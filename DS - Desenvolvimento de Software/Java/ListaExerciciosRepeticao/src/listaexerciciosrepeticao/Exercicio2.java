/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package listaexerciciosrepeticao;

import java.util.Scanner;

/**
 *
 * @author Aluno
 */
public class Exercicio2 {
    public static void main(String[] args) {
         Scanner leitor = new Scanner(System.in);
        int i=0;
        int quantidadePeças, valor = 0, cod;
        double valorfinal = 0;
        System.out.println("Digite quantas peças você vai comprar: ");
        quantidadePeças = leitor.nextInt();
        for (i=0; i < quantidadePeças; i++){
            System.out.println("Digite o preco das peças: " + (i + 1));
            valor += leitor.nextInt();
        }
        System.out.println("Digite o código da forma de pagamento ");
        cod = leitor.nextInt();
        switch (cod){
            case 1:
                valorfinal=valor*0.85;
                break;
            case 2:
                valorfinal=valor*0.90;
                break;
            case 3:
                valorfinal=valor*0.95;
                break;
            case 4:
                valorfinal=valor;
                break;
            case 5:
                valorfinal=valor*1.05;
                break;
        }
        System.out.println("Preço total é de: "+valorfinal);
    }
    
}
    
