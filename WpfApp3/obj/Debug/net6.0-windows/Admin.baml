   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.Admin   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	     � Title$  Admin��5   	   $	��800��6   $	��800��6&   $	��700��65   $	��700��6E   $	��700��6U   $	��800��6b    � WindowStyle$
 None=�6n    � WindowStartupLocation$ CenterScreen=�6�   .��5	      � .+�5
   
   �� -   5        $��	NameTovar��5
      $
��Left=�6#   $��
97,134,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6g   $	��252��6   $��42��6�   �� 5   
   -   5        $��
CenaTovara��5      $
��Left=�6$   $��
97,204,0,0q�6?   $
 Wrap=�6S   $	��Top=�6h   $	��252��6�   $��42��6�   �� 5   
   -   5        $��
ImageTovar��5      $
��Left=�6$   $��
97,268,0,0q�6?   $
 Wrap=�6S   $	��Top=�6h   $	��252��6�   $��42��6�   �� 5   
   -   5        $	��Dob��5      $��Добавить��6   $
��Left=�6/   $��133,379,0,0q�6J   $	��Top=�6_   $��36��6w   $	��180��6�   6�   �� 5   
   -   5         ��Name$
 Exit��5      $��X��6   $
��Left=�6+   $��26��6F   $��
675,10,0,0q�6R   $	��Top=�6f   $��82��6~   $��20(�6�   $
��Bold"�6�   $��Bahnschrift)�6�   6�   �� 5   
   -   5        $ UpdBut��5      $��Изменить��6!   $
��Left=�64   $��133,420,0,0q�6O   $	��Top=�6d   $��36��6|   $	��180��6�   6�   �� 5   
   -   5        $ DelBut��5      $��Удалить��6!   $
��Left=�63   $��133,461,0,0q�6N   $	��Top=�6c   $��36��6{   $	��180��6�   6�   �� 5   
   -   5        $��	ListTovar��5      $��370,100,10,232q�6$    �� View 5      �� 5      .P�5      �� $��Наименование��5       �� Width$	 150��6-    �� DisplayMemberBinding 5   %   ��  �� Path$
 Name�5   -   �� 5      $��Цена��5      $	 100��6%    5   %   �� $
 Cena�5   %   �� 5      $��Изображение��6%   $	 100��6:   	 �� CellTemplate	 5      �� 5      .R�5   "   �� ��6(   �� $ Image�5      5      5      5!      5"      5#      