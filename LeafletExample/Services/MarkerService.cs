
using LeafletExample.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LeafletExample.Services
{
    public class MarkerService
    {
        MarkerService _markerService;

     

        public bool SaveMarker(Marker markerSave)
        {
           
            List<Marker> mark= new List<Marker>();
            try
            {
               
                var client = new MongoClient("mongodb://localhost:27017");

                var database = client.GetDatabase("Test");

                var collection = database.GetCollection<BsonDocument>("TestCollection");
              
                collection.InsertOne(markerSave.ToBsonDocument());
              
                return true;

              
            }
            catch (Exception)
            {
                return false;
            }
         
        }
    }
}
