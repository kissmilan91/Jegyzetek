   M S B A M L   `   `   `  ����M  I20220209_Butorbolt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:_20220209_Butorbolt_20220209_Butorbolt  5   	   (    "_20220209_Butorbolt.ButorReszletek   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:_20220209_Butorbolt     5   	     � Title$  ButorReszletek��5   	   $	��450��6    $	��800��6-   $��16(�69   .��5	      � $��10q�6    � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��40 �6   .+�5   
   �� $��Megnevezés��6   $��0��6%   $��0��62   $��Center=�6B   �� 5   
   $��	Alapanyag��6   $��1��6$   $��0��61   $��Center=�6A   �� 5   
   $��Szállítás��6   $��2��6$   $��0��61   $��Center=�6A   �� 5   
   $	��Ár��6   $��3��6   $��0��6*   $��Center=�6:   �� 5   
   $��Szín��6   $��4��6   $��0��6,   $��Center=�6<   �� 5   
   -   5         ��Name$ tbNev��5      $��0��6!   $��1��6.   $��30��6>   ��6J   �� *Nev+�� 5   
   -   5        $��cbAlapanyag��5      $��1��6&   $��1��63   $��30��6C    �� DisplayMemberPath$	 Nev��5       �� SelectedValuePath$ ID��6+    �� SelectedValue 5   O   �� *Alapanyag_ID+5   +   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��dpSzallitas��5      $��2��6(   $��1��65   $��30��6h      SelectedDate 6E   �� *	Szallitas+6h   �� 5    
   -   5        $
 tbAr��5       $��3��6    $��1��6-   $��30��6=   ��6I   �� *Ar+�� 5!   
   -   5        $ tbSzin��5!      $��4��6"   $��1��6/   $��30��6?   ��6K   �� *Szin+�� 5#   
   -   5         ��Name$ 	btnMentes��5#      $��5��6$   $��0��61   $��Mentés��6A   $
��10,0q�6R   6`   �� 5$   
   -   5        $ 
btnMegesem��5$      $��5��6%   $��1��62   $��Mégsem��6B   $
��10,0q�6S   6a   5&      5'      