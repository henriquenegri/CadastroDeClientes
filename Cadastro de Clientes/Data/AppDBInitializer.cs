using Cadastro_de_Clientes.Models;

namespace Cadastro_de_Clientes.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var contexto = serviceScope.ServiceProvider.GetService<AppCont>();
                contexto.Database.EnsureCreated();

                //Criando registros no banco de dados

                if (!contexto.Clientes.Any())
                {
                    contexto.Clientes.AddRange(new List<Cliente>()
                    {
                        new Cliente
                        {
                            Nome = "Come Abacate bem",
                            email = "comeAbacateBem@gmail.com",
                            Bairro = "Abacate",
                            Logradouro = "Pé de abacate",
                            Cidade = "Ribeirão Preto",
                            Estado = "São Paulo",
                            Numero = 79,
                            Telefone = 1612354687
                        },
                        new Cliente
                        {
                            Nome = "Cozinha da Vovó JuJu",
                            email = "VovoJuju@gmail.com",
                            Bairro = "Billabong",
                            Logradouro = "XV de Setembro",
                            Cidade = "Ribeirão Preto",
                            Estado = "São Paulo",
                            Numero = 47,
                            Telefone = 1665898742
                        },
                        new Cliente
                        {
                            Nome = "Celulares do Irmão do Jorel",
                            email = "irmaoDoJorel@gmail.com",
                            Bairro = "Tiradentes",
                            Logradouro = "Rosas De Macapá",
                            Cidade = "Ribeirão Preto",
                            Estado = "São Paulo",
                            Numero = 10,
                            Telefone = 1765412398
                        },
                        new Cliente
                        {
                            Nome = "Móveis do Linkin Park",
                            email = "linkinPark@gmail.com",
                            Bairro = "swordArtRoyale",
                            Logradouro = "Rua Do Rock",
                            Cidade = "Ribeirão Preto",
                            Estado = "São Paulo",
                            Numero = 25,
                            Telefone = 1987456320
                        },
                        new Cliente
                        {
                            Nome = "Quem é o tal do Daniel Rosa",
                            email = "talDoDanielRosa@gmail.com",
                            Bairro = "Pomar Do Pico Amarelo",
                            Logradouro = "Árvore das Acácias",
                            Cidade = "Ribeirão Preto",
                            Estado = "São Paulo",
                            Numero = 09,
                            Telefone = 1875395584
                        },
                    });
                    contexto.SaveChanges();
                }
            }

        }
    }
}
