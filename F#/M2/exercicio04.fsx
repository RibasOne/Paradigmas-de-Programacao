// 4 - Faça uma função que recebe uma lista e retorna a soma dos valores primos (utilizar a função da questão 3).

let rec isPrime num =
    match num with
    | 1 -> false // 1 não é primo
    | 2 -> true // 2 é primo
    | num when num % 2 = 0 -> false // Números pares maiores que 2 não são primos
    | num ->
        let limite = int(sqrt(double num)) + 1
        let rec verificaDivisores i =
            match i with
            | i when i > limite -> true // Não encontrou divisores até o limite, é primo
            | i when num % i = 0 -> false // Encontrou um divisor e não é primo
            | _ -> verificaDivisores (i + 2) // Verifica o próximo possível divisor ímpar
        verificaDivisores 3
        
let rec produtoNumPrimos lista = 
    match lista with
    | [] -> 1 // Lista vazia
    | head :: tail when (isPrime head) = true -> // Eh numero primo
        head * produtoNumPrimos tail
    | _ :: tail -> produtoNumPrimos tail // Nao eh numero primo

printfn "Resultado do produto dos numeros primos [0-11]: %i" (produtoNumPrimos [0;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15])
printfn "Resultado do produto dos numeros primos [0-5]: %i" (produtoNumPrimos [0;1;2;3;4;5])
printfn "Resultado do produto dos numeros primos [0-100]: %i" (produtoNumPrimos [0..100])