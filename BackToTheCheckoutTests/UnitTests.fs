namespace Tests

open NUnit.Framework
open BackToTheCheckout.BackToTheCheckout

[<TestClass>]
type TestClass () =

    [<SetUp>]
    member this.Setup () =
        ()

    [<Test>]
    member this.EmptyCartReturns0() =
        Assert.AreEqual(myFunction [] {CountOfA=0; CountOfB=0; CountOfC=0; CountOfD=0}, {CountOfA=0; CountOfB=0; CountOfC=0; CountOfD=0})

    [<Test>]
    member this.ItemAReturnsCorrectValue() =
        Assert.AreEqual(myFunction ["A"] {CountOfA=0; CountOfB=0; CountOfC=0; CountOfD=0}, {CountOfA=1; CountOfB=0; CountOfC=0; CountOfD=0})

    [<Test>]
    member this.ItemBReturnsCorrectValue() =
        Assert.AreEqual(myFunction ["B"] {CountOfA=0; CountOfB=0; CountOfC=0; CountOfD=0}, {CountOfA=0; CountOfB=1; CountOfC=0; CountOfD=0})

    [<Test>]
    member this.ItemCReturnsCorrectValue() =
        Assert.AreEqual(myFunction ["C"] {CountOfA=0; CountOfB=0; CountOfC=0; CountOfD=0}, {CountOfA=0; CountOfB=0; CountOfC=1; CountOfD=0})

    [<Test>]
    member this.ItemDReturnsCorrectValue() =
        Assert.AreEqual(myFunction ["D"] {CountOfA=0; CountOfB=0; CountOfC=0; CountOfD=0}, {CountOfA=0; CountOfB=0; CountOfC=0; CountOfD=1})

    [<Test>]
    member this.ItemDReturnsCorrectValue2() =
        Assert.AreEqual(Total ["A"], 50)
        Assert.AreEqual(Total ["B"], 30)
        Assert.AreEqual(Total ["A"; "B"], 80)
        Assert.AreEqual(Total ["A"; "B"; "C"; "D"], 115)
        Assert.AreEqual(Total ["A"; "B"; "C"; "D"; "A"; "B"; "C"; "A"; "A"; "A"; "A"; "B"; "B"; "B"], 435)

