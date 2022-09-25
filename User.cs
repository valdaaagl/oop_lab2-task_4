class User
{
    public string login;
    public string Login
    {
        get
        {
            return this.login;
        }
        set
        {
            login = value;
        }
    }
    public string name;
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            name = value;
        }
    }
    public string surname;
    public string Surnme
    {
        get
        {
            return this.surname;
        }
        set
        {
            surname = value;
        }
    }
    public int age;
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            age = value;
        }
    }
    public static string date = "25/09/22";
}