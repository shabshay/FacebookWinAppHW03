using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using System.Collections;

namespace FacebookWinFormApplication.Logic
{
    internal static class GroupsNotifier
    {
        /// <summary>
        /// Send message to all groups in the list.
        /// </summary>
        /// <param name="i_Groups">Facebook groups.</param>
        /// <param name="i_Message">The message that will be posted to the groups in the list.</param>
        public static void SendPost(List<ListGroupItem> i_Groups, string i_Message)
        {
            foreach (ListGroupItem selectedGroupItem in i_Groups)
            {
                selectedGroupItem.GroupFB.PostToWall(i_Message);
            }
        }

        /// <summary>
        /// Validating if message is valid to post.
        /// </summary>
        /// <param name="i_User">The user that the message will be posted on his behalf.</param>
        /// <param name="i_PostMessage">The message that will be posted.</param>
        /// <param name="i_SelectedGroups">The groups list.</param>
        /// <returns></returns>
        public static bool PostIsValid(User i_User, string i_PostMessage, IList i_SelectedGroups)
        {
            if (i_User == null || string.IsNullOrEmpty(i_PostMessage.Trim())
                || i_SelectedGroups == null || i_SelectedGroups.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
