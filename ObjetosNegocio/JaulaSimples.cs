using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    /// <summary>
    /// Classe que representa uma versão simplificada de uma jaula no zoológico.
    /// Contém apenas os atributos ID e capacidade.
    /// </summary>
    public class JaulaSimples
    {
        #region Atributos

        /// <summary>
        /// Identificador único da jaula.
        /// </summary>
        int jaulaId;

        /// <summary>
        /// Capacidade máxima de animais que a jaula pode comportar.
        /// </summary>
        int capacidade;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe JaulaSimples.
        /// </summary>
        public JaulaSimples()
        {
            jaulaId = 0;
            capacidade = 0;
        }

        /// <summary>
        /// Construtor com parâmetros da classe JaulaSimples.
        /// </summary>
        /// <param name="jaulaId">Identificador único da jaula.</param>
        /// <param name="capacidade">Capacidade máxima de animais da jaula.</param>
        public JaulaSimples(int jaulaId, int capacidade)
        {
            this.jaulaId = jaulaId;
            this.capacidade = capacidade;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador único da jaula.
        /// </summary>
        public int JaulaId
        {
            get { return jaulaId; }
            set { jaulaId = value; }
        }

        /// <summary>
        /// Obtém ou define a capacidade máxima de animais da jaula.
        /// </summary>
        public int Capacidade
        {
            get { return capacidade; }
            set { capacidade = value; }
        }

        #endregion
    }



}

