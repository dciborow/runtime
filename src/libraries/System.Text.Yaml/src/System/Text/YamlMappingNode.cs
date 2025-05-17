using System.Collections;
using System.Collections.Generic;

namespace System.Text.Yaml
{
    /// <summary>
    /// Represents a mapping of keys to YAML nodes.
    /// </summary>
    public sealed class YamlMappingNode : YamlNode, IEnumerable<KeyValuePair<string, YamlNode>>
    {
        private readonly Dictionary<string, YamlNode> _children = new();

        public YamlNode this[string key]
        {
            get => _children[key];
            set => _children[key] = value;
        }

        public IEnumerator<KeyValuePair<string, YamlNode>> GetEnumerator() => _children.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
