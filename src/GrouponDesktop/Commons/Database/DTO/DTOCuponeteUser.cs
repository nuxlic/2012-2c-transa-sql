using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Commons.Database.DTO
{
    class DTOCuponeteUser
    {
        private int? UserId = null;

        public int? UserId1
        {
            get { return UserId; }
            set { UserId = value; }
        }
        private String Username = null;

        public String Username1
        {
            get { return Username; }
            set { Username = value; }
        }
        private String Password = null;

        public String Password1
        {
            get { return Password; }
            set { Password = value; }
        }
        private int? FailedAttemps = null;

        public int? FailedAttemps1
        {
            get { return FailedAttemps; }
            set { FailedAttemps = value; }
        }
        private int? RoleId = null;

        public int? RoleId1
        {
            get { return RoleId; }
            set { RoleId = value; }
        }
        private bool? Enabled = null;

        public bool? Enabled1
        {
            get { return Enabled; }
            set { Enabled = value; }
        }
        private bool? Deleted = null;

        public bool? Deleted1
        {
            get { return Deleted; }
            set { Deleted = value; }
        }


    }
}
