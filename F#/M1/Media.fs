let calcularMedia notas =
    List.average notas

let verificarAprovacao media =
    media >= 6.0

let mensagemAprovacao aprovado =
    if aprovado then
        "Aprovado"
    else
        "Reprovado"

let main args =
   
    printfn "Digite tres notas:"
    let notas = [1..3] |> List.map (fun _ -> System.Console.ReadLine() |> float)

    let media = notas |> calcularMedia
    let aprovado = media |> verificarAprovacao
    let mensagem = aprovado |> mensagemAprovacao

    printfn "Media: %.2f" media
    printfn "Situacao: %s" mensagem


main()
