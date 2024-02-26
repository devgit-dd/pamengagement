using System;
using System.Collections.Generic;

namespace DAL.DevEntities;

public partial class tbldata_response
{
    public int id { get; set; }

    public string? teamname { get; set; }

    public int? scores { get; set; }

    public decimal? responsetime { get; set; }
}
