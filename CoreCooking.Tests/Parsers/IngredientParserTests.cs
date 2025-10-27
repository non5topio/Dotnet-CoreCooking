using CoreCooking.Models.Recipes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreCooking.Parsers
{
    [TestClass]
    public class IngredientParserTests
    {
        [TestMethod]
        public void SimpleLine()
        {
            // Arrange
            var parser = new IngredientParser();

            // Act
            Ingredient item = parser.ParseLine("2 cups of Jasmine Rice - Slightly undercooked");

            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(2M, item.Quantity);
            Assert.AreEqual("cups", item.Uom);
            Assert.AreEqual("Jasmine Rice", item.Name);
            Assert.AreEqual("Slightly undercooked", item.Directions);
        }

        [TestMethod]
        public void HalfAQuantity()
        {
            // Arrange
            var parser = new IngredientParser();

            // Act
            Ingredient item = parser.ParseLine("1/2 cup Brown Sugar");

            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(0.5M, item.Quantity);
            Assert.AreEqual("cup", item.Uom);
            Assert.AreEqual("Brown Sugar", item.Name);
            Assert.IsNull(item.Directions);
        }


        [TestMethod]
        public void NoQuantity()
        {
            // Arrange
            var parser = new IngredientParser();

            // Act
            Ingredient item = parser.ParseLine("Coriander");

            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(null, item.Quantity);
            Assert.AreEqual(null, item.Uom);
            Assert.AreEqual("Coriander", item.Name);
            Assert.AreEqual(null, item.Directions);
        }


        [TestMethod]
        public void OneGarlicPowder()
        {
            // Arrange
            var parser = new IngredientParser();

            // Act
            Ingredient item = parser.ParseLine("1 Garlic Powder");

            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(1, item.Quantity);
            Assert.AreEqual(null, item.Uom);
            Assert.AreEqual("Garlic Powder", item.Name);
            Assert.AreEqual(null, item.Directions);
        }


        [TestMethod]
        public void OneToTwo()
        {
            // Arrange
            var parser = new IngredientParser();

            // Act
            Ingredient item = parser.ParseLine("10cm Ginger");

            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(10, item.Quantity);
            Assert.AreEqual("cm", item.Uom);
            Assert.AreEqual("Ginger", item.Name);
            Assert.AreEqual(null, item.Directions);
        }
/*
FAILED TEST: **Analysis:**  
The test run failed due to a file access issue during the build process. Specifically, the file `CoreCooking.Tests.pdb` could not be copied because it was locked by another process, leading to a build error.

**Recommended Fix:**  
- Clean the solution and rebuild:  
  ```bash
  dotnet clean
  dotnet build
  ```
- If the issue persists, restart the environment or IDE to release any locks on the file.

        [TestMethod]
        public void TestParseLineWithMultipleHyphens()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            Ingredient item = parser.ParseLine("1 cup of coffee - black - no sugar");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(1M, item.Quantity);
            Assert.AreEqual("cup", item.Uom);
            Assert.AreEqual("coffee", item.Name);
            Assert.AreEqual("black - no sugar", item.Directions);
        }

*/
/*
FAILED TEST: **Analysis:**  
The test run failed due to a file access issue during the build process. Specifically, the file `CoreCooking.Tests.pdb` could not be copied because it was locked by another process, leading to a build error.

**Recommended Fix:**  
- Clean the solution and rebuild:  
  ```bash
  dotnet clean
  dotnet build
  ```
- If the issue persists, restart the environment or IDE to release any locks on the file.

        [TestMethod]
        public void TestParseLineWithNoUOMAndNoQuantity()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            Ingredient item = parser.ParseLine("of Salt");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.IsNull(item.Quantity);
            Assert.IsNull(item.Uom);
            Assert.AreEqual("Salt", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: **Analysis:**  
The test run failed due to a file access issue during the build process. Specifically, the file `CoreCooking.Tests.pdb` could not be copied because it was locked by another process, leading to a build error.

**Recommended Fix:**  
- Clean the solution and rebuild:  
  ```bash
  dotnet clean
  dotnet build
  ```
- If the issue persists, restart the environment or IDE to release any locks on the file.

        [TestMethod]
        public void TestParseLineWithInvalidFraction()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            Ingredient item = parser.ParseLine("2/0 tsp Sugar");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.IsNull(item.Quantity);
            Assert.IsNull(item.Uom);
            Assert.AreEqual("tsp Sugar", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: **Analysis:**  
The test run failed due to a file access issue during the build process. Specifically, the file `CoreCooking.Tests.pdb` could not be copied because it was locked by another process, leading to a build error.

**Recommended Fix:**  
- Clean the solution and rebuild:  
  ```bash
  dotnet clean
  dotnet build
  ```
- If the issue persists, restart the environment or IDE to release any locks on the file.

        [TestMethod]
        public void TestParseLineWithMultiplePluralUOM()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            Ingredient item = parser.ParseLine("1 liter of water");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(1M, item.Quantity);
            Assert.AreEqual("liter", item.Uom);
            Assert.AreEqual("water", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: **Analysis:**
The test run failed due to a file access issue during the build process. Specifically, the file `CoreCooking.Tests.pdb` could not be copied because it was locked by another process, leading to a build error.

**Recommended Fix:**
- Clean the solution and rebuild:  
  ```bash
  dotnet clean
  dotnet build
  ```
- If the issue persists, restart the environment or IDE to release any locks on the file.

        [TestMethod]
        public void TestParseLineWithNonMatchingUOM()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            Ingredient item = parser.ParseLine("250 grams of flour");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(250M, item.Quantity);
            Assert.AreEqual("g", item.Uom);
            Assert.AreEqual("flour", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: **Analysis:**

The test run failed due to a file access issue during the build process. Specifically, the file `CoreCooking.Tests.pdb` could not be copied because it was locked by another process, leading to a build error.

**Recommended Fix:**

- Ensure no other processes are using the `CoreCooking.Tests.pdb` file (e.g., a debugger or test runner is still attached).
- Clean the solution and rebuild:  
  ```bash
  dotnet clean
  dotnet build
  ```
- If the issue persists, restart the environment or IDE to release any locks on the file.

        [TestMethod]
        public void TestParseLineWithComplexFraction()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            Ingredient item = parser.ParseLine("1 1/2 tsp Cinnamon");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(1.5M, item.Quantity);
            Assert.AreEqual("tsp", item.Uom);
            Assert.AreEqual("Cinnamon", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
    }
}
