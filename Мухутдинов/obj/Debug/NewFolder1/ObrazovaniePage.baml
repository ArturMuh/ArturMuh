   M S B A M L   `   `   `  ����O  KМухутдинов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:Мухутдинов.NewFolder1Мухутдинов.NewFolder1  5      5    /Мухутдинов.NewFolder1.ObrazovaniePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:Мухутдинов.NewFolder1     5      -   5          N� Title$  Образование��5	      .��5
      �  � RowDefinitions 5   
   �� 5       � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $��1* �6   6,   .+�5   
   �� .��5      �� 
�������.+�5      &   System.Windows.Controls.DataGrid  -   5        $��ObrazovanieDataGrid��5         AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6-   -   5        ObrazovanieIDColumn��   
Visibility$ 	Collapsed=�5   W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6n   �� *id+	 �� Mode$	 TwoWay=�  5      $) #Название документа��6-   -   5         ObrazovanieNazvanieDocColumn��
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 2* 5   o    6z   �� *Nazvanie_doc+$	 TwoWay=�  5      $ 
Серия��6-   -   5        ObrazovanieSeriaColumn��$
 1* 5   \    6g   �� *Seria+$	 TwoWay=�  5      $# Номер документа��6-   -   5        ObrazovanieNomerDocColumn��$
 1* 5   i    6t   �� *	Nomer_doc+$	 TwoWay=�  5      $ Средний балл��6-   -   5        ObrazovanieSrBallColumn��$
 1* 5   d    6o   �� *Srednie_ball+$	 TwoWay=�4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        ObrazovanieDeleteColumn��$

 0.8* 5   R      CellTemplate 5      �� 5   "   .R�5   &   �� -	   5        .��5   B   Удалить6K   5   #   5!      5#      5$      5%      �� 5&   
   $��Center=�6   $��Center=�60   $��1��6M   .+�5'      �� -
   5        $��ObrazovanieTable��5'   "   $	��0,5q�6   .��5(      �� $��5q�6   $��20(�6'   Обновить6?   5)      5+      5.      5/      