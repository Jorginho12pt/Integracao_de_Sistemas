using System.ComponentModel;

namespace AplicacaoDesktop_2_RabbitMQ
{
    [DefaultValue(Resposta.Desconhecido)]
    public enum Resposta
    {
        [Description("Ok")]
        Ok = 1,

        [Description("Falha na inspecao visual")]
        Falha_na_inspeção_visual = 2,

        [Description("Falha na inspecao de resistencia")]
        Falha_na_inspeção_de_resistência = 3,

        [Description("Falha na inspecao de dimensoes")]
        Falha_na_inspeção_de_dimensões = 4,

        [Description("Falha na inspecao de estanqueidade")]
        Falha_na_inspeção_de_estanqueidade = 5,

        [Description("Desconhecido")]
        Desconhecido = 6
    }
}
