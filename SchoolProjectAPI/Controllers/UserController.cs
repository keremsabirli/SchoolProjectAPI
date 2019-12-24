using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolProjectAPI.DTOs;
using SchoolProjectAPI.Models;
using SchoolProjectAPI.Wrappers.IWrappers;
using System.Collections.Generic;
using System.Linq;

namespace SchoolProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IRepositoryWrapper repoWrapper;
        private IMapper mapper;
        public UserController(IRepositoryWrapper repoWrapper, IMapper mapper)
        {
            this.repoWrapper = repoWrapper;
            this.mapper = mapper;
        }
        [HttpGet]
        public ActionResult<List<UserDTO>> Get()
        {
            return Ok(mapper.Map<IEnumerable<UserDTO>>(repoWrapper.User.Get()).ToList());
        }
        [HttpGet("{id}", Name = "GetUserById")]
        public ActionResult<UserDTO> Get(long id)
        {
            return Ok(mapper.Map<UserDTO>(repoWrapper.User.Get(id)));
        }
        [HttpPost]
        public ActionResult Post([FromBody]UserDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (value == null) return BadRequest();
            repoWrapper.User.Insert(mapper.Map<User>(value));
            repoWrapper.Save();
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Put(long id, [FromBody] UserDTO value)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (id != value.Id) return BadRequest("Value with the given id doesn't exist.");
            var entity = repoWrapper.User.Get(id);
            if (entity == null) return BadRequest("Value with the given id is null");
            mapper.Map(value, entity);
            repoWrapper.Save();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            User entity = repoWrapper.User.Get(id);
            if (entity == null) return BadRequest("Value with the given id is null");
            repoWrapper.User.Delete(entity);
            repoWrapper.Save();
            return Ok();
        }
    }
}