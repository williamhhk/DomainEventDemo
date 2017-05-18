using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo
{
    public interface IMediate
    {
        TResponse Request<TResponse>(IQuery<TResponse> query);
    }
}
