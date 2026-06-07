# 🚀 CI Pipeline Workshop

Learn how to set up a CI pipeline with automated build, testing, and code coverage using GitHub Actions.

## 📋 What's Inside

| Component | Description |
|-----------|-------------|
| `src/Calculator/` | A simple C# math library |
| `tests/Calculator.Tests/` | xUnit tests with code coverage |
| `.github/workflows/ci.yml` | GitHub Actions CI pipeline |

## 🎯 Workshop Exercise

### Step 1: Fork & Clone
```bash
git clone https://github.com/<your-username>/ci-pipeline-workshop.git
cd ci-pipeline-workshop
```

### Step 2: Create Your Branch
```bash
git checkout -b feature/my-changes
```

### Step 3: Make a Code Change
Open `src/Calculator/MathService.cs` and add a new method:
```csharp
public int Power(int baseNum, int exponent)
{
    return (int)Math.Pow(baseNum, exponent);
}
```

### Step 4: Add a Unit Test
Open `tests/Calculator.Tests/MathServiceTests.cs` and add:
```csharp
[Fact]
public void Power_TwoToThree_ReturnsEight()
{
    var result = _sut.Power(2, 3);
    Assert.Equal(8, result);
}
```

### Step 5: Push & Watch the Pipeline
```bash
git add .
git commit -m "feat: add Power method with test"
git push origin feature/my-changes
```

Now go to the **Actions** tab in GitHub and watch your pipeline run! ✅

## 🔍 What the Pipeline Does

```
📥 Checkout → 🏗️ Setup .NET → 📦 Restore → 🔨 Build → 🧪 Test → 📊 Coverage Report
```

## 🏆 Bonus Challenges
- [ ] Add a method that deliberately fails a test — see how the pipeline reports it
- [ ] Change the coverage threshold and see what happens
- [ ] Add a new workflow that only runs on pull requests