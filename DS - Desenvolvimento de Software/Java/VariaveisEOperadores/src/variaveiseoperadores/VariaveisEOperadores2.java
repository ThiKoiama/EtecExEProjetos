package variaveiseoperadores;


import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Aluno
 */
public class VariaveisEOperadores2 {
    public static void main(String[] args) {
        double altura, base, comprimento, volume;
         Scanner leitor = new Scanner(System.in);
         System.out.println("Digite a altura da embalagem: ");
         altura = leitor.nextDouble();
         System.out.println("Digite a base da embalagem: ");
         base = leitor.nextDouble();
         System.out.println("Digite o comprimento da embalagem: ");
         comprimento = leitor.nextDouble();
         volume = altura*base*comprimento;
         System.out.println("O volume da embalagem é "+volume );
         
    }
}
