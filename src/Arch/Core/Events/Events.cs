﻿
namespace Arch.Core.Events;

#if EVENTS
/// <summary>
///     The <see cref="Events"/> class
///     acts as a storage for all registered event handlers and stores them properly in lists.
/// </summary>
internal class Events
{
    internal readonly List<ComponentAddedHandler> ComponentAddedHandlers = new();
    internal readonly List<ComponentSetHandler> NonGenericComponentSetHandlers = new();
    internal readonly List<ComponentRemovedHandler> ComponentRemovedHandlers = new();
}

/// <summary>
///     The <see cref="Events{T}"/> class
///     acts as a storage for generic events and stores them in specified lists. 
/// </summary>
/// <typeparam name="T"></typeparam>
internal class Events<T> : Events
{
    internal readonly List<ComponentSetHandler<T>> ComponentSetHandlers = new();
}
#endif