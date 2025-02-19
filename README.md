*Check the wiki for more information*

Assignment: Implementing the Builder Design Pattern in a C# Console Application
Objective:

Design and implement a C# console application using the Builder Design Pattern to construct complex objects step by step. The goal is to build an object with multiple parts or configurations using a builder.
Assignment Breakdown:
Assignment 1: Define the Product Class

Objective: Create the product that will be constructed step by step by the builder.

    Define a class that represents the complex object to be built. This class should have several properties representing different parts of the object.
    Include methods to display the constructed object and its components.

Assignment 2: Define the Builder Interface

Objective: Create an interface for building the product.

    Define an interface that declares methods for building different parts of the product.
    Include methods to initialize or reset the product.
    The interface should define separate methods for each part of the product.

Assignment 3: Implement Concrete Builders

Objective: Create concrete builder classes that implement the builder interface.

    Implement one or more concrete builder classes that provide specific implementations of each method in the builder interface.
    Each builder class should be responsible for building parts of the product and storing the resulting product instance.

Assignment 4: Implement the Director Class

Objective: Create a director class that controls the construction process.

    Implement a Director class that uses a builder to create the product.
    The director should have methods to construct different variations of the product using the builder (e.g., a "simple" product and a "complex" product).
    The director does not need to know the details of the construction but should delegate the process to the builder.

Assignment 5: Test the Builder Pattern

Objective: Write test code to construct the product using different builder configurations.

    In the Main() method of the console application, create instances of the director and concrete builders.
    Use the director to construct the product by calling different configurations and displaying the final result.
    Ensure that the product can be built with different variations and parts using the builder.

Bonus Assignment: Fluent Builder Interface (Optional)

Objective: Enhance the builder with a fluent interface.

    Refactor the builder classes to allow method chaining so that the construction of the product can be done more fluently.
    Modify the builder methods to return the builder instance, allowing calls to be chained together in a single line.

Submission Requirements:

    Code Implementation:
        Submit your C# files for each part of the assignment. Ensure the code compiles and runs successfully.
    Documentation:
        Provide brief documentation explaining how your builder pattern works.
    Test Cases:
        Include test cases in the Main() method to demonstrate the functionality of the builder pattern and how it handles different product configurations.

Let me know if you need any clarification or further instructions!
