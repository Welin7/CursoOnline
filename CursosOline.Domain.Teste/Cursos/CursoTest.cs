using CursosOline.Domain.Teste.Utilidades;
using CursosOnline.Domain.Domain;
using CursosOnline.Domain.Domain.Enum;
using System;
using Xunit;

namespace CursosOline.Domain.Teste.Cursos
{
    public class CursoTest
    {
        //Test green
        [Fact (DisplayName = "CriarCurso")]
        public void Curso_Criar_Curso_Retornar_Curso()
        {
            var Curso_Esperado = new
            {
                Nome = "Curso de C# utilizando TDD",
                Carga_Horaria = (double)80,
                //Refactoring include enum PublicoAlvo
                Publico_Alvo = PublicoAlvo.Estudante,
                Valor = (decimal)500               
            };

            var curso = new Curso(Curso_Esperado.Nome, Curso_Esperado.Carga_Horaria, Curso_Esperado.Publico_Alvo, Curso_Esperado.Valor);
            Assert.Equal(Curso_Esperado.Nome, curso.Nome);
            Assert.Equal(Curso_Esperado.Carga_Horaria, curso.Carga_Horaria);
            Assert.Equal(Curso_Esperado.Publico_Alvo, curso.PublicoAlvo);
            Assert.Equal(Curso_Esperado.Valor, curso.Valor);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Curso_DescricaoVazia_OuNulo_Retornar_Argument_Exception(string Nome_Invalido)
        {
            var Curso_Esperado = new
            {
                Nome = "Curso de C# utilizando TDD",
                Carga_Horaria = (double)80,
                //Refactoring include enum PublicoAlvo
                Publico_Alvo = PublicoAlvo.Estudante,
                Valor = (decimal)500
            };

            Assert.Throws<ArgumentException>(() => new Curso(Nome_Invalido, Curso_Esperado.Carga_Horaria, Curso_Esperado.Publico_Alvo, Curso_Esperado.Valor));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void Curso_Carga_Horaria_Menor_Que_Um_Retornar_Argument_Exception(double Carga_Horaria_Invalida)
        {
            var mensagemError = "Parâmetros inválidos";
            
            var Curso_Esperado = new
            {
                Nome = "Curso de C# utilizando TDD",
                Carga_Horaria = (double)80,
                //Refactoring include enum PublicoAlvo
                Publico_Alvo = PublicoAlvo.Estudante,
                Valor = (decimal)500
            };

            Assert.Throws<ArgumentException>(() => new Curso(Curso_Esperado.Nome, Carga_Horaria_Invalida, Curso_Esperado.Publico_Alvo, Curso_Esperado.Valor)).Validar_Mensagem(mensagemError);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        public void Curso_Valor_Menor_Que_Um_Retornar_Argument_Exception(decimal Valor_Invalido)
        {
            var mensagemError = "Parâmetros inválidos";

            var Curso_Esperado = new
            {
                Nome = "Curso de C# utilizando TDD",
                Carga_Horaria = (double)80,
                //Refactoring include enum PublicoAlvo
                Publico_Alvo = PublicoAlvo.Estudante,
                Valor = (decimal)500
            };

            Assert.Throws<ArgumentException>(() => new Curso(Curso_Esperado.Nome, Curso_Esperado.Carga_Horaria, Curso_Esperado.Publico_Alvo, Valor_Invalido)).Validar_Mensagem(mensagemError);
        }
    }
}
