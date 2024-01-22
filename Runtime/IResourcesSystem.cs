using System;

namespace Laphed.PlayerResources
{
    
    public interface IResourcesSystem<TEnum, T> where TEnum: Enum
    {
        IResource<T> GetResource(TEnum resourceType);
        void RegisterResource(TEnum resourceType, IResource<T> resource);
        void UnregisterResource(TEnum resourceType);
    }
}