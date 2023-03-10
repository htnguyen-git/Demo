using System;
using System.Collections.Generic;
using System.IO;
using Dropbox.Sign.Api;
using Dropbox.Sign.Client;
using Dropbox.Sign.Model;

public class Example
{
    public static void Main()
    {
        var config = new Configuration();
        // Configure HTTP basic authorization: api_key
        config.Username = "YOUR_API_KEY";

        // or, configure Bearer (JWT) authorization: oauth2
        // config.AccessToken = "YOUR_BEARER_TOKEN";

        var apiAppApi = new ApiAppApi(config);

        var oauth = new SubOAuth(
            callbackUrl: "https://example.com/oauth",
            scopes: new List<SubOAuth.ScopesEnum>() {
                SubOAuth.ScopesEnum.BasicAccountInfo,
                SubOAuth.ScopesEnum.RequestSignature
            }
        );

        var whiteLabelingOptions = new SubWhiteLabelingOptions(
            primaryButtonColor: "#00b3e6",
            primaryButtonTextColor: "#ffffff"
        );

        var customLogoFile = new FileStream(
            "CustomLogoFile.png",
            FileMode.Open
        );

        var data = new ApiAppUpdateRequest(
            name: "My Production App",
            domains: new List<string>(){"example.com"},
            oauth: oauth,
            whiteLabelingOptions: whiteLabelingOptions,
            customLogoFile: customLogoFile
        );

        var clientId = "0dd3b823a682527788c4e40cb7b6f7e9";

        try
        {
            var result = apiAppApi.ApiAppUpdate(clientId, data);
            Console.WriteLine(result);
        }
        catch (ApiException e)
        {
            Console.WriteLine("Exception when calling Dropbox Sign API: " + e.Message);
            Console.WriteLine("Status Code: " + e.ErrorCode);
            Console.WriteLine(e.StackTrace);
        }
    }
}
