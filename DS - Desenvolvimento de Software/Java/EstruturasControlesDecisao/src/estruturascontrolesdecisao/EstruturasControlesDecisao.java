/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package estruturascontrolesdecisao;

import java.util.Scanner;

/**
 *
 * @author Aluno
 */
public class EstruturasControlesDecisao {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner leitor = new Scanner(System.in);
        System.out.println("Digite o código sanguíneo do paciente: ");
        int codigo = leitor.nextInt();
        switch (codigo){
            case 1:
                System.out.println("Você pode receber apenas de O- e seu código é O-");
                break;
            case 2:
                System.out.println("Você pode receber apenas de O- e O+ e seu código é O+");
                break;
            case 3:
                System.out.println("Você pode receber apenas de O- e A- e seu código é A-");
                break;
            case 4:
                System.out.println("Você pode receber apenas de O-, O+, A- e A+ e seu código é A+");
                break;
            case 5:
                System.out.println("Você pode receber apenas de O- e B- e seu código é B-");
                break;
            case 6:
                System.out.println("Você pode receber apenas de O-, O+, B- e B+ e seu código é B+");
                break;
            case 7:
                System.out.println("Você pode receber apenas de O-, A-, B- e AB- e seu código é AB-");
                break;
            case 8:
                System.out.println("Você pode receber de todos os tipos e seu código é AB+");
                break;
            default:
                System.out.println("Código errado! Tente novamente");
                break;
        }
    }
    
}
