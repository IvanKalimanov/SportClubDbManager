   M S B A M L   `   `   `  ���� W  SSportClubDbManager.Presenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SportClubDbManager.PresenterSportClubDbManager.Presenter  -    'SportClubDbManager.Presenter.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     <local*clr-namespace:SportClubDbManager.Presenter       � Title$  
MainWindow��$	��450��$	��800�� � 
ResizeMode$ NoResize=�.��� .+�o� $��25��$	��Top=�.@�m� -    m�Name$ ReportMenuItem��$��Отчёты��.@�m� -   $" SportsmenMovesReportMenuItem��$-��'Переходы спортсменов��m� -   $$ PairedSportErrorReportMenuItem��$>��8Ошибки для парных видов спорта��m� -   $) #SportsmenWithoutMovesReportMenuItem��$4��.Спортсмены без переходов��m� -   $% OpponentSameSportReportMenuItem��$:��4Виды спорта как у конкурента��m� -   $ SearchMenuItem��$��
Поиск���� -    ��Name$ ButtonsTubControl��$��
0,24,0,315q�$��2��.@��� -    ��Name$ SportTabItem��$��Виды спорта��$��
-2,-2,-2,0q�.��� ���	#FFE5E5E5$��65�� � ColumnDefinitions �� $��6* ��� $	��40* ��� $	��40* ��� $	��40* ��� $	��15* ��� $	��10* ��� $
��246* �.+��� -	    ��Name$ SportInsertButton��$��Добавить��$��1��$
��Left=�$��0,9,0,0q�$	��Top=�$��25��$��75���� -
   $ UpdateSportButton��$��Изменить��$��2��$
��Left=�$��0,9,0,0q�$	��Top=�$��25��$��75���� -   $ DeleteSportButton��$��Удалить��$��3��$
��Left=�$��0,9,0,0q�$	��Top=�$��75��$��25���� -   $ SportsmenTabItem��$��Спортсмены��$��
-2,-2,-2,0q�.��� ���	#FFE5E5E5$��65�� �� $��6* ��� $	��40* ��� $	��40* ��� $	��40* ��� $	��15* ��� $	��10* ��� $
��246* �.+��� -   $ SportsmanInsertButton��$��Добавить��$
��Left=�$��0,9,0,0q�$	��Top=�$��25��$��75��$��1���� -   $ UpdateSportsmanButton��$��Изменить��$��2��$
��Left=�$��0,9,0,0q�$	��Top=�$��25��$��75���� -   $ DeleteSportsmanButton��$��Удалить��$��3��$
��Left=�$��0,9,0,0q�$	��Top=�$��75��$��25���� -   $ TrainersTabItem��$��Тренеры��$��
-2,-2,-2,0q�.��� ���	#FFE5E5E5.+�� ���	#FFE5E5E5$��0,1,0,1q� �� $��6* ��� $	��40* ��� $	��40* ��� $	��40* ��� $	��15* ��� $	��10* ��� $
��246* �.+��� -   $ TrainerInsertButton��$��Добавить��$
��Left=�$��0,9,0,0q�$	��Top=�$��25��$��75��$��1���� -   $ UpdateTrainerButton��$��Изменить��$��2��$
��Left=�$��0,9,0,0q�$	��Top=�$��25��$��75���� -   $ DeleteTrainerButton��$��Удалить��$��3��$
��Left=�$��0,9,0,0q�$	��Top=�$��75��$��25���� -   $ OpponentSportTabItem��$3��-Виды спорта у конкурента��$��
-2,-2,-2,0q�.��� ���	#FFE5E5E5.+�� ���	#FFE5E5E5$��0,1,0,1q� �� $��6* ��� $	��40* ��� $	��40* ��� $	��40* ��� $	��15* ��� $	��10* ��� $
��246* �.+��� -   $ OpponentSportInsertButton��$��Добавить��$
��Left=�$��0,9,0,0q�$	��Top=�$��25��$��75��$��1���� -   $ UpdateOpponentSportButton��$��Изменить��$��2��$
��Left=�$��0,9,0,0q�$	��Top=�$��25��$��75���� -   $ DeleteOpponentSportButton��$��Удалить��$��3��$
��Left=�$��0,9,0,0q�$	��Top=�$��75��$��25���� -   $ PreviousTrainerTabItem��$)��#Предыдущие тренеры��$��
-2,-2,-2,0q�$��Stretch=�.��� ���	#FFE5E5E5 �� $
��101* ��� $
��296* �.+�� ���	#FFE5E5E5$��0,1,0,1q�$��2�� �� $��6* ��� $	��40* ��� $	��40* ��� $	��40* ��� $	��15* ��� $	��10* ��� $
��246* �.+��� -   $! PreviousTrainerInsertButton��$��Добавить��$
��Left=�$��0,9,0,0q�$	��Top=�$��25��$��75��$��1���� -   $! PreviousUpdateTrainerButton��$��Изменить��$��2��$
��Left=�$��0,9,0,0q�$	��Top=�$��25��$��75���� -   $! DeletePreviousTrainerButton��$��Удалить��$��3��$
��Left=�$��0,9,0,0q�$	��Top=�$��75��$��25��&   System.Windows.Controls.DataGrid  -     Name$ Table��$��	0,119,0,0q�$��2��