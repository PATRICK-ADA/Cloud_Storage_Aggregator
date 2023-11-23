using System;

namespace Models.UserEntity
{
public class UserEntity
{

    public string UserId{get; set;} = Guid.NewGuid().ToString();
    public string UserName{get; set;} = string.Empty;
    public string Email {get; set;} 

    public string Password{get; set;}

}

}