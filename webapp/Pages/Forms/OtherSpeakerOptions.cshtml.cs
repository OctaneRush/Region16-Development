using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages.Forms;

public class OtherSpeakerOptionsModel : PageModel
{
    private readonly ILogger<OtherSpeakerOptionsModel> _logger;

    public OtherSpeakerOptionsModel(ILogger<OtherSpeakerOptionsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}