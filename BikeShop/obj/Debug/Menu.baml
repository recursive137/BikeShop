   M S B A M L   `   `   `  ����C  ?BikeShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BikeShopBikeShop  5      9!clr-namespace:BikeShop.ConvertersBikeShop.Converters  5          BikeShop.Menu   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:BikeShop     5      /c!clr-namespace:BikeShop.Converters     5        N� Title$
  Menu��5
       � 	Resources 5      0   *BikeShop.Converters.LetterToColorConverter   letterToColorConv(   "BikeShop.Converters.TwiceConverter  	twiceConv��%:   &	        &	        5   
   6#     5   
   6   5      .��5      � ��6   ��  �� ElementName$ color�� �� Path$
 Text� �� 	Converter# [  .+�5   
   �� -   5         ��Name$ button��5      $��Products��6!   $
��Left=�64   $��	10,33,0,0q�6O   $	��Top=�6b   $��82��6z   $��55��6�   �� 5   
   -   5        $ button1��5      $��Live support��6"   $
��Left=�69   $��
108,31,0,0q�6T   $	��Top=�6h   $��82��6�   $��57��6�   6�   �� 5   
   -   5        $ button2��5      $��Email support��6"   $
��Left=�6:   $��
208,33,0,0q�6U   $	��Top=�6i   $��82��6�    J� RenderTransformOrigin$ -0.219,0.956&�6�   $��55��6�   6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��
42,136,0,0q�6B   $
��Wrap=�6V   $��Adventure Works��6j   $	��Top=�6�   $��45��6�   $	��216��6�   $��24(�6�   �� 5   
   .+�5      �� 
 �� Top$	 201��6   	 �� Left$	 82��6&   $ 0.038,4.271&�67   .��6[   A6^   �� 5      $	 226��6   $	 82��6&   .��67   B6:   �� 5      $	 226��6   $		 111��6&   .��68   C6;   �� 5      $	 201��6   $		 110��6&   $ 
4.284,2.13&�68   .��6[   D6^   5      �� 5   
   .+�5      �� -   5        
 ��Name$
 color��5      $��a��6   6   �� 5      -   5         ��Name$ slider��5   .    � Maximum$	 100Q�6    � Value$ 10Q�6#   6@   � 5        6   �� *Value+$ slider��6H   �� 5!      $��65��6   $��20��6!   ��6-   �� *Value+$ slider��6Z   �� 5"      ��6   �� ��5#      �� 5$      .R�5%      �� ��6$   �� *Speed+5&      5(      5)      5+      5,      