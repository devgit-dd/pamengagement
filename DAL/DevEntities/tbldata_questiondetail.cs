using System;
using System.Collections.Generic;

namespace DAL.DevEntities;

public partial class tbldata_questiondetail
{
    public int id { get; set; }

    public string? name { get; set; }

    public string? imagepath { get; set; }

    public string? hinttext { get; set; }

    public virtual ICollection<tbldata_answer> tbldata_answers { get; set; } = new List<tbldata_answer>();
}
