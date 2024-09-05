using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http; 

namespace zerix_trial.Pages;

public class ComposeModel : PageModel
{
    [BindProperty]
    public List<IFormFile> UploadedFiles { get; set; } = new List<IFormFile>();

    private readonly ILogger<ComposeModel> _logger;

    public ComposeModel(ILogger<ComposeModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public IActionResult OnPostUploadFiles(List<IFormFile> files)
        {
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    UploadedFiles.Add(file);
                }
            }
            
            // Redirect to Get request to reset form state
            return RedirectToPage();
        }
}
