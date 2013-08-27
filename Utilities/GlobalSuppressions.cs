// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.IoC.Default.DefaultBootstrapper.#Resolve(System.Type,System.String,System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.IO.FileSystem.Module.FileSystemModule.#Load(Utilities.IoC.Interfaces.IBootstrapper)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1057:StringUriOverloadsCallSystemUriOverloads", Scope = "member", Target = "Utilities.IO.FileSystem.Default.WebDirectory.#.ctor(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1057:StringUriOverloadsCallSystemUriOverloads", Scope = "member", Target = "Utilities.IO.FileSystem.Default.WebFile.#.ctor(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.IO.Logging.Default.DefaultLogger.#AddLog(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.IO.Logging.Module.LoggingModule.#Load(Utilities.IoC.Interfaces.IBootstrapper)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1043:UseIntegralOrStringArgumentForIndexers", Scope = "member", Target = "Utilities.IO.Messaging.Manager.#Item[System.Type]")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.IO.Messaging.Default.SMTPSystem.#InternalSend(Utilities.IO.Messaging.Interfaces.IMessage)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.CodeGen.BaseClasses.CompilerBase.#Add(System.String,System.String,System.Collections.Generic.IEnumerable`1<System.String>,System.Reflection.Assembly[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "Utilities.DataTypes.CodeGen.Module.CompilerModule.#Load(Utilities.IoC.Interfaces.IBootstrapper)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.Conversion.Converters.ExpandoTypeConverter.#ConvertTo(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,System.Object,System.Type)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.Conversion.Converters.ExpandoTypeConverter.#ConvertFrom(System.ComponentModel.ITypeDescriptorContext,System.Globalization.CultureInfo,System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.IEnumerableExtensions.#ForEach`1(System.Collections.Generic.IEnumerable`1<!!0>,System.Action`1<!!0>,System.Action`2<!!0,System.Exception>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "Utilities.DataTypes.Conversion.Converters.DbTypeTypeConverter.#TypeToDbType(System.Object)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.IEnumerableExtensions.#ForEachParallel`1(System.Collections.Generic.IEnumerable`1<!!0>,System.Action`1<!!0>,System.Action`2<!!0,System.Exception>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.IEnumerableExtensions.#ForEachParallel`2(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,!!1>,System.Action`2<!!0,System.Exception>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Utilities.DataTypes.IEnumerableExtensions.#ToList`2(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,!!1>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "Utilities.DataTypes.AOP.Manager.#Setup(System.Type)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Scope = "member", Target = "Utilities.DataTypes.ReflectionExtensions.#PropertySetter`2(System.Linq.Expressions.Expression`1<System.Func`2<!!0,!!1>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Utilities.DataTypes.IEnumerableExtensions.#ForEach`2(System.Collections.Generic.IEnumerable`1<!!0>,System.Func`2<!!0,!!1>,System.Action`2<!!0,System.Exception>)")]
