let processarVetor () =
    [0..20]
    |> List.filter (fun x -> x % 2 = 0)  // Filtro para deixar somente os numeros pares
    |> List.map (fun x -> x * 2)          // Multiplica cada valor por 2
    |> List.filter (fun x -> x % 6 = 0)  // Filtro para deixar somente os multiplos de 6

// Exemplo de uso
let main args =
    let resultado = processarVetor ()
    printfn "Resultado: %A" resultado
main()