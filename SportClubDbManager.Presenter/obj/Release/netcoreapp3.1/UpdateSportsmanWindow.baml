   M S B A M L   `   `   `  ���� W  SSportClubDbManager.Presenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SportClubDbManager.PresenterSportClubDbManager.Presenter  8    2SportClubDbManager.Presenter.UpdateSportsmanWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     <local*clr-namespace:SportClubDbManager.Presenter       � Title$  InsertSportWindow��$	��504��$	��300�� � 
ResizeMode$ NoResize=�.��� $	��492��$��Center=� � RowDefinitions �� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* ��� $	��42* � � ColumnDefinitions �� $��5* ��� $��5* �.+��� -    ��Name$ SportsmanCertNumTextBox��$
��Left=� �� TextWrapping$
 Wrap=�$��Bottom=�$	��125��$��1��$��20���� $'��!Номер сертификата��$
��Left=�$��0,0,0,0q�$��Bottom=�$��0��$��26��$	��133��$��0���� $��ФИО��$
��Left=�$��Bottom=�$��26��$��40��$��1���� -    ��Name$ UpdateButton��$��Изменить��$��Center=�$��Center=�$��1��$��26��$��74��$��12���� -   $ SportsmanFIOTextBox��$
��Left=�$
 Wrap=�$��Bottom=�$	��125��$��1��$��20��$��0,0,0,0q�$��1���� -   $ SportsmanLevelTextBox��$
��Left=�$��0,0,0,0q�$��3��$
 Wrap=�$��Bottom=�$	��125��$��1��$��20���� $��Уровень��$
��Left=�$��0,0,0,0q�$��3��$��Bottom=��� $��Рейтинг��$
��Left=�$��0,0,0,0q�$��4��$��Bottom=��� -   $ SportsmanRatingTextBox��$
��Left=�$��0,0,0,0q�$��4��$
 Wrap=�$��Bottom=�$	��125��$��1��$��20���� $��Пол��$
��Left=�$��0,0,0,0q�$��2��$��Bottom=��� -    ��Name$ SportsmanSexComboBox��$��1��$
��Left=�$��0,0,0,0q�$��2��$��Bottom=�$	��125��$��20��.@��� $��м���� $��ж���� $��
Адрес��$
��Left=�$��0,0,0,0q�$��5��$��Bottom=�(  "System.Windows.Controls.DatePicker  -     Name$" SportsmanBirhtDateDatePicker��$��1��$
��Left=�$��0,0,0,0q�$��8��$��Bottom=�$	��125��$��25���� $'��!Мобильный телефон��$
��Left=�$��Bottom=�$��0��$��26��$	��133��$��0,0,0,0q�$��2��$��5���� -   $ SportsmanAddressTextBox��$
��Left=�$��0,0,0,0q�$��5��$
 Wrap=�$��Bottom=�$	��125��$��20��$��1���� -	   $! SportsmanMobilePhoneTextBox��$
��Left=�$��0,0,0,0q�$��6��$
 Wrap=�$��Bottom=�$	��125��$��20��$��1���� -
   $%��Домашний телефон��$
��Left=�$��Bottom=�$��0��$��26��$	��133��$��6��$��0,27,0,0q�$��2���� -   $ SportsmanHomePhoneTextBox��$
��Left=�$��7��$
 Wrap=�$��Bottom=�$	��125��$��20��$��1���� $��Дата рождения��$
��Left=�$��Center=�$��0��$��25��$	��133��$��8���� $*��$Дата начала занятий��$
��Left=�$��Bottom=�$��0��$��26��$	��133��$��8��$��0,0,0,0q�$��2��  -   $" SportsmanStartDateDatePicker��$
��Left=�$��0,0,0,0q�$��8��$��Bottom=�$��2��$��2��$��1��$	��125��$��25���� $��Тренер��$
��Left=�$��Bottom=�$��0��$��26��$	��133��$��10��$��0,0,0,0q�$��2���� $��Партнёр��$
��Left=�$��Bottom=�$��0��$��26��$	��133��$��9��$��0,0,0,0q�$��2���� -   $ SportsmanPartnerComboBox��$��1��$
��Left=�$��10��$��Bottom=�$	��125��$��20���� -   $ SportsmanTrainerComboBox��$��1��$
��Left=�$��0,0,0,0q�$��11��$��Bottom=�$	��125��$��20��