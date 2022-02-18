/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package variaveiseoperadores;

import java.util.Scanner;

/**
 *
 * @author Aluno
 */
public class VariaveisEOperadores1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int dias, VIDA, restante;
        Scanner leitor = new Scanner(System.in);
        System.out.println("Digite o tempo de utilização em dias: ");
        dias = leitor.nextInt();
        VIDA = 5 *365;
        restante = VIDA - dias;
        System.out.println("A vida útil restante do aparelho é " + restante);
    }
    
}
