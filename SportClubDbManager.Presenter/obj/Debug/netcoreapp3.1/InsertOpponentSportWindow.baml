   M S B A M L   `   `   `  ����W  SSportClubDbManager.Presenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SportClubDbManager.PresenterSportClubDbManager.Presenter  5   	   <    6SportClubDbManager.Presenter.InsertOpponentSportWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:SportClubDbManager.Presenter     5   	     � Title$  InsertOpponentSportWindow��5   	   $	��200��6+   $	��300��68   .��5	      � $	��184��6   $��Bottom=�6    � RowDefinitions 5
   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $��5* �6   .+�5   
   �� -   5         ��Name$ OpponentSportNameTextBox��5      $
��Left=�64   $��0,0,0,0q�6O    �� TextWrapping$
 Wrap=�6`   $��Bottom=�6t   $	��125��6�   $��1��6�   $��20��6�   $��0��6�   �� 5   
   $,��&Название вида спорта��6   $
��Left=�6/   $��0,0,0,0q�6J   $��Bottom=�6[   $��0��6v   $��26��6�   $	��133��6�   $��0��6�   �� 5   
   -   5         ��Name$ OpponentSportTypeComboBox��5      $��1��66   $��Center=�6F   $��1��6a   $
��Left=�6n   $	��125��6�   $��20��6�   .@�5      �� $��парный��6   �� 5      $"��индивидуальный��6   5      �� 5   
   $��Тип��6   $
��Left=�6   $��0,0,0,0q�69   $��Center=�6J   $��26��6e   $��30��6q   $��1��6|   �� 5   
   -   5         ��Name$ InsertButton��5      $��Добавить��6'   $��Center=�6:   $��0,0,0,0q�6W   $��Center=�6h   $��1��6�   $��25��6�   $��75��6�   $��2��6�   5      5      