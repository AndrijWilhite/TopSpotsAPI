using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.IO;
using Newtonsoft.Json;
using TopSpots.Models;

namespace TopSpots.Controllers
{
    public class TopSpotsController : ApiController
    {
        [HttpGet, Route("api/topspots")]
        public IHttpActionResult GetAllTopSpots()
        {
            string topSpots = File.ReadAllText("C:\\Users\\andrij\\dev\\TopSpotsAPI\\topspots.json");

            TopSpot[] topSpotsArray = JsonConvert.DeserializeObject<TopSpot[]>(topSpots);

            return Ok(topSpotsArray);
        }
        [HttpPost]
        public IHttpActionResult PostTopSpot(TopSpot topSpot)
        {
            string topSpots = File.ReadAllText("C:\\Users\\andrij\\dev\\TopSpotsAPI\\topspots.json");

            TopSpot[] topSpotsArray = JsonConvert.DeserializeObject<TopSpot[]>(topSpots);

            List<T> 

            topSpots = JsonConvert.SerializeObject(topSpotsArray);

            File.WriteAllText("C:\\Users\\andrij\\dev\\TopSpotsAPI\\topspots.json", topSpots);
        }
    }
}
