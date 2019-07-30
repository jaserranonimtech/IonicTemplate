// =============================
// Email: info@ebenmonney.com
// www.ebenmonney.com/templates
// =============================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateApiIonic.Authorization
{
    public class Policies
    {
        ///<summary>Policy to allow viewing all user records.</summary>
        public const string ViewAllUsersPolicy = "View All Users";

        ///<summary>Policy to allow adding, removing and updating all user records.</summary>
        public const string ManageAllUsersPolicy = "Manage All Users";

        /// <summary>Policy to allow viewing details of all roles.</summary>
        public const string ViewAllRolesPolicy = "View All Roles";

        /// <summary>Policy to allow viewing details of all or specific roles (Requires roleName as parameter).</summary>
        public const string ViewRoleByRoleNamePolicy = "View Role by RoleName";

        /// <summary>Policy to allow adding, removing and updating all roles.</summary>
        public const string ManageAllRolesPolicy = "Manage All Roles";

        /// <summary>Policy to allow assigning roles the user has access to (Requires new and current roles as parameter).</summary>
        public const string AssignAllowedRolesPolicy = "Assign Allowed Roles";

        ///<summary>Policy to allow viewing all Request records.</summary>
        public const string ViewAllRequest = "View Available Request";

        ///<summary>Policy to allow adding, removing and updating all request records.</summary>
        public const string ManageAllRequest = "Manage All Request";

        ///<summary>Policy to allow viewing all Request records.</summary>
        public const string ViewAllAnalisis = "View Available Request";

        ///<summary>Policy to allow adding, removing and updating all request records.</summary>
        public const string ManageAllAnalisis = "Manage All Request";

        ///<summary>Policy to allow viewing all Request records.</summary>
        public const string ViewAllMesaControl = "View Available Mesa de Control";

        ///<summary>Policy to allow adding, removing and updating all request records.</summary>
        public const string ManageAllMesaControl = "Manage All Mesa de Control";

        public const string ViewAllVerificacionReferencias = "View Available Verificacion de Referencias";

        ///<summary>Policy to allow adding, removing and updating all request records.</summary>
        public const string ManageAllVerificacionReferencias = "Manage All Verificacion de Referencias";

        ///<summary>Policy to allow viewing all Request records.</summary>
        public const string ViewAllOficialCumplimiento = "View Available Oficial de Cumplimiento";

        ///<summary>Policy to allow adding, removing and updating all request records.</summary>
        public const string ManageAllOficialCumplimiento = "Manage All Oficial de Cumplimiento";

        ///<summary>Policy to allow viewing all Request records.</summary>
        public const string ViewAllAsesor = "View Available Asesor";

        ///<summary>Policy to allow adding, removing and updating all request records.</summary>
        public const string ManageAllAsesor = "Manage All Asesor";

        ///<summary>Policy to allow viewing all Request records.</summary>
        public const string ViewAllLegal = "View Available Legal";

        ///<summary>Policy to allow adding, removing and updating all request records.</summary>
        public const string ManageAllLegal = "Manage All Legal";

        ///<summary>Policy to allow viewing all Request records.</summary>
        public const string ViewAllGerencia = "View Available Gerencia";

        ///<summary>Policy to allow adding, removing and updating all request records.</summary>
        public const string ManageAllGerencia = "Manage All Gerencia";

        ///<summary>Policy to allow viewing all Request records.</summary>
        public const string ViewAllFinanzas = "View Available Finanzas";

        ///<summary>Policy to allow adding, removing and updating all request records.</summary>
        public const string ManageAllFinanzas = "Manage All Finanzas";


    }



    /// <summary>
    /// Operation Policy to allow adding, viewing, updating and deleting general or specific user records.
    /// </summary>
    public static class AccountManagementOperations
    {
        public const string CreateOperationName = "Create";
        public const string ReadOperationName = "Read";
        public const string UpdateOperationName = "Update";
        public const string DeleteOperationName = "Delete";

        public static UserAccountAuthorizationRequirement Create = new UserAccountAuthorizationRequirement(CreateOperationName);
        public static UserAccountAuthorizationRequirement Read = new UserAccountAuthorizationRequirement(ReadOperationName);
        public static UserAccountAuthorizationRequirement Update = new UserAccountAuthorizationRequirement(UpdateOperationName);
        public static UserAccountAuthorizationRequirement Delete = new UserAccountAuthorizationRequirement(DeleteOperationName);
    }
}
