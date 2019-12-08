namespace ComboBoxMemoryLeakSample
{
    public sealed class TestItem
    {
        public string Name { get; }

        public TestItem(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}