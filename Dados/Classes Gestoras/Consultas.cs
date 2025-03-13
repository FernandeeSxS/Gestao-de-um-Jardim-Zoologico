using ObjetosNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Classe que gere uma lista de objetos do tipo Consulta.
    /// </summary>
    public class Consultas
    {
        #region Atributos

        /// <summary>
        /// Identificador único da lista de consultas.
        /// </summary>
        int idConsultas;

        /// <summary>
        /// Lista de consultas.
        /// </summary>
        List<Consulta> consultas;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Consultas.
        /// Inicializa a lista de consultas e define o identificador padrão.
        /// </summary>
        public Consultas()
        {
            idConsultas = 0;
            consultas = new List<Consulta>();
        }

        /// <summary>
        /// Construtor com parâmetros da classe Consultas.
        /// Inicializa a lista de consultas e atribui um identificador.
        /// </summary>
        /// <param name="idConsultas">Identificador único da lista de consultas.</param>
        public Consultas(int idConsultas)
        {
            this.idConsultas = idConsultas;
            consultas = new List<Consulta>();
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da lista de consultas.
        /// </summary>
        public int IdConsultas
        {
            get { return idConsultas; }
            set { idConsultas = value; }
        }

        #endregion

        #region Outros Métodos para Consulta

        /// <summary>
        /// Adiciona uma consulta à lista.
        /// </summary>
        /// <param name="consulta">Consulta a ser adicionada.</param>
        /// <returns>Retorna true se a consulta foi adicionada com sucesso; caso contrário, retorna false.</returns>
        public bool AdicionarConsulta(Consulta consulta)
        {
            if (!consultas.Contains(consulta) || consulta == null)
            {
                consultas.Add(consulta);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna a consulta com base no ID.
        /// </summary>
        /// <param name="id">ID da consulta.</param>
        /// <returns>Retorna a consulta procurada ou null caso não encontre.</returns>
        public Consulta EncontrarConsulta(int id)
        {
            return consultas.Find(c => c.ConsultaId == id);
        }

        /// <summary>
        /// Remove uma consulta da lista com base no ID.
        /// </summary>
        /// <param name="id">ID da consulta a ser removida.</param>
        /// <returns>Retorna true se a consulta foi removida com sucesso; caso contrário, retorna false.</returns>
        public bool RemoverConsulta(int id)
        {
            Consulta consulta = EncontrarConsulta(id);
            if (consulta != null)
            {
                consultas.Remove(consulta);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Ordena as consultas pela data da consulta.
        /// </summary>
        public bool OrdenarPorData()
        {
            if (consultas == null || consultas.Count == 0)
            {
                return false;
            }

            consultas.Sort();
            return true;
        }

        /// <summary>
        /// Preserva a lista de consultas num ficheiro binário.
        /// </summary>
        /// <param name="fileName">Caminho e nome do ficheiro onde os dados serão gravados.</param>
        /// <returns>Retorna true se os dados foram gravados com sucesso, caso contrário, retorna false.</returns>
        public bool SaveConsultas(string fileName)
        {
            try
            {
                if (!OrdenarPorData())
                {
                    throw new Exception();
                }

                Stream stream = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, this);

                stream.Close();

                return true;
            }
            catch (IOException e)
            {
                throw new IOException(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Carrega a lista de consultas a partir de um ficheiro binário.
        /// </summary>
        /// <param name="fileName">Caminho/nome do ficheiro de onde os dados serão carregados.</param>
        /// <returns>Retorna true se os dados foram carregados com sucesso, caso contrário, retorna false.</returns>
        public bool LoadConsultas(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    throw new FileNotFoundException();
                }

                Stream stream = File.Open(fileName, FileMode.Open);
                BinaryFormatter bin = new BinaryFormatter();

                Consultas consultasDeserializadas = (Consultas)bin.Deserialize(stream);
                stream.Close();

                this.idConsultas = consultasDeserializadas.idConsultas;
                this.consultas = consultasDeserializadas.consultas;

                return true;
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Verifica se já existe uma consulta com a mesma data e hora.
        /// </summary>
        /// <param name="consulta">A consulta a ser verificada.</param>
        /// <returns>Retorna true se já existir uma consulta para a mesma data e hora, caso contrário, retorna false.</returns>
        public bool ConsultaExistente(Consulta consulta)
        {
            if (consultas.Any(c => c.DataConsulta == consulta.DataConsulta))
            {
                return true;
            }
            return false;
        }

        #endregion

        #region Outros Métodos para ConsultaSimples

        /// <summary>
        /// Adiciona uma consulta simples à lista.
        /// </summary>
        /// <param name="cS">Consulta simples a ser adicionada.</param>
        /// <returns>Retorna true se a consulta foi adicionada com sucesso; caso contrário, retorna false.</returns>
        public bool AdicionarConsultaSimples(ConsultaSimples cS)
        {
            Consulta consulta = new Consulta(cS.ConsultaId, cS.DataConsulta, cS.AnimalId, cS.VeterinarioId);
            bool a = AdicionarConsulta(consulta);
            return a;
        }

        /// <summary>
        /// Verifica se uma consulta simples já existe na lista de consultas.
        /// </summary>
        /// <param name="cS">Consulta simples a ser verificada.</param>
        /// <returns>Retorna true se a consulta simples já existir, caso contrário, retorna false.</returns>
        public bool ConsultaSimplesExistente(ConsultaSimples cS)
        {
            Consulta consulta = new Consulta(cS.ConsultaId, cS.DataConsulta, cS.AnimalId, cS.VeterinarioId);
            bool a = ConsultaExistente(consulta);
            return a;
        }

    }

    #endregion

    #endregion
}

