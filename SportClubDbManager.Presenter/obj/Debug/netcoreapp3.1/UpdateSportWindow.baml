   M S B A M L   `   `   `  ����W  SSportClubDbManager.Presenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SportClubDbManager.PresenterSportClubDbManager.Presenter  5   	   4    .SportClubDbManager.Presenter.UpdateSportWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:SportClubDbManager.Presenter     5   	     � Title$  UpdateSportWindow��5   	   $	��200��6#   $	��300��60   .��5	      � $	��184��6   $��Bottom=�6    � RowDefinitions 5
   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $��5* �6   .+�5   
   �� -   5         ��Name$ sportNameTextBox��5      $��1��6,   $��0��6<   $
��Left=�6I   $��0,0,0,0q�6d   $��Название��6u    �� TextWrapping$
 Wrap=�6�   $��Bottom=�6�   $	��125��6�   ${�False��6�   $��20��6�   �� 5   
   $,��&Название вида спорта��6   $��0��6/   $��0��6?   $
��Left=�6L   $��0,0,0,0q�6g   $��Bottom=�6x   �� 5   
   -   5         ��Name$ sportTypeComboBox��5      $��1��6.   $��1��6>   $��0,0,0,0q�6K   $	��125��6\   $��20��6h   $��Center=�6t   $
��Left=�6�   .@�5      �� $��парный��6   �� 5      $"��индивидуальный��6   5      �� 5   
   $��Тип��6   $
��Left=�6   $��0,0,0,0q�69   $��0��6J   $��1��6Z   $��Center=�6g   �� 5   
   -   5         ��Name$ updateButton��5      $��Изменить��6'   $��Center=�6:   $��1��6W   $��2��6g   $��0,0,0,0q�6t   $��Center=�6�   $��75��6�   $��25��6�   5      5      