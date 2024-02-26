using System;
using System.Collections.Generic;

namespace DAL.DevEntities;

public partial class tbldata_answer
{
    public int id { get; set; }

    public int? questionid { get; set; }

    public string? answer { get; set; }

    public string? text_for_question { get; set; }

    public virtual tbldata_questiondetail? question { get; set; }
}
