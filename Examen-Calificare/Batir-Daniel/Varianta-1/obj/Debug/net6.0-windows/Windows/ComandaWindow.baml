   M S B A M L   `   `   `  ����E  AVarianta-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Varianta_1.ViewModels.ComandaVarianta_1.ViewModels.Comanda  5   	   &     Varianta_1.Windows.ComandaWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local1+clr-namespace:Varianta_1.ViewModels.Comanda     5   	   -   5          � Title$  ComandaWindow��5   	   $	��450��6   $	��600��6,    � WindowStyle$ 
ToolWindow=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      4   .Varianta_1.ViewModels.Comanda.ComandaViewModel  5   
    � 	Resources 5         TextBlockStyle �� 
TargetType �� Property �� Value  TextBoxStyle  ComboBoxStyle  DatePickerStyle(  "System.Windows.Controls.DatePicker  	addButton �� 
TargetType	 �� CornerRadius
 �� Triggers P� Property P� Value��%�  &	        &	 �     &	 z    &	      &	 �    �� 5   
   " ��5      .�5      ��  � ��$ 18(�5      �� 5       � ��
 �����5      �� 5       � ��$ Center=�5      �� 5       � ��$ 40 0 0 0q�5      5      �� 5   
   " ��5       .�5!      ��  � ��$ 18(�5"      �� 5#       � ��$ 50��5$      �� 5%       � ��$ 30 0 0 0q�5&      5'      �� 5)   
   " ��5*      .�5+      ��  � ��$ 18(�5,      �� 5-       � ��$ 50��5.      �� 5/       � ��$ 30 0 0 0q�50      51      �� 53   
   "  54      .�55      ��  � ��$ 18(�56      �� 57       � ��$ 50��58      �� 59       � ��$ 30 0 0 0q�5:      5;      �� 5=   
   " ��5>      .�5?      ��  � �� �#ffffff5@      �� 5A       �@�FocusVisualStyle 5B      Z� �� 5C       � ��$ 35��5D      �� 5E       � ��$	 150��5F      �� 5G       � ��$ 0 20 0 0q�5H      �� 5I       � ��$ 16(�5J      �� 5K       � ��$ Right=�5L      �� 5M       � ��$ 1��5N      �� 5O       � �� 5P      �� 5Q      " ��6&   .R�5R      �� #��z��6!   $	 7��5S   !   ._�5T      �� $��Center=�6/   $��Center=�5U   /   5V      5W      5Y      
 5[      P� 5\       �@J�IsMouseOver$
 True��5]      . �5^      ��  � �� �#7B5CD65_      �� 5`       � �� �#ffffff5a      5b      5d      5e      .��5g      �� $	 5��6     SecundaryBackgroundColor#���  5h      ._�5i   
   � $��20q�6    � RowDefinitions 5j      �� 5k      �� 5l      �� 5n      �� 5o       � ColumnDefinitions 5r      �� 5s      $
��auto �6#   �� 5t      $��* �6#   .+�5w      �� $��Data comenzii : ��6   $��0��5x      #��[  5y      �� 5{      $��Suma : ��6   $��1��5|      #��[  5}      �� 5      $��	Client : ��6   $��2��5�      #��[  5�        5�      -   5        $��dataComenziTBX��5�      $��0��5�      $��1��5�      #��[ 5�         Text 5�      �� *SelectedComanda.DataComanda+5�      �� 5�      -   5        $��sumaTBX��5�      $��1��5�      $��1��5�      #��[ 5�      ��5�      �� *SelectedComanda.SumaTotala+5�      �� 5�      -   5        $��
clientName��5�      $��2��5�      $��1��5�      $	��320��5�      #��[ 5�       �� DisplayMemberPath$
 Nume��5�       �� SelectedValuePath$ 	CodClient��5�       �� Text 5�      �� *" SelectedComanda.Client.CodClient+��5�      �� *
_Clienti+ �� SelectedItem 5�      �� *SelectedComanda.Client.Nume+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedValue 5�      �� *" SelectedComanda.Client.CodClient+$ PropertyChanged=��� 5�      #��[ 6   $
��Save��5�      $��0��5�      $��5��5�      $	��200��5�      
��� � ���5�      �� *
AddCommand+5�      �� 5�      -   5        #��[ 5�      $��Cancel��5�      
���  ��$
��Left=�5�      $��
105 20 0 0q�5�      $��5��5�      $	��200��5�      $��1��5�      5�      5�      5�      