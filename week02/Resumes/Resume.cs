public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        //Job because b in he list is a Job instance
        foreach (Job b in _jobs)
        {
            b.Display();
        }
    }
}