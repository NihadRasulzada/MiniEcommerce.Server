// System
global using System.Text;

// API Configurations & Extensions
global using MiniEcommerceServer.API.Configurations.ColumnWriters;
global using MiniEcommerceServer.API.Extensions;
global using MiniEcommerceServer.API.Middlewares;

// Application Layer - Core
global using MiniEcommerceServer.Application;
global using MiniEcommerceServer.Application.Abstractions.Services;
global using MiniEcommerceServer.Application.Consts;
global using MiniEcommerceServer.Application.CustomAttributes;
global using MiniEcommerceServer.Application.Enums;

// Application - User Commands
global using MiniEcommerceServer.Application.Features.Commands.AppUser.CreateUser;
global using MiniEcommerceServer.Application.Features.Commands.AppUser.FacebookLogin;
global using MiniEcommerceServer.Application.Features.Commands.AppUser.GoogleLogin;
global using MiniEcommerceServer.Application.Features.Commands.AppUser.LoginUser;
global using MiniEcommerceServer.Application.Features.Commands.AppUser.RefreshTokenLogin;
global using MiniEcommerceServer.Application.Features.Commands.AppUser.UpdatePassword;

// Application - Product Commands
global using MiniEcommerceServer.Application.Features.Commands.Product.CreateProduct;
global using MiniEcommerceServer.Application.Features.Commands.Product.RemoveProduct;
global using MiniEcommerceServer.Application.Features.Commands.Product.UpdateProduct;

// Application - Product Image Commands
global using MiniEcommerceServer.Application.Features.Commands.ProductImageFile.ChangeShowcaseImage;
global using MiniEcommerceServer.Application.Features.Commands.ProductImageFile.RemoveProductImage;
global using MiniEcommerceServer.Application.Features.Commands.ProductImageFile.UploadProductImage;

// Application - Product Queries
global using MiniEcommerceServer.Application.Features.Queries.Product.GetAllProduct;
global using MiniEcommerceServer.Application.Features.Queries.Product.GetByIdProduct;
global using MiniEcommerceServer.Application.Features.Queries.ProductImageFile.GetProductImages;

// Application - Basket Commands & Queries
global using MiniEcommerceServer.Application.Features.Commands.Basket.AddItemToBasket;
global using MiniEcommerceServer.Application.Features.Commands.Basket.RemoveBasketItem;
global using MiniEcommerceServer.Application.Features.Commands.Basket.UpdateQuantity;
global using MiniEcommerceServer.Application.Features.Queries.Basket.GetBasketItems;

// Application - Order Commands & Queries
global using MiniEcommerceServer.Application.Features.Commands.Order.CompleteOrder;
global using MiniEcommerceServer.Application.Features.Commands.Order.CreateOrder;
global using MiniEcommerceServer.Application.Features.Queries.Order.GetAllOrders;
global using MiniEcommerceServer.Application.Features.Queries.Order.GetOrderById;

// Application - Validators
global using MiniEcommerceServer.Application.Validators.Products;

// Infrastructure Layer
global using MiniEcommerceServer.Infrastructure;
global using MiniEcommerceServer.Infrastructure.Filters;
global using MiniEcommerceServer.Infrastructure.Services.Storage.Local;

// Persistence Layer
global using MiniEcommerceServer.Persistence;

// SignalR
global using MiniEcommerceServer.SignalR;
