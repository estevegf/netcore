using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_project.Models
{
    public interface IApi
    {
        Task<Education[]> GetEducation();
    }
}
