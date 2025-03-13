using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNegocio
{

    /// <summary>
    /// Classe que representa uma versão simplificada de um animal no zoológico.
    /// Contém apenas os atributos ID, nome, especie e ID da jula à qual está associado.
    /// </summary>
    public class AnimalSimples
    {
        #region Atributos

        /// <summary>
        /// ID único do animal.
        /// </summary>
        int animalId;

        /// <summary>
        /// Nome do animal.
        /// </summary>
        string nome;

        /// <summary>
        /// Espécie do animal.
        /// </summary>
        string especie;

        /// <summary>
        /// Identificador da jaula do animal.
        /// </summary>
        int jaulaId;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe AnimalSimples.
        /// </summary>
        public AnimalSimples()
        {
            animalId = 0;
            nome = "";
            especie = "";
            jaulaId = 0;
        }

        /// <summary>
        /// Construtor com parâmetros da classe AnimalSimples.
        /// </summary>
        /// <param name="animalId">ID único do animal.</param>
        /// <param name="nome">Nome do animal.</param>
        /// <param name="especie">Espécie do animal.</param>
        /// <param name="jaulaId">Identificador da jaula do animal.</param>
        public AnimalSimples(int animalId, string nome, string especie, int jaulaId)
        {
            this.animalId = animalId;
            this.nome = nome;
            this.especie = especie;
            this.jaulaId = jaulaId;
        }

        #endregion

        #region Propriedades

        /// <summary>
        /// Obtém ou define o ID único do animal.
        /// </summary>
        public int AnimalId
        {
            get { return animalId; }
            set { animalId = value; }
        }

        /// <summary>
        /// Obtém ou define o nome do animal.
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obtém ou define a espécie do animal.
        /// </summary>
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        /// <summary>
        /// Obtém ou define o identificador da jaula do animal.
        /// </summary>
        public int JaulaId
        {
            get { return jaulaId; }
            set { jaulaId = value; }
        }

        #endregion
    }


}
