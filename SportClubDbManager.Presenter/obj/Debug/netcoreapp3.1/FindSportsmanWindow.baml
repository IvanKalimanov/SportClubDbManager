   M S B A M L   `   `   `  ����W  SSportClubDbManager.Presenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SportClubDbManager.PresenterSportClubDbManager.Presenter  5   	   6    0SportClubDbManager.Presenter.FindSportsmanWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:SportClubDbManager.Presenter     5   	     � Title$  FindSportWindow��5   	   $	��504��6!   $	��600��6.    � 
ResizeMode$ NoResize=�6:   .��5	      � $	��492��6   $��Center=�6    � RowDefinitions 5
   
   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $
��168* �6    � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $��5* �6   .+�5   
   �� $��ФИО��6   $
��Left=�6   $��Bottom=�69   $��26��6T   $��40��6`   $��1��6k   �� 5   
   -   5         ��Name$ SearchButton��5      $��
Поиск��6'   $
��Left=�67   $��Center=�6R   $��1��6�   $��26��6�   $��74��6�   $��7��6�   �� 5   
   -   5         ��Name$ SportsmanFIOTextBox��5      $
��Left=�6/    �� TextWrapping$
 Wrap=�6J   $��Bottom=�6^   $	��125��6y   $��1��6�   $��20��6�   $��0,0,0,0q�6�   $��1��6�   �� 5   
   -   5        $ SportsmanLevelTextBox��5      $
��Left=�61   $��0,0,0,0q�6L   $��3��6]   $
 Wrap=�6j   $��Bottom=�6~   $	��125��6�   $��1��6�   $��20��6�   �� 5   
   $��Уровень��6   $
��Left=�6"   $��0,0,0,0q�6=   $��3��6N   $��Bottom=�6[   �� 5   
   $��Пол��6   $
��Left=�6   $��0,0,0,0q�69   $��2��6J   $��Bottom=�6W   �� 5   
   -   5         ��Name$ SportsmanSexComboBox��5      $��1��61   $
��Left=�6A   $��0,0,0,0q�6\   $��2��6m   $��Bottom=�6z   $	��125��6�   $��20��6�   .@�5       �� $��м��6   �� 5!      $��ж��6   5"      �� 5#   
   $��
Адрес��6   $
��Left=�6    $��0,0,0,0q�6;   $��4��6L   $��Bottom=�6Y   (  "System.Windows.Controls.DatePicker  5$   
   -   5          Name$" SportsmanBirhtDateDatePicker��5$      $��1��6;   $
��Left=�6K   $��0,0,0,0q�6f   $��5��6w   $��Bottom=�6�   $	��125��6�   $��25��6�   �� 5%   
   -   5        $ SportsmanAddressTextBox��5%      $
��Left=�63   $��0,0,0,0q�6N   $��4��6_   $
 Wrap=�6l   $��Bottom=�6�   $	��125��6�   $��20��6�   $��1��6�   �� 5&   
   $��Дата рождения��6   $
��Left=�6(   $��Center=�6C   $��0��6^   $��25��6n   $	��133��6z   $��5��6�   �� 5'   
   $*��$Дата начала занятий��6   $
��Left=�6.   $��Bottom=�6I   $��0��6d   $��26��6t   $	��133��6�   $��6��6�   $��0,0,0,0q�6�     5(   
   -   5        $" SportsmanStartDateDatePicker��5(      $
��Left=�6;   $��0,0,0,0q�6V   $��6��6g   $��Bottom=�6t   $��2��6�   $��1��6�   $	��125��6�   $��25��6�   &   System.Windows.Controls.DataGrid  5)   
   -   5        	  Name$	 Table��5)      $��8��6"   $��2��6/   5+      5,      