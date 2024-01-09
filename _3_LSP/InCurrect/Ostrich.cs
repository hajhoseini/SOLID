namespace _3_LSP.InCurrect
{
    public class Ostrich : Bird
    {
        // Ostriches can't fly, violating LSP
        public override void Fly()
        {
            throw new InvalidOperationException("Ostriches can't fly!");
        }
    }
}
