using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3.Interfejsy
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }

}
