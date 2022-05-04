using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using domain.AttendeeAggregate;

namespace webapp.Pages.Forms;

public class AttendeeFormModel : PageModel
{
    private readonly webapp.ApplicationDbContext _context;

    public AttendeeFormModel(webapp.ApplicationDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Attendee? Attendee {get; set;}

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

        _context.Attendees.Add(Attendee);
        await _context.SaveChangesAsync();
        
        return RedirectToPage("./Index");
    }
}