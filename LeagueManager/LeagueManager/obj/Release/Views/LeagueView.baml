   M S B A M L   `   `   `  ���� H  DLeagueManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:LeagueManager.ViewsLeagueManager.Views  =#clr-namespace:LeagueManager.ContextLeagueManager.Context  $    LeagueManager.Views.LeagueView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:LeagueManager.Views     7Context#clr-namespace:LeagueManager.Context     -     � Title$  
LeagueView��$	��450��$	��800��.��� .+��� $
��Left=�$	��419��$��-1,0,0,0q�$	��Top=�$	��793��}�. .@��� $��Players��}�. .��� ���	#FFE5E5E5.+��� -    ��Name$ ListView��$
��Left=�$	��278��$��	19,32,0,0q�$	��Top=�$	��449�� �� View �� .P��� $
��Name�� �� DisplayMemberBinding �� *Name+�� $	��Elo�� �� *Elo+�� $��Achievement Score�� �� *AchievementScore+�� $��	Standings��}�. .��� ���	#FFE5E5E5.+��� $
��Left=�$	��391��$	��Top=�$	��787��.@��� $��	This week��.��� ���	#FFE5E5E5 � ColumnDefinitions �� $	��90* ��� $
��691* �.+��� -   $ DailyStandings��$
��Left=�$	��363��$	��Top=�$	��689��$��2�� �� .P��� $
��Name�� �� *Name+�� $	��Elo�� �� *Elo+�� $��GamesWon�� �� *
GamesWon+�� $��	GamesLost�� �� *	GamesLost+�� -   $��Show standings��$��1��$
��Left=�$��
604,28,0,0q�$	��Top=�$��87���� -    ��Name$ SumUp��$��End turn��$��1��$
��Left=�$��
604,53,0,0q�$	��Top=�$��87���� $��General��.��� ���	#FFE5E5E5 �� $	��46* ��� $	��44* ��� $
��691* �.+��� -   $ GeneralStandings��$
��Left=�$	��363��$	��Top=�$	��689��$��3�� �� .P��� $
��Name�� �� *Name+�� $	��Elo�� �� *Elo+�� $��GamesWon�� �� *GeneralGamesWon+�� $��	GamesLost�� �� *GeneralGamesLost+�� $��Matchups��}�. .��� ���	#FFE5E5E5 �� $
��143* ��� $
��644* �.+��� -   $ Generate��$��Generate��$
��Left=�$��430.833,9,0,0q�$	��Top=�$��75��$��33��$��1���� -    ��Name$ MatchBox��$
��Left=�$��235.833,10,0,0q�$	��Top=�$	��190��$��32��$��1���� -	   $ MatchupsListView��$
��Left=�$	��371��$��	10,10,0,0q�$	��Top=�$	��364��$��2�� �� .P��� $��Player 1�� �� *	Player1+�� $��Player 2�� �� *	Player2+�� $��Is Finished�� �� *
IsFinished+�� $��Winner�� �� *Winner+�� $
��Date�� �� *	MatchDate+�� -
   $ Delete��$��Delete��$
��Left=�$��
431,47,0,0q�$	��Top=�$��75��$��33��$��1���� -   $ 	WinnerBox��$
��Left=�$��
236,48,0,0q�$	��Top=�$	��190��$��32��$��1���� -   $ Score��$��Score��$
��Left=�$��
431,85,0,0q�$	��Top=�$��75��$��33��$��1���� -   $ PlayerBoxList��$
��Left=�$��
236,85,0,0q�$	��Top=�$	��190��$��32��$��1���� -   $ Absent��$��Absent��$
��Left=�$��431,123,0,0q�$	��Top=�$��75��$��33��$��1���� $��Achievements��}�. .��� ���	#FFE5E5E5 �� $
��143* ��� $
��644* �.+��� -   $ AchListView��$
��Left=�$	��371��$	��Top=�$	��629��$��	10,10,0,0q�$��2�� �� .P��� $��Achievement Name�� �� *Name+�� $��Score�� �� *Score+�� $��Description�� �� *Description+�� $��Players who have it�� �� *ListOfPlayers+�� -   $ AddAch��$	��Add��$��1��$
��Left=�$��
519,70,0,0q�$	��Top=�$��75���� -   $ DelAch��$��Delete��$��1��$
��Left=�$��
519,95,0,0q�$	��Top=�$��75���� -   $ Assign��$��Assign��$��1��$
��Left=�$��519,120,0,0q�$	��Top=�$��75���� -   $ 
AchPlayers��$��1��$
��Left=�$��501,145,0,0q�$	��Top=�$	��120���� -   $ AchDDL��$��1��$
��Left=�$��501,172,0,0q�$	��Top=�$	��120���� $��History��.��� ���	#FFE5E5E5$��0,-1,0,1q�}�. .+��� -   $ MatchupsHistory��$
��Left=�$	��278��$��	19,32,0,0q�$	��Top=�$	��449�� �� .P��� $
��Date�� �� *Date+�� $��Winner�� �� *
WinnerName+�� -   $ MatchupSelect��$
��Left=�$��
508,76,0,0q�$	��Top=�$	��120���� -   $ TurnInfo��$��Details��$
��Left=�$��
657,76,0,0q�$	��Top=�$��75��