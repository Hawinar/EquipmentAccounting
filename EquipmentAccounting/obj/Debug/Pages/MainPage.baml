   M S B A M L   `   `   `  ����N  JEquipmentAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:EquipmentAccounting.PagesEquipmentAccounting.Pages  5      (    "EquipmentAccounting.Pages.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:EquipmentAccounting.Pages     5        N� Title$  MainPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��203* �6   �� 5      $��30 �6    � ColumnDefinitions 5   
   �� 5      $��70 �6   �� 5      $
��133* �6   �� 5      $	��150 �6   .+�5   
   �� -   5        $��Добавить��5      $��1��5      $��1��5      $��0,0,0,-2q�5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGEquipment��5      $��0��5      $��1��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Тип��5$      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5%      �� *Type+  5&      $ 
Номер��5'       5(      �� *Number+  5)      $$ Местонахождение��5*       5+      �� *
Location+  5,      $ Статус��5-       5.      �� *Status+4  .System.Windows.Controls.DataGridTemplateColumn  5/      	   CellTemplate	 50      �� 51      .R�52      �� -   5        $��
Фокус��52   %   53   !   54      56        57      	 58      �� 59      .R�5:      �� -   5        $ ��Редактировать��5:   %   5;   !   5<      5>        5?      	 5@      �� 5A      .R�5B      �� -   5        $��Удалить��5B   %   5C   !   5D      5F      5H      �� 5I   
   $��0��6   $��2��6"   .+�5J      �� -   5        
 ��Name$
 cbSizeBy��5J       �� SelectedIndex$ 0��6)   .@�5K      �� $��Тип��6   �� 5L      $��
Номер��6   �� 5M      $$��Местонахождение��6   �� 5N      $��Статус��6   5O      �� 5Q      -   5         ��Name$ tbTarget��5R      $��Center=�5S      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Введите искомое��5T       %  !MaterialDesignFloatingHintTextBox#��[  5U      �� 5W      -   5        $��
Поиск��5W      $��
10,10,10,0q�5X      5Y      �� 5[      -	   5        $��Сброс поиска��5[      $��
10,10,10,0q�5\      5]      5_      5`      5a      