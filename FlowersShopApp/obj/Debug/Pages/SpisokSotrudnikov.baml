   M S B A M L   `   `   `  ����I  EFlowersShopApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:FlowersShopApp.PagesFlowersShopApp.Pages  5      ,    &FlowersShopApp.Pages.SpisokSotrudnikov   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:FlowersShopApp.Pages     5        N� Title$  SpisokSotrudnikov��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $)��#Список сотрудников��6   $
��Left=�6:   $��5q�6U   $��Center=�6`   �� 5   
   -   5         ��Name$ lvSotrudniki��5       $��1��6   $��Center=�66   $��Center=�6S    �� View 5      �� 5      .P�5      �� $��ID��6%    �� DisplayMemberBinding 61   �� *id_sotrudnika+�� 5      $��Фамилия��6%    66   �� *
familiya+�� 5      $��Должность��6%    68   �� *
doljnost+5      5      �� 5   
   -   5         ��Name$ btnAdd��5      $+��%Добавить сотрудника��6!   $
��Left=�6?   $��10,3,0,0q�6Z   $��2��6l   $	��Top=�6y   $	��144��6�   $��31��6�   6�   �� 5   
   -   5        $ 	btnRemove��5      $)��#Удалить сотрудника��6$   $
��Left=�6A   $��	172,2,0,6q�6\   $��2��6o   $	��144��6|   6�   5      5      