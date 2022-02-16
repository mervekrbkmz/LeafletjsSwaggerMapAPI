namespace LeafletExample.Models
{
    public class Marker
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Poi Geometry { get; set; }
    }
    //Input yerıne request de kullanılır
    public class MarkerRequest
    {
        public int Id { get; set; } 

    }
    //response olarakda kullanılır
    public class MarkerResponse
    {
        public string Name { get; set; }
    }
}
