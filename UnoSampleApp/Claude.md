# Claude Configuration for UnoSampleApp

This Uno Platform application uses the UnoClaude documentation framework for consistency and best practices.

## Documentation Reference

This project follows the architectural patterns and guidelines defined in the UnoClaude submodule:

- **Primary Documentation**: [UnoClaude Documentation](../UnoClaude/Claude.md)
- **Architecture Overview**: [../UnoClaude/.claude/docs/architecture/README.md](../UnoClaude/.claude/docs/architecture/README.md)
- **ViewModels and Models**: [../UnoClaude/.claude/docs/mvvm/README.md](../UnoClaude/.claude/docs/mvvm/README.md)
- **XAML Styling Guidelines**: [../UnoClaude/.claude/docs/styling/README.md](../UnoClaude/.claude/docs/styling/README.md)
- **Services Architecture**: [../UnoClaude/.claude/docs/services/README.md](../UnoClaude/.claude/docs/services/README.md)

## Project Structure

This app follows the UnoClaude project structure:

```
UnoSampleApp/
├── Claude.md (this file)
├── UnoSampleApp/
│   ├── Pages/
│   │   ├── Main/
│   │   │   ├── MainPage.xaml
│   │   │   ├── Regions/
│   │   │   └── ViewModels/
│   │   └── [Other Pages]/
│   ├── Models/
│   ├── Mediator/
│   │   ├── Requests/
│   │   │   ├── IRequests/
│   │   │   ├── Events/
│   │   │   └── Commands/
│   │   └── Handlers/
│   │       ├── IRequests/
│   │       ├── Events/
│   │       └── Commands/
│   └── Services/
```

## Key Implementation Guidelines

1. **Pages and Regions**: All pages should inherit from BasePage and use UnoRegions as defined in UnoClaude
2. **MVVM Pattern**: Use Uno.Extensions.Reactive patterns as documented
3. **Styling**: Every XAML control must have an explicit style following UnoClaude guidelines
4. **Services**: Implement Shiny Mediator Pattern for API and messaging

## Getting Started

When implementing features in this app:
1. First consult the UnoClaude documentation for patterns and guidelines
2. Follow the established project structure
3. Use the same coding conventions and architectural patterns
4. Ensure all implementations align with UnoClaude standards

For detailed implementation guidance, always refer to the UnoClaude documentation linked above.