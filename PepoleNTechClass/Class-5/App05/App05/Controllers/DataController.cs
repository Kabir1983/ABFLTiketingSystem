using App05.Models;
using Microsoft.AspNetCore.Mvc;

namespace App05.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            string folderPath = @"C:\Users\HumaiunKabir\Downloads";
            string[] files = Directory.GetFiles(folderPath);
            return View(files);
        }

        public IActionResult FileList()
        {
            string folderPath = @"C:\Users\HumaiunKabir\Downloads";
            string[] files = Directory.GetFiles(folderPath);
            List<FilesModel> objFilesModelList = new List<FilesModel>();
            int i = 1;
            foreach (string file in files)
            {
                FilesModel objFileModel = new FilesModel();
                objFileModel.Id = i++;
                objFileModel.Name = Path.GetFileNameWithoutExtension(file);
                objFileModel.Extension = Path.GetExtension(file);
                objFileModel.Size = new FileInfo(file).Length;
                objFileModel.FilePath = file;
                objFilesModelList.Add(objFileModel);
            }
            return View(objFilesModelList);
        }

        public IActionResult Subfolder()
        {
            string folderPath = @"C:\Users\HumaiunKabir";
            string[] files = Directory.GetDirectories(folderPath);
            return View(files);
        }


        public IActionResult HRInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HRInfo(Person objPerson)
        {
            if (objPerson != null)
            {
                objPerson.Id= 1;
                return RedirectToAction("FileList", "Data");
            }
            return View();
        }
    }
}
