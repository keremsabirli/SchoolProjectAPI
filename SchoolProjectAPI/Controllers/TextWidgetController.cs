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
    public class TextWidgetController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public TextWidgetController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<LiteTextWidgetDTO>> Get()
        {
            return Ok(mapper.Map<IEnumerable<LiteTextWidgetDTO>>(repoWrapper.PersonWidget.Get()).ToList());
        }
        [HttpGet("{id}", Name = "GetTextWidgetById")]
        public ActionResult<TextWidgetDTO> Get(long id)
        {
            return Ok(mapper.Map<TextWidgetDTO>(repoWrapper.TextWidget.Get(id)));
        }
        [HttpPost]
        public ActionResult Post([FromBody]TextWidgetDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.TextWidget.Insert(mapper.Map<TextWidget>(value));
            repoWrapper.Save();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Put(long id, [FromBody] TextWidgetDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Value with the given id doesn't exist.");
            var entity = repoWrapper.TextWidget.Get(id);
            if (entity == null) return BadRequest("Value with the given id is null");
            mapper.Map(value, entity);
            repoWrapper.Save();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            var entity = repoWrapper.TextWidget.Get(id);
            if (entity == null) return BadRequest("Value with the given id is null");
            repoWrapper.TextWidget.Delete(entity);
            repoWrapper.Save();
            return Ok();
        }
    }
}