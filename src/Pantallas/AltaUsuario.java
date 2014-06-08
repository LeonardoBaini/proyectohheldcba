package Pantallas;

import java.awt.BorderLayout;

import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JFrame;
import javax.swing.JTextField;
import java.awt.Rectangle;
import javax.swing.JLabel;
import javax.swing.JPasswordField;
import javax.swing.JButton;
import java.awt.Toolkit;
import javax.swing.ImageIcon;

import Clases.ABM;
import Clases.Cripter;
import Clases.EscribirArchivo;
import Clases.InicializadorDirectorios;

import java.awt.Color;
import java.awt.Font;
import java.awt.event.KeyEvent;
import java.util.ArrayList;

@SuppressWarnings("unused")
public class AltaUsuario extends JFrame {

	private static final long serialVersionUID = 1L;
	private JPanel jContentPane = null;
	private JTextField jTextFieldUsuario = null;
	private JLabel jLabelUsuario = null;
	private JPasswordField jPasswordFieldContrasenia = null;
	private JLabel Contasenia = null;
	private JButton jButtonCrear = null;

	/**
	 * This is the default constructor
	 */
	public AltaUsuario() {
		super();
		initialize();
	}

	/**
	 * This method initializes this
	 * 
	 * @return void
	 */
	private void initialize() {
		this.setSize(300, 200);
		this.setIconImage(Toolkit.getDefaultToolkit().getImage(getClass().getResource("/Iconos/Profile.png")));
		this.setContentPane(getJContentPane());
		setResizable(false);
		this.setTitle("Alta de usuarios");
	}

	/**
	 * This method initializes jContentPane
	 * 
	 * @return javax.swing.JPanel
	 */
	private JPanel getJContentPane() {
		if (jContentPane == null) {
			Contasenia = new JLabel();
			Contasenia.setBounds(new Rectangle(60, 65, 131, 18));
			Contasenia.setForeground(Color.white);
			Contasenia.setText("Contraseña");
			jLabelUsuario = new JLabel();
			jLabelUsuario.setBounds(new Rectangle(60, 8, 177, 19));
			jLabelUsuario.setFont(new Font("Dialog", Font.BOLD, 12));
			jLabelUsuario.setForeground(Color.white);
			jLabelUsuario.setText("Usuario");
			jContentPane = new JPanel();
			jContentPane.setLayout(null);
			jContentPane.setBackground(new Color(103, 135, 175));
			jContentPane.add(getJTextFieldUsuario(), null);
			jContentPane.add(jLabelUsuario, null);
			jContentPane.add(getJPasswordFieldContrasenia(), null);
			jContentPane.add(Contasenia, null);
			jContentPane.add(getJButtonCrear(), null);
		}
		return jContentPane;
	}

	/**
	 * This method initializes jTextFieldUsuario	
	 * 	
	 * @return javax.swing.JTextField	
	 */
	private JTextField getJTextFieldUsuario() {
		if (jTextFieldUsuario == null) {
			jTextFieldUsuario = new JTextField();
			jTextFieldUsuario.setBounds(new Rectangle(60, 29, 171, 34));
		}
		return jTextFieldUsuario;
	}

	/**
	 * This method initializes jPasswordFieldContrasenia	
	 * 	
	 * @return javax.swing.JPasswordField	
	 */
	private JPasswordField getJPasswordFieldContrasenia() {
		if (jPasswordFieldContrasenia == null) {
			jPasswordFieldContrasenia = new JPasswordField();
			jPasswordFieldContrasenia.setBounds(new Rectangle(61, 88, 171, 34));
		}
		return jPasswordFieldContrasenia;
	}

	/**
	 * This method initializes jButtonCrear	
	 * 	
	 * @return javax.swing.JButton	
	 */
	private JButton getJButtonCrear() {
		if (jButtonCrear == null) {
			jButtonCrear = new JButton();
			jButtonCrear.setBounds(new Rectangle(61, 128, 171, 35));
			jButtonCrear.setIcon(new ImageIcon(getClass().getResource("/Iconos/Save.png")));
			jButtonCrear.setText("Dar de Alta");
			jButtonCrear.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					if (jTextFieldUsuario.getText().length()==0 || jPasswordFieldContrasenia.getPassword().length==0){
						JOptionPane.showMessageDialog(null,"No se aceptan campos vacíos!.\nComplételos");
					}else{
						try{
							ABM abm=new ABM();
							
						InicializadorDirectorios ini=new InicializadorDirectorios();
						
						String usuario;
						String pass;
						
						usuario=jTextFieldUsuario.getText();
						pass=String.valueOf(jPasswordFieldContrasenia.getPassword());
						String ruta="C:\\TFHHELD\\USRS\\USRS.txt";	
						if(ini.existeFichero(ruta)==false){
							abm.crearUsuario("administrador","coinse", ruta);
						}
						
						if(abm.usuarioExiste(usuario, ruta)){
							JOptionPane.showMessageDialog(null,"El usuario ya existe, no se puede crear, a lo sumo modificar o borrar...");
						}else{
						if(abm.crearUsuario(usuario, pass, ruta)==true){
							JOptionPane.showMessageDialog(null,"Usuario creado OK!");
										
						}
						}
						}catch(Exception e1){
							JOptionPane.showMessageDialog(null,e1.getMessage());
							
						}
						
					}
				}
			});
			jButtonCrear.addKeyListener(new java.awt.event.KeyAdapter() {
				public void keyPressed(java.awt.event.KeyEvent e) {


					if(e.getKeyCode()== KeyEvent.VK_ENTER){
						jButtonCrear.doClick();
					}
				}
			});
		}
		return jButtonCrear;
	}

}
