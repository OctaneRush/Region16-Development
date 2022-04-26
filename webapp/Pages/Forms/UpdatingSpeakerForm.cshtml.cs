using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using domain.SpeakerAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace webapp.Pages.Forms;

    public class UpdateSpeakerFormModel : PageModel
    {
        private readonly webapp.ApplicationDbContext _context;
        private readonly IUserEmailStore<IdentityUser>? _emailStore;
        private readonly UserManager<IdentityUser>? _userManager;
        private readonly IUserStore<IdentityUser>? _userStore;

    public UpdateSpeakerFormModel(webapp.ApplicationDbContext context)
    {
        _context = context;
    }

        [BindProperty]
        public Speaker? Speaker { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {

            //var currentUser = await _userStore.FindByNameAsync(User.Identity.Name.ToUpper(), CancellationToken.None);
            var currentUser = _context.Users.Where(u => u.UserName == _userManager.GetUserName(User));
            var currentEmail = currentUser.Select(e => e.Email);


            // if (email == null)
            // {
            //     return NotFound();
            // }
    
            Speaker = _context.Speakers.Where(p => p.EmailAddress.Equals(currentEmail)).SingleOrDefault();

            if (Speaker == null)
            {
                return NotFound();
            }
            else

            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
        
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Speaker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpeakerExists(Speaker.EmailAddress))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }
        private bool SpeakerExists(string email)
        {
            return _context.Speakers.Any(s => s.EmailAddress == email);
        }
    }