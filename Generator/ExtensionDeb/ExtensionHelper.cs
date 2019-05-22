using EnvDTE;
using System;
using System.Collections.Generic;
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
    }
}
