   M S B A M L   `   `   `  ����?  ;App2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:App2App2  5   	       App2.Window17   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:App2     5   	     � Title$  Window17��5   	    � WindowStyle$
 none=�5	   
    � 
ResizeMode$ NoResize=�5
   	   $	��650��5   	   $
��1100��6   ���	#FF9FE08C � WindowState$ 	Maximized=�6;    � 	Resources 5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background	 �� Color  Button.Static.Border  
ExitStyle2
 �� 
TargetType �� 
TargetType � ColumnDefinitions ��Name �� Triggers P� Property P� Value  ButtonStyle1  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border 	 Button.Disabled.Background 
 Button.Disabled.Border  Button.Disabled.Foreground  ButtonStyle2 � RowDefinitions �� RadiusY �� RadiusX ��Name �� TextAlignment  ButtonStyle3 �� FlowDirection  ButtonStyle4  ButtonStyle5  ButtonStyle6  	OnLoaded1 �� TargetProperty �� 
TargetName g� RepeatBehavior9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	OnLoaded2��%�$  &	        &	 �     &	 �     &	 �     7   7  7  &	 �    7   7  7  &	 ]    &	 �    &	 �    &	 �    &		 �    &	
     &	 /    &	 R    7   7  7  &	 I    7   7  7  &	 N    7   7  7  &	 c    7   7  7  &	 [    7   7  7  &	 R    &	 �    �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $	 	#FFDDDDDD��6;   �� 5   
   $	 	#FF707070��67   �� 5   
   "
 ��6#   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5        � ��$ 1q�6(   �� 5!       � �� 5"      �� 5#      " ��6&   .R�5$      � $��-14,0,12,-22q�6    5%      �� 5&   "   $	��13* �63   �� 5'   "   $	��54* �63   �� 5(   "   $	��16* �63   .+�5*      �� $# Images_QuitterButtonJaune_png��6$   $��1��6K   $��Stretch=�6[   $��4,14,6,6q�6y   $#��Images/QuitterButtonJaune.png��6�   $
��Fill=�6�   $
��Auto��6�   5+       5,      P� 5-       �@��IsDefaulted . 6=   P� 5.       �@J�IsMouseOver . 6=   P� 5/       � �� . 6;   P� 50       � {� .  6;   52      54      55      �� 56   
   "
 ��6%   .�57      ��  �@�FocusVisualStyle8   61   �� 58       � ��8  6+   �� 59       � ��8  6,   �� 5:       � ��# � ��6+   �� 5;       � ��$ 1q�60   �� 5<       � ��$ Center=�6;   �� 5=       � ��$ Center=�69   �� 5>       � ��$ 1q�6(   �� 5?       � �� 5@      �� 5A      " ��6&   .R�5B      � .+�5C      �� $ Images_arrowjaune_png��6$   $��	10,4,34,6q�6C   $��Images/arrowjaune.png��6V   $
��Fill=�6u   5D       5E      P� 5F       �@��IsDefaulted . 6=   P� 5G       �@J�IsMouseOver . 6=   P� 5H       � �� . 6;   P� 5I       � {� .  6;   5K      5M      5N      �� 5O   
   $	 	#FFBEE6FD��6>   �� 5P   
   $	 	#FF3C7FB1��6:   �� 5Q   
   $	 	#FFC4E5F6��6<   �� 5R   
   $	 	#FF2C628B��68   �� 5S   
   $	 	#FFF4F4F4��6=   �� 5T   
   $	 	#FFADB2B5��69   �� 5U   
   $	 	#FF838383��6=   �� 5V   
   "
 ��6%   .�5W      ��  �@�FocusVisualStyle8   61   �� 5X       � ��8  6+   �� 5Y       � ��8  6,   �� 5Z       � ��# � ��6+   �� 5[       � ��$ 1q�60   �� 5\       � ��$ Center=�6;   �� 5]       � ��$ Center=�69   �� 5^       � ��$ 1q�6(   �� 5_       � �� 5`      �� 5a      " ��6&   .R�5b      � $��	10,0,0,10q�6    5c      �� 5d   "   $��8* �60   �� 5e   "   $	��19* �60   �� 5f   "   $��7* �60    5h      �� 5i   "   $��3* �63   �� 5j   "   $��5* �63   �� 5k   "   $	��21* �63   �� 5l   "   $	��22* �63   �� 5m   "   $	��21* �63   �� 5n   "   $	��20* �63   �� 5o   "   $��5* �63   .+�5q      �� 
�������$
 32.5��65   $
 32.5��6D   ���	#FF5C994A$��5��6f   $��0q�6z   $��7��6�   $��3��6�   �� 5r      $ 	textBlock��6(   $��4,2,6,-4q�6;   $
��Wrap=�6M   $ ��تأكيد الاجابة ��6a   $��
El Messiri)�6w   $ Right=�6�   $��30(�6�   $��2��6�   $��1��6�   $��4��6�   5s       5t      P� 5u       �@��IsDefaulted . 6=   P� 5v       �@J�IsMouseOver . 6=   P� 5w       � �� . 6;   P� 5x       � {� .  6;   5z      5|      5}      �� 5~   
   "
 ��6%   .�5      ��  �@�FocusVisualStyle8   61   �� 5�       � ��8  6+   �� 5�       � ��8  6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��$ 1q�6(   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �  5�      �� 5�   "   $	��50* �63   �� 5�   "   .+�5�      �� 
�������$
 32.5��65   $
 32.5��6D   ���	#FF5C994A$��5��6f   $
��0,10q�6z   $��2��6�   �� 5�      $ 	textBlock��6(   $��10,18,12,20q�6;   $
��Wrap=�6P   $��
El Messiri)�6d   $ Right=�6|   $��30(�6�   �� 6�   $ RightToLeft=�6�   $�السؤال التالي��6�   �� 6�   �� 6�   $ RightToLeft=�6�   6  5�       5�      P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . 6=   P� 5�       � �� . 6;   P� 5�       � {� .  6;   5�      5�      5�      �� 5�   
   "
 ��6%   .�5�      ��  �@�FocusVisualStyle8   61   �� 5�       � ��8  6+   �� 5�       � ��8  6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��$ 1q�6(   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      � $��	0,0,0,-10q�6    5�      �� 5�   "   $��* �63   �� 5�   "   $��0* �63   .+�5�      �� ���	#FFEAE131$��	10,0,40,0q�69   $
 32.5��6L   $
 32.5��6[   ���	#FF5C994A$��5��6}   �� 5�      $ 	textBlock��6(   $��
28,18,52,8q�6;   $
��Wrap=�6O   $��36(�6c   $��
El Messiri)�6q   $ Center=�6�   $
��Auto��6�   $
��Auto��6�   
���   ��� 6�   $�
أكتشف��6�   �� 6�   $� ��6�   6�   5�       5�      P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . 6=   P� 5�       � �� . 6;   P� 5�       � {� .  6;   5�      5�      5�      �� 5�   
   "
 ��6%   .�5�      ��  �@�FocusVisualStyle8   61   �� 5�       � ��8  6+   �� 5�       � ��8  6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��$ 1q�6(   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      � $��	0,0,0,-10q�6    5�      �� 5�   "   $��* �63   �� 5�   "   $��0* �63   .+�5�      �� 
�������$��	10,0,40,0q�65   $
 32.5��6H   $
 32.5��6W   ���	#FF5C994A$��5��6y   �� 5�      $ 	textBlock��6(   $��
18,18,50,8q�6;   $
��Wrap=�6O   $��28(�6c   $��
El Messiri)�6q   $ Center=�6�   $
��Auto��6�   $
��Auto��6�   
���   �$��تأكيد الاجابة��6�   5�       5�      P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . 6=   P� 5�       � �� . 6;   P� 5�       � {� .  6;   5�      5�      5�      �� 5�   
   "
 ��6%   .�5�      ��  �@�FocusVisualStyle8   61   �� 5�       � ��8  6+   �� 5�       � ��8  6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��$ 1q�6(   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      � $��	0,0,0,-10q�6    5�      �� 5�   "   $��* �63   �� 5�   "   $��0* �63   .+�5�      �� 
�������$��	10,0,26,0q�65   $
 32.5��6H   $
 32.5��6W   ���	#FF5C994A$��5��6y   �� 5�      $ 	textBlock��6(   $��	4,18,24,8q�6;   $
��Wrap=�6N   $��28(�6b   $��
El Messiri)�6p   $ Center=�6�   $
��Auto��6�   $
��Auto��6�   
���   �$��السؤال التالي��6�   5�       5�      P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . 6=   P� 5�       � �� . 6;   P� 5�       � {� .  6;   5�      5�      5�      �� 5�   
   .��5�      U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6,   $ image��6�   $ Forever��6�   .\�5�        $ 0:0:0.3��6'   $ 23.071Q�69     5�      $ 0:0:0.6��6'   $ -0.181Q�69     5�      $ 0:0:0.9��6'   $ -23.598Q�69     5�      $ 0:0:1.2��6'   $ -0.614Q�69   5�      5�      �� 5�   
   .��5�      U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6,   $
 sons��6�   $ Forever��6�   .\�5        $ 0:0:0.3��6'   $
 0.75Q�69     5     $ 0:0:0.6��6'   $ 0.833Q�69     5     $ 0:0:0.9��6'   $ 0.972Q�69   5     U� 5     $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $
 sons��6�   $ Forever��6�   .\�5       $ 0:0:0.3��6'   $ 9Q�69     5     $ 0:0:0.6��6'   $ 6Q�69     5     $ 0:0:0.9��6'   $ 1Q�69   5     U� 5	     $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6,   $
 sons��6�   $ Forever��6�   .\�5
       $ 0:0:0.3��6'   $ 0.857Q�69     5     $ 0:0:0.6��6'   $ 0.881Q�69     5     $ 0:0:0.9��6'   $ 1Q�69   5     U� 5     $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $
 sons��6�   $ Forever��6�   .\�5       $ 0:0:0.3��6'   $ 6Q�69     5     $ 0:0:0.6��6'   $ -1Q�69     5     $ 0:0:0.9��6'   $ -6Q�69   5     5     5      � Triggers 5     :� 5  
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5     �� -   5         ��Name$ OnLoaded1_BeginStoryboard��5     #��[ 6A   5     .��5     �  5  
   �� 5     $
��117* �6   �� 5     $	��84* �6   �� 5     $	��48* �6   �� 5     $	��18* �6   �� 5      $	��36* �6   �� 5!     $	��21* �6   �� 5"     $	��24* �6   �� 5#     $	��33* �6   �� 5$     $	��57* �6   �� 5%     $	��30* �6   �� 5&     $	��27* �6   �� 5'     $	��30* �6   �� 5(     $	��30* �6   �� 5)     $	��33* �6   �� 5*     $	��27* �6   �� 5+     $	��18* �6   �� 5,     $	��36* �6   �� 5-     $	��60* �6   �� 5.     $	��27* �6   �� 5/     $	��18* �6   �� 50     $	��15* �6   �� 51     $	��54* �6   �� 52     $	��66* �6   �� 53     $	��75* �6   �� 54     $	��32* �6   �� 55     $	��84* �6    57  
   �� 58     $
��106* �6   �� 59     $	��84* �6   �� 5:     $	��16* �6   �� 5;     $	��19* �6   �� 5<     $	��90* �6   �� 5=     $	��97* �6   �� 5>     $	��26* �6   �� 5?     $	��24* �6   �� 5@     $	��69* �6   �� 5A     $	��18* �6   �� 5B     $	��13* �6   �� 5C     $	��14* �6   �� 5D     $	��60* �6   �� 5E     $	��14* �6   .+�5G  
   �� ���	#FF5C994A���	#FF123434$��0��68   $��
0,0,0,8.55q�6�   $��26��6�   �� 5H  
   -   5        $ 
textBlock1��5H     $��-2,12,3,-21.45q�6(   $
��Wrap=�6@   $��
El Messiri)�6T   $��60(�6l   $ Center=�6z   
���   �$��15��6�   $��6��6�   �� 6�   $ RightToLeft=�6�   .�6  �� $�
أكتشف��6  �� 6+  $� ��6/  �� 6:  $�ألواني��6>  6O  �� 6U  �� 6a  $ RightToLeft=�6f  .�6�  �� 6�  6�  �� 5I  
   -   5        $
 sons��5I     $��-11,7,-10,5q�6   $��Images/volume.png��63   $
��Fill=�6N   $��1��6x   $��12��6�   $��2��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�     � ToolTip$  صوت��6�   z�5J     V� 5K     .~�5L     �� �� 5M     �� 5N     T� 5O     5P     5R     �� 5S  
   -   5        ! ��Name$! Exit1��5S     $��Button��6    $��-14,-10,-32,44q�61   #���  6I   $��25��6�   $  خروج��6�   �� 5T  
   -   5        $! 
RetourBtn1��5T     $��Button��6%   $��26,4,1,16.55q�66   #���  6L   $  رجوع��6�   �� 5U  
   -   5        " ��Name$" cont1��5U     
�������$��4.592,6.357,0,-0.145q�60   ���	#FF5C994A$��5��6a   $
 32.5��6u   $
 32.5��6�   $��3��6�   $��3��6�   $��19��6�   $��5��6�   �� 5V  
   -   5        $ ImageChoix1��5V     $��6.773,8.763,20.193,24.989q�6%   $ 0.5,0.5&�6H   $��4��6h   $��2��6u   $��20��6�   $��4��6�   z�5W     V� 5X     .~�5Y     �� �� 5Z     �� 5[     T� 5\     5]     5_     �� 5`  
   -   5        $" cont2��5`     
�������$��6.592,6.357,1,-0.145q�60   ���	#FF5C994A$��5��6a   $
 32.5��6u   $
 32.5��6�   $��3��6�   $��3��6�   $��9��6�   $��8��6�   �� 5a  
   -	   5        $ ImageChoix2��5a     $!��-3.227,8.763,-14.807,24.989q�6%   $ 0.5,0.5&�6J   $��4��6j   $��2��6w   $��10��6�   $��6��6�   z�5b     V� 5c     .~�5d     �� �� 5e     �� 5f     T� 5g     5h     5j     �� 5k  
   -
   5        $" cont3��5k     
�������$��3.592,6.357,4,-0.145q�60   ���	#FF5C994A$��5��6a   $
 32.5��6u   $
 32.5��6�   $��3��6�   $��3��6�   $��1��6�   $��6��6�   �� 5l  
   -   5        $ ImageChoix3��5l     $��23.773,8.763,0.193,24.989q�6%   $ 0.5,0.5&�6H   $��4��6h   $��2��6u   $��1��6�   $��5��6�   z�5m     V� 5n     .~�5o     �� �� 5p     �� 5q     T� 5r     5s     5u     �� 5v  
   -   5        $ t1��5v     $��5,3.145,3,-2q�6   $��Images/True.png��62   $
��Fill=�6K   $��6��6Z   $��22��6g   $��2��6x   �� 5w  
   -   5        $ t3��5w     $��3,3.145,5,-2q�6   $��Images/True.png��62   $
��Fill=�6K   $��6��6Z   $��2��6g   $��2��6�   $��2��6�   �� 5x  
   -   5        $ t2��5x     $��3,3.145,2,-2q�6   $��Images/True.png��62   $
��Fill=�6K   $��6��6Z   $��2��6g   $��12��6�   $��2��6�   �� 5y  
   -   5        $ f1��5y     $��6.592,4.145,3,-6q�6   $��Images/False.png��66   $
��Fill=�6P   $��6��6_   $��22��6l   $��2��6}   �� 5z  
   -   5        $ f2��5z     $��4.592,4.145,2,-6q�6   $��Images/False.png��66   $
��Fill=�6P   $��6��6_   $��12��6l   $��2��6}   $��2��6�   �� 5{  
   -   5        $" r1��5{     
�������$��	-6,2,-2,2q�6-   
���   �$ 0.448,0.433&�6O   $��12��6s   $��21��6�   �� 5|  
   -   5        $" r2��5|     
�������$��-3,2,1,2q�6-   
���   �$ 0.448,0.433&�6N   $��12��6r   $��18��6�   $��3��6�   �� 5}  
   -   5        $" r3��5}     
�������$
��-1,2q�6-   
���   �$ 0.448,0.433&�6J   $��12��6n   $��17��6�   �� 5~  
   -   5        $	" r10��5~     
�������$��-3.663,2,-1.337,2q�6.   
���   �$ 0.448,0.433&�6X   $��12��6|   $��4��6�   $��2��6�   �� 5  
   -   5        $" r9��5     
�������$��-2.664,2,-2.336,2q�6-   
���   �$ 0.448,0.433&�6W   $��12��6{   $��6��6�   $��2��6�   �� 5�  
   -   5        $" r8��5�     
�������$��-1.664,2,-3.336,2q�6-   
���   �$ 0.448,0.433&�6W   $��12��6{   $��8��6�   �� 5�  
   -   5        $" r7��5�     
�������$��	-1,2,-4,2q�6-   
���   �$ 0.448,0.433&�6O   $��12��6s   $��9��6�   $��2��6�   �� 5�  
   -   5        $" r6��5�     
�������$
��-1,2q�6-   
���   �$ 0.448,0.433&�6J   $��12��6n   $��11��6�   $��2��6�   �� 5�  
   -   5        $" r5��5�     
�������$��-3,2,1,2q�6-   
���   �$ 0.448,0.433&�6N   $��12��6r   $��13��6�   $��2��6�   �� 5�  
   -   5        $" r4��5�     
�������$��	-5,2,-3,2q�6-   
���   �$ 0.448,0.433&�6O   $��12��6s   $��15��6�   $��2��6�   �� 5�  
   -   5        $! ValiderQuest��5�     $��Button��6'   $��6,1,2,7q�68   #���  6I   $��8��6p   $��15��6}   $��7��6�   6�   �� 5�  
   -   5        $! 	QuestSuiv��5�     $��Button��6$   $��
-12,1,14,7q�65   #���  6I   $��8��6p   $��5��6}   $��7��6�   6�   r� 5�  
   -   5        $
��blue��5�     # r� Source$# Enregistrer016.mp3?�6   $ r� LoadedBehavior$$ Manual=�65   6P   r� 5�  
   -   5        $
��gris��5�     $# Enregistrer017.mp3?�6   $$ Manual=�65   6P   r� 5�  
   -   5        $��jaune��5�     $# Enregistrer018.mp3?�6   $$ Manual=�66   6Q   r� 5�  
   -    5        $��marron��5�     $# Enregistrer019.mp3?�6   $$ Manual=�67   6R   r� 5�  
   -!   5        $��mauve��5�     $# Enregistrer020.mp3?�6   $$ Manual=�66   6Q   r� 5�  
   -"   5        $
��noir��5�     $# Enregistrer021.mp3?�6   $$ Manual=�65   6P   r� 5�  
   -#   5        $��orange��5�     $# Enregistrer022.mp3?�6   $$ Manual=�67   6R   r� 5�  
   -$   5        $
��rose��5�     $# Enregistrer023.mp3?�6   $$ Manual=�65   6P   r� 5�  
   -%   5        $��rouge��5�     $# Enregistrer024.mp3?�6   $$ Manual=�66   6Q   r� 5�  
   -&   5        $
��vert��5�     $# Enregistrer025.mp3?�6   $$ Manual=�65   6P   r� 5�  
   -'   5        $��Correct��5�     $# Correct.mp3?�6   $$ Manual=�61   $��
0,0,1,8.55q�6I   6`   r� 5�  
   -(   5        $��Wrong��5�     $# 	Wrong.mp3?�6   $$ Manual=�6-   $��
0,0,1,8.55q�6E   6\   �� 5�  
   -)   5        $" affiche��5�     $��17��6%   $��5��6:   
�������$��-2,7,5.227,7q�6W   $
 32.5��6m   $��3��6|   $
 32.5��6�   $��5��6�   ���	#FF5C994A$��5��6�   �� 5�  
   -*   5        $ 	textBlock��5�     $��15��6'   $��6��6<   $��10,10,-22,-27q�6L   $��4��6c   $
��Wrap=�6p   $��
El Messiri)�6�   $��38(�6�   $ Center=�6�   �� 5�  
   -+   5        $ image��5�     $��5��6   $��11��63   $��13.807,10,-10.807,-4q�6D   $��5��6b   $��2��6o   $ 0.5,0.5&�6�   z�5�     V� 5�     .~�5�     �� �� 5�     �� 5�     T� 5�     5�     5�     �� 5�  
   -,   5        $ f3��5�     $��4.592,4.145,5,-6q�6   $��Images/False.png��66   $
��Fill=�6P   $��6��6_   $��2��6l   $��2��6|   $��2��6�   5�     5�     