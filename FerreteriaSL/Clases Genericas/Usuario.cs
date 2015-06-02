using System;
using System.Collections.Generic;
using System.Linq;
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

        public static Settings userSettings = new Settings();
        //private static bool testing = true;

        //public static bool Testing
        //{
        //    get { return Usuario.testing; }
        //    set { Usuario.testing = value; }
        //}
        
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
    
    public class Settings
    {
        private bool test;

        public bool Test
        {
            get { return test; }
            set { test = value; }
        }

        public Settings()
        {
            this.test = false;
        }
    
    }

    public class PrintOptions
    {
        private int testVariable;

        public int TestVariable
        {
            get { return testVariable; }
            set { testVariable = value; }
        }

        public PrintOptions()
        {
            this.testVariable = 1;
        }

    }

}
