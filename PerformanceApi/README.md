# .NET 9/10 performance degradation sample

A small demo project to showcase the performance degradation when upgrading from .NET 8 to .NET 9 or .NET 10.

## How to run

- Open the `PerformanceApi.slnx` solution in visual studio
- Run in debug mode with the diagnostic tools enabled
- install "front-end" dependencies with `npm install`
- Run the "front-end" with `npm run dev`
- The front-end will make some request sequentials as well as two blocks of concurrent requests.
  - Both individual response times as well as the average time is significantly higher on dotnet 9/10 on the first run

## Testing results

| Version | Avg Response |
| ------- | ------------ |
| .NET 8  | 49ms         |
| .NET 9  | 437ms        |
| .NET 10 | 340ms        |
