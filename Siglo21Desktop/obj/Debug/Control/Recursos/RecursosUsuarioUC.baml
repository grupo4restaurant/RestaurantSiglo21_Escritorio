   M S B A M L   `   `   `  ����I  ESiglo21Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Siglo21Desktop.Control.RecursosSiglo21Desktop.Control.Recursos  5      7    1Siglo21Desktop.Control.Recursos.RecursosUsuarioUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Siglo21Desktop.Control.Recursos     5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��0.5* �6   �� 5      $��3* �6   �� 5      $��1* �6   �� 5      $
��0.5* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��btnNuevo��5   W   $��30��6   $
��Left=�6!   $��Bottom=�6<   $	��100��6g    J� Opacity$
 0.75Q�6t   $��Nuevo��6�   6�   �� 5      -   5         ��Name$ 
btnRefresh��5   X   $��30��6   $��Right=�6!   $��Bottom=�6=   $
��auto��6l   $
 0.75Q�6z   $��	Refrescar��6�   $��	570,0,0,0q�6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg��5         AutoGenerateColumns .     
IsReadOnly . $��1��5      $��Visible=�5       ��5      �� *	Listado+ �� NotifyOnTargetUpdated .    Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID��5$      
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 5&         SortDirection$ 	AscendingX�5'      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5%      �� *
usuario_id+   HeaderTemplate 5(      �� 5)      .R�5*      �� $ Vertical=�6)   .+�5+   "   �� ��6,   �� *	Content+ �� RelativeSource ��  �� Mode$ TemplatedParent=��� 5-   "    ��Name$ txtId��6*   -   5        $	��100��5-   9   6E   5.      5/      51        53      $	 Nombre��54      $
 * 56      $ 	AscendingX�57       55      �� *nombre+ 58      �� 59      .R�5:      �� $ Vertical=�6)   .+�5;   "   �� ��6,   �� *	Content+ �� $ TemplatedParent=��� 5=   "   $ 	txtNombre��6*   -   5        $	��100��5=   =   6I   5>      5?      5A        5C      $	 Paterno��5D      $
 * 5F      $ 	AscendingX�5G       5E      �� *
ap_paterno+ 5H      �� 5I      .R�5J      �� $ Vertical=�6)   .+�5K   "   �� ��6,   �� *	Content+ �� $ TemplatedParent=��� 5M   "   $ 
txtPaterno��6*   -   5        $	��100��5M   >   6J   5N      5O      5Q        5S      $	 Materno��5T      $
 * 5V      $ 	AscendingX�5W       5U      �� *
ap_materno+ 5X      �� 5Y      .R�5Z      �� $ Vertical=�6)   .+�5[   "   �� ��6,   �� *	Content+ �� $ TemplatedParent=��� 5]   "   $ 
txtMaterno��6*   -   5        $	��100��5]   >   6J   5^      5_      5a        5c      $	 E-Mail��5d      $
 * 5f      $ 	AscendingX�5g       5e      �� *e_mail+ 5h      �� 5i      .R�5j      �� $ Vertical=�6)   .+�5k   "   �� ��6,   �� *	Content+ �� $ TemplatedParent=��� 5m   "   $ txtEmail��6*   -   5        $	��100��5m   <   6H   5n      5o      5q        5s      $	 	Teléfono��5t      $
 * 5v      $ 	AscendingX�5w       5u      �� *fono+ 5x      �� 5y      .R�5z      �� $ Vertical=�6)   .+�5{   "   �� ��6,   �� *	Content+ �� $ TemplatedParent=��� 5}   "   $ txtFono��6*   -	   5        $	��100��5}   ;   6G   5~      5      5�        5�      $	 Perfil��5�      $
 * 5�      $ 	AscendingX�5�       5�      �� *
rol_desc+ 5�      �� 5�      .R�5�      �� $ Vertical=�6)   .+�5�   "   �� ��6,   �� *	Content+ �� $ TemplatedParent=��� 5�   "   $ 	txtPerfil��6*   -
   5        $	��100��5�   =   6I   5�      5�      5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      $	 Acciones��6)      CellTemplate 5�      �� 5�      .R�5�      �� $ 
Horizontal=�6)   .+�5�   "   �� $��btnView��6)   -   5        $��Editar��5�   8   6I   �� 5�   "   $��	btnDelete��6)   -   5        $��Eliminar��5�   :   6M   5�      5�      5�      5�      �� 5�   
   $��4q�5�      $��2��5�      $ 
Horizontal=�5�      $��Center=�5�      .+�5�      �� $	��4,0q�5�      $��<<��5�      ��5�      �� *FirstCommand+�� 5�      $	��4,0q�5�      $��<��5�      ��5�      �� *PreviousCommand+�� 5�      $��Center=�5�      $ 
Horizontal=�5�      .+�5�      �� ��5�      �� *Start+�� 5�      $
�� to ��5�      �� 5�      ��5�      �� *End+�� 5�      $
�� of ��5�      �� 5�      ��5�      �� *
TotalItems+5�      �� 5�      $	��4,0q�5�      $��>��5�      ��5�      �� *NextCommand+�� 5�      $	��4,0q�5�      $��>>��5�      ��5�      �� *LastCommand+5�      � 5�   
   $��3��6   5�      5�      5�      