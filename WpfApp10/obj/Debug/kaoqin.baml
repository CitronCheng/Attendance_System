   M S B A M L   `   `   `  ����C  ?WpfApp10, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp10WpfApp10  5   	       WpfApp10.kaoqin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp10     5   	     � Title$  kaoqin��5   	   $��319.307��6   $��665.347��6)   .��5	      � -   5         �Name$ 	winkaoqin��5	      $��0,0,-8,0q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AttaForm��5
         AutoGenerateColumns .  $��10,52,10,10q�6A      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ FingerId��6e      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6w   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
FingerId+   ClipboardContentBinding 6B   Z� 6w     5      $
 Name��6a   $	 100 6o    6%   �� *Name+ 6>   Z� 6o     5      $ 
AttantTime��6g   $	 100 6{    6%   �� *
AttantTime+ 6D   Z� 6{     5      $ 	AttantNum��6f   $	 100 6y    6%   �� *	AttantNum+ 6C   Z� 6y     5      $
 Type��6a   $	 100 6o    6%   �� *Type+ 6>   Z� 6o     5      $ YesOrNo��6d   $	 100 6u    6%   �� *	YesOrNo+ 6A   Z� 6u     5      $ TimeSpan��6e   $	 100 6w    6%   �� *
TimeSpan+ 6B   Z� 6w   5      �� 5   
   -   5        	 ��Name$	 ChooseComboBox��5      $
��Left=�6+   $	��Top=�6F   $	��120��6^   .@�5      �� -   5        $��按时间查看��5      $
��Left=�6+   $	��118��6F   6R   �� 5      -   5        $��按员工查看��5      $
��Left=�6+   $	��118��6F   6R   �� 5      -   5        $��按打卡类型查看��5      $
��Left=�6-   $	��118��6H   6T   5      � 5   
   -   5        $ 	TimeChose��5      $��137,0,222,257q�6"   .+�5      (  "System.Windows.Controls.DatePicker  -   5        
  Name$
 BeginTimeBox��5      $
��Left=�6/   $	��Top=�6J    J� RenderTransformOrigin$ 
0.87,0.472&�6b   $��54,0,0,0q�6�   6�   �� 5      $
��Left=�6   $
��Wrap=�63   $	��Top=�6G   $��15��6_   $��64��6k   $��0,4,0,0q�6v   �� 6�   $�起始时间��6�   �� 6�   $�:��6�   6�     5      -	   5        $
 
EndTimeBox��5      $
��Left=�6-   $	��Top=�6H   $ 
0.87,0.472&�6`   $��	224,0,0,0q�6�   6�   �� 5      $
��Left=�6   $
��Wrap=�63   $	��Top=�6G   $��15��6_   $��64��6k   $��	170,4,0,0q�6v   �� 6�   $�终止时间��6�   �� 6�   $�:��6�   6�   5      �� 5    
   -
   5        $	 EmpComboBox��5       $
��Left=�6)   $��	137,0,0,0q�6D   $	��Top=�6W   $	��120��6o   5!      �� 5"   
   -   5        $	 TypeComboBox��5"      $
��Left=�6)   $��	137,0,0,0q�6D   $	��Top=�6W   $	��120��6o   .@�5#      �� $��Sign_In��6   $
��Left=�6-   $	��118��6H   �� 5$      $��Sign_Out��6   $
��Left=�6.   $	��118��6I   �� 5%      $��OverTimeWork��6   $
��Left=�62   $	��118��6M   5&      �� 5'   
   -   5         ��Name$ Search_Button��5'      $��查询��6(   $
��Left=�65   $��	562,0,0,0q�6P   $	��Top=�6c   $��75��6{   6�   �� 5(   
   -   5         ��Name$ TimeCheckBox��5(      $��按时间查看��6)   $
��Left=�69   $��	10,27,0,0q�6T   $	��Top=�6g   6   �� 5)   
   -   5        $ EmpCheckBox��5)      $��按员工查看��6(   $
��Left=�68   $��
298,27,0,0q�6S   $	��Top=�6g   6   �� 5*   
   -   5        $ TypeCheckBox��5*      $��按签到/签退查看��6)   $
��Left=�6<   $��
443,27,0,0q�6W   $	��Top=�6k   $ 0.267,0&�6�   6�   5+      5,      