// 2 - Faça uma função que receba 2 valores, caso sejam iguais, multiplique os dois, caso sejam diferentes, faça o primeiro valor elevado ao segundo. 
// Não pode utilizar o operador de potência (deve ser feita uma sequência de multiplicações, 23 = 2 * 2 * 2).
let rec calcular num1 num2 =
    match num1, num2 with
    | num1, num2 when num1 = num2 -> num1 * num2 // Se iguais, os valores se multiplicam
    | num1, num2 -> // Se forem diferentes, faz a potencia
        let rec potencia x y = 
            match x with
            | 0 -> y 
            | _ -> potencia (x - 1) (y * num1)
        potencia num2 1

printfn "Resultado: %i" (calcular 2 2)
printfn "Resultado: %i" (calcular 2 10)
printfn "Resultado: %i" (calcular 3 3)