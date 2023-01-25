* _Create appsettings.json file in GalleryGramApp folder_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[database_name];uid=[USERNAME];pwd=[PASSWORD];"
  }
}
```

* _Create EnvironmentVariables.cs file in GalleryGramApp folder_
```
namespace GalleryGram.Keys
{
  public static class EnvironmentVariables
  {
    public static string ApiKey = "[SANDBOX API KEY]";
  }
}
```