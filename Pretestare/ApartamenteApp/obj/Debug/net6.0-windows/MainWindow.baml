   M S B A M L   `   `   `  ����I  EApartamenteApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ApartamenteAppApartamenteApp  5   	       ApartamenteApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ApartamenteApp     5   	     � WindowStartupLocation$  CenterScreen=�5   	   
����d�
�������$��18(�5   	    � Title$ Apartamente��5   	   $	��700��5   	   $	��900��5   	    � 	Resources 5      ,   &ApartamenteApp.InverseBooleanConverter   InverseBooleanConverter �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%�  &	        '��      '�� �     '�� 	    '�� �      5   
   6(   �� 5   
   " ��6   .�5      ��  � ��$ 10q�5      �� 5       � ��$ 	0 10 0 10q�5      5      �� 5   
   " ��6   .�5      ��  � ��$ 10q�5      �� 5       � ��$ 	0 10 0 10q�5      5      �� 5   
   " ��6   .�5      ��  � ��$ 10q�5       �� 5!       �@��Padding$ 	0 10 0 10q�5"      5#      �� 5%   
   " ��6   .�5&      ��  � ��$ 10q�5'      �� 5(       � ��$ 2q�5)      �� 5*       � ��
 �����5+      �� 5,       � ��
 ��d�5-      �� 5.       � ��$
 Bold"�5/      �� 50       � ��
 ��d�51      �� 52       � �� 53      �� 54      " ��6&   .R�55      �� $ 12��6!   #��z��56   !   ._�57      �� $��Center=�6/   $��Center=�58   /   #��z��59   /   5:      5;      5=      5>      5?      .��5A      ]� .+�5B   
   �� $	��Top=�6    �� Orientation$ Vertical=�5C      5D      �� 5F   
   $ Vertical=�6   $
��Left=�5G      
����  �$	��250��5I      $
��Left=�5J      .+�5L      �� -   5        $��btnAddAgent��5M      $��Adauga agent��5L      5N      �� 5P      -   5        $��btnDisplayAgent��5Q      $��Afiseaza agenti��5P      5R      �� 5T      -   5        $��btnAddApartament��5U      $��Adauga apartament��5T      5V      �� 5X      -   5        $��btnDisplayApartament��5Y      $��Afiseaza apartamente��5X      5Y      �� 5[      -   5        $��btnOperationOne��5[      .��5]      �� $D��>Lista apartamentelor cu patru camere aflate la etajele 2 și 3��6   $
��Wrap=�5^      $��15(�5_      	 �� TextAlignment$	 Center=�5`      5a      �� 5c      -   5        $��btnOperationTwo��5c      .��5e      �� $Q��KLista agenților cu telefon și vârstă cuprinsă în diapazonul 20 – 30��6   $
��Wrap=�5f      $��15(�5g      $	 Center=�5h      5i      �� 5k      -   5        $��btnOperationThree��5k      .��5m      �� $Q��KLista agenților și suma totală de vânzări acumulată de fiecare din ei��6   $
��Wrap=�5n      $��15(�5o      $	 Center=�5p      5q      5r      �� 5t   
   $��Bottom=�6   5u      �� 5w   
   .+�5x      �� -   5        
 ��Name$
 gbAddAgenti��5x      $��Agent��5y      $��10q�5z      $��5q�5{      $y�	Collapsed=�5|      .��5}      �  � ColumnDefinitions 5~      �� 5      $
��auto �6+   �� 5�      $��* �6+    � RowDefinitions 5�      �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   .+�5�      �� $��Nume :��6    $��0��5�       $��0��5�       �� 5�      -	   5         ��Name$ tbxNume��5�      $��0��5�      $��1��5�      �� 5�      $��	Prenume :��6    $��1��5�       $��0��5�       �� 5�      -
   5        $ 
tbxPrenume��5�      $��1��5�      $��1��5�      �� 5�      $��Varsta :��6    $��2��5�       $��0��5�       �� 5�      -   5        $ 	tbxVarsta��5�      $��2��5�      $��1��5�      �� 5�      $��	Telefon :��6    $��3��5�       $��0��5�       �� 5�      -   5        $ 
tbxTelefon��5�      $��3��5�      $��1��5�      �� 5�      $��4��6"   $��2��5�   "   $��Center=�5�   "   $ 
Horizontal=�5�   "   $��0 20 0 0q�5�   "   .+�5�      �� -   5        $��btnSaveAgent��5�   !   $
��Save��5�   !   
��� � �$	��250��5�   !   $
��Bold"�5�   !   $��20(�5�   !   $��5q�5�   !   $��5q�5�   !   
�������{�5�   !   ��  �� ElementName$ 	tbxVarsta�� �� Path$ (Validation.HasError)� �� 	Converter# [  5�   !   �� 5�      -   5        $��btnCancelAgent��5�   !   $��Cancel��5�   !   
���  ��$	��250��5�   !   $
��Bold"�5�   !   $��20(�5�   !   $��5q�5�   !   $��5q�5�   !   
�������5�   !   5�      5�      5�      �� 5�      -   5        $
 gbAddApartamente��5�      $��
Apartament��5�      $��10q�5�      $��5q�5�      .��5�      �  5�      �� 5�      $
��auto �6+   �� 5�      $��* �6+    5�      �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   �� 5�      $
��auto �6(   .+�5�      �� $��Etaj :��6    $��0��5�       $��0��5�       �� 5�      -   5        $ tbxEtaj��5�      $��0��5�      $��1��5�      �� 5�      $��Numar camere :��6    $��1��5�       $��0��5�       �� 5�      -   5        $ tbxNrCamere��5�      $��1��5�      $��1��5�      �� 5�      $��Pret :��6    $��2��5�       $��0��5�       �� 5�      -   5        $ tbxPret��5�      $��2��5�      $��1��5�      �� 5�      $��Metri patrati :��6    $��3��5�       $��0��5�       �� 5�      -   5        $ tbxMetriPatrati��5�      $��3��5�      $��1��5�      �� 5�      $��Nume agent :��6    $��4��5�       $��0��5�       �� 5�      -   5         ��Name$ cbNumeAgent��5�       �� SelectedValuePath$ CodAgent��5�      $��4��5�      $��1��5�      ��5�      �� *Agenti+ �� SelectedValue 5�      �� *Apartamente.CodAgent+��5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   .+�5   &   �� $��50��60   ��5  0   �� $
 Nume��� 5  &   $��50��60   ��5  0   �� $ Prenume�5  #   5     5     �� 5	     $��5��6"   $��2��5
  "   $��Center=�5  "   $ 
Horizontal=�5  "   $��0 20 0 0q�5  "   .+�5     �� -   5        $��btnSaveApartament��5  !   $
��Save��5  !   
��� � �$	��250��5  !   $
��Bold"�5  !   $��20(�5  !   $��5q�5  !   $��5q�5  !   
�������5  !   �� 5     -   5        $��btnCancelApartament��5  !   $��Cancel��5  !   
���  ��$	��250��5  !   $
��Bold"�5  !   $��20(�5  !   $��5q�5  !   $��5q�5   !   
�������5"  !   5#     5$     5%     5&     5(     5*     