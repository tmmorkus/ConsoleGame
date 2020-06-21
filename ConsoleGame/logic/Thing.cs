

namespace ConsoleGame.logic
{
    class Thing
    {
        public string Name { get; private set; }
        public bool IsMovable { get; private set; }
        public bool IsEatable { get; private set; }

        public Thing (string name, bool isMovable, bool isEatable){
            Name = name;
            IsMovable = isMovable;
            IsEatable = isEatable;
        }





    }
}
