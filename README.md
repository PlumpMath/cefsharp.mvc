# cefsharp.mvc

Test project to try and get CefSharp to run inside an asp.net MVC project.

Currently running into the following issue...

http://stackoverflow.com/questions/25714843/using-cef-chromium-embedded-framework-inside-asp-net-webapplication

Bin Directory
![alt text](http://i.imgur.com/MIV0H9L.png "Bin Dir")


Error...

[FileNotFoundException: Could not load file or assembly 'CefSharp.BrowserSubprocess.Core.DLL' or one of its dependencies. The specified module could not be found.]
   System.Reflection.RuntimeAssembly._nLoad(AssemblyName fileName, String codeBase, Evidence assemblySecurity, RuntimeAssembly locationHint, StackCrawlMark& stackMark, IntPtr pPrivHostBinder, Boolean throwOnFileNotFound, Boolean forIntrospection, Boolean suppressSecurityChecks) +0
   System.Reflection.RuntimeAssembly.nLoad(AssemblyName fileName, String codeBase, Evidence assemblySecurity, RuntimeAssembly locationHint, StackCrawlMark& stackMark, IntPtr pPrivHostBinder, Boolean throwOnFileNotFound, Boolean forIntrospection, Boolean suppressSecurityChecks) +36
   System.Reflection.RuntimeAssembly.InternalLoadAssemblyName(AssemblyName assemblyRef, Evidence assemblySecurity, RuntimeAssembly reqAssembly, StackCrawlMark& stackMark, IntPtr pPrivHostBinder, Boolean throwOnFileNotFound, Boolean forIntrospection, Boolean suppressSecurityChecks) +152
   System.Reflection.RuntimeAssembly.InternalLoad(String assemblyString, Evidence assemblySecurity, StackCrawlMark& stackMark, IntPtr pPrivHostBinder, Boolean forIntrospection) +77
   System.Reflection.RuntimeAssembly.InternalLoad(String assemblyString, Evidence assemblySecurity, StackCrawlMark& stackMark, Boolean forIntrospection) +21
   System.Reflection.Assembly.Load(String assemblyString) +28
   System.Web.Configuration.CompilationSection.LoadAssemblyHelper(String assemblyName, Boolean starDirective) +38

[ConfigurationErrorsException: Could not load file or assembly 'CefSharp.BrowserSubprocess.Core.DLL' or one of its dependencies. The specified module could not be found.]
   System.Web.Configuration.CompilationSection.LoadAssemblyHelper(String assemblyName, Boolean starDirective) +738
   System.Web.Configuration.CompilationSection.LoadAllAssembliesFromAppDomainBinDirectory() +217
   System.Web.Configuration.CompilationSection.LoadAssembly(AssemblyInfo ai) +130
   System.Web.Compilation.BuildManager.GetReferencedAssemblies(CompilationSection compConfig) +170
   System.Web.Compilation.BuildManager.GetPreStartInitMethodsFromReferencedAssemblies() +92
   System.Web.Compilation.BuildManager.CallPreStartInitMethods(String preStartInitListPath, Boolean& isRefAssemblyLoaded) +290
   System.Web.Compilation.BuildManager.ExecutePreAppStart() +157
   System.Web.Hosting.HostingEnvironment.Initialize(ApplicationManager appManager, IApplicationHost appHost, IConfigMapPathFactory configMapPathFactory, HostingEnvironmentParameters hostingParameters, PolicyLevel policyLevel, Exception appDomainCreationException) +531

[HttpException (0x80004005): Could not load file or assembly 'CefSharp.BrowserSubprocess.Core.DLL' or one of its dependencies. The specified module could not be found.]
   System.Web.HttpRuntime.FirstRequestInit(HttpContext context) +9924184
   System.Web.HttpRuntime.EnsureFirstRequestInit(HttpContext context) +101
   System.Web.HttpRuntime.ProcessRequestNotificationPrivate(IIS7WorkerRequest wr, HttpContext context) +261
