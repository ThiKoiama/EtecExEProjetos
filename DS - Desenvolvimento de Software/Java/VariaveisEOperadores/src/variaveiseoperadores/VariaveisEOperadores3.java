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
public class VariaveisEOperadores3 {
    public static void main(String[] args) {
        double legua1, legua2, legua3;
        Scanner leitor = new Scanner(System.in);
        System.out.println("Digite a medida em léguas: ");
        double leguas = leitor.nextDouble();
        legua1 = 6172.4;
        legua2 = 5555.56;
        legua3 = 4444.44;
        System.out.println("Para a légua de 18000 ao grau o valor em metros é " + leguas*legua1);
        System.out.println("Para a légua de 20000 ao grau o valor em metros é " + leguas*legua2);
        System.out.println("Para a légua de 25000 ao grau o valor em metros é " + leguas*legua3);
        
    }
   
}
