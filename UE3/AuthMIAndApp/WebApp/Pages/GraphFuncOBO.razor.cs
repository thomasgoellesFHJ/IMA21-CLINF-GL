using Microsoft.AspNetCore.Components;
using Microsoft.Identity.Client;
using Microsoft.Identity.Web;
using System.Net.Http;
using System.Net.Mail;
using WebApp.Data;

namespace WebApp.Pages;

public partial class GraphFuncOBO
{

    
    [Inject]
    IHttpClientFactory _httpClientFactory { get; set; }

    [Inject]
    ITokenAcquisition _tokenAcquisition { get; set; }
    [Inject]
    MicrosoftIdentityConsentAndConditionalAccessHandler ConsentHandler { get; set; }
    [Inject]
    IConfiguration _configuration { get; set; }
    private HttpClient _httpClient;
    private string MailsAsJson;
    private List<MailMessage> messages = new List<MailMessage>();

    public GraphFuncOBO() 
    { 
    }    

    protected override async Task OnInitializedAsync()
    {
        _httpClient = _httpClientFactory.CreateClient();
        string token = "";
        try
        {
            // get a token
            token = await _tokenAcquisition.GetAccessTokenForUserAsync(new[] { _configuration.GetValue<string>("MiddleTierApi:Scope") });
        }
        catch (Exception ex)
        {
            // if the token is not available, redirect to the consent page
            ConsentHandler.HandleException(ex);
        }
        // make API call

        _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        var dataRequest = await _httpClient.GetAsync(_configuration.GetValue<string>("MiddleTierApi:BaseUrl"));

        if (dataRequest.IsSuccessStatusCode)
        {
            MailsAsJson = dataRequest.Content.ReadAsStringAsync().Result;
            //StateHasChanged();
        }

        
    }
}
