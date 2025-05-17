namespace System.Text.Yaml
{
    /// <summary>
    /// Represents a scalar YAML value.
    /// </summary>
    public sealed class YamlScalarNode : YamlNode
    {
        public YamlScalarNode(string value) => Value = value;
        public string Value { get; }
        public override string ToString() => Value;
    }
}
