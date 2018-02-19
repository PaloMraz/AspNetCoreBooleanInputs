using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreBooleanInputs.Models
{
  public class BooleanInputsViewModel
  {
    public bool IsImportant { get; set; }

    public bool IsActive { get; set; }

    public List<string> Messages { get; } = new List<string>();
  }
}
