# Inheritance and composition
----------
- Smaller code
- Easy to read, reuse, extend
- Easy to test
- **The task at hand**

## Inheritance
- Via polimorfism, subtypes can add behavior and code that user superclass wont change. **Subclassing can be done withouth code changes**. 
- Superclassing is often expensive. The **implicit interface** of a superclass is fragile and forces a lot of changes if modified. Both client code and subclasses would require fixing. 

##Composition
- A class doesnt rely on implementations in super classes, therefore, code that uses that class, wont break if the super class interface changes. 
- Instead of inheriting methods, a refference to the other class is created, and the method calls are bypassed to it (delegating it).

-----

### IS A vs HAS A
- Of persons, users, employees, students <- *The right abstraction*



