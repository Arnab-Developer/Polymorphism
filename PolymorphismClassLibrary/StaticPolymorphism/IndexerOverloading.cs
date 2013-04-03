// ----------------------------------------------------+
// This file containing a class for indexer overloading.
// ----------------------------------------------------+

namespace PolymorphismClassLibrary.StaticPolymorphism
{
    /// <summary>
    /// Class for indexer overloading.
    /// </summary>
    public class IndexerOverloading
    {
        private string[] names;

        /// <summary>
        /// Parameter less constructor.
        /// </summary>
        public IndexerOverloading()
        {
            this.names = new string[3];
        }

        /// <summary>
        /// Indexer to access names.
        /// </summary>
        /// <param name="index">Index number.</param>
        /// <returns>Name in the given index.</returns>
        public string this[int index]
        {
            get
            {
                if (this.IsIndexOutOfBound(index))
                {
                    return this.names[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (this.IsIndexOutOfBound(index))
                {
                    this.names[index] = value;
                }
            }
        }

        /// <summary>
        /// Indexer to access names.
        /// </summary>
        /// <param name="position">Position.</param>
        /// <returns>Name in the given position.</returns>
        public string this[string position]
        {
            get
            {
                int index = this.GetIndexFromPosition(position);

                if (index != -1)
                {
                    return this.names[index];
                }
                else
                {
                    return null;
                }
            }
            set 
            {
                int index = this.GetIndexFromPosition(position);

                if (index != -1)
                {
                    this.names[index] = value;
                }
            }
        }

        private bool IsIndexOutOfBound(int index)
        {
            if (this.names.Length < (index + 1))
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
            char lastChar = position[position.Length - 1];

            int index;
            switch (lastChar)
            {
                case '1':
                    index = 0;
                    break;

                case '2':
                    index = 1;
                    break;

                case '3':
                    index = 2;
                    break;

                default:
                    index = -1;
                    break;
            }

            return index;
        }
    }
}
