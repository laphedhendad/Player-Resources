namespace Laphed.PlayerResources
{
    public class FloatResource: ResourceBase<float>
    {
        public override void Add(float value) => FullAccessAmount += value;

        public override bool IsEnough(float requiredAmount) => requiredAmount <= FullAccessAmount;

        public override void Spend(float value) => FullAccessAmount -= value;
    }
}