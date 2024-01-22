using Laphed.Rx;

namespace Laphed.PlayerResources
{
    public abstract class ResourceBase<T>: IResource<T>
    {
        public IReadonlyReactiveProperty<T> Amount => internalAmountProperty;

        private readonly IReactiveProperty<T> internalAmountProperty = new ReactiveProperty<T>();
        protected T FullAccessAmount
        {
            get => internalAmountProperty.Value;
            set => internalAmountProperty.Value = value;
        }
        
        public virtual void Set(T value) => FullAccessAmount = value;

        public abstract void Add(T value);

        public abstract bool IsEnough(T requiredAmount);

        public abstract void Spend(T value);
    }
}