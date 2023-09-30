using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Alunos
    {
        public int matricula;
        public string nome;
        public string disciplina;
        public double notaProva1;
        public double notaProva2;
        public double notaTrabalho;
        public double media;
        public List<int> matriculados = new();
        public List<Alunos> alunos = new();

        internal Alunos(int matricula, string nome, string disciplina, double notaProva1, double notaProva2, double notaTrabalho)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.disciplina = disciplina;
            this.notaProva1 = notaProva1;
            this.notaProva2 = notaProva2;
            this.notaTrabalho = notaTrabalho;
            this.media = Math.Round(((notaProva1 + notaProva2) * 2.5D) / 7, 2);
        }



    }
}