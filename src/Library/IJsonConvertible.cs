namespace Recipies
{
    /// <summary>
    /// Define el tipo que tienen los objetos que pueder ser serializados en y deserializados desde texto en formato
    /// Json.
    /// </summary>
    public interface IJsonConvertible
    {
        string ConvertToJson();

        void LoadFromJson(string json);
    }
}