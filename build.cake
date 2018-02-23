#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0

// Cake Addins
#addin nuget:?package=Cake.FileHelpers&version=2.0.0
#addin "Cake.XCode"

//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

var NATIVE_SRC_DIR="./native-src";
var VERSION = "6.1.0";

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

var solutionPath = "./braintree-ios-dropin.sln";
var nativeSrcUrl = $"https://codeload.github.com/braintree/braintree-ios-drop-in/legacy.zip/{VERSION}";

var artifacts = new [] {
    new Artifact {
        AssemblyInfoPath = "./Naxam.BraintreeDropIn.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./braintree-dropin.nuspec",
        Dependencies = new [] { 
            "Naxam.BraintreeUIKit.iOS"
        },
        Name = "DropIn"
    },
    new Artifact {
        AssemblyInfoPath = "./Naxam.BraintreeUIKit.iOS/Properties/AssemblyInfo.cs",
        NuspecPath = "./braintree-uikit.nuspec",
        Dependencies = new string [] { 
        },
        Name = "UIKit"
    },
};

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////
Task("Downloads")
    .Does(() =>
{
    // CleanDirectory(NATIVE_SRC_DIR);

    var zipPath = File(NATIVE_SRC_DIR + "./src.zip");
    DownloadFile(nativeSrcUrl, zipPath);    
});

Task("Clean")
    .Does(() =>
{
    CleanDirectory("./packages");

    var nugetPackages = GetFiles("./*.nupkg");

    foreach (var package in nugetPackages)
    {
        DeleteFile(package);
    }
});

Task("Restore-NuGet-Packages")
    .IsDependentOn("Clean")
    .Does(() =>
{
    NuGetRestore(solutionPath);
});

Task("Build")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() =>
{
    MSBuild(solutionPath, settings => settings.SetConfiguration(configuration));
});

Task("UpdateVersion")
    .Does(() => 
{
    foreach(var artifact in artifacts) {
        ReplaceRegexInFiles(artifact.AssemblyInfoPath, "\\[assembly\\: AssemblyVersion([^\\]]+)\\]", string.Format("[assembly: AssemblyVersion(\"{0}\")]", VERSION));
    }
});

Task("Pack")
    .IsDependentOn("UpdateVersion")
    .IsDependentOn("Build")
    .Does(() =>
{
    foreach(var artifact in artifacts) {
        NuGetPack(artifact.NuspecPath, new NuGetPackSettings {
            Version = VERSION,
            ReleaseNotes = new [] {
                string.Format("Braintree iOS SDK v{0} - {1}", VERSION, artifact.Name)
            },
            Dependencies = artifact.Dependencies.Select(x =>
                new NuSpecDependency {
                    Id = x,
                    Version = VERSION
                }).ToArray()
        });
    }
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
    .IsDependentOn("Pack");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);

class Artifact {
    public string AssemblyInfoPath { get; set; }

    public string NuspecPath { get; set; }

    public string[] Dependencies { get; set; }

    public string Name { get; set; }
}