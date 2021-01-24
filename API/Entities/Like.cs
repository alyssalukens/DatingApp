namespace API.Entities
{
    public class Like
    {
        public int Id { get; set; }
        public virtual AppUser User {get; set;}
        public virtual Game Game {get; set;}
    }
}