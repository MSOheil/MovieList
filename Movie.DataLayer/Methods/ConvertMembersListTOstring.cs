using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DataLayer.ExtentionMethodHelper
{
    public static class ConvertMembersListTOstring
    {
        public static string ConvertListToString(IEnumerable<string> listMembers)
        {
            string memberList = "";
            foreach (var item in listMembers)
            {
                memberList += Convert.ToString(item) + ",";
            }
            return memberList;
        }


    }
}
