using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace zerix_trial.Pages;

public class ComposeModel : PageModel
{
    private readonly ILogger<ComposeModel> _logger;

    public ComposeModel(ILogger<ComposeModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
