﻿using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.ExtensionDeb
{
    class ExtensionHelper
    {
        internal static Project GetActiveProject(DTE dte)
        {
            Microsoft.VisualStudio.Shell.ThreadHelper.ThrowIfNotOnUIThread();
            Project activeProject = null;

            Array activeSolutionProjects = dte.ActiveSolutionProjects as Array;
            if (activeSolutionProjects != null && activeSolutionProjects.Length > 0)
            {
                activeProject = activeSolutionProjects.GetValue(0) as Project;
            }
            return activeProject;
        }

        internal static string GetCurrentFilePath()
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            var proj = GetActiveProject(Package.GetGlobalService(typeof(SDTE)) as DTE);
            if (proj == null)
            {
                //TODO:
                return null;
            }
            else
            {
                var currentProject = (VSLangProj.VSProject)proj.Object;
                return Path.GetDirectoryName(currentProject.Project.FileName);

            }
        }

        internal static int GetCaretLine()
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            DTE dte = Package.GetGlobalService(typeof(DTE)) as DTE;
            var txtSelection = dte.ActiveDocument.Selection as TextSelection;
            return txtSelection.ActivePoint.Line;
        }

        internal static string GetActiveDocumentPath()
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            DTE dte = Package.GetGlobalService(typeof(DTE)) as DTE;
            if (dte.ActiveDocument == null)
                return null;
            return dte.ActiveDocument.FullName;
        }
    }
}
