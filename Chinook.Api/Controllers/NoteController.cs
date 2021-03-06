using Chinook.Model.Helpers;
using Chinook.Model.Models;
using Chinook.Service;
using Chinook.Service.Attributes;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Chinook.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class NoteController : ControllerBase
    {
        public readonly INoteService noteService;
        public NoteController(INoteService noteService)
        {
            this.noteService = noteService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = noteService.GetAll();
            return Ok(list);
        }

        [HttpGet("GetByCategoryId/{categoryId:int}")]
        public IActionResult GetByCategoryId(int categoryId)
        {
            var list = noteService.GetByCategoryId(categoryId);
            return Ok(list);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NoteModel model)
        {
            try
            {
                var result = noteService.Post(model);
                return StatusCode((int)result.StatusCode, result.CreateReturnModel());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServiceResult { Message = ex.Message });
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] NoteModel model)
        {
            try
            {
                var result = noteService.Put(model);
                return StatusCode((int)result.StatusCode, result.CreateReturnModel());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServiceResult { Message = ex.Message });
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = noteService.Delete(id);
                return StatusCode((int)result.StatusCode, result.CreateReturnModel());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServiceResult { Message = ex.Message });
            }
        }

        [HttpPut("move")]
        public IActionResult Move([FromBody] NoteModel model)
        {
            try
            {
                var result = noteService.Move(model);
                return StatusCode((int)result.StatusCode, result.CreateReturnModel());
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServiceResult { Message = ex.Message });
            }
        }
    }
}