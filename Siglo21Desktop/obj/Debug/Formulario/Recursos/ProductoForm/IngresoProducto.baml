   M S B A M L   `   `   `  ����I  ESiglo21Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:Siglo21Desktop.Formulario.Recursos.ProductoForm/Siglo21Desktop.Formulario.Recursos.ProductoForm  5   	   E    ?Siglo21Desktop.Formulario.Recursos.ProductoForm.IngresoProducto   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Olocal=clr-namespace:Siglo21Desktop.Formulario.Recursos.ProductoForm     5   	     � Title$  IngresoProducto��5   	   $	��450��6!   $	��800��6.   .��5	      � $��50q�6    � ColumnDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��1* �6   .+�5   
   �� .��6   	Nombre:6   �� 5   
   -   5         ��Name$ 	txtNombre��5   4   $��1��6   $��0,0,0,10q�6"   64   �� 5   
   $��1��6   .��6   
Código:6'   �� 5   
   -   5        $ txtCod��5    $   $��1��5      $��1��6   $��0,0,0,10q�5       6$   �� 5#   
   $��2��6   .��6   
Catálogo:6(   �� 5$   
   -   5         ��Name$ 
CatalogoCB��5$   0   $��2��6   $��1��6    ��5%      �� 5&      .R�5'      ��  �� Orientation$ 
Horizontal=�6!   .+�5(      �� ��6$   �� *nombre+5)      5*      5,      �� 5.   
   $��3��6   .��6   
Proveedor:6)   �� 5/   
   -   5        $ ProveedorCB��5/   0   $��3��6   $��1��6    ��50      �� 51      .R�52      �� $ 
Horizontal=�6!   .+�53      �� ��6$   �� *nombre+54      55      57      �� 59   
   $��4��6   .��6   Valor:6%   �� 5:   
   -   5        $ txtValor��5:   /   $��4��6   $��1��6   6/   �� 5=   
   $��6��6   $��2��6"   $ 
Horizontal=�66   $��Center=�5>      $��Bottom=�6*   .+�5?      �� -   5        $��Guardar��5?      6'   5@      5A      5B      