using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using rp_ef_maria.Models;
namespace rp_ef_maria.Pages;

public class ProfileModel : PageModel
{
    private readonly ILogger<ProfileModel> _logger;
    private readonly StoreContext _context;

    [BindProperty]
    public SiteUser SiteUser { get; set; } = default!;
    public ProfileModel(StoreContext context, ILogger<ProfileModel> logger)
    {
        _context = context;
        _logger = logger;
    }




    public async Task<IActionResult> OnGetAsync()
    {
        return Page();


    }



    public async Task<IActionResult> OnPostAsync()
    {
        SiteUser.SiteUserId = 2;
        if (!ModelState.IsValid)
        {
            _logger.LogWarning("ModelState is invalid");
            foreach (var val in ModelState.Values.SelectMany(v => v.Errors).Select(e => (e.ErrorMessage, e.Exception)))
            {

                _logger.LogWarning($"ModelState[{val.ErrorMessage}] : {val.Exception}");
            }

            return BadRequest();
        }

        _context.Attach(SiteUser).State = EntityState.Modified;
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!SiteUserExists(SiteUser.SiteUserId))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Profile");


    }

    private bool SiteUserExists(uint id)
    {
        return (_context.SiteUser?.Any(e => e.SiteUserId == id)).GetValueOrDefault();
    }
}

