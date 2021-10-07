using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Data;
using ProjectManagement.Models;

namespace ProjectManagement.Controllers
{
    public class CompletedProjectController : Controller
    {
        private readonly dbContext _context;

        public CompletedProjectController(dbContext context)
        {
            _context = context;
        }

        // GET: CompletedProject
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompletedProjects.ToListAsync());
        }

        // GET: CompletedProject/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var completedProject = await _context.CompletedProjects
                .FirstOrDefaultAsync(m => m.CompletedProjectId == id);
            if (completedProject == null)
            {
                return NotFound();
            }

            return View(completedProject);
        }

        // GET: CompletedProject/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompletedProject/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompletedProjectId,ProjectName,ContractDate,WarrantyExpiredDate,PgexpiredDate,Description")] CompletedProject completedProject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(completedProject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(completedProject);
        }

        // GET: CompletedProject/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var completedProject = await _context.CompletedProjects.FindAsync(id);
            if (completedProject == null)
            {
                return NotFound();
            }
            return View(completedProject);
        }

        // POST: CompletedProject/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompletedProjectId,ProjectName,ContractDate,WarrantyExpiredDate,PgexpiredDate,Description")] CompletedProject completedProject)
        {
            if (id != completedProject.CompletedProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(completedProject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompletedProjectExists(completedProject.CompletedProjectId))
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
            return View(completedProject);
        }

        // GET: CompletedProject/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var completedProject = await _context.CompletedProjects
                .FirstOrDefaultAsync(m => m.CompletedProjectId == id);
            if (completedProject == null)
            {
                return NotFound();
            }

            return View(completedProject);
        }

        // POST: CompletedProject/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var completedProject = await _context.CompletedProjects.FindAsync(id);
            _context.CompletedProjects.Remove(completedProject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompletedProjectExists(int id)
        {
            return _context.CompletedProjects.Any(e => e.CompletedProjectId == id);
        }
    }
}
