   M S B A M L   `   `   `  ����O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  5      0    *Мухутдинов.NewFolder1.AvtoryPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Мухутдинов.NewFolder1     5      -   5          N� Title$  Авторы��5	      .��5      �  � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� .��5      �� 
�������.+�5      �� $	��134��6   $��17��6(   �� 65   $%�Поиск по фамилии:��69   6U   �� 5      -   5         ��Name$ AvtoryNameSearchField��5      $	��199��69   $��0,0,15,0q�6E   �� 5      -   5         ��Name$ AvtorySearchButton��5      $��80��6V   $��
Поиск��6a   &   System.Windows.Controls.DataGrid  5      -   5          Name$ AvtoryDataGrid��5         AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 	ID_avtory��6-   -   5        AvtoryIDavtoryColumn��
   
Visibility$
 	Collapsed=�5   _   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6v   �� *	ID_avtory+ �� Mode$ TwoWay=�  5      $,	 &Фамилия Имя Отчество��6-   -   5        AvtoryFamiliaColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 5   h    6s   �� *FIO+$ TwoWay=�5      5      5      �� 5    
   -   5        $��Экспорт в Excel��5       $
��Left=�6+   $��
19,176,0,0q�6F   $��15(�6Z   $	��Top=�6h   $	��110��6�   $��1��6�   $��39��6�   �� 5!   
   $��Center=�6   $��Center=�60   $��1��6M   5"      �� 5#   
   -   5        $ AvtoryTable��5#      $��Обновить��6'   $��1��6:   $
��Left=�6J   $��
19,129,0,0q�6e   $��20(�6y   $	��Top=�6�   $	��110��6�   $��36��6�   �� 5$   
   -	   5        $��Добавить��5$      $��1��6$   $
��Left=�64   $��134,129,0,0q�6O   $��20(�6d   $	��Top=�6s   $	��102��6�   $��36��6�   �� 5%   
   -
   5        $��Изменить��5%      $
��Left=�6%   $��134,176,0,0q�6@   $��20(�6U   $	��Top=�6c   $	��102��6{   $��1��6�   $��39��6�   �� 5&   
   -   5        $��buttonDelete��5&   ,   $��Удалить��6@   $
��Left=�6R   $��134,225,0,0q�6m   $	��Top=�6�   $	��102��6�   $��1��6�   $��31��6�   $��20(�6�   �� 5'   
   $��Номер автора:��6   $��1��6(   $
��Left=�68   $��5,27,0,0q�6S   $	��Top=�6e   $��92��6}   $��26��6�   �� 5(   
   -   5        $��IDavtoryyaField��5(      $��1��6)   $
��Left=�69   $��22��6T   $��
102,31,0,0q�6`    �� TextWrapping$
 Wrap=�6t   $�� ��6�   $	��Top=�6�   $	��150��6�   �� 5)   
   $��ФИО:��6   $��1��6   $
��Left=�6/   $��5,58,0,0q�6J   $	��Top=�6\   �� 5*   
   -   5        $��FamiliayaField��5*      $��1��6(   $
��Left=�68   $��51��6S   $��
102,59,0,0q�6_   $
 Wrap=�6s   $�� ��6�   $	��Top=�6�   $	��150��6�   5,      5-      