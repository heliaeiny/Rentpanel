using BaseBackend.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseBackend.Models;

public class WatchList : BaseEntity
{
    public WatchList() : base()
    { }
    public Owner Owner { get; set; }     
    public Product Product { get; set; }
    public string Description { get; set; }
    



}
