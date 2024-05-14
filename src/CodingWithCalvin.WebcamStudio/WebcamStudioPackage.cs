using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Task = System.Threading.Tasks.Task;

namespace CodingWithCalvin.WebcamStudio
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(PackageGuidString)]
    [ProvideToolWindow(
        typeof(ToolWindow),
        Window = EnvDTE.Constants.vsWindowKindSolutionExplorer,
        Style = VsDockStyle.Linked,
        Orientation = ToolWindowOrientation.Bottom,
        DockedWidth = 300
    )]
    [InstalledProductRegistration(Vsix.Name, Vsix.Description, Vsix.Version)]
    [ProvideToolWindowVisibility(typeof(ToolWindow), UIContextGuids.NoSolution)]
    [ProvideToolWindowVisibility(typeof(ToolWindow), UIContextGuids.EmptySolution)]
    [ProvideToolWindowVisibility(typeof(ToolWindow), UIContextGuids.SolutionExists)]
    [ProvideToolWindowVisibility(typeof(ToolWindow), UIContextGuids.SolutionHasMultipleProjects)]
    [ProvideToolWindowVisibility(typeof(ToolWindow), UIContextGuids.SolutionHasSingleProject)]
    [ProvideBindingPath(SubPath = "assemblies")]
    public sealed class WebcamStudioPackage : AsyncPackage
    {
        public const string PackageGuidString = "93866737-df2a-4630-a3f2-3bd2ec532ce0";

        protected override async Task InitializeAsync(
            CancellationToken cancellationToken,
            IProgress<ServiceProgressData> progress
        )
        {
            await this.JoinableTaskFactory.SwitchToMainThreadAsync(cancellationToken);

            await this.ShowToolWindowAsync(typeof(ToolWindow), 0, true, cancellationToken)
                .ConfigureAwait(false);
        }
    }
}
