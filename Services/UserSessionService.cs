namespace EventEase.Services;

public class UserSessionService
{
    public string UserName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public bool IsRegistered { get; set; }

    public int EventsAttended { get; set; }

    public void Register(string name, string email)
    {
        UserName = name;
        Email = email;
        IsRegistered = true;
    }

    public void MarkAttendance()
    {
        EventsAttended++;
    }
}