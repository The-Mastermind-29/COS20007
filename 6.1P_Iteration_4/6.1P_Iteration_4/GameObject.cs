namespace _6._1P_Iteration_4;

public abstract class GameObject : IdentifiableObject
{
    private string _name;
    private string _description;

    public GameObject(string[] ids, string name, string description) : base(ids)
    {
        _name = name;
        _description = description;
    }

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public string ShortDescription
    {
        get
        {
            return _name + " (" + FirstId + ")";
        }
    }

    public virtual string FullDescription
    {
        get
        {
            return _description;
        }
    }
}
