using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPress.Pages;

public class GetStartedModel : PageModel {
    
    private readonly ILogger<GetStartedModel> _logger;

    public GetStartedModel(ILogger<GetStartedModel> logger){
        _logger = logger;
    }

    public void OnGet(){

    }
}