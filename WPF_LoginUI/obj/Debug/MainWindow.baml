   M S B A M L   `   `   `  ����F  BWPF_LoginUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF_LoginUIWPF_LoginUI  5   	       WPF_LoginUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPF_LoginUI     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��5q�6   $��0��6   $	��123��6,   $��18(�67   $��Center=�6E   �� 5   
   $��1��6   
������.+�5      �� $��5q�6   $��log in��6#   $��Center=�61   $��25(�6N   
���P��6\   5      � 5   
   $��2��6   $
��Left=�6   $	��Top=�68   $��
281,54,0,0q�6P    5      �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6    �� 5      $��30 �6     � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $	��200 �6#   .+�5!      �� $��	Usersname��6   $��0��6)   $��0��66   $��Center=�6F   �� 5"      $��2q�61   $��0��6=   $��1��6J   $��Center=�6Z   ��6   �� *
UserName+6Z   �� 5$      $��Password��6   $��1��6(   $��0��65   $��Center=�6E   �� 5%      $��2q�61   $��1��6=   $��1��6J   $��Center=�6Z   ��6   �� *
PassWord+6Z   �� 5'      $��2��6   $��remember me��6+   $��2��6A      WPF_LoginUI.CustomButton  5(      
�������$��2��64   $��
log in1223��6H   $��3��6]   ��6j   �� *LoginAction+5*      5+      5,      