This repo contains samples projects used for smoke-testing SonarLint for Visual Studio features.

## Manual testing checklist

### Simple analysis

**Check analysis issues are raised for all supported languages:**
- [ ] C#
- [ ] VB.NET
- [ ] C++
- [ ] JavaScript

**Check issues with secondary locations are raised for supported languages:**
- [ ] C++
	
### Connected mode - Create new binding
_Note: the "standalone" projects can be used for this, but don't commit the binding files_

**Check:**
- [ ] rules config files are created for each language: C#, VB.NET, C, C++ (not JavaScript currently)
- [ ] C# and VB.NET projects are updated to referenced the ruleset and SonarLint.xml

### Update existing binding
**Check:**
- [ ] binding was updated successfully (output window)

### Connected mode - taint issues
_Use the "Taint_CSharp_NetCore_WebAppReact" project in "bound\sonarcloud\SLVS_Samples_Bound_VS2019\SLVS_Bound_VS2019.sln"_

**Check:**
- [ ] "Taint list" tool window appears
- [ ] "Taint list" tab caption updates to show the number of issues in the file
- [ ] "Issue Visualization" tool window appears when a taint issue is selected
- [ ] "Issue Visualization" tool window disappears when a taint issues is not selected
- [ ] secondary locations are shown in editor when a taint issue is selected

#### Connected mode - notifications
**Check:**
- [ ] SonarQube notification icon appears in the status bar
- [ ] pop-up appears when clicking on the icon
- [ ] notification icon disappears when the bound solution is closed

### Connected mode - hotspots
_At the time of writing (March 2021) this feature is only available on SonarQube.
The following project can be used for testing: https://next.sonarqube.com/sonarqube/security_hotspots?id=citytour2019-dotnet_

**Check:**
- [ ] clicking _Open in IDE_ switches to VS
- [ ] VS displays gold bar saying can't show the hotspot (assuming the correct bound solution is not open)
