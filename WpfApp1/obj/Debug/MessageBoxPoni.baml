   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MessageBoxPoni   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Icon$  Assests\Logo(1).ico��5   	    � Title$ MessageBoxPoni��5	   	   $��348.5��6    $	��600��6/    � WindowStyle$
 None=�6;    � 
ResizeMode$ NoResize=�6N    � WindowStartupLocation$ CenterScreen=�6d    � Triggers 5
      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      W�  W� From$ 0X�6&   	 W� To$ 1X�6/   	 g� Duration$	 0:0:1D�66   
 �� TargetProperty$
 Opacity�6G   5      5      5      5      .��5      � .+�5   
   �� ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ #8BC33A��6#   � 5      $ #33691E��6#    � Offset$ 1Q�63   � 5      $ #8BC34A��6#   $	 0.5Q�63   5      5       � 5!   
   $��20,10,395,0q�6   .+�5"      �� $��Assests/Logo.png��6   $	��578��6.   $��Center=�6;   $��-66,-116,-79,-132q�6V   5#      �� 5$   
   $��235,84,30,76q�6   
������� �� RadiusY$
 24.5��67    �� RadiusX$
 24.5��6F    J� Effect 5%      3  -System.Windows.Media.Effects.DropShadowEffect  5&         
BlurRadius$ 1Q�6#      ShadowDepth$ 2Q�62      Color$ 	#FF515151��6B      Opacity$	 0.6Q�6T   5(      � 5)   
   $��251,84,54,76q�6   .+�5+      �� -   5         ��Name$
 text��5+   f    �� TextAlignment$ Center=�6   $
��Wrap=�6/   $��	0,24,0,29q�6C   $��20(�6V   6f   5-      �� 5.   
   -   5        $��40��5.      $	��Ok!��6   ���#4c8c4a$��338,256,160,44q�6@    5/        50      $ 1Q�6#   $ 2Q�62   $ 	#FF515151��6B      	Direction$	 300Q�6T   $	 0.6Q�6d   53      A� 54   
   -   5         A�Name$ closeButton��54      
���  ��$��10��66   $��10��6B   $	��Top=�6M   $��Right=�6e   $��10,10q�6�    56        57      $ 0Q�6#   $	 0.1Q�61   59      A� 5;   
   -   5        $ 	minButton��5;      
��� ���$��10��67   $��10��6C   $	��Top=�6N   $��Right=�6f   $��30,10q�6�    5=        5>      $ 0Q�6#   $	 0.1Q�61   5A      5B      5C      