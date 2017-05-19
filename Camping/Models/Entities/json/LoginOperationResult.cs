using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.json
{
    
    public class LoginOperationResult<T> : OperationResult
    {
        public int userType {get;set;}

        public T account { get; set; }

    }
}
