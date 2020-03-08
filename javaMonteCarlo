import java.util.concurrent.ThreadLocalRandom;
import java.util.Scanner;

public class Main {
	
	//TODO
	// Stworzyć klasę koło
	// oraz metody - pole pi, pole monte carlo 
	// w metodzie main stworzyć kilka obiektów o różnym promieniu
	

	public static void main(String[] args){
		
		 int promien;
         int iloscPunktow;
         int ileTrafilo = 0;
         

         double odleglosc;
         double promien2;
     
         double x;
         double y;
         
         Scanner myInput = new Scanner( System.in );
         

         System.out.println("Podaj promień okręgu: (INT) ");
         promien = myInput.nextInt();
         System.out.println();
         System.out.println("Podaj ilość punktów do wylosowania: (INT) ");
         iloscPunktow = myInput.nextInt();
         promien2 = promien;

         for (int i=0; i <= iloscPunktow; i++)
         {
             x = ThreadLocalRandom.current().nextDouble(-promien, promien);
             y = ThreadLocalRandom.current().nextDouble(-promien, promien);

             odleglosc = Math.sqrt(x * x + y * y);

             if (odleglosc <= promien2)
             {
                 ileTrafilo++;
             }
         }

         double pole = 0;
         pole = promien * promien * Math.PI;

         double pole2 = 0;
         pole2 = 4 * promien2 * promien2 * ileTrafilo / iloscPunktow;
         System.out.println();
         System.out.println("Pole normalnie: " + pole);
         System.out.println();
         System.out.println("Pole monte carlo: " + pole2);
         System.out.println();
         
         
         
         }
	
	
	
	}

