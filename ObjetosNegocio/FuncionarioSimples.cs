using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    /// <summary>
    /// Classe que representa uma versão simplificada de um funcionario no zoológico.
    /// Contém apenas os atributos ID e idade.
    /// </summary>
    public class FuncionarioSimples
    {
        #region Atributos

        /// <summary>
        /// Identificador único do funcionário.
        /// </summary>
        int funcionarioId;

        /// <summary>
        /// Idade do funcionário.
        /// </summary>
        int idade;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe FuncionarioSimples.
        /// </summary>
        public FuncionarioSimples()
        {
            funcionarioId = 0;
            idade = 0;
        }

        /// <summary>
        /// Construtor com parâmetros da classe FuncionarioSimples.
        /// </summary>
        /// <param name="funcionarioId">Identificador único do funcionário.</param>
        /// <param name="idade">Idade do funcionário.</param>
        public FuncionarioSimples(int funcionarioId, int idade)
        {
            this.funcionarioId = funcionarioId;
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
        /// Obtém ou define a idade do funcionário.
        /// </summary>
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        #endregion
    }

}