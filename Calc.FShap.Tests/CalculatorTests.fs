module ``Calculator Tests``

open Xunit
open Calc

[<Fact>]
let ``When two positive numbers 1 and 2 added then 3 must be returned``() =

    let actual = Calculator.Add(1, 2)

    Assert.Equal(3, actual)

[<Fact>]
let ``When two negative numbers -1 and - 2 added then -3 must be returned``() =

    let actual = Calculator.Add(-1, -2)

    Assert.Equal(-3, actual)

[<Fact>]
let ``When 1 and -2 is added then -1 must be returned``() =

    let actual = Calculator.Add(1, -2)

    Assert.Equal(-1, actual)

[<Theory>]
[<InlineData(1, 2, 3)>]
[<InlineData(-1, -2, -3)>]
[<InlineData(1, -2, -1)>]
[<InlineData(100, 200, 300)>]
let ``When two number x and y added then an expected number must be retuned``(x, y, expected) =

    let actual = Calculator.Add(x, y)

    Assert.Equal(expected, actual)
