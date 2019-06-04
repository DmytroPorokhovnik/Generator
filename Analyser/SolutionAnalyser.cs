using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analyser
{
    public class SolutionAnalyser
    {
        public void AnalyseProject(string projectPath)
        {
            MSBuildWorkspace workspace = MSBuildWorkspace.Create();
            Project currProject = workspace.OpenProjectAsync(projectPath)
                                           .Result;
        }
    }
}
