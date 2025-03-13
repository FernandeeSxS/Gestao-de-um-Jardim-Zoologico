using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    /// <summary>
    /// Classe que representa uma versão simplificada de um veterinario no zoológico.
    /// Contém apenas os atributos ID e idade.
    /// </summary>
    public class VeterinarioSimples
    {
        #region Atributos

        /// <summary>
        /// Identificador único do veterinário.
        /// </summary>
        int veterinarioId;

        /// <summary>
        /// Idade do veterinário.
        /// </summary>
        int idade;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe VeterinarioSimples.
        /// </summary>
        public VeterinarioSimples()
        {
            veterinarioId = 0;
            idade = 0;
        }

        /// <summary>
        /// Construtor com parâmetros da classe VeterinarioSimples.
        /// </summary>
        /// <param name="veterinarioId">Identificador único do veterinário.</param>
        /// <param name="idade">Idade do veterinário.</param>
        public VeterinarioSimples(int veterinarioId, int idade)
        {
            this.veterinarioId = veterinarioId;
            this.idade = idade;
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
        /// Obtém ou define a iade do veterinário.
        /// </summary>
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        #endregion
    }

}

