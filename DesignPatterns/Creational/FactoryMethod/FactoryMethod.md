## Factory Method

Define an interface for creating an object, but let subclasses decide which class to instantiate

#### Participants

- AbstractProduct
###### Defines the interface of objects the factory method creates

- ConcreteProduct
###### Implements the AbstractProduct interface

- AbstractCreator
###### Declares the factory method which returns an object of type AbstractProduct. May define a default implementation

- ConcreteCreator
###### Overrides the AbstractCreator factory method to return an instance of a ConcreteProduct
