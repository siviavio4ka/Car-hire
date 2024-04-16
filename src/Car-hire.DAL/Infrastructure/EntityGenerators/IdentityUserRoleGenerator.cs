using Microsoft.AspNetCore.Identity;

namespace Car_hire.DAL.Infrastructure.EntityGenerators;

public static class IdentityUserRoleGenerator
{
    private static readonly Random Random = new();

    public static IEnumerable<IdentityUserRole<int>> GenerateIdentityUserRole(int count, int maxRoleId) =>
        Enumerable.Range(1, count).Select(i => new IdentityUserRole<int>
        {
            UserId = i,
            RoleId = Random.Next(1, maxRoleId)
        });
}