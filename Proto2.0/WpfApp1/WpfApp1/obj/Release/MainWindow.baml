   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       � Title$  Proto comparator��$	��700��$
��1000��.���  � ColumnDefinitions �� ��  � RowDefinitions �� $��* ��� $
��Auto �.+��� -    ��Name$ groupBox��$��0��$��0��$��Data from Protos1��$��10,0,5,0q�$��5,5,5,5q�$��Stretch=�$��Stretch=�.��� -   $��LeftTreeView��$��Stretch=�.+��� -   $��_viewer1��$
��Auto=�$
��Auto=�$��0��$��10q�.��� -   $��10q�$��0��.+��  � IsSharedSizeScope .  �� $
��Auto ��� .+�Q� $��0��$��1q����  �� $��* ��� $	��155 ���  z� SharedSizeGroup$ Value��$��* �.+��� $��0��$��Property���� $��1�� �� Padding$ 0q��� $��2��$��Value��R� -   $��	TreeViewL��$��1��
�������$��0,1,0,0q����� *
Children+����  �� 
TargetType" Q�.���  �� Property �@Q�
IsExpanded	 �� Value	 �� *SubItemExpanded+
 �� Mode$
 TwoWay=�����  �� ItemsSource �� *
Children+.R�� ���� *SubItemBackground+ �� $ Property��$	��190 ��� $ Togle��$��5 ��� $ Value��$	��120 �.+��� $��0��$
��Wrap=�$��0,0,0,0q����� *propertyName+���� *SubItemBackground+�� $��2��$
��Wrap=�$
��Left=����� *value+���� *SubItemBackground+ �� ItemTemplate ��  �� *
Children+.R�� ���� *SubItemBackground+ �� $ Property���� $ Togle���� $ Value��.+��� $��0��$
��Wrap=�$��0,0,0,0q����� *propertyName+���� *SubItemBackground+�� $��2��$
��Wrap=�$
��Left=����� *value+���� *SubItemBackground+ ��  �� *
Children+.R�� ���� *SubItemBackground+ �� $ Property���� $ Togle���� $ Value��.+��� $��0��$
��Wrap=����� *propertyName+���� *SubItemBackground+�� $��2��$
��Wrap=�$
��Left=����� *value+���� *SubItemBackground+�� -   $ 	groupBox1��$��0��$��1��$��Data from Protos2��$��5,0,10,0q�$��5,5,5,5q�$��Stretch=�$��Stretch=�.��� -   $��RightTreeView��$��Stretch=�.+��� -    ��Name$ _viewer2��$
��Auto=�$
��Auto=�$��10q�.��� -	   $��10q�$��0��.+��  .  �� $
��Auto ��� .+�Q� $��0��$��1q����  �� $��* ��� $	��155 ��� $ Value��$��* �.+��� $��0��$��Property���� $��1��$ 0q��� $��2��$��Value��R� -
    R�Name$ 	TreeViewR��$��1��
�������$��0,1,0,0q����� *
Children+���� " Q�.���  �@Q�
IsExpanded	 �� *SubItemExpanded+$
 TwoWay=�����  �� *
Children+.R�� ���� *SubItemBackground+ �� $ Property��$	��190 ��� $ Togle��$��5 ��� $ Value��$	��120 �.+��� $��0��$
��Wrap=�$��0,0,0,0q����� *propertyName+���� *SubItemBackground+�� $��2��$
��Wrap=����� *value+���� *SubItemBackground+ ��  �� *
Children+.R�� ���� *SubItemBackground+ �� $ Property���� $ Togle���� $ Value��.+��� $��0��$
��Wrap=�$��0,0,0,0q����� *propertyName+���� *SubItemBackground+�� $��2��$
��Wrap=����� *value+���� *SubItemBackground+ ��  �� *
Children+.R�� ���� *SubItemBackground+ �� $ Property���� $ Togle���� $ Value��.+��� $��0��$
��Wrap=�$��0,0,0,0q����� *propertyName+���� *SubItemBackground+�� $��2��$
��Wrap=����� *value+���� *SubItemBackground+�� $��1��$��2��$��Files generation��$��Bottom=�$��0,15,0,0q�$��10,20,10,20q�.���  �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* � �� $
��Auto ��� $
��Auto �.+��� -    ��Name$ comboBoxClasses��$��1��$��1�� �� 
IsEditable .  �� 
IsReadOnly .  �� Text$ Please Select Class��$��0��$	��250��$��2���� -    ��Name$ ChooseProtoFilesButton��$��0��$��0��$��Select Proto Files��$��30��$	��150��$��
10,0,10,10q��� -   $ GenerateClassesButton��$��0��$��1��{�.  $��Generate  Classes ->��$��30��$	��150��$��
10,0,10,10q��� -   $ buttonProtos1��$��1��$��0��{�.  $��Select Data File 1��$��30��$	��150��$��
10,0,10,10q��� -   $ buttonProtos2��$��2��$��0��{�.  $��Select Data File 2��$��30��$	��150��$��
10,0,10,10q��� -    ��Name$ 
labelReady��$�� ��$��16(�
���  ��$��3��$
��Left=�$	��Top=�$��1��