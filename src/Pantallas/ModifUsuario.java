package Pantallas;

import java.awt.BorderLayout;
import javax.swing.JPanel;
import javax.swing.JFrame;
import java.awt.Color;
import java.awt.Toolkit;
import javax.swing.JComboBox;
import java.awt.Rectangle;
import java.awt.event.KeyEvent;
import java.util.ArrayList;

import javax.swing.JOptionPane;
import javax.swing.JPasswordField;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.ImageIcon;

import Clases.ABM;
import Clases.EscribirArchivo;
import Clases.LeerArchivo;

@SuppressWarnings("unused")
public class ModifUsuario extends JFrame {

	private static final long serialVersionUID = 1L;
	private JPanel jContentPane = null;
	private JComboBox<String> jComboBoxUsuarios = null;
	private JPasswordField jPasswordFieldPassword = null;
	private JLabel jLabelUsers = null;
	private JLabel jLabelClave = null;
	private JButton jButtonCambiarClave = null;

	/**
	 * This is the default constructor
	 */
	public ModifUsuario() {
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
		this.setTitle("Modificación de Usuarios");
		setResizable(false);
		inicializarUsuarios();
		
	}


	private void inicializarUsuarios(){
		try{
			jComboBoxUsuarios.removeAll();
			ArrayList<String>usuarios=null;
			String ruta="C:\\TFHHELD\\USRS\\USRS.txt";
			LeerArchivo l=new LeerArchivo();
			usuarios=l.leerHastaLaComa(ruta);
			
			for (int i=0;i<usuarios.size();i++){
				
				jComboBoxUsuarios.addItem(usuarios.get(i));
				
			}
			
		}catch(Exception e1){
			JOptionPane.showMessageDialog(null,"Error no se pueden mostrar los usuarios "+e1.getMessage());
			
		}
		
	}

	/**
	 * This method initializes jContentPane
	 * 
	 * @return javax.swing.JPanel
	 */
	private JPanel getJContentPane() {
		if (jContentPane == null) {
			jLabelClave = new JLabel();
			jLabelClave.setBounds(new Rectangle(35, 60, 164, 24));
			jLabelClave.setForeground(Color.white);
			jLabelClave.setText("Nueva Clave");
			jLabelUsers = new JLabel();
			jLabelUsers.setBounds(new Rectangle(34, 2, 203, 20));
			jLabelUsers.setForeground(Color.white);
			jLabelUsers.setText("Usuarios");
			jContentPane = new JPanel();
			jContentPane.setLayout(null);
			jContentPane.setBackground(new Color(103, 135, 175));
			jContentPane.add(getJComboBoxUsuarios(), null);
			jContentPane.add(getJPasswordFieldPassword(), null);
			jContentPane.add(jLabelUsers, null);
			jContentPane.add(jLabelClave, null);
			jContentPane.add(getJButtonCambiarClave(), null);
		}
		return jContentPane;
	}

	/**
	 * This method initializes jComboBoxUsuarios	
	 * 	
	 * @return javax.swing.JComboBox	
	 */
	private JComboBox<String> getJComboBoxUsuarios() {
		if (jComboBoxUsuarios == null) {
			jComboBoxUsuarios = new JComboBox<String>();
			jComboBoxUsuarios.setBounds(new Rectangle(34, 24, 236, 31));
		}
		return jComboBoxUsuarios;
	}

	/**
	 * This method initializes jPasswordFieldPassword	
	 * 	
	 * @return javax.swing.JPasswordField	
	 */
	private JPasswordField getJPasswordFieldPassword() {
		if (jPasswordFieldPassword == null) {
			jPasswordFieldPassword = new JPasswordField();
			jPasswordFieldPassword.setBounds(new Rectangle(36, 86, 219, 31));
		}
		return jPasswordFieldPassword;
	}

	/**
	 * This method initializes jButtonCambiarClave	
	 * 	
	 * @return javax.swing.JButton	
	 */
	private JButton getJButtonCambiarClave() {
		if (jButtonCambiarClave == null) {
			jButtonCambiarClave = new JButton();
			jButtonCambiarClave.setBounds(new Rectangle(65, 131, 154, 35));
			jButtonCambiarClave.setIcon(new ImageIcon(getClass().getResource("/Iconos/Save.png")));
			jButtonCambiarClave.setText("Cambiar Clave");
			jButtonCambiarClave.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					if(jComboBoxUsuarios.getSelectedItem().toString().length()!=0 && jPasswordFieldPassword.getPassword().length!=0){
					ABM abm=new ABM();
					String pass=String.valueOf(jPasswordFieldPassword.getPassword());
					String usr=(String) jComboBoxUsuarios.getSelectedItem();
					String ruta="C:\\TFHHELD\\USRS\\USRS.txt";
					boolean borradoOk;
					boolean creadoOK;
					
					borradoOk=abm.borrarUsuario(usr, ruta);
					creadoOK=abm.crearUsuario(usr, pass, ruta);
					if(borradoOk==creadoOK && creadoOK==true){
						JOptionPane.showMessageDialog(null, "Usuario modificado ok!");
						
					}else{
						JOptionPane.showMessageDialog(null, "No se puede modificar usuario porque no existe.");
					}
					}else{
						JOptionPane.showMessageDialog(null, "No se permiten campos vacíos...");
					}
				}
			});
			jButtonCambiarClave.addKeyListener(new java.awt.event.KeyAdapter() {
				public void keyPressed(java.awt.event.KeyEvent e) {
					if(e.getKeyCode()== KeyEvent.VK_ENTER){
						jButtonCambiarClave.doClick();
					}
				}
			});
		}
		return jButtonCambiarClave;
	}

}
