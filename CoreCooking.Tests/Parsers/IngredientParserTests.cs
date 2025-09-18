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
FAILED TEST: <|channel|>analysis<|message|>We need to output short concise analysis: build failed due to pdb locked, likely previous test process still running, need to clean, kill process, ensure no parallel builds, maybe add UseSharedCompilation false. Provide recommended fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build cannot copy `CoreCooking.Tests.pdb` from `obj` to `bin` because the file is locked by another process. This lock triggers repeated MSB3026 warnings and ultimately MSB3027/MSB3021 errors, preventing the test assembly from being built and the tests from running.

**Recommended Fixes**  
1. Terminate any lingering process that may be holding the PDB (e.g., a previous `dotnet test` run, debugger, or IDE test runner). Restart the IDE or container if needed.  
2. Run a clean rebuild: `dotnet clean && dotnet build` (or manually delete the `bin` and `obj` folders of the test project).  
3. Ensure builds/tests run sequentially (disable parallel project builds in CI or set `/p:UseSharedCompilation=false`) to avoid concurrent access to the same PDB file.

        [TestMethod]
        public void ParseLine_UomSynonym_Teaspoon_NormalizedToTsp()
        {
            // Arrange
            var parser = new IngredientParser();

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to produce short concise analysis: build failed due to pdb locked, likely previous test runner still running, need to clean, kill process, ensure no parallel builds, maybe add UseSharedCompilation false. Provide recommended fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The test run never started because the build could not copy `CoreCooking.Tests.pdb` from `obj` to `bin`. The PDB file is locked by another process, causing repeated MSB3026 warnings and ultimately MSB3027/MSB3021 errors.

**Recommended Fixes**  
1. Stop any process that may be holding the PDB (e.g., a previous `dotnet test` run, debugger, or IDE test runner). Restart the IDE or container if needed.  
2. Run a clean rebuild: `dotnet clean && dotnet build` (or manually delete the `bin` and `obj` folders of the test project).  
3. Ensure builds/tests run sequentially (disable parallel project builds in CI or set `/p:UseSharedCompilation=false`) to avoid concurrent access to the same PDB file.

        [TestMethod]
        public void ParseLine_LeadingOf_FillerWord_Removed()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            var item = parser.ParseLine("of Salt");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.IsNull(item.Quantity);
            Assert.IsNull(item.Uom);
            Assert.AreEqual("Salt", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to output short concise analysis: build failed due to pdb locked, likely previous test runner still running, need to clean, kill process, ensure no parallel builds, maybe add UseSharedCompilation false. Provide recommended fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build cannot copy `CoreCooking.Tests.pdb` from `obj` to `bin` because the file is locked by another process. This lock triggers repeated MSB3026 warnings and ultimately MSB3027/MSB3021 errors, preventing the test assembly from being built and the tests from running.

**Recommended Fixes**  
1. Stop any process that may be holding the PDB (e.g., a previous `dotnet test` run, debugger, or IDE test runner). Restart the IDE or container if needed.  
2. Run a clean rebuild: `dotnet clean && dotnet build` (or manually delete the `bin` and `obj` folders of the test project).  
3. Ensure builds/tests run sequentially (disable parallel project builds in CI or set `/p:UseSharedCompilation=false`) to avoid concurrent access to the same PDB file.

        [TestMethod]
        public void ParseLine_MultipleHyphens_OnlyFirstHyphenSplits()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            var item = parser.ParseLine("1 cup coffee - strong - extra hot");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(1M, item.Quantity);
            Assert.AreEqual("cup", item.Uom);
            Assert.AreEqual("coffee", item.Name);
            Assert.AreEqual("strong - extra hot", item.Directions);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to produce short concise analysis: build failed due to pdb locked, likely previous test runner still running, need to clean, kill process, ensure no parallel builds, maybe add /p:UseSharedCompilation=false. Provide recommended fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build cannot copy `CoreCooking.Tests.pdb` from `obj` to `bin` because the file is locked by another process. This lock triggers repeated MSB3026 warnings and ultimately MSB3027/MSB3021 errors, preventing the test assembly from being built and the tests from running.

**Recommended Fixes**  
1. Stop any process that may be holding the PDB (e.g., a previous `dotnet test` run, debugger, or IDE test runner). Restart the IDE or container if needed.  
2. Run a clean rebuild: `dotnet clean && dotnet build` (or manually delete the `bin` and `obj` folders of the test project).  
3. Ensure builds/tests run sequentially (disable parallel project builds in CI or set `/p:UseSharedCompilation=false`) to avoid concurrent access to the same PDB file.

        [TestMethod]
        public void ParseLine_DecimalQuantity_WithPeriod_ParsesCorrectly()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            var item = parser.ParseLine("2.75 cup Milk");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(2.75M, item.Quantity);
            Assert.AreEqual("cup", item.Uom);
            Assert.AreEqual("Milk", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to output short concise analysis: build failed due to pdb locked, likely previous test runner still running, need to clean, kill process, ensure no parallel builds. Provide recommended fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The test run never started because the build failed. The compiler could not copy `CoreCooking.Tests.pdb` from `obj` to `bin`; the file is locked by another process, causing repeated MSB3026 warnings and ultimately MSB3027/MSB3021 errors.

**Recommended Fixes**  
1. Stop any process that may be holding the PDB (e.g., a previous `dotnet test` run, debugger, or IDE test runner). Restart the IDE or container if needed.  
2. Run a clean rebuild: `dotnet clean && dotnet build` (or delete the `bin` and `obj` folders manually).  
3. Ensure builds/tests run sequentially (disable parallel project builds in CI or set `/p:UseSharedCompilation=false`).  

These steps will release the lock, allow the project to compile, and let the tests execute.

        [TestMethod]
        public void ParseLine_MixedFraction_ParsesCorrectly()
        {
            // Arrange
            var parser = new IngredientParser();

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to output short concise analysis: build failed due to file lock on pdb, likely previous test runner still running, need to clean, kill process, ensure no parallel builds, maybe add /p:UseSharedCompilation=false. Provide recommended fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build cannot copy `CoreCooking.Tests.pdb` from `obj` to `bin` because the file is locked by another process. This lock triggers repeated MSB3026 warnings and ultimately MSB3027/MSB3021 errors, preventing the test assembly from being built and the tests from running.

**Recommended Fixes**  
1. **Terminate any process that may be holding the PDB** (e.g., a previous `dotnet test` run, debugger, or IDE test runner). Restart the IDE or container if needed.  
2. **Clean the solution and rebuild**:  
   ```bash
   dotnet clean
   dotnet build
   ```  
   or manually delete the `bin` and `obj` folders of `CoreCooking.Tests` before rebuilding.  
3. **Ensure sequential builds** in CI/local scripts (disable parallel project builds) to avoid concurrent access to the same PDB file.  

Applying these steps will release the lock, allow the project to compile, and let the tests execute.

        [TestMethod]
        public void ParseLine_InvalidFraction_IgnoresQuantityButParsesUom()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            var item = parser.ParseLine("2/0 tsp Sugar");
        
            // Assert
            Assert.IsNotNull(item);
            // Quantity parsing fails and is swallowed.
            Assert.IsNull(item.Quantity);
            // UOM should still be recognized.
            Assert.AreEqual("tsp", item.Uom);
            // Remaining name after the UOM.
            Assert.AreEqual("Sugar", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to produce short concise analysis: failure due to file lock on pdb during build, likely previous test process still running, need to clean, kill process, ensure no parallel builds, maybe add /p:UseSharedCompilation=false. Provide recommended fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The build cannot copy `CoreCooking.Tests.pdb` from `obj` to `bin` because the file is locked by another process. This causes repeated MSB3026 warnings and ultimately MSB3027/MSB3021 errors, preventing the test assembly from being built and the tests from running.

**Recommended Fixes**  
1. **Terminate any process that may be holding the PDB** (e.g., a previous `dotnet test` run, debugger, or IDE test runner). Restart the IDE or container if needed.  
2. **Clean the solution and rebuild**:  
   ```bash
   dotnet clean
   dotnet build
   ```  
   or manually delete the `bin` and `obj` folders of `CoreCooking.Tests` before rebuilding.  
3. **Ensure sequential builds** in CI/local scripts (disable parallel project builds) to avoid concurrent access to the same PDB file.  

Applying these steps will release the lock, allow the project to compile, and let the tests execute.

        [TestMethod]
        public void ParseLine_UnknownUom_LeavesUomNullAndKeepsName()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            var item = parser.ParseLine("3 foo Bar");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(3M, item.Quantity);
            Assert.IsNull(item.Uom);
            // The parser retains the leading space when no UOM is matched.
            Assert.AreEqual(" foo Bar", item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to output short concise analysis: failure due to file lock on pdb during build, likely previous test runner still running, need to clean, kill process, ensure no parallel builds. Provide recommended fixes.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The test run never reached the test code because the build failed. The compiler could not copy `CoreCooking.Tests.pdb` from `obj` to `bin` – the file is locked by another process, causing repeated MSB3026 warnings and finally MSB3027/MSB3021 errors.

**Recommended Fixes**  
1. **Terminate any process that may be holding the PDB** (e.g., a previous `dotnet test` run, debugger, IDE test runner, or lingering `dotnet` process). Restart the development environment or container if needed.  
2. **Clean the solution and rebuild**:  
   ```bash
   dotnet clean
   dotnet build
   ```  
   or manually delete the `bin` and `obj` folders of `CoreCooking.Tests` before rebuilding.  
3. **Ensure sequential builds** in CI/local scripts (disable parallel project builds) to prevent concurrent access to the same PDB file.  

Applying these steps will release the lock, allow the project to compile, and let the tests execute.

        [TestMethod]
        public void ParseLine_OnlyQuantity_NoUomOrName()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            var item = parser.ParseLine("2");
        
            // Assert
            Assert.IsNotNull(item);
            Assert.AreEqual(2M, item.Quantity);
            Assert.IsNull(item.Uom);
            Assert.AreEqual(string.Empty, item.Name);
            Assert.IsNull(item.Directions);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to summarize: failure due to file lock on pdb during build, likely previous test runner still running, or parallel builds. Recommend clean, kill processes, ensure no debugger attached, maybe add <GeneratePackageOnBuild>false> or disable parallel. Also note test file syntax errors but not causing build error. Provide concise.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The test run failed during the build step because the compiler could not copy `CoreCooking.Tests.pdb` to the output folder. The PDB file is locked by another process, causing repeated MSB3026 warnings and ultimately an MSB3027 error.

**Recommended Fixes:**  
1. **Terminate any processes that may be holding the PDB** (e.g., a previous `dotnet test` run, debugger, or IDE test runner). Restart the development environment or container if needed.  
2. **Clean the solution and rebuild** to remove stale files:  
   ```bash
   dotnet clean
   dotnet build
   ```  
3. **Delete the `bin` and `obj` folders** of the test project manually before rebuilding to ensure no locked files remain.  
4. **If using CI**, configure the pipeline to run builds/tests sequentially (disable parallel project builds) or add a short delay/cleanup step before the next build.  

Applying these steps will release the lock on `CoreCooking.Tests.pdb`, allowing the project to compile and the tests to execute.

        [TestMethod]
        public void ParseNullString_ReturnsEmptyList()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            var result = parser.Parse(null);
        
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

*/
/*
FAILED TEST: <|channel|>analysis<|message|>We need to produce short concise analysis: The failure is due to file lock on pdb during build, not test code. Recommend cleaning, ensuring no process holds file, maybe kill dotnet test runner, use dotnet clean, rebuild, or adjust CI to not run parallel builds. Also fix test file syntax errors? But the immediate failure is build error. Provide concise answer.<|end|><|start|>assistant<|channel|>final<|message|>**Analysis:**  
The test run failed during the build step because the compiler could not copy `CoreCooking.Tests.pdb` to the output folder. The file is locked by another process, causing repeated MSB3026 warnings and ultimately an MSB3027 error.

**Recommended Fixes:**  
1. **Clean and rebuild** the solution to release the lock:  
   ```bash
   dotnet clean
   dotnet build
   ```
2. **Terminate any lingering processes** that might be holding the PDB (e.g., previous `dotnet test`, debugger, or IDE instances). Restart the development environment or container if needed.  
3. **Ensure single‑threaded builds** in CI pipelines (disable parallel project builds) to avoid concurrent access to the same PDB file.  
4. If the lock persists, **delete the `bin` and `obj` folders** manually before rebuilding.  

Applying these steps will allow the project to compile and the tests to run.

        [TestMethod]
        public void ParseEmptyString_ReturnsEmptyList()
        {
            // Arrange
            var parser = new IngredientParser();
        
            // Act
            var result = parser.Parse(string.Empty);
        
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
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
