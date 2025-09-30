[![Build Project](https://github.com/tremorscript/Platy.AdventureWorks.Repository/actions/workflows/ci.yml/badge.svg)](https://github.com/tremorscript/Platy.AdventureWorks.Repository/actions/workflows/ci.yml)

[![NuGet Version](https://img.shields.io/nuget/v/Platy.AdventureWorks.Repository?label=Platy.AdventureWorks.Repository)](https://www.nuget.org/packages/Platy.AdventureWorks.Repository/)

# Overview
This is the project template that I use to quickly create a set of repository classes for interacting with any existing database

# Features
- The DbContext and Entity classes are internal, which means that external libraries users cannot make db changes without interacting with the repository classes.
- The repository classes validate the entities before making changes to the database
- A Result type is returned in case of success or failure, instead of relying on exceptions.
- A notification is published for every Create, Update and Delete event. External libraries can subscribe to these events.
- `csx` templates help generate the code for existing databases to help get started quickly. Uses a forked version of [Loresoft EntityFrameworkGenerator](https://github.com/loresoft/EntityFrameworkCore.Generator).
- Integration tests using TestContainers.
