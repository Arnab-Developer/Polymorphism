namespace PolymorphismDemo.Lib.StaticPolymorphism
{
    public class IndexerOverloading
    {
        private readonly string[] _names;
        public IndexerOverloading()
        {
            _names = new string[3];
        }

        public string this[int index]
        {
            get
            {
                if (IsIndexOutOfBound(index))
                {
                    return _names[index];
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (IsIndexOutOfBound(index))
                {
                    _names[index] = value;
                }
            }
        }

        public string this[string position]
        {
            get
            {
                int index = GetIndexFromPosition(position);

                if (index != -1)
                {
                    return _names[index];
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                int index = GetIndexFromPosition(position);

                if (index != -1)
                {
                    _names[index] = value;
                }
            }
        }

        private bool IsIndexOutOfBound(int index)
        {
            if (_names.Length < (index + 1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int GetIndexFromPosition(string position)
        {
            char lastChar = position[^1];
            var index = lastChar switch
            {
                '1' => 0,
                '2' => 1,
                '3' => 2,
                _ => -1,
            };
            return index;
        }
    }
}
