﻿namespace MiniEcommerceServer.Application.DTOs.User
{
    public class CreateUser
    {
        public string NameSurname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
    }
}
