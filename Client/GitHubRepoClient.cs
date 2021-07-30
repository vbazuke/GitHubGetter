using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using BotGitHub.Model;
using Octokit;
using System.Collections.Generic;

namespace BotGitHub.Client
{
    public class GitHubRepoClient : IGitHubRepoClient
    {                     
        

        public GitHubRepoClient(HttpClient client)
        {
            
        }

        
        public async Task<List<GitHubRepo>> GetRepository(string orgName, int upperLimit )
        {
            try
            {
                var options = new ApiOptions()
                {
                    PageSize = upperLimit,
                    PageCount = 1
                };

                var github = new GitHubClient(new ProductHeaderValue("GitHubBot"));
                IReadOnlyList<Repository> list = await github.Repository.GetAllForOrg(orgName, options);                

                List<GitHubRepo> listFinal = new List<GitHubRepo>() {                    
                    new GitHubRepo(){ Name="",Description=""},
                    new GitHubRepo(){ Name="",Description=""},
                    new GitHubRepo(){ Name="",Description=""},
                    new GitHubRepo(){ Name="",Description=""},
                    new GitHubRepo(){ Name="",Description=""},
            };

                int counter = 0;

                foreach (Repository r in list) 
                {
                    if (r.Language == "C#")
                    {
                        listFinal[counter].Name = (r.Name);
                        listFinal[counter].Description = (r.Description);
                        counter++;
                    }
                   

                    if (counter == 5)
                    {
                        break;
                    }

                }               

                return listFinal;
            }
            catch (Exception e)
            {                
                return null;
            }
        }
    }
}