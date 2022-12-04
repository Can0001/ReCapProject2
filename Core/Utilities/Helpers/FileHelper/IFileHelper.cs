using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Helpers.FileHelper
{
    public interface IFileHelper
    {
        public string Add(IFormFile file);
        public void Delete(string filePath);
        public string Update(IFormFile file, string oldFilePath);
    }
}