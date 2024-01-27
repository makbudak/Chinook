﻿using Chinook.Service;
using Microsoft.AspNetCore.Mvc;

namespace Chinook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        private readonly IMenuItemService _menuItemService;
        public MenuItemController(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        [HttpGet("GetByMenuId/{id}")]
        public IActionResult GetByMenuId(int id)
        {
            var list = _menuItemService.GetByMenuId(id);
            return Ok(list);
        }
    }
}