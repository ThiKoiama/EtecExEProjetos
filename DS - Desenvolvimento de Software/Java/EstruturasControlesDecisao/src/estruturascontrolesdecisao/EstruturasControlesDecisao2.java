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
public class EstruturasControlesDecisao2 {
    public static void main(String[] args) {
       int cargo, horas;
       double salariofinal, salariobase;
        Scanner leitor = new Scanner(System.in);
        System.out.println("Digite o código do cargo: ");
        cargo=leitor.nextInt();
        System.out.println("Digite a quantidade de horas trabalhadas: ");
        horas=leitor.nextInt();
        switch (cargo){
            case 1:
                salariobase= 45.32;
                salariofinal=salariobase*horas;
            break;
            case 2:
                salariobase=  32.23;
                salariofinal=salariobase*horas;
            break;
             case 3:
                salariobase=   47.25;
                salariofinal=salariobase*horas;
            break;
             case 4:
                salariobase=   33.70;
                salariofinal=salariobase*horas;
            break;
            default:
                salariofinal=0;
                System.out.println("Digite um código válido!");
                break;
            
        }
        System.out.println("Salário final é de R$"+salariofinal);
    }
    
}
