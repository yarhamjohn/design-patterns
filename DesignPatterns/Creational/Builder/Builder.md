## Builder

Separate the construction of a complex object from its representation so that the same construction process can create different representations.

#### Participants

- AbstractBuilder
###### Specifies an interface for creating parts of a product object

- ConcreteBuilder
###### Implements the AbstractBuilder interface to construct the parts of the product object. Keeps track of the representation it creates and provides an interface for retrieving the product

- Director
###### Constructs an object using the AbstractBuilder interface

- Product
###### Represents the complex object constructed by the ConcreteBuilder including classes that define the parts and interfaces for assembling the parts
