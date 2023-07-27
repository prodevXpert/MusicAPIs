﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicAPIs.Models;

namespace MusicAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private static List<Song> songs = new List<Song>()
        {
            new Song(){Id=1,Title="Willow",Language="English"},
            new Song(){Id=2,Title="Hello",Language="English"},
        };
        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return songs;
        }
        [HttpPost]
        public void Post([FromBody]Song song)
        {
            songs.Add(song);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Song song)
        {
            songs[id] = song;
        }

        [HttpDelete("{id}")]
        
        public void Delete(int id)
        {
            songs.RemoveAt(id);
        }
    }
}