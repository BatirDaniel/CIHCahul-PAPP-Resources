   M S B A M L   `   `   `  ����D  @CircleApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CircleApp	CircleApp  5   	       CircleApp.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:CircleApp     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Aplcaitie cerc��5	   	   $	��450��6    $	��800��6-   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $#��Welcome to Circle Application��6   
��� � � �� TextAlignment$ Center=�5      $��25(�5      $
��Bold"�5      $��0��5      $��3��5      �� 5   
   -   5        $��editRaza��5      $��0��5      $��1��5       $��25(�5!      $��10 20 10 20q�5"      �� 5$   
   -   5        $��btnDetermina��5$      $��	Calculate��5%      $��25(�5&      $
��Bold"�5'      $��1��5(      
��� � �
�������$��1��5+      $��10 20 10 20q�5,      5-      �� 5/   
   -   5        $��btnSave��5/      $��Save in file��50      $��25(�51      $
��Bold"�52      $��1��53      
����d�
�������$��2��56      $��10 20 10 20q�57      58      &   System.Windows.Controls.DataGrid  5:   
   -   5          Name$ dataGrid��5:      $��2��5;      $��3��5<      $��10q�5=         AutoGenerateColumns$ False��5>         Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5@      ,  &System.Windows.Controls.DataGridColumn   Header$
 Raza��6>   	   MinWidth$		 140Q�6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *Raza+6L     5A      $ Lungime��6[   $		 140Q�6l   
 6%   �� *lungimeCerc+ �� StringFormat$ 0.###��6l     5B      $
 Aria��6X   $		 140Q�6f   
 6%   �� *
arieCerc+$ 0.###��6f   5D      5E      5F      