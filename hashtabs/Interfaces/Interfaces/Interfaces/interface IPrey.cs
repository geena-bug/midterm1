//ABSTRACT DATA TYPES are like user defined data types. they define the expected operations on domain values
//using functions. However, they do not specify the content of the functions or how these
//operations should be performed.
// There are various ways of implementing an ADT.

//The program that uses an ADT is known as the client program. It has access to the ADT/Interface
//The program which implements the data structure is known as the implementation

//We can use an ADT's methods without knowing its implementation. When that implementation is changed in the future,
// The client program can continue to work in the same way without being affected
// Also ADTs are best suited to work with algorithms because the implementation of an algorithm is abstract

// Data structure is a way of organizing data so it can be used effectively 
// i.e queried, added to and updated quickly and easily

interface IPrey
{
    /// <summary>
    /// Displays a prey related message to the console
    /// </summary>
    /// <returns>void</returns> 
    void Flee();
}