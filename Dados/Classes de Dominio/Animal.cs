using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{

    /// <summary>
    /// Enumerado que representa os possíveis estados de saúde do animal.
    /// </summary>
    public enum EstadoSaude
    {
        Saudavel = 0,
        EmTratamento = 1
    }

    /// <summary>
    /// Classe que representa um animal no zoológico.
    /// </summary>
    public class Animal : IComparable
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
        /// Idade do animal em anos.
        /// </summary>
        int idade;

        /// <summary>
        /// Identificador da jaula do animal.
        /// </summary>
        int jaulaId;

        /// <summary>
        /// Estado de saúde do animal.
        /// </summary>
        EstadoSaude saude;

        /// <summary>
        /// Tipo de alimentação do animal.
        /// </summary>
        string tipoAlimentacao;

        #endregion

        #region Métodos

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Animal.
        /// </summary>
        public Animal()
        {
            animalId = 0; 
            nome = "";
            especie = "";
            idade = 0;
            saude = EstadoSaude.Saudavel;
            tipoAlimentacao = "";
            jaulaId = 0;
        }

        /// <summary>
        /// Construtor com parâmetros da classe Animal.
        /// </summary>
        /// <param name="animalId">ID único do animal.</param>
        /// <param name="nome">Nome do animal.</param>
        /// <param name="especie">Espécie do animal.</param>
        public Animal(int animalId, string nome, string especie, int jaulaId)
        {
            this.animalId = animalId;
            this.nome = nome;
            this.especie = especie;
            this.jaulaId = jaulaId;
        }

        /// <summary>
        /// Construtor com parâmetros da classe Animal.
        /// </summary>
        /// <param name="animalId">ID único do animal.</param>
        /// <param name="nome">Nome do animal.</param>
        /// <param name="especie">Espécie do animal.</param>
        /// <param name="idade">Idade do animal em anos.</param>
        /// <param name="saude">Estado de saúde do animal.</param>
        /// <param name="tipoAlimentacao">Tipo de alimentação do animal.</param>
        public Animal(int animalId, string nome, string especie, int idade, EstadoSaude saude, string tipoAlimentacao, int jaulaId)
        {
            this.animalId = animalId;
            this.nome = nome;
            this.especie = especie;
            this.idade = idade;
            this.saude = saude;
            this.tipoAlimentacao = tipoAlimentacao;
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
        /// Obtém ou define a idade do animal em anos.
        /// </summary>
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        /// <summary>
        /// Obtém ou define o estado de saúde do animal.
        /// </summary>
        public EstadoSaude Saude
        {
            get { return saude; }
            set { saude = value; }
        }

        /// <summary>
        /// Obtém ou define o tipo de alimentação do animal.
        /// </summary>
        public string TipoAlimentacao
        {
            get { return tipoAlimentacao; }
            set { tipoAlimentacao = value; }
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

        #region Outros Métodos

        /// <summary>
        /// Método de comparação para ordenar os animais por nome.
        /// </summary>
        /// <param name="o">Outro objeto do tipo Animal</param>
        /// <returns>Resultado da comparação</returns>
        public int CompareTo(Object o)
        {
            if (!(o is Animal))
                throw new ArgumentException();

            Animal a = o as Animal;
            return a.nome.CompareTo(this.nome);
        }

        #endregion

        #endregion

    }

}
