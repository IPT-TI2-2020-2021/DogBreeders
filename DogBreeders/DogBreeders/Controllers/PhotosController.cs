using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DogBreeders.Data;
using DogBreeders.Models;

namespace DogBreeders.Controllers {
   public class PhotosController : Controller {
      private readonly DogBreedersDB _db;

      public PhotosController(DogBreedersDB context) {
         _db = context;
      }




      // GET: Photos
      public async Task<IActionResult> Index() {

         /* 
          * SELECT *
          * FROM Photos INNER JOIN Dogs ON Photos.DogFK = Dogs.Id
          *             INNER JOIN Breeds ON Dogs.BreedsFK = Breeds.Id
          */
         var ListOfPhotos = _db.Photos.Include(p => p.Dog)
                                      .ThenInclude(d => d.Breed);  // LINQ

         return View(await ListOfPhotos.ToListAsync());
      }







      // GET: Photos/Details/5
      public async Task<IActionResult> Details(int? id) {
         if (id == null) {
            return NotFound();
         }

         var photos = await _db.Photos
             .Include(p => p.Dog)
             .FirstOrDefaultAsync(m => m.Id == id);
         if (photos == null) {
            return NotFound();
         }

         return View(photos);
      }

      // GET: Photos/Create
      public IActionResult Create() {
         ViewData["DogFK"] = new SelectList(_db.Dogs, "Id", "Id");
         return View();
      }

      // POST: Photos/Create
      // To protect from overposting attacks, enable the specific properties you want to bind to.
      // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public async Task<IActionResult> Create([Bind("Id,NameOfPhoto,Date,Local,DogFK")] Photos photos) {
         if (ModelState.IsValid) {
            _db.Add(photos);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
         }
         ViewData["DogFK"] = new SelectList(_db.Dogs, "Id", "Id", photos.DogFK);
         return View(photos);
      }

      // GET: Photos/Edit/5
      public async Task<IActionResult> Edit(int? id) {
         if (id == null) {
            return NotFound();
         }

         var photos = await _db.Photos.FindAsync(id);
         if (photos == null) {
            return NotFound();
         }
         ViewData["DogFK"] = new SelectList(_db.Dogs, "Id", "Id", photos.DogFK);
         return View(photos);
      }

      // POST: Photos/Edit/5
      // To protect from overposting attacks, enable the specific properties you want to bind to.
      // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public async Task<IActionResult> Edit(int id, [Bind("Id,NameOfPhoto,Date,Local,DogFK")] Photos photos) {
         if (id != photos.Id) {
            return NotFound();
         }

         if (ModelState.IsValid) {
            try {
               _db.Update(photos);
               await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
               if (!PhotosExists(photos.Id)) {
                  return NotFound();
               }
               else {
                  throw;
               }
            }
            return RedirectToAction(nameof(Index));
         }
         ViewData["DogFK"] = new SelectList(_db.Dogs, "Id", "Id", photos.DogFK);
         return View(photos);
      }

      // GET: Photos/Delete/5
      public async Task<IActionResult> Delete(int? id) {
         if (id == null) {
            return NotFound();
         }

         var photos = await _db.Photos
             .Include(p => p.Dog)
             .FirstOrDefaultAsync(m => m.Id == id);
         if (photos == null) {
            return NotFound();
         }

         return View(photos);
      }

      // POST: Photos/Delete/5
      [HttpPost, ActionName("Delete")]
      [ValidateAntiForgeryToken]
      public async Task<IActionResult> DeleteConfirmed(int id) {
         var photos = await _db.Photos.FindAsync(id);
         _db.Photos.Remove(photos);
         await _db.SaveChangesAsync();
         return RedirectToAction(nameof(Index));
      }

      private bool PhotosExists(int id) {
         return _db.Photos.Any(e => e.Id == id);
      }
   }
}
