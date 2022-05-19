

namespace TreesHashSet
{
    class RandomName
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public override bool Equals(object obj)
        {
            var user = obj as RandomName;

            if (user == null)
                return false;
            return FirstName == user.FirstName && SecondName == user.SecondName;
        }
        public override int GetHashCode()
        {
            int firtsNameHashCode = FirstName?.GetHashCode() ?? 0;
            int secondNameHashCode = SecondName?.GetHashCode() ?? 0;
            return firtsNameHashCode ^ secondNameHashCode;
        }
    }
}
