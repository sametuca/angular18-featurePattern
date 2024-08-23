
using AngularJWT.Application.Auth.Requirements;
using AngularJWT.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace AngularJWT.Application.Auth.Handlers
{
    public class PermissionHandler : AuthorizationHandler<PermissionRequirement>
    {
        private readonly IUserPermissionService _userPermissionService;

        public PermissionHandler(IUserPermissionService userPermissionService) => _userPermissionService = userPermissionService;

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                           PermissionRequirement requirement)
        {
            var userId = context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userId == null)
            {
                context.Fail();
                return;
            }

            var permissions = await _userPermissionService.GetUserPermissionsAsync(userId);

            if (permissions.Contains(requirement.Permission))
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }
        }
    }
}
