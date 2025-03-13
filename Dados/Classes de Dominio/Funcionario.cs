using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    /// <summary>
    /// Enumerado que representa os turnos de trabalho.
    /// </summary>
    public enum TurnoFunc
    {
        Manha = 0,
        Tarde = 1,
        Noite = 2
    }

    [Serializable]
    /// <summary>
    /// Classe que representa um funcionário do zoológico.
    /// </summary>
    public class Funcionario
    {
        #region Atributos

        /// <summary>
        /// Identificador único do funcionário.
        /// </summary>
        int funcionarioId;

        /// <summary>
        /// Nome do funcionário.
        /// </summary>
        string nome;

        /// <summary>
        /// Função ou cargo do funcionário.
        /// </summary>
        string funcao;

        /// <summary>
        /// Turno de trabalho do funcionário.
        /// </summary>
        TurnoFunc turno;

        /// <summary>
        /// Idade do funcionário.
        /// </summary>
        int idade;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Funcionario.
        /// </summary>
        public Funcionario()
        {
            funcionarioId = 0;
            nome = "";
            funcao = "";
            turno = TurnoFunc.Manha;
            idade = 0; 
        }

        /// <summary>
        /// Construtor com parâmetros da classe Funcionario.
        /// </summary>
        /// <param name="funcionarioId">Identificador único do funcionário.</param>
        /// <param name="idade">Idade do funcionário.</param>
        public Funcionario(int funcionarioId, int idade)
        {
            this.funcionarioId = funcionarioId;
            this.idade = idade;
        }

        /// <summary>
        /// Construtor com parâmetros da classe Funcionario.
        /// </summary>
        /// <param name="funcionarioId">Identificador único do funcionário.</param>
        /// <param name="nome">Nome do funcionário.</param>
        /// <param name="funcao">Função ou cargo do funcionário.</param>
        /// <param name="turno">Turno de trabalho do funcionário.</param>
        /// <param name="idade">Idade do funcionário.</param>
        public Funcionario(int funcionarioId, string nome, string funcao, TurnoFunc turno, int idade)
        {
            this.funcionarioId = funcionarioId;
            this.nome = nome;
            this.funcao = funcao;
            this.turno = turno;
            this.idade = idade;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador do funcionário.
        /// </summary>
        public int FuncionarioId
        {
            get { return funcionarioId; }
            set { funcionarioId = value; }
        }

        /// <summary>
        /// Obtém ou define o nome do funcionário.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define a função do funcionário.
        /// </summary>
        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }

        /// <summary>
        /// Obtém ou define o turno do funcionário.
        /// </summary>
        public TurnoFunc Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        /// <summary>
        /// Obtém ou define a idade do funcionário.
        /// </summary>
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        #endregion

        #endregion
    }

}
