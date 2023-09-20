using System.ComponentModel;

namespace ArchSoft.Enums.Environments
{
    public enum BREnvironment
    {
        [Description("Indefinido")]
        None,

        [Description("Local")]
        Local,

        [Description("Desenvolvimento")]
        Desenvolvimento,

        [Description("Homologação")]
        Homologacao,

        [Description("Produção")]
        Producao,

        [Description("Teste")]
        Teste
    }
}
