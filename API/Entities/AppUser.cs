using System.Collections.Generic;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }  

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string Name {get; set;}

        public string Email {get; set;}

        public string Bio {get; set;}

        public string Facebook {get; set;}

        public string Instagram {get; set;}

        public string Linkedin {get; set;}

        public string Twitter {get; set;}

        public string ProfilePictureUrl {get; set;}

        public virtual ICollection<GameUser> GamesMade {get; set;}

    }
}