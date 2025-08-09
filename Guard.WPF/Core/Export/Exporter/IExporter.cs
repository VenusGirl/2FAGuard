﻿namespace Guard.WPF.Core.Export.Exporter
{
    internal interface IExporter
    {
        internal enum ExportType
        {
            File,
        }

        internal abstract string Name { get; }
        internal abstract ExportType Type { get; }
        internal abstract string ExportFileExtensions { get; }
        internal abstract Task Export(string? path, byte[]? password);
        internal abstract bool RequiresPassword();
        internal abstract string GetDefaultFileName();
    }
}
