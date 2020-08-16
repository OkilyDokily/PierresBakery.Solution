
# _Pierre's Bakery_
| Spec | Input | Output |
|-|-|-|
| Dry up code by adding an inheritable abstract bakeryItem class that contains purely unimplemented properties and a deal method |  |  |
| Create a bread and pastry class that are also abstract and pass default implementation to the BakerItem class via its constructor | Bread() |  |
| Create subclasses on Bread and Pastry such as Brioche | new Brioche(),new Croissant etc | Brioche object etc |
| Allow Order Class to add new orders  | Order.AddOrder("Croissant", 5) | Dictionary<string,int>{{"Croissant",5}} |
| ensure subobjects call Deal correctly on subobjects that utilize default implementation for bread and pastry | new Zwiebel().Deal(amount) | 37 for ex |
| Create a special 3 for 7 deal on Brioche with a default price of 4 | new Brioche(7).Deal() | 15 |
| Create a special 4 for 5 on Croissants with same default price | new Croissant(9).Deal() | 12 |
| Create a static method that returns a dictionary for each category and a corresponding dictionary for each item in that category that includes the amount ordered and the deal for each item. | getTotalsForAllOrder() | Dictionary{"Bread",Dictionary{"Brioche",[10,23]},{Zwieback, [5, 15},},{"Pastry", Dictionary{"Croissant",[5,16]}} |
#### _This demonstrates beginner level C# and unit testing._

#### By _**Matthew**_


## Description

_A page demonstrates basic C# with a console._
_An imaginary bakery where the user can buy items_

                                  
## Setup/Installation Requirements

## Known Bugs

_I don't think there are any bugs but please tell me if you see any._

## Support and contact details

_Open a Github issue if you see a problem or have questions_

## Technologies Used

_This is a C#,MSTest, and console thing._

### License

*Feel free to use this code as you please*

Copyright (c) 2020 **_Matthew_**
