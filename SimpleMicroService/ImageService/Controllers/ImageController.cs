using ImageService.CommandsAndQueries.Commands;
using ImageService.CommandsAndQueries.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ImageService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ImageController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: ImageController
        [HttpPost]
        public async Task<IActionResult> Create(AddImage command)
        {
            var result = await _mediator.Send(command);
            if (string.IsNullOrWhiteSpace(result))
                return NotFound("Not found");
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new ListAllImages()));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _mediator.Send(new GetImagsById { Id = id }));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await _mediator.Send(new DeleteImage { Id = id }));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateImage command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }
    }
}
