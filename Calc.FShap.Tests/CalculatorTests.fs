﻿module ``Calculator Tests``

open Xunit
open Calc

let add x y =
    let calculator = new Calculator()
    calculator.Add(x, y)
    calculator.Result

let equal (expected:int) (actual:int) =
    Assert.Equal(expected, actual)

[<Fact>]
let ``When two positive numbers 1 and 2 added then 3 must be returned``() =

    add 1 2 |> equal 3

[<Fact>]
let ``When two negative numbers -1 and - 2 added then -3 must be returned``() =

    add -1 -2 |> equal -3

[<Fact>]
let ``When 1 and -2 is added then -1 must be returned``() =

    add 1 -2 |> equal -1

[<Theory>]
[<InlineData(1, 2, 3)>]
[<InlineData(-1, -2, -3)>]
[<InlineData(1, -2, -1)>]
[<InlineData(100, 200, 300)>]
let ``When two number x and y added then an expected number must be retuned``(x, y, expectedValue) =

    add x y |> equal expectedValue
