   M S B A M L   `   `   `  ����W  SSportClubDbManager.Presenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SportClubDbManager.PresenterSportClubDbManager.Presenter  5   	   6    0SportClubDbManager.Presenter.InsertTrainerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:SportClubDbManager.Presenter     5   	     � Title$  InsertSportWindow��5   	   $	��284��6#   $	��300��60    � 
ResizeMode$ NoResize=�6<   .��5	      � $	��252��6   $��Center=�6    � RowDefinitions 5
   
   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6    � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $��5* �6   .+�5   
   �� -   5         ��Name$ TrainerIdTextBox��5      $
��Left=�6,    �� TextWrapping$
 Wrap=�6G   $��Bottom=�6[   $	��125��6v   $��1��6�   $��20��6�   6�   �� 5   
   $ ��Идентификатор��6   $
��Left=�6(   $��0,0,0,0q�6C   $��Bottom=�6T   $��0��6o   $��26��6   $	��133��6�   $��0��6�   �� 5   
   $��ФИО��6   $
��Left=�6   $��Bottom=�69   $��26��6T   $��40��6`   $��1��6k   �� 5   
   -   5         ��Name$ insertButton��5      $��Добавить��6'   $��Center=�6:   $��Center=�6W   $��1��6�   $��26��6�   $��74��6�   $��5��6�   �� 5   
   -   5        $ TrainerFIOTextBox��5      $
��Left=�6-   $
 Wrap=�6H   $��Bottom=�6\   $	��125��6w   $��1��6�   $��20��6�   $��0,0,0,0q�6�   $��1��6�   �� 5   
   -   5        $ TrainerLevelTextBox��5      $
��Left=�6/   $��0,0,0,0q�6J   $��3��6[   $
 Wrap=�6h   $��Bottom=�6|   $	��125��6�   $��1��6�   $��20��6�   �� 5   
   $��Уровень��6   $
��Left=�6"   $��0,0,0,0q�6=   $��3��6N   $��Bottom=�6[   �� 5   
   $��Рейтинг��6   $
��Left=�6"   $��0,0,0,0q�6=   $��4��6N   $��Bottom=�6[   �� 5   
   -   5        $ TrainerRatingTextBox��5      $
��Left=�60   $��0,0,0,0q�6K   $��4��6\   $
 Wrap=�6i   $��Bottom=�6�   $	��125��6�   $��1��6(  $��20��68  �� 5   
   $��Вид спорта��6   $
��Left=�6%   $��0,0,0,0q�6@   $��2��6Q   $��Bottom=�6^   �� 5    
   -   5         ��Name$ TrainerSportComboBox��5       $��1��61   $
��Left=�6A   $��0,0,0,0q�6\   $��2��6m   $��Bottom=�6z   $	��125��6�   $��20��6�   5"      5#      