   M S B A M L   `   `   `  ����P  L20220216_Papirgyujtes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:_20220216_Papirgyujtes.Pages_20220216_Papirgyujtes.Pages  5      9    3_20220216_Papirgyujtes.Pages.PageOsztalyStatisztika   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:_20220216_Papirgyujtes.Pages     5        N� Title$  PageOsztalyStatisztika��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   .+�5      �� $��Osztály statisztika��6   $��32(�62   $
��Bold"�6@   �� 5      $��	Osztály:��6   $��Center=�6'   $��20,0,0,0q�6B   �� 5      -   5         ��Name$ 
cboOsztaly��5      $��25��6+   $��60��67   $��5,0,0,0q�6B   6S   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgStatisztika��5      $��1��6*   $��10q�67      AutoGenerateColumns$ False��6C      
IsReadOnly$
 True��6_      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Név��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 150 62   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6>   �� *nev+  5      $ 
Mennyiség��6%   $		 100 68   
 6D   �� *tanuloOsszesMennyiseg+ �� StringFormat$ {0} dkg.��5      �� 5   
   -   5         ��Name$ 	tblOsszeg��5      $��Összesen: ��6'   $��2��69   $
��Bold"�6F   $��20(�6X   $��10q�6f   5      5       