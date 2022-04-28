using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using domain.SpeakerAggregate;
using domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace webapp.Pages.Forms;

    public class UpdateSpeakerFormModel : PageModel
    {
        private readonly webapp.ApplicationDbContext _context;
        private IUnitOfWork _unitOfWork;


    public UpdateSpeakerFormModel(webapp.ApplicationDbContext context, IUnitOfWork unitOfWork)
    {
        _context = context;
        _unitOfWork = unitOfWork;
    }

        [BindProperty]
        public Speaker? Speaker { get; set; }

        public async Task<IActionResult> OnGetAsync()
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

            return RedirectToPage("/Index");
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
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