﻿using CarWorkshop.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarWorkshopMvc.Controllers
{
    public class CarWorkshopController : Controller
    {
        private readonly ICarWorkshopService _carWorkshopService;

        public CarWorkshopController(ICarWorkshopService carWorkshopService)
        {
            _carWorkshopService = carWorkshopService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarWorkshop.Domain.Entities.CarWorkshop carWorkshop) 
        {
            await _carWorkshopService.CreateAsync(carWorkshop);
            return RedirectToAction(nameof(Create)); // To do refactor
        }
    }
}