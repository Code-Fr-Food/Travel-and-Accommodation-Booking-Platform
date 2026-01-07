# Commit Message Guidelines

This project follows the [Conventional Commits](https://www.conventionalcommits.org/) specification.

## Format

```
<type>(<scope>): <subject>

<body>

<footer>
```

## Type

Must be one of the following:

- **feat**: A new feature
- **fix**: A bug fix
- **docs**: Documentation only changes
- **style**: Changes that don't affect code meaning (whitespace, formatting, semicolons, etc)
- **refactor**: Code change that neither fixes a bug nor adds a feature
- **perf**: Code change that improves performance
- **test**: Adding missing tests or correcting existing tests
- **build**: Changes to the build system or external dependencies (package.json, .csproj, etc)
- **ci**: Changes to CI configuration files and scripts (GitHub Actions, etc)
- **chore**: Other changes that don't modify src or test files
- **revert**: Reverts a previous commit

## Scope

The scope is optional and can be anything specifying the place of the commit change:

- `api` - Changes in HotelBookingPlatform.API
- `application` - Changes in HotelBookingPlatform.Application
- `domain` - Changes in HotelBookingPlatform.Domain
- `infrastructure` - Changes in HotelBookingPlatform.Infrastructure
- `tests` - Changes in test projects
- `migrations` - Database migration changes
- `config` - Configuration file changes

## Subject

- Use the imperative, present tense: "change" not "changed" nor "changes"
- Don't capitalize the first letter
- No period (.) at the end
- Maximum 50 characters

## Body

- Use the imperative, present tense
- Include motivation for the change and contrast with previous behavior
- Wrap at 72 characters

## Footer

- Reference GitHub issues: `Closes #123`, `Fixes #456`, `Refs #789`
- Note breaking changes: `BREAKING CHANGE: description`

## Examples

### Feature with scope
```
feat(api): add endpoint for hotel search

Implement hotel search with filters for city, price range, and star rating.
Includes pagination support and sorting options.

Closes #42
```

### Bug fix
```
fix(domain): correct discount calculation logic

Fix issue where discount percentages were not being applied correctly
to room prices when multiple discounts were active.

Fixes #156
```

### Breaking change
```
refactor(api)!: change authentication response format

BREAKING CHANGE: The authentication endpoint now returns a different
JSON structure. Update client applications accordingly.

Old format:
{
  "token": "...",
  "user": {...}
}

New format:
{
  "accessToken": "...",
  "refreshToken": "...",
  "user": {...}
}
```

### Documentation
```
docs(readme): update setup instructions for .NET 8

Add instructions for PostgreSQL setup and migration creation.
Remove outdated SQL Server references.
```

### Chore without scope
```
chore: update NuGet packages to latest versions
```

## Git Hooks (Optional)

To enforce commit message format, you can use git hooks or tools like:
- [Husky.NET](https://github.com/alirezanet/Husky.Net) for .NET projects
- [commitlint](https://commitlint.js.org/) with Node.js

## Tips

1. Keep commits atomic - one logical change per commit
2. Write clear, descriptive commit messages
3. Use present tense ("add feature" not "added feature")
4. Reference issues when applicable
5. Separate subject from body with a blank line
6. Use the body to explain "what" and "why", not "how"
