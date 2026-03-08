# .NET 8.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that a .NET 8.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 8.0 upgrade.
3. Upgrade RandomDraw\RandomDraw.csproj to .NET 8.0

## Settings

This section contains settings and data used by execution steps.

### Project upgrade details

This section contains details about each project upgrade and modifications that need to be done in the project.

#### RandomDraw\RandomDraw.csproj modifications

Project properties changes:
  - Project file needs to be converted from traditional .NET Framework format to SDK-style format
  - Target framework should be changed from `net48` to `net8.0-windows`

Other changes:
  - The project uses an Access database (draw.accdb) which will continue to work with .NET 8.0
  - ClickOnce deployment settings will be removed as they are incompatible with modern .NET
  - After upgrade, the project will support single-file publishing for true standalone executables
