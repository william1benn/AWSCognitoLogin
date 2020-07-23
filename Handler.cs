using Amazon.Lambda.Core;
using System;
using Amazon;
using Amazon.CognitoIdentity;
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Extensions.CognitoAuthentication;
using System.Threading.Tasks;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AwsDotnetCsharp
{
    public class Handler
    {
      public async Task<object> CognitoSignIn(UserRequest creds)
       {
          string accessKey = Environment.GetEnvironmentVariable("ACCESS");
          string secretKey = Environment.GetEnvironmentVariable("SECRET");
          // string provider = Environment.GetEnvironmentVariable("PROVIDER");
          string poolId = Environment.GetEnvironmentVariable("POOL");
          string client = Environment.GetEnvironmentVariable("CLIENT");
       try{

            using var AmazonCognitoP = new AmazonCognitoIdentityProviderClient(
                awsAccessKeyId: accessKey,
                awsSecretAccessKey: secretKey, 
                region:RegionEndpoint.USEast1);
                
                   var authReq = new AdminInitiateAuthRequest
                {
                    UserPoolId = poolId,
                    ClientId = client,
                    AuthFlow = AuthFlowType.ADMIN_NO_SRP_AUTH
                };
                authReq.AuthParameters.Add("USERNAME", creds.userName);
                authReq.AuthParameters.Add("PASSWORD", creds.passWord);

                 var authResp = await AmazonCognitoP.AdminInitiateAuthAsync(authReq);

                 return authResp;
            } 
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
