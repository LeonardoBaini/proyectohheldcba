package Clases;

import java.io.IOException;
import java.util.ArrayList;

import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.UIManager;
import javax.swing.UnsupportedLookAndFeelException;

import Pantallas.PantallaPPal;


@SuppressWarnings("unused")
public class Test {

	/**
	 * @param args
	 */
	/**
	 * @param args
	 * @throws Exception 
	 */
	public static void main(String[] args) throws Exception {
		
		  try {
				UIManager.setLookAndFeel("com.sun.java.swing.plaf.nimbus.NimbusLookAndFeel");
				
			} catch (ClassNotFoundException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} catch (InstantiationException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} catch (IllegalAccessException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} catch (UnsupportedLookAndFeelException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} 
	       
	       
	        
		PantallaPPal pant=new PantallaPPal();
		pant.setLocationRelativeTo(null);
		pant.setResizable(false);
		pant.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		pant.setVisible(true);
		String dir1="C:\\TFHHELD\\USRS";
		String dir2="C:\\TFHHELD\\TEMPBAJADAS";
		String dir3="C:\\TFHHELD\\BAJADAS";
		String dir4="C:\\TFHHELD\\PROVISORIO";
		String dir5="C:\\TFHHELD\\DEFINITIVO";
		String dir6="C:\\TFHHELD\\PLANTILLASTABULADAS";
		String dir7="C:\\TFHHELD\\HISTORIALBAJADAS";
		ArrayList <String> listaDir=new ArrayList<String>();
		EscribirArchivo escritor=new EscribirArchivo();
		listaDir.add(dir1);
		listaDir.add(dir2);
		listaDir.add(dir3);
		listaDir.add(dir4);
		listaDir.add(dir5);
		listaDir.add(dir6);
		listaDir.add(dir7);
		int count=0;
		
		InicializadorDirectorios ini=new InicializadorDirectorios();
		for(int i=0;i<listaDir.size();i++){
		
		if (ini.crearCarpetas(listaDir.get(i))){
			count++;
		}
		
		}
	
		if (count!=0){
		JOptionPane.showMessageDialog(null,"Directorios creados  = "+count);
		}
		count=0;
		for(int i=0;i<listaDir.size();i++){
			
			if (ini.esDirectorio(listaDir.get(i))){
				count++;
			}
			
			}
		if(count==7){
			JOptionPane.showMessageDialog(null,"Todos los directorios estan creados\n ***NO OLVIDE COMPARTIR TEMPBAJADAS Y USRS EN TFHHELD***");
		}else{
			JOptionPane.showMessageDialog(null,"Faltan directorios");
		}
		
		if(ini.existeFichero("C:\\TFHHELD\\PLANTILLASTABULADAS\\PLANTILLAREIMP.txt")==false){
	
		String PLANTILLAREIMP="type\"NROENTRADA\"key\"enter\"type\"a011\"key\"enter\"key\"pf1\"type\"12\"key\"enter\"";
		escritor.escribirUnaLinea("C:\\TFHHELD\\PLANTILLASTABULADAS\\PLANTILLAREIMP.txt", PLANTILLAREIMP);
		JOptionPane.showMessageDialog(null,"Plantilla de REIMPRESIÓN creada");
		}
		if(ini.existeFichero("C:\\TFHHELD\\PLANTILLASTABULADAS\\PLANTILLAUBIC.txt")==false){
		
		String PLANTILLAUBIC="type\"NROENTRADA\"key\"enter\"key\"enter\"type\"1P\"key\"tab\"type\"0701\"key\"enter\"key\"enter\"key\"enter\"key\"enter\"type\"UBICACION\"key\"enter\"key\"enter\"appendtodisk \"D:\\ENTRADACAMBIO.txt,24/2,24/79\"key\"pf1\"type\"0601\"key\"enter\"";
		escritor.escribirUnaLinea("C:\\TFHHELD\\PLANTILLASTABULADAS\\PLANTILLAUBIC.txt", PLANTILLAUBIC);
		JOptionPane.showMessageDialog(null,"Plantilla de UBICACIÓN creada");
		}
		
		
		
	}
	
		
}


		


