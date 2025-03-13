using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{
    /// <summary>
    /// Classe que representa uma versão simplificada de um Zoológico.
    /// </summary>
    public class ZoologicoSimples
    {
        #region Atributos

        /// <summary>
        /// Identificador da lista de jaulas do zoológico.
        /// </summary>
        int idJaulas;

        /// <summary>
        /// Identificador da lista de bilhetes do zoológico.
        /// </summary>
        int idBilhetes;

        /// <summary>
        /// Identificador da lista de funcionários do zoológico.
        /// </summary>
        int idFuncionarios;

        /// <summary>
        /// Identificador da lista de veterinários do zoológico.
        /// </summary>
        int idVeterinarios;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe ZoologicoSimples.
        /// </summary>
        public ZoologicoSimples()
        {
            idJaulas = 0;
            idBilhetes = 0;
            idFuncionarios = 0;
            idVeterinarios = 0;
        }

        /// <summary>
        /// Construtor com parâmetros da classe ZoologicoSimples.
        /// </summary>
        /// <param name="idJaulas">Identificador das jaulas.</param>
        /// <param name="idBilhetes">Identificador dos bilhetes.</param>
        /// <param name="idFuncionarios">Identificador dos funcionários.</param>
        /// <param name="idVeterinarios">Identificador dos veterinários.</param>
        public ZoologicoSimples( int idJaulas, int idBilhetes, int idFuncionarios, int idVeterinarios)
        {
            this.idJaulas = idJaulas;
            this.idBilhetes = idBilhetes;
            this.idFuncionarios = idFuncionarios;
            this.idVeterinarios = idVeterinarios;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o identificador das jaulas.
        /// </summary>
        public int IdJaulas
        {
            get { return idJaulas; }
            set { idJaulas = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador dos bilhetes.
        /// </summary>
        public int IdBilhetes
        {
            get { return idBilhetes; }
            set { idBilhetes = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador dos funcionários.
        /// </summary>
        public int IdFuncionarios
        {
            get { return idFuncionarios; }
            set { idFuncionarios = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador dos veterinários.
        /// </summary>
        public int IdVeterinarios
        {
            get { return idVeterinarios; }
            set { idVeterinarios = value; }
        }

        #endregion


        #endregion
    }

}
