using FerreteriaSL.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace FerreteriaSL
{
    static class Usuario
    {
        private static string name;
        private static int id;
        public delegate void UserChangedHandler(object sender, EventArgs e);
        public static event UserChangedHandler UserChanged = delegate { };
        private static bool[] permissions = new bool[9];
        public static event EventHandler UserLogedOut;
        
        private static void UserLogedOutHandler()
        {
            EventHandler handler = UserLogedOut;
            if (handler != null)
                handler(null, EventArgs.Empty);
        }

        private static void UserChangedFunction()
        {
            UserChanged(null, EventArgs.Empty);
        }
        
        public static bool[] Permissions
        {
            get { return Usuario.permissions; }

        }

        public static string Name
        {
            get { return Usuario.name; }

        }
        
        public static int ID
        {
            get { return Usuario.id; }

        }

        public static void ChangeUser(int new_id, string new_name, int privilege)
        {
            id = new_id;
            name = new_name;
            setPermissionsArray(Convert.ToDouble(privilege));
            UserChangedFunction();
        }

        private static void setPermissionsArray(double privilege)
        {
            Array.Clear(permissions, 0, permissions.Length);

            // CAMBIAR PARA QUE SE ADAPTER DINAMICAMENTE A LA CANTIDAD DE OPCIONES Y PRIVILEGIOS [MainWindow.cs:37 | Usuario.cs:60 | Usuarios.cs:112]
            for (int i = 9; i >= 1 && privilege > -1; i--) 
            {
                if (privilege - Math.Pow(2, i) > -1)
                {
                    permissions[i-1] = true;
                    privilege -= Math.Pow(2, i);
                }
            }

        }

        public static void LogOut()
        {
            id = -1;
            name = null;
            Array.Clear(permissions, 0, permissions.Length);
            UserLogedOutHandler();
        }

    }

}
