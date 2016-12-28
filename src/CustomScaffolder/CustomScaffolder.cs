using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Web.CodeGeneration;
using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;

namespace CustomScaffolder
{
    [Alias("sample")]
    public class SampleGenerator : ICodeGenerator
    {
        ILogger _logger;
        public SampleGenerator(ILogger logger)
        {
            if (logger == null)
            {
                throw new ArgumentNullException(nameof(logger));
            }
            _logger = logger;
        }
        public async Task GenerateCode(SampleGeneratorModel model)
        {
            _logger.LogMessage($"Model name: {model.Model}");
            await Task.CompletedTask;
        }
    }
}