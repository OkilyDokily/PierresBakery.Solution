
# _Pierre's Bakery_

#### _This demonstrates beginner level C# and unit testing._

#### By _**Matthew**_


## Description

_A page demonstrates basic C# with a console._
_An imaginary bakery where the user can buy items_

                                  
## Setup/Installation Requirements

| Spec | Input | Output |
|-|-|-|
| create new Bread Object | new Bread(5) | Bread{Amount:5} |
| ensure bread Amount equals 5 and singleitem == 5 | new Bread(5) | b.Amount == 5 && singleitem== 5 |
| create new Pastry Object and singleitem == 2 | new Pastry(5) | Pastry{Amount:5} && singleitem == 2 |
| ensure Pastry Amount equals 5 | new Pastry(5) | p.Amount == 5 |
| create a Bread method to process two for 5 deal | bread.TwoFor5(17) | 16* 5 + SingleItemPrice |
| create a new Pastry method to process three for five deal | pastry.ThreeFor5(29) | 9 * 3 + 2 * SingleItemPrice |
| Dry up code by adding an inheritable BakeryItem class |  |  |
| Create an Order Class to hold bread and pastry orders |  |  |
| Create a static AddToOrder method | Order.AddToOrder(new Pastry(5)) | static List<BreadItems> {new Pastry(5)} |
| Create subclasses for Bread and Pastry | new Brioche(),new Croissant etc | Brioche object etc |
| ensure subobjects are created correctly  | new Brioche() | Brioche{contains bread properties} |
| ensure subobjects can be added to orders | Order.AddToOrder(new Brioche(5)) | static List<BreadItems> {new Brioche(5)} |
| Create a special 3 for 7 deal on Brioche with a default price of 4 | new Brioche(7).Deal() | 15 |
| Create a special 4 for 5 on Croissants with same default price | new Croissant(9).Deal() | 12 |
| create a generic method that takes a subobject such as Brioche and then calls the total | GetTotalValueOfOrderForAType<T>() | 56 for ex |
| create a generic method that calls the previous method for each type based on a dictionary/list | GetTotals | 135 for ex |
| Create a static method that tells how many items of each kind have been purchased | Order.GetItemizedNumbers() | 3 Pastries,  |
## Known Bugs

_I don't think there are any bugs but please tell me if you see any._

## Support and contact details

_Open a Github issue if you see a problem or have questions_

## Technologies Used

_This is a C#,MSTest, and console thing._

### License

*Feel free to use this code as you please*

Copyright (c) 2020 **_Matthew_**
