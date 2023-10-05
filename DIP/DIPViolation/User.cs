﻿namespace SOLID.DIP.ISPViolation
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User(int id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
        public override string ToString()
        {
            return $"User{{id={Id}, userName='{Name}', pswd='{Password}'}}"; ;
        }
    }
}
