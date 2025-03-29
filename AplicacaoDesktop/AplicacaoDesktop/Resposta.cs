using System.ComponentModel;

namespace AplicacaoDesktop
{
    [DefaultValue(Resposta.Desconhecido)]
    public enum Resposta
    {
        [Description("Ok")]
        Ok = 1,

        [Description("Falha na inspeção visual")]
        Falha_na_inspeção_visual = 2,

        [Description("Falha na inspeção de resistência")]
        Falha_na_inspeção_de_resistência = 3,

        [Description("Falha na inspeção de dimensões")]
        Falha_na_inspeção_de_dimensões = 4,

        [Description("Falha na inspeção de estanqueidade")]
        Falha_na_inspeção_de_estanqueidade = 5,

        [Description("Desconhecido")]
        Desconhecido = 6
    }
}