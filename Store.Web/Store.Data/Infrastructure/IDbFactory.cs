using System;

/// <summary>
/// In order to use the repository pattern in the right manner, we need to define a well designed infrastructure.
/// From the bottom to the top all instances will be available through injected interfaces.
/// </summary>
namespace Store.Data.Infrastructure
{
    /// <summary>
    /// Concrete class that implement this interface must also implement IDisposable one.
    /// </summary>
    public interface IDbFactory:IDisposable
    {
        StoreEntities Init();
    }
}
