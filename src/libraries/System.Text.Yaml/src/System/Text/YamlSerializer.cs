using System.Text;

namespace System.Text.Yaml
{
    /// <summary>
    /// Serializes YAML documents.
    /// </summary>
    public static class YamlSerializer
    {
        public static string Serialize(YamlDocument document)
        {
            StringBuilder sb = new();
            foreach (var kvp in document.Root)
            {
                if (kvp.Value is YamlScalarNode scalar)
                {
                    sb.AppendLine($"{kvp.Key}: {scalar.Value}");
                }
            }
            return sb.ToString();
        }
    }
}
