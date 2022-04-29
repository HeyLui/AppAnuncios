using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ads.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Ads.Controllers
{
    public class AnunciosController : Controller
    {
        private readonly POSTADSContext _context;

        public AnunciosController(POSTADSContext context)
        {
            _context = context;
        }

        // GET: Anuncios
        public async Task<IActionResult> Index()
        {
            //27 / 7 = 3.85 

            var promedio = _context.Anuncios.Select(a => a.Calificacion).Count();

            var cantidad = _context.Tusers.Select(b => b.IdUsers).Count();
            var total = promedio / cantidad;
            var estrella = 100 / total;
            ViewBag.estrellas = estrella;

            //SUMA DE VOTOS ENTRE NUMERO DE USUARIOS

            


            var pOSTADSContext = _context.Anuncios.Include(a => a.IdTipoadNavigation);
            //Tuser loginsession = new Tuser();
            //if (HttpContext.Session.GetString("loginsession")!= null)
            //{
            //    var x = HttpContext.Session.GetString("loginsession");
            //    loginsession = JsonConvert.DeserializeObject<Tuser>(x);
            //}
            //ViewBag.nombre = HttpContext.Session.GetString("name") == null ? "NA": HttpContext.Session.GetString("name").ToString();
            return View(await pOSTADSContext.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Index(string buscador, string opcion, string btnfiltro, int em)
        {
            if(btnfiltro != null)
            {
                //var ftft = from xv in _context.Anuncios where xv.IdTipoadNavigation.CategoriaName == btnfiltro select xv.IdTipoad;
                var result = _context.Anuncios.Where(x => x.IdTipoadNavigation.CategoriaName.Contains(btnfiltro));

                //var filtroboton = from a in _context.Anuncios
                //                  orderby a.IdTipoad == em ascending
                //                  select a;
                return View(await result.Include(a => a.IdTipoadNavigation).ToListAsync());

            }

            if (opcion == "Categoria")
            {
                var categorias = from a in _context.Anuncios
                                 orderby a.IdTipoad ascending
                                 select a;
                return View(await categorias.Include(a => a.IdTipoadNavigation).ToListAsync());
            }

            else if (opcion == "Mayor votado")
            {
                var fc = from a in _context.Anuncios
                         orderby a.Calificacion descending
                         select a;
                return View(await fc.Include(a => a.IdTipoadNavigation).ToListAsync());
            }
            else if (opcion == "Menor votado")
            {
                var fc = from a in _context.Anuncios
                         orderby a.Calificacion ascending
                         select a;
                return View(await fc.Include(a => a.IdTipoadNavigation).ToListAsync());
            }
            else if (opcion == "A - Z")
            {
                var mc = from a in _context.Anuncios
                         orderby a.NombreAd ascending
                         select a;
                return View(await mc.Include(a => a.IdTipoadNavigation).ToListAsync());
            }
            //else if (opcion == "Menor Cantidad")
            //{
            //    var menorc = from a in db.Compras
            //              orderby a.Cantidad_Compra descending
            //              select a;
            //    return View(menorc.ToList());
            //}
            else if (!string.IsNullOrEmpty(buscador))
            {
                var buscar = from a in _context.Anuncios
                             where a.NombreAd.Contains(buscador)
                             select a;
                return View(await buscar.Include(a => a.IdTipoadNavigation).ToListAsync());

            }
            else
            {
                return View(await _context.Anuncios.Include(a => a.IdTipoadNavigation).ToListAsync());
            }



        }

        // GET: Anuncios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            

            var anuncio = await _context.Anuncios
                .Include(a => a.IdTipoadNavigation)
                .FirstOrDefaultAsync(m => m.IdAd == id);



            ViewBag.data = HttpContext.Session.GetString("usuariodata");

            if (ViewBag.data != null)
            {
                
                ViewBag.buscar1 = HttpContext.Session.GetString("usuarioidrec");
                int buscador = Convert.ToInt32(ViewBag.buscar1);
                string datos = ViewBag.data;
                var buscar = from xv in _context.PuntajeUserAds where xv.IdUsersNavigation.Username == datos select xv;
                if (buscar != null)
                {
                    //var qw = from u in _context.Anuncios
                    //         join x in _context.PuntajeUserAds
                    //         on u.IdAd equals x.IdUsers
                    //         where u.IdAd == id && x.IdUsers == buscador
                    //         select new
                    //         {
                    //             u.IdAd,
                    //             x.IdUsers
                    //         };

                    ////var detalleuserad = _context.PuntajeUserAds.Where(x => x.IdAd == idad).ToList();
                    var result = _context.PuntajeUserAds.ToList().Where(x => x.IdUsers == buscador && x.IdAd == id).FirstOrDefault();
                    ViewBag.yaya = result;
                    //HttpContext.Session.SetString("yavoto", JsonConvert.SerializeObject(pinche));
                }
                
            }

            

            if (anuncio == null)
            {
                return NotFound();
            }

            return View(anuncio);
        }

        // GET: Anuncios/Create
        public IActionResult Create()
        {
            ViewData["Tipoad"] = new SelectList(_context.CategoriaAds, "IdTipoad", "CategoriaName");
            return View();
        }

        // POST: Anuncios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAd,NombreAd,Descripcion,Imagen,IdTipoad,Calificacion")] Anuncio anuncio, IFormFile imgphoto, string nombre, string descripcion, int? idtipo)
        {
            if (ModelState.IsValid)
            {
                if (imgphoto != null)

                {
                    if (imgphoto.Length > 0)

                    //Convert Image to byte and save to database

                    {

                        byte[] p1 = null;
                        using (var fs1 = imgphoto.OpenReadStream())
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                        anuncio.Imagen = p1;

                        var nuevad = new Anuncio
                        {
                            NombreAd = nombre,
                            Descripcion = descripcion,
                            Imagen = p1,
                            IdTipoad = idtipo,
                            Calificacion = 0


                        };
                        _context.Add(nuevad);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));

                    }
                }
                
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdTipoad"] = new SelectList(_context.CategoriaAds, "IdTipoad", "CategoriaName", anuncio.IdTipoad);
            return View(anuncio);
        }
        public ActionResult convertirImagen(int codigo)
        {

            using (var context = new POSTADSContext())
            {
                var foto = (from i in context.Anuncios
                              where i.IdAd == codigo
                              select i).FirstOrDefault();


                return File(foto.Imagen, "Imagenes/jpg");


            }


        }

        [HttpGet]
        public ActionResult Votar()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> VotacionAsync(Anuncio anuncios, PuntajeUserAd puntaje, int voto, int? id, int idad)
        {
            //string pass = Helper.EncodePassword(contra);
            var objusu = (from a in _context.Tusers where a.IdUsers == id select a).FirstOrDefault();
            //HttpContext.Session.SetString("usuariodata", JsonConvert.SerializeObject(objusu.Username));



            if (objusu == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                var quer = from xv in _context.Anuncios where xv.IdAd == anuncios.IdAd select xv;
                
                var rel = _context.PuntajeUserAds.ToList().Where(x => x.IdAd ==  idad).Count();
                if (rel == 0)
                {
                    foreach (Anuncio cv in quer)
                    {

                        cv.Calificacion = cv.Calificacion + voto;
                    }
                    
                }
                else
                {
                    foreach (Anuncio cv in quer)
                    {
                        double pp = 0.05;
                        cv.Calificacion = cv.Calificacion + voto;
                        cv.Calificacion = cv.Calificacion / rel;
                    }
                }
                
               
                _context.SaveChanges();



                var userad = new PuntajeUserAd
                {
                    IdUsers = objusu.IdUsers,
                    IdAd = idad,
                    Puntaje = voto

                };
                _context.Add(userad);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Anuncios", new { Id = idad });
                //var objvoto = (from a in _context.PuntajeUserAds where a.IdUsers == id select a).FirstOrDefault();
                //int session = HttpContext.Session.SetString("usuariodata", JsonConvert.SerializeObject(objusu.).FirstOrDefault);
                //var qw = from u in _context.Anuncios
                //         join x in _context.PuntajeUserAds
                //         on u.IdAd equals x.IdUsers
                //         where u.IdAd == idad && x.IdUsers == id
                //         select new
                //         {
                //             u.IdAd , x.IdUsers
                //         };
                ////var detalleuserad = _context.PuntajeUserAds.Where(x => x.IdAd == idad).ToList();

                ////var yavoto1 = from xv in _context.PuntajeUserAds where xv.IdUsers == id select xv;



                //HttpContext.Session.SetString("yavoto", JsonConvert.SerializeObject(qw));





                //return View("Details/" + idad );
            }


            //if (objusu != null)
            //{

            //    HttpContext.Session.SetString("usuariodata", JsonConvert.SerializeObject(objusu.Username));
            //    //HttpContext.Session.SetString("rol", JsonConvert.SerializeObject(objusu.IdRolNavigation.DescripcionRol));
            //    //HttpContext.Session.SetString("tuser", JsonConvert.SerializeObject(tuser));

            //    //Redirecionamiento del vistas
            //    if (objusu.IdRol == 2)
            //    {
            //        return RedirectToAction("Index", "Anuncios");
            //    }
            //    //var duser = JsonConvert.DeserializeObject<Tuser>(HttpContext.Session.GetString("usuariodata"));
            //    //ViewBag.nick = duser;
            //    return RedirectToAction("Index", "Anuncios");
            //}
            return RedirectToAction("Details", "Anuncios");
        }
            // GET: Anuncios/Edit/5
            public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anuncio = await _context.Anuncios.FindAsync(id);
            if (anuncio == null)
            {
                return NotFound();
            }
            ViewData["IdTipoad"] = new SelectList(_context.CategoriaAds, "IdTipoad", "CategoriaName", anuncio.IdTipoad);
            return View(anuncio);
        }

        // POST: Anuncios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAd,NombreAd,Descripcion,Imagen,IdTipoad,Calificacion")] Anuncio anuncio, IFormFile imgphoto, string namem, string descripcion, int? idtipo)
        {

            if (id != anuncio.IdAd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (imgphoto != null)

                {
                    if (imgphoto.Length > 0)

                    //Convert Image to byte and save to database

                    {

                        byte[] p1 = null;
                        using (var fs1 = imgphoto.OpenReadStream())
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                        anuncio.Imagen = p1;

                        if (anuncio == null)
                        {
                            var nuevad = new Anuncio
                            {
                                IdAd = anuncio.IdAd,
                                NombreAd = namem,
                                Descripcion = descripcion,
                                Imagen = p1,
                                IdTipoad = idtipo,

                                Calificacion = 0
                            };
                            _context.Update(nuevad);
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            var nuevad = new Anuncio
                            {
                                IdAd = anuncio.IdAd,
                                NombreAd = namem,
                                Descripcion = descripcion,
                                Imagen = p1,
                                IdTipoad = idtipo,

                                Calificacion = anuncio.Calificacion


                            };
                            _context.Update(nuevad);
                            await _context.SaveChangesAsync();

                        }
                        
                       
                        //try
                        //{

                        //}
                        //catch (DbUpdateConcurrencyException)
                        //{
                        //    if (!AnuncioExists(anuncio.IdAd))
                        //    {
                        //        return NotFound();
                        //    }
                        //    else
                        //    {
                        //        throw;
                        //    }
                        //}
                        return RedirectToAction(nameof(Index));
                    }

                }

                
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdTipoad"] = new SelectList(_context.CategoriaAds, "IdTipoad", "CategoriaName", anuncio.IdTipoad);
            return View(anuncio);
        }

        // GET: Anuncios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anuncio = await _context.Anuncios
                .Include(a => a.IdTipoadNavigation)
                .FirstOrDefaultAsync(m => m.IdAd == id);
            if (anuncio == null)
            {
                return NotFound();
            }

            return View(anuncio);
        }

        // POST: Anuncios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var anuncio = await _context.Anuncios.FindAsync(id);
            _context.Anuncios.Remove(anuncio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnuncioExists(int id)
        {
            return _context.Anuncios.Any(e => e.IdAd == id);
        }
    }
}
