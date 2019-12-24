using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolProjectAPI.DTOs;
using SchoolProjectAPI.Models;
using SchoolProjectAPI.Wrappers.IWrappers;
using System.Collections.Generic;

namespace SchoolProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonWidgetController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public PersonWidgetController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<PersonWidgetDTO>> Get()
        {
            return Ok(mapper.Map<IEnumerable<PersonWidgetDTO>>(repoWrapper.PersonWidget.Get()));
        }
        [HttpGet("{id}", Name = "GetPersonWidgetById")]
        public ActionResult<PersonWidgetDTO> Get(long id)
        {
            return Ok(mapper.Map<PersonWidgetDTO>(repoWrapper.PersonWidget.Get(id)));
        }
        [HttpPost]
        public ActionResult Post([FromBody]PersonWidgetDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.PersonWidget.Insert(mapper.Map<PersonWidget>(value));
            repoWrapper.Save();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Put(long id, [FromBody] PersonWidgetDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Value with the given id doesn't exist.");
            var entity = repoWrapper.PersonWidget.Get(id);
            if (entity == null) return BadRequest("Value with the given id is null");
            mapper.Map(value, entity);
            repoWrapper.Save();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            PersonWidget entity = repoWrapper.PersonWidget.Get(id);
            if (entity == null) return BadRequest("Value with the given id is null");
            repoWrapper.PersonWidget.Delete(entity);
            repoWrapper.Save();
            return Ok();
        }
    }
}