   M S B A M L   `   `   `  ����W  SSportClubDbManager.Presenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SportClubDbManager.PresenterSportClubDbManager.Presenter  5   	   >    8SportClubDbManager.Presenter.InsertPreviousTrainerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:SportClubDbManager.Presenter     5   	     � Title$  InsertSportWindow��5   	   $	��263��6#   $	��324��60    � 
ResizeMode$ NoResize=�6<   .��5	      � $	��202��6   $��Center=�6    � RowDefinitions 5
   
   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6    � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $��5* �6   .+�5   
   �� -   5         ��Name$ insertButton��5      $��Добавить��6'   $��Center=�6:   $��Center=�6W   $��1��6�   $��26��6�   $��74��6�   $��4��6�   �� 5   
   $0��*Дата окончания занятий��6   $
��Left=�61   $��Bottom=�6L   $��0��6g   $��26��6w   $	��145��6�   $��0,0,0,0q�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$&  PreviousTrainerEndDateDatePicker��5      $
��Left=�6?   $��0,0,0,0q�6Z   $��Bottom=�6k   $��1��6�   $	��125��6�   $��25��6�   �� 5   
   $��Тренер��6   $
��Left=�6!   $��Bottom=�6<   $��0��6W   $��26��6g   $	��133��6s   $��2��6   $��0,0,0,0q�6�   �� 5   
   $��Спортсмен��6   $
��Left=�6$   $��Bottom=�6?   $��0��6Z   $��26��6j   $	��133��6v   $��1��6�   $��0,0,0,0q�6�   �� 5   
   -   5         ��Name$ SportsmanComboBox��5      $��1��6.   $
��Left=�6>   $��1��6Y   $��Bottom=�6f   $	��125��6�   $��20��6�   $��0,0,0,0q�6�   6�   �� 5   
   -   5        $ TrainerComboBox��5      $��1��6,   $
��Left=�6<   $��0,0,0,0q�6W   $��2��6h   $��Bottom=�6u   $	��125��6�   $��20��6�   5      5      