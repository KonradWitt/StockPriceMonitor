   M S B A M L   `   `   `  ����L  HStockPriceMonitor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StockPriceMonitorStockPriceMonitor  5   	   I)clr-namespace:StockPriceMonitor.ViewModelStockPriceMonitor.ViewModel  5   	   K*clr-namespace:StockPriceMonitor.ConvertersStockPriceMonitor.Converters  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	   	   "    StockPriceMonitor.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StockPriceMonitor     5   	   8vm)clr-namespace:StockPriceMonitor.ViewModel     5   	   8c*clr-namespace:StockPriceMonitor.Converters     5   	   4s&clr-namespace:System;assembly=mscorlib     5	   	     � Title$  StockPriceMonitor��5   	   $	��450��6#   $	��600��60    � DataContext 5      3  -StockPriceMonitor.ViewModel.MainWindowContext  5   
    � 	Resources 5      >  8StockPriceMonitor.Converters.PriceChangeToColorConverter   PriceChangeToColorConverter  ButtonTextStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers	 P� Property
 P� Value  ButtonImageStyle  DataGridStyle&   System.Windows.Controls.DataGrid  DataGridColumnHeaderStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader  DataGridRowStyle)  #System.Windows.Controls.DataGridRow �� 	Resources �� Color  BorderStyle  TextBoxStyle ��Name J� SnapsToDevicePixels �� Triggers �� 
TargetName C� ResourceKey  
LabelStyle��%H  &	        &	      &	 �    &	 �    &	 {    &	 ^    &	     &	 L	    &	       5   
   6(   �� 5   
   " ��6*   .�5      ��  � ��
 �   �6+   �� 5       � ��$ 	Helvetica)�6+   �� 5       � ��$ Medium"�6+   �� 5       � ��
 �����6+   �� 5       � ��$ 	10,0,10,0q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   $ 8��5      $��2q�5       
���   �._�5"      �� $��Center=�6/   $��Center=�6L   5#      5$      5&       5(      P� 5)      	 �@J�IsMouseOver$

 True��61   . �5*      ��  � ��
 �����63   �� 5+       �@J�Opacity$	 0.2Q�60   �� 5,       � ��
 �   �63   5-      5/      �� 50   
   " ��6+   .�51      ��  � ��
 ���� 6+   �� 52       � ��
 ���� 6+   �� 53       � ��$ 0q�60   �� 54       � ��$ 30��6&   �� 55       � ��$ 30��6'   56      �� 57   
   "  6&   .�58      ��  � ��
 �����6+   �� 59       � ��$	 400��6&   �� 5:       �@ AutoGenerateColumns$ False��64   �� 5;       �@ CanUserResizeColumns$ False��65   �� 5<       � ��$ 0q�60   �� 5=       �@ RowHeaderWidth$ 0Q�6/   �� 5>       �@ GridLinesVisibility$
 None=�64   �� 5?      % �@ HorizontalScrollBarVisibility$ Disabled=�6>   5A      �� 5B   
   "  62   .�5C      ��  � ��
 �����6+   �� 5D       � ��$ 14(�6)   �� 5E       � ��$
 Bold"�6+   �� 5F       � ��$ Stretch=�64   �� 5G       � ��$
 Left=�6;   5H      �� 5I   
   "  6)    5J      ���� 5K      $ Transparent��6T   (��       6"   * SystemColors.HighlightBrushKey+)6T   �� 5L      $ Transparent��6R   (��       6"   *SystemColors.ControlBrushKey+)6R   �� 5M      $ Black��6X   (��       6"   *$"SystemColors.HighlightTextBrushKey+)6X   �� 5N      $ Black��6V   (��       6"   *" SystemColors.ControlTextBrushKey+)6V   5O      5P      �� 5Q   
   " ��6$   .�5R      ��  � ��
 �����6+   �� 5S       � ��$	 400��6&   �� 5T       �@��CornerRadius$ 8��6-   �� 5U       � ��$ 2q�60   �� 5V       � ��
 �   �6,   �� 5W       � ��$ 10,10,10,10q�6'   �� 5X       �@��Padding$ 5,5,5,5q�6(   5Y      �� 5Z   
   " ��6%   .�5[      ��  � ��$	 200��6&   �� 5\       � ��$ 30��6'   �� 5]       � ��$ 	Helvetica)�6+   �� 5^       � ��$ Center=�69   �� 5_       � ��
 �����6+   �� 5a       � �� 5b      �� 5c      " ��6&   .R�5d      �� $ Bd��6Z   $ 8��6!   $��2q�62   
���   �#��z��6f   ._�5e      �� $��PART_ContentHost��6+   # z 6C   5f       5g      P� 5h      	 � {�. �5i   "   �� $ Bd��6E    � �� 5j   &   C� 5k   *   # Z��6:   5m   #   �� 5n   "    � �� 5o   &   C� 5p   *   # Z��6:   5r   #   
 5s   "   ��5t   &   	False��67   5v      5x      5z      5{      �� 5|   
   " ��6#   .�5}      ��  � ��$	 200��6&   �� 5~       � ��$ 	Helvetica)�6+   �� 5       � ��$ Center=�6;   �� 5�       � ��$ Center=�69   �� 5�       � ��
 �  ��6+   5�      5�      .��5�      �  � RowDefinitions 5�   
   �� 5�      $
��Auto �6   �� 5�      $��* �6   �� 5�      $
��Auto �6   .+�5�   
   � $��0��6   $��Center=�6    5�      �� 5�      $��30 �6    �� 5�      $��* �6    .+�5�      �� $��0��6   #��[ 6!   ��6E   ��  �� Path$ UserMessage��� 5�      $��1��6    �� Orientation$ 
Horizontal=�6'   $��Center=�6@   .+�5�      �� #��[ 6   ��6A   �� $ 
SearchText� �� UpdateSourceTrigger$ PropertyChanged=��� 5�      $	��Add��6   #��[ 6'   ��6R   �� *	AddTicker+5�      5�      �� 5�   
   $��1��6   #��[ 6   ._�5�        #��[ 6      ColumnHeaderStyle# [ 6?      RowStyle# [ 6~   ��6�   �� *FavoriteStocks+   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$ Ticker��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T      
IsReadOnly$
 true��6^   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 69   �� *Ticker+   	CellStyle 5�      �� 5�      *
  $System.Windows.Controls.DataGridCell" 
 6$   .�5�   "   ��  � ��
 �����6?   �� 5�   "    � ��$ 0q�6D   �� 5�   "    � ��$ Center=�6F   5�      5�        5�      $ 	Price ($)��6)   $ 70 6V   $
 true��6a    6<   �� *Price+ 5�      �� 5�      " 
 6$   .�5�   "   ��  � �� 6?   �� $ PriceChange� �� 	Converter# [  �� 5�   "    � ��$ 0q�6D   �� 5�   "    � ��$ Center=�6F   5�      5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      $ Manage��6-   $ 70 6=   $
 true��6H      CellTemplate 5�      �� 5�      .R�5�   "   �� #��[ 6)   ��6S   ��   �� RelativeSource  �� ! �� AncestorType"!  $ DataContext.DeleteTicker���6�   �� $ Ticker�.��5�   &   �� $��Pictures/Bin.png��6,   $��25��6F   $��25��6Q   5�   #   5�       5�      �� 5�      " 
 6$   .�5�   "   ��  � ��
 �����6?   �� 5�   "    � ��$ 0q�6D   �� 5�   "    � ��$ Center=�6F   �� 5�   "    � ��$
 Left=�6H   �� 5�   "    � ��$
 Left=�6O   5�      5�      5�      5�      �� 5�   
   $��2��6   $ 
Horizontal=�6#   $��Center=�6<   $��10,10,10,10q�6Y   .+�5�      �� $��Start Monitoring��6   #��[ 60   ��6[   �� *StartMonitoring+�� 5�      $��Stop Monitoring��6   #��[ 6/   ��6[   �� *StopMonitoring+5�      5�      5�      