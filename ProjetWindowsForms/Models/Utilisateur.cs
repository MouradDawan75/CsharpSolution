using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetWindowsForms.Models
{
    public class Utilisateur
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public bool Admin { get; set; }

        public Utilisateur() { }

        public Utilisateur(string email, string password, string photo, bool admin)
        {
            Email = email;
            Password = password;
            Photo = photo;
            Admin = admin;
        }

        public override string ToString()
        {
            return $"Email: {Email} Admin: {Admin}";
        }
    }
}
