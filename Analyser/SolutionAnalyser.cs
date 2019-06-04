using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Analyser
{
    public class SolutionAnalyser
    {
        public async Task<List<string>> GetClassesFromProject(string projectPath)
        {
            MSBuildWorkspace workspace = MSBuildWorkspace.Create();
            Project project = workspace.OpenProjectAsync(projectPath)
                                           .Result;
            var compilatedProject = await project.GetCompilationAsync();
            var classVisitor = new ClassVirtualizationVisitor();
            foreach (var syntaxTree in compilatedProject.SyntaxTrees)
            {
                classVisitor.Visit(syntaxTree.GetRoot());
            }
            List<string> classesNames = new List<string>();
            foreach (var @class in classVisitor.Classes)
                classesNames.Add(@class.Identifier.ValueText);
            return classesNames;
        }
    }
}
