# ADR 000: Adopting Architecture Decision Records (ADRs)

## Status

Accepted

## Context

As this project grows, it becomes increasingly important to document architectural decisions to ensure consistency, facilitate communication, and provide a historical record. Mostly for Future Me who will come back to this someday and think "what the fuck?". Adopting Architecture Decision Records (ADRs) will help me achieve these goals.

- All significant architectural decisions will be documented using ADRs.
- The ADRs will be stored in the `/docs/adr/` directory of the project repository.

## Decision

The project will adopt the use of ADRs to document all significant architectural decisions. Each ADR will follow a standardized template to ensure clarity and consistency.

## Consequences

- Determining what is "significant" is subjective and opionated.
- Createing ADRs reduces cognitive load and ramp up, but take time away from coding.

## ADR Template

```markdown
# ADR {number}: {title}

## Status

{Proposed | Accepted | Deprecated | Superseded by ADR {number}}

## Context

{Provide the context or background information that led to this decision.}

## Decision

{Describe the decision that has been made.}

## Consequences

{Explain the consequences of this decision, both positive and negative.}
```

## Example

```markdown
# ADR 001: Use PostgreSQL for Database

## Status

Accepted

## Context

We need a robust, scalable, and open-source relational database for our application.

## Decision

We will use PostgreSQL as our primary database.

## Consequences

- We will benefit from PostgreSQL's advanced features and active community support.
- Team members will need to familiarize themselves with PostgreSQL.
```

## References

- [Documenting architecture decisions](https://cognitect.com/blog/2011/11/15/documenting-architecture-decisions)
- [ADR GitHub repository](https://github.com/joelparkerhenderson/architecture_decision_record)
