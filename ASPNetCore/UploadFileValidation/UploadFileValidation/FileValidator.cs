namespace UploadFileValidation
{
    public static class FileValidator
    {
        public static bool IsFileExtensionAllowed(IFormFile file, string[] allowedExtendions)
        {
            var extension = Path.GetExtension(file.FileName);
            return allowedExtendions.Contains(extension);
        }

        public static bool IsFileSizeWithinLimit(IFormFile file, long sizelimit) 
        {
            return file.Length <= sizelimit;
        }

        public static bool FileNameExists(IFormFile fileName)
        {
            //Logic to search for same file name in the system
            return false;
        }
    }
}