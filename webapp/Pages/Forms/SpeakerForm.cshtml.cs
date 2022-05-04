using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using domain.SpeakerAggregate;
using domain;

namespace webapp.Pages.Forms;

public class SpeakerFormModel : PageModel
{
    private readonly webapp.ApplicationDbContext _context;
    private IUnitOfWork _unitOfWork;

    public SpeakerFormModel(webapp.ApplicationDbContext context, IUnitOfWork unitOfWork)
    {
        _context = context;
        _unitOfWork = unitOfWork;
    }

    [BindProperty]
    public Speaker? Speaker {get; set;}

    public IActionResult OnGet()
    {
        var currentUser = _context.Speakers.Where(u => u.EmailAddress == HttpContext.User.Identity.Name).FirstOrDefault();
            
        if (currentUser != null)
        {
            Speaker ??= new Speaker
            {
                FirstName = currentUser.FirstName,
                LastName = currentUser.LastName,
                MailAddress = currentUser.MailAddress,
                PrimaryPhoneNumber = currentUser.PrimaryPhoneNumber,
                EmailAddress = currentUser.EmailAddress,
                JobTitle = currentUser.JobTitle
            };
            
            return Page();
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var newSpeaker = _unitOfWork.Helper.ValidateSpeaker(Speaker);

        if (newSpeaker == true)
        {
            await _unitOfWork.Speakers.AddSpeaker(Speaker);           
            _unitOfWork.Complete();
            return RedirectToPage("/Forms/OtherSpeakerOptions");
        }
        else
        {
            return Page();
        }
    }
}