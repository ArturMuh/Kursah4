   M S B A M L   `   `   `  ����O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  5      5    /Мухутдинов.NewFolder1.IzdatelstvoPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Мухутдинов.NewFolder1     5      -   5          N� Title$  Издательство��5	      .��5      �  � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� .��5      �� 
�������.+�5      �� $	��134��6   $��17��6(   �� 65   $0�*Название издательства:��69   6Z   �� 5      -   5         ��Name$  IzdatelstvoNameSearchField��5      $	��199��6>   $��0,0,15,0q�6J   �� 5      -   5         ��Name$ IzdatelstvoSearchButton��5      $��80��6`   $��
Поиск��6k   &   System.Windows.Controls.DataGrid  5      -   5          Name$ IzdatelstvoDataGrid��5         AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID_izdatelstva��6-   -   5        "IzdatelstvoIDizdatelstvaColumn��
   
Visibility$
 	Collapsed=�5   n   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6�   �� *ID_izdatelstva+ �� Mode$ TwoWay=�  5      $	 Название��6-   -   5        IzdatelstvoNazvanieColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 5   b    6m   �� *
Nazvanie+$ TwoWay=�5      5      5      �� 5    
   -   5        $��Экспорт в Excel��5       $
��Left=�6+   $��
22,165,0,0q�6F   $��15(�6Z   $	��Top=�6h   $	��112��6�   $��1��6�   $��35��6�   �� 5!   
   $��Center=�6   $��Center=�60   $��1��6M   5"      �� 5#   
   -   5        $ IzdatelstvoTable��5#      $��Обновить��6,   $��1��6?   $
��Left=�6O   $��
22,124,0,0q�6j   $��20(�6~   $	��Top=�6�   $	��112��6�   $��36��6�   �� 5$   
   -	   5        $��Добавить��5$      $��1��6$   $
��Left=�64   $��143,125,0,0q�6O   $��20(�6d   $	��Top=�6s   $	��104��6�   $��36��6�   �� 5%   
   -
   5        $��Изменить��5%      $
��Left=�6%   $��143,166,0,0q�6@   $��20(�6U   $	��Top=�6c   $	��104��6{   $��1��6�   $��34��6�   �� 5&   
   -   5        $��buttonDelete��5&   ,   $��Удалить��6@   $
��Left=�6R   $��
22,205,0,0q�6m   $	��Top=�6�   $	��113��6�   $��1��6�   $��30��6�   $��20(�6�   �� 5'   
   $&�� Код издательства:��6   $
��Left=�6,   $��
533,29,0,0q�6G   $	��Top=�6[   $	��112��6s   $��26��6   $��2��6�   �� 5(   
   -   5        $��IDizdatelstvayaField��5(      $��1��6.   $
��Left=�6>   $��22��6Y   $��
107,31,0,0q�6e    �� TextWrapping$
 Wrap=�6y   $�� ��6�   $	��Top=�6�   $	��150��6�   �� 5)   
   $��Название:��6   $
��Left=�6$   $��
533,60,0,0q�6?   $	��Top=�6S   $��2��6k   �� 5*   
   -   5        $��NazvanieyaField��5*      $��1��6)   $
��Left=�69   $��23��6T   $��
102,59,0,0q�6`   $
 Wrap=�6t   $�� ��6�   $	��Top=�6�   $	��155��6�   5-      5.      