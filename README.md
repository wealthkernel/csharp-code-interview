# WealthKernel C# Code Interview

## Getting started

To run this project you will need the following

- A .NET IDE
  - This can be Rider, Visual Studio, VSCode or anything else that can edit code if you're OK using the command line
- .NET Core 3.1+ SDK
- Git, to pull down this repo
 
The program will run on ports `22222` (`http`) and `33333` (`https`).

## What you'll be doing

You'll be implementing a simple Shopping Cart API. We'll walk you through specifics as we go but this is just to get an idea of how you develop and think.

As a tip, think about what happens in real life when you're shopping for something, either in real life or online. How does it work? What problems can you think of?

## Project Structure

### Controller
In the root of the project, there is a file called `ShoppingCartController.cs` which is currently blank. This is where you'll start implementing the API.

### Models
Inside the folder `Models` you will find a very simple `CartItem` that you will probably need to extend for more functionality.

### Data
Inside the folder `Data` there is a simple in memory repository called `Shopping Cart Repository` which you can use inside the controller (it is already added to the DI). Feel free to extend or change it in any way you wish.

### Bus

Inside this folder is a simple in memory bus that is registered with the DI. Do not worry about this unless we get to a point where you're asked to use it.

If you are asked, you'll be shown how it works, and there is an example in the file `ExampleCommand.cs`

## Testing

Up to you! Test how you wish. 

For ease of use there are two testing projects supplied, one of which is for Unit Tests and one is for Integration tests.
