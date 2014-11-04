package Pantallas;

import Clases.*;
//import java.awt.BorderLayout;

import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JFrame;
//import java.awt.Dimension;
import javax.swing.JMenu;
import java.awt.Rectangle;
import java.io.IOException;
import java.util.ArrayList;

import javax.swing.JMenuBar;
import javax.swing.JMenuItem;

import Clases.InicializadorDirectorios;
import javax.swing.JLabel;
import javax.swing.ImageIcon;
import java.awt.Toolkit;
import javax.swing.JButton;
//import java.awt.GridBagLayout;
import javax.swing.BorderFactory;
import javax.swing.border.TitledBorder;
import java.awt.Color;
import java.awt.Font;
import java.awt.SystemColor;

public class PantallaPPal extends JFrame {

	private static final long serialVersionUID = 1L;
	private JPanel jContentPane = null;
	private JMenuBar jJMenuBar = null;
	private JMenu jMenuArchivo = null;
	private JMenu jMenuTareas = null;
	
	private JMenuItem jMenuItemSalir = null;
	private JLabel jLabel = null;
	private JMenu jMenuABMUsrs = null;
	private JMenuItem jMenuItemAlta = null;
	private JMenuItem jMenuItemBaja = null;
	private JMenuItem jMenuItemModif = null;
	private JMenuItem jMenuItemGenerarGmapDefinitivo = null;
	private JButton jButtonBajadas = null;
	private JButton jButtonDefinitivo = null;
	private JButton jButtonHistBajadas = null;
	private JButton jButton3 = null;
	private JButton jButtonProvisorio = null;
	private JButton jButton5 = null;
	private JPanel jPanelBotoneraCarpetas = null;
	/**
	 * This is the default constructor
	 */
	public PantallaPPal() {
		super();
		initialize();
	}

	/**
	 * This method initializes this
	 * 
	 * @return void
	 */
	private void initialize() {
		this.setSize(715, 344);
		this.setIconImage(Toolkit.getDefaultToolkit().getImage(getClass().getResource("/Imagenes/LogoFurlongHHeld.png")));
		this.setJMenuBar(getJJMenuBar());
		this.setContentPane(getJContentPane());
		this.setTitle("Transportes Furlong                                           TFHHELD PARA PC  v.4");
	}

	/**
	 * This method initializes jContentPane
	 * 
	 * @return javax.swing.JPanel
	 */
	private JPanel getJContentPane() {
		if (jContentPane == null) {
			jLabel = new JLabel();
			jLabel.setBounds(new Rectangle(219, 34, 210, 85));
			jLabel.setIcon(new ImageIcon(getClass().getResource("/Imagenes/LogoFurlongHHeld.png")));
			jLabel.setText("");
			jContentPane = new JPanel();
			jContentPane.setLayout(null);
			jContentPane.setBackground(new Color(103, 135, 175));
			jContentPane.add(jLabel, null);
			jContentPane.add(getJPanelBotoneraCarpetas(), null);
		}
		return jContentPane;
	}

	/**
	 * This method initializes jJMenuBar	
	 * 	
	 * @return javax.swing.JMenuBar	
	 */
	private JMenuBar getJJMenuBar() {
		if (jJMenuBar == null) {
			jJMenuBar = new JMenuBar();
			jJMenuBar.setBackground(new Color(163, 163, 215));
			jJMenuBar.setFont(new Font("Dialog", Font.BOLD, 12));
			jJMenuBar.add(getJMenuArchivo());
			jJMenuBar.add(getJMenuTareas());
			jJMenuBar.add(getJMenuABMUsrs());
		}
		return jJMenuBar;
	}

	/**
	 * This method initializes jMenuArchivo	
	 * 	
	 * @return javax.swing.JMenu	
	 */
	private JMenu getJMenuArchivo() {
		if (jMenuArchivo == null) {
			jMenuArchivo = new JMenu();
			jMenuArchivo.setText("Archivo");
			jMenuArchivo.add(getJMenuItemSalir());
		}
		return jMenuArchivo;
	}

	/**
	 * This method initializes jMenuTareas	
	 * 	
	 * @return javax.swing.JMenu	
	 */
	private JMenu getJMenuTareas() {
		if (jMenuTareas == null) {
			jMenuTareas = new JMenu();
			jMenuTareas.setText("Tareas");
			
			jMenuTareas.add(getJMenuItemGenerarGmapDefinitivo());
		}
		return jMenuTareas;
	}

	/**
	 * Copia de TEMPBAJADAS al resto de los directorios.	
	 * C:\\TFHHELD\\BAJADAS\\
	 * C:\\TFHHELD\\HISTORIALBAJADAS\\
	 * C:\\TFHHELD\\PROVISORIO\\
	 * 	
	 * @return javax.swing.JMenuItem	
	 */
	
	private boolean bajarDatos(){
		boolean ok=false;
		String ultimoUsuario;
		LeerArchivo l=new LeerArchivo();
		ultimoUsuario=l.ultimoUsuario("C:\\TFHHELD\\TEMPBAJADAS\\CULECTURAS.txt");
		InicializadorDirectorios ini=new InicializadorDirectorios();
		String archivoOrigen="C:\\TFHHELD\\TEMPBAJADAS\\CULECTURAS.txt";
		String archivoDestinoBajadas="C:\\TFHHELD\\BAJADAS\\CULECTURAS.txt";
		String archivoDestinoHistorialBajadas="C:\\TFHHELD\\HISTORIALBAJADAS\\CULECTURAS"+ultimoUsuario+ini.dameFechaDeHoy()+ini.dameHora()+".txt";
		String archivoDestinoProvisorio="C:\\TFHHELD\\PROVISORIO\\CUWKFILE01.txt";
		
		String dir1="C:\\TFHHELD\\BAJADAS";
		String dir2="C:\\TFHHELD\\PROVISORIO";
	
		
		boolean vacio1;
		boolean vacio2;
		vacio1=ini.esDirectorioVacio(dir1);
		vacio2=ini.esDirectorioVacio(dir2);
		if(vacio1==true && vacio2==true){
			try {
				Color colorDefault;
				ini.copyFile(archivoOrigen,archivoDestinoBajadas);
				JOptionPane.showMessageDialog(null,"Dato copiado ok a BAJADAS");
				colorDefault=jButtonBajadas.getBackground();
				jButtonBajadas.setBackground(Color.GREEN);
				ini.copyFile(archivoOrigen,archivoDestinoProvisorio);
				JOptionPane.showMessageDialog(null,"Dato copiado ok a PROVISORIO");
				jButtonProvisorio.setBackground(Color.GREEN);
				ini.copyFile(archivoOrigen,archivoDestinoHistorialBajadas);
				jButtonHistBajadas.setBackground(Color.GREEN);
				JOptionPane.showMessageDialog(null,"Dato copiado ok a HISTORIASBAJADAS");
				
				
				jButtonBajadas.setBackground(colorDefault);
				
				jButtonProvisorio.setBackground(colorDefault);
				
				jButtonHistBajadas.setBackground(colorDefault);
				ok=true;
				
			} catch (IOException e1) {
			
				JOptionPane.showMessageDialog(null,"ERROR "+e1.getMessage());
				ok=false;
			}
		}else{
			JOptionPane.showMessageDialog(null,"Imposible transferir, proceso GMAP pendiente directorios BAJADAS Y PROVISORIO CONTIENEN DATOS.");
			ok=false;
		}
		return ok;
	
	}
	private JMenuItem getJMenuItemSalir() {
		if (jMenuItemSalir == null) {
			jMenuItemSalir = new JMenuItem();
			jMenuItemSalir.setText("Salir");
			jMenuItemSalir.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					dispose();
				}
			});
		}
		return jMenuItemSalir;
	}

	/**
	 * This method initializes jMenuABMUsrs	
	 * 	
	 * @return javax.swing.JMenu	
	 */
	private JMenu getJMenuABMUsrs() {
		if (jMenuABMUsrs == null) {
			jMenuABMUsrs = new JMenu();
			jMenuABMUsrs.setText("ABM usuarios");
			jMenuABMUsrs.add(getJMenuItemAlta());
			jMenuABMUsrs.add(getJMenuItemBaja());
			jMenuABMUsrs.add(getJMenuItemModif());
		}
		return jMenuABMUsrs;
	}

	/**
	 * This method initializes jMenuItemAlta	
	 * 	
	 * @return javax.swing.JMenuItem	
	 */
	private JMenuItem getJMenuItemAlta() {
		if (jMenuItemAlta == null) {
			jMenuItemAlta = new JMenuItem();
			jMenuItemAlta.setText("Alta");
			jMenuItemAlta.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
				AltaUsuario alta=new AltaUsuario();
				
				alta.setLocationRelativeTo(null);
				alta.setVisible(true);
				
				}
			});
		}
		return jMenuItemAlta;
	}

	/**
	 * This method initializes jMenuItemBaja	
	 * 	
	 * @return javax.swing.JMenuItem	
	 */
	private JMenuItem getJMenuItemBaja() {
		if (jMenuItemBaja == null) {
			jMenuItemBaja = new JMenuItem();
			jMenuItemBaja.setText("Baja");
			jMenuItemBaja.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
				BajaUsuario baja= new BajaUsuario();
				
				baja.setLocationRelativeTo(null);
				baja.setVisible(true);
				
				}
				
			});
		}
		return jMenuItemBaja;
	}

	/**
	 * This method initializes jMenuItemModif	
	 * 	
	 * @return javax.swing.JMenuItem	
	 */
	private JMenuItem getJMenuItemModif() {
		if (jMenuItemModif == null) {
			jMenuItemModif = new JMenuItem();
			jMenuItemModif.setText("Modificación");
			jMenuItemModif.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
				ModifUsuario mod=new ModifUsuario();
				
				mod.setLocationRelativeTo(null);
				mod.setVisible(true);
				
				}
			});
		}
		return jMenuItemModif;
	}

	private String generarCUGMAPCU(String plantillaUbic,String lineaCUWKFILE01){
		 //ubic    //entrada //dis         //pn                  hheld     usr
		//J20102     107062  005040626330  0504062633000092110   12        usuario
	//	type"NROENTRADA"key"enter"key"enter"type"1P"key"tab"type"0701"key"enter"key"enter"key"enter"key"enter"type"UBICACION"key"enter"key"enter"appendtodisk "D:\ENTRADACAMBIO.txt,24/2,24/79"key"pf1"type"0601"key"enter"
		String auxPlantillaUbic=plantillaUbic.replaceAll("NROENTRADA", lineaCUWKFILE01.substring(11, 17));//11 a 16
		auxPlantillaUbic=auxPlantillaUbic.replaceAll("UBICACION",lineaCUWKFILE01.substring(0, 6));//0 a 6
		
		
		return auxPlantillaUbic;
	}
	
	private String generarCUGMAPRE(String plantillaReimp,String lineaCUWKFILE01){
		String auxPlantillaReimp=null;
		// type"NROENTRADA"key"enter"type"a011"key"enter"key"pf1"type"12"key"enter"
		//ubic    //entrada //dis         //pn                  hheld     usr
		//J20102     107062  005040626330  0504062633000092110   12        usuario
	//	type"NROENTRADA"key"enter"key"enter"type"1P"key"tab"type"0701"key"enter"key"enter"key"enter"key"enter"type"UBICACION"key"enter"key"enter"appendtodisk "D:\ENTRADACAMBIO.txt,24/2,24/79"key"pf1"type"0601"key"enter"
		if(lineaCUWKFILE01.substring(8, 9).equals("R")){
		auxPlantillaReimp=plantillaReimp.replaceAll("NROENTRADA", lineaCUWKFILE01.substring(11, 17));//11 a 16
		}
		
		
		return auxPlantillaReimp;
	}
	
	
	/**
	 * This method initializes jMenuItemGenerarGmapDefinitivo	
	 * 	
	 * @return javax.swing.JMenuItem	
	 */
	private JMenuItem getJMenuItemGenerarGmapDefinitivo() {
		if (jMenuItemGenerarGmapDefinitivo == null) {
			jMenuItemGenerarGmapDefinitivo = new JMenuItem();
			jMenuItemGenerarGmapDefinitivo.setText("GENERAR ARCHIVOS DEFINIT. PARA GMAP");
			jMenuItemGenerarGmapDefinitivo
					.addActionListener(new java.awt.event.ActionListener() {
						public void actionPerformed(java.awt.event.ActionEvent e) {
							boolean datosBajadosOK=false;
							InicializadorDirectorios ini=new InicializadorDirectorios();
							if (ini.existeFichero("C:\\TFHHELD\\DEFINITIVO\\CUGMAPCU.txt")==false && ini.existeFichero("C:\\TFHHELD\\DEFINITIVO\\CUGMAPRE.txt")==false){
							
								if (ini.existeFichero("C:\\TFHHELD\\TEMPBAJADAS\\CULECTURAS.txt")==true){
									datosBajadosOK=bajarDatos(); 
							if(datosBajadosOK){
							
							try{
							
							
							
							
							String lineaPlantillaUBIC=null;
							String lineaPLantillaREIMP=null;
							ArrayList<String>reimpresiones=new ArrayList<String>();
							ArrayList<String>reubicaciones=new ArrayList<String>();
							ArrayList<String>provisorio=null;
							EscribirArchivo escritor=new EscribirArchivo();
							LeerArchivo CUWKFILE01=new LeerArchivo();
							LeerArchivo PLANTILLAREIMP=new LeerArchivo();
							LeerArchivo PLANTILLAUBIC=new LeerArchivo();
							provisorio=CUWKFILE01.leer("C:\\TFHHELD\\PROVISORIO\\CUWKFILE01.txt");
							lineaPLantillaREIMP=PLANTILLAREIMP.leer("C:\\TFHHELD\\PLANTILLASTABULADAS\\PLANTILLAREIMP.txt").get(0);
							lineaPlantillaUBIC=PLANTILLAUBIC.leer("C:\\TFHHELD\\PLANTILLASTABULADAS\\PLANTILLAUBIC.txt").get(0);
							String AuxGenerarCUMAPRE=null;
							
							for(int i=0;i<provisorio.size();i++){
							reubicaciones.add(generarCUGMAPCU(lineaPlantillaUBIC,provisorio.get(i)));
							AuxGenerarCUMAPRE=generarCUGMAPRE(lineaPLantillaREIMP, provisorio.get(i));
							if(AuxGenerarCUMAPRE!=null)
							reimpresiones.add(AuxGenerarCUMAPRE);
							}							
							
							escritor.escribir("C:\\TFHHELD\\DEFINITIVO\\CUGMAPCU.txt", reubicaciones);
							escritor.escribir("C:\\TFHHELD\\DEFINITIVO\\CUGMAPRE.txt", reimpresiones);
							
							LeerArchivo CUGMAPCU=new LeerArchivo();
							LeerArchivo CUGMAPRE=new LeerArchivo();
							
							int lineasCUGMAPCU=CUGMAPCU.contarLineas("C:\\TFHHELD\\DEFINITIVO\\CUGMAPCU.txt");
							int lineasCUGMAPRE=CUGMAPRE.contarLineas("C:\\TFHHELD\\DEFINITIVO\\CUGMAPRE.txt");;
							int lineasPROVISORIO=provisorio.size();
							
							if(lineasCUGMAPCU==lineasPROVISORIO){	
								Color colorDefault=jButtonDefinitivo.getBackground();
								jButtonDefinitivo.setBackground(Color.GREEN);
							JOptionPane.showMessageDialog(null,"Los archivos\n" +
															   " C:\\TFHHELD\\DEFINITIVO\\CUGMAPCU.txt\ny\n" +
									                           " C:\\TFHHELD\\DEFINITIVO\\CUGMAPRE.txt\nSe han generado con éxito!\n" +
									                           "\nlineas CUGMAPCU.txt="+lineasCUGMAPCU+
									                           "\nlineas CUGMAPRE.txt="+lineasCUGMAPRE+
									                           "\nlineas WKFILE01.txt= "+lineasPROVISORIO+
									                           "\n****CORTE LOS ARCHIVOS GENERADOS Y PÉGUELOS EN SU CARPETA DE PROCESO HABITUAL****" +
									                           "\n\nLAS LINEAS DE \"CUGMAPRE.txt\" PUEDEN SER MENOS, PUES NO TODAS SE REIMPRIMEN." );
							
							ini.borrarFichero("C:\\TFHHELD\\TEMPBAJADAS\\CULECTURAS.txt");
							
							ini.borrarFichero("C:\\TFHHELD\\PROVISORIO\\CUWKFILE01.txt");
							
							ini.borrarFichero("C:\\TFHHELD\\BAJADAS\\CULECTURAS.txt");
							
							
							
							
							
							ini.abrirDirectorio("C:\\TFHHELD\\DEFINITIVO");
							jButtonDefinitivo.setBackground(colorDefault);
							
							}else{
								JOptionPane.showMessageDialog(null,"Los archivos\n" +
										   " C:\\TFHHELD\\DEFINITIVO\\CUGMAPCU.txt\ny\n" +
				                           " C:\\TFHHELD\\DEFINITIVO\\CUGMAPRE.txt\nNO COINCIDEN EN TAMAÑO VERIFIQUELOS!\n" +
				                           "\nlineas CUGMAPCU.txt="+lineasCUGMAPCU+
				                           "\nlineas WKFILE01.txt= "+lineasPROVISORIO);
								
								ini.abrirDirectorio("C:\\TFHHELD\\DEFINITIVO");								
								ini.abrirDirectorio("C:\\TFHHELD\\PROVISORIO");
								
							}
							
							}catch(Exception ex){
								JOptionPane.showMessageDialog(null,"Se produjo un error "+ex.getMessage());
								
							}
							}else{//fin si no se bajó ok
								JOptionPane.showMessageDialog(null, "No se puede bajar de TEMPBAJADAS"); 
							}
								}else{
									JOptionPane.showMessageDialog(null,"NO HAY ARCHIVO 'CULECTURAS.txt' EN C:\\TFHHELD\\TEMPBAJADAS PARA PROCESAR,\n BAJE UNO DE LA HAND HELD USANDO LA OPCIÓN 'BAJAR A PC'");	
								}
							}else{
								JOptionPane.showMessageDialog(null,"ANTES DE ÉSTE NUEVO PROCESO, (MUEVA)  CORTANDO Y PEGANDO LOS ARCHIVOS YA GENERADOS POR ÉSTE SISTEMA...\n" +
										"Mientras haya al menos un archivo en DEFINITIVO, no se puede seguir...");
								ini.abrirDirectorio("C:\\TFHHELD\\DEFINITIVO");	
							}
							
							
						}
					});
		}
		return jMenuItemGenerarGmapDefinitivo;
	}

	/**
	 * This method initializes jButton	
	 * 	
	 * @return javax.swing.JButton	
	 */
	private JButton getJButton() {
		if (jButtonBajadas == null) {
			jButtonBajadas = new JButton();
			//jButtonBajadas.setBackground(new Color(162, 162, 241));
			jButtonBajadas.setBounds(new Rectangle(18, 16, 155, 25));
			jButtonBajadas.setText("BAJADAS");
			jButtonBajadas.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					InicializadorDirectorios ini=new InicializadorDirectorios();
					ini.abrirDirectorio("C:\\TFHHELD\\BAJADAS");
				}
			});
		}
		return jButtonBajadas;
	}

	/**
	 * This method initializes jButton1	
	 * 	
	 * @return javax.swing.JButton	
	 */
	private JButton getJButton1() {
		if (jButtonDefinitivo == null) {
			jButtonDefinitivo = new JButton();
			jButtonDefinitivo.setBounds(new Rectangle(197, 53, 155, 25));
			// jButtonDefinitivo.setBackground(new Color(162, 162, 241));
			jButtonDefinitivo.setText("DEFINITIVO");
			jButtonDefinitivo.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					InicializadorDirectorios ini=new InicializadorDirectorios();
					ini.abrirDirectorio("C:\\TFHHELD\\DEFINITIVO");
				}
			});
		}
		return jButtonDefinitivo;
	}

	/**
	 * This method initializes jButton2	
	 * 	
	 * @return javax.swing.JButton	
	 */
	private JButton getJButton2() {
		if (jButtonHistBajadas == null) {
			jButtonHistBajadas = new JButton();
			//jButtonHistBajadas.setBackground(new Color(162, 162, 241));
			jButtonHistBajadas.setBounds(new Rectangle(17, 90, 155, 25));
			jButtonHistBajadas.setText("HIST. BAJADAS");
			jButtonHistBajadas.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					InicializadorDirectorios ini=new InicializadorDirectorios();
					ini.abrirDirectorio("C:\\TFHHELD\\HISTORIALBAJADAS");
				}
			});
		}
		return jButtonHistBajadas;
	}

	/**
	 * This method initializes jButton3	
	 * 	
	 * @return javax.swing.JButton	
	 */
	private JButton getJButton3() {
		if (jButton3 == null) {
			jButton3 = new JButton();
			jButton3.setBounds(new Rectangle(196, 16, 155, 25));
			//jButton3.setBackground(new Color(162, 162, 241));
			jButton3.setText("PLANT. TABULADAS");
			jButton3.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					InicializadorDirectorios ini=new InicializadorDirectorios();
					ini.abrirDirectorio("C:\\TFHHELD\\PLANTILLASTABULADAS");
				}
			});
		}
		return jButton3;
	}

	/**
	 * This method initializes jButton4	
	 * 	
	 * @return javax.swing.JButton	
	 */
	private JButton getJButton4() {
		if (jButtonProvisorio == null) {
			jButtonProvisorio = new JButton();
			jButtonProvisorio.setBounds(new Rectangle(18, 53, 155, 25));
			//jButtonProvisorio.setBackground(new Color(162, 162, 241));
			jButtonProvisorio.setText("PROVISORIO");
			jButtonProvisorio.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					InicializadorDirectorios ini=new InicializadorDirectorios();
					ini.abrirDirectorio("C:\\TFHHELD\\PROVISORIO");
				}
			});
		}
		return jButtonProvisorio;
	}

	/**
	 * This method initializes jButton5	
	 * 	
	 * @return javax.swing.JButton	
	 */
	private JButton getJButton5() {
		if (jButton5 == null) {
			jButton5 = new JButton();
			jButton5.setBounds(new Rectangle(197, 92, 155, 25));
			//jButton5.setBackground(new Color(162, 162, 241));
			jButton5.setText("TEMPBAJADAS");
			jButton5.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					InicializadorDirectorios ini=new InicializadorDirectorios();
					ini.abrirDirectorio("C:\\TFHHELD\\TEMPBAJADAS");
				}
			});
		}
		return jButton5;
	}

	/**
	 * This method initializes jPanelBotoneraCarpetas	
	 * 	
	 * @return javax.swing.JPanel	
	 */
	private JPanel getJPanelBotoneraCarpetas() {
		if (jPanelBotoneraCarpetas == null) {
			jPanelBotoneraCarpetas = new JPanel();
			jPanelBotoneraCarpetas.setLayout(null);
			jPanelBotoneraCarpetas.setBounds(new Rectangle(145, 154, 374, 130));
			jPanelBotoneraCarpetas.setBorder(BorderFactory.createTitledBorder(null, "Visor de carpetas", TitledBorder.DEFAULT_JUSTIFICATION, TitledBorder.DEFAULT_POSITION, null, SystemColor.activeCaptionBorder));
			jPanelBotoneraCarpetas.setBackground(new Color(103, 135, 175));
			jPanelBotoneraCarpetas.add(getJButton1(), null);
			jPanelBotoneraCarpetas.add(getJButton3(), null);
			jPanelBotoneraCarpetas.add(getJButton4(), null);
			jPanelBotoneraCarpetas.add(getJButton5(), null);
			jPanelBotoneraCarpetas.add(getJButton(), null);
			jPanelBotoneraCarpetas.add(getJButton2(), null);
		}
		return jPanelBotoneraCarpetas;
	}

}  //  @jve:decl-index=0:visual-constraint="10,10"
