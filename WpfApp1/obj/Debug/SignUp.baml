   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.SignUp   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Icon$  Assests\Logo(1).ico��5	   	    � Title$ Sign Up��5
   	   $	��700��6   $	��350��6&    � WindowStyle$
 None=�62    � 
ResizeMode$ NoResize=�6E    � WindowStartupLocation$ CenterScreen=�6[    � Triggers 5      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  W� From$ 0X�6&   	 W� To$ 1X�6/   	 g� Duration$	 0:0:1D�66   
 �� TargetProperty$
 Opacity�6G   5      5      5      5      .��5      � $	��700��6   $	��Top=�6    � RowDefinitions 5   
   �� 5      $
��249* �6   �� 5      .+�5   
   �� $	��500��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5       �  � Color$ #C5E1A5��6#   � 5!      $ #33691E��6#    � Offset$ 1Q�63   � 5"      $ #8BC34A��6#   $	 0.5Q�63   5$      5&      �� 5'   
   $��Assests/Logo.png��6   $	��266��6*   $	��Top=�67   $��
35,57,35,0q�6O   �� 5(   
   $	��280��6   $	��350��6    
�������$��Bottom=�6:   $��
35,0,35,98q�6U    �� RadiusY$
 14.5��6i    �� RadiusX$
 14.5��6x    J� Effect 5)      3  -System.Windows.Media.Effects.DropShadowEffect  5*         Color$ 	#FFBBBBBB��6#      
BlurRadius$ 15Q�65      	Direction$ 0Q�6E      RenderingBias$ Quality=�6S      ShadowDepth$ 1Q�6k   5,      � 5-   
   $	��280��6   $	��350��6   $��Bottom=�6(   $��
35,0,35,98q�6C   .+�5.      �� $��Sign Up��6   $��Center=�6(   $	��Top=�6E   $��5q�6]   
�������$��18(�6z   �� 5/      $��Center=�6   $��10q�64   .+�50      �� -   5         ��Name$ emailTB��50      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��6+    %  !MaterialDesignFloatingHintTextBox#��[  6R   $��Champagne & Limousines)�6�   $��18(�6�   $��49��6�   �� 51      -   5        $ FirstNameTB��51      $ 	FirstName��6/   #��[  6Z   $��Champagne & Limousines)�6�   $��18(�6�   $��49��6�   �� 52      -   5        $ 
LastNameTB��52      $ LastName��6.   #��[  6X   $��Champagne & Limousines)�6�   $��18(�6�   $��49��6�   G� 53      -   5         G�Name$ PassP��53      $ Password��6-    ) %MaterialDesignFloatingHintPasswordBox#��[ 6W   $��Champagne & Limousines)�6�   $��18(�6�   $��55��6�   �� 54      -   5        $ 	SallaryTB��54      $ Salary��6-   #��[  6U   $��Champagne & Limousines)�6�   $��18(�6�   $��49��6�   56      58      �� 59   
   -   5        $	��150��59      ���#8BC34A$��Center=�62   $��Bottom=�6O   $��100,0,100,75.214q�6j   $��Sing Up��6�   6�   A� 5;   
   -   5        
���  ��$��10��5;   !   $��10��6-   $	��Top=�68   $��Right=�6P   $��10,10q�6l    5=        5>      $ 0Q�6#   $	 0.1Q�61   5A      5C      5D      