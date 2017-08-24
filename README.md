#### Somos especialistas em BLOCKCHAIN.
[![N|Solid] [IMG]] [STR]
  #### Fa�a parte da revolu��o!
  # Conecte-se a nossa  [Star Blockchain API] [API]
  _
##### Voc� pode:
  - Registrar arquivos numa base de dados descentralizada, compartilhada, p�blica e criptografada conhecida tamb�m como o protocolo da confian�a.
  - Pesquisar, validar, verificar ou atestar a autenticidade de seus arquivos a qualquer momento apenas com um click
  

> A Star Blockchain API � um produto capaz de se conectar ao seu sistema de informa��o para criar registros na blockchain com os dados nele armazenados que voc� selecionar. Isso � �til aos mais variados neg�cios privados ou p�blicos, uma vez que nosso produto permite que voc� crie solu��es inovadoras para seus clientes a partir dos recursos que sua organiza��o j� possui. A utiliza��o de nossa API lhe permitir� ofertar mais do que voc� imaginava ser poss�vel em seu mercado de atua��o, simplesmente somando as funcionalidades da tecnologia blockchain.


##### Tech
Aplica��o cliente desenvolvida na plataforma Microsoft .NET Framework 4.5.2 para consumir os servi�os dispon�veis da Star Blockchain API.

##### Installation
[AppBlockchain] [INS] necessita do [Microsoft .NET Framework] [MNF] 4.5.2 ou superior para executar.

##### Exemplo de c�digo

Registrar Arquivo:

```sh
using AStar;
using AStar.Model;

namespace AppBlockchain
{
    public class ApiBlockchain
    {
        public async Task<string> Registrar(string privateKey, int account, string user, string pass, 
                                            string hashArquivo, string coin, int test)
        {
            try
            {
                // Declaracao e Instancia de objetos das classes utilizadas
                SendApi Api = new SendApi();
                SingleResult singleResult = new SingleResult();
                
                // Chamada do metodo de registro de arquivos da API
                singleResult = await Api.SendHashAsync(AStar.Util.Token.sign(privateKey), 
                                                        account, user, pass, hash, coin, test);
                
                // Verifica��o do retorno do metodo
                if (singleResult.Error != null)
                    return "Erro de execucao da rotina SendFile da API. " + singleResult.Result;
                else
                    return singleResult.Result;
            }
            catch (Exception ex)
            {
                return "Erro na chamada da rotina Registrar. Exception: " + ex.Message;
            }
        }
    }
}
```

Validar Aquivo:
```sh
using System;
using AStar.Api;
using AStar.Model;
using AStar.Util;
using System.Threading.Tasks;

namespace AppBlockchain
{
    public class ApiBlockchain
    {
        public Transaction[] SearchByHash(string privateKey, int account, string user, 
                                            string pass, int id, string hash)
        {
            try
            {
                // Daclaracao e instancia de objeto da classe utilizada
                searchApi = new SearchApi();
                // Chamada do metodo de validacao do arquivo
                Transaction[] transactions = searchApi.SearchByHash(AStar.Util.Token.sign(privateKey), 
                                                                    account, user, pass, hash);
                // Retorno dos resultados
                return transactions;
            }
            catch (Exception ex)
            {
                Transaction[] transactions = new Transaction[1];
                Transaction x = new Transaction();
                x.Errormessage = "Erro na chamada da rotina SearchByHash. Exception: " + ex.Message;
                transactions[0] = x;
                return transactions;
            }
        }
    }
}
```
[IMG]: <https://www.astarlabs.com/wp-content/uploads/2017/08/a-star.jpg>
[STR]: <https://www.astarlabs.com/>
[API]: <https://www.astarlabs.com/produtos/star-blockchain-api/>
[INS]: <https://github.com/astarlabs/dotNetFileRegisterExample/tree/master/Installer/Release>
[MNF]: <https://www.microsoft.com/net/download/framework>