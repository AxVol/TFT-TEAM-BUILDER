   M S B A M L   `   `   `  ????K  GTFT TEAM BUILDER, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TFT_TEAM_BUILDER.ViewsTFT_TEAM_BUILDER.Views  5      I)clr-namespace:TFT_TEAM_BUILDER.ViewModelsTFT_TEAM_BUILDER.ViewModels  5      &     TFT_TEAM_BUILDER.Views.BuildView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:TFT_TEAM_BUILDER.Views     5      ?	viewModel)clr-namespace:TFT_TEAM_BUILDER.ViewModels     5        N? Title$  	BuildView??5
       ? DataContext 5      0  *TFT_TEAM_BUILDER.ViewModels.BuildViewModel  5   
    ? 	Resources 5       ?? 
TargetType   Item ?? Property ?? Value ?? 	Resources??%E  &	        ?? 5   
   " ??6   .?5      ??  ? ?? ?#212a356+   ?? 5       ? ??$ 2q?60   ?? 5       ? ??$ Hidden=?6K   ?? 5       ? ??$ Hidden=?6I    5      ???? 5      '??       " ??6   .?5      ??  ?@??CornerRadius$ 15??65   5      5      5      5      .??5      ? ???#212a35 ? RowDefinitions 5   
   ?? 5       ?? 5!      $	??150 ?6   ?? 5"      .+?5%   
   ? $??0??6   .+?5&      ?? #??[  6>   $??20q?6\   ???#212a35??6   ?? *team.teamItems+??5'      ?? 5(      .R?5)      ?? $	??100??6%   $	??100??62    ?? Orientation$ 
Horizontal=?6>   .+?5*      ?? $??50??6C   $??50??6O   $
??Left=?6Z   $	??Top=?6u   ??6$   ?? *pathToImage+	 ? ToolTip	 5+   "   _? 5,   &   ???#0e2848
???????
 _? 	Placement$
 Relative=?5.   .    _? HorizontalOffset$ 15??5/   .    _? VerticalOffset$ 10??50   .   .??51   *   ?? $ 
Horizontal=?65   .+?52   .   ?? $??60??64   $??60??6?   ??6K   ?? *	FirstItem+?? 53   .   $??0,10,0,0q?68   $??24(?6J   $??+??6X   ?? 54   .   $??60??64   $??60??6?   ??6K   ?? *
SecondItem+?? 55   .   $??0,10,0,0q?68   $??24(?6J   $??=??6X   ?? 56   .   $??60??64   $??60??6?   ??6K   ?? *pathToImage+57   +   58   '   5:      5;      5<      ??5>      ?? 5?      .R?5@      ?  ? 	ItemWidth$ 60??5B   (   $??60??5C   (    ? 
ItemHeight$ 60??5D   (   ??5@   $   ?? * (FrameworkElement.ActualWidth)+ ?? RelativeSource ??  ?? AncestorType$ ScrollContentPresenterL?5D   (   5E      5G      5H      ? 5I   
   $??1??6   .+?5J      ?? ???#212a35$??Hidden=?5K      $??Hidden=?5L      $??0q?5M      ??5J   ,   ?? *team.teamTraits+??5N      ?? 5O      .R?5P      ? .+?5Q      ?? $??	-5,0,23,0q?6$   ??67   ?? *pathToImage+?? 5R      $??35,0,0,0q?6(   
???????$??24(?6M   ??6[   ?? *	teamCount+5S      5T      ??5V      ?? 5W      .R?5X      ? $ 60??5Z   (   $??60??5[   (   $ 40??5\   (   ??5X   $   ?? * (FrameworkElement.ActualWidth)+ ?? $ ScrollContentPresenterL?5\   (   5]      5_      5`      ? 5a   
   $??2??6   $??	300,0,0,0q?6    5b      ?? 5c      $	??25* ?6    ?? 5d      $	??25* ?6    ?? 5e      $	??25* ?6    ?? 5f      $	??25* ?6    .+?5i      ? $??0??6   .+?5j      ?? ???#212a35$
??Left=?5k      $??Center=?5l      $??0,0,0,0q?5m      $??50??5n      $??50??5o      $??Hidden=?5q      $??Hidden=?5r      ??5p      ?? *
team.slot0+??5s      ?? 5t      .R?5u      ? .+?5v   "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5w      5x      5z      ?? 5{      ???#212a35$
??Left=?5|      $??Center=?5}      $??60,0,0,0q?5~      $??50??5      $??50??5?      $??Hidden=?5?      $??Hidden=?5?      ??5?      ?? *
team.slot1+??5?      ?? 5?      .R?5?      ? .+?5?   "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?      5?      5?      ?? 5?      ???#212a35$
??Left=?5?      $??Center=?5?      $??	120,0,0,0q?5?      $??50??5?      $??50??5?      $??Hidden=?5?      $??Hidden=?5?      ??5?      ?? *
team.slot2+??5?      ?? 5?      .R?5?      ? .+?5?   "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?      5?      5?      ?? 5?      ???#212a35$
??Left=?5?      $??Center=?5?      $??	180,0,0,0q?5?      $??50??5?      $??50??5?      $??Hidden=?5?      $??Hidden=?5?      ??5?      ?? *
team.slot3+??5?      ?? 5?      .R?5?      ? .+?5?   "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?      5?      5?      ?? 5?      ???#212a35$
??Left=?5?      $??Center=?5?      $??	240,0,0,0q?5?      $??50??5?      $??50??5?      $??Hidden=?5?      $??Hidden=?5?      ??5?      ?? *
team.slot4+??5?      ?? 5?      .R?5?      ? .+?5?   "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?      5?      5?      ?? 5?      ???#212a35$
??Left=?5?      $??Center=?5?      $??	300,0,0,0q?5?      $??50??5?      $??50??5?      $??Hidden=?5?      $??Hidden=?5?      ??5?      ?? *
team.slot5+??5?      ?? 5?      .R?5?      ? .+?5?   "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?      5?      5?      ?? 5?      ???#212a35$
??Left=?5?      $??Center=?5?      $??	360,0,0,0q?5?      $??50??5?      $??50??5?      $??Hidden=?5?      $??Hidden=?5?      ??5?      ?? *
team.slot6+??5?      ?? 5?      .R?5?      ? .+?5?   "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?      5?      5?      5?      ? 5?      $??1??6   .+?5?      ?? ???#212a35$
??Left=?5?      $??Center=?5?      $??30,0,0,0q?5?      $??50??5?      $??50??5?      $??Hidden=?5?      $??Hidden=?5?      ??5?      ?? *
team.slot7+??5?      ?? 5?      .R?5?      ? .+?5?   "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?      5?      5?      ?? 5?      ???#212a35$
??Left=?5?      $??Center=?5?      $??90,0,0,0q?5?      $??50??5?      $??50??5?      $??Hidden=?5?      $??Hidden=?5?      ??5?      ?? *
team.slot8+??5?      ?? 5?      .R?5?      ? .+?5   "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5     5     5     ?? 5     ???#212a35$
??Left=?5     $??Center=?5     $??	150,0,0,0q?5     $??50??5	     $??50??5
     $??Hidden=?5     $??Hidden=?5     ??5     ?? *
team.slot9+??5     ?? 5     .R?5     ? .+?5  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5     5     5     ?? 5     ???#212a35$
??Left=?5     $??Center=?5     $??	210,0,0,0q?5     $??50??5     $??50??5     $??Hidden=?5     $??Hidden=?5     ??5     ?? *team.slot10+??5     ?? 5      .R?5!     ? .+?5"  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5#     5$     5&     ?? 5'     ???#212a35$
??Left=?5(     $??Center=?5)     $??	270,0,0,0q?5*     $??50??5+     $??50??5,     $??Hidden=?5.     $??Hidden=?5/     ??5-     ?? *team.slot11+??50     ?? 51     .R?52     ? .+?53  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   54     55     57     ?? 58     ???#212a35$
??Left=?59     $??Center=?5:     $??	330,0,0,0q?5;     $??50??5<     $??50??5=     $??Hidden=?5?     $??Hidden=?5@     ??5>     ?? *team.slot12+??5A     ?? 5B     .R?5C     ? .+?5D  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5E     5F     5H     ?? 5I     ???#212a35$
??Left=?5J     $??Center=?5K     $??	390,0,0,0q?5L     $??50??5M     $??50??5N     $??Hidden=?5P     $??Hidden=?5Q     ??5O     ?? *team.slot13+??5R     ?? 5S     .R?5T     ? .+?5U  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5V     5W     5Y     5Z     ? 5[     $??2??6   .+?5\     ?? ???#212a35$
??Left=?5]     $??Center=?5^     $??0,0,0,0q?5_     $??50??5`     $??50??5a     $??Hidden=?5c     $??Hidden=?5d     ??5b     ?? *team.slot14+??5e     ?? 5f     .R?5g     ? .+?5h  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5i     5j     5l     ?? 5m     ???#212a35$
??Left=?5n     $??Center=?5o     $??60,0,0,0q?5p     $??50??5q     $??50??5r     $??Hidden=?5t     $??Hidden=?5u     ??5s     ?? *team.slot15+??5v     ?? 5w     .R?5x     ? .+?5y  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5z     5{     5}     ?? 5~     ???#212a35$
??Left=?5     $??Center=?5?     $??	120,0,0,0q?5?     $??50??5?     $??50??5?     $??Hidden=?5?     $??Hidden=?5?     ??5?     ?? *team.slot16+??5?     ?? 5?     .R?5?     ? .+?5?  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?     5?     5?     ?? 5?     ???#212a35$
??Left=?5?     $??Center=?5?     $??	180,0,0,0q?5?     $??50??5?     $??50??5?     $??Hidden=?5?     $??Hidden=?5?     ??5?     ?? *team.slot17+??5?     ?? 5?     .R?5?     ? .+?5?  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?     5?     5?     ?? 5?     ???#212a35$
??Left=?5?     $??Center=?5?     $??	240,0,0,0q?5?     $??50??5?     $??50??5?     $??Hidden=?5?     $??Hidden=?5?     ??5?     ?? *team.slot18+??5?     ?? 5?     .R?5?     ? .+?5?  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?     5?     5?     ?? 5?     ???#212a35$
??Left=?5?     $??Center=?5?     $??	300,0,0,0q?5?     $??50??5?     $??50??5?     $??Hidden=?5?     $??Hidden=?5?     ??5?     ?? *team.slot19+??5?     ?? 5?     .R?5?     ? .+?5?  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?     5?     5?     ?? 5?     ???#212a35$
??Left=?5?     $??Center=?5?     $??	360,0,0,0q?5?     $??50??5?     $??50??5?     $??Hidden=?5?     $??Hidden=?5?     ??5?     ?? *team.slot20+??5?     ?? 5?     .R?5?     ? .+?5?  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?     5?     5?     5?     ? 5?     $??3??6   .+?5?     ?? ???#212a35$
??Left=?5?     $??Center=?5?     $??30,0,0,0q?5?     $??50??5?     $??50??5?     $??Hidden=?5?     $??Hidden=?5?     ??5?     ?? *team.slot21+??5?     ?? 5?     .R?5?     ? .+?5?  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?     5?     5?     ?? 5?     ???#212a35$
??Left=?5?     $??Center=?5?     $??90,0,0,0q?5?     $??50??5?     $??50??5?     $??Hidden=?5?     $??Hidden=?5?     ??5?     ?? *team.slot22+??5?     ?? 5?     .R?5?     ? .+?5?  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5?     5?     5?     ?? 5?     ???#212a35$
??Left=?5?     $??Center=?5?     $??	150,0,0,0q?5?     $??50??5?     $??50??5?     $??Hidden=?5?     $??Hidden=?5?     ??5?     ?? *team.slot23+??5      ?? 5     .R?5     ? .+?5  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5     5     5     ?? 5     ???#212a35$
??Left=?5	     $??Center=?5
     $??	210,0,0,0q?5     $??50??5     $??50??5     $??Hidden=?5     $??Hidden=?5     ??5     ?? *team.slot24+??5     ?? 5     .R?5     ? .+?5  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5     5     5     ?? 5     ???#212a35$
??Left=?5     $??Center=?5     $??	270,0,0,0q?5     $??50??5     $??50??5     $??Hidden=?5      $??Hidden=?5!     ??5     ?? *team.slot25+??5"     ?? 5#     .R?5$     ? .+?5%  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5&     5'     5)     ?? 5*     ???#212a35$
??Left=?5+     $??Center=?5,     $??	330,0,0,0q?5-     $??50??5.     $??50??5/     $??Hidden=?51     $??Hidden=?52     ??50     ?? *team.slot26+??53     ?? 54     .R?55     ? .+?56  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   57     58     5:     ?? 5;     ???#212a35$
??Left=?5<     $??Center=?5=     $??	390,0,0,0q?5>     $??50??5?     $??50??5@     $??Hidden=?5B     $??Hidden=?5C     ??5A     ?? *team.slot27+??5D     ?? 5E     .R?5F     ? .+?5G  "   ?? $??-59,-2,-5,-2q?6(   $	??100??6>   $??60??6J   $
??Fill=?6u   ??6V   ?? *pathToImage+6u   5H     5I     5K     5L     5M     5N     5O     