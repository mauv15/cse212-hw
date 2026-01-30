using System.Collections.Generic;

public class FeatureCollection
{
    public string? Type { get; set; }
    public List<Feature> Features { get; set; } = new();
}

public class Feature
{
    public string? Type { get; set; }
    public FeatureProperties? Properties { get; set; }
}

public class FeatureProperties
{
    public double? Mag { get; set; }
    public string? Place { get; set; }
}
