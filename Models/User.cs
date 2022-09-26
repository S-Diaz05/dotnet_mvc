namespace dotnet_mvc.Models;

public class User
{
    public string? RequestId { get; set; }
    public string? nombre{get; set;}
    public string? apellidos{get; set;}
    public string? correo{get; set;}

    public string? password{get; set;}
    public string? verify_password{get; set;}
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);


}
