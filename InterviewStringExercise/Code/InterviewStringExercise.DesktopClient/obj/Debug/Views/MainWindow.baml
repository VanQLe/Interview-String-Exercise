   M S B A M L   `   `   `  ����`  \InterviewStringExercise.DesktopClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:InterviewStringExercise.DesktopClient%InterviewStringExercise.DesktopClient  5   	   6    0InterviewStringExercise.DesktopClient.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:InterviewStringExercise.DesktopClient     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ label��5
      $��String Exercise ��6   $��Center=�6:   $��193,10,211,0q�6X   $	��Top=�6n   $	��113��6�   $��32��6�   $
��Bold"�6�   �� 5   
   -   5        $ label1��5      $��Input String��6    $
��Left=�67   $��	22,56,0,0q�6R   $	��Top=�6e   �� 5   
   -   5        $ label1_Copy��5      $��Output String��6%   $
��Left=�6=   $��
22,106,0,0q�6X   $	��Top=�6l   �� 5   
   -   5         ��Name$ InputTextBox��5      $
��Left=�6j   $��23��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��379��6�   $��
118,59,0,0q�6�   ��6(   �� *InputString+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ OutputStringLabel��5      $
��Left=�6r   $��118,106,0,0q�6�   $	��Top=�6�   $	��379��6�   $��26��6�   ��6+   �� *OutputString+$ PropertyChanged=�6�   �� 5   
   -   5         ��Name$ ConvertStringButton��5      $��Convert String��6Y   $
��Left=�6r   $��193,160,0,0q�6�   $	��Top=�6�   $	��113��6�   ��6.   �� *ConvertStringCommand+6�   5      5      