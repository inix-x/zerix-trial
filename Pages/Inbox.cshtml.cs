using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_trial.Pages;

public class InboxModel : PageModel
{
    private readonly ILogger<InboxModel> _logger;

    public InboxModel(ILogger<InboxModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
