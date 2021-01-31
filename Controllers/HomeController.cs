using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EFOperation.Models;
using Microsoft.AspNetCore.Diagnostics;
using System.Net.Http;

namespace EFOperation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _clientFactory;
        private readonly GitHubService _gitHubService;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory, GitHubService gitHubService)
        {
            _gitHubService = gitHubService;
            _logger = logger;
            _clientFactory = httpClientFactory;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "repos/aspnet/AspNetCore.Docs/pulls");

            var client = _clientFactory.CreateClient("github");

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
            }
            else
            {

            }

            var response2 = _gitHubService.GetAspNetDocsIssues();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var erromodel = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if (erromodel?.Error is OutOfMemoryException)
            {

            }
            if (erromodel?.Path == "/index")
            {

            }

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
