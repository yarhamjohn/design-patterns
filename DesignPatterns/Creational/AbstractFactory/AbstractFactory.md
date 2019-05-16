## Abstract Factory

Provides an interface for creating families of related or dependant objects without specifying their concrete classes.

#### Participants

- AbstractFactory
###### Declares an interface for operations that create AbstractProducts

- ConcreteFactory
###### Implements the operations to create concrete product objects

- AbstractProduct
###### Declares an interface for a type of product object

- Product
###### Implements the AbstractProduct interface. Defines a product object to be created by the corresponding concrete factory

- Client
###### Uses interfaces declared by the AbstractFactory and AbstractProduct classes
