   M S B A M L   `   `   `  ����@  <laba3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:laba3.View.Windowslaba3.View.Windows  5   	       laba3.View.Windows.Win6   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:laba3.View.Windows     5   	     � Title$
  Win6��5   	   $	��450��6   $	��800��6#    � WindowStartupLocation$ CenterScreen=�6/    � 
ResizeMode$ NoResize=�6T   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $ Vertical=�6   $��Center=�60   $��Center=�6M   $��20q�6h   .+�5      �� -   5         ��Name$	 lb1��5      $,��&Введите номер месяца��6%   $��50��6D   �� 5      -   5         ��Name$	 tb1��5      $��50��6'   $	��100��63   5      �� 5      $ Vertical=�6   $��Center=�60   $��Center=�6M   $��20q�6h   .+�5      �� -   5        $	 lb2��5      $��
Ответ��6%   $��50��65   �� 5      -   5        $	 lb3��5      $��50��6%   $	��400��61   5      5      �� 5   
   $����По введенному номеру месяца вывести на экран сообщение о номере квартала.��6   $��0��5      $��50��6   $	��Top=�6%   �� 5   
   -   5         ��Name$ bt��5      $��Узнать ответ��6   $	��100��64   $��75��6@   $��1��6]   $��Bottom=�6j   �� 5   
   -   5        $
 back��5      $��Вернуться��6   $	��100��63   $��75��6?   $
��Left=�6K   $��Bottom=�6f   $��1��6�   5       5!      