using System;
using Xunit;

namespace CursosOline.Domain.Teste.Utilidades
{
    public static class AssertExtension
    {
        public static void Validar_Mensagem(this ArgumentException argument_Exception, string Mensagem_Error)
        {
            if(argument_Exception.Message == Mensagem_Error)
            {
                Assert.True(true);
            }
            else
            {
                Assert.False(true, $" A Mensagem esperada eh {Mensagem_Error}");
            }
        }
    }
}
