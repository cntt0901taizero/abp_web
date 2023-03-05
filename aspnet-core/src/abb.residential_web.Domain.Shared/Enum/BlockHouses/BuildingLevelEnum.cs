using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace abb.residential_web.Enum
{
    public enum BuildingLevelEnum
    {
        [Display(Name = "Undefined")]
        Undefined = 0,

        [Display(Name = "Hạng A")]
        Level_A = 1,

        [Display(Name = "Hạng A")]
        Level_B = 1,

        [Display(Name = "Hạng A")]
        Level_C = 1,
    }
}
