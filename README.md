API construída usando C#/.NET 3.1 utilizando o Visual Studio 2019, que funciona como um intermediário de requests para o API REST do GitHub.

Foi utilizado o pacote Octokit.NET para facilitar as requisições. https://github.com/octokit/octokit.net

O flow do chat desenvolvido no builder, encontra-se no diretório flow, bem [aqui](https://github.com/vbazuke/GitHubGetter/blob/master/flow/vbazuke-botflow.json)!

Esse repositório foi utilizado para fazer o deploy da API no Heroku, que está no ar em : https://fathomless-headland-97676.herokuapp.com/GitHubRepo?orgName=takeNet&upperLimit=15

Para o exemplo de requisição feita pelo chat foi utilizada a url com os parâmetros acima.

orgName =    Nome da organização/conta de onde virão os repositórios

upperLimit = Limite Superior para a busca de repositórios com a linguagem C# (Limite máximo de repositórios a serem verificados)


