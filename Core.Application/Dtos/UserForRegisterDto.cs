namespace Core.Application.Dtos;

public class UserForRegisterDto : IDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string District { get; set; }
    public string Language { get; set; }

    public UserForRegisterDto()
    {
        Email = string.Empty;
        Password = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        Phone = string.Empty;
        CompanyName = string.Empty;
        Address = string.Empty;
        City = string.Empty;
        District = string.Empty;
        Language = string.Empty;
    }


    public UserForRegisterDto(string firstName, string lastName, string email, string password, string phone, string companyName, string address, string city, string district, string language) 
    {
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        CompanyName = companyName;
        Address = address;
        City = city;
        District = district;
        Language = language;
    }
}
