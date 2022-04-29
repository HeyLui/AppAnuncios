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
    public class PuntajeUserAdsController : Controller
    {
        private readonly POSTADSContext _context;

        public PuntajeUserAdsController(POSTADSContext context)
        {
            _context = context;
        }

        // GET: PuntajeUserAds
        public async Task<IActionResult> Index()
        {
            var pOSTADSContext = _context.PuntajeUserAds.Include(p => p.IdAdNavigation).Include(p => p.IdUsersNavigation);
            return View(await pOSTADSContext.ToListAsync());
        }

        // GET: PuntajeUserAds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puntajeUserAd = await _context.PuntajeUserAds
                .Include(p => p.IdAdNavigation)
                .Include(p => p.IdUsersNavigation)
                .FirstOrDefaultAsync(m => m.Idpuntajeusuario == id);
            if (puntajeUserAd == null)
            {
                return NotFound();
            }

            return View(puntajeUserAd);
        }

        // GET: PuntajeUserAds/Create
        public IActionResult Create()
        {
            ViewData["IdAd"] = new SelectList(_context.Anuncios, "IdAd", "IdAd");
            ViewData["IdUsers"] = new SelectList(_context.Tusers, "IdUsers", "IdUsers");
            return View();
        }

        // POST: PuntajeUserAds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idpuntajeusuario,IdUsers,IdAd,Puntaje")] PuntajeUserAd puntajeUserAd)
        {
            if (ModelState.IsValid)
            {
                _context.Add(puntajeUserAd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdAd"] = new SelectList(_context.Anuncios, "IdAd", "IdAd", puntajeUserAd.IdAd);
            ViewData["IdUsers"] = new SelectList(_context.Tusers, "IdUsers", "IdUsers", puntajeUserAd.IdUsers);
            return View(puntajeUserAd);
        }

        // GET: PuntajeUserAds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puntajeUserAd = await _context.PuntajeUserAds.FindAsync(id);
            if (puntajeUserAd == null)
            {
                return NotFound();
            }
            ViewData["IdAd"] = new SelectList(_context.Anuncios, "IdAd", "IdAd", puntajeUserAd.IdAd);
            ViewData["IdUsers"] = new SelectList(_context.Tusers, "IdUsers", "IdUsers", puntajeUserAd.IdUsers);
            return View(puntajeUserAd);
        }

        // POST: PuntajeUserAds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idpuntajeusuario,IdUsers,IdAd,Puntaje")] PuntajeUserAd puntajeUserAd)
        {
            if (id != puntajeUserAd.Idpuntajeusuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(puntajeUserAd);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PuntajeUserAdExists(puntajeUserAd.Idpuntajeusuario))
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
            ViewData["IdAd"] = new SelectList(_context.Anuncios, "IdAd", "IdAd", puntajeUserAd.IdAd);
            ViewData["IdUsers"] = new SelectList(_context.Tusers, "IdUsers", "IdUsers", puntajeUserAd.IdUsers);
            return View(puntajeUserAd);
        }

        // GET: PuntajeUserAds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puntajeUserAd = await _context.PuntajeUserAds
                .Include(p => p.IdAdNavigation)
                .Include(p => p.IdUsersNavigation)
                .FirstOrDefaultAsync(m => m.Idpuntajeusuario == id);
            if (puntajeUserAd == null)
            {
                return NotFound();
            }

            return View(puntajeUserAd);
        }

        // POST: PuntajeUserAds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var puntajeUserAd = await _context.PuntajeUserAds.FindAsync(id);
            _context.PuntajeUserAds.Remove(puntajeUserAd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PuntajeUserAdExists(int id)
        {
            return _context.PuntajeUserAds.Any(e => e.Idpuntajeusuario == id);
        }
    }
}
