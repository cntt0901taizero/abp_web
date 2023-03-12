using System;
using System.Collections.Generic;

namespace BaseApplication.Dtos
{
    public class UserSessionDto
    {
        public Guid? SessionId { get; set; }
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string IsActive { get; set; }
        public string CreationTime { get; set; }
        public List<string> GrantedPermissions { get; set; }
        public bool IsSuperAdmin { get; set; } = false;
    }
}
