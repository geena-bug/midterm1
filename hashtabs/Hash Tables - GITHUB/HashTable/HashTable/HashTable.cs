using System;
using System.Reflection;

//HashTable class consists of an array of hash linked list entries that chain in a Linked List during collision
public class HashTable<TKey, TValue> : IHashTable <TKey, TValue>
{
    private int InitialCapacity = 10; //Size of table array
    //private const double LoadFactor = 0.75;//number of elements in a hash table divided by the number of slots

    public Entry<TKey, TValue>[] table ;//initialize array of hashtable buckets/ slots/ entries
    private int size; //Takes count of number of entries in the hash table

    // Inner class for entries (linked list nodes)
    public class Entry<TKey, TValue>
    {
        public TKey Key{ get; set; }// Key
        public TValue Value{ get; set; }// Value
        public Entry<TKey, TValue> Next { get; set; }// Next pointer
    }

    //HashTable method creates an array of hashtable entries
    public HashTable()
    {
        table = new Entry<TKey, TValue>[InitialCapacity];// Create new entries table
        size = 0;// Initialize size to 0
    }
    
    //Implements the GetIndex method of the IHashTable interface: Gets the hash index
    public int GetIndex(TKey key)
    {
        int hashCode = key.GetHashCode();// Get the system generated hash code of the key
        int index = Math.Abs(hashCode) % table.Length;// Get the hash index (the reminder when absolute value of
                                                       // of the hash code is divided by the size of the entry table
        return index;// Return index
    }
    
    
    //Implements the AddOrUpdate method of the IHashTable interface: Adds a new entry or updates the entry
    //value if the key already exists
    public void AddOrUpdate(TKey key, TValue value)
    {
        int index = GetIndex(key);//Get index using hash function in the GetIndex method
        var entry = table[index];//Assign the hash table element with the hashed index to variable "entry".
                                 // Note! table[index] is the head/first linked list node in the bucket/ slot 
                                 
        while (entry != null) //While current node is not empty
        {
            if (entry.Key.Equals(key))// If the current node's key is equal to the passed key 
            {
                entry.Value = value;// Make passed value the current node's value (update node)
                return; // return
            }
            entry = entry.Next; //Move to next linked list node
        }
        
        // Create new entry node using passed values

        Entry<TKey, TValue> newEntry = new Entry<TKey, TValue>
        {
            Key = key,
            Value = value,
            Next = table[index] //new node stays in front of chain
        };
        table[index] = newEntry; //Make new node head/ first linked list node
        size++; // increment number of entries by 1
         

        // if (size >= table.Length * LoadFactor) //If number of number of entries >= Hash table lenght * load factor
        //      ResizeTable();// Call ResizeTable method
    }

   
    //Method ResizeTable doubles the size of the entry table
  /*  private int ResizeTable()
    {
        InitialCapacity = InitialCapacity * 2;// Double size of entry table
        return InitialCapacity;// return new size value 
    } */

    // Implements the TryGetValue method of the IHashTable interface: Gets the value of a given key
    public TValue TryGetValue(TKey key )
    {
        int index = GetIndex(key); //Get index using hash function in the GetIndex method
        var entry = table[index];//Assign the hash table element with the hashed index to variable "entry".
                                 // Note! table[index] is the head/first linked list node in the bucket/ slot
                                 
        TValue value; // declare a variable "value" to hold the value of the key/value pair
        

        while (entry != null) // While the linked list node in the given index is not null
        {
            
            if (entry.Key.Equals(key)) // If the node's key is equal to the passed key
            {
               return value = entry.Value;// Return the node's value
                
            }
            entry = entry.Next; //Go to next entry in the linked list 
        }
        Console.WriteLine("key not found");
        return value = default(TValue);// Return a null value if the key is not found 
    }


    // Implements the Remove method of the IHashTable interface: Deletes a given key from the Hash table.
    // If key is in a linked list node, transverse linked list (chain) until found, then delete.
    public bool Remove(TKey key)
    {
        int index = GetIndex(key);// Get the hash index
        
        var entry = table[index];//Assign the hash table element with the hashed index to variable "entry".
                                // Note! table[index] is the head/first linked list node in the bucket/ slot
                                
        Entry<TKey, TValue> prevEntry = null; //initialize node variable to hold the previous node to "null"
        
        while (entry != null)// While current linked list node is not empty
        {
            if (entry.Key.Equals(key))// If the current node's key is equal to the passed key
            {
                if (prevEntry != null)// If previous node is not null
                {
                    //Delete happens here
                    prevEntry.Next = entry.Next;// Make current node's next, the previous node's next
                }
                else // If previous node is null ie node found is first in chain
                    table[index] = entry.Next; // Make current node's next to be table index (first node)

                size--;// Reduce number of entries by 1
                return true;// Return true
            }

            prevEntry = entry;// Put current node in prevEntry variable
            TKey p = prevEntry.Key;
            entry = entry.Next; // Move to next node
            TKey e = entry.Key;
        }

        return false;// Return false
    }

    
}