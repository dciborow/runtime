using System;

namespace System.Text.Yaml
{
    /// <summary>
    /// Very small YAML parser handling simple key/value pairs.
    /// </summary>
    public static class YamlParser
    {
        public static YamlDocument Parse(string yaml)
        {
            if (yaml is null)
                throw new ArgumentNullException(nameof(yaml));

            YamlMappingNode root = new();
            foreach (string line in yaml.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                string trimmed = line.Trim();
                if (trimmed.Length == 0 || trimmed.StartsWith("#"))
                    continue;

                string[] parts = trimmed.Split(':', 2);
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();
                    root[key] = new YamlScalarNode(value);
                }
            }

            return new YamlDocument(root);
        }
    }
}
