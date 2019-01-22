using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Accounting.Data.Context;
using Accounting.Data.Models;
using Accounting.Data.Models.Shared;

namespace Accounting.Controllers
{
    public class AccountCategoriesController : Controller
    {
        private readonly AccountingDbContext _context;

        public AccountCategoriesController(AccountingDbContext context)
        {
            _context = context;
        }

        // GET: AccountCategories
        public async Task<IActionResult> Index()
        {
            var accountingDbContext = _context.AccountCategories.Include(a => a.Type);
            return View(await accountingDbContext.ToListAsync());
        }

        // GET: AccountCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountCategory = await _context.AccountCategories
                .Include(a => a.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accountCategory == null)
            {
                return NotFound();
            }

            return View(accountCategory);
        }

        // GET: AccountCategories/Create
        public IActionResult Create()
        {
            ViewData["TypeId"] = new SelectList(_context.AccountTypes, "Id", "Code");
            return View();
        }

        // POST: AccountCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Code,Name,TypeId,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn")] AccountCategory accountCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TypeId"] = new SelectList(_context.AccountTypes, "Id", "Code", accountCategory.TypeId);
            return View(accountCategory);
        }

        // GET: AccountCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountCategory = await _context.AccountCategories.FindAsync(id);
            if (accountCategory == null)
            {
                return NotFound();
            }
            ViewData["TypeId"] = new SelectList(_context.AccountTypes, "Id", "Code", accountCategory.TypeId);
            return View(accountCategory);
        }

        // POST: AccountCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Code,Name,TypeId,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn")] AccountCategory accountCategory)
        {
            if (id != accountCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountCategoryExists(accountCategory.Id))
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
            ViewData["TypeId"] = new SelectList(_context.AccountTypes, "Id", "Code", accountCategory.TypeId);
            return View(accountCategory);
        }

        // GET: AccountCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountCategory = await _context.AccountCategories
                .Include(a => a.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accountCategory == null)
            {
                return NotFound();
            }

            return View(accountCategory);
        }

        // POST: AccountCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accountCategory = await _context.AccountCategories.FindAsync(id);
            _context.AccountCategories.Remove(accountCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountCategoryExists(int id)
        {
            return _context.AccountCategories.Any(e => e.Id == id);
        }
    }
}
