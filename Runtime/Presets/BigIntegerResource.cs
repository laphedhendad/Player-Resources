using System.Numerics;

namespace Laphed.PlayerResources
{
    public class BigIntegerResource: ResourceBase<BigInteger>
    {
        public override void Add(BigInteger value) => FullAccessAmount += value;

        public override bool IsEnough(BigInteger requiredAmount) => requiredAmount <= FullAccessAmount;

        public override void Spend(BigInteger value) => FullAccessAmount -= value;
    }
}