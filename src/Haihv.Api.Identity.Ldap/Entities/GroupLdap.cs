namespace Haihv.Api.Identity.Ldap.Entities;

/// <summary>
/// Đại diện cho một nhóm LDAP.
/// </summary>
public class GroupLdap : BaseLdap
{
    /// <summary>
    /// Danh sách các nhóm là thành viên của nhóm.
    /// </summary>
    public HashSet<string> GroupMembers { get; set; } = [];
    
    /// <summary>
    /// Danh sách các người dùng là thành viên của nhóm.
    /// </summary>
    public HashSet<string> UserMembers { get; set; } = [];
}