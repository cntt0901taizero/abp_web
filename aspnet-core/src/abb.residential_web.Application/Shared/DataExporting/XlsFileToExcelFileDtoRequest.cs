﻿using FlexCel.XlsAdapter;
using MediatR;
using BaseApplication.Dtos;
using BaseApplication.Factory;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace BaseApplication.DataExporting
{
    public class XlsFileToExcelFileDtoRequest: IRequest<FileDto>
    {
        public XlsFile XlsResult { get; set; }
        public string OutputFileNameNotExtension { get; set; }
        public bool IsFileExcel2003 { get; set; } = false;
    }
    public class XlsFileToExcelFileDtoRequestHandler:IRequestHandler<XlsFileToExcelFileDtoRequest, FileDto>
    {
        private readonly IAppFactory _factory;

        public XlsFileToExcelFileDtoRequestHandler(IAppFactory factory)
        {
            _factory = factory;
        }

        public async Task<FileDto> Handle(XlsFileToExcelFileDtoRequest request, CancellationToken cancellationToken)
        {
            using (var outStream = new MemoryStream())
            {
                request.XlsResult.Save(outStream);
                var fileName = request.OutputFileNameNotExtension + ".xlsx";
                if (request.IsFileExcel2003)
                {
                    fileName = request.OutputFileNameNotExtension + ".xls";
                }
                var outputFile = new FileDto(fileName, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                await _factory.TempFileCacheManager.SetFileAsync(outputFile, outStream.ToArray());
                return outputFile;
            }
        }
    }
}
