   M S B A M L   `   `   `  ����@  <laba3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:laba3.View.Windowslaba3.View.Windows  5   	       laba3.View.Windows.Win4   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:laba3.View.Windows     5   	     � Title$
  Win4��5   	   $	��450��6   $	��800��6#    � WindowStartupLocation$ CenterScreen=�6/    � 
ResizeMode$ NoResize=�6T   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5   
   �� $ Vertical=�6   $��Center=�6,   $��Center=�6I   $��20q�6d   .+�5      �� -   5         ��Name$	 lb1��5      $��Введите a��6!   $��50��65   �� 5      -   5         ��Name$	 tb1��5      $��50��6#   $	��100��6/   5      �� 5   
   $ Vertical=�6   $��Center=�6,   $��Center=�6I   $��20q�6d   .+�5      �� -   5        $	 lb2��5      $��Введите b��6!   $��50��65   �� 5      -   5        $	 tb2��5      $��50��6#   $	��100��6/   5      �� 5      $ Vertical=�6   $��Center=�60   $��Center=�6M   $��20q�6h   .+�5      �� -   5        $	 lb3��5      $��
Ответ��6%   $��50��65   �� 5      -   5        $	 lb4��5      $��50��6%   $	��400��61   5      5      �� 5    
   $���� Даны a и b. Напечатать максимальное и минимальное значения выражений с указанием формул, по которым производились вычисления.��6   $��0��5!   9   $��50��6F   $	��Top=�6R   �� 5"   
   -   5         ��Name$ bt��5"      $��Узнать ответ��6   $	��100��64   $��75��6@   $��1��6]   $��Bottom=�6j   �� 5#   
   -   5        $
 back��5#      $��Вернуться��6   $	��100��63   $��75��6?   $
��Left=�6K   $��Bottom=�6f   $��1��6�   5$      5%      