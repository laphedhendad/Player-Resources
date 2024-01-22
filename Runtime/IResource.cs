using Laphed.Rx;

namespace Laphed.PlayerResources
{
    public interface IResource<T>
    {
        IReadonlyReactiveProperty<T> Amount { get; }
        void Set(T value);
        void Add(T value);
        bool IsEnough(T requiredAmount);
        void Spend(T value);
    }
}