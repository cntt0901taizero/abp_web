using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace abb.residential_web.Enum
{
    public enum FloorsTypeEnum
    {
        [Display(Name = "Chưa rõ")]
        Undefined = 0,

        [Display(Name = "Tầng Căn hộ")]
        CanHo = 1,

        [Display(Name = "Tầng Văn phòng")]
        VanPhong = 2,

        [Display(Name = "Tầng Thương mại")]
        ThuongMai = 3,

        [Display(Name = "Tầng Kỹ thuật")]
        KyThuat = 4,

        [Display(Name = "Tầng hầm")]
        TangHam = 5,
    }
}
