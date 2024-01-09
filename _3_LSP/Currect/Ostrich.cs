namespace _3_LSP.Currect
{
    public class Ostrich : IFlyable
    {
        // Ostriches can't fly, but the interface is still respected
        public void Fly()
        {
            throw new InvalidOperationException("Ostriches can't fly!");
        }
    }
}
