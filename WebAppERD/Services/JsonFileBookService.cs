using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WebAppERD.Model;

namespace WebAppERD.Services
{

    //due to change in enviroment setup we did this env CODE
    // like ? //wwwroot//Data>>Book.json
    //      this is maybe diffrent for Linux Windows Mac
    public class JsonFileBookService
    {
        //  get  jsonfile to this program & address of file
        //khud file ka root generate kery gah!!

        //variable for HOME/ root dir/
        //gen file address
        // file handiling

        // by default it has get setter method
        //contructor JsonFileBookServices is var ko set kry gah and Env ly gha
        public IWebHostEnvironment WebHostEnvironment { get; set; }

        //actual hosting envirnment
        public JsonFileBookService(IWebHostEnvironment WebHostEnvironment)
        {
            WebHostEnvironment = WebHostEnvironment;
        }

        public string fileAddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "books.json");
            }
        }

        //IEnumerable is list: contain Term and Description
        //id = 1 ; id is term and 1 desc
        // List =Array
        public IEnumerable<Book> getBookRecord()

        {
            //this will get file and store in fileStram
            // using: mean if this file is opening then do this in using{ --- in this code--- }
            using (var fileStream = File.OpenText(fileAddress))
            {
                //string data in this
                //fileStream.ReadToEnd();
                // now we have to convert in address variable

                //automatic list ma bna dy gah or obj ma save kr dy gah???
                //>>>ya ab data ly rha json file sa and string ma store kr rha after this data ko seperate kr rha jis trha humny consol ma \t ki base py seprate kr rhy thy and bad ma in ko hum int, and string dataype ma rkh rhy thyy
                return JsonSerializer.Deserialize<Book[]>(fileStream.ReadToEnd());

            }

        }




    }
}
