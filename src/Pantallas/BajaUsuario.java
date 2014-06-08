package Pantallas;

import java.awt.BorderLayout;
import javax.swing.JPanel;
import javax.swing.JFrame;
import java.awt.Toolkit;
import javax.swing.JComboBox;
import java.awt.Rectangle;
import javax.swing.JLabel;
import javax.swing.JButton;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;

import Clases.ABM;
import Clases.LeerArchivo;

import java.awt.Color;
import java.awt.event.KeyEvent;
import java.util.ArrayList;

@SuppressWarnings("unused")
public class BajaUsuario extends JFrame {

	private static final long serialVersionUID = 1L;
	private JPanel jContentPane = null;
	private JComboBox<String> jComboBoxUsuarios = null;
	private JLabel jLabelUsrs = null;
	private JButton jButtonBorrar = null;

	/**
	 * This is the default constructor
	 */
	public BajaUsuario() {
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
		this.setTitle("Baja de usuarios");
		inicializarUsuarios();
		setResizable(false);
		
		
	}

	/**
	 * This method initializes jContentPane
	 * 
	 * @return javax.swing.JPanel
	 */
	private JPanel getJContentPane() {
		if (jContentPane == null) {
			jLabelUsrs = new JLabel();
			jLabelUsrs.setBounds(new Rectangle(49, 7, 192, 21));
			jLabelUsrs.setForeground(Color.white);
			jLabelUsrs.setText("Usuarios");
			jContentPane = new JPanel();
			jContentPane.setLayout(null);
			jContentPane.setBackground(new Color(103, 135, 175));
			jContentPane.add(getJComboBoxUsuarios(), null);
			jContentPane.add(jLabelUsrs, null);
			jContentPane.add(getJButtonBorrar(), null);
		}
		return jContentPane;
	}
	private void inicializarUsuarios(){
		try{
			jComboBoxUsuarios.removeAllItems();
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
	 * This method initializes jComboBoxUsuarios	
	 * 	
	 * @return javax.swing.JComboBox	
	 */
	private JComboBox<String> getJComboBoxUsuarios() {
		if (jComboBoxUsuarios == null) {
			jComboBoxUsuarios = new JComboBox<String>();
			jComboBoxUsuarios.setBounds(new Rectangle(47, 31, 198, 30));
		}
		return jComboBoxUsuarios;
	}

	/**
	 * This method initializes jButtonBorrar	
	 * 	
	 * @return javax.swing.JButton	
	 */
	private JButton getJButtonBorrar() {
		if (jButtonBorrar == null) {
			jButtonBorrar = new JButton();
			jButtonBorrar.setBounds(new Rectangle(73, 95, 151, 39));
			jButtonBorrar.setIcon(new ImageIcon(getClass().getResource("/Iconos/Delete.png")));
			jButtonBorrar.setText("Eliminar");
			jButtonBorrar.addActionListener(new java.awt.event.ActionListener() {
				public void actionPerformed(java.awt.event.ActionEvent e) {
					String ruta="C:\\TFHHELD\\USRS\\USRS.txt";
					String usuario=(String) jComboBoxUsuarios.getSelectedItem();
					ABM abm=new ABM();
					if(abm.borrarUsuario(usuario, ruta)==true){
						JOptionPane.showMessageDialog(null, "Borrado exitoso!");
						
						inicializarUsuarios();
					}
					
				}
			});
			jButtonBorrar.addKeyListener(new java.awt.event.KeyAdapter() {
				public void keyPressed(java.awt.event.KeyEvent e) {
					if(e.getKeyCode()== KeyEvent.VK_ENTER){
						jButtonBorrar.doClick();
					}
				}
			});
		}
		return jButtonBorrar;
	}

}
