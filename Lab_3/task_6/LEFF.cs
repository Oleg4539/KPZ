using System.Collections.Generic;

public class LEFF
{
    private Dictionary<string, LightElementNode> _cache = new Dictionary<string, LightElementNode>();

    public LightElementNode GetElement(string tagName, DisplayType display, ClosingType closing)
    {
        string key = $"{tagName}-{display}-{closing}";
        if (!_cache.ContainsKey(key))
        {
            var element = new LightElementNode(tagName, display, closing);
            _cache[key] = element;
        }

        var shared = _cache[key];
        var copy = new LightElementNode(shared.TagName, shared.Display, shared.Closing);
        copy.CssClasses.AddRange(shared.CssClasses);
        return copy;
    }

    public int CachedCount => _cache.Count;
}