using System.Collections.Generic;
using System.Threading.Tasks;
using BotGitHub.Model;
using Octokit;

namespace BotGitHub.Client
{
    public interface IGitHubRepoClient
    {
        Task<List<GitHubRepo>> GetRepository(string orgName, int upperLimit);
    }
}