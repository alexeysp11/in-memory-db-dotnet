using System.Collections.Generic;

namespace WorkflowLib.InMemoryDatabase.DataStorage.Primitives;

public class BalancedTreeElement<T>
{
    public T Data { get; set; }
    public BalancedTreeElement<T> Left { get; set; }
    public BalancedTreeElement<T> Right { get; set; }

    public BalancedTreeElement(T value)
    {
        Data = value;
    }
}