let divisaoMaiorMenor a b =
    if a > b then
        float a / float b
    else
        float b / float a

let main argv =
    printfn "digite dois numeros para a divisao:"
    let numero1 = System.Console.ReadLine() |> float
    let numero2 = System.Console.ReadLine() |> float

    let resultado = divisaoMaiorMenor numero1 numero2

    printfn "Resultado da divisao: %.2f" resultado
main()