   M S B A M L   `   `   `  ????F  BStudyCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:bazabaza  5   	       baza.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:md1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:baza  5   	     ? WindowStartupLocation$  CenterScreen=?5   	    ? Title$ 
MainWindow??5
   	   $	??700??6   $
??1200??6)    ? 	Resources 5         OpenMenu ?? TargetProperty ?? 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O? KeyTime O? Value  	CloseMenu??%?  &	        &	 ?     ?? 5   
   .??5      U? $ (FrameworkElement.Width)?6,   $ GridMenu??6a   .\?5        $ 0??6'   $ 70Q?63     5      $ 0:0:0.5??6'   $	 250Q?69   5      5      ?? 5   
   .??5      U? $ (FrameworkElement.Width)?6,   $ GridMenu??6a   .\?5        $ 0??6'   $	 250Q?63     5      $ 0:0:0.5??6'   $ 70Q?69   5      5      5       ? Triggers 5      :? 5   
    :? RoutedEvent$ ButtonBase.Click??6   	 :? 
SourceName$	 ButtonOpenMenu??66   .[?5      ?? #??[  6   5      :? 5   
   $ ButtonBase.Click??6   $	 ButtonCloseMenu??66   .[?5       ?? #??[ 6   5!      .??5$      ? ???	#FFDEDEDE.+?5%   
   ? -   5        
 ?Name$
 GridMain??5%      $??	70 60 0 0q?6"   ? 5&   
   $??60??6   $	??Top=?6   ???#673AB7 J? Effect 5'      3  -System.Windows.Media.Effects.DropShadowEffect  5(         
BlurRadius$ 1Q?6#      ShadowDepth$ 1Q?62      Color$ White??6B   .+?5*      ??  ?? Orientation$ 
Horizontal=?6   $??Right=?62   .+?5+      ?? -   5         ??Name$ accountNametxb??5+      $??Davron Omonov??64   
???????$??Center=?6\   $??16(?6w   '  !MaterialDesignThemes.Wpf.PopupBox  5,         PlacementMode$ BottomAndAlignRightEdges=?6   
???????   	StaysOpen$ False??6Z   $??10q?6l      PopupContent. 5-      ?? $	??150??6!   .+?5.      ?? -   5         ??Name$ settingsBtn??5.   !   $??Settings??66   6I   ?? 5/      -   5        $ 	logoutBtn??5/   !   $??Logout??64   6E   50      51      52      ?? 53      -   5        $ CenternameTxb??53      $??Center=?6/   $??DemiBold"?6L   $??Center=?6b   
???????$??30(?6?   ?? 6?   $??35(?6?   .?6?   "Shahriston"6?   
 filiali6?   54      ? 57   
   -   5        $
 GridMenu??57      $??70??6!   $
??Left=?6,   ???#673AB7 58        59      $ 2Q?6#   $ 1Q?62   $ 	#FFAEAEAE??6B   .+?5;      ?? .+?5<      ? $	??150??6   
??????? J? RenderTransformOrigin$ 0.5,0.5&?67   z?5=      V? 5>      .~?5?      ?? ?? 5@      ?? 5A      T? 5B      5C      .+?5E      ?? -   5        $ ButtonOpenMenu??5E      $??60??65   $??60??6A   $??5q?6L   $??Right=?6W   $	??Top=?6s    0 ,MaterialDesignFloatingActionMiniAccentButton#??[ 6?   ???#673AB7??6?   Z? ??6?   Z? .??5F      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=?6&   $??25??62   $??25??6=   5G      ?? 5H      -   5        $ ButtonCloseMenu??5H      $y?	Collapsed=?66   $??60??6M   $??60??6Y   $??5q?6d   $??Right=?6o   $	??Top=?6?   #??[ 6?   ???#673AB7??6?   Z? ??6?   Z? .??5I        $ 	ArrowLeft=?6&   $??25??67   $??25??6B   5J      ?? 5L      $??80??6   $??Bottom=?6(   5M      ?? 5P      -	   5         ??Name$ ListViewMenu??5P      
???????$??Disabled=?6D   .@?5R      ?? -
   5         ??Name$ Student??5R   #   $??60??64   .??5S      ?? $ 
Horizontal=?6%   .+?5T        $ AccountStudent=?6*   $??30??6@   $??30??6L   $
??10 0q?6W   ?? 5U      $??Student??6(   $??20(?67   $??Center=?6E   $
??10 0q?6`   5V      5W      ?? 5X      -   5        $ Teacher??5X   #   $??60??64   .??5Y      ?? $ 
Horizontal=?6%   .+?5Z        $ Teacher=?6*   $??30??69   $??30??6E   $
??10 0q?6P   ?? 5[      $??Teacher??6(   $??20(?67   $??Center=?6E   $
??10 0q?6`   5\      5]      ?? 5^      -   5        $ Group??5^   #   $??60??62   .??5_      ?? $ 
Horizontal=?6%   .+?5`        $ GroupAdd=?6*   $??30??6:   $??30??6F   $
??10 0q?6Q   ?? 5a      $??Group??6(   $??20(?65   $??Center=?6C   $
??10 0q?6^   5b      5c      ?? 5d      -   5        $ Setting??5d   #   $??60??64   .??5e      ?? $ 
Horizontal=?6%   .+?5f        $ Settings=?6*   $??30??6:   $??30??6F   $
??10 0q?6Q   ?? 5g      $??Settings??6(   $??20(?68   $??Center=?6F   $
??10 0q?6a   5h      5i      5j      5k      5l      5m      5n      