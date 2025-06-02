using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using MiniEcommerceServer.Application.Abstractions.Services.Configurations;
using MiniEcommerceServer.Application.CustomAttributes;
using MiniEcommerceServer.Application.DTOs.Configuration;
using MiniEcommerceServer.Application.Enums;
using System.Reflection;
using Action = MiniEcommerceServer.Application.DTOs.Configuration.Action;

namespace MiniEcommerceServer.Infrastructure.Services.Configurations
{
    public class ApplicationService : IApplicationService
    {
        public List<Menu> GetAuthorizeDefinitionEndpints(Type type)
        {
            Assembly? assembly = Assembly.GetAssembly(type);
            if (assembly == null)
                return new List<Menu>();

            IEnumerable<Type> controllers = assembly.GetTypes()
                .Where(t => typeof(ControllerBase).IsAssignableFrom(t))
                .ToList();

            List<Menu> menus = new List<Menu>();

            foreach (var controller in controllers)
            {
                IEnumerable<MethodInfo> actions = controller.GetMethods()
                    .Where(m => m.IsDefined(typeof(AuthorizeDefinitionAttribute), inherit: true))
                    .ToList();

                foreach (var action in actions)
                {
                    AuthorizeDefinitionAttribute? authorizeDefinitionAttribute = action
                        .GetCustomAttributes(typeof(AuthorizeDefinitionAttribute), inherit: true)
                        .FirstOrDefault() as AuthorizeDefinitionAttribute;

                    if (authorizeDefinitionAttribute == null)
                        continue;

                    Menu? menu = menus.FirstOrDefault(m => m.Name == authorizeDefinitionAttribute.Menu);
                    if (menu == null)
                    {
                        menu = new Menu { Name = authorizeDefinitionAttribute.Menu };
                        menus.Add(menu);
                    }

                    HttpMethodAttribute? httpAttribute = action
                        .GetCustomAttributes()
                        .FirstOrDefault(a => a is HttpMethodAttribute) as HttpMethodAttribute;

                    String httpMethod = httpAttribute?.HttpMethods.FirstOrDefault() ?? HttpMethods.Get;

                    Action actionDto = new()
                    {
                        ActionType = Enum.GetName(typeof(ActionType), authorizeDefinitionAttribute.ActionType) ?? string.Empty,
                        Definition = authorizeDefinitionAttribute.Definition,
                        HttpType = httpMethod,
                        Code = $"{httpMethod}.{Enum.GetName(typeof(ActionType), authorizeDefinitionAttribute.ActionType) ?? string.Empty}.{authorizeDefinitionAttribute.Definition.Replace(" ", "")}"
                    };

                    menu.Actions.Add(actionDto);
                }
            }

            return menus;
        }
    }
}
