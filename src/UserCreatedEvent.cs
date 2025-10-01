namespace Talapker.Identity.Contracts;

public record UserCreatedEvent(Guid Id, string FirstName, string LastName, string Email);
