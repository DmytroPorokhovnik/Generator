using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace Analyser
{
    class ClassVirtualizationVisitor : CSharpSyntaxRewriter
    {
        public ClassVirtualizationVisitor()
        {
            Classes = new List<ClassDeclarationSyntax>();
        }

        public List<ClassDeclarationSyntax> Classes { get; set; }

        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            node = (ClassDeclarationSyntax)base.VisitClassDeclaration(node);
            Classes.Add(node);
            return node;
        }
    }
}
