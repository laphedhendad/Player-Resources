namespace Laphed.PlayerResources
{
    public class IntegerResource: ResourceBase<int>
    {
        public override void Add(int value) => FullAccessAmount += value;

        public override bool IsEnough(int requiredAmount) => requiredAmount <= FullAccessAmount;

        public override void Spend(int value) => FullAccessAmount -= value;
    }
}