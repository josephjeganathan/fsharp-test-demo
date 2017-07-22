module StockStepDefinitions

open TickSpec
open NUnit.Framework
open Calc

type CalcFeature () = inherit FeatureFixture("Calc.feature")

let mutable calc = Calculator()

let [<Given>] ``a calculator`` () = 
    calc <- Calculator()

let [<When>] ``(.*) and (.*) is added``(x, y) = 
    calc.Add(x, y)

let [<Then>] ``result must be (.*)`` (expectedResult) =
    Assert.AreEqual(expectedResult, calc.Result)