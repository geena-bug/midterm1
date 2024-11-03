public interface ILinkedList<T> //Linked 
{
    /// <summary>
    /// Adds a new node to the beginning of the linked list
    /// </summary>
    /// <param name="data">The contents of the node to be added to the linked list</param>
    /// <returns>void</returns>
     void InsertFirst(T data);

    /// <summary>
    /// Deletes the node at the beginning of the linked list
    /// </summary>
    /// <returns>The deleted node</returns> 
     Node<T> DeleteFirst();

    /// <summary>
    /// Iterates through the linked list from the head
    /// </summary>
    /// <returns>void</returns> 
     void DisplayList();
}