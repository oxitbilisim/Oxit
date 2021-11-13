using Newtonsoft.Json;
using Oxit.Core.Enums;

namespace Oxit.Core.Utilities
{
    public static class Json
    {
        public static string ToJson(this object obj, JsonRefHandlers handler = JsonRefHandlers.Ignore)
        {

            if (handler == JsonRefHandlers.None)

                return JsonConvert.SerializeObject(obj);


            JsonSerializerSettings settings = new JsonSerializerSettings();

            if (handler == JsonRefHandlers.Ignore)
            {
                settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            }
            else if (handler == JsonRefHandlers.Preserve)
            {
                settings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
            }

            return JsonConvert.SerializeObject(obj, settings);


        }
    }
}
