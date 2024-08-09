namespace _9._2C_Iteration_7
{
    public class Path : GameObject
    {
        bool _isAccessible;

        Location _begin;
        Location _end;

        public Path(string[] idents, string name, string description, Location begin, Location end) : base(idents, name, description)
        {
            _begin = begin;
            _end = end;
            _isAccessible = true;

            AddIdentifier("path");

            foreach (string s in name.Split(" "))
            {
                AddIdentifier(s);
            }
        }

        public Location Destination
        {
            get
            {
                return _end;
            }
        }

        public bool IsAccessible
        {
            get
            {
                return _isAccessible;
            }
            set
            {
                _isAccessible = value;
            }
        }

        public Location Begin
        {
            get
            {
                return _begin;
            }
            set
            {
                _begin = value;
            }
        }

        public Location End
        {
            get
            {
                return _end;
            }
            set
            {
                _end = value;
            }
        }
    }
}
