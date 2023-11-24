using System;
using Google.Apis.Drive.v3;
using System.Collections.Generic;


namespace Models.UserCloudAcc
{
public class UserCloudAcc

{
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string RedirectUri { get; set; }
    public List<DriveService> DriveServices { get; set; } = new List<DriveService>();
    

}

}