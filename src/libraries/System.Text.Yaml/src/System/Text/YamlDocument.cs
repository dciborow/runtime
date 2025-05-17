namespace System.Text.Yaml
{
    /// <summary>
    /// Represents a parsed YAML document.
    /// </summary>
    public sealed class YamlDocument
    {
        public YamlDocument(YamlMappingNode root) => Root = root;
        public YamlMappingNode Root { get; }
    }
}
