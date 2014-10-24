Debug
=====

Logger for CSharp.

**Usage**

```csharp

var log = Log.Create("Log");
// OR
// var log = log.Create(typeof(...));

log.Config.LogLevels = LogLevels.Debug | LogLevels.Error

log.Debug(....);


```
