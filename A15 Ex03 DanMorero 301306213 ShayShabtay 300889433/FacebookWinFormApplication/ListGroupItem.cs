using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormApplication
{
    /// <summary>
    /// Group 'wrapper' that overrides Group ToString method and returns the group's name.
    /// </summary>
    internal class ListGroupItem : Group
    {
        public Group GroupFB { get; set; }

        public ListGroupItem(Group i_Group)
        {
            this.GroupFB = i_Group;
        }

        public override string ToString()
        {
            return this.GroupFB.Name;
        }
    }
}
