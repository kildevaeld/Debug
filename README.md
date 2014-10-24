Debug
=====

Logger for CSharp.

**Usage**

```csharp

Log.Configuator.LogLevels = LogLevels.Debug | LogLevels.Error;
var log = Log.Create("Log");
// OR
// var log = log.Create(typeof(...));
//log.Config.LogLevels = LogLevels.Debug | LogLevels.Warn

log.Debug(....);


```
