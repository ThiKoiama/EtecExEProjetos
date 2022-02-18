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
public class ListaExerciciosRepeticao {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner leitor = new Scanner(System.in);
        int i, s = 0;
        int quantidadeLados, medida;
        System.out.println("Digite o número de lados: ");
        quantidadeLados = leitor.nextInt();
        for (i = 0; i < quantidadeLados; i++){
            System.out.println("Digite a medida do lado " + (i + 1));
            s += leitor.nextInt();
        }
        System.out.println("O perímetro é " + s);
    }
    
}
