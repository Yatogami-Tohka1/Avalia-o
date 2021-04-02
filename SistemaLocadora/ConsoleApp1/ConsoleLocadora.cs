using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class ConsoleLocadoras
    {
        public static string LocadoraSelecionada = "";
        public static string ClienteSelecionado = "";
        public static string VeiculoSelecionado = "";
        public static void Main()
        {
            int c = 0;
            RedeLocadoras.AdicionarLocadora(new Locadora("Locadora Centro", "Rua Guaporé 789"));
            RedeLocadoras.AdicionarLocadora(new Locadora("Locadora Yvete Dias", "Rua Yvete Dias da Silva 60"));
            RedeLocadoras.Clientes.Add(new Cliente("Matheus Mazali Maeda", "113.888.779-02"));
            RedeLocadoras.Clientes.Add(new Cliente("Pedro Ivo Bez Maroco", "090.749.739-06"));
            RedeLocadoras.Clientes.Add(new Cliente("Caio Yoshinobu Higashi Trevisan Graciano", "066.513.619-61"));
            RedeLocadoras.Clientes.Add(new Cliente("Cauã Porfírio Taramelli", "125.201.229-27"));
            foreach (Locadora loc in RedeLocadoras.Locadoras)
            {
                if(loc.Nome == "Locadora Centro")
                {
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1575", "Locadora Centro", "Carro", 0, "NBJ-4189", 15000, "Ford", "Fusion", false));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1576", "Locadora Centro", "Carro", 0, "MZI-4665", 40000, "BMW", "I8", false));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1577", "Locadora Centro", "Carro", 0, "MNI-9344", 30000, "Porsche", "Panamera", true));

                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1578", "Locadora Centro", "Avião", 1000, "", 0, "Boeing", "747", false));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1579", "Locadora Centro", "Avião", 1200, "", 0, "Boeing", "787", true));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1580", "Locadora Centro", "Avião", 8000, "", 0, "Airbus", "A320", false));
                }
            }
            foreach (Locadora loc in RedeLocadoras.Locadoras)
            {
                if (loc.Nome == "Locadora Yvete Dias")
                {
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1581", "Locadora Yvete Dias", "Carro", 0, "JKL-6086", 10000, "Hyundai", "Veloster", false));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1582", "Locadora Yvete Dias", "Carro", 0, "KZJ-5452", 280000, "Wolkswagem", "Gol Mexido", true));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1583", "Locadora Yvete Dias", "Carro", 0, "HVW-9099", 36000, "Wolkswagem", "Savero Rebaixada", true));

                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1584", "Locadora Yvete Dias", "Avião", 1400, "", 0, "Boeing", "737", true));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1585", "Locadora Yvete Dias", "Avião", 1800, "", 0, "Boeing", "720", true));
                    loc.AdicionarVeiculoAluguel(new VeiculoAluguel("1586", "Locadora Yvete Dias", "Avião", 16000, "", 0, "Airbus", "A319", false));
                }
            }               
            while (c == 0)
            {
                MostrarMenu();
            }           
        }
        
        
       public static void MostrarMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n " +
                "      Sistema de Locadoras\n " +
                "\n" +
                $"Locadora selecionada: {LocadoraSelecionada}\n" +
                $"Cliente selecionado: {ClienteSelecionado}\n" +
                "     \n" +
                "1 - Criar Locadora \n" +
                "2 - Remover Locadora\n" +
                "3 - Listar Locadoras\n" +
                "4 - Selecionar Locadora\n" +
                "\n" +
                "5 - Listar Veiculos Disponiveis\n" +
                "6 - Listar Carros Disponíveis\n" +
                "7 - Listar Aviões Disponíveis\n" +
                "8 - Listar Todos Os Veiculo\n" +
                "\n" +
                "9 - Cadastrar Cliente\n" +
                "10 - Listar Clientes\n" +
                "11 - Selecionar Cliente\n" +
                "\n" +
                "12 - Iniciar Aluguel\n" +
                "13 - Devolver Veículo\n" +
                "14 - Listar Alugueis\n" +
                "15 - ListarAlugueisCliente\n" +
                "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            int op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    CriarLocadora();
                    break;
                case 2:
                    RemoverLocadora();
                    break;
                case 3:
                    ListarLocadoras();
                    break;
                case 4:
                    SelecionarLocadora();
                    break;
                case 5:
                    ListarVeiculosDisponíveis();
                    break;
                case 6:
                    ListarCarrosDisponíveis();
                    break;
                case 7:
                    ListaAviõesDisponíveis();
                    break;
                case 8:
                    ListarTodosOsVeiculos();
                    break;
                case 9:
                    CadastrarCliente();
                    break;
                case 10:
                    ListarClientes();
                    break;
                case 11:
                    SelecionarCliente();
                    break;
                case 12:
                    IniciarAluguel();
                    break;
                case 13:
                    DevolverVeiculo();
                    break;
                case 14:
                    ListarAlugueis();
                    break;
                case 15:
                    AluguelPorCliente();
                    break;
                default:
                    Console.WriteLine("Comando inválido");
                    break;
            }
        }
        public static void CriarLocadora()
        {
            Console.WriteLine("");
            Console.WriteLine("Adicionando locadora...\n" +
            "Insira o nome da sua locadora:");
            string n = Console.ReadLine();
            Console.WriteLine("Insira o endereço da locadora " + n);
            string e = Console.ReadLine();
            RedeLocadoras.AdicionarLocadora(new Locadora(n, e));
            Console.WriteLine($"Locadora {n} foi adicionada com sucesso");
        }
        public static void ListarLocadoras()
        {
            RedeLocadoras.ListarLocadoras();
        }
        public static void RemoverLocadora()
        {
            RedeLocadoras.ListarLocadoras();
            Console.WriteLine("Qual locadora voce deseja remover?");
            string Remover = Console.ReadLine();
            if(RedeLocadoras.RemoverLocadora(Remover))
            {
                Console.WriteLine($"{Remover} removida com sucesso");
            }
            else
            {
                Console.WriteLine($"Não foi possivel encontrar a locadora {Remover}");
            }
            
        }
        public static void SelecionarLocadora()
        {
            string LocadoraBackup = LocadoraSelecionada;
            LocadoraSelecionada = "";
            RedeLocadoras.ListarLocadoras();
            Console.WriteLine(" \n" +
                "Qual locadora voce desejar selecionar?");
            string Selecionar = Console.ReadLine();
            foreach(Locadora loc in RedeLocadoras.Locadoras)
            {
                if(loc.Nome.Equals(Selecionar))
                { 
                    LocadoraSelecionada = loc.Nome;
                    Console.WriteLine($"{Selecionar} foi selecionada!");
                }
            }
            if(LocadoraSelecionada == "")
            {
                Console.WriteLine($"{Selecionar} não foi encontrado na base de dados");
                LocadoraSelecionada = LocadoraBackup;
            }
        }
        public static void ListarVeiculosDisponíveis()
        {
            if (LocadoraSelecionada == "")
            {
                Console.WriteLine("Selecione uma locadora primeiro");
            }
            else
            { 
            foreach (Locadora locadora in RedeLocadoras.Locadoras)
            {

                    if (locadora.Nome == LocadoraSelecionada)
                    {
                        Locadora.ListarVeiculosDisponiveis(LocadoraSelecionada);
                    }              
            }
            }
        }
        public static void ListaAviõesDisponíveis()
        {
            if (LocadoraSelecionada == "")
            {
                Console.WriteLine("Selecione uma locadora primeiro");
            }
            else
            {
                foreach (Locadora locadora in RedeLocadoras.Locadoras)
            {

                    if (locadora.Nome == LocadoraSelecionada)
                    {
                        Locadora.ListarAviõesDisponiveis(LocadoraSelecionada);                        
                    }
                }
            }
        }
        public static void ListarCarrosDisponíveis()
        {
            if (LocadoraSelecionada == "")
            {
                Console.WriteLine("Selecione uma locadora primeiro");
            }
            else
            {
                foreach (Locadora locadora in RedeLocadoras.Locadoras)
                {

                    if (locadora.Nome == LocadoraSelecionada)
                    {
                        Locadora.ListarCarrosDisponiveis(LocadoraSelecionada);
                    }
                }
            }
        }
        public static void ListarTodosOsVeiculos()
        {
            if (LocadoraSelecionada == "")
            {
                Console.WriteLine("Selecione uma locadora primeiro");
            }
            else
            {
                foreach (Locadora locadora in RedeLocadoras.Locadoras)
                {
                        if (locadora.Nome == LocadoraSelecionada)
                        {
                            Locadora.ListarTodosOsVeículos(LocadoraSelecionada);
                        }
                }
            }
        }
            
        
        public static void CadastrarCliente()
        {

            Console.WriteLine(" \n" +
                "Adicionando Cliente... \n" +
                "Insira o nome do cliente: ");
            string nomeCliente = Console.ReadLine();
            Console.WriteLine($"Digite o cpf de {nomeCliente}: ");
            string cpfCliente = Console.ReadLine();

            RedeLocadoras.Clientes.Add(new Cliente(nomeCliente, cpfCliente));

            Console.WriteLine($"Cliente {nomeCliente} foi adicionado com sucesso!!");

        }
        public static void ListarClientes()
        {
            Console.WriteLine("");
            Console.WriteLine("Lista de todos os clientes cadastrados:");
            foreach (Cliente c in RedeLocadoras.Clientes)
            {
                Console.WriteLine($"Nome: {c.Nome} | CPF: {c.Cpf}");
            }
        }
        public static void SelecionarCliente()
        {

            string ClienteBackup = ClienteSelecionado;
            ClienteSelecionado = "";
            ListarClientes();
            Console.WriteLine(" \n" +
            "Qual Cliente você deseja selecionar? ");
            string Selecionar = Console.ReadLine();
            foreach (Cliente c in RedeLocadoras.Clientes)
            {
                if (c.Nome.Equals(Selecionar))
                {
                    ClienteSelecionado = c.Nome;
                    Console.WriteLine($"{c.Nome} foi selecionado!");                 
                }               

            }
            if (ClienteSelecionado == "")
            {
                Console.WriteLine($"{Selecionar} não foi encontrado na base de dados");
                ClienteSelecionado = ClienteBackup;
            }



        }
        public static void IniciarAluguel()
        {
            if(LocadoraSelecionada == "")
            {
                Console.WriteLine("Selecione uma locadora primeiro");
                return;
            }
            if (ClienteSelecionado == "")
            {
                Console.WriteLine("Selecione um cliente primeiro");
                return;
            }
            Listar:
            Locadora.ListarVeiculosDisponiveis(LocadoraSelecionada);


            Console.WriteLine(" \n" +
                "Qual veículo deseja alugar? (Use o ID como referência)");

            string idVeiculoAlugar = Console.ReadLine();
            bool Achou = false; ;

            foreach(VeiculoAluguel v in Locadora.VeiculosAluguel)
            {
                if (v.Id.Equals(idVeiculoAlugar)) 
                {
                    if (v.Locadora == LocadoraSelecionada)
                    {
                        if(v.Alugado == false)
                        {
                            Achou = true;
                            Console.WriteLine("Veiculo selecionado:");
                            if(v.Tipo == "Carro")
                            {
                                Console.WriteLine($"ID: {v.Id} | Tipo: {v.Tipo} | Placa: {v.Placa} | Quilometragem: {v.Quilometragem} | Marca: {v.Marca} | Modelo: {v.Modelo} | Situação: Disponível");
                            }
                            if (v.Tipo == "Avião")
                            {
                                Console.WriteLine($"ID: {v.Id} | Tipo: {v.Tipo} | Horas de Voo: {v.Horasvoo} | Marca: {v.Marca} | Modelo: {v.Modelo} | Situação: Disponível");
                            }
                            Console.WriteLine("");
                            VeiculoSelecionado = v.Id;
                            Console.WriteLine("Por quantos dias será alugado este veículo?");
                            int dias = int.Parse(Console.ReadLine());
                            var hoje = DateTime.Now;
                            var AlugarDias = hoje.AddDays(dias);
                            Locadora.AlugueisAtuais.Add(new Aluguel(v.Id, ClienteSelecionado, LocadoraSelecionada, hoje, AlugarDias));
                            Console.WriteLine("");
                            Console.WriteLine("Aluguel efetuado com sucesso!\n" +
                                " \n" +
                                $"ID: {v.Id} | Tipo: {v.Tipo} | Placa: {v.Placa} | Quilometragem: {v.Quilometragem} | Marca: {v.Marca} | Modelo: {v.Modelo}\n" +
                                $"Alugado por: {ClienteSelecionado}\n" +
                                $"Locadora: {LocadoraSelecionada}\n" +
                                $"Data inicial: {hoje}\n" +
                                $"Data para devolução: {AlugarDias}");
                                v.Alugado = true;
                            
                        }
                        
                    }
                }
            }
            if (Achou == false)
            {
                Console.WriteLine("");
                Console.WriteLine($"Nao foi encontrado nenhum veículo disponível em {LocadoraSelecionada} com o ID: {idVeiculoAlugar}");
                Console.WriteLine("");
                goto Listar;
            }

        }
        public static void DevolverVeiculo()
        {
            Devolver:
            ListarAlugueis();
            Console.WriteLine("");
            Console.WriteLine("Qual dos alugueis deseja devolver? (Use o ID como referência)");
            string idDevolver = Console.ReadLine();
            bool existe = false;
            foreach (Aluguel a in Locadora.AlugueisAtuais)
            {
                if (a.Id.Equals(idDevolver))
                {
                    Console.WriteLine($"Aluguel ID: {a.Id} foi devolvido a {a.Locadora}");
                    foreach (VeiculoAluguel v in Locadora.VeiculosAluguel)
                    {
                        if(v.Id.Equals(idDevolver))
                        {
                            v.Alugado = false;
                            a.Desativado = true;
                            a.Id = "0";
                        }
                    }
                   existe = true;
                }

            }
            if (existe == false)
            {
                Console.WriteLine($"Nenhum aluguel com o ID {idDevolver} foi encontrado");
                goto Devolver;
            }
        }
        public static void ListarAlugueis()
        {
            Console.WriteLine(" \n" +
            "Alugueis cadastrados:");
            foreach (Aluguel a in Locadora.AlugueisAtuais)
            {
                foreach(VeiculoAluguel v in Locadora.VeiculosAluguel)
                {
                    if (v.Id.Equals(a.Id))
                    {
                        if (v.Alugado == true || a.Desativado == false)
                        {
                            Console.WriteLine($"-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                                $"Aluguel ID: {a.Id}\n" +
                                $"Veículo {v.Marca} {v.Modelo}\n" +
                                $"Alugado por: {a.Cliente}\n" +
                                $"Locado por {a.Locadora}\n" +
                                $" \n" +
                                $"Inicio: {a.Inicio}\n" +
                                $"Devolução: {a.Final}\n" +
                                $"-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                        }
                    }
                }

                }
            }

        public static void AluguelPorCliente()
        {
            ListarClientes();            
            Console.WriteLine("Qual dos clientes deseja listar os alugueis?");
            string selecionado = Console.ReadLine();
            bool encontrado = false;
                    encontrado = true;
                    foreach(Aluguel a in Locadora.AlugueisAtuais)
                    {
                        if(a.Cliente.Equals(selecionado))
                        {
                                encontrado = true;
                                Console.WriteLine($"-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n" +
                                $"Aluguel ID: {a.Id}\n" +
                                $"Alugado por: {a.Cliente}\n" +
                                $"Locado por {a.Locadora}\n" +
                                $" \n" +
                                $"Inicio: {a.Inicio}\n" +
                                $"Devolução: {a.Final}\n" +
                                $"-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");                                
                        }
                    }
                
            
            if(encontrado == false)
            {
                Console.WriteLine($"{selecionado} não foi encontrado na base de dados");
            }
        }
        }


    }

