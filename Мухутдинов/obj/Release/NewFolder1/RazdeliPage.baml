   M S B A M L   `   `   `  ���� O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  1    +Мухутдинов.NewFolder1.RazdeliPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ?local-clr-namespace:Мухутдинов.NewFolder1     -     N� Title$  Раздел��.���  � RowDefinitions ��  � ColumnDefinitions �� $��2* ��� $��1* �.+��� .���� 
�������.+��� $	��134��$��17���� $&� Название раздела:���� -    ��Name$ RazdeliNameSearchField��$	��199��$��0,0,15,0q��� -    ��Name$ RazdeliSearchButton��$��80��$��
Поиск��&   System.Windows.Controls.DataGrid  -     Name$ RazdeliDataGrid��   AutoGenerateColumns .     CanUserAddRows .     Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 
ID_razdela��-   RazdeliIDrazdelaColumn��
   
Visibility$
 	Collapsed=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
ID_razdela+ �� Mode$ TwoWay=�  $	 Раздел��-   RazdeliRazdelColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2*  �� *Razdel+$ TwoWay=��� -   $��Экспорт в Excel��$
��Left=�$��
24,169,0,0q�$��15(�$	��Top=�$	��123��$��1��$��35���� $��Center=�$��Center=�$��1���� -   $ RazdeliTable��$��Обновить��$��1��$
��Left=�$��
24,128,0,0q�$��20(�$	��Top=�$	��123��$��36���� -	   $��Добавить��$��1��$
��Left=�$��152,128,0,0q�$��20(�$	��Top=�$	��100��$��36���� -
   $��Изменить��$
��Left=�$��152,169,0,0q�$��20(�$	��Top=�$	��100��$��1��$��34���� -   $��buttonDelete��$��Удалить��$
��Left=�$��
24,209,0,0q�$	��Top=�$	��123��$��1��$��36��$��20(��� $ ��Номер раздела:��$��1��$
��Left=�$��5,27,0,0q�$	��Top=�$	��103��$��26���� -   $��ID_razdelayaField��$��1��$
��Left=�$��22��$��
102,32,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��150���� $��Раздел:��$��1��$
��Left=�$��5,58,0,0q�$	��Top=��� -   $��RazdelyaField��$��1��$
��Left=�$��46��$��
102,59,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��150��