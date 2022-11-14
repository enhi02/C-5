using asm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asm.Services
{
    public interface MonAnSvc
    {
        List<MonAn> GetMonAnAll();

        MonAn GetMonAn(int id);

        int AddMonAn(MonAn monAn);

        int EditMonAn(int id, MonAn monAn);
    }


}
