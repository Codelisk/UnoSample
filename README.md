# UnoSample

A sample project demonstrating how to use UnoClaude documentation framework in an Uno Platform application.

## Project Structure

- **UnoClaude/** - Submodule containing the documentation framework and architectural guidelines
- **UnoSampleApp/** - Sample Uno Platform application that follows UnoClaude patterns

## Getting Started

This repository includes UnoClaude as a submodule. To clone this repository with all submodules:

```bash
git clone --recursive https://github.com/Codelisk/UnoSample.git
```

Or if you've already cloned the repository:

```bash
git submodule update --init --recursive
```

## Building the Sample App

Navigate to the UnoSampleApp directory and restore dependencies:

```bash
cd UnoSampleApp
dotnet restore
```

The app follows all architectural patterns and guidelines defined in the UnoClaude documentation framework.

## Documentation

- See [UnoSampleApp/Claude.md](UnoSampleApp/Claude.md) for app-specific documentation
- See [UnoClaude/Claude.md](UnoClaude/Claude.md) for the complete documentation framework