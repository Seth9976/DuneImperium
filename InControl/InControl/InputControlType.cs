using System;

namespace InControl
{
	// Token: 0x0200002B RID: 43
	public enum InputControlType
	{
		// Token: 0x0400030B RID: 779
		None,
		// Token: 0x0400030C RID: 780
		LeftStickUp,
		// Token: 0x0400030D RID: 781
		LeftStickDown,
		// Token: 0x0400030E RID: 782
		LeftStickLeft,
		// Token: 0x0400030F RID: 783
		LeftStickRight,
		// Token: 0x04000310 RID: 784
		LeftStickButton,
		// Token: 0x04000311 RID: 785
		RightStickUp,
		// Token: 0x04000312 RID: 786
		RightStickDown,
		// Token: 0x04000313 RID: 787
		RightStickLeft,
		// Token: 0x04000314 RID: 788
		RightStickRight,
		// Token: 0x04000315 RID: 789
		RightStickButton,
		// Token: 0x04000316 RID: 790
		DPadUp,
		// Token: 0x04000317 RID: 791
		DPadDown,
		// Token: 0x04000318 RID: 792
		DPadLeft,
		// Token: 0x04000319 RID: 793
		DPadRight,
		// Token: 0x0400031A RID: 794
		LeftTrigger,
		// Token: 0x0400031B RID: 795
		RightTrigger,
		// Token: 0x0400031C RID: 796
		LeftBumper,
		// Token: 0x0400031D RID: 797
		RightBumper,
		// Token: 0x0400031E RID: 798
		Action1,
		// Token: 0x0400031F RID: 799
		Action2,
		// Token: 0x04000320 RID: 800
		Action3,
		// Token: 0x04000321 RID: 801
		Action4,
		// Token: 0x04000322 RID: 802
		Action5,
		// Token: 0x04000323 RID: 803
		Action6,
		// Token: 0x04000324 RID: 804
		Action7,
		// Token: 0x04000325 RID: 805
		Action8,
		// Token: 0x04000326 RID: 806
		Action9,
		// Token: 0x04000327 RID: 807
		Action10,
		// Token: 0x04000328 RID: 808
		Action11,
		// Token: 0x04000329 RID: 809
		Action12,
		// Token: 0x0400032A RID: 810
		Back = 100,
		// Token: 0x0400032B RID: 811
		Start,
		// Token: 0x0400032C RID: 812
		Select,
		// Token: 0x0400032D RID: 813
		System,
		// Token: 0x0400032E RID: 814
		Options,
		// Token: 0x0400032F RID: 815
		Pause,
		// Token: 0x04000330 RID: 816
		Menu,
		// Token: 0x04000331 RID: 817
		Share,
		// Token: 0x04000332 RID: 818
		Home,
		// Token: 0x04000333 RID: 819
		View,
		// Token: 0x04000334 RID: 820
		Power,
		// Token: 0x04000335 RID: 821
		Capture,
		// Token: 0x04000336 RID: 822
		Assistant,
		// Token: 0x04000337 RID: 823
		Plus,
		// Token: 0x04000338 RID: 824
		Minus,
		// Token: 0x04000339 RID: 825
		Create,
		// Token: 0x0400033A RID: 826
		Mute,
		// Token: 0x0400033B RID: 827
		Guide,
		// Token: 0x0400033C RID: 828
		PedalLeft = 150,
		// Token: 0x0400033D RID: 829
		PedalRight,
		// Token: 0x0400033E RID: 830
		PedalMiddle,
		// Token: 0x0400033F RID: 831
		GearUp,
		// Token: 0x04000340 RID: 832
		GearDown,
		// Token: 0x04000341 RID: 833
		Pitch = 200,
		// Token: 0x04000342 RID: 834
		Roll,
		// Token: 0x04000343 RID: 835
		Yaw,
		// Token: 0x04000344 RID: 836
		PitchUp,
		// Token: 0x04000345 RID: 837
		PitchDown,
		// Token: 0x04000346 RID: 838
		RollLeft,
		// Token: 0x04000347 RID: 839
		RollRight,
		// Token: 0x04000348 RID: 840
		YawLeft,
		// Token: 0x04000349 RID: 841
		YawRight,
		// Token: 0x0400034A RID: 842
		ThrottleUp,
		// Token: 0x0400034B RID: 843
		ThrottleDown,
		// Token: 0x0400034C RID: 844
		ThrottleLeft,
		// Token: 0x0400034D RID: 845
		ThrottleRight,
		// Token: 0x0400034E RID: 846
		POVUp,
		// Token: 0x0400034F RID: 847
		POVDown,
		// Token: 0x04000350 RID: 848
		POVLeft,
		// Token: 0x04000351 RID: 849
		POVRight,
		// Token: 0x04000352 RID: 850
		TiltX = 250,
		// Token: 0x04000353 RID: 851
		TiltY,
		// Token: 0x04000354 RID: 852
		TiltZ,
		// Token: 0x04000355 RID: 853
		GyroscopeX = 250,
		// Token: 0x04000356 RID: 854
		GyroscopeY,
		// Token: 0x04000357 RID: 855
		GyroscopeZ,
		// Token: 0x04000358 RID: 856
		AccelerometerX,
		// Token: 0x04000359 RID: 857
		AccelerometerY,
		// Token: 0x0400035A RID: 858
		AccelerometerZ,
		// Token: 0x0400035B RID: 859
		ScrollWheel,
		// Token: 0x0400035C RID: 860
		TouchPadTap,
		// Token: 0x0400035D RID: 861
		TouchPadButton,
		// Token: 0x0400035E RID: 862
		TouchPadXAxis,
		// Token: 0x0400035F RID: 863
		TouchPadYAxis,
		// Token: 0x04000360 RID: 864
		LeftSL,
		// Token: 0x04000361 RID: 865
		LeftSR,
		// Token: 0x04000362 RID: 866
		RightSL,
		// Token: 0x04000363 RID: 867
		RightSR,
		// Token: 0x04000364 RID: 868
		Paddle1,
		// Token: 0x04000365 RID: 869
		Paddle2,
		// Token: 0x04000366 RID: 870
		Paddle3,
		// Token: 0x04000367 RID: 871
		Paddle4,
		// Token: 0x04000368 RID: 872
		Command = 300,
		// Token: 0x04000369 RID: 873
		LeftStickX,
		// Token: 0x0400036A RID: 874
		LeftStickY,
		// Token: 0x0400036B RID: 875
		RightStickX,
		// Token: 0x0400036C RID: 876
		RightStickY,
		// Token: 0x0400036D RID: 877
		DPadX,
		// Token: 0x0400036E RID: 878
		DPadY,
		// Token: 0x0400036F RID: 879
		LeftCommand,
		// Token: 0x04000370 RID: 880
		RightCommand,
		// Token: 0x04000371 RID: 881
		Analog0 = 400,
		// Token: 0x04000372 RID: 882
		Analog1,
		// Token: 0x04000373 RID: 883
		Analog2,
		// Token: 0x04000374 RID: 884
		Analog3,
		// Token: 0x04000375 RID: 885
		Analog4,
		// Token: 0x04000376 RID: 886
		Analog5,
		// Token: 0x04000377 RID: 887
		Analog6,
		// Token: 0x04000378 RID: 888
		Analog7,
		// Token: 0x04000379 RID: 889
		Analog8,
		// Token: 0x0400037A RID: 890
		Analog9,
		// Token: 0x0400037B RID: 891
		Analog10,
		// Token: 0x0400037C RID: 892
		Analog11,
		// Token: 0x0400037D RID: 893
		Analog12,
		// Token: 0x0400037E RID: 894
		Analog13,
		// Token: 0x0400037F RID: 895
		Analog14,
		// Token: 0x04000380 RID: 896
		Analog15,
		// Token: 0x04000381 RID: 897
		Analog16,
		// Token: 0x04000382 RID: 898
		Analog17,
		// Token: 0x04000383 RID: 899
		Analog18,
		// Token: 0x04000384 RID: 900
		Analog19,
		// Token: 0x04000385 RID: 901
		Button0 = 500,
		// Token: 0x04000386 RID: 902
		Button1,
		// Token: 0x04000387 RID: 903
		Button2,
		// Token: 0x04000388 RID: 904
		Button3,
		// Token: 0x04000389 RID: 905
		Button4,
		// Token: 0x0400038A RID: 906
		Button5,
		// Token: 0x0400038B RID: 907
		Button6,
		// Token: 0x0400038C RID: 908
		Button7,
		// Token: 0x0400038D RID: 909
		Button8,
		// Token: 0x0400038E RID: 910
		Button9,
		// Token: 0x0400038F RID: 911
		Button10,
		// Token: 0x04000390 RID: 912
		Button11,
		// Token: 0x04000391 RID: 913
		Button12,
		// Token: 0x04000392 RID: 914
		Button13,
		// Token: 0x04000393 RID: 915
		Button14,
		// Token: 0x04000394 RID: 916
		Button15,
		// Token: 0x04000395 RID: 917
		Button16,
		// Token: 0x04000396 RID: 918
		Button17,
		// Token: 0x04000397 RID: 919
		Button18,
		// Token: 0x04000398 RID: 920
		Button19,
		// Token: 0x04000399 RID: 921
		Button20,
		// Token: 0x0400039A RID: 922
		Button21,
		// Token: 0x0400039B RID: 923
		Button22,
		// Token: 0x0400039C RID: 924
		Button23,
		// Token: 0x0400039D RID: 925
		Button24,
		// Token: 0x0400039E RID: 926
		Button25,
		// Token: 0x0400039F RID: 927
		Button26,
		// Token: 0x040003A0 RID: 928
		Button27,
		// Token: 0x040003A1 RID: 929
		Button28,
		// Token: 0x040003A2 RID: 930
		Button29,
		// Token: 0x040003A3 RID: 931
		Count
	}
}
