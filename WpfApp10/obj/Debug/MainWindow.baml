   M S B A M L   `   `   `  ����^  ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35tOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration System.Windows.Forms.Integration  5   	   V RAForge.Controls, Version=2.2.5.0, Culture=neutral, PublicKeyToken=a8ac264d1dc6b9d9J6clr-namespace:AForge.Controls;assembly=AForge.ControlsAForge.Controls 5   	   C ?WpfApp10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp10WpfApp10 5   	      WpfApp10.MainWindow   5   	   WwfiOclr-namespace:System.Windows.Forms.Integration;assembly=WindowsFormsIntegration  5   	   Aaforge6clr-namespace:AForge.Controls;assembly=AForge.Controls  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp10     5   	     � Title$  
MainWindow��5
   	   $��734.6��6   $��1323.5��6+   .��5      � $��0,-27,-8,-20q�6    � ColumnDefinitions 5   
   �� 5      $
��361* �6   �� 5      $
��301* �6   ��5   
   �� 5       �� ImageSource$ Resource/背景大1.jpg��6   .+�5   
   7   1System.Windows.Forms.Integration.WindowsFormsHost  $��0��6   $��
70,230,0,0q�6,      
Background# � ��6@   $	��396��6�   $	��Top=�6�   $
��Left=�6�   $	��600��6�      Child. 5      '  !AForge.Controls.VideoSourcePlayer  -   5        sourcePlayer��[ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"  System.Windows.Forms.Control   Width$	 400��5   =      Height$	 600��6I   5      5      �� 5   
   -   5        $��初始化程序��5      $��39,262,363,0q�6!   $��20(�6J   $��50��6X   $	��Top=�6d   $��1��6|   ��5      �� 5       �� EndPoint$	 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5      � 	 � Color$	 	#FFF3F3F3��6#   
 � Offset$
 0Q�65   � 5      $	 	#FFEBEBEB��6#   $	
 0.5Q�65   � 5      $	 	#FFDDDDDD��6#   $	
 0.5Q�65   � 5      $	 	#FF937979��6#   $
 1Q�65   5      5       �� 5!   
   -   5        $��显示/隐藏细节��5!      $��332,262,70,0q�6#   $��20(�6O   $��1��6]   $��50��6m   $	��Top=�6y   ��5"      �� 5#      $	 0,1&�6&   $	 0,0&�65   .��5$      � $	 	#FFF3F3F3��6#   $
 0Q�65   � 5%      $	 	#FFEBEBEB��6#   $	
 0.5Q�65   � 5&      $	 	#FFDDDDDD��6#   $	
 0.5Q�65   � 5'      $	 	#FF9B7B7B��6#   $
 1Q�65   5(      5*      �� 5+   
   -   5        $��注册��5+      $��39,378,363,0q�6    J� RenderTransformOrigin$ 0.055,-0.082&�64   $��20(�6p   $��1��6~   $��49��6�   $	��Top=�6�   ��5,      �� 5-      $	 0,1&�6&   $	 0,0&�65   .��5.      � $	 	#FFF3F3F3��6#   $
 0Q�65   � 5/      $	 	#FFEBEBEB��6#   $	
 0.5Q�65   � 50      $	 	#FFDDDDDD��6#   $	
 0.5Q�65   � 51      $	 	#FFA48787��6#   $
 1Q�65   52      54      �� 55   
   -   5        $��验证��55      $��332,377,70,0q�6   $��20(�6I   $��50��6W   $	��Top=�6c   $��1��6{   ��56      �� 57      $	 0,1&�6&   $	 0,0&�65   .��58      � $	 	#FFF3F3F3��6#   $
 0Q�65   � 59      $	 	#FFEBEBEB��6#   $	
 0.5Q�65   � 5:      $	 	#FFDDDDDD��6#   $	
 0.5Q�65   � 5;      $	 	#FF8B6767��6#   $
 1Q�65   5<      5>      �� 5?   
   -   5         ��Name$ InfoBox��5?      $��712,572,41,0q�6%   $
��Wrap=�6;   $	��Top=�6O   $��84��6g   $��36(�6s    �� TextAlignment$ Center=�6�    J� OpacityMask
 �   �
�������$��2��6�   �� 5@   
   -   5         ��Name$ Success_Image��5@      $��228,472,274,180q�6'   $��Resource/正确.png��6@   $��1��6Y   �� 5A   
   -   5        $ 
Fail_Image��5A      $��228,472,274,180q�6$   $��Resource/错误.png��6=   $��1��6V   5C      5D      