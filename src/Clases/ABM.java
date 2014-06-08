package Clases;

import java.util.ArrayList;

import javax.swing.JOptionPane;

public class ABM {
	
	public boolean borrarUsuario(String usuario,String ruta){
		boolean ok = false;
		try{
		String usr=usuario;	
		LeerArchivo l=new LeerArchivo();
		ArrayList<String> lineasFull=l.leer(ruta);
		ArrayList<String> usuarios=l.leerHastaLaComa(ruta);
		for(int i=0;i<usuarios.size();i++){
		if (usuarios.get(i).equals(usr)){
			lineasFull.remove(i);
			EscribirArchivo esc=new EscribirArchivo();
			esc.escribir(ruta, lineasFull);
		ok=true;
			
		}
		}
		
		}catch(Exception e1){
			JOptionPane.showMessageDialog(null,"Error "+e1.getMessage());
			
		}
		
return ok;
	}
	public boolean crearUsuario(String usuario,String pass,String ruta){
		
		try{
		String passEncriptado;
		System.out.println(usuario+pass);
		Cripter cri=new Cripter();
		passEncriptado=cri.Encriptar(pass);
		EscribirArchivo escritor=new EscribirArchivo();						
		String concatUsrPass=usuario+","+passEncriptado;						
		escritor.escribirContinuacionUnaLinea(ruta, concatUsrPass);
		
		return true;
		}catch(Exception e1){
			JOptionPane.showMessageDialog(null,"Error, no se creó el usuario, causa ->"+e1.getMessage());
			return false;
		}
		
	}
	
public boolean usuarioExiste(String usuario,String ruta){
		boolean existe=false;
		try{
		ArrayList<String>usuarios;
		LeerArchivo l=new LeerArchivo();
		usuarios=l.leerHastaLaComa(ruta);
		for(int i=0;i<usuarios.size();i++){
			if(usuarios.get(i).equals(usuario)){
				existe=true;
			}
		}
		
		
		}catch(Exception e1){
			JOptionPane.showMessageDialog(null,"Error, no se creó el usuario, causa ->"+e1.getMessage());
			
		}
		return existe;
		
	}
	
	
	


}









