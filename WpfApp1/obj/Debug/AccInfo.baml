   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.AccInfo   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  AccInfo��5	   	   $	��625��6   $	��500��6&    � WindowStyle$
 None=�62    � Icon$ Assests\Logo(1).ico��6E    � WindowStartupLocation$ CenterScreen=�6`    � 
ResizeMode$ CanMinimize=�6�    � Triggers 5
      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  W� From$ 0X�6&   	 W� To$ 1X�6/   	 g� Duration$	 0:0:1D�66   
 �� TargetProperty$
 Opacity�6G   5      5      5      5      .��5      � .+�5   
   �� $	��625��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ #C5E1A5��6#   � 5      $ #33691E��6#    � Offset$ 1Q�63   � 5      $ #8BC34A��6#   $	 0.5Q�63   5      5!      �� 5"   
   $	��510��6   
�������$��Bottom=�6.    �� RadiusY$
 14.5��6I    �� RadiusX$
 14.5��6X   $��
20,0,34,62q�6g    J� Effect 5#      3  -System.Windows.Media.Effects.DropShadowEffect  5$         Color$ 	#FFBBBBBB��6#      
BlurRadius$ 15Q�65      	Direction$ 0Q�6E      RenderingBias$ Quality=�6S      ShadowDepth$ 1Q�6k   5&      �� 5'   
   $��Assests/Logo.png��6   $	��111��6*   $	��Top=�67   $��346,10,-30,0q�6O    5(        5)      $ 	#FFBBBBBB��6#   $ 15Q�65   $ 0Q�6E   $ Quality=�6S   $ 1Q�6k   5+      � 5,   
   $	��542��6   $��
20,0,34,30q�6   $��Bottom=�60   .+�5-      �� $��0,0,0,44q�6   .+�5.      �� $��Account Info��6   $��Center=�60   $��38(�6N   $��Champagne & Limousines)�6\   $��0,20,0,0q�6�   �� 5/      $��100,0q�6   �� 50      $��24(�6    �� TextAlignment$
 Left=�6+   $��25,30,340,10q�6A   
������� � Cursor$
 Hand��6i   �� 51      $�Email:��6   52      �� 53      $��24(�6   $
 Left=�6+   $��25,30,340,10q�6A   
�������$
 Hand��6i   �� 54      $�Nume:��6   55      �� 56      $��24(�6   $
 Left=�6+   $��25,30,301,10q�6A   
�������$
 Hand��6i   �� 57      $�Prenume:��6   58      59      �� 5:      $��18(�6   $
 Left=�6'   $��136,103,10,398q�6=   
���   �$
 Hand��6h   �� 5;      -   5         ��Name$ emailTB��5;      $ �cristianandrei98@gmail.com��6+   5<      �� 5=      $��20(�6   $
 Left=�6'   $��136,172,10,329q�6=   
���   �$
 Hand��6h   �� 5>      -   5        $ numeTB��5>      $�Stoleru��6*   5?      �� 5@      $��20(�6   $
 Left=�6'   $��136,245,23,256q�6=   
���   �$
 Hand��6h   �� 5A      -   5        $ 	prenumeTB��5A      $�Cristian-Andrei��6-   5B      �� 5C      $��20(�6   $
 Left=�6'   $��22,326,280,175q�6=   
��� d �$
 Hand��6l   �� 5D      $�	Cars Sold��6   5E      �� 5F      $��20(�6   $ Right=�6'   $��279,326,23,175q�6>   
���  ��$
 Hand��6k   �� 5G      $�Salary��6   5H      �� 5I      $��363,81,23,-81q�6   �� 5J      $��20(�6   $ Right=�6'   $��279,367,23,134q�6>   
���  ��$
 Hand��6k   �� 5K      -   5        $ salaryTB��5K      5L      �� 5M      $��22,81,333,-81q�6   �� 5N      $��20(�6   $
 Left=�6'   $��22,367,280,134q�6=   
��� d �$
 Hand��6l   �� 5O      -   5        $ salesTB��5O      $�14��6+   5P      5R      �� 5S   
   $��40,83,60,-8q�6   � 5T   
   $	��100��6   $��Bottom=�6   .+�5U      �� -   5         ��Name$ BackBT��5U      $
��Back��6%   $��Bottom=�64   $
��Left=�6O   $��50��6j   $��	57,0,0,40q�6v   $	��150��6�   6�   �� 5V      -   5        $ ChangePB��5V      $��Change Password��6'   $��Bottom=�6A   $
��Left=�6\   $��50��6w   $��
284,0,0,40q�6�   $	��150��6�   6�   5X      5Y      5Z      