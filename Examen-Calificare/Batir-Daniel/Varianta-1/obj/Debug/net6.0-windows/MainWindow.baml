   M S B A M L   `   `   `  ����E  AVarianta-1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Varianta_1
Varianta_1  5   	   9!clr-namespace:Varianta_1.ControlsVarianta_1.Controls  5   	       Varianta_1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Varianta_1     5   	   2ctls!clr-namespace:Varianta_1.Controls     5   	     � Title$  Magazin Online��5	   	   $	��650��5
   	   $
��1000��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	    � 
ResizeMode$ NoResize=�5   	   $��Poppins)�5   	   .��5      �� -   5         ��Name$ mainForm��5         PrimaryBackgroundColor#���   5       J� 	AllowDrop$
 True��5       �� CornerRadius$ 5��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� $��0��6     SecundaryBackgroundColor#���  5      $ 8 0 0 8��5      ._�5       � -   5        	 �Name$	 GridNav��5       $��60��5!      
 � RowDefinitions
 5"      �� 5#      $��60 �6(   �� 5$      $��* �6(   .+�5'      � $��0��6   .+�5(      �� $��14 0 0 0q�6!   $��32��5)   !   $��24��5*   !   $
��Left=�5+   !   ��5,      �� 5-   "    �� ImageSource$ Resources/onlineshop.png��6-    j� Stretch$ Uniform=�5.   -   50      �� 52      $��Magazin Online��6      PrimaryTextColor#���  53       $
��Bold"�54       $��16(�55       $��Center=�56       $
��Left=�57       $��60 0 0 0q�58       59      �� 5<      $��1��6!   $��0q�5=   !   .+�5>      �� -   5         ��Name$ btnDashboard��5>   !     PopupButtonStyle#���  5?   !   $
��Left=�5@   !   .��5D      "   Varianta_1.Controls.MenuItem     	GroupName$ MenuItem��6,     PrimaryBlueColor   IndicatorBrush# �  5E   ,   $��Center=�5F   ,   .��5G   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5H   &   ��   	dashboard#���  6,   $��Center=�5I   ,   $��12 0 0 0q�5J   ,   �� 5K   &   $��	Dashboard��6,     TextMenu#��[ 5L   ,   $��Center=�5M   ,   $��12 0 0 0q�5N   ,   5O   #   5P      5Q      �� 5R      -   5        $ 
btnClienti��5R   !   #���  5S   !   $
��Left=�5T   !   .��5X        $ MenuItem��6,   # �  5Y   ,   $��Center=�5Z   ,   .��5[   "   �� $ 
Horizontal=�6-   .+�5\   &   ��  	 users#���  6,   $��Center=�5]   ,   $��12 0 0 0q�5^   ,   �� 5_   &   $��Clienti��6,   #��[ 5`   ,   $��Center=�5a   ,   $��12 0 0 0q�5b   ,   5c   #   5d      5e      �� 5f      -   5        $ 
btnComenzi��5f   !   #���  5g   !   $
��Left=�5h   !   .��5l        $ MenuItem��6,   # �  5m   ,   $��Center=�5n   ,   .��5o   "   �� $ 
Horizontal=�6-   .+�5p   &   ��   products#���  6,   $��Center=�5q   ,   $��12 0 0 0q�5r   ,   �� 5s   &   $��Comenzi��6,   #��[ 5t   ,   $��Center=�5u   ,   $��12 0 0 0q�5v   ,   5w   #   5x      5y      5z      � 5~      -   5         �Name$ Popup��5~       � AllowsTransparency$
 True��5       � HorizontalOffset$ 0��5�       � VerticalOffset$ 10��5�      .��5�      #   Varianta_1.Controls.UserPopup  -   5          Name$ Header��5�   )   #���  5�   )   5�      5�      5�      � 5�      $��1��6   
 5�      �� 5�      $��47 �6$   �� 5�      .+�5�      �� -   5        #���   5�      .+�5�      d� -	   5         d�Name$ Tg_Btn��5�   #    	 iToggleButtonStyle#��� 	 5�   #   $
��Left=�5�   #   $��0q�5�   #   
������ $��	10,10,0,0q�5�   #   $��30��5�   #    � Triggers 5�      :� 5�       :� RoutedEvent$ ToggleButton.Unchecked��6+   .[�5�   "   �� .��5�   &   �� -
   5         ��Name$ HideStackPanel��5�   1   .��5�   *   W�  �� 
TargetName$ GridNav��6:    �� TargetProperty$ Width�5�   :    g� 	BeginTime	 0:0:05�   :    W� From 2105�   :   	 W� To 605�   :    g� Duration$ 0:0:0.5D�5�   :   5�   +   5�   '   5�   #   5�      :� 5�      $ ToggleButton.Checked��6+   .[�5�   "   �� .��5�   &   �� -   5        $ ShowStackPanel��5�   1   .��5�   *   W� $ GridNav��6:   $ Width�5�   :   	 0:0:05�   :    605�   :    2105�   :   $ 0:0:0.5D�5�   :   5�   +   5�   '   5�   #   5�      5�      �� 5�      $��Right=�6!   $��30��5�   !   $��
0 -30 10 0q�5�   !   $ 
Horizontal=�5�   !   $��RightToLeft=�5�   !   $��85��5�   !   .+�5�      �� -   5        $ btnClose��5�   !    
 IconButtonsStyle#��[
 5�   !    	 close#���  5�   !   
  � Tag$  IsCloseButton��5�   !   �� 5�      -   5        $ 
btnRestore��5�   !   $	��5,0q�5�   !   ��5�      �� 5�   "   ! �� 
TargetType"! ��6(   " �� BasedOn#" [
 5�   (   .�5�   &   �� # �� Property# � ��  maximize$ �� Value#$ �  5�   -   % �� Triggers% 5�   &   5�   #   5�      �� 5�      -   5        $ btnMinimize��5�   !   #��� 
 5�   !     minimize#���  5�   !   5�   !   5�      5�       � 5�      -   5        $��
fContainer��5�      $��1��5�      $��20,20,20,20q�5�      &  � NavigationUIVisibility$& Hidden=�5�      5�      5�      5�      5�      5�      