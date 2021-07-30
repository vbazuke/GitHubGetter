using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using BotGitHub.Model;
using BotGitHub.Client;

namespace BotGitHub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GitHubRepoController : ControllerBase
    {
        private readonly IGitHubRepoClient _gitHubRepoClient;

        public GitHubRepoController(IGitHubRepoClient gitHubRepoClient)
        {
            _gitHubRepoClient = gitHubRepoClient;
        }

        // GET: GitHubRepo?repoName={repoName}&limit={limit}
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string repoName, int limit)
        {
            return Ok(await _gitHubRepoClient.GetRepository(repoName, limit));
        }
    }
}
