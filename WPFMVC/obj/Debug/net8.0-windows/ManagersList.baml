   M S B A M L   `   `   `  ����@  <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFUIWPFUI  5   	       WPFUI.ManagersList   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:WPFUI     5   	     � Title$  ManagersList��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ StudentShow��5
         AutoGenerateColumns$ False��6(      CanUserAddRows$ False��6D      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6[   $��0��6l   $	��338��6|   $	��Top=�6�   $��
10,50,10,0q�6�      MinRowHeight$ 30Q�6�      ColumnHeaderHeight$ 30Q�6�      AlternatingRowBackground
 ��ح� �� AlternationCount$ 2��6  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 老师ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Id+  5      $
 老师姓名��6%    63   �� *Name+  5      $
 年龄��6%    61   �� *Age+  5      $
 联系电话��6%    63   �� *Phone+4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 操作��6)      CellTemplate 5      �� 5      .R�5      � .+�5   "   ��  �� Orientation$ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5   &   �� -   5        $��40��5   -   $��20��68   $��编辑��6D   $��10(�6d   
 � Tag 6Q   �� *Id+6�   5   #   5      5      5      5      5      5      