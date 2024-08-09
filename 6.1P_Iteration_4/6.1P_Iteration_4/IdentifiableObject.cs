namespace _6._1P_Iteration_4;

public class IdentifiableObject
{
    private List<string> _identifiers = new List<string>();
    public IdentifiableObject(string[] idents)
    {
        _identifiers = idents.ToList();
    }

    public bool AreYou(string id)
    {
        for (int i = 0; i < _identifiers.Count; i++)
        {
            string x = _identifiers[i];
            if (x == id.ToLower())
                return true;
        }
        return false;

    }

    public string FirstId
    {
        get
        {
            if (_identifiers.Count == 0)
                return "";
            return _identifiers[0];
        }
    }

    public void AddIdentifier(string id)
    {
        _identifiers.Add(id.ToLower());
    }
}
