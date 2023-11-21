// 3 - Faça uma função que recebe um número e retorna se ele é primo ou não.

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

printfn "Os valores abaixo sao primos?"
printfn "7 -> %b" (isPrime 2)
printfn "6 -> %b" (isPrime 5)
printfn "5 -> %b" (isPrime 8)