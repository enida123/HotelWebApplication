using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.Data.EF;
using Hotel.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication9.Helper;
using WebApplication9.ViewModels;

namespace WebApplication9.Controllers
{
    public class AutentifikacijaController : Controller
    {
        private MojContext _db;
        private IHttpContextAccessor httpContext;

        public AutentifikacijaController(MojContext db, IHttpContextAccessor httpContext)
        {
            _db = db;
            this.httpContext = httpContext;
        }

        public IActionResult Prijava()
        {

            return View(new LoginVM());
        }
        [HttpPost]
        public IActionResult Prijava(LoginVM login)
        {
            KorisnickiNalog korisnik = _db.KorisnickiNalog.Where(x => x.KorisnickoIme == login.Username && x.Lozinka == login.Password)
                .FirstOrDefault();
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            if (korisnik == null)
            {
                ModelState.AddModelError("", "Korisnicko ime ili lozinka nisu ispravni");
            }
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            HttpContext.SetLogiraniKorisnik(korisnik);

            if (korisnik.IsUposlenik)
            {
                return RedirectToAction("Index", "Home");
            }
            else if (korisnik.IsKlijent)
            {
                return RedirectToAction("Index", "Klijent");
            }
            else
            {
                return Redirect("/Administrator/Home/Index");

            }

        }
        public IActionResult Registracija()
        {
            AutentifikacijaRegistracijaVM model = new AutentifikacijaRegistracijaVM();
            model.Gradovi = _db.Grad.Select(x => new SelectListItem
            {
                Value = x.id.ToString(),
                Text = x.Naziv
            }).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Registracija(AutentifikacijaRegistracijaVM login)
        {
            KorisnickiNalog nalog = new KorisnickiNalog
            {
                KorisnickoIme = login.KorisnickoIme,
                Lozinka = login.Password,
                IsAdministrator = false,
                IsKlijent = true,
                IsUposlenik = false
            };

            _db.KorisnickiNalog.Add(nalog);
            _db.SaveChanges();

            Gost gost = new Gost
            {
                Ime = login.Ime,
                Prezime = login.Prezime,
                GradID = login.GradID,
                NalogID = nalog.Id,
                BrojTelefona = login.BrojTelefona,
                Spol = login.Spol
            };
            _db.Gost.Add(gost);
            _db.SaveChanges();
            if (!ModelState.IsValid)
            {
                return View(gost);
            }
            return RedirectToAction("Prijava", "Autentifikacija");
        }
        public IActionResult Odjava()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Prijava");
        }


    }
}