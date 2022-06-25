using BackEnd.DTO;
using BackEnd.Managers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotiziaController : ControllerBase
    {
        private readonly NotiziaManager _manager;

        public NotiziaController(NotiziaManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()       
        {
            return Ok(_manager.GetAll());
        }

        [HttpGet]
        [Authorize]
        [Route("GetSingle/{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(_manager.GetSingle(id));
        }

        [HttpPost]
        [Authorize]
        [Route("Add")]
        public IActionResult Add(NotiziaDTO notiziadto)
        {
            return Ok(_manager.Add(notiziadto));
        }

        [HttpPut]
        [Authorize]
        [Route("Update")]
        public IActionResult Update(NotiziaDTO notiziadto)
        {
            return Ok(_manager.Update(notiziadto));
        }

        [HttpPut]
        [Authorize]
        [Route("SetVisible/{id}")]
        public IActionResult SetVisible(int id)
        {
            return Ok(_manager.SetVisible(id));
        }

        [HttpPut]
        [Authorize]
        [Route("SetInvisible/{id}")]
        public IActionResult SetInvisible(int id)
        {
            return Ok(_manager.SetInvisible(id));
        }

        [HttpPut]
        [Authorize]
        [Route("PutIntoRecycleBin/{id}")]
        public IActionResult PutIntoRecycleBin(int id)
        {
            return Ok(_manager.PutIntoRecycleBin(id));
        }

        [HttpPut]
        [Authorize]
        [Route("RemoveFromRecycleBin/{id}")]
        public IActionResult RemoveFromRecycleBin(int id)
        {
            return Ok(_manager.RemoveFromRecycleBin(id));
        }

        [HttpDelete]
        [Authorize]
        [Route("Delete/{id}")]
        public IActionResult Delete (int id)
        {
            return Ok(_manager.Delete(id));
        }
    }
}
