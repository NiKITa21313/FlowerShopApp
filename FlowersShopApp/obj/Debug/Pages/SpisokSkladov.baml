   M S B A M L   `   `   `  ����I  EFlowersShopApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:FlowersShopApp.PagesFlowersShopApp.Pages  5      (    "FlowersShopApp.Pages.SpisokSkladov   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:FlowersShopApp.Pages     5        N� Title$  SpisokSkladov��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $!��Список складов��6   $
��Left=�66   $��5q�6Q   $��Center=�6\   �� 5   
   -   5         ��Name$ lvSklady��5       $��1��6   $��Center=�62   $��Center=�6O    �� View 5      �� 5      .P�5      �� $��
Адрес��6%    �� DisplayMemberBinding 64   �� *adres+�� 5      $��
Цветы��6%    64   �� *zvety+�� 5      $��Количество��6%    69   �� *kolichestvo+5      5      �� 5   
   -   5         ��Name$ btnAdd��5      $!��Добавить склад��6!   $
��Left=�6:   $��10,0,0,6q�6U   $��2��6g   $��Bottom=�6t   $	��144��6�   $��31��6�   6�   �� 5   
   -   5        $ 	btnRemove��5      $��Удалить склад��6$   $
��Left=�6<   $��	176,0,0,6q�6W   $��2��6j   $��Bottom=�6w   $	��144��6�   $��31��6�   6�   5      5      