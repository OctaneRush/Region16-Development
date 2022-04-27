using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using domain.SpeakerAggregate;
using domain;

namespace webapp.Pages.Forms;

public class SpeakerFormModel : PageModel
{
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

        var newSpeaker = _unitOfWork.Helper.ValidateSpeaker(Speaker);

        if (newSpeaker == true)
        {
            await _unitOfWork.Speakers.AddSpeaker(Speaker);           
            _unitOfWork.Complete();
            return RedirectToPage("/Index");
        }
        else
        {
            return Page();
        }
    }
}