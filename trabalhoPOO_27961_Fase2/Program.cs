using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegrasNegocio;
using ObjetosNegocio;

namespace Frontend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Jaulas

            RegrasJaulas jaulas1 = new RegrasJaulas(1);
            RegrasJaulas jaulas2 = new RegrasJaulas(2);

            JaulaSimples jaula1 = new JaulaSimples(1, 10);
            JaulaSimples jaula2 = new JaulaSimples(2, 15);
            JaulaSimples jaula3 = new JaulaSimples(3, -1);

            try
            {
                bool h = jaulas1.AdicionarJaulaSimples(jaula1);
                bool j = jaulas1.AdicionarJaulaSimples(jaula2);
                //bool k = jaulas1.AdicionarJaulaSimples(jaula3);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            try
            {
                bool h = jaulas1.GuardarJaulasFicheiro("Jaulas");
                bool j = jaulas2.CarregarJaulasFicheiro("Jaulas");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            #endregion

            #region Animais
            AnimalSimples animal1 = new AnimalSimples(1, "Mufasa", "Leão", jaula1.JaulaId);
            AnimalSimples animal2 = new AnimalSimples(2, "Jota", "Elefante", jaula2.JaulaId);
            AnimalSimples animal3 = new AnimalSimples(3, "Bambi", "Veado", jaula3.JaulaId);

            RegrasAnimais animais1 = new RegrasAnimais(1);

            try
            {
                bool f = animais1.AdicionarAnimalSimples(animal3);
                // bool g = animais1.AdicionarAnimal(animal2);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            #endregion

            #region Veterinarios

            RegrasVeterinarios vets1 = new RegrasVeterinarios(1);
            RegrasVeterinarios vets2 = new RegrasVeterinarios(2);

            VeterinarioSimples vet1 = new VeterinarioSimples(1, 34);
            VeterinarioSimples vet2 = new VeterinarioSimples(2, 21);
            VeterinarioSimples vet3 = new VeterinarioSimples(3, 18);

            try
            {
                bool a = vets1.AdicionarVeterinarioSimples(vet1);
                bool b = vets1.AdicionarVeterinarioSimples(vet2);
                //bool c = vets1.AdicionarVeterinarioSimples(vet3);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            try
            {
                bool d = vets1.GuardarVeterinariosFicheiro("Veterinarios");
                bool f = vets2.CarregarVeterinariosFicheiro("Veterinarios");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            #endregion

            #region Consultas

            RegrasConsultas consultas1 = new RegrasConsultas(1);
            RegrasConsultas consultas2 = new RegrasConsultas(2);

            ConsultaSimples c1 = new ConsultaSimples(1, new DateTime(2024, 12, 1, 18, 0, 0), animal1.AnimalId, vet1.VeterinarioId);
            ConsultaSimples c2 = new ConsultaSimples(2, new DateTime(2024, 12, 12, 18, 0, 0), animal3.AnimalId, vet2.VeterinarioId);
            ConsultaSimples c3 = new ConsultaSimples(3, new DateTime(2024, 12, 20, 18, 0, 0), animal2.AnimalId, vet1.VeterinarioId);

            try
            {
                bool a = consultas1.AdicionarConsultaSimples(c1);
                bool b = consultas1.AdicionarConsultaSimples(c2);
                //bool c = consultas1.AdicionarConsultaSimples(c3);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            try
            {
                bool d = consultas1.GuardarConsultasFicheiro("Consultas");
                bool f = consultas2.CarregarConsultasFicheiro("Consultas");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            #endregion

            #region Eventos

            EventoSimples evento1 = new EventoSimples(1, new DateTime(2024, 12, 20, 18, 0, 0), 1, TipoEvento.Espetaculo);
            EventoSimples evento2 = new EventoSimples(2, new DateTime(2024, 12, 20, 10, 0, 0), 1, TipoEvento.LimpezaJaula);
            EventoSimples evento3 = new EventoSimples(3, new DateTime(2024, 12, 10, 14, 0, 0), 1, TipoEvento.AlimentacaoAnimal);

            try
            {
                RegrasEventos.AdicionarEventoSimples(evento1);
                RegrasEventos.AdicionarEventoSimples(evento2);
                //RegrasEventos.AdicionarEvento(evento3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            List<EventoSimples> eventos = RegrasEventos.ObterEventosPorDiaSimples(evento1.Data);
            foreach (EventoSimples evento in eventos)
            {
                Console.WriteLine($"  ID: {evento.EventoId}\n");
                Console.WriteLine($"  Data do Evento: {evento.Data.ToString("dd/MM/yyyy HH:mm")}\n");
                Console.WriteLine($"  Descrição: {evento.TipoEvento}\n");
                Console.WriteLine($"  ID da lista de Funcionarios Responaveis: {evento.IdFuncionarios}\n");
            }

            #endregion

            #region Funcionarios

            RegrasFuncionarios funcs1 = new RegrasFuncionarios(1);
            RegrasFuncionarios funcs2 = new RegrasFuncionarios(2);

            FuncionarioSimples func1 = new FuncionarioSimples(1, 34);
            FuncionarioSimples func2 = new FuncionarioSimples(2, 22);
            FuncionarioSimples func3 = new FuncionarioSimples(3, 15);

            try
            {
                bool a = funcs1.AdicionarFuncionarioSimples(func1);
                bool b = funcs1.AdicionarFuncionarioSimples(func2);
                //bool c = funcs1.AdicionarFuncionarioSimples(func3);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            try
            {
                bool h = funcs1.GuardarFuncionariosFicheiro("Funcionarios");
                bool j = funcs2.CarregarFuncionariosFicheiro("Funcionarios");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            #endregion

            #region Bilhetes

            RegrasBilhetes bilhetes1 = new RegrasBilhetes(1);

            BilheteSimples b1 = new BilheteSimples("A1", new DateTime(2024, 12, 20, 18, 0, 0));
            BilheteSimples b2 = new BilheteSimples("A2", new DateTime(2024, 12, 10, 18, 0, 0));
            BilheteSimples b3 = new BilheteSimples("C1", new DateTime(2024, 12, 20, 10, 0, 0));

            try
            {
                bilhetes1.AdicionarBilheteSimples(b1);
                bilhetes1.AdicionarBilheteSimples(b2);
                bilhetes1.AdicionarBilheteSimples(b3);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            try
            {
                bilhetes1.AlterarPrecoBilhetesPorData(new DateTime(2024, 12, 20), 22.00);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            #endregion

            #region Zoologico

            RegrasZoologico zoologico = new RegrasZoologico();

            ZoologicoSimples zS = new ZoologicoSimples(1, 1, 1, 1);
            try
            {
                zoologico.AtualizarNomeZoologico(zS, "SantoInaci");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            #endregion
        }
    }
}

