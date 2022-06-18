using CourseManagementApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagementApp
{
    internal class Group
    {
        private static int _totalCount = 1000;
        public Group(GroupType type)
        {
            this.Type = type;
            _totalCount++;
            No = Enum.GetName(typeof(GroupType), type)[0] + _totalCount.ToString();
        }

        public string No { get; }
        public GroupType Type;
        public int StudentLimit;
    }
}
