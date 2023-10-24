string[] roles = { "administrator", "user", "manager" };
string? roleName;
bool keep_running = true;
string? loweredRoleName;

Console.WriteLine("Enter your role: ");

do
{
    roleName = Console.ReadLine();
    loweredRoleName = roleName.ToLower();
    if (Array.Exists(roles, role => role == loweredRoleName))
    {
        Console.WriteLine($"Your input value ({roleName}) has been accepted.");
        keep_running = false;
        
    }
    else
    {
        Console.WriteLine($"The role name that you entered, \"{roleName}\" is not valid. Enter your role name (Administrator, Manager, or User)");
        do
        {
            roleName = Console.ReadLine();
            loweredRoleName = roleName.ToLower();
            if (Array.Exists(roles, role => role == loweredRoleName))
            {
                Console.WriteLine($"Your input value ({roleName}) has been accepted.");
                keep_running = false;
                break;
            }
            else
            {
                Console.WriteLine($"The role name that you entered, \"{roleName}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            }
        } while (true);
    }

} while (keep_running);

Console.ReadLine();