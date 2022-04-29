using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ads.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Ads.Controllers
{
    public class TusersController : Controller
    {
        private readonly POSTADSContext _context;

        public object Helper { get; private set; }

        public TusersController(POSTADSContext context)
        {
            _context = context;
        }

        // GET: Tusers
        public async Task<IActionResult> Index()
        {
            var pOSTADSContext = _context.Tusers.Include(t => t.IdRolNavigation);
            return View(await pOSTADSContext.ToListAsync());
        }

        // GET: Tusers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tuser = await _context.Tusers
                .Include(t => t.IdRolNavigation)
                .FirstOrDefaultAsync(m => m.IdUsers == id);
            if (tuser == null)
            {
                return NotFound();
            }

            return View(tuser);
        }

        // GET: Tusers/Create
        public IActionResult Create()
        {
            ViewData["IdRol"] = new SelectList(_context.Roles, "IdRol", "IdRol");
            return View();
        }

        // POST: Tusers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsers,Username,Pass,IdRol")] Tuser tuser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tuser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdRol"] = new SelectList(_context.Roles, "IdRol", "IdRol", tuser.IdRol);
            return View(tuser);
        }

        // GET: Tusers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tuser = await _context.Tusers.FindAsync(id);
            if (tuser == null)
            {
                return NotFound();
            }
            ViewData["IdRol"] = new SelectList(_context.Roles, "IdRol", "IdRol", tuser.IdRol);
            return View(tuser);
        }

        // POST: Tusers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUsers,Username,Pass,IdRol")] Tuser tuser)
        {
            if (id != tuser.IdUsers)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tuser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TuserExists(tuser.IdUsers))
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
            ViewData["IdRol"] = new SelectList(_context.Roles, "IdRol", "IdRol", tuser.IdRol);
            return View(tuser);
        }

        // GET: Tusers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            

            var tuser = await _context.Tusers
                .Include(t => t.IdRolNavigation)
                .FirstOrDefaultAsync(m => m.IdUsers == id);
            if (tuser == null)
            {
                return NotFound();
            }

            return View(tuser);
        }

        // POST: Tusers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tuser = await _context.Tusers.FindAsync(id);
            _context.Tusers.Remove(tuser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Iniciar(Tuser tuser, string usuario, string contra)
        {
            //string pass = Helper.EncodePassword(contra);
            var objusu = (from a in _context.Tusers where a.Username == usuario && a.Pass == contra select a).FirstOrDefault();
            if (objusu != null)
            {

                HttpContext.Session.SetString("usuariodata", JsonConvert.SerializeObject(objusu.Username));
                HttpContext.Session.SetString("usuarioidrec", JsonConvert.SerializeObject(objusu.IdUsers));
                HttpContext.Session.SetString("roluser", JsonConvert.SerializeObject(objusu.IdRol));
                //HttpContext.Session.SetString("rol", JsonConvert.SerializeObject(objusu.IdRolNavigation.DescripcionRol));
                //HttpContext.Session.SetString("tuser", JsonConvert.SerializeObject(tuser));

                //Redirecionamiento del vistas
                if (objusu.IdRol == 2)
                {
                    return RedirectToAction("Index", "Anuncios");
                }
                //var duser = JsonConvert.DeserializeObject<Tuser>(HttpContext.Session.GetString("usuariodata"));
                //ViewBag.nick = duser;

                return RedirectToAction("Index", "Anuncios");
            }
            return RedirectToAction("Index", "Anuncios");
        }

        [HttpPost]
        public async Task<IActionResult> RegistrarAsync(Tuser tuser, string usernew, string passnew)
        {
            //string pass = Helper.EncodePassword(contra);
            var usergg = new Tuser
            {
                IdUsers = tuser.IdUsers,
                Username = usernew,
                Pass = passnew,
                IdRol = 1
                

            };
            _context.Add(usergg);
            await  _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Desconectarse()
        {

            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Anuncios");
        }
        public async Task<IActionResult> Login()
        {

            return RedirectToAction(nameof(Login));
        }

        private bool TuserExists(int id)
        {
            return _context.Tusers.Any(e => e.IdUsers == id);
        }
    }
}
