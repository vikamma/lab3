   M S B A M L   `   `   `  ����D  @Matsiuk02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Matsiuk02.ViewsMatsiuk02.Views  5   	   $    Matsiuk02.Views.PersonInfoView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Matsiuk02.Views     5   	     � Title$  PersonInfoView��5   	   $	��400��6    $	��600��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6   �� 5      $	��30* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6!   ��61   �� *	Surname+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�6   �� 5   
   $��0��6   $��1��6!   ��61   �� *Name+$ OneWay=�$ PropertyChanged=�6|   �� 5   
   $��1��6   $��0��6!   ��61   �� *Email+$ OneWay=�$ PropertyChanged=�6}   �� 5   
   $��1��6   $��1��6!   ��61   �� *Date+$ OneWay=�$ PropertyChanged=�6|   �� 5   
   $��2��6   $��0��6!   ��61   �� *	Zodiac1+$ OneWay=�$ PropertyChanged=�6   �� 5   
   $��2��6   $��1��6!   ��61   �� *	Zodiac2+$ OneWay=�$ PropertyChanged=�6   �� 5   
   $��3��6   $��0��6!   ��61   �� *	IsAdult+$ OneWay=�$ PropertyChanged=�6   �� 5   
   $��3��6   $��1��6!   ��61   �� *
IsBirthday+$ OneWay=�$ PropertyChanged=�6�   5       5!      