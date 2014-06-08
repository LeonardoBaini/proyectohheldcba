package Clases;

public class Cripter {
	
	
	  
	public  String Encriptar(String textoPlano) {
		
		 String mensaje=textoPlano; 
	        char array[]=mensaje.toCharArray(); 
	         
	        for(int i=0;i<array.length;i++){ 
	            array[i]=(char)(array[i]+(char)5); 
	} 
	        String encriptado =String.valueOf(array); 
	     //   System.out.println(encriptado); 			
		
        return encriptado;
}

	public  String Desencriptar(String encriptado) throws Exception {
		
		char arrayD[]=encriptado.toCharArray(); 
        for(int i=0;i<arrayD.length;i++){ 
            arrayD[i]=(char)(arrayD[i]-(char)5); //RESTA 5 A M DANDO H EN ESTE CASO PORQUE HIJKLM si.vamos a visual!OK.
        } 
      String desencriptado =String.valueOf(arrayD); 
       // System.out.println(desencriptado);   
	
      //querrasdecir la parte del culo...mas que cool... jaja
      //viste jaja, estaré loco pero no bolu...
      // he aquí un entorno de test.
        return desencriptado;
}
}
