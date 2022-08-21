# SpecFlow with Playwright

very simple example of Playwright usage with SpecFlow for acceptance tests
- [Spec Flow docs](https://docs.specflow.org/en/latest/)
- [Playwright .Net](https://playwright.dev/dotnet/)

## Visual Studio

install the SpecFlow extension https://docs.specflow.org/projects/specflow/en/latest/visualstudio/visual-studio-installation.html

## Linving Doc
SpecFlow+LivingDoc is a set of tools that allows you to share and collaborate on Gherkin Feature Files with stakeholders who may not be familiar with developer tools.

https://docs.specflow.org/projects/specflow-livingdoc/en/latest/

### Generate living docs for the current specs

1. install the dotnet tool:
`$ dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI`
2. run it on the generated spec project output, ex:

```
> cd .\tests\BlazorApp.TestsSpec\bin\Debug\net6.0\
> livingdoc test-assembly .\BlazorApp.TestsSpec.dll -t .\TestExecution.json
```
