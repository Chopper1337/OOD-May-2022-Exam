   M S B A M L   `   `   `  ����L  HOOD-May-2022-Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:OOD_May_2022_ExamOOD_May_2022_Exam  5   	   !    OOD_May_2022_Exam.AddWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:OOD_May_2022_Exam     5   	     � Title$  	AddWindow��5   	   $	��450��6   $	��400��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5      �� $��Type of Rental:��6   $
��Left=�6&   $��80,35,20,20q�6A   $	��Top=�6W   $��0��6o   6~   �� 5   
   -   5        $��RentalTypeCBX��5   j   $��0��6   $��180,35,20,20q�6H   $	��150��6^   $��20��6   $
��Left=�6�   ��6    ��  �� Path$ 
RentalType�6�   �� 5      $��	Location:��6   $
��Left=�6    $��80,35,20,20q�6;   $	��Top=�6Q   $��1��6i   6x   �� 5   
   -   5        $��LocationTBLK��5   M   $��1��6   $��180,35,20,20q�6   $	��150��65   $��20��6A   $
��Left=�6a   6~   �� 5      $��Price:��6   $
��Left=�6   $��80,35,20,20q�68   $	��Top=�6N   $��2��6f   6u   �� 5   
   -   5        $��	PriceTBLK��5   M   $��2��6   $��180,35,20,20q�6   $	��150��65   $��20��6A   $
��Left=�6^   6{   �� 5      $��Description:��6   $
��Left=�6#   $��80,35,20,20q�6>   $	��Top=�6T   $��3��6l   6{   �� 5   
   -   5        $��DescriptionTBLK��5   ^   $��3��6   $��180,20,20,20q�6   $	��150��65   $��80��6A   $��2��6M   $
��Left=�6u   6�   �� 5   
   -   5        $
��Save��5      $��20��60   $��5q�6<   $��50��6G   $��4��6R   $��Bottom=�6_   $��Right=�6z   6�   5      5       