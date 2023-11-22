using System;

namespace Models.UserCloudAcc
{
public class UserCloudAcc

{
public string CloudProviderId {get; set;} = Guid.NewGuid().ToString();
public string UserEmail {get; set;}
public string UserPassword {get; set;}

public string UserId {get; set;}


}

}