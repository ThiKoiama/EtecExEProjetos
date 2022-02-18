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
public class EstruturasControlesDecisao3 {
    public static void main(String[] args) {
        double salario, valorfilho, salariofamilia;
        Scanner leitor = new Scanner(System.in);
        int numfilhos;
        System.out.println("Digite o salário bruto do funcionário: ");
        salario = leitor.nextDouble();
        System.out.println("Digite o número de filhos: ");
        numfilhos = leitor.nextInt();
        if(salario <= 808.80){
            valorfilho = 41.27;
        }
        else if(salario <= 1212.64){
            valorfilho = 29.16;
        }
        else{
            valorfilho = 0;
        }
        salariofamilia = salario + valorfilho * numfilhos;
        System.out.println("O salário final do funcionário será " + salariofamilia);
    }
}
