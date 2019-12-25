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
    public class WidgetController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public WidgetController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<LiteWidgetDTO>> Get()
        {
            return Ok(mapper.Map<IEnumerable<LiteWidgetDTO>>(repoWrapper.Widget.Get()).ToList());
        }
        [HttpGet("{id}", Name = "GetWidgetById")]
        public ActionResult<WidgetDTO> Get(long id)
        {
            return Ok(mapper.Map<WidgetDTO>(repoWrapper.Widget.Get(id)));
        }
        [HttpPost]
        public ActionResult Post([FromBody] LiteWidgetDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.Widget.Insert(mapper.Map<Widget>(value));
            repoWrapper.Save();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Put(long id, [FromBody] LiteWidgetDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Value with the given id doesn't exist.");
            var entity = repoWrapper.Widget.Get(id);
            if (entity == null) return BadRequest("Value with the given id is null");
            mapper.Map(value, entity);
            repoWrapper.Save();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            Widget entity = repoWrapper.Widget.Get(id);
            if (entity == null) return BadRequest("Value with the given id is null");
            repoWrapper.Widget.Delete(entity);
            repoWrapper.Save();
            return Ok();
        }
    }
}