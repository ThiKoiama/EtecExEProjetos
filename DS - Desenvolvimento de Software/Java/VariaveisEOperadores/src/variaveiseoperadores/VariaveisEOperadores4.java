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
public class VariaveisEOperadores4 {
    public static void main(String[] args) {
        int semanascorr, restante;
        Scanner leitor = new Scanner(System.in);
        System.out.println("Digite o múmero de semanas corridas: ");
        semanascorr=leitor.nextInt();
        restante= 20-semanascorr;
        System.out.println("Restam "+restante+" semanas");
        
    }
}
