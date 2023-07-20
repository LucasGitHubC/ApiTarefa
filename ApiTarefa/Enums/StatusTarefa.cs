using System.ComponentModel;

namespace ApiTarefa.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        AFaxer = 1,

        [Description("EmAndamento")]
        EmAndamento = 2,

        [Description("Concluido")]
        Concluido = 3,
    }
}
