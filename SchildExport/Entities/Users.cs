using System;
using System.Collections.Generic;

namespace SchulIT.SchildExport.Entities
{
    public partial class Users
    {
        public int Id { get; set; }
        public string UsName { get; set; }
        public string UsLoginName { get; set; }
        public string UsPassword { get; set; }
        public string UsUserGroups { get; set; }
        public string UsPrivileges { get; set; }
        public int? SchulnrEigner { get; set; }
        public string Email { get; set; }
        public string EmailName { get; set; }
        public string Smtpusername { get; set; }
        public string Smtppassword { get; set; }
        public string EmailSignature { get; set; }
        public int? HeartbeatDate { get; set; }
        public string ComputerName { get; set; }
        public string UsPasswordHash { get; set; }
    }
}
