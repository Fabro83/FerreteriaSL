using System;

namespace FerreteriaSL.Clases_Genericas
{
    static class Usuario
    {
        public delegate void UserChangedHandler(object sender, EventArgs e);
        public static event UserChangedHandler UserChanged = delegate { };
        private static readonly bool[] _permissions = new bool[9];
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
            get { return _permissions; }

        }

        public static string Name { get; private set; }

        public static int Id { get; private set; }

        public static void ChangeUser(int newId, string newName, int privilege)
        {
            Id = newId;
            Name = newName;
            SetPermissionsArray(Convert.ToDouble(privilege));
            UserChangedFunction();
        }

        private static void SetPermissionsArray(double privilege)
        {
            Array.Clear(_permissions, 0, _permissions.Length);

            // CAMBIAR PARA QUE SE ADAPTER DINAMICAMENTE A LA CANTIDAD DE OPCIONES Y PRIVILEGIOS [MainWindow.cs:37 | Usuario.cs:60 | Usuarios.cs:112]
            for (int i = 9; i >= 1 && privilege > -1; i--) 
            {
                if (privilege - Math.Pow(2, i) > -1)
                {
                    _permissions[i-1] = true;
                    privilege -= Math.Pow(2, i);
                }
            }

        }

        public static void LogOut()
        {
            Id = -1;
            Name = null;
            Array.Clear(_permissions, 0, _permissions.Length);
            UserLogedOutHandler();
        }

    }

}
