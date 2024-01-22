using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Laphed.PlayerResources
{
    [DataContract]
    public class Resources<TEnum, T>: IResourcesSystem<TEnum, T> where TEnum: Enum
    {
        [DataMember]
        private Dictionary<TEnum, IResource<T>> resources;
        
        public IResource<T> GetResource(TEnum resourceType) => resources[resourceType];

        public void RegisterResource(TEnum resourceType, IResource<T> resource) =>
            resources.Add(resourceType, resource);

        public void UnregisterResource(TEnum resourceType) => resources.Remove(resourceType);
    }
}