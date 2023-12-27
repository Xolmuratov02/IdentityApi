using Identity.Application.Common.Enums;
using Identity.Application.Common.Identity.Models;

namespace Identity.Application.Common.Identity.Services;

public interface IVerificationTokenGeneratorService
{
    string GenerateToken(VerificationType type, Guid userId);

    (VerificationToken Token, bool IsValid) DecodeToken(string token);
}