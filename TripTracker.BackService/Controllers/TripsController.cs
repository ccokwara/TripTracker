using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TripTracker.BackService.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class TripsController : ControllerBase
    {
        private Models.Repository _repository;

        public TripsController(Models.Repository repository)
        {
            _repository = repository;
        }

        // Get api/trips
        [HttpGet]
        public IEnumerable<Models.Trip> Get()
        {
            return _repository.Get();
        }


        //Get api/trips/id
        [HttpGet("{id}")]
        public Models.Trip Get(int Id)
        {
            return _repository.Get(Id);
        }

        //Post apt/trips
        [HttpPost]
        public void Post([FromBody] Models.Trip value)
        {
            _repository.Add(value);
        }


        //Put api/trips/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Models.Trip value)
        {
            _repository.Update(value);
        }

        //Delete api/trips/id
        [HttpDelete ("{id}")]
        public void Delete(int id)
        {
            _repository.Remove(id);
        }
    }
}