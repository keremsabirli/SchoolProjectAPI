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
    public class UserWidgetController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public UserWidgetController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<UserWidgetDTO>> Get()
        {
            return Ok(mapper.Map<IEnumerable<UserWidgetDTO>>(repoWrapper.UserWidget.Get()));
        }
        [HttpGet("{id}", Name = "GetUserWidgetById")]
        public ActionResult<WidgetDTO> Get(long id)
        {
            return Ok(mapper.Map<UserWidgetDTO>(repoWrapper.UserWidget.Get(id)));
        }
        [HttpPost]
        public ActionResult Post([FromBody]UserWidgetDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.UserWidget.Insert(mapper.Map<UserWidget>(value));
            repoWrapper.Save();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Put(long id, [FromBody] UserWidgetDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Value with the given id doesn't exist.");
            var entity = repoWrapper.UserWidget.Get(id);
            if (entity == null) return BadRequest("Value with the given id is null");
            mapper.Map(value, entity);
            repoWrapper.Save();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            UserWidget entity = repoWrapper.UserWidget.Get(id);
            if (entity == null) return BadRequest("Value with the given id is null");
            repoWrapper.UserWidget.Delete(entity);
            repoWrapper.Save();
            return Ok();
        }
    }
}