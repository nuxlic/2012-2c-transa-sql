using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrouponDesktop.Commons.Database.DTO
{
    class DTOCuponeteUser
    {
        private int? _UserId = null;

        public int? UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        private String _Username = null;

        public String Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        private String _Password = null;

        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        private int? _FailedAttemps = null;

        public int? FailedAttemps
        {
            get { return _FailedAttemps; }
            set { _FailedAttemps = value; }
        }
        private int? _RoleId = null;

        public int? RoleId
        {
            get { return _RoleId; }
            set { _RoleId = value; }
        }
        private bool? _Enabled = null;

        public bool? Enabled
        {
            get { return _Enabled; }
            set { _Enabled = value; }
        }
        private bool? _Deleted = null;

        public bool? Deleted
        {
            get { return _Deleted; }
            set { _Deleted = value; }
        }


    }
}
