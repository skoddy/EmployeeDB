using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace EmployeeManagement
{
    public static class Extensions
    {

        public static List<T> DataTableToList<T>(this DataTable table) where T : new()
        {
            // Eigenschaften des generischen Objekts auslesen
            // und zur Liste konvertieren.
            IList<PropertyInfo> properties = typeof(T).GetProperties().ToList();

            // Generische Liste initialisieren.
            List<T> items = new List<T>();

            // Zeilen der Tabelle auslesen.
            // Für jede Zeile in der Tabelle..
            foreach (var row in table.Rows)
            {
                // ...wird aus den Zellen der Zeile ein 
                // Item (Schlüssel-Wert-Paar) für die Liste erstellt.
                var item = CreateItem<T>((DataRow)row, properties);

                // Item der Liste hinzufügen.
                items.Add(item);
            }

            return items;
        }

        private static T CreateItem<T>(DataRow row, IList<PropertyInfo> properties) where T : new()
        {
            T item = new T();

            // Eigenschaften auslesen.
            foreach (var property in properties)
            {
                // Sonderfälle DayOfWeek und DBNull abfangen.
                // Schlüssel-Wert-Paare für die Liste erstellen.
                // Aus der Eigenschaft des generischen Objekts wird der Schlüssel.
                // Aus der Tabellenzelle wird Wert.
                if (property.PropertyType == typeof(DayOfWeek))
                {
                    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), row[property.Name].ToString());
                    property.SetValue(item, day, null);
                }
                else
                {
                    if (row[property.Name] == DBNull.Value)
                        property.SetValue(item, null, null);
                    else
                        property.SetValue(item, row[property.Name], null);
                }
            }
            return item;
        }
    }
}
