   M S B A M L   `   `   `  ����P  L20220216_Papirgyujtes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:_20220216_Papirgyujtes.Pages_20220216_Papirgyujtes.Pages  5      /    )_20220216_Papirgyujtes.Pages.PageUjLeadas   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:_20220216_Papirgyujtes.Pages     5        N� Title$  PageUjLeadas��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��Leadott mennyiségek��6   $��32(�6.   $
��Bold"�6<   �� 5   
   -   5         ��Name$ gbSzuro��5   "   $��Szürő��6   $��1��63   $��5q�6@   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��	Osztály:��6   �� 5      -   5         ��Name$ 
cboOsztaly��5      $��50��6/   6:   �� 5      $��Tanuló:��6   �� 5      -   5        $ 	cboTanulo��5      $	��150��6.   6:   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgMennyisegek��5      $��2��6*      AutoGenerateColumns$ False��67      
IsReadOnly$
 True��6S      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Mennyiség��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 6o   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *	mennyiseg+ �� StringFormat$ {0} dkg.��6o   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 Dátum��6)   $	
 100 68      CellTemplate 5      �� 5       .R�5!      (  "System.Windows.Controls.DatePicker  $��0q�6c      SelectedDate 6)   �� *	idopont+$ 
yyyy.MM.dd��6c   5"      5$      5&      �� 5'   
   $��Új szállítás��6   $��3��6)   $��5q�66   .��5(      �� $ 
Horizontal=�6   .+�5)      �� $��Mennyiség:��6   �� 5*      -   5         ��Name$ tbMennyiseg��5*      $��50��6/   �� 5+      $��Dátum:��6   $��10,0,0,0q�6)     5,      -   5        $��dpDatum��5,      $	��120��6,   �� 5-      -   5         ��Name$ btnLead��5-      $
��Lead��6*   $
��15,0q�69   $��10,0,0,0q�6H   6Z   5.      5/      50      51      