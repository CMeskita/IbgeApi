using IbgeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicos.Util
{
    public interface IWebIbgeApi
    {
        
        Task<List<Municipios>> GetMunicipios();
        Task<List<Municipios>> GetMunicipiosUf(int id);
        Task<List<Municipios>> GetUf();
    }
}
