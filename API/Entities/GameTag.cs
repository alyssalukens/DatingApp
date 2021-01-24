namespace API.Entities
{
    public class GameTag
    {
        public int Id { get; set; }
         public virtual Tag Tag {get; set;}
         public virtual Game Game {get; set;}
    }
}