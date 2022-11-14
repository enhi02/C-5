using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonAn.Models.ViewModels
{
    public class UploadImageViewModel
    {
        public IFormFile Image { get; set; }
    }
}
