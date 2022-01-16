namespace SimpleGltf.Json.Extensions;

public static class MaterialExtensions
{
    public static MaterialPbrMetallicRoughness CreatePbrMetallicRoughness(this Material material)
    {
        var pbrMetallicRoughness = new MaterialPbrMetallicRoughness();
        material.MaterialPbrMetallicRoughness = pbrMetallicRoughness;
        return pbrMetallicRoughness;
    }
}