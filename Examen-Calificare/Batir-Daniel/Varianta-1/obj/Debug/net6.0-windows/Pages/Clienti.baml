   M S B A M L   `   `   `  ����E  AVarianta-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Varianta_1.PagesVarianta_1.Pages  5      ;"clr-namespace:Varianta_1.ConverterVarianta_1.Converter  5      K*clr-namespace:Varianta_1.ViewModels.ClientVarianta_1.ViewModels.Client  5          Varianta_1.Pages.Clienti   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Varianta_1.Pages     5      5local1"clr-namespace:Varianta_1.Converter     5      =local2*clr-namespace:Varianta_1.ViewModels.Client     5        N� Title$  Clienti��5       � DataContext 5      2   ,Varianta_1.ViewModels.Client.ClientViewModel  5   
    � 	Resources 5      4   .Varianta_1.Converter.TextToVisibilityConverter   TextToVisibilityConverter �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Styles/ClientStyle.xaml?�6%   %   &	          5      6/   5      .��5      ��  �� CornerRadius$ 5��6     SecundaryBackgroundColor#���  5      ._�5   
   � $��1��6   $��30 20 20 20q�5       � RowDefinitions 5       �� 5!      $
��auto �6    �� 5"      $
��auto �6    �� 5#      $
��auto �6    �� 5$      $
��auto �6    �� 5%      $
��auto �6    �� 5&      $��* �6    �� 5'      $
��auto �6    .+�5+      �� $��Clienti��6   $��0��5,      $��32(�5-      $��SemiBold"�5.      $��0 20 0 0q�5/      
�������$
��Left=�51      �� 54      -   5          	addButton#��[ 54      $��0��56      .��57      ��  �� Orientation$ 
Horizontal=�6   .+�58      �� $��Add new Client��6    59      5:      �� 5=      $��1��6   $��2��5>      ���#DAE2EA$��	0 -1 0 10q�5@      
�������$��1q�5B      �� 5E      $��1��6   $ 
Horizontal=�5F      $��0 10 0 0q�5G      .+�5H      �� -   5          	tabButton#��[ 5H      $��Clients List��5I      $��90��5K      
����+��5L      �� 5M      #��[ 6   $$��Clients with the maximum order��5N      $	��210��5O      �� 5P      #��[ 6   $��Archived��5Q      $��85��5R      5S      �� 5V      $��Clients List��6   $��4��5W      $��14(�5X      $��SemiBold"�5Y      
�������$
��Left=�5[      $��Center=�5\      �� 5^      $��	Filter by��6   $��4��5_      $��16(�5`      $��SemiBold"�5a      $��	0 0 265 0q�5b      
�������$��Right=�5d      $��Center=�5e      � 5h      $	��250��6   $��Right=�5i      $��4��5j      .+�5k      �� $
��15 0q�6   $��Center=�5l      
������� J� IsHitTestVisible$ False��5n      	 K� ZIndex$	 1��5o      $��Search in clients ...��5p      y�5q      �� 
 �� ElementName$
 textBoxFilter�� �� Path$
 Text� �� 	Converter# [  �� 5s      -   5        $��textBoxFilter��5s        filterTextBox#��[ 5t      
���   �5u      5v      &   System.Windows.Controls.DataGrid  5y      -   5          Name$ clientsDataGrid��5~      $��0 20 0 0q�5y      $��5��5z        DataGridRowStyle1   RowStyle# �  5{        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5|        DataGridCellStyle1   	CellStyle# �  5}         SelectionMode$ Single=�5�        DataGridStyle1#���  5�      ��5      �� *	Clients+ �� SelectedItem 5�      �� *SelectedClient+   Columns 5�      4  .System.Windows.Controls.DataGridCheckBoxColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ C��6-      CanUserResize$ False��5�   -      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 5�   -    	 CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [	 5�   -      HeaderTemplate 5�      �� 5�      .R�5�   "   �� #��[	 6+   5�      5�      0  *System.Windows.Controls.DataGridTextColumn  5�      $ #��6)   $ False��5�   )   $
 auto 5�   )      Binding 5�   )   �� *	CodClient+4	  .System.Windows.Controls.DataGridTemplateColumn	  5�      $
 Nume��6-   $ * 5�   -    	  CellTemplate 5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $��25��6-   $��25��5�   -   $ 50��5�   -   $��0 0 10 0q�5�   -   ��5�   -   �� *	BgColor+._�5�   *   �� $��Center=�5�   4   $��Center=�5�   4   
�������$��0 0 0 1q�5�   4   ��5�   4   �� *	Character+5�   4   5�   '   �� 5�   &   $��Center=�5�   0   ��5�   0   �� *Nume+5�   0   5�   #   5�      5�      	  5�      $ Prenume��6-   $ * 5�   -    5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $��25��6-   $��25��5�   -   $ 50��5�   -   $��0 0 10 0q�5�   -   ��5�   -   �� *	BgColor+._�5�   *   �� $��Center=�5�   4   $��Center=�5�   4   
�������$��0 0 0 1q�5�   4   ��5�   4   �� *	Character+5�   4   5�   '   �� 5�   &   $��Center=�5�   0   ��5�   0   �� *	Prenume+5�   0   5�   #   5�      5�        5�      $ Adresa��6)   $ * 5�   )    5�   )   �� *Adresa+5�   )     5�      $ Email��6)   $ * 5�   )    5�   )   �� *Email+5�   )     5�      $ Telefon��6)   $ * 5�   )    5�   )   �� *	Telefon+5�   )   	  5�      $ 
Operations��6-   $
 auto 5�   !    5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   ��  
 gridEditButton#��[
 6-   $	����5�   -     FontAwesome#��[ 5�   -   ��5�   -   �� *UpdateCommand+��5�   -   �� $
 clientsDataGrid��$ SelectedItem�5�   '   �� 5�   &   $��5 0 0 0q�6-     gridRemoveButton#��[ 5�   -   $	����5�   -   #��[ 5�   -   ��5�   -   �� *RemoveCommand+��5�   -   �� $
 clientsDataGrid��$ SelectedItem�5�   '   5�   #   5�      5�      5�      �� 5�      $��6��6   $��Right=�5�      ���#DEE4EC$��1q�5�      $ 5��5�       �� Padding$ 5q�5�      ���#ffffff$��
0 10 10 10q�5�      ._�5�      �� $ 
Horizontal=�6   .+�5�      ��   pagingButton#��[ 6   5�      �� 5�      $��1��6    ���#DEE4EC$	��3 7q�5�       �� 5�      #��[ 6   $��1��5�      ���#7950F2���#ffffff5�      �� 5�      #��[ 6   $��2��5�      ���#6C76825�      �� 5      #��[ 6   $��3��5     �� 5     $	��...��6    ���#6C7682$��Center=�5      $
��10 0q�5      $��15(�5      �� 5	     #��[ 6   $��7��5
     �� 5     #��[ 6   $��8��5     �� 5     #��[ 6   $��9��5     �� 5     $��1��6    ���#DEE4EC$	��3 7q�5      �� 5     #��[ 6   5     5     5     5     5     5     