   M S B A M L   `   `   `  ����I  EFlowersShopApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:FlowersShopApp.PagesFlowersShopApp.Pages  5      )    #FlowersShopApp.Pages.SpisokPostavok   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:FlowersShopApp.Pages     5        N� Title$  SpisokPostavok��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� $��0��6   $#��Список поставок��6   $
��Left=�67   $��5q�6R   $��Center=�6]   �� 5   
   -   5         ��Name$ 
lvPostavki��5       $��1��6   $��Center=�64   $��Center=�6Q    �� View 5      �� 5      .P�5      �� $ ��Идентификатор��6%    �� DisplayMemberBinding 6<   �� *id_postavki+�� 5      $��
Адрес��6%    64   �� *postavschik+�� 5      $��
Цветы��6%    64   �� *zvety+�� 5      $��Количество��6%    69   �� *kolichestvo+�� 5      $��Дата поставки��6%    6<   �� *data+5      5      �� 5   
   -   5         ��Name$ btnAdd��5      $'��!Добавить поставку��6!   $
��Left=�6=   $��10,0,0,6q�6X   $��2��6j   $��Bottom=�6w   $	��144��6�   $��31��6�   6�   �� 5   
   -   5        $ 
btnReplace��5      $%��Удалить поставку��6%   $
��Left=�6@   $��	184,0,0,6q�6[   $��2��6n   $��Bottom=�6{   $	��144��6�   $��31��6�   6�   5       5!      