   M S B A M L   `   `   `  ����E  AVarianta-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Varianta_1.PagesVarianta_1.Pages  5      ;"clr-namespace:Varianta_1.ConverterVarianta_1.Converter  5      M+clr-namespace:Varianta_1.ViewModels.ComandaVarianta_1.ViewModels.Comanda  5          Varianta_1.Pages.Comenzi   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Varianta_1.Pages     5      5local1"clr-namespace:Varianta_1.Converter     5      >local2+clr-namespace:Varianta_1.ViewModels.Comanda     5        N� Title$  Comenzi��5       � DataContext 5      4   .Varianta_1.ViewModels.Comanda.ComandaViewModel  5   
    � 	Resources 5      4   .Varianta_1.Converter.TextToVisibilityConverter   TextToVisibilityConverter �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Styles/ComandaStyle.xaml?�6%   %   &	          5      6/   5      .��5      ��  �� CornerRadius$ 5��6     SecundaryBackgroundColor#���  5      ._�5   
   � $��1��6   $��30 20 20 20q�5       � RowDefinitions 5       �� 5!      $
��auto �6    �� 5"      $
��auto �6    �� 5#      $
��auto �6    �� 5$      $
��auto �6    �� 5%      $
��auto �6    �� 5&      $��* �6    �� 5'      $
��auto �6    .+�5+      �� $��Comenzi��6   $��0��5,      $��32(�5-      $��SemiBold"�5.      $��0 20 0 0q�5/      
�������$
��Left=�51      �� 54      -   5          	addButton#��[ 54      $��0��56      .��57      ��  �� Orientation$ 
Horizontal=�6   .+�58      �� $��Add new Order��6    59      5:      �� 5=      $��1��6   $��2��5>      ���#DAE2EA$��	0 -1 0 10q�5@      
�������$��1q�5B      �� 5E      $��1��6   $ 
Horizontal=�5F      $��0 10 0 0q�5G      .+�5H      �� -   5          	tabButton#��[ 5H      $��
Order List��5J      
����+��6.   �� 5K      #��[ 6   $ ��Order list ordered by date��5L      $	��180��5M      �� 5N      #��[ 6   $��Archived��5O      5P      �� 5S      $��
Order list��6   $��4��5T      $��18(�5U      $��SemiBold"�5V      
�������$
��Left=�5X      $��Center=�5Y      �� 5[      $��	Filter by��6   $��4��5\      $��16(�5]      $��SemiBold"�5^      $��	0 0 265 0q�5_      
�������$��Right=�5a      $��Center=�5b      � 5e      $	��250��6   $��Right=�5f      $��4��5g      .+�5h      �� $
��15 0q�6   $��Center=�5i      
������� J� IsHitTestVisible$ False��5k      	 K� ZIndex$	 1��5l      $��Search in orders ...��5m      y�5n      �� 
 �� ElementName$
 textBoxFilter�� �� Path$
 Text� �� 	Converter# [  �� 5p      -   5        $��textBoxFilter��5p        filterTextBox#��[ 5q      
���   �5r      5s      &   System.Windows.Controls.DataGrid  5v      -   5          Name$ comenziDataGrid��5{      $��0 20 0 0q�5v      $��5��5w        DataGridRowStyle1   RowStyle# �  5x        DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5y        DataGridCellStyle1   	CellStyle# �  5z        DataGridStyle1#���  5}      ��5|      �� *Orders+   Columns 5~      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ C��6-      CanUserResize$ False��5�   !      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 5�   !    	 CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [	 5�   !      HeaderTemplate 5�      �� 5�      .R�5�   "   �� #��[	 6+   5�      5�      0  *System.Windows.Controls.DataGridTextColumn  5�      $ #��6)      
IsReadOnly$
 True��5�      $ False��5�      $
 auto 5�         Binding 5�      �� *
CodComanda+ 5�      �� 5�       �� 
TargetType" ��6$   .�5�   "   ��  �� Property � �� �� Value$ Center=�6H   5�      5�      4	  .System.Windows.Controls.DataGridTemplateColumn	  5�      $ Data comenzii��6-   $
 True��5�   !   $ * 5�   !    	  CellTemplate 5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $��25��6-   $��25��5�   !   $ 50��5�   !   $��0 0 60 0q�5�   !   ��5�   !   �� *	BgColor+._�5�   *   �� $��Center=�5�   (   $��Center=�5�   (   
�������$��0 0 0 1q�5�   (   ��5�   4   �� *	Character+5�   (   5�   '   �� 5�   &   $��Center=�5�   $   $��Center=�5�   $   ��5�   0   �� *DataComanda+5�   $   5�   #   5�      5�      	  5�      $ Suma totala��6-   $
 True��5�   !   $ * 5�   !    5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   �� $��25��6-   $��25��5�   !   $ 50��5�   !   $��0 0 60 0q�5�   !   ��5�   !   �� *	BgColor+._�5�   *   �� $��Center=�5�   (   $��Center=�5�   (   
�������$��0 0 0 1q�5�   (   ��5�   4   �� *	Character+5�   (   5�   '   �� 5�   &   $��Center=�5�   $   $��Center=�5�   $   ��5�   0   �� *
SumaTotala+5�   $   5�   #   5�      5�      	  5�      $ 
Operations��6-   $
 auto 5�   !    5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   .+�5�   &   ��  
 gridEditButton#��[
 6-   $	����5�   -     FontAwesome#��[ 5�   -   ��5�   -   �� *UpdateCommand+��5�   -   �� $
 clientsDataGrid��$ SelectedItem�5�   '   �� 5�   &   $��5 0 0 0q�6-     gridRemoveButton#��[ 5�   -   $	����5�   -   #��[ 5�   -   ��5�   -   �� *RemoveCommand+��5�   -   �� $
 clientsDataGrid��$ SelectedItem�5�   '   5�   #   5�      5�      5�      �� 5�      $��6��6   $��Right=�5�      ���#DEE4EC$��1q�5�      $ 5��5�       �� Padding$ 5q�5�      ���#ffffff$��
0 10 10 10q�5�      ._�5�      �� $ 
Horizontal=�6   .+�5�      ��   pagingButton#��[ 6   5�      �� 5�      $��1��6    ���#DEE4EC$	��3 7q�5�       �� 5�      #��[ 6   $��1��5�      ���#7950F2���#ffffff5�      �� 5�      #��[ 6   $��2��5�      ���#6C76825�      �� 5�      #��[ 6   $��3��5�      �� 5�      $	��...��6    ���#6C7682$��Center=�5�       $
��10 0q�5�       $��15(�5       �� 5     #��[ 6   $��7��5     �� 5     #��[ 6   $��8��5     �� 5     #��[ 6   $��9��5     �� 5	     $��1��6    ���#DEE4EC$	��3 7q�5      �� 5     #��[ 6   5     5     5     5     5     5     