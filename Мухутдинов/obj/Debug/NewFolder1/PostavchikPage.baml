   M S B A M L   `   `   `  ����O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  5      4    .Мухутдинов.NewFolder1.PostavchikPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TXceed.Wpf.Toolkit, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      9local-clr-namespace:Мухутдинов.NewFolder1  5      -   5          N� Title$  Поставщик��5
      .��5      �  � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� .��5      �� 
�������.+�5      �� $	��134��6   $��17��6(   �� 65   $,�&Название поставщика:��69   6X   �� 5      -   5         ��Name$ PostavchikNameSearchField��5      $	��199��6=   $��0,0,15,0q�6I   �� 5      -   5         ��Name$ PostavchikSearchButton��5      $��80��6^   $��
Поиск��6i   &   System.Windows.Controls.DataGrid  5      -   5          Name$ PostavshikDataGrid��5         AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ID_postavshika��6-   -   5        "PostavchikID_postavshikaColumn��
   
Visibility$
 	Collapsed=�5   n   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6�   �� *ID_postavshika+ �� Mode$ TwoWay=�  5      $	 Название��6-   -   5        PostavchikNazvanieColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 5   a    6l   �� *
Nazvanie+$ TwoWay=�  5      $	 
Адрес��6-   -   5        PostavchikAdressColumn��$ 2* 5   \    6g   �� *Adress+$ TwoWay=�  5      $	 Телефон��6-   -   5        PostavchikTelefonColumn��$ 2* 5   _    6j   �� *	Telefon+$ TwoWay=�  5      $	 Email��6-   -	   5        PostavchikEmailColumn��$ 2* 5   [    6f   �� *Email+$ TwoWay=�5!      5"      5#      �� 5$   
   -
   5        $��Экспорт в Excel��5$      $
��Left=�6+   $��
21,211,0,0q�6F   $��15(�6Z   $	��Top=�6h   $	��113��6�   $��1��6�   $��35��6�    J� RenderTransformOrigin$ 0.327,0.106&�6�   �� 5%   
   $��Center=�6   $��Center=�60   $��1��6M   5&      �� 5'   
   -   5        $ PostavchikTable��5'      $��Обновить��6+   $��1��6>   $
��Left=�6N   $��
21,170,0,0q�6i   $��20(�6}   $	��Top=�6�   $	��113��6�   $��36��6�   �� 5(   
   -   5        $��Добавить��5(      $��1��6$   $
��Left=�64   $��142,170,0,0q�6O   $��20(�6d   $	��Top=�6s   $	��110��6�   $��36��6�   �� 5)   
   -   5        $��Изменить��5)      $
��Left=�6%   $��142,211,0,0q�6@   $��20(�6U   $	��Top=�6c   $	��110��6{   $��1��6�   $��35��6�   �� 5*   
   $��ID поставщика:��6   $��1��6)   $
��Left=�69   $��5,27,0,0q�6T   $	��Top=�6f   $��92��6~   $��26��6�   �� 5+   
   -   5        $��IDpostavshikayaField��5+      $��1��6.   $
��Left=�6>   $��22��6Y   $��
102,31,0,0q�6e    �� TextWrapping$
 Wrap=�6y   $�� ��6�   $	��Top=�6�   $	��150��6�   �� 5,   
   $��Название:��6   $��1��6$   $
��Left=�64   $��5,58,0,0q�6O   $	��Top=�6a   �� 5-   
   -   5        $��NazvanieyaField��5-      $��1��6)   $
��Left=�69   $��23��6T   $��
102,59,0,0q�6`   $
 Wrap=�6t   $�� ��6�   $	��Top=�6�   $	��150��6�   �� 5.   
   $��Адрес:��6   $��1��6!   $
��Left=�61   $��5,89,0,0q�6L   $	��Top=�6^   �� 5/   
   -   5        $��AdressField��5/      $��1��6%   $
��Left=�65   $��
102,93,0,0q�6P   $
 Wrap=�6d   $	��Top=�6y   $	��150��6�   $��22��6�   �� 50   
   $��Телефон:��6   $
��Left=�6#   $��	5,119,0,0q�6>   $	��Top=�6Q   $ 0.474,0.578&�6i   $��1��6�   %  Xceed.Wpf.Toolkit.MaskedTextBox  51   
   -   5        $��maskedtextboxPhoneNumber��51         Mask$ +7(000)-000-00-00��6=   $��1��6V   $	��Top=�6f   $
��Left=�6~   $��102,123,0,0q�6�   $	��150��6�   �� 52   
   $��Email:��6   $
��Left=�6!   $��
10,144,0,0q�6<   $	��Top=�6P   $ 0.474,0.578&�6h   $��1��6�     53   
   -   5        $��maskedtextboxEmailNumber��53      $ ?????????????@????/??��6=   $��1��6Z   $	��Top=�6j   $
��Left=�6�   $��102,148,0,0q�6�   $	��150��6�   �� 54   
   -   5        $ Delete��54      $��Удалить��6!   $
��Left=�64   $��
21,251,0,0q�6O   $��20(�6c   $	��Top=�6q   $	��113��6�   $��1��6�   $��35��6�   57      58      