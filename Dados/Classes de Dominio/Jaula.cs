using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    [Serializable]
    /// <summary>
    /// Classe que representa uma jaula no zoológico.
    /// </summary>
    public class Jaula
    {
        #region Atributos

        /// <summary>
        /// Identificador único da jaula.
        /// </summary>
        int jaulaId;

        /// <summary>
        /// Identificador da lista de animais relacionados à jaula.
        /// </summary>
        int idAnimais;

        /// <summary>
        /// Capacidade máxima de animais que a jaula pode comportar.
        /// </summary>
        int capacidade;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Jaula.
        /// </summary>
        public Jaula()
        {
            jaulaId = 0;
            idAnimais = 0;
            capacidade = 0;
        }

        /// <summary>
        /// Construtor com parâmetros da classe Jaula.
        /// </summary>
        /// <param name="jaulaId">Identificador único da jaula.</param>
        /// <param name="capacidade">Capacidade máxima de animais da jaula.</param>
        public Jaula(int jaulaId, int capacidade)
        {
            this.jaulaId = jaulaId;
            this.capacidade = capacidade;
        }

        /// <summary>
        /// Construtor com parâmetros da classe Jaula.
        /// </summary>
        /// <param name="jaulaId">Identificador único da jaula.</param>
        /// <param name="idAnimais">Identificador da lista de animais relacionados à jaula.</param>
        /// <param name="capacidade">Capacidade máxima de animais da jaula.</param>
        public Jaula(int jaulaId, int idAnimais, int capacidade)
        {
            this.jaulaId = jaulaId;
            this.idAnimais = idAnimais;
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
        /// Obtém ou define o identificador da lista de animais relacionados à jaula.
        /// </summary>
        public int IdAnimais
        {
            get { return idAnimais; }
            set { idAnimais = value; }
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

        #endregion
    }


}

