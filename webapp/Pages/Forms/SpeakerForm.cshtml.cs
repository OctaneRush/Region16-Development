using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using domain.SpeakerAggregate;
using domain;

namespace webapp.Pages.Forms;

public class SpeakerFormModel : PageModel
{
    //private readonly webapp.ApplicationDbContext _context;
    private IUnitOfWork _unitOfWork;

    public SpeakerFormModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
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
        
        var fname = _unitOfWork.Helper.ValidateFirstName(Speaker);
        var lname = _unitOfWork.Helper.ValidateLastName(Speaker);
        var address = _unitOfWork.Helper.ValidateMailAddress(Speaker);
        var phone = _unitOfWork.Helper.ValidatePrimaryPhoneNumber(Speaker);
        var email = _unitOfWork.Helper.ValidateEmailAddress(Speaker);
        var title = _unitOfWork.Helper.ValidateJobTitle(Speaker);

        if (fname && lname && address && phone && email && title == true)
        {
            await _unitOfWork.Speakers.AddSpeaker(Speaker);
            _unitOfWork.Complete();
        }
        // _context.Speakers.Add(Speaker);
        // await _context.SaveChangesAsync();
        
        return RedirectToPage("/Index");
    }
}