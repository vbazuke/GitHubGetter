using System;

namespace BotGitHub.Model
{
    public interface IGitHubRepoResponse
    {
         string Name { get; set; }
         string Description { get; set; }
    }
}
