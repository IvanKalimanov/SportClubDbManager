   M S B A M L   `   `   `  ���� W  SSportClubDbManager.Presenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SportClubDbManager.PresenterSportClubDbManager.Presenter  6    0SportClubDbManager.Presenter.InsertTrainerWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     <local*clr-namespace:SportClubDbManager.Presenter       � Title$  InsertTrainerWindow��$	��284��$	��300�� � 
ResizeMode$ NoResize=�.��� $	��252��$��Center=� � RowDefinitions �� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* � � ColumnDefinitions �� $��4* ��� $	��11* ��� $	��15* �.+��� -    ��Name$ TrainerIdTextBox��$
��Left=� �� TextWrapping$
 Wrap=�$��Bottom=�$	��125��$��2��$��20���� $ ��Идентификатор��$
��Left=�$��0,0,0,0q�$��Bottom=�$��0��$��26��$	��133��$��0��$��2���� $��ФИО��$��Center=�$	��Top=�$��26��$��40��$��1��$��0,16,0,0q��� -    ��Name$ insertButton��$��Добавить��$��Center=�$��Center=�$��2��$��26��$��74��$��5���� -   $ TrainerFIOTextBox��$
��Left=�$
 Wrap=�$��Bottom=�$	��125��$��2��$��20��$��0,0,0,0q�$��1���� -   $ TrainerLevelTextBox��$
��Left=�$��0,0,0,0q�$��3��$
 Wrap=�$��Bottom=�$	��125��$��2��$��20���� $��Уровень��$
��Left=�$��0,0,0,0q�$��3��$��Bottom=�$��2���� $��Рейтинг��$
��Left=�$��0,0,0,0q�$��4��$��Bottom=�$��2���� -   $ TrainerRatingTextBox��$
��Left=�$��0,0,0,0q�$��4��$
 Wrap=�$��Bottom=�$	��125��$��2��$��20���� $��Вид спорта��$
��Left=�$��0,0,0,0q�$��2��$��Bottom=�$��2���� -    ��Name$ TrainerSportComboBox��$��2��$
��Left=�$��0,0,0,0q�$��2��$��Bottom=�$	��125��$��20��