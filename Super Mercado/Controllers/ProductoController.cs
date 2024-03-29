﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Super_Mercado.Services;
using Super_Mercado.Models;


namespace Super_Mercado.Controllers
{
    public class ProductoController : Controller
    {
        private readonly Super_mercadoService _service;
        public IActionResult Index()
        {
            var productos = _service.GetAll();
            return View(productos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                Producto result = await _service.Create(producto);
                if (result != null)
                {
                    return View(result);
                }
            }
            return RedirectToAction(nameof(Create));
        }

        [HttpGet]
        public IActionResult Update(long? Id)
        {
            if (Id != null)
            {
                Producto result = _service.GetById(Id).Result;
                if (result != null)
                {
                    return View(result);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Producto producto)
        {
            if (ModelState.IsValid)
            {
                Producto result = await _service.Update(producto);
                if (result != null)
                {
                    return View(producto + "" + "El producto ha sido modificado");
                }
            }

            return View(null);
        }
    }
}