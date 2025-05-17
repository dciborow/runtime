using Xunit;
using System.Text.Yaml;

public class YamlParserTests
{
    [Fact]
    public void ParseSimpleMapping()
    {
        string text = "foo: bar\nbaz: qux";
        var doc = YamlParser.Parse(text);
        Assert.Equal("bar", ((YamlScalarNode)doc.Root["foo"]).Value);
        Assert.Equal("qux", ((YamlScalarNode)doc.Root["baz"]).Value);
    }

    [Fact]
    public void SerializeSimpleMapping()
    {
        string text = "foo: bar\nbaz: qux";
        var doc = YamlParser.Parse(text);
        string serialized = YamlSerializer.Serialize(doc);
        Assert.Contains("foo: bar", serialized);
        Assert.Contains("baz: qux", serialized);
    }
}
