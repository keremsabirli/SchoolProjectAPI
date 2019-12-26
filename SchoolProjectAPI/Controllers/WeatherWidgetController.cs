using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProjectAPI.DTOs;
using SchoolProjectAPI.Models;
using SchoolProjectAPI.Wrappers.IWrappers;

namespace SchoolProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherWidgetController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public WeatherWidgetController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<LiteWeatherWidgetDTO>> Get()
        {
            return Ok(mapper.Map<IEnumerable<LiteWeatherWidgetDTO>>(repoWrapper.WeatherWidget.Get()).ToList());
        }
        [HttpGet("{id}", Name = "GetWeatherWidgetById")]
        public ActionResult<WeatherWidgetDTO> Get(long id)
        {
            return Ok(mapper.Map<WeatherWidgetDTO>(repoWrapper.WeatherWidget.Get(id)));
        }
        [HttpPost]
        public ActionResult Post([FromBody] LiteWeatherWidgetDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.WeatherWidget.Insert(mapper.Map<WeatherWidget>(value));
            repoWrapper.Save();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Put(long id, [FromBody] LiteWeatherWidgetDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Value with the given id doesn't exist.");
            var entity = repoWrapper.WeatherWidget.Get(id);
            if (entity == null) return BadRequest("Value with the given id is null");
            mapper.Map(value, entity);
            repoWrapper.Save();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var entity = repoWrapper.WeatherWidget.Get(id);
            if (entity == null) return BadRequest("Value with the given id is null");
            repoWrapper.WeatherWidget.Delete(entity);
            repoWrapper.Save();
            return Ok();
        }
    }
}