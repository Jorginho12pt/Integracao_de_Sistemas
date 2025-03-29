using System;
using System.ComponentModel;

namespace AplicacaoDesktop
{
    public static class EnumEx
    {
        public static int GetValueFromDescription<T>(string description) where T : Enum
        {
            foreach (var field in typeof(T).GetFields())
            {
                if (Attribute.GetCustomAttribute(field,
                typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description == description)
                        return (int)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (int)field.GetValue(null);
                }
            }

            return default(int);
        }
    }
}
