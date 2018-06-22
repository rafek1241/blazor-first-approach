using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazorfirststandaloneapplication.shared.Models
{
    public class User
    {
        public User(string password, string login, string surname, string name)
        {
            Password = password;
            Login = login;
            Surname = surname;
            Name = name;
        }

        public long UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Login { get; }

        public string Password { get; set; } //set for changing password

        public virtual ICollection<PortfolioCard> PortfolioCards { get; set; }
    }
}
