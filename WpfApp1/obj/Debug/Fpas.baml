   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Fpas   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Icon$  Assests\Logo(1).ico��5	   	    � Title$ Password��5
   	   $	��500��6   $	��350��6'    � WindowStyle$
 None=�63    � 
ResizeMode$ NoResize=�6F    � WindowStartupLocation$ CenterScreen=�6\    � Triggers 5      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  W� From$ 0X�6&   	 W� To$ 1X�6/   	 g� Duration$	 0:0:1D�66   
 �� TargetProperty$
 Opacity�6G   5      5      5      5      .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ #C5E1A5��6#   � 5      $ #33691E��6#    � Offset$ 1Q�63   � 5      $ #8BC34A��6#   $	 0.5Q�63   5       5"      �� 5#   
   $��Assests/Logo.png��6   $	��200��6*   $	��200��67   $	��Top=�6C   $��20q�6[   �� 5$   
   $	��280��6   $	��275��6    
�������$��Bottom=�6:   $��
35,0,35,65q�6U    �� RadiusY$
 14.5��6i    �� RadiusX$
 14.5��6x    J� Effect 5%      3  -System.Windows.Media.Effects.DropShadowEffect  5&         Color$ 	#FFBBBBBB��6#      
BlurRadius$ 15Q�65      	Direction$ 0Q�6E      RenderingBias$ Quality=�6S      ShadowDepth$ 1Q�6k   5(      � 5)   
   $	��280��6   $	��270��6   $��Bottom=�6(   $��
35,0,35,70q�6C   .+�5*      �� $��Center=�6   $	��Top=�65   $
��5,25q�6M   
�������$��18(�6m   " Forgot your account’s password�� 5+   0   or having trouble logging?�� 6W   Enter your email address�� 6{   $"and we’ll send you the password.5,      �� 5.      $��Bottom=�6   $��10,40q�64   .+�5/      �� -   5         ��Name$ emailTB��5/      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��6+    %  !MaterialDesignFloatingHintTextBox#��[  6R   $��Champagne & Limousines)�6�   $��18(�6�    J� RenderTransformOrigin$ 0.502,0.532&�6�   50      52      �� 53   
   -   5        $	��150��53      ���#8BC34A$��Center=�62   $��Bottom=�6O   $��94,0,106,54q�6j   $��
Send Email��6   6�   A� 54   
   -   5        
���  ��$��10��54   !   $��10��6-   $	��Top=�68   $��Right=�6P   $��10,10q�6l    56        57      $ 0Q�6#   $	 0.1Q�61   5:      5;      5=      