using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Classe que representa um veterinário do zoológico.
    /// </summary>
    public class Veterinario
    {
        #region Atributos

        /// <summary>
        /// Identificador único do veterinário.
        /// </summary>
        int veterinarioId;

        /// <summary>
        /// Nome do veterinário.
        /// </summary>
        string nome;

        /// <summary>
        /// Especialidade do veterinário.
        /// </summary>
        string especialidade;

        /// <summary>
        /// Idade do veterinário.
        /// </summary>
        int idade;

        /// <summary>
        /// Identificador único da lista de consultas associadas ao veterinário.
        /// </summary>
        int idConsultas;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Veterinario.
        /// </summary>
        public Veterinario()
        {
            veterinarioId = 0;
            nome = "";
            especialidade = "";
            idade = 0;
            idConsultas = 0;
        }

        /// <summary>
        /// Construtor com parâmetros da classe Veterinario.
        /// </summary>
        /// <param name="veterinarioId">Identificador único do veterinário.</param>
        /// <param name="idade">Idade do veterinário.</param>
        public Veterinario(int veterinarioId, int idade)
        {
            this.veterinarioId = veterinarioId;
            this.idade = idade;
        }

        /// <summary>
        /// Construtor com parâmetros da classe Veterinario.
        /// </summary>
        /// <param name="veterinarioId">Identificador único do veterinário.</param>
        /// <param name="nome">Nome do veterinário.</param>
        /// <param name="especialidade">Especialidade do veterinário.</param>
        /// <param name="idade">Idade do veterinário.</param>
        /// <param name="idConsultas">Identificador das consultas associadas ao veterinário.</param>
        public Veterinario(int veterinarioId, string nome, string especialidade, int idade, int idConsultas)
        {
            this.veterinarioId = veterinarioId;
            this.nome = nome;
            this.especialidade = especialidade;
            this.idade = idade;
            this.idConsultas = idConsultas;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único do veterinário.
        /// </summary>
        public int VeterinarioId
        {
            get { return veterinarioId; }
            set { veterinarioId = value; }
        }

        /// <summary>
        /// Obtém ou define o nome do veterinário.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define a especialidade do veterinário.
        /// </summary>
        public string Especialidade
        {
            get { return especialidade; }
            set { especialidade = value; }
        }

        /// <summary>
        /// Obtém ou define a idade do veterinário.
        /// </summary>
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador único da lista de consultas associadas ao veterinário.
        /// </summary>
        public int IdConsultas
        {
            get { return idConsultas; }
            set { idConsultas = value; }
        }

        #endregion

        #endregion
    }

}

