# AWSCognitoLogin

Made this for a project in use, after not seeing much documentation on AWS I figured I would share a working example utilizing basic
`Username` and `Password` login with Cognito UserPools.

Utilizes Serverless:

In the serverless.yml file.

replace `bucketname` with an avalible s3 bucket for the deployment.
replace `service` with a name of your own.

- run the build commands:

mac/linux `./build.sh`

or 

Powershell/Windows
`.\build.cmd`


Made this for a project in use, after not seeing much documentation on AWS I figured I would share a working example utilizing basic
`Username` and `Password` login with Cognito UserPools.

**Utilizes a Serverless Template:**

*In the serverless.yml file.*

replace `bucketname` with an available s3 bucket for the deployment.
replace `service` with a name of your own.

- run the build commands:
mac/linux `./build.sh` 
powershell/Windows `.\build.cmd`

- run the command shell command:

`serverless deploy` or `sls deploy`


**You will need to add environment variables to the lambda function directly, for simplicity I kept them as is but would recommend  to utilize** 
`AWS Secrets Manager`

*Environment Variables needed:*

`CLIENT` = ClientID form Cognito userpool
`POOL` = PoolID From Cognito userpool
`ACCESS` = AWS Access Key 
`SECRET`= AWS Secret Access Key


### I Advise you to modify this better to fit your needs. Hopefully its able to file in the blanks that AWS misses in the docs.

