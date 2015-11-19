namespace FerreteriaSL.Clases_Genericas
{
    public static class CommonStringParser
    {
        public static string EscapeSqlQuery(string query)
        {
            return query.Replace("'", "\\'");
        }
    }
}
