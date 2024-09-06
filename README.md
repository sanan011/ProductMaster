# Product Management System
## Project Name: **ProManage**

### Description
ProManage is a console-based application designed to manage product inventories efficiently. It allows users to add, view, update, and remove products in an inventory. The application is built using Object-Oriented Programming (OOP) principles in C#, ensuring a modular and maintainable codebase.

### Features
- **Add Products**: Users can add new products to the inventory, specifying details like brand, model, category, price, and quantity.
- **View All Products**: Display all products in the inventory with their respective details.
- **Update Products**: Users can update product details by specifying the product and the properties to be updated.
- **Remove Products**: Remove a product from the inventory by specifying its index.
- **View Products by Category**: Easily view all products within a specific category.
- **Calculate Total Price**: Compute the total price of products in the entire inventory or within a specific category.

### Installation
1. Clone the repository:
   ```bash
   [git clone https://github.com/yourusername/ProManage.git](https://github.com/sanan011/ProductMaster.git)
   ```
2. Open the project in Visual Studio.
3. Build the solution to restore dependencies.

### Usage
1. Run the application using Visual Studio or from the command line.
2. Follow the menu options to manage your products:
   - **1**: Show all products
   - **2**: Show products by category
   - **3**: Show total company price
   - **4**: Show total price for category
   - **5**: Add product
   - **6**: Sell product
   - **0**: Exit

### Example
```plaintext
1. Show all products
2. Show products by category
3. Show total company price
4. Show total price for category
5. Add product
6. Sell product
0. Exit
Enter your choice: 5

Enter category (notebooks/phones): notebooks
Enter brand: Dell
Enter model: XPS 13
Enter price: 1200.50
Enter quantity: 5
Product added successfully!
```

### Project Structure
- **Program.cs**: Entry point of the application, handling user interaction and calling appropriate methods.
- **Product.cs**: Contains the `Product` class, encapsulating all product-related operations such as adding, updating, removing, and displaying products.

### Contributing
If you wish to contribute to this project, please fork the repository and submit a pull request with your changes. Contributions are welcome!

### License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more information.

---
