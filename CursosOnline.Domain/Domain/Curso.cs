using CursosOnline.Domain.Domain.Enum;
using System;

namespace CursosOnline.Domain.Domain
{
    public class Curso
    {
        public string Nome { get; set; }
        
        public double Carga_Horaria { get; set; }
        
        //Refactoring include enum to type PublicoAlvo
        public PublicoAlvo PublicoAlvo { get; set; }
        
        public decimal Valor { get; set; }

        public Curso(string nome, double carga_horaria, PublicoAlvo publico_alvo, decimal valor)
        {
            if(string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("Nome inválido");
            }
            
            this.Nome = nome;
            this.Carga_Horaria = carga_horaria;
            this.PublicoAlvo = publico_alvo;
            this.Valor = valor;
        }
    }
}
