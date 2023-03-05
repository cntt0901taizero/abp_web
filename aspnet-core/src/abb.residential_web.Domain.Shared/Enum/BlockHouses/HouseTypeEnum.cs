using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace abb.residential_web.Enum
{
    public enum HouseTypeEnum
    {
        [Display(Name = "Chưa rõ")]
        Undefined = 0,

        [Display(Name = "Căn Studio")]
        Studio = 1,

        [Display(Name = "Căn Officetel")]
        Officetel = 2,

        [Display(Name = "Căn Shophouse")]
        Shophouse = 3,

        [Display(Name = "Căn Dualkey")]
        Dualkey = 4,

        [Display(Name = "Căn Penhouse")]
        Penhouse = 5,

        [Display(Name = "Căn Duplex")]
        Duplex = 6,

        [Display(Name = "Căn Skyvilla")]
        Skyvilla = 7,

        [Display(Name = "Căn Thường")]
        Normal = 8,
    }
}
