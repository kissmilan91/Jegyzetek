   M S B A M L   `   `   `  ����M  I20220209_Butorbolt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:_20220209_Butorbolt_20220209_Butorbolt  5   	   $    _20220209_Butorbolt.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:_20220209_Butorbolt     5   	     � Title$  
Bútorbolt��5   	   $	��400��6   $	��600��6(   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� $��Keresés��6   $��10q�6$   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Név:��6   �� 5      -   5         ��Name$ tbNevKereso��5      $	��200��6/   $
��10,0q�6;   �� 5      -   5         ��Name$ btnKeres��5      $��Keres��6+   $
��10,0q�6;   6J   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dgButorok��5      $��1��6&   $
��0,10q�63      AutoGenerateColumns$ False��6A      
IsReadOnly$
 True��6]      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Név��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 150 6J   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Nev+6J     5      $		 Ár��6%    61   �� *Ar+  5      $	 Szín��6%    63   �� *Szin+4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 Szállítás��6)      CellTemplate 5      �� 5      .R�5       (  "System.Windows.Controls.DatePicker  $��0q�6L      SelectedDate 6)   �� *	Szallitas+6L   5!      5#        5$      $	 	Alapanyag��6%    68   �� *AlapanyagNev+5'      �� 5)   
   $ 
Horizontal=�6   $��2��6.   $��Center=�6;   .+�5*      �� -   5        $ 
btnUjButor��5*      $��
Új bútor��6)   $	��100��6<   $
��10,0q�6H   6V   �� 5+      -   5        $ btnButorSzerkeszt��5+      $��Szerkesztés��60   $	��100��6F   $
��10,0q�6R   6`   �� 5,      -   5        $ btnButorTorol��5,      $��Törlés��6,   $	��100��6=   $
��10,0q�6I   6W   5-      5.      5/      