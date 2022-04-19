using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using domain.SpeakerAggregate;
using domain.SessionAggregate;

namespace webapp.Pages.Forms;

public class SpeakerFormModel : PageModel
{
    private readonly webapp.ApplicationDbContext _context;

    public SpeakerFormModel(webapp.ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Speaker? Speaker {get; set;}

    public IActionResult OnGet()
    {
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Speakers.Add(Speaker);
        await _context.SaveChangesAsync();
        
        return RedirectToPage("./Index");
    }
}