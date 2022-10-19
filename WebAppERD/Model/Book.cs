using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebAppERD.Model
{
   // this class will be use as to store  string data in INTO Json formate in json.file
    public class Book
    {

        //this is used for to get into Jsonfile attribues of entitiy
        //by defualt it gets same as in Json file but if want to use Book_id instead of id 
        //then we ude JsonPropertyName... concept
        [JsonPropertyName("id")]
        public int book_id
        {
            get; set;
        }
        [JsonPropertyName("name")]
        public int name
        {
            get; set;
        }
        [JsonPropertyName("image")]
        public int image
        {
            get; set;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Book>(this);
        }

    }
}
