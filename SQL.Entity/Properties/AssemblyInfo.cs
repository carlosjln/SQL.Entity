using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle( "SQL.Entity" )]
[assembly: AssemblyProduct( "SQL.Entity" )]
[assembly: AssemblyDescription( "Simple and clean SQL Entity. (Alpha version)" )]

[assembly: AssemblyCompany( "Carlos J. López - twitter/carlosjln" )]
[assembly: AssemblyCopyright( "Copyright © 2013" )]
[assembly: AssemblyTrademark( "" )]

[assembly: AssemblyVersion( "1.0.0.1" )]
//[assembly: AssemblyFileVersion( "1.0.0.1" )]
//[assembly: AssemblyInformationalVersion("1.0.0.1")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid( "A1154B0B-5B4F-41D1-9F39-BA7947F60BF0" )]