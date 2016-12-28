using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;

namespace CustomScaffolder
{
    public class SampleGeneratorModel
    {
        [Option(Name="model", ShortName="m")]
        public string Model { get; set; }
    }
}