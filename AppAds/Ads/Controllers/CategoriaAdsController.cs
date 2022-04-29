using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ads.Models;

namespace Ads.Controllers
{
    public class CategoriaAdsController : Controller
    {
        private readonly POSTADSContext _context;

        public CategoriaAdsController(POSTADSContext context)
        {
            _context = context;
        }

        // GET: CategoriaAds
        public async Task<IActionResult> Index()
        {
            return View(await _context.CategoriaAds.ToListAsync());
        }

        // GET: CategoriaAds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaAd = await _context.CategoriaAds
                .FirstOrDefaultAsync(m => m.IdTipoad == id);
            if (categoriaAd == null)
            {
                return NotFound();
            }

            return View(categoriaAd);
        }

        // GET: CategoriaAds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoriaAds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoad,CategoriaName")] CategoriaAd categoriaAd)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoriaAd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaAd);
        }

        // GET: CategoriaAds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaAd = await _context.CategoriaAds.FindAsync(id);
            if (categoriaAd == null)
            {
                return NotFound();
            }
            return View(categoriaAd);
        }

        // POST: CategoriaAds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdTipoad,CategoriaName")] CategoriaAd categoriaAd)
        {
            if (id != categoriaAd.IdTipoad)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoriaAd);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaAdExists(categoriaAd.IdTipoad))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaAd);
        }

        // GET: CategoriaAds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaAd = await _context.CategoriaAds
                .FirstOrDefaultAsync(m => m.IdTipoad == id);
            if (categoriaAd == null)
            {
                return NotFound();
            }

            return View(categoriaAd);
        }

        // POST: CategoriaAds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoriaAd = await _context.CategoriaAds.FindAsync(id);
            _context.CategoriaAds.Remove(categoriaAd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaAdExists(int id)
        {
            return _context.CategoriaAds.Any(e => e.IdTipoad == id);
        }
    }
}
