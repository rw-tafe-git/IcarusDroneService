   M S B A M L   `   `   `  ����M  IIcarusDroneService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:IcarusDroneServiceIcarusDroneService  5   	   #    IcarusDroneService.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:IcarusDroneService     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wpfx)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Icarus Drone Service��5	   	   $	��570��6&   $	��830��63   .��5
      �  � RowDefinitions 5   
   �� 5      $
��111* �6   �� 5      $
��106* �6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� -   5         ��Name$ TextBoxClientName��5      $
��Left=�6-   $��
120,44,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��120��6�   �� 5   
   -   5        $ TextBoxClientModel��5      $
��Left=�6.   $��
120,81,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   $��Client Name��6   $
��Left=�6&   $��	21,44,0,0q�6A   $	��Top=�6T   �� 5   
   $��Drone Model��6   $
��Left=�6&   $��	21,77,0,0q�6A   $	��Top=�6T   �� 5   
   -   5        $ TextBoxServiceCost��5      $
��Left=�6.   $��120,122,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   6�   �� 5   
   $��Service Cost��6   $
��Left=�6'   $��
21,116,0,0q�6B   $	��Top=�6V   �� 5   
   $��Service Problem��6   $
��Left=�6*   $��
21,162,0,0q�6E   $	��Top=�6Y   �� 5   
   $��Service Tag��6   $
��Left=�6&   $��
21,236,0,0q�6A   $	��Top=�6U   %  Xceed.Wpf.Toolkit.IntegerUpDown  5   
   -   5          Name$ IntegerUpDownServiceTag��5      $��120,236,0,0q�6>   $��0��6S   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   Value 1006c   �  �Xceed.Wpf.Toolkit.NumericUpDown`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]   	Increment 16o   $	��Top=�6}   $��32��6�   $
��Left=�6�   $��60��6�   �� 5   
   -   5         ��Name$ ButtonAddDrone��5      $��	Add Drone��6)   $��Right=�6=   $��	0,0,19,13q�6Y   $��Bottom=�6l   $��32��6�   $��90��6�   6�   �� 5   
   -   5        $ ButtonRemoveService��5      $��Remove��6.   $��	0,0,26,13q�6?   $��1��6R   $��Right=�6b   $��90��6~   $��32��6�   $��Bottom=�6�   6�   �� 5   
   -   5        	 ��Name$	 listBoxCompletedServices��5      $��19,52,26,51q�6_   $��1��6t   6�   �� 5   
   -   5        $ ButtonServiceDroneExpress��5      $��Service Drone��64   $��Right=�6L   $��	0,0,19,30q�6h   $��Bottom=�5       $��32��6,   $��90��68   $��1��6C   $��1��6P   6`   	� 5!   
   -	   5        
 	�Name$
 	rbRegular��5!      $��Regular��6)   $
��Left=�6;   $��
266,47,0,0q�6V   $	��Top=�6j    d� 	IsChecked$
 TrueY�6�   	� 5"   
   -
   5        $
 	rbExpress��5"      $��Express��6)   $
��Left=�6;   $��
266,83,0,0q�6V   $	��Top=�6j   �� 5#   
   $��Regular Priority Queue��6   $
��Left=�61   $��	21,10,0,0q�6L   $��1��6_   $	��Top=�6l   $	��192��6�   �� 5$   
   $��Express Priority Queue��6   $
��Left=�61   $��	22,11,0,0q�6L   $��1��6_   $	��Top=�6l   $	��192��6�   $��1��6�   �� 5%   
   -   5         ��Name$! listViewRegularServiceQueue��5%      $��1��68   $��19,42,19,67q�6p    �� View 5&      �� 5'      .P�5(      �� $
��Name��6%    �� Width$ 80��63    �� DisplayMemberBinding 6>   �� *Name+�� 5)      $��Model��6%   $ 90��64    6?   �� *Model+�� 5*      $��Problem��6%   $ 70��66    6A   �� *	Problem+�� 5+      $
��Cost��6%   $ 60��63    6>   �� *Cost+�� 5,      $	��Tag��6%   $ 60��62    6=   �� *Tag+5-      5/      �� 50   
   -   5        $! listViewExpressServiceQueue��50      $��1��68   $��19,42,19,67q�6p   $��1��6�    51      �� 52      .P�53      �� $
��Name��6%   $ 80��63    6>   �� *Name+�� 54      $��Model��6%   $ 90��64    6?   �� *Model+�� 55      $��Problem��6%   $ 70��66    6A   �� *	Problem+�� 56      $
��Cost��6%   $ 60��63    6>   �� *Cost+�� 57      $	��Tag��6%   $ 60��62    6=   �� *Tag+58      5:      �� 5;   
   -   5        $ TextBoxServiceProblem��5;      $
��Left=�61   $��120,161,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��231��6�   $��51��6�   �� 5<   
   -   5         ��Name$ 	StatusBar��5<      $��1��6'   $��2��64   $��Bottom=�6H   $��25��6c   .@�5=      �� $��Stretch=�6    J� RenderTransformOrigin$ 0.5,1&�68   .��5>      �� -   5        $��TextBlockStatus��5>      $	��820��63   $��Stretch=�6?   5?      5@      �� 5A   
   -   5        $ ButtonServiceDroneRegular��5A      $��Service Drone��64   $��Right=�6L   $��	0,0,19,29q�6h   $��Bottom=�6{   $��32��6�   $��90��6�   $��1��6�   6�   �� 5B   
   $��	Add Drone��6   $
��Left=�6$   $��	21,10,0,0q�6?   $	��Top=�6R   $	��192��6j   �� 5C   
   $��Completed Services��6   $
��Left=�6-   $��	19,10,0,0q�6H   $	��Top=�6[   $	��192��6s   $��1��6   5D      5E      