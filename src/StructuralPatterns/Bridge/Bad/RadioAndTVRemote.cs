namespace ConsoleApp1.src.StructuralPatterns.Bridge.Bad
{
    public abstract class RadioAndTVRemote : AdvancedRemote
    {
        public abstract void ControlTV();
        public abstract void ControlRadio();
    }
}