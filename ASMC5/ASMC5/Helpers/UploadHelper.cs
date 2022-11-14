using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonAn.Helpers
{
    public interface IUploadHelper
    {
        bool UpLoadFile(IFormFile imageFile);
    }

    public class UploadHelper : IUploadHelper
    {
        private readonly IWebHostEnvironment _IWebHostEnvironment;

        public UploadHelper(IWebHostEnvironment IWebHostEnvironment)
        {
            _IWebHostEnvironment = IWebHostEnvironment;
        }

        public bool UpLoadFile(IFormFile imageFile)
        {
            if (imageFile != null)
            {
                try
                {
                    var filePath = Path.Combine(_IWebHostEnvironment.WebRootPath, "Uploads", imageFile.FileName);
                    //if (File.Exists(filePath))
                    //{
                    //    return null;
                    //}
                    using (var filestream = new FileStream(filePath, FileMode.Create))
                    {
                        imageFile.CopyTo(filestream);
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}
