using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.Model
{
    public interface IPOCRepo
    {
        Task<POC> GetALL();
        Task<POC> GetName(string name);
        Task Create(POC poc);
        Task<bool> Update(POC poc);

    }
}
