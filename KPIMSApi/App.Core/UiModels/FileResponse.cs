namespace KPIMS.Core.UiModels
{
    public class FileResponse
    {
        public string? FileName { get; set; } = string.Empty;
        public string? FileSize { get; set; } = string.Empty;
        public float FileSizeInByte { get; set; } = 0;
        public string? FileType { get; set; } = string.Empty;
        public string? FilePath { get; set; } = string.Empty;
        public string? DirectoryName { get; set; } = string.Empty;
    }
}
