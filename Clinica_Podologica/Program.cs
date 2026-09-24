using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;
namespace Clinica_Podologica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");

                Console.ResetColor();
                Console.ForegroundColor= ConsoleColor.Blue;

                Console.WriteLine(" 1 - Cadastro de Paciente");
                Console.WriteLine(" 2 - Cadastro Médico");
                Console.WriteLine(" 3 - Cadastro Leito");
                Console.WriteLine(" 4 - Registrar Internação ");
                Console.WriteLine(" 5 - Alta Hospitalar");
                Console.WriteLine(" 6 - Listar Pacientes Internados");
                Console.WriteLine(" 7 - Exibir Relatório Geral do HSP");
                Console.WriteLine(" 0 - SAIR");






                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        cadastro_cliente();
                        break;

                    case 2:
                        funcao_medico();
                        break;

                    case 3:
                        funcao_leito();
                        break;

                    case 4:
                        funcao_internacao();
                        break;


                    case 5:
                        alta_hospital();
                        break;

                    case 6:
                        pacientes_internados();
                        break;

                    case 7:
                        relatorio_geral();
                        break;

                    
                    
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Fechando Programa!! ");
                        break;








                }
                  








                






            }

         










        }

        static void cadastro_cliente()
        {
            int id;
            string nome, cpf, tipo_sangue, alergias, Contato_Emg;
            DateTime Data_Nasc;

            Console.Clear();
            Console.ForegroundColor =(ConsoleColor) ConsoleColor.DarkRed;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░

░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");

            Console.ResetColor ();

            Console.WriteLine("Digite o Identificador Único:");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Paciente:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF:");
            cpf = Console.ReadLine();

            Console.WriteLine("Digite a Data de Nascimento:");
            Data_Nasc = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Tipo Sanguineo:");
            tipo_sangue = Console.ReadLine();

            Console.WriteLine("Alergias :");
            alergias = Console.ReadLine();

            Console.WriteLine("Digite o Contato de Emergencia:");
            Contato_Emg = Console.ReadLine();

            Console.WriteLine("\nCadastro Realizado!!!");
            Console.WriteLine("\n" + id);
            Console.WriteLine("\n" + nome);
            Console.WriteLine("\n " + cpf);
            Console.WriteLine("\n " + Data_Nasc);
            Console.WriteLine("\n" + tipo_sangue);
            Console.WriteLine("\n " + alergias);
            Console.WriteLine("\n " + Contato_Emg);

            Thread.Sleep(3000);

        }
     
        
        
        static void funcao_medico()
        {
            int id;
            string nome, crm, especialidade, telefone;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(@"
███████╗██╗░░░██╗███╗░░██╗░█████╗░░█████╗░░█████╗░
██╔════╝██║░░░██║████╗░██║██╔══██╗██╔══██╗██╔══██╗
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝███████║██║░░██║
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██╔══██║██║░░██║
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║░░██║╚█████╔╝
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝░╚════╝░

███╗░░░███╗███████╗██████╗░██╗░█████╗░░█████╗░
████╗░████║██╔════╝██╔══██╗██║██╔══██╗██╔══██╗
██╔████╔██║█████╗░░██║░░██║██║██║░░╚═╝██║░░██║
██║╚██╔╝██║██╔══╝░░██║░░██║██║██║░░██╗██║░░██║
██║░╚═╝░██║███████╗██████╔╝██║╚█████╔╝╚█████╔╝
╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝░╚════╝░░╚════╝░");
            Console.ResetColor();

            Console.WriteLine("Digite o ID do Médico");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Médico:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o CRM:");
            crm = Console.ReadLine();

            Console.WriteLine("Digite a Especialidade");
            especialidade = Console.ReadLine();

            Console.WriteLine("Digite o Telefone:");
            telefone = Console.ReadLine();


            Console.WriteLine("\nCadastro Realizado!!!");
            Console.WriteLine("\n" + id);
            Console.WriteLine("\n" + nome);
            Console.WriteLine("\n" + crm);
            Console.WriteLine("\n" + especialidade);
            Console.WriteLine("\n" + telefone);

            Thread.Sleep(3000);

        }
        static void funcao_leito()
        {
            int id;
            string nmr_quarto, tipo;
            bool estaOcupado;

            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine(@"
███████╗██╗░░░██╗███╗░░██╗░█████╗░░█████╗░░█████╗░  ██╗░░░░░███████╗██╗████████╗░█████╗░
██╔════╝██║░░░██║████╗░██║██╔══██╗██╔══██╗██╔══██╗  ██║░░░░░██╔════╝██║╚══██╔══╝██╔══██╗
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝███████║██║░░██║  ██║░░░░░█████╗░░██║░░░██║░░░██║░░██║
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██╔══██║██║░░██║  ██║░░░░░██╔══╝░░██║░░░██║░░░██║░░██║
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║░░██║╚█████╔╝  ███████╗███████╗██║░░░██║░░░╚█████╔╝
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝░╚════╝░  ╚══════╝╚══════╝╚═╝░░░╚═╝░░░░╚════╝░");
            Console.ResetColor();

            Console.WriteLine("Digite o ID ");
            id =int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Número do Quarto");
            nmr_quarto = Console.ReadLine();

            Console.WriteLine("Digite o Tipo:");
            tipo = Console.ReadLine();

            Console.WriteLine("O Quarto Está Ocupado? (S/N))");
            estaOcupado = Console.ReadLine().ToUpper() == "S";

            Console.WriteLine("\nCadastro Realizado!!!");
            Console.WriteLine("\n" + id);
            Console.WriteLine("\n" + nmr_quarto);
            Console.WriteLine("\n" + tipo);
            Console.WriteLine("\n" + estaOcupado);

            Thread.Sleep(3000);











        }
        static void funcao_internacao()
        {
            int id, cod_pacient, cod_medico, cod_leito;
            DateTime DataEntrada, DataAlta;
            string Diag_Entrada, Status;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
███████╗██╗░░░██╗███╗░░██╗░█████╗░░█████╗░░█████╗░
██╔════╝██║░░░██║████╗░██║██╔══██╗██╔══██╗██╔══██╗
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝███████║██║░░██║
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██╔══██║██║░░██║
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║░░██║╚█████╔╝
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝░╚════╝░

██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║███████║██║░░╚═╝███████║██║░░██║
██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══██║██║░░██╗██╔══██║██║░░██║
██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░");
            Console.ResetColor();

            Console.WriteLine("Digite o Registro de Internação");
            id =int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Código do Paciente: ");
            cod_pacient = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Código do Médico Responsável");
            cod_medico= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Código do Leito:");
            cod_leito= int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Data e Hora da Admissão");
            DataEntrada = DateTime.Now;

            Console.WriteLine("Digite a Data e Hora da Alta");
            DataAlta = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Motivo de Entrada:");
            Diag_Entrada = Console.ReadLine();

            Console.WriteLine("Digite o Status");
            Status = Console.ReadLine();


            Console.WriteLine("\nCadastro Realizado!!!");
            Console.WriteLine("\n " + id);
            Console.WriteLine("\n" + cod_pacient);
            Console.WriteLine("\n" + cod_medico);
            Console.WriteLine("\n" + cod_leito);
            Console.WriteLine("\n" + DataEntrada);
            Console.WriteLine("\n" + DataAlta);
            Console.WriteLine("\n" + Diag_Entrada);
            Console.WriteLine("\n" + Status );

            Thread.Sleep(3000);












        }
        static void alta_hospital()
        {
            string nome_paciente, nome_medico;
            DateTime hr_alta, data_alta;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
░█████╗░██╗░░░░░████████╗░█████╗░  ██╗░░██╗░█████╗░░██████╗██████╗░██╗████████╗░█████╗░██╗░░░░░░█████╗░██████╗░
██╔══██╗██║░░░░░╚══██╔══╝██╔══██╗  ██║░░██║██╔══██╗██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██║░░░░░██╔══██╗██╔══██╗
███████║██║░░░░░░░░██║░░░███████║  ███████║██║░░██║╚█████╗░██████╔╝██║░░░██║░░░███████║██║░░░░░███████║██████╔╝
██╔══██║██║░░░░░░░░██║░░░██╔══██║  ██╔══██║██║░░██║░╚═══██╗██╔═══╝░██║░░░██║░░░██╔══██║██║░░░░░██╔══██║██╔══██╗
██║░░██║███████╗░░░██║░░░██║░░██║  ██║░░██║╚█████╔╝██████╔╝██║░░░░░██║░░░██║░░░██║░░██║███████╗██║░░██║██║░░██║
╚═╝░░╚═╝╚══════╝░░░╚═╝░░░╚═╝░░╚═╝  ╚═╝░░╚═╝░╚════╝░╚═════╝░╚═╝░░░░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝");
            Console.ResetColor();

            Console.WriteLine("Digite o Nome do Paciente:");
            nome_paciente = Console.ReadLine();

            Console.WriteLine("Digite o Nome do Médico que deu Alta:");
            nome_medico = Console.ReadLine();

            Console.WriteLine("Digite a Hora da Alta:");
            hr_alta = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Data da Alta");
            data_alta = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nCadastro Realizado!!!");
            Console.WriteLine("\n" + nome_paciente);
            Console.WriteLine("\n" + nome_medico);
            Console.WriteLine("\n" + hr_alta);
            Console.WriteLine("\n" + data_alta);

            Thread.Sleep(3000);


        }
        static void pacientes_internados()
        {
            int nmr_quarto, cod_paciente;
            string nome_paciente, leito, causa;
            DateTime hr_internacao;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"
██████╗░░█████╗░░█████╗░██╗███████╗███╗░░██╗████████╗███████╗░██████╗
██╔══██╗██╔══██╗██╔══██╗██║██╔════╝████╗░██║╚══██╔══╝██╔════╝██╔════╝
██████╔╝███████║██║░░╚═╝██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░╚█████╗░
██╔═══╝░██╔══██║██║░░██╗██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░░╚═══██╗
██║░░░░░██║░░██║╚█████╔╝██║███████╗██║░╚███║░░░██║░░░███████╗██████╔╝
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═════╝░

██╗███╗░░██╗████████╗███████╗██████╗░███╗░░██╗░█████╗░██████╗░░█████╗░░██████╗
██║████╗░██║╚══██╔══╝██╔════╝██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔════╝
██║██╔██╗██║░░░██║░░░█████╗░░██████╔╝██╔██╗██║███████║██║░░██║██║░░██║╚█████╗░
██║██║╚████║░░░██║░░░██╔══╝░░██╔══██╗██║╚████║██╔══██║██║░░██║██║░░██║░╚═══██╗
██║██║░╚███║░░░██║░░░███████╗██║░░██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═════╝░");
            Console.ResetColor();

            Console.WriteLine("Digite o Nome do Paciente:");
            nome_paciente = Console.ReadLine();

            Console.WriteLine("Digite o Código do Paciente:");
            cod_paciente = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Número do Quarto");
            nmr_quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Leito:");
            leito = Console.ReadLine();

            Console.WriteLine("Digite a Causa de Internação:");
            causa = Console.ReadLine();

            Console.WriteLine("Digite a Hora da Internação:");
            hr_internacao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nCadastro Realizado!!!");
            Console.WriteLine("\n" + nome_paciente);
            Console.WriteLine("\n" + cod_paciente);
            Console.WriteLine("\n" + nmr_quarto);
            Console.WriteLine("\n" + leito);
            Console.WriteLine("\n" + causa);
            Console.WriteLine("\n" + hr_internacao);

            Thread.Sleep(3000);

            }
        static void relatorio_geral()
        {
            int qnt_pacientes_registrados,leitos_disponiveis,leitos_ocupados, altas, nmr_atendimentos;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(@"
██████╗░███████╗██╗░░░░░░█████╗░████████╗░█████╗░██████╗░██╗░█████╗░  ░██████╗░███████╗██████╗░░█████╗░██╗░░░░░
██╔══██╗██╔════╝██║░░░░░██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗██║██╔══██╗  ██╔════╝░██╔════╝██╔══██╗██╔══██╗██║░░░░░
██████╔╝█████╗░░██║░░░░░███████║░░░██║░░░██║░░██║██████╔╝██║██║░░██║  ██║░░██╗░█████╗░░██████╔╝███████║██║░░░░░
██╔══██╗██╔══╝░░██║░░░░░██╔══██║░░░██║░░░██║░░██║██╔══██╗██║██║░░██║  ██║░░╚██╗██╔══╝░░██╔══██╗██╔══██║██║░░░░░
██║░░██║███████╗███████╗██║░░██║░░░██║░░░╚█████╔╝██║░░██║██║╚█████╔╝  ╚██████╔╝███████╗██║░░██║██║░░██║███████╗
╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝░╚════╝░  ░╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝");
            Console.ResetColor();



            Console.WriteLine("Digite a Quantidade de Registros:");
            qnt_pacientes_registrados = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade de Leitos Disponiveis:");
            leitos_disponiveis = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade de Leitos Ocupados:");
            leitos_ocupados = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade de Altas:");
            altas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Número de Atendimentos");
            nmr_atendimentos = int.Parse(Console.ReadLine());


            Thread.Sleep(3000);










        }















        



















        











    }
}
