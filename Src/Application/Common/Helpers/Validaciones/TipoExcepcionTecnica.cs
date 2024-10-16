using System.ComponentModel;

namespace Application.Common.Helpers.Validaciones
{
    public enum TipoExcepcionTecnica
    {
        [Description("El campo de EventType no puede ser vacio")]
        EventTypeEmpty = 1,

        [Description("El campo de Description no puede ser vacio")]
        DescriptionEmpty = 2,

        [Description("El campo de DateEvent no puede ser vacio")]
        DateEventEmpty = 3,
    }
}
