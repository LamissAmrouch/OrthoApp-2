   M S B A M L   `   `   `  ����?  ;App2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:App2App2  5   	       App2.Window21   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:App2     5   	     � Title$  Window3��5   	    � WindowStyle$
 none=�5	   
    � 
ResizeMode$ NoResize=�5
   	   $	��650��5   	   $
��1100��6    � WindowState$ 	Maximized=�6:   ��6$   Z�  � 	Resources 5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background	 �� Color  Button.Static.Border  	ExitStyle
 �� 
TargetType �� 
TargetType � ColumnDefinitions ��Name �� Triggers P� Property P� Value  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background 	 Button.Disabled.Border 
 Button.Disabled.Foreground  ButtonStyle1 �� RadiusY �� RadiusX ��Name �� TextAlignment  ButtonStyle2  ButtonStyle3  ButtonStyle4  ButtonStyle5 �� FlowDirection  ButtonStyle6  ButtonStyle7 � RowDefinitions  ButtonStyle8  ButtonStyle9  ButtonStyle10��%5  &	        &	 �     &	 �     &	 �     7   7  7  &	 �    &	 �    &	 �    &	 �    &	     &		 3    &	
 V    &	 y    7   7  7  &	 �	    7   7  7  &	 k    7   7  7  &	 �    7   7  7  &	 �    7   7  7  &	 x    7   7  7  &	 �    7   7  7  &	 �     7   7  7  &	 �'    7   7  7  &	 �+    7   7  7  �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $	 	#FFDDDDDD��6;   �� 5   
   $	 	#FF707070��67   �� 5   
   "
 ��6"   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   �� 5        � ��$ 1q�6(   �� 5!       � �� 5"      �� 5#      " ��6&   .R�5$      � $��-14,0,12,-22q�6    5%      �� 5&   "   $	��13* �63   �� 5'   "   $	��54* �63   �� 5(   "   $	��16* �63   .+�5*      �� $# Images_QuitterButtonJaune_png��6$   $��1��6K   $��Stretch=�6[   $��4,14,6,6q�6y   $#��Images/QuitterButtonJaune.png��6�   $
��Fill=�6�   $
��Auto��6�   5+       5,      P� 5-       �@��IsDefaulted . 6=   P� 5.       �@J�IsMouseOver . 6=   P� 5/       � �� . 6;   P� 50       � {� .  6;   52      54      55      �� 56   
   $	 	#FFBEE6FD��6>   �� 57   
   $	 	#FF3C7FB1��6:   �� 58   
   $	 	#FFC4E5F6��6<   �� 59   
   $	 	#FF2C628B��68   �� 5:   
   $	 	#FFF4F4F4��6=   �� 5;   
   $	 	#FFADB2B5��69   �� 5<   
   $	 	#FF838383��6=   �� 5=   
   "
 ��6%   .�5>      ��  �@�FocusVisualStyle8   61   �� 5?       � ��8  6+   �� 5@       � ��8  6,   �� 5A       � ��# � ��6+   �� 5B       � ��$ 1q�60   �� 5C       � ��$ Center=�6;   �� 5D       � ��$ Center=�69   �� 5E       � ��$ 1q�6(   �� 5F       � �� 5G      �� 5H      " ��6&   .R�5I      � $��	0,0,0,-10q�6    5J      �� 5K   "   $��* �63   �� 5L   "   $��0* �63   .+�5N      �� ���	#FFEAE131$��	10,0,40,0q�69   $
 32.5��6L   $
 32.5��6[   ���	#FF5C994A$��5��6}   �� 5O      $ 	textBlock��6(   $��
28,18,52,8q�6;   $
��Wrap=�6O   $��36(�6c   $��
El Messiri)�6q   $ Center=�6�   $
��Auto��6�   $
��Auto��6�   
���   ��� 6�   $�
أكتشف��6�   �� 6�   $� ��6�   6�   5P       5Q      P� 5R       �@��IsDefaulted . 6=   P� 5S       �@J�IsMouseOver . 6=   P� 5T       � �� . 6;   P� 5U       � {� .  6;   5W      5Y      5Z      �� 5[   
   "
 ��6%   .�5\      ��  �@�FocusVisualStyle8   61   �� 5]       � ��8  6+   �� 5^       � ��8  6,   �� 5_       � ��# � ��6+   �� 5`       � ��$ 1q�60   �� 5a       � ��$ Center=�6;   �� 5b       � ��$ Center=�69   �� 5c       � ��$ 1q�6(   �� 5d       � �� 5e      �� 5f      " ��6&   .R�5g      � $��	0,0,0,-10q�6    5h      �� 5i   "   $��* �63   �� 5j   "   $��0* �63   .+�5l      �� 
�������$��
10,0,10,10q�65   $
 32.5��6I   $
 32.5��6X   ���	#FF5C994A$��5��6z   �� 5m      $ 	textBlock��6(   $��
2,19,18,14q�6;   $
��Wrap=�6O   $��24(�6c   $��
El Messiri)�6q   $ Center=�6�   �� 6�   $�  ��6�   �� 6�   $� ��6�   6�   5n       5o      P� 5p       �@��IsDefaulted . 6=   P� 5q       �@J�IsMouseOver . 6=   P� 5r       � �� . 6;   P� 5s       � {� .  6;   5u      5w      5x      �� 5y   
   "
 ��6%   .�5z      ��  �@�FocusVisualStyle8   61   �� 5{       � ��8  6+   �� 5|       � ��8  6,   �� 5}       � ��# � ��6+   �� 5~       � ��$ 1q�60   �� 5       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��$ 1q�6(   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �  5�      P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . 6=   P� 5�       � �� . 6;   P� 5�       � {� .  6;   5�      5�      5�      �� 5�   
   "
 ��6%   .�5�      ��  �@�FocusVisualStyle8   61   �� 5�       � ��8  6+   �� 5�       � ��8  6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��$ 1q�6(   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      � .+�5�      �� $ Images_home2_png��6$   $��
10,10,10,0q�6>   $��Images/home2.png��6R   $
��Fill=�6l   5�       5�      P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . 6=   P� 5�       � �� . 6;   P� 5�       � {� .  6;   5�      5�      5�      �� 5�   
   "
 ��6%   .�5�      ��  �@�FocusVisualStyle8   61   �� 5�       � ��8  6+   �� 5�       � ��8  6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��$ 1q�6(   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      � $��	0,0,0,-10q�6    5�      �� 5�   "   $��* �63   �� 5�   "   $��0* �63   .+�5�      �� ���	#FFEAE131$
��40,0q�69   $
 32.5��6G   $
 32.5��6V   ���	#FF5C994A$��5��6x   �� 5�      $ 	textBlock��6(   $��
40,14,40,6q�6;   $
��Wrap=�6O   $��36(�6c   $��
El Messiri)�6q   $ Center=�6�   �� 6�   $ RightToLeft=�6�   $�
أتمرن��6�   6�   5�       5�      P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . 6=   P� 5�       � �� . 6;   P� 5�       � {� .  6;   5�      5�      5�      �� 5�   
   "
 ��6%   .�5�      ��  �@�FocusVisualStyle8   61   �� 5�       � ��8  6+   �� 5�       � ��8  6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��$ 1q�6(   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      � .+�5�      �� 
�������$��
24,10,8,10q�65   $
 30.5��6I   $
 30.5��6X   ���	#FF5C994A$��5��6z   �� 5�      $ 	textBlock��6(   $��38��6;   $��
32,0,10,28q�6G   $
��Wrap=�6[   $��Bottom=�6o   $��
El Messiri)�6�   $��30(�6�   $ Center=�6�   �� 6�   $ RightToLeft=�6�   $�ألواني��6�   6�   �� 5�      $ Images_coleurs_png��6$   $��64,28,44,75q�6@   $��Images/coleurs.png��6U   $
��Fill=�6q   5�       5�      P� 5�       �@��IsDefaulted . 6=   P� 5�       �@J�IsMouseOver . 6=   P� 5�       � �� . 6;   P� 5�       � {� .  6;   5�      5�      5�      �� 5�   
   "
 ��6%   .�5�      ��  �@�FocusVisualStyle8   61   �� 5�       � ��8  6+   �� 5�       � ��8  6,   �� 5�       � ��# � ��6+   �� 5�       � ��$ 1q�60   �� 5�       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��$ 1q�6(   �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �  5�      �� 5�   "   $��3* �60   �� 5�   "   $��4* �60   �� 5�   "   $	��50* �60   �� 5�   "   $��7* �60   �� 5�   "   $	��24* �60   �� 5�   "   $��8* �60    5�      �� 5�   "   $	��22* �63   �� 5�   "   $��8* �63   �� 5�   "   $
��141* �63   �� 5�   "   $	��12* �63   �� 5�   "   $	��17* �63   .+�5�      �� 
�������$��10,0,8,-5.793q�65   $
 30.5��6L   $
 30.5��6[   ���	#FF5C994A$��5��6}   $��5��6�   $��5��6�   �� 5�      $ 	textBlock��6(   $
��Auto��6;   $��0,-0.207,-7,6.207q�6I   $
��Wrap=�6d   $��Stretch=�6x   $��
El Messiri)�6�   $��30(�6�   $ Center=�6�   $��1��6�   $��3��6�   $��4��6�   �� 6  $ RightToLeft=�6  .�6%  �� $�تعلم��6)  �� 67  $� ��6;  �� 6F  $�الأفعال��6J  6\  �� 6b  �� 6n  $ RightToLeft=�6r  6�  �� 5      $ Images_imagege_jpg��6$   $��5,0.793,4,5.207q�6@   $��Images/imagege.jpg��6Y   $
��Fill=�6u   $��2��6�   $��2��6�   $��2��6�   5      5     P� 5      �@��IsDefaulted . 6=   P� 5      �@J�IsMouseOver . 6=   P� 5      � �� . 6;   P� 5      � {� .  6;   5     5
     5     �� 5  
   "
 ��6%   .�5     ��  �@�FocusVisualStyle8   61   �� 5      � ��8  6+   �� 5      � ��8  6,   �� 5      � ��# � ��6+   �� 5      � ��$ 1q�60   �� 5      � ��$ Center=�6;   �� 5      � ��$ Center=�69   �� 5      � ��$ 1q�6(   �� 5      � �� 5     �� 5     " ��6&   .R�5     �  5     �� 5  "   $��3* �60   �� 5  "   $��4* �60   �� 5  "   $	��50* �60   �� 5  "   $��7* �60   �� 5  "   $	��24* �60   �� 5  "   $��8* �60    5!     �� 5"  "   $	��22* �63   �� 5#  "   $��8* �63   �� 5$  "   $
��141* �63   �� 5%  "   $	��12* �63   �� 5&  "   $	��17* �63   .+�5(     �� 
�������$��-4,0,0,-5.793q�65   $
 30.5��6L   $
 30.5��6[   ���	#FF5C994A$��5��6}   $��4��6�   $��5��6�   $��1��6�   �� 5)     $ Images_sens__1__jpg��6$   $��2��6A   $��2��6U   $��-1.4,2,-6.5,-6q�6e   $��2��6}   $��2��6�   $��Images/sens (1).jpg��6�   $
��Fill=�6�   �� 5*     $ 	textBlock��6(   $
��Auto��6;   $��2,6,7.787,0q�6I   $
��Wrap=�6^   $��Stretch=�6r   $��
El Messiri)�6�   $��30(�6�   $ Center=�6�   $��1��6�   $��4��6�   $��4��6�   �� 6�   $ RightToLeft=�6  .�6  �� $�تعلم��6#  �� 61  $� ��65  �� 6@  $�ا��6D  �� 6O  $�
لحواس��6S  6c  �� 6i  �� 6u  $ RightToLeft=�6z  .�6�  �� 6�  �� 6�  �� 6�  $ RightToLeft=�6�  6�  5+      5,     P� 5-      �@��IsDefaulted . 6=   P� 5.      �@J�IsMouseOver . 6=   P� 5/      � �� . 6;   P� 50      � {� .  6;   52     54     55     �� 56  
   "
 ��6%   .�57     ��  �@�FocusVisualStyle8   61   �� 58      � ��8  6+   �� 59      � ��8  6,   �� 5:      � ��# � ��6+   �� 5;      � ��$ 1q�60   �� 5<      � ��$ Center=�6;   �� 5=      � ��$ Center=�69   �� 5>      � ��$ 1q�6(   �� 5?      � �� 5@     �� 5A     " ��6&   .R�5B     � $��6.933,2.36,2.933,7.293q�6   .+�5C     �� ���	#FF29B6AF$ 12.183��69   $ 12.183��6J   ���	#FF29B6AF$��44��6n   $��0,-4,0,0q�6z   �� 5D     $ 	textBlock��6(   $��10.667,3.997,9.333,6.003q�6;   $
��Wrap=�6]   $��22(�6q   $��
El Messiri)�6   ���	#FFF9F3F3�� 6�   $ RightToLeft=�6�   $�
تشغيل��6�   6�   5E      5F     P� 5G      �@��IsDefaulted . 6=   P� 5H      �@J�IsMouseOver . 6=   P� 5I      � �� . 6;   P� 5J      � {� .  6;   5L     5N     5O     �� 5P  
   "
 ��6&   .�5Q     ��  �@�FocusVisualStyle8   61   �� 5R      � ��8  6+   �� 5S      � ��8  6,   �� 5T      � ��# � ��6+   �� 5U      � ��$ 1q�60   �� 5V      � ��$ Center=�6;   �� 5W      � ��$ Center=�69   �� 5X      � ��$ 1q�6(   �� 5Y      � �� 5Z     �� 5[     " ��6&   .R�5\     �  5]     �� 5^  "   $��6* �60   �� 5_  "   $��8* �60   �� 5`  "   $
��131* �60   �� 5a  "   $��8* �60   �� 5b  "   $��8* �60   �� 5c  "   $��8* �60   �� 5d  "   $��7* �60   �� 5e  "   $	��16* �60    5g     �� 5h  "   $	��14* �63   �� 5i  "   $��8* �63   �� 5j  "   $��8* �63   �� 5k  "   $	��27* �63   �� 5l  "   $	��20* �63   �� 5m  "   $	��18* �63   �� 5n  "   $	��12* �63   �� 5o  "   $	��33* �63   �� 5p  "   $	��16* �63   �� 5q  "   $	��13* �63   �� 5r  "   $��7* �63   �� 5s  "   $��5* �63   �� 5t  "   $��6* �63   �� 5u  "   $��8* �63   �� 5v  "   $��3* �63   .+�5x     �� 
�������$��3.979,0,-0.001,-5.793q�65   $
 30.5��6T   $
 30.5��6c   ���	#FF5C994A$��5��6�   $��14��6�   $��7��6�   $��1��6�   �� 5y     $ 	textBlock��6(   $
��Auto��6;   $��0.279,-11.828,-1.002,0q�6I   $
��Wrap=�6i   $��Stretch=�6}   $��
El Messiri)�6�   $��30(�6�   $ Center=�6�   $��2��6�   $��11��6�   $��3��6�   $��4��6  �� 6  $ RightToLeft=�6  $�أعضاء الجسم��6:  �� 6O  �� 6[  $ RightToLeft=�6_  �� 6}  �� 6�  $ RightToLeft=�6�  .�6�  �� 6�  �� 6�  �� 6�  $ RightToLeft=�6�  6�  �� 5z     $ Images_corps2_jpg��6$   $��8��6?   $��3��6S   $��5.1,0.086,-0.149,11.828q�6c   $��2��6�   $��1��6�   $��Images/corps2.jpg��6�   $
��Fill=�6�   $
��Auto��6�   $��Stretch=�6�   5{      5|     P� 5}      �@��IsDefaulted . 6=   P� 5~      �@J�IsMouseOver . 6=   P� 5      � �� . 6;   P� 5�      � {� .  6;   5�     5�     5�     5�     .��5�     � .+�5�  
   � ���	#FF9FE08C$��0,-8.207,0,8.207q�6&    5�     �� 5�     $��4* �6#   �� 5�     $	��61* �6#   �� 5�     $��8* �6#   �� 5�     $	��35* �6#   �� 5�     $	��15* �6#   �� 5�     $��7* �6#   �� 5�     $	��25* �6#   �� 5�     $	��17* �6#   �� 5�     $	��18* �6#   �� 5�     $��8* �6#   �� 5�     $	��15* �6#   �� 5�     $	��26* �6#   �� 5�     $��6* �6#   �� 5�     $	��47* �6#   �� 5�     $	��38* �6#   �� 5�     $��7* �6#   �� 5�     $	��44* �6#   �� 5�     $��8* �6#   �� 5�     $	��20* �6#   �� 5�     $	��27* �6#   �� 5�     $	��32* �6#   �� 5�     $	��10* �6#   �� 5�     $	��27* �6#   �� 5�     $	��45* �6#    5�     �� 5�     $	��39* �6    �� 5�     $	��48* �6    �� 5�     $	��29* �6    �� 5�     $��8* �6    �� 5�     $��3* �6    �� 5�     $��8* �6    �� 5�     $��7* �6    �� 5�     $	��13* �6    �� 5�     $	��11* �6    �� 5�     $	��14* �6    �� 5�     $	��12* �6    �� 5�     $��7* �6    �� 5�     $	��10* �6    �� 5�     $��7* �6    �� 5�     $��5* �6    �� 5�     $	��48* �6    �� 5�     $	��13* �6    �� 5�     $	��24* �6    �� 5�     $	��19* �6    .+�5�     �� ���	#FF5C994A���	#FF123434$��0��6<   $��0,0,0,-47.243q�6|   $��24��6�   �� 5�     -   5        $ 	textBlock��5�     $��6,6,-10,-43.243q�6+   $
��Wrap=�6D   $��
El Messiri)�6X   $��90(�6p   $ Center=�6~   
���   �$��8��6�   $��11��6�   �� 6�   $ RightToLeft=�6�   $�فيديوهات��6�   �� 6   �� 6  $ RightToLeft=�6  6/  �� 5�     -   5        $ 
textBlock1��5�     $��24.319,-2,2,12q�6,   $
��Wrap=�6D   $��6��6X   $��13��6e   $��2��6v   $��2��6�   �� 5�     -   5         ��Name$ HomeBtn��5�     $��
2,-8,14,12q�6&   $��17��6:   #���  6H   $��2��6o   $��1��6�    � ToolTip$% القائمة الرئيسية��6�   .��5�     �� -   5        $ Images_home2_png��5�     $��34��62   $��Images/home2.png��6>   $
��Fill=�6X   $��66��6g   5�     �� 5�     -   5        $ 
mesactions��5�     $��Button��6A   $��-8.5,6.793,2.5,-10.793q�6R   #���  6r   $��17��6�   $��5��6�   $��10��6�   $��5��6�   �� 5�     -   5        $ messens��5�     $��Button��68   $��-16.5,6.793,-1,-10.793q�6I   #���  6i   $��4��6�   $��5��6�   $��10��6�   $��6��6�   �� 5�     -   5        $ moncorps��5�     $��Button��6=   $��-17.5,6.793,2,-10.793q�6N   #���  6m   $��12��6�   $��5��6�   $��10��6�   $��3��6�   5�     �� 5�  
   -   5        $
 Exit��5�     $��Button��6   $��0,-10,-32,0q�60   #���  6E   $��64��6i   $	��Top=�6u   $��Right=�6�   $	��130��6�   $ خروج��6�   5�     5�     