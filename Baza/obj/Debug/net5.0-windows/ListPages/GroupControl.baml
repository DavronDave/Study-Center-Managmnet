   M S B A M L   `   `   `  ????F  BStudyCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:baza.ListPagesbaza.ListPages  5      !    baza.ListPages.GroupControl   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:baza.ListPages     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        .??5      ? ???	#FFDBC8FF  ? 	Resources  5   
    ?? 
TargetType ?? Property ?? Value??%  '??       '?? ?     ?? 5      " ??6   .?5      ??  ? ??$ 18(?6-   ?? 5       ? ??$ 0 8 0 2q?6+   ?? 5       ? ??$ DemiBold"?6/   5      ?? 5      " ??6   .?5      ??  ? ??$ 30??6+   ?? 5       ? ??$ 16(?6-   5      5       ? ColumnDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      $??44 ?6   ?? 5       $	??320 ?6   ?? 5!      .+?5#   
   ? ???#F6F6F6$??4??6$   .+?5$      ?? $??GROUP??6   $??25(?6%   $
??Bold"?63   ???#673AB7$??Center=?6Z   $??Center=?6u   5%      ? 5'   
   -   5         ?Name$ 	GroupGrid??5'   1   $??1??6   $??2??6    5(      ?? 5)      ?? 5*      .+?5,      ?? $??	40 0 10 0q?6   $??0??6-   .+?5-      ?? $?? Group name:??6   ?? 5.      -   5         ??Name$ gnameTxt??5.      $??1q?6,   ??6@   ?? *Name+?? 5/      $??	 Subject:??6   ?? 50      -   5         ??Name$ 
subjectcmb??50      $??16(?6/   $??1q?6=   
???????$??33??6d   	 ?? DisplayMemberPath$
	 Name??6p   
 ?? SelectedValuePath$
 	SubjectId??6?   ??6?   ?? 51      ?? 52      $??	 Teacher:??6   ?? 53      -   5        $ 
teachercmb??53      $??16(?6/   $??1q?6=   
???????$??33??6d   $	 Fullname??6p   $
 	TeacherId??6?   ??6?   ?? 54      ?? 55      $?? Duration (month):??6   ?? 56      -   5        $ durTxt??56      $??1q?6*   ??6>   ?? *
Duration+57      ?? 59      $??1??6   .+?5:      ?? $?? Start date:??6   (  "System.Windows.Controls.DatePicker  5;      -   5          Name$ 
datepicker??5;      $??30??6L   
???????   SelectedDate 2022/1/16l      SelectedDateFormat$ Short=?6?      Text 61   ?? *	StartDate+6?   ?? 5<      $?? Start lesson:??6   ?? 5=      -   5        $ startlessoncmb??5=      $??16(?63   $??1q?6A   
???????$??33??6h   .@?5>      ?? .??6#   	08 : 006.   ?? 5?      .??6#   	10 : 006.   ?? 5@      .??6#   	13 : 006.   ?? 5A      .??6#   	15 : 006.   ?? 5B      .??6#   	17 : 006.   5C      ?? 5D      $?? Finish lesson:??6   ?? 5E      -	   5        $ finishlessoncmb??5E      $??16(?64   $??1q?6B   
???????$??33??6i   .@?5F      ?? .??6#   	10 : 006.   ?? 5G      .??6#   	12 : 006.   ?? 5H      .??6#   	15 : 006.   ?? 5I      .??6#   	17 : 006.   ?? 5J      .??6#   	19 : 006.   5K      ?? 5L      $?? Room:??6   ?? 5M      -
   5        $ roomcmb??5M      $??16(?6,   $??1q?6:   
???????$??33??6a   $
	 Name??6m   $
 RoomId??6?   ??6?   ?? 5N      5O      5P      ?? 5Q   
    ?? Orientation$ 
Horizontal=?6   $??1??6.   $??2??6;   $??Bottom=?6O   $??Center=?6j   .+?5R      ?? -   5         ??Name$ 	InsertBtn??5R      $??10q?6(   $	??100??64   .??5S      ?? $ 
Horizontal=?6   .+?5T      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
AccountAdd=?6"   ?? 5U      $
?? Add??6&   5V      5W      ?? 5X      -   5        $ 	updateBtn??5X      $??10q?6(   $	??100??64   .??5Y      ?? $ 
Horizontal=?6   .+?5Z        $
 Edit=?6"   ?? 5[      $?? Update??6&   5\      5]      ?? 5d      -   5        $ AddStudentBtn??5d      $??10q?6,   $	??135??68   .??5e      ?? $ 
Horizontal=?6   .+?5f        $	 Add=?6"   $??19??6-   ?? 5g      $?? Add Student??6&   5h      5i      5j      ?? 5l   
   -   5         ??Name$ studentsLbx??5l      
???????$??2??6:   $??1??6J   $??20q?6W   ??5m      ?? 5n      .R?5o      ?? $??18(?6:   ??6    ?? *
Fullname+6:   5p      5r      &   System.Windows.Controls.DataGrid  5t   
   -   5          Name$ GroupDatagrid??5t      $??2??6*   $??4??67   $??16(?6K      AutoGenerateColumns$ False??6Y      
IsReadOnly$
 True??6u      CanUserResizeColumns$ False??6?      GridLinesVisibility$	 All=?5u      $??40 10 40 20q?6K   ??6-   ?? *Group+   Columns 5w      0  *System.Windows.Controls.DataGridTextColumn  5z      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Group name??6>      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *Name+5?        5?      $ Subject??6N   $	 190 6_    6%   ?? *Teacher.Subject.Name+6_     5?      $ Teacher??6A   $	 200 6R    6%   ?? *	Teacher+6R     5?      $ Duration??6B   $	 100 6T    6%   ?? *
Duration+6T     5?      $ Started date??6\   $	 140 6r    6%   ?? *	StartDate+ ?? StringFormat$ 
dd-MM-yyyy??6r     5?      $ Start lesson??6E   $	 120 6[    6%   ?? *StartLesson+6[     5?      $ Finish lesson??6F   $	 130 6]    6%   ?? *FinishLesson+6]     5?      $
 Room??6C   $	 100 6Q    6%   ?? *	Room.Name+6Q   4  .System.Windows.Controls.DataGridTemplateColumn  5?      $	 Add??6)      CellTemplate 5?      ?? 5?      .R?5?      ?? $ addStudents??6%   -   5        .??5?   "   ?? $ 
Horizontal=?6-   .+?5?   &     $	 Add=?62   ?? 5?   &   $
?? Add??66   5?   #   5?      5?      5?        5?      $ Delete??6)   $	 130 69    5?      ?? 5?      .R?5?      ?? $ 	deleteBtn??6%   -   5        .??5?   "   ?? $ 
Horizontal=?6-   .+?5?   &     $ Delete=?62   ?? 5?   &   $??Delete??66   $	??5 0q?6G   5?   #   5?      5?      5?      5?      5?      5?      