   M S B A M L   `   `   `  ���� O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  4    .Мухутдинов.NewFolder1.PostavchikPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     X TXceed.Wpf.Toolkit, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  9local-clr-namespace:Мухутдинов.NewFolder1  -     N� Title$  Поставщик��.���  � RowDefinitions ��  � ColumnDefinitions �� $��2* ��� $��1* �.+��� .���� 
�������.+��� $	��134��$��17���� $,�&Название поставщика:���� -    ��Name$ PostavchikNameSearchField��$	��199��$��0,0,15,0q��� -    ��Name$ PostavchikSearchButton��$��80��$��
Поиск��&   System.Windows.Controls.DataGrid  -     Name$ PostavshikDataGrid��   AutoGenerateColumns .     CanUserAddRows .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID_postavshika��-   "PostavchikID_postavshikaColumn��
   
Visibility$
 	Collapsed=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ID_postavshika+ �� Mode$ TwoWay=�  $	 Название��-   PostavchikNazvanieColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2*  �� *
Nazvanie+$ TwoWay=�  $	 
Адрес��-   PostavchikAdressColumn��$ 2*  �� *Adress+$ TwoWay=�  $	 Телефон��-   PostavchikTelefonColumn��$ 2*  �� *	Telefon+$ TwoWay=�  $	 Email��-	   PostavchikEmailColumn��$ 2*  �� *Email+$ TwoWay=��� -
   $��Экспорт в Excel��$
��Left=�$��
21,211,0,0q�$��15(�$	��Top=�$	��113��$��1��$��35�� J� RenderTransformOrigin$ 0.327,0.106&��� $��Center=�$��Center=�$��1���� -   $ PostavchikTable��$��Обновить��$��1��$
��Left=�$��
21,170,0,0q�$��20(�$	��Top=�$	��113��$��36���� -   $��Добавить��$��1��$
��Left=�$��142,170,0,0q�$��20(�$	��Top=�$	��110��$��36���� -   $��Изменить��$
��Left=�$��142,211,0,0q�$��20(�$	��Top=�$	��110��$��1��$��35���� $��ID поставщика:��$��1��$
��Left=�$��5,27,0,0q�$	��Top=�$��92��$��26���� -   $��IDpostavshikayaField��$��1��$
��Left=�$��22��$��
102,31,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��150���� $��Название:��$��1��$
��Left=�$��5,58,0,0q�$	��Top=��� -   $��NazvanieyaField��$��1��$
��Left=�$��23��$��
102,59,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��150���� $��Адрес:��$��1��$
��Left=�$��5,89,0,0q�$	��Top=��� -   $��AdressField��$��1��$
��Left=�$��
102,93,0,0q�$
 Wrap=�$	��Top=�$	��150��$��22���� $��Телефон:��$
��Left=�$��	5,119,0,0q�$	��Top=�$ 0.474,0.578&�$��1��%  Xceed.Wpf.Toolkit.MaskedTextBox  -   $��maskedtextboxPhoneNumber��   Mask$ +7(000)-000-00-00��$��1��$	��Top=�$
��Left=�$��102,123,0,0q�$	��150���� $��Email:��$
��Left=�$��
10,144,0,0q�$	��Top=�$ 0.474,0.578&�$��1��  -   $��maskedtextboxEmailNumber��$ ?????????????@????/??��$��1��$	��Top=�$
��Left=�$��102,148,0,0q�$	��150���� -   $ Delete��$��Удалить��$
��Left=�$��
21,251,0,0q�$��20(�$	��Top=�$	��113��$��1��$��35��