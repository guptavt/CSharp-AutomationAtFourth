# Hello

This repository is maintained by the Fourth App Team and contains the C# source code to our current automation effort,
spanning both Web and real Mobile Device testing.

## Things to note

We're building everything on **macOS** machines, with **Xamarin Studio** and on the **Mono Framework**. As our underlying
Automation Framework, build by the QA Architecture (formerly Tech QA) Team, works on all platforms, this ensures that our
code can be compiled and executed on Windows / macOS / Linux. 

In order to get everything set up properly for further development, follow the excellent guides on Confluence, [linked](https://fourthlimited.atlassian.net/wiki/display/EN/Setup+Mobile+Environment)
 [here](https://fourthlimited.atlassian.net/wiki/display/EN/Running+Mobile+Tests).

## Workflow?

As each Sprint we devote time to writing Automation, we have established a workflow:
- each contributor grabs the latest code from `master`
- a new branch is created, specifying the `US<number>` that will be worked on
- write code aplenty, commit early & often
- maintain the CHANGELOG.md with everything that's `Added/Changed/Deprecated/Removed/Fixed/Security`
- submit a Pull Request
- ??
- PROFIT!