   M S B A M L   `   `   `  ????F  BStudyCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:baza.ListPagesbaza.ListPages  5      #    baza.ListPages.StudentControl   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:baza.ListPages     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5        .??5      ? ???	#FFDBC8FF  ? 	Resources  5   
    ?? 
TargetType ?? Property ?? Value??%  '??       '?? ?     ?? 5      " ??6   .?5      ??  ? ??$ 18(?6-   ?? 5       ? ??$ 0 8 0 2q?6+   ?? 5       ? ??$ DemiBold"?6/   5      ?? 5      " ??6   .?5      ??  ? ??$ 30??6+   ?? 5       ? ??$ 16(?6-   5      5       ? ColumnDefinitions 5   
   ?? 5      ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5       $??44 ?6   ?? 5!      $	??250 ?6   ?? 5"      .+?5%   
   ? ???#F6F6F6$??3??6$   .+?5&      ?? -   5         ??Name$ 	searchtxt??5&      ???#673AB7$
??40 7q?6>   )  #MaterialDesignThemes.Wpf.HintAssist   
HelperText$ Search??6L   $??18(?6n   
???????$??DemiBold"?6?   $
??Left=?6?   $	??130??6?   6?   ?? 5'      $??STUDENT??6   $??25(?6'   $
??Bold"?65   ???#673AB7$??Center=?6\   $??Center=?6w   5(      ? 5*   
   -   5         ?Name$ studentGrid??5*      $??1??6$   $??2??61    5+      ?? 5,      ?? 5-      .+?5/      ?? $??	40 0 10 0q?6   $??0??6,   .+?50      ?? $?? Firstname:??6    ?? 51      -   5        $ fnameTxt??51      $??1q?60   ??6D   ?? *Fname+?? 52      $??
 Lastname:??6    ?? 53      -   5        $ lnameTxt??53      $??1q?60   ??6D   ?? *Lname+?? 54      $?? Phone:??6    ?? 55      -   5        $ phoneTxt??55      ??60   ?? *Phone+56      ?? 57      $??1??6   .+?58      ?? $?? Survey:??6   ?? 59      -   5        	 ??Name$	 	survetCmb??59      
???????$??30??6A   $??16(?6M   
 ?? Text
 6[   ?? *Survey+.@?5:      ?? .??6#   Social Network63   ?? 5;      .??6#   Flayer6+   ?? 5<      .??6#   Friend6+   5=      ?? 5>      $?? Databirth:??6   (  "System.Windows.Controls.DatePicker  5?      -   5          Name$ 
datepicker??5?      $??30??6L   
???????   SelectedDate 2000/1/16k      SelectedDateFormat$ Short=?6?      Text 61   ?? *	DateBirth+6?   ?? 5@      $?? Moderator:??6   ?? 5A      -	   5        $	 moderatorCmb??5A      
???????$??16(?6_   
 61   ?? *	Moderator+.@?5B      ?? .??6#   Yulduz Ikromova64   ?? 5C      .??6#   Sitora Akbarova64   5D      5F      5G      ?? 5K   
    ?? Orientation$ 
Horizontal=?6   $??1??6.   $??2??6;   $??Bottom=?6O   $??Center=?6j   .+?5L      ?? -
   5         ??Name$ 	InsertBtn??5L      $??10q?6(   $	??100??64   .??5M      ?? $ 
Horizontal=?6   .+?5N      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
AccountAdd=?6"   ?? 5O      $
?? Add??6&   5P      5Q      ?? 5R      -   5        $ 	updateBtn??5R      $??10q?6(   $	??100??64   .??5S      ?? $ 
Horizontal=?6   .+?5T        $ Update=?6"   ?? 5U      $?? Update??6&   5V      5W      5_      &   System.Windows.Controls.DataGrid  5a   
   -   5          Name$ StudentDatagrid??5a      $??2??6,   $??3??69   $??16(?6M      AutoGenerateColumns$ False??6[      
IsReadOnly$
 True??6w      CanUserResizeColumns$ False??6?      GridLinesVisibility$	 All=?5b      $??40 10 40 20q?6F   ??6-   ??    Columns 5d      0  *System.Windows.Controls.DataGridTextColumn  5g      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Firstname??6?      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *Fname+5o        5p      $ Lastname??6?   $	 150 6Q    6%   ?? *Lname+6Q     5q      $ Phone??6?   $	 170 6N    6%   ?? *Phone+6N     5r      $ Survey??6@   $	 160 6P    6%   ?? *Survey+6P     5s      $ Date of birth??6\   $	 160 6s    6%   ?? *	DateBirth+ ?? StringFormat$ 
dd-MM-yyyy??6s     5t      $ 	Moderator??6C   $	 160 6V    6%   ?? *	Moderator+6V   4	  .System.Windows.Controls.DataGridTemplateColumn	  5v      $ Update??6)    	  CellTemplate 5w      ?? 5x      .R?5y      ?? $ updateCellBtn??6%   -   5        .??5z   "   ?? $ 
Horizontal=?6-   .+?5{   &     $
 Edit=?62   ?? 5|   &   $?? Edit??66   5}   #   5~      5      5?      	  5?      $ Delete??6)   $	 125 69    5?      ?? 5?      .R?5?      ?? $ 	deleteBtn??6%   -   5        .??5?   "   ?? $ 
Horizontal=?6-   .+?5?   &     $ Delete=?62   ?? 5?   &   $??Delete??66   $	??5 0q?6G   5?   #   5?      5?      5?      5?      ?? 5?   
   $??	   Groups??6   $??1??6%   $??2??62   $??0 5 0 0q?6B   ?? 5?   
   -   5         ??Name$ 	groupsLbx??5?      $??1??6%   $??2??62   $??18(?6B   
???????$??10 33 40 10q?6c   5?      5?      5?      