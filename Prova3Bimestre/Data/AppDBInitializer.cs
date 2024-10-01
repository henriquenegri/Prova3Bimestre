using Prova3Bimestre.Models;
using Prova3Bimestre.Data;

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

                if (!contexto.Fornecedores.Any())
                {
                    contexto.Fornecedores.AddRange(new List<Fornecedor>()
                    {
                        new Fornecedor
                        {
                            Nome = "´Vovó Juju",
                            email = "comeAbacateBem@gmail.com",
                            Telefone = 1234567891,
                            CNPJ = 1234567891,
                        },
                        new Fornecedor
                        {
                            Nome = "O tal do Daniel Rosa",
                            email = "DanielRosa@gmail.com",
                            Telefone = 784512369,
                            CNPJ = 986532147,
                        },
                        new Fornecedor
                        {
                            Nome = "Paulista",
                            email = "Paulista@gmail.com",
                            Telefone = 522136497,
                            CNPJ = 0875512694,
                        },
                        new Fornecedor
                        {
                           Nome = "Bruno",
                            email = "NaoFalamosDoBruno@gmail.com",
                            Telefone = 00321654877,
                            CNPJ = 02021559755,
                        },
                        new Fornecedor
                        {
                            Nome = "Tanjiro Kamado",
                            email = "TanjiroOni@gmail.com",
                            Telefone = 1566332489,
                            CNPJ = 978456123,
                        },
                    });
                    contexto.SaveChanges();
                }
            }

        }
    }
}
