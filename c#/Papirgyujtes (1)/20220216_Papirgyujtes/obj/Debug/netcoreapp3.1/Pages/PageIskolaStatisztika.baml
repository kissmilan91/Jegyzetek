   M S B A M L   `   `   `  ����P  L20220216_Papirgyujtes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:_20220216_Papirgyujtes.Pages_20220216_Papirgyujtes.Pages  5      8    2_20220216_Papirgyujtes.Pages.PageIskolaStatisztika   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:_20220216_Papirgyujtes.Pages     5        N� Title$  PageIskolaStatisztika��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��Iskola statisztika��6   $��32(�6-   $
��Bold"�6;   $��10q�6M   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgStatisztika��5       $��1��6      AutoGenerateColumns$ False��67      
IsReadOnly$
 True��6S   $��10q�6e      AlternatingRowBackground
 �����   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Osztály��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	osztaly+  5      $ Összes mennyiség��6%    6?   �� *osszes+	 �� StringFormat$	 {0} dkg��  5      $ Legkevesebb��6%    6:   �� *legkevesebb+$	 {0} dkg��  5      $ Legtöbb��6%    66   �� *	legtobb+$	 {0} dkg��  5      $ Leadások száma��6%    6=   �� *darab+$	 {0} db��5      �� 5   
   -   5        
 ��Name$
 	tblOsszeg��5   !   $��2��6   $��Összesen: ��64   $��20(�6F   $
��Bold"�6T   $��10q�6f   5      5      