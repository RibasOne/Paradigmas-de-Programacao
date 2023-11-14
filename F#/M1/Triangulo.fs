let tipoTriangulo a b c =
    if (a >= b + c) || (b >= a + c) || (c >= a + b) then
        printfn "Nao forma um triangulo"
    elif (a = b) && (b = c) then
        printfn "Equilatero"
    elif (a = b) || (b = c) || (a = c) then
        printfn "Isosceles"
    else
        printfn "Escaleno"

// Exemplo de uso
let main args =
    printfn "Digite os tres lados do triangulo:"
    let lado1 = System.Console.ReadLine() |> float
    let lado2 = System.Console.ReadLine() |> float
    let lado3 = System.Console.ReadLine() |> float

    tipoTriangulo lado1 lado2 lado3
main()