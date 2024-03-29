using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Extenxions;

namespace API.entities
{
    public class AppUser
    {
        public int Id{get; set;}
        public string UserName{get; set;}
        public byte[] PasswordHasd {get; set;}
        public byte[] PassswordSalt {get; set;}
        public DateTime DateOFBirth{get; set;}
        public string KnownAs{get; set;}
        public DateTime Created{get; set;} = DateTime.Now;
        public DateTime LastActive {get; set;} =DateTime.Now;
        public string Gender{get; set;}
        public string  Introduction{get; set;}
        public string LookingFor{get; set;}
        public string Interests{ get; set;}
        public string City{get; set;}
        public string Country{get; set;}
        public ICollection<Photo> Photos{get; set;}

        public int GetAge(){
            return DateOFBirth.CaculateAge();
        }



        
    }
}