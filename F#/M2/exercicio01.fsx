// 1 - Faça uma função que recebe uma lista e retorne o produto dos valores ímpares.
let rec produtoValoresImpares lista =
    match lista with
    | [] -> 1 // lista vazia, retorna 1 como identidade da multiplicação
    | head :: tail when head % 2 <> 0 -> // Multiplica x se for ímpar
        head * produtoValoresImpares tail 
    | _ :: tail -> produtoValoresImpares tail // Para valores pares, ignora o numero e continua a recursao
    
printfn "Resultado do produto dos impares: %i" (produtoValoresImpares [])
printfn "Resultado do produto dos impares: %i" (produtoValoresImpares [1;2;3;4;5])
printfn "Resultado do produto dos impares: %i" (produtoValoresImpares [1;2;3;4;5;6;7;8;9;10;11;12;13;14;15])