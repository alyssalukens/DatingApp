namespace API.Entities
{
    public class GameImage
    {
        public int Id {get; set;}
         public virtual Game Game {get; set;}
        public string GameImageUrl {get; set;}
    }
}