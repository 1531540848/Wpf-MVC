   M S B A M L   `   `   `  ����@  <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFMVCWPFMVC  5   	       WPFMVC.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPFMVC     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��0,0,0,3q�6    � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5        $��StuKey��5   H   $
��Left=�6   $��	93,10,0,0q�6-   $�� ��6@    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��244��6�   $��30��6�   $��18(�6�   �� 5   
   $��关键字：��6   $
��Left=�6   $��	32,10,0,0q�6:   $	��Top=�6M   $��30��6e   $��57��6q   6~   �� 5   
   -   5        $��
SetStudent��5      $��查询��6   $
��Left=�60   $��
362,10,0,0q�6K   $	��Top=�6_   $��30��6w   $��60��6�   6�   �� 5   
   -   5        $��
SetManager��5       $��老师列表��6   $
��Left=�62   $��
500,10,0,0q�6M   $	��Top=�6a   $��30��6y   $��60��6�   6�   �� 5   
   -   5        $��Refresh��5   :   $��刷新��6   $��Right=�6   $��
0,10,112,0q�6I   $	��Top=�6]   $��30��6u   $��60��6�    J� RenderTransformOrigin$ -3.308,0.523&�6�   6�   �� 5   
   -   5        $��AddStu��5   :   $��添加��6   $��Right=�6   $��	0,10,30,0q�6H   $	��Top=�6[   $��30��6s   $��59��6   6�   �� 5   
   $��1��6   $��-352,59,-348,0q�6   
���   �$	��Top=�6F   $
��1500��6^   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ StudentShow��5         AutoGenerateColumns$ False��6(      CanUserAddRows$ False��6D      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6[   $��0��6l   $	��338��6|   $	��Top=�6�   $��
10,83,10,0q�6�      MinRowHeight$ 30Q�6�   	   ColumnHeaderHeight$	 30Q�6�   
   AlternatingRowBackground

 ��ح� �� AlternationCount$ 2��6     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 学生ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Id+  5      $ 学生姓名��6%    63   �� *StudentName+  5      $ 性别��6%    61   �� *Gender+  5      $ 出生年月��6%    63   �� *
Birthday+  5      $ 家庭住址��6%    63   �� *	Address+  5      $ 家长电话��6%    63   �� *PatriarchTel+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 操作��6)      CellTemplate 5      �� 5      .R�5      � .+�5    "   ��  �� Orientation$ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5!   &   �� -   5        $��40��5!   -   $��20��68   $��编辑��6D   $��10(�6d   
 � Tag 6Q   �� *Id+6�   �� 5"   &   $��DeleteDetail��6D   -   5        $��40��5"   -   $��20��68   $��10,0,0,0q�6l   $��删除��6~   $��10(�6�    6Y   �� *Id+6�   5#   #   5$      5%      5'      5)      5*      5+      