using System.ComponentModel;

namespace GrpcServer.Models
{
    public enum ECargo
    {
        [Description("Visitante")]
        Visitante = 0,
        [Description("Membro")]
        Membro = 1,
        [Description("Diácono")]
        Diacono = 2,
        [Description("Obreiro")]
        Obreiro = 3,
        [Description("Secretário")]
        Secretario = 4,
        [Description("Tesoureiro")]
        Tesoureiro = 5,
        [Description("Pastor")]
        Pastor = 6,
        [Description("Administrador")]
        Administrador = 7
    }
}
