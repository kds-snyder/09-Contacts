   M S B A M L   `   `   `  ����F  BWpfContacts, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfContactsWpfContacts  5   	       WpfContacts.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfContacts     5   	   -   5          � Title$  Contact Manager V1.0��5   	   $	��350��6&   $	��800��63   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��49* �6   �� 5      $	��58* �6   �� 5      $
��289* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid_contacts��5      $
��Left=�6.   $��	10,49,0,0q�6I   $	��Top=�6\   $	��260��6t   $	��767��6�   $��3��6�      SelectionMode$ Single=�6�   �� 5   
   -   5         ��Name$ button_deleteContact��5      $��Delete Selected Contact��6/   $
��Left=�6Q   $��419.56,6,0,0q�6l   $	��Top=�6�   $	��140��6�    J� RenderTransformOrigin$ -0.027,0.07&�6�   $��25��6�   $��2��6�   �� 5   
   -   5        $ button_editContact��5      $��Edit Selected Contact��6-   $
��Left=�6M   $��265.56,6,0,0q�6h   $	��Top=�6~   $	��140��6�   $ 0.946,-0.514&�6�   $��25��6�   $��2��6�   �� 5   
   -   5        $ button_addContact��5      $��Add New Contact��6,   $
��Left=�6F   $��111.56,6,0,0q�6a   $	��Top=�6w   $	��140��6�   $��25��6�   $��2��6�   5      5      