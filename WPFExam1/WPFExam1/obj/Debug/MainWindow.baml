   M S B A M L   `   `   `  ����C  ?WPFExam1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPFExam1WPFExam1  5   	       WPFExam1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPFExam1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	        WPFExam1.somethingblabla   somethingblabla��%!   &	          5
   
   5      5      .��5      � .+�5   
   �� -   5         ��Name$
 Text��5      $
��text��6   $
��Left=�6.   $��
169,90,0,0q�6I   $	��Top=�6]   �� 5   
   -   5        $ Width��5      $��Width��6    $
��Left=�60   $��179,166,0,0q�6K   $	��Top=�6`   �� 5   
   -   5        $ Height��5      $��Height��6!   $
��Left=�62   $��179,243,0,0q�6M   $	��Top=�6b   �� 5   
   -   5         ��Name$ ilovewpf��5      $
��Left=�6$   $��23��6?   $��
287,94,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $��
I LOVE WPF��6s   $	��Top=�6�   $	��120��6�   �� 5   
   $
��Left=�6   $��641,239,0,0q�6/   $
��Wrap=�6D   $	��Top=�6Y   �� 5   
   $
��Left=�6   $��641,179,0,0q�6/   $
��Wrap=�6D   $	��Top=�6X   �� 5   
   -   5         ��Name$ button��5      $�� ��6!   $
��Left=�6�   $��287,322,0,0q�6�   $	��Top=�6�   ��6,   ��  �� ElementName$ SliderHeight�� �� Path$ Value���6f   �� *Text+$ ilovewpf����6�   �� $ SliderWidth��$ Value�6  �� 5   
   -   5         ��Name$ SliderWidth��5      $
��Left=�6&   $��277,172,0,0q�6A   $	��Top=�6V   $	��334��6n   	 � Value$	 80Q�6z   
 � Maximum$	
 300Q�6�    � Minimum$ 70Q�6�   �� 5   
   -   5        $ SliderHeight��5      $
��Left=�6'   $��277,247,0,0q�6B   $	��Top=�6W   $	��334��6o   $	 90Q�6{   $	
 300Q�6�   $ 70Q�6�   �� 5   
    �� ContentStringFormat$ {0:N0}��6W   $��646,234,81.6,136q�6v   ��6   �� $ SliderHeight��$ Value� �� Mode$ OneWay=�6v   �� 5   
   $ {0:N0}��6V   $��641,166,95.6,202q�6u   ��6   �� $ SliderWidth��$ Value�$ OneWay=�6u   �� 5   
   $��712,166,-204.4,195q�6�   ��6   �� $ SliderWidth��$ Value� �� 	Converter# [   �� ConverterParameter %  System.Windows.Markup.Reference  *SliderWidth+6�   �� 5    
   $��712,234,9.6,142q�6�   ��6   �� $ SliderHeight��$ Value�# [     *SliderHeight+6�   5!      5$      