using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odoo_Security_Support.FileHandle
{
    class Handle
    {
        public static string[] GetPermission(string model_id, string groupId, List<string> AvailableAccess)
        {
            var permission = new string[4] { "1", "0", "0", "0" };
            if (AvailableAccess != null)
            {
                foreach (var accessLine in AvailableAccess)
                {
                    if (accessLine.Contains(model_id) && accessLine.Contains(groupId))
                        permission = accessLine.Split(',').Skip(4).ToArray();
                }
            }
            return permission;

        }

        public static List<string[]> GetAccess(List<string> Models, List<string> Groups, List<string> AvailableAccess)
        {
            var access = new List<string[]>();
            foreach (var model in Models)
            {
                foreach (var groupId in Groups)
                {
                    var _model = model.Replace(".", "_");
                    var name = string.Format("{0}_{1}", _model, groupId.Replace(".", "_"));
                    var id = string.Format("access_{0}", name);
                    var model_id = string.Format("model_{0}", _model);
                    var perm = GetPermission(model_id, groupId, AvailableAccess);
                    var permLine = new string[] { id, name, model_id, groupId, perm[0], perm[1], perm[2], perm[3] };
                    access.Add(permLine);
                }
                access.Add(new string[] { "", "", "", "", "", "", "", "", "", "" });
            }
            return access;
        }
    }
}
