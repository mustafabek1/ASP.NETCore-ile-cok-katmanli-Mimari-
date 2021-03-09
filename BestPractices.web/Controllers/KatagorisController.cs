using AutoMapper;
using BestPracticeProject.Core.Models;
using BestPracticeProject.Core.Service;
using BestPracticesProject.web.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPractices.web.Controllers
{
    public class KatagorisController : Controller
    {
        private readonly IKatagoriService _katagoriService;
        private readonly IMapper _mapper;

        public KatagorisController(IKatagoriService katagoriService, IMapper mapper)
        {
            _katagoriService = katagoriService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var katagoris = await _katagoriService.GetAllAsync();


            return View(_mapper.Map<IEnumerable<KatagoriDto>>(katagoris));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(KatagoriDto katagoriDto)
        {
            await _katagoriService.AddAsync(_mapper.Map<Katagori>(katagoriDto));

            return RedirectToAction("Index");
        }

    }
}
