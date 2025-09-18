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
FAILED TEST: <|channel|>analysis<|message|>We need to output short concise analysis and fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build aborts while copying `CoreCooking.Tests.pdb` because the file is locked by another process (e.g., a previous test runner, debugger, or lingering `dotnet`/`vstest` instance). The repeated MSB3026 warnings and final MSB3027/MSB3021 errors prevent the test assembly from being built, so no tests are executed.

**Fixes**  
1. Terminate any running test/debug processes that might hold the PDB (close Visual Studio, stop `dotnet test`/`vstest` processes, or kill stray `dotnet` instances).  
2. Run a clean rebuild: `dotnet clean && dotnet build` (or use the IDE’s Clean → Rebuild).  
3. If the lock persists, restart the development environment/container to release the file handle.  
4. (Optional) Disable any background file‑watcher/test‑explorer that automatically rebuilds while a previous build is still in progress.

        [TestMethod]
        public void ParseLine_UnknownUom_TreatedAsName()
        {
            // Arrange
            var parser = new IngredientParser();

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to output short concise analysis: test run failed because pdb locked, need to kill process, clean, rebuild. Provide fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build aborts while copying `CoreCooking.Tests.pdb` because the file is locked by another process (e.g., a previous test runner, debugger, or lingering `dotnet`/`vstest` instance). The repeated MSB3026 warnings and final MSB3027/MSB3021 errors prevent the test assembly from being built, so no tests are executed.

**Fixes**  
1. Stop any running test/debug processes that might hold the PDB (close Visual Studio, end lingering `dotnet test`, `vstest.console`, or other `dotnet` processes).  
2. Run a clean rebuild: `dotnet clean && dotnet build` (or use the IDE’s Clean → Rebuild).  
3. If the lock persists, restart the development environment/container to release the file handle.  
4. (Optional) Ensure no background file‑watcher/test‑explorer is automatically rebuilding while a previous build is still in progress.

        [TestMethod]
        public void ParseLine_EmptyString_ReturnsEmptyIngredient()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            Ingredient item = parser.ParseLine(string.Empty);
        
            // Assert
            Assert.IsNotNull(item);
            Assert.IsNull(item.Quantity);
            Assert.IsNull(item.Uom);
            Assert.AreEqual(string.Empty, item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to output short concise analysis: pdb locked, need to kill process, clean, rebuild. Provide fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build fails because `CoreCooking.Tests.pdb` is locked by another process (e.g., a previous test runner, debugger, or lingering `dotnet`/`vstest` instance). The copy from `obj` to `bin` retries 10 times and then aborts, producing MSB3026/MSB3027/MSB3021 errors, so no tests are executed.

**Fixes**  
1. Stop any running test/debug processes that might hold the PDB (close Visual Studio, end `dotnet test`, `vstest.console`, or other `dotnet` processes).  
2. Run a clean rebuild: `dotnet clean && dotnet build` (or use the IDE’s Clean/Rebuild).  
3. If the lock persists, restart the development environment/container to release the file handle.  
4. (Optional) Ensure no background test‑watcher or continuous‑build tool is automatically rebuilding while a previous build is still in progress.

        [TestMethod]
        public void ParseLine_MultipleHyphens_UsesFirstHyphenOnly()
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
FAILED TEST: <|channel|>analysis<|message|>We need to give short concise analysis: pdb locked, need to kill process, clean, rebuild. Also mention maybe test runner still attached. Provide fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build fails because `CoreCooking.Tests.pdb` is locked by another process (e.g., a previous test runner, debugger, or lingering `dotnet`/`vstest` instance). The copy from `obj` to `bin` retries 10 times and then aborts, producing MSB3026/MSB3027/MSB3021 errors, so no tests are executed.

**Recommended Fixes**
1. Stop any running test/debug processes that might hold the PDB (close Visual Studio, end lingering `dotnet test`, `vstest.console`, or other `dotnet` processes).  
2. Run a clean rebuild:  
   ```bash
   dotnet clean
   dotnet build
   ```  
3. If the lock persists, restart the development environment or container to release the file handle.  
4. (Optional) Ensure no background test‑watcher or continuous‑build tool is automatically rebuilding while a previous build is still in progress.

        [TestMethod]
        public void ParseLine_QuantityAndUomNoSpace_ParsesCorrectly()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            Ingredient item = parser.ParseLine("2cups Sugar");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(2M, item.Quantity);
            Assert.AreEqual("cups", item.Uom);   // plural because quantity > 1
            Assert.AreEqual("Sugar", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>Need to produce short concise analysis: file lock on pdb due to another process, cause build failure. Recommend kill process, clean, rebuild, ensure no test runner still attached, maybe restart container. Also note test file syntax errors but not causing this failure. Provide only analysis and fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build stops while copying `CoreCooking.Tests.pdb` because the file is locked by another process (e.g., a previous `dotnet test`/`vstest` run, debugger, or lingering test‑explorer instance). The repeated MSB3026 warnings and final MSB3027/MSB3021 errors prevent the test assembly from being built, so no tests are executed.

**Recommended Fixes:**  
1. Terminate any running test/debug processes that might hold the PDB (close Visual Studio, stop lingering `dotnet test`, `vstest.console`, or other `dotnet` instances).  
2. Run a clean rebuild:  
   ```bash
   dotnet clean
   dotnet build
   ```  
3. If the lock persists, restart the development environment or container to release the file handle.  
4. (Optional) Disable background test watchers or continuous build tools that could trigger a new build while the previous one is still running.  

Applying these steps will allow the project to compile and the tests to run.

        [TestMethod]
        public void ParseLine_OnlyFillWord_ParsesNameOnly()
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
FAILED TEST: <|channel|>analysis<|message|>Need to output short concise analysis: file lock on pdb due to another process, cause build failure. Recommend kill process, clean, rebuild, ensure no test runner still attached, maybe add /p:DebugType=none. Provide only analysis and fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build fails because `CoreCooking.Tests.pdb` is locked by another process (e.g., a previous test runner, debugger, or lingering `dotnet`/`vstest` instance). The copy from `obj` to `bin` retries 10 times and then aborts, producing MSB3026/MSB3027/MSB3021 errors. No test code is executed because the project never finishes building.

**Recommended Fixes:**  
1. Stop any running test/debug processes that might hold the PDB (close Visual Studio, end `dotnet test`, `vstest.console`, or other `dotnet` processes).  
2. Run a clean rebuild:  
   ```bash
   dotnet clean
   dotnet build
   ```  
3. If the lock persists, restart the development environment or container to release the file handle.  
4. Ensure no background file‑watcher/test‑explorer is automatically rebuilding while a previous build is still in progress.  
5. (Optional) Add `/p:DebugType=none` or `/p:DebugSymbols=false` to the build command if you don’t need PDBs during test runs.

        [TestMethod]
        public void ParseLine_UomWithoutQuantity_ParsesCorrectly()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            Ingredient item = parser.ParseLine("cup of Milk");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.IsNull(item.Quantity);
            Assert.AreEqual("cup", item.Uom);   // singular because quantity is null
            Assert.AreEqual("Milk", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to produce short concise analysis: file lock on pdb due to another process, need to kill process, clean, rebuild. Also mention that test file syntax errors may cause compile errors later but current failure is pdb lock. Provide fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build failed because `CoreCooking.Tests.pdb` could not be copied to the output folder. The file is locked by another process (e.g., a previous test runner, debugger, or lingering `dotnet`/`vstest` instance), causing repeated MSB3026 warnings and ultimately MSB3027/MSB3021 errors.

**Recommended Fixes:**  
1. Stop any running test/debug processes that might be holding the PDB (close Visual Studio, stop `dotnet test`/`vstest` processes, or kill stray `dotnet` processes).  
2. Run a clean rebuild:  
   ```bash
   dotnet clean
   dotnet build
   ```  
3. If the lock persists, restart the development environment or container to release the file handle.  
4. Ensure no background test watcher is automatically rebuilding while a previous build is still in progress.

        [TestMethod]
        public void ParseLine_InvalidFractionFormat_QuantityNull_UomSingular()
        {
            // Arrange
            var parser = new IngredientParser();

*/
/*
FAILED TEST: <|channel|>analysis<|message|>Need to produce short concise analysis: file lock on pdb due to previous test process still running, need to kill, clean, rebuild. Also note test file syntax errors but not causing build error. Provide recommended fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build failed because `CoreCooking.Tests.pdb` could not be copied to the output folder. The file is locked by another process (e.g., a previous `dotnet test` run, debugger, or test‑explorer instance), causing repeated MSB3026 warnings and ultimately MSB3027/MSB3021 errors.

**Recommended Fixes:**  
1. Stop any running test/debug processes that might be holding the PDB (close Visual Studio, stop `dotnet test`/`vstest` processes, or kill lingering `dotnet` processes).  
2. Run a clean rebuild:  
   ```bash
   dotnet clean
   dotnet build
   ```  
3. If the lock persists, restart the development environment or container to release the file handle.  
4. Ensure no background file‑watcher/test runner is automatically rebuilding while a previous build is still in progress.

        [TestMethod]
        public void ParseLine_ZeroDenominatorFraction_QuantityNull_UomSingular()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            Ingredient item = parser.ParseLine("2/0 tsp Sugar");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.IsNull(item.Quantity); // parsing failed, quantity should be null
            Assert.AreEqual("tsp", item.Uom); // singular because quantity is null
            Assert.AreEqual("Sugar", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>Need to produce short concise analysis: file lock on pdb, likely previous test process still running, need to kill, clean, rebuild. Also mention maybe test project missing proper namespace braces causing compile errors? But compile succeeded until copy pdb, so focus on lock. Provide recommended fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build failed because `CoreCooking.Tests.pdb` could not be copied from the intermediate folder to the output folder. The file is locked by another process (e.g., a previous `dotnet test` run, debugger, or test‑explorer instance), causing repeated MSB3026 warnings and ultimately MSB3027/MSB3021 errors.

**Recommended Fixes:**  
1. Stop any running test/debug processes that might be holding the PDB (close Visual Studio, stop `dotnet test`/`vstest` processes, or kill lingering `dotnet` processes).  
2. Run a clean rebuild:  
   ```bash
   dotnet clean
   dotnet build
   ```  
3. If the lock persists, restart the development environment or container to release the file handle.  
4. Ensure no background file‑watcher/test runner is automatically rebuilding while a previous build is still in progress.

        [TestMethod]
        public void ParseLine_MixedFraction_ParsesCorrectly()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            Ingredient item = parser.ParseLine("1 1/2 cup Flour");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(1.5M, item.Quantity);
            Assert.AreEqual("cups", item.Uom);
            Assert.AreEqual("Flour", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to output short concise analysis: build failed due to pdb locked, likely previous test process still running. Recommend kill process, clean, rebuild, ensure no debugger attached, maybe add /p:DebugType=none. Also note that test file syntax is broken but not causing this error. Provide only analysis and fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build failed because `CoreCooking.Tests.pdb` could not be copied from the intermediate folder to the output folder. The file is locked by another process (e.g., a previous `dotnet test` run, debugger, or test‑explorer instance), causing repeated MSB3026 warnings and ultimately MSB3027/MSB3021 errors.

**Recommended Fixes:**  
1. Stop any running test processes or debuggers that might be holding the PDB (kill lingering `dotnet`/`vstest` processes or close Visual Studio).  
2. Run a clean rebuild:  
   ```bash
   dotnet clean
   dotnet build
   ```  
3. If the lock persists, restart the development environment or container to release the file handle.  
4. (Optional) Ensure no background test watcher is automatically rebuilding while a previous build is still in progress.

        [TestMethod]
        public void ParseLine_DecimalQuantity_UsesPluralUom()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            Ingredient item = parser.ParseLine("1.5 cup Milk");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(1.5M, item.Quantity);
            Assert.AreEqual("cups", item.Uom); // plural because quantity > 1
            Assert.AreEqual("Milk", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to output short concise analysis: failure due to pdb file locked, likely previous test process still running. Recommend: stop lingering dotnet test processes, clean, rebuild, ensure no debugger attached, maybe add /p:DebugType=none. Also note test file syntax errors but not part of build error. Provide concise.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build failed because `CoreCooking.Tests.pdb` could not be copied from the intermediate folder to the output folder. The file is locked by another process (e.g., a previous `dotnet test` run, debugger, or test‑explorer instance), causing MSB3026 warnings and ultimately MSB3027/MSB3021 errors.

**Recommended Fixes:**  
1. **Terminate any lingering test or dotnet processes** that might be holding the PDB (e.g., stop the running test runner, close Visual Studio debugger, or kill stray `dotnet` processes).  
2. **Clean and rebuild** the solution:  
   ```bash
   dotnet clean
   dotnet build
   ```  
3. If the lock persists, **restart the development environment or container** to release the file handle.  
4. (Optional) Ensure no background file‑watcher/test‑explorer is automatically rebuilding while a previous build is still in progress.  

Applying these steps will allow the project to compile and the tests to run.

        [TestMethod]
        public void Parse_EmptyOrNullString_ReturnsEmptyList()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act & Assert for empty string
            List<Ingredient> emptyResult = parser.Parse(string.Empty);
            Assert.IsNotNull(emptyResult);
            Assert.AreEqual(0, emptyResult.Count);
        
            // Act & Assert for null string
            List<Ingredient> nullResult = parser.Parse(null);
            Assert.IsNotNull(nullResult);
            Assert.AreEqual(0, nullResult.Count);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to summarize why test run failed: build error due to pdb file locked, likely because previous test run didn't terminate, or test runner still attached. Provide fix: clean, close processes, ensure no lingering dotnet test processes, maybe add /p:DebugType=none, or use dotnet test --no-build, but main fix is to stop lock, clean, rebuild. Also note test file syntax errors causing compile failures? The test file appears malformed (missing brackets, attributes). However the build didn't get to compile errors; it failed copying pdb. The primary failure is file lock. Provide concise analysis and fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The test run failed during the build step because the compiler could not copy `CoreCooking.Tests.pdb` from the intermediate folder to the output folder. The file is locked by another process (likely a previous test runner, debugger, or lingering `dotnet` process), causing repeated MSB3026 warnings and ultimately an MSB3027/MSB3021 error.

**Recommended Fixes:**  
1. **Terminate any lingering processes** that might be holding the PDB (e.g., previous `dotnet test`, VS debugger, or test explorer).  
2. **Clean the solution** to remove the locked file and then rebuild:  
   ```bash
   dotnet clean
   dotnet build
   ```  
3. If the lock persists, **restart the development environment or container** to release the file handle.  
4. (Optional) Ensure no background test watchers are running that automatically trigger builds while the previous build is still in progress.  

Applying these steps will allow the project to compile and the tests to execute.

        [TestMethod]
        public void Parse_MultiLineString_WithMixedNewlines_ReturnsCorrectIngredients()
        {
            // Arrange
            var parser = new IngredientParser();
            string text = "1 cup Sugar\n2 tbsp Olive Oil\r\n3 cloves Garlic";
        
            // Act
            List<Ingredient> result = parser.Parse(text);
        
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        
            // Item 1
            Assert.AreEqual(1M, result[0].Quantity);
            Assert.AreEqual("cup", result[0].Uom);
            Assert.AreEqual("Sugar", result[0].Name);
            Assert.IsNull(result[0].Directions);
        
            // Item 2
            Assert.AreEqual(2M, result[1].Quantity);
            Assert.AreEqual("tbsp", result[1].Uom);
            Assert.AreEqual("Olive Oil", result[1].Name);
            Assert.IsNull(result[1].Directions);
        
            // Item 3
            Assert.AreEqual(3M, result[2].Quantity);
            Assert.AreEqual("clove", result[2].Uom);
            Assert.AreEqual("Garlic", result[2].Name);
            Assert.IsNull(result[2].Directions);
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
