using Microsoft.AspNetCore.Mvc;
using UploadFileValidation.ActionFilters;

namespace UploadFileValidation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileUloadController : ControllerBase
    {
        //----------------------------------------------------------------------------------------------------------
        // Correct approach:
        // Adding a custom attribute on the controller action of our choice which would take care of the validation.
        //----------------------------------------------------------------------------------------------------------
        [HttpPost(nameof(UploadFile))]
        [FileValidationFilter([".pdf", ".doc", ".docx"], 1024 * 1024)]
        public IActionResult UploadFile(IFormFile file)
        {
            // Do something with the file
            return Ok();
        }

        //------------------------------------------------------------------
        // Issues with such an approach:
        // 1) It has hardcoded checks in one controller method.
        // 2) Can’t reuse validation methods for another controller method.
        // 3) Violates the single responsibility principle.
        //------------------------------------------------------------------
        [HttpPost(nameof(Upload))]
        public IActionResult Upload(IFormFile file)
        {
            if (file is null || file.Length == 0)
                return BadRequest("The file is null");

            if (!FileValidator.IsFileExtensionAllowed(file, [".pdf", ".doc", ".docx"]))
                return BadRequest("Invalid file type. Please upload a PDF, DOC, or DOCX file.");

            if (!FileValidator.IsFileSizeWithinLimit(file, 1024 * 1024))
                return BadRequest("File size exceeds the maximum allowed size (1 MB).");

            if (FileValidator.FileNameExists(file))
                return BadRequest("Duplicate file name detected. Please upload a file with a different name.");

            // Do something with the file
            return Ok();
        }
    }
}