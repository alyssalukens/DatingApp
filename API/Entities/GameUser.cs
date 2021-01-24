namespace API.Entities
{
    public class GameUser
    {
        public int Id { get; set; }
        public virtual Game Game {get; set;}
        public virtual AppUser User {get; set;}
    }
}