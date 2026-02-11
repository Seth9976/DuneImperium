using System;

namespace Steamworks
{
	// Token: 0x0200006E RID: 110
	public enum InputActionOrigin
	{
		// Token: 0x04000AC2 RID: 2754
		None,
		// Token: 0x04000AC3 RID: 2755
		SteamController_A,
		// Token: 0x04000AC4 RID: 2756
		SteamController_B,
		// Token: 0x04000AC5 RID: 2757
		SteamController_X,
		// Token: 0x04000AC6 RID: 2758
		SteamController_Y,
		// Token: 0x04000AC7 RID: 2759
		SteamController_LeftBumper,
		// Token: 0x04000AC8 RID: 2760
		SteamController_RightBumper,
		// Token: 0x04000AC9 RID: 2761
		SteamController_LeftGrip,
		// Token: 0x04000ACA RID: 2762
		SteamController_RightGrip,
		// Token: 0x04000ACB RID: 2763
		SteamController_Start,
		// Token: 0x04000ACC RID: 2764
		SteamController_Back,
		// Token: 0x04000ACD RID: 2765
		SteamController_LeftPad_Touch,
		// Token: 0x04000ACE RID: 2766
		SteamController_LeftPad_Swipe,
		// Token: 0x04000ACF RID: 2767
		SteamController_LeftPad_Click,
		// Token: 0x04000AD0 RID: 2768
		SteamController_LeftPad_DPadNorth,
		// Token: 0x04000AD1 RID: 2769
		SteamController_LeftPad_DPadSouth,
		// Token: 0x04000AD2 RID: 2770
		SteamController_LeftPad_DPadWest,
		// Token: 0x04000AD3 RID: 2771
		SteamController_LeftPad_DPadEast,
		// Token: 0x04000AD4 RID: 2772
		SteamController_RightPad_Touch,
		// Token: 0x04000AD5 RID: 2773
		SteamController_RightPad_Swipe,
		// Token: 0x04000AD6 RID: 2774
		SteamController_RightPad_Click,
		// Token: 0x04000AD7 RID: 2775
		SteamController_RightPad_DPadNorth,
		// Token: 0x04000AD8 RID: 2776
		SteamController_RightPad_DPadSouth,
		// Token: 0x04000AD9 RID: 2777
		SteamController_RightPad_DPadWest,
		// Token: 0x04000ADA RID: 2778
		SteamController_RightPad_DPadEast,
		// Token: 0x04000ADB RID: 2779
		SteamController_LeftTrigger_Pull,
		// Token: 0x04000ADC RID: 2780
		SteamController_LeftTrigger_Click,
		// Token: 0x04000ADD RID: 2781
		SteamController_RightTrigger_Pull,
		// Token: 0x04000ADE RID: 2782
		SteamController_RightTrigger_Click,
		// Token: 0x04000ADF RID: 2783
		SteamController_LeftStick_Move,
		// Token: 0x04000AE0 RID: 2784
		SteamController_LeftStick_Click,
		// Token: 0x04000AE1 RID: 2785
		SteamController_LeftStick_DPadNorth,
		// Token: 0x04000AE2 RID: 2786
		SteamController_LeftStick_DPadSouth,
		// Token: 0x04000AE3 RID: 2787
		SteamController_LeftStick_DPadWest,
		// Token: 0x04000AE4 RID: 2788
		SteamController_LeftStick_DPadEast,
		// Token: 0x04000AE5 RID: 2789
		SteamController_Gyro_Move,
		// Token: 0x04000AE6 RID: 2790
		SteamController_Gyro_Pitch,
		// Token: 0x04000AE7 RID: 2791
		SteamController_Gyro_Yaw,
		// Token: 0x04000AE8 RID: 2792
		SteamController_Gyro_Roll,
		// Token: 0x04000AE9 RID: 2793
		SteamController_Reserved0,
		// Token: 0x04000AEA RID: 2794
		SteamController_Reserved1,
		// Token: 0x04000AEB RID: 2795
		SteamController_Reserved2,
		// Token: 0x04000AEC RID: 2796
		SteamController_Reserved3,
		// Token: 0x04000AED RID: 2797
		SteamController_Reserved4,
		// Token: 0x04000AEE RID: 2798
		SteamController_Reserved5,
		// Token: 0x04000AEF RID: 2799
		SteamController_Reserved6,
		// Token: 0x04000AF0 RID: 2800
		SteamController_Reserved7,
		// Token: 0x04000AF1 RID: 2801
		SteamController_Reserved8,
		// Token: 0x04000AF2 RID: 2802
		SteamController_Reserved9,
		// Token: 0x04000AF3 RID: 2803
		SteamController_Reserved10,
		// Token: 0x04000AF4 RID: 2804
		PS4_X,
		// Token: 0x04000AF5 RID: 2805
		PS4_Circle,
		// Token: 0x04000AF6 RID: 2806
		PS4_Triangle,
		// Token: 0x04000AF7 RID: 2807
		PS4_Square,
		// Token: 0x04000AF8 RID: 2808
		PS4_LeftBumper,
		// Token: 0x04000AF9 RID: 2809
		PS4_RightBumper,
		// Token: 0x04000AFA RID: 2810
		PS4_Options,
		// Token: 0x04000AFB RID: 2811
		PS4_Share,
		// Token: 0x04000AFC RID: 2812
		PS4_LeftPad_Touch,
		// Token: 0x04000AFD RID: 2813
		PS4_LeftPad_Swipe,
		// Token: 0x04000AFE RID: 2814
		PS4_LeftPad_Click,
		// Token: 0x04000AFF RID: 2815
		PS4_LeftPad_DPadNorth,
		// Token: 0x04000B00 RID: 2816
		PS4_LeftPad_DPadSouth,
		// Token: 0x04000B01 RID: 2817
		PS4_LeftPad_DPadWest,
		// Token: 0x04000B02 RID: 2818
		PS4_LeftPad_DPadEast,
		// Token: 0x04000B03 RID: 2819
		PS4_RightPad_Touch,
		// Token: 0x04000B04 RID: 2820
		PS4_RightPad_Swipe,
		// Token: 0x04000B05 RID: 2821
		PS4_RightPad_Click,
		// Token: 0x04000B06 RID: 2822
		PS4_RightPad_DPadNorth,
		// Token: 0x04000B07 RID: 2823
		PS4_RightPad_DPadSouth,
		// Token: 0x04000B08 RID: 2824
		PS4_RightPad_DPadWest,
		// Token: 0x04000B09 RID: 2825
		PS4_RightPad_DPadEast,
		// Token: 0x04000B0A RID: 2826
		PS4_CenterPad_Touch,
		// Token: 0x04000B0B RID: 2827
		PS4_CenterPad_Swipe,
		// Token: 0x04000B0C RID: 2828
		PS4_CenterPad_Click,
		// Token: 0x04000B0D RID: 2829
		PS4_CenterPad_DPadNorth,
		// Token: 0x04000B0E RID: 2830
		PS4_CenterPad_DPadSouth,
		// Token: 0x04000B0F RID: 2831
		PS4_CenterPad_DPadWest,
		// Token: 0x04000B10 RID: 2832
		PS4_CenterPad_DPadEast,
		// Token: 0x04000B11 RID: 2833
		PS4_LeftTrigger_Pull,
		// Token: 0x04000B12 RID: 2834
		PS4_LeftTrigger_Click,
		// Token: 0x04000B13 RID: 2835
		PS4_RightTrigger_Pull,
		// Token: 0x04000B14 RID: 2836
		PS4_RightTrigger_Click,
		// Token: 0x04000B15 RID: 2837
		PS4_LeftStick_Move,
		// Token: 0x04000B16 RID: 2838
		PS4_LeftStick_Click,
		// Token: 0x04000B17 RID: 2839
		PS4_LeftStick_DPadNorth,
		// Token: 0x04000B18 RID: 2840
		PS4_LeftStick_DPadSouth,
		// Token: 0x04000B19 RID: 2841
		PS4_LeftStick_DPadWest,
		// Token: 0x04000B1A RID: 2842
		PS4_LeftStick_DPadEast,
		// Token: 0x04000B1B RID: 2843
		PS4_RightStick_Move,
		// Token: 0x04000B1C RID: 2844
		PS4_RightStick_Click,
		// Token: 0x04000B1D RID: 2845
		PS4_RightStick_DPadNorth,
		// Token: 0x04000B1E RID: 2846
		PS4_RightStick_DPadSouth,
		// Token: 0x04000B1F RID: 2847
		PS4_RightStick_DPadWest,
		// Token: 0x04000B20 RID: 2848
		PS4_RightStick_DPadEast,
		// Token: 0x04000B21 RID: 2849
		PS4_DPad_North,
		// Token: 0x04000B22 RID: 2850
		PS4_DPad_South,
		// Token: 0x04000B23 RID: 2851
		PS4_DPad_West,
		// Token: 0x04000B24 RID: 2852
		PS4_DPad_East,
		// Token: 0x04000B25 RID: 2853
		PS4_Gyro_Move,
		// Token: 0x04000B26 RID: 2854
		PS4_Gyro_Pitch,
		// Token: 0x04000B27 RID: 2855
		PS4_Gyro_Yaw,
		// Token: 0x04000B28 RID: 2856
		PS4_Gyro_Roll,
		// Token: 0x04000B29 RID: 2857
		PS4_DPad_Move,
		// Token: 0x04000B2A RID: 2858
		PS4_Reserved1,
		// Token: 0x04000B2B RID: 2859
		PS4_Reserved2,
		// Token: 0x04000B2C RID: 2860
		PS4_Reserved3,
		// Token: 0x04000B2D RID: 2861
		PS4_Reserved4,
		// Token: 0x04000B2E RID: 2862
		PS4_Reserved5,
		// Token: 0x04000B2F RID: 2863
		PS4_Reserved6,
		// Token: 0x04000B30 RID: 2864
		PS4_Reserved7,
		// Token: 0x04000B31 RID: 2865
		PS4_Reserved8,
		// Token: 0x04000B32 RID: 2866
		PS4_Reserved9,
		// Token: 0x04000B33 RID: 2867
		PS4_Reserved10,
		// Token: 0x04000B34 RID: 2868
		XBoxOne_A,
		// Token: 0x04000B35 RID: 2869
		XBoxOne_B,
		// Token: 0x04000B36 RID: 2870
		XBoxOne_X,
		// Token: 0x04000B37 RID: 2871
		XBoxOne_Y,
		// Token: 0x04000B38 RID: 2872
		XBoxOne_LeftBumper,
		// Token: 0x04000B39 RID: 2873
		XBoxOne_RightBumper,
		// Token: 0x04000B3A RID: 2874
		XBoxOne_Menu,
		// Token: 0x04000B3B RID: 2875
		XBoxOne_View,
		// Token: 0x04000B3C RID: 2876
		XBoxOne_LeftTrigger_Pull,
		// Token: 0x04000B3D RID: 2877
		XBoxOne_LeftTrigger_Click,
		// Token: 0x04000B3E RID: 2878
		XBoxOne_RightTrigger_Pull,
		// Token: 0x04000B3F RID: 2879
		XBoxOne_RightTrigger_Click,
		// Token: 0x04000B40 RID: 2880
		XBoxOne_LeftStick_Move,
		// Token: 0x04000B41 RID: 2881
		XBoxOne_LeftStick_Click,
		// Token: 0x04000B42 RID: 2882
		XBoxOne_LeftStick_DPadNorth,
		// Token: 0x04000B43 RID: 2883
		XBoxOne_LeftStick_DPadSouth,
		// Token: 0x04000B44 RID: 2884
		XBoxOne_LeftStick_DPadWest,
		// Token: 0x04000B45 RID: 2885
		XBoxOne_LeftStick_DPadEast,
		// Token: 0x04000B46 RID: 2886
		XBoxOne_RightStick_Move,
		// Token: 0x04000B47 RID: 2887
		XBoxOne_RightStick_Click,
		// Token: 0x04000B48 RID: 2888
		XBoxOne_RightStick_DPadNorth,
		// Token: 0x04000B49 RID: 2889
		XBoxOne_RightStick_DPadSouth,
		// Token: 0x04000B4A RID: 2890
		XBoxOne_RightStick_DPadWest,
		// Token: 0x04000B4B RID: 2891
		XBoxOne_RightStick_DPadEast,
		// Token: 0x04000B4C RID: 2892
		XBoxOne_DPad_North,
		// Token: 0x04000B4D RID: 2893
		XBoxOne_DPad_South,
		// Token: 0x04000B4E RID: 2894
		XBoxOne_DPad_West,
		// Token: 0x04000B4F RID: 2895
		XBoxOne_DPad_East,
		// Token: 0x04000B50 RID: 2896
		XBoxOne_DPad_Move,
		// Token: 0x04000B51 RID: 2897
		XBoxOne_LeftGrip_Lower,
		// Token: 0x04000B52 RID: 2898
		XBoxOne_LeftGrip_Upper,
		// Token: 0x04000B53 RID: 2899
		XBoxOne_RightGrip_Lower,
		// Token: 0x04000B54 RID: 2900
		XBoxOne_RightGrip_Upper,
		// Token: 0x04000B55 RID: 2901
		XBoxOne_Share,
		// Token: 0x04000B56 RID: 2902
		XBoxOne_Reserved6,
		// Token: 0x04000B57 RID: 2903
		XBoxOne_Reserved7,
		// Token: 0x04000B58 RID: 2904
		XBoxOne_Reserved8,
		// Token: 0x04000B59 RID: 2905
		XBoxOne_Reserved9,
		// Token: 0x04000B5A RID: 2906
		XBoxOne_Reserved10,
		// Token: 0x04000B5B RID: 2907
		XBox360_A,
		// Token: 0x04000B5C RID: 2908
		XBox360_B,
		// Token: 0x04000B5D RID: 2909
		XBox360_X,
		// Token: 0x04000B5E RID: 2910
		XBox360_Y,
		// Token: 0x04000B5F RID: 2911
		XBox360_LeftBumper,
		// Token: 0x04000B60 RID: 2912
		XBox360_RightBumper,
		// Token: 0x04000B61 RID: 2913
		XBox360_Start,
		// Token: 0x04000B62 RID: 2914
		XBox360_Back,
		// Token: 0x04000B63 RID: 2915
		XBox360_LeftTrigger_Pull,
		// Token: 0x04000B64 RID: 2916
		XBox360_LeftTrigger_Click,
		// Token: 0x04000B65 RID: 2917
		XBox360_RightTrigger_Pull,
		// Token: 0x04000B66 RID: 2918
		XBox360_RightTrigger_Click,
		// Token: 0x04000B67 RID: 2919
		XBox360_LeftStick_Move,
		// Token: 0x04000B68 RID: 2920
		XBox360_LeftStick_Click,
		// Token: 0x04000B69 RID: 2921
		XBox360_LeftStick_DPadNorth,
		// Token: 0x04000B6A RID: 2922
		XBox360_LeftStick_DPadSouth,
		// Token: 0x04000B6B RID: 2923
		XBox360_LeftStick_DPadWest,
		// Token: 0x04000B6C RID: 2924
		XBox360_LeftStick_DPadEast,
		// Token: 0x04000B6D RID: 2925
		XBox360_RightStick_Move,
		// Token: 0x04000B6E RID: 2926
		XBox360_RightStick_Click,
		// Token: 0x04000B6F RID: 2927
		XBox360_RightStick_DPadNorth,
		// Token: 0x04000B70 RID: 2928
		XBox360_RightStick_DPadSouth,
		// Token: 0x04000B71 RID: 2929
		XBox360_RightStick_DPadWest,
		// Token: 0x04000B72 RID: 2930
		XBox360_RightStick_DPadEast,
		// Token: 0x04000B73 RID: 2931
		XBox360_DPad_North,
		// Token: 0x04000B74 RID: 2932
		XBox360_DPad_South,
		// Token: 0x04000B75 RID: 2933
		XBox360_DPad_West,
		// Token: 0x04000B76 RID: 2934
		XBox360_DPad_East,
		// Token: 0x04000B77 RID: 2935
		XBox360_DPad_Move,
		// Token: 0x04000B78 RID: 2936
		XBox360_Reserved1,
		// Token: 0x04000B79 RID: 2937
		XBox360_Reserved2,
		// Token: 0x04000B7A RID: 2938
		XBox360_Reserved3,
		// Token: 0x04000B7B RID: 2939
		XBox360_Reserved4,
		// Token: 0x04000B7C RID: 2940
		XBox360_Reserved5,
		// Token: 0x04000B7D RID: 2941
		XBox360_Reserved6,
		// Token: 0x04000B7E RID: 2942
		XBox360_Reserved7,
		// Token: 0x04000B7F RID: 2943
		XBox360_Reserved8,
		// Token: 0x04000B80 RID: 2944
		XBox360_Reserved9,
		// Token: 0x04000B81 RID: 2945
		XBox360_Reserved10,
		// Token: 0x04000B82 RID: 2946
		Switch_A,
		// Token: 0x04000B83 RID: 2947
		Switch_B,
		// Token: 0x04000B84 RID: 2948
		Switch_X,
		// Token: 0x04000B85 RID: 2949
		Switch_Y,
		// Token: 0x04000B86 RID: 2950
		Switch_LeftBumper,
		// Token: 0x04000B87 RID: 2951
		Switch_RightBumper,
		// Token: 0x04000B88 RID: 2952
		Switch_Plus,
		// Token: 0x04000B89 RID: 2953
		Switch_Minus,
		// Token: 0x04000B8A RID: 2954
		Switch_Capture,
		// Token: 0x04000B8B RID: 2955
		Switch_LeftTrigger_Pull,
		// Token: 0x04000B8C RID: 2956
		Switch_LeftTrigger_Click,
		// Token: 0x04000B8D RID: 2957
		Switch_RightTrigger_Pull,
		// Token: 0x04000B8E RID: 2958
		Switch_RightTrigger_Click,
		// Token: 0x04000B8F RID: 2959
		Switch_LeftStick_Move,
		// Token: 0x04000B90 RID: 2960
		Switch_LeftStick_Click,
		// Token: 0x04000B91 RID: 2961
		Switch_LeftStick_DPadNorth,
		// Token: 0x04000B92 RID: 2962
		Switch_LeftStick_DPadSouth,
		// Token: 0x04000B93 RID: 2963
		Switch_LeftStick_DPadWest,
		// Token: 0x04000B94 RID: 2964
		Switch_LeftStick_DPadEast,
		// Token: 0x04000B95 RID: 2965
		Switch_RightStick_Move,
		// Token: 0x04000B96 RID: 2966
		Switch_RightStick_Click,
		// Token: 0x04000B97 RID: 2967
		Switch_RightStick_DPadNorth,
		// Token: 0x04000B98 RID: 2968
		Switch_RightStick_DPadSouth,
		// Token: 0x04000B99 RID: 2969
		Switch_RightStick_DPadWest,
		// Token: 0x04000B9A RID: 2970
		Switch_RightStick_DPadEast,
		// Token: 0x04000B9B RID: 2971
		Switch_DPad_North,
		// Token: 0x04000B9C RID: 2972
		Switch_DPad_South,
		// Token: 0x04000B9D RID: 2973
		Switch_DPad_West,
		// Token: 0x04000B9E RID: 2974
		Switch_DPad_East,
		// Token: 0x04000B9F RID: 2975
		Switch_ProGyro_Move,
		// Token: 0x04000BA0 RID: 2976
		Switch_ProGyro_Pitch,
		// Token: 0x04000BA1 RID: 2977
		Switch_ProGyro_Yaw,
		// Token: 0x04000BA2 RID: 2978
		Switch_ProGyro_Roll,
		// Token: 0x04000BA3 RID: 2979
		Switch_DPad_Move,
		// Token: 0x04000BA4 RID: 2980
		Switch_Reserved1,
		// Token: 0x04000BA5 RID: 2981
		Switch_Reserved2,
		// Token: 0x04000BA6 RID: 2982
		Switch_Reserved3,
		// Token: 0x04000BA7 RID: 2983
		Switch_Reserved4,
		// Token: 0x04000BA8 RID: 2984
		Switch_Reserved5,
		// Token: 0x04000BA9 RID: 2985
		Switch_Reserved6,
		// Token: 0x04000BAA RID: 2986
		Switch_Reserved7,
		// Token: 0x04000BAB RID: 2987
		Switch_Reserved8,
		// Token: 0x04000BAC RID: 2988
		Switch_Reserved9,
		// Token: 0x04000BAD RID: 2989
		Switch_Reserved10,
		// Token: 0x04000BAE RID: 2990
		Switch_RightGyro_Move,
		// Token: 0x04000BAF RID: 2991
		Switch_RightGyro_Pitch,
		// Token: 0x04000BB0 RID: 2992
		Switch_RightGyro_Yaw,
		// Token: 0x04000BB1 RID: 2993
		Switch_RightGyro_Roll,
		// Token: 0x04000BB2 RID: 2994
		Switch_LeftGyro_Move,
		// Token: 0x04000BB3 RID: 2995
		Switch_LeftGyro_Pitch,
		// Token: 0x04000BB4 RID: 2996
		Switch_LeftGyro_Yaw,
		// Token: 0x04000BB5 RID: 2997
		Switch_LeftGyro_Roll,
		// Token: 0x04000BB6 RID: 2998
		Switch_LeftGrip_Lower,
		// Token: 0x04000BB7 RID: 2999
		Switch_LeftGrip_Upper,
		// Token: 0x04000BB8 RID: 3000
		Switch_RightGrip_Lower,
		// Token: 0x04000BB9 RID: 3001
		Switch_RightGrip_Upper,
		// Token: 0x04000BBA RID: 3002
		Switch_Reserved11,
		// Token: 0x04000BBB RID: 3003
		Switch_Reserved12,
		// Token: 0x04000BBC RID: 3004
		Switch_Reserved13,
		// Token: 0x04000BBD RID: 3005
		Switch_Reserved14,
		// Token: 0x04000BBE RID: 3006
		Switch_Reserved15,
		// Token: 0x04000BBF RID: 3007
		Switch_Reserved16,
		// Token: 0x04000BC0 RID: 3008
		Switch_Reserved17,
		// Token: 0x04000BC1 RID: 3009
		Switch_Reserved18,
		// Token: 0x04000BC2 RID: 3010
		Switch_Reserved19,
		// Token: 0x04000BC3 RID: 3011
		Switch_Reserved20,
		// Token: 0x04000BC4 RID: 3012
		PS5_X,
		// Token: 0x04000BC5 RID: 3013
		PS5_Circle,
		// Token: 0x04000BC6 RID: 3014
		PS5_Triangle,
		// Token: 0x04000BC7 RID: 3015
		PS5_Square,
		// Token: 0x04000BC8 RID: 3016
		PS5_LeftBumper,
		// Token: 0x04000BC9 RID: 3017
		PS5_RightBumper,
		// Token: 0x04000BCA RID: 3018
		PS5_Option,
		// Token: 0x04000BCB RID: 3019
		PS5_Create,
		// Token: 0x04000BCC RID: 3020
		PS5_Mute,
		// Token: 0x04000BCD RID: 3021
		PS5_LeftPad_Touch,
		// Token: 0x04000BCE RID: 3022
		PS5_LeftPad_Swipe,
		// Token: 0x04000BCF RID: 3023
		PS5_LeftPad_Click,
		// Token: 0x04000BD0 RID: 3024
		PS5_LeftPad_DPadNorth,
		// Token: 0x04000BD1 RID: 3025
		PS5_LeftPad_DPadSouth,
		// Token: 0x04000BD2 RID: 3026
		PS5_LeftPad_DPadWest,
		// Token: 0x04000BD3 RID: 3027
		PS5_LeftPad_DPadEast,
		// Token: 0x04000BD4 RID: 3028
		PS5_RightPad_Touch,
		// Token: 0x04000BD5 RID: 3029
		PS5_RightPad_Swipe,
		// Token: 0x04000BD6 RID: 3030
		PS5_RightPad_Click,
		// Token: 0x04000BD7 RID: 3031
		PS5_RightPad_DPadNorth,
		// Token: 0x04000BD8 RID: 3032
		PS5_RightPad_DPadSouth,
		// Token: 0x04000BD9 RID: 3033
		PS5_RightPad_DPadWest,
		// Token: 0x04000BDA RID: 3034
		PS5_RightPad_DPadEast,
		// Token: 0x04000BDB RID: 3035
		PS5_CenterPad_Touch,
		// Token: 0x04000BDC RID: 3036
		PS5_CenterPad_Swipe,
		// Token: 0x04000BDD RID: 3037
		PS5_CenterPad_Click,
		// Token: 0x04000BDE RID: 3038
		PS5_CenterPad_DPadNorth,
		// Token: 0x04000BDF RID: 3039
		PS5_CenterPad_DPadSouth,
		// Token: 0x04000BE0 RID: 3040
		PS5_CenterPad_DPadWest,
		// Token: 0x04000BE1 RID: 3041
		PS5_CenterPad_DPadEast,
		// Token: 0x04000BE2 RID: 3042
		PS5_LeftTrigger_Pull,
		// Token: 0x04000BE3 RID: 3043
		PS5_LeftTrigger_Click,
		// Token: 0x04000BE4 RID: 3044
		PS5_RightTrigger_Pull,
		// Token: 0x04000BE5 RID: 3045
		PS5_RightTrigger_Click,
		// Token: 0x04000BE6 RID: 3046
		PS5_LeftStick_Move,
		// Token: 0x04000BE7 RID: 3047
		PS5_LeftStick_Click,
		// Token: 0x04000BE8 RID: 3048
		PS5_LeftStick_DPadNorth,
		// Token: 0x04000BE9 RID: 3049
		PS5_LeftStick_DPadSouth,
		// Token: 0x04000BEA RID: 3050
		PS5_LeftStick_DPadWest,
		// Token: 0x04000BEB RID: 3051
		PS5_LeftStick_DPadEast,
		// Token: 0x04000BEC RID: 3052
		PS5_RightStick_Move,
		// Token: 0x04000BED RID: 3053
		PS5_RightStick_Click,
		// Token: 0x04000BEE RID: 3054
		PS5_RightStick_DPadNorth,
		// Token: 0x04000BEF RID: 3055
		PS5_RightStick_DPadSouth,
		// Token: 0x04000BF0 RID: 3056
		PS5_RightStick_DPadWest,
		// Token: 0x04000BF1 RID: 3057
		PS5_RightStick_DPadEast,
		// Token: 0x04000BF2 RID: 3058
		PS5_DPad_North,
		// Token: 0x04000BF3 RID: 3059
		PS5_DPad_South,
		// Token: 0x04000BF4 RID: 3060
		PS5_DPad_West,
		// Token: 0x04000BF5 RID: 3061
		PS5_DPad_East,
		// Token: 0x04000BF6 RID: 3062
		PS5_Gyro_Move,
		// Token: 0x04000BF7 RID: 3063
		PS5_Gyro_Pitch,
		// Token: 0x04000BF8 RID: 3064
		PS5_Gyro_Yaw,
		// Token: 0x04000BF9 RID: 3065
		PS5_Gyro_Roll,
		// Token: 0x04000BFA RID: 3066
		PS5_DPad_Move,
		// Token: 0x04000BFB RID: 3067
		PS5_Reserved1,
		// Token: 0x04000BFC RID: 3068
		PS5_Reserved2,
		// Token: 0x04000BFD RID: 3069
		PS5_Reserved3,
		// Token: 0x04000BFE RID: 3070
		PS5_Reserved4,
		// Token: 0x04000BFF RID: 3071
		PS5_Reserved5,
		// Token: 0x04000C00 RID: 3072
		PS5_Reserved6,
		// Token: 0x04000C01 RID: 3073
		PS5_Reserved7,
		// Token: 0x04000C02 RID: 3074
		PS5_Reserved8,
		// Token: 0x04000C03 RID: 3075
		PS5_Reserved9,
		// Token: 0x04000C04 RID: 3076
		PS5_Reserved10,
		// Token: 0x04000C05 RID: 3077
		PS5_Reserved11,
		// Token: 0x04000C06 RID: 3078
		PS5_Reserved12,
		// Token: 0x04000C07 RID: 3079
		PS5_Reserved13,
		// Token: 0x04000C08 RID: 3080
		PS5_Reserved14,
		// Token: 0x04000C09 RID: 3081
		PS5_Reserved15,
		// Token: 0x04000C0A RID: 3082
		PS5_Reserved16,
		// Token: 0x04000C0B RID: 3083
		PS5_Reserved17,
		// Token: 0x04000C0C RID: 3084
		PS5_Reserved18,
		// Token: 0x04000C0D RID: 3085
		PS5_Reserved19,
		// Token: 0x04000C0E RID: 3086
		PS5_Reserved20,
		// Token: 0x04000C0F RID: 3087
		SteamDeck_A,
		// Token: 0x04000C10 RID: 3088
		SteamDeck_B,
		// Token: 0x04000C11 RID: 3089
		SteamDeck_X,
		// Token: 0x04000C12 RID: 3090
		SteamDeck_Y,
		// Token: 0x04000C13 RID: 3091
		SteamDeck_L1,
		// Token: 0x04000C14 RID: 3092
		SteamDeck_R1,
		// Token: 0x04000C15 RID: 3093
		SteamDeck_Menu,
		// Token: 0x04000C16 RID: 3094
		SteamDeck_View,
		// Token: 0x04000C17 RID: 3095
		SteamDeck_LeftPad_Touch,
		// Token: 0x04000C18 RID: 3096
		SteamDeck_LeftPad_Swipe,
		// Token: 0x04000C19 RID: 3097
		SteamDeck_LeftPad_Click,
		// Token: 0x04000C1A RID: 3098
		SteamDeck_LeftPad_DPadNorth,
		// Token: 0x04000C1B RID: 3099
		SteamDeck_LeftPad_DPadSouth,
		// Token: 0x04000C1C RID: 3100
		SteamDeck_LeftPad_DPadWest,
		// Token: 0x04000C1D RID: 3101
		SteamDeck_LeftPad_DPadEast,
		// Token: 0x04000C1E RID: 3102
		SteamDeck_RightPad_Touch,
		// Token: 0x04000C1F RID: 3103
		SteamDeck_RightPad_Swipe,
		// Token: 0x04000C20 RID: 3104
		SteamDeck_RightPad_Click,
		// Token: 0x04000C21 RID: 3105
		SteamDeck_RightPad_DPadNorth,
		// Token: 0x04000C22 RID: 3106
		SteamDeck_RightPad_DPadSouth,
		// Token: 0x04000C23 RID: 3107
		SteamDeck_RightPad_DPadWest,
		// Token: 0x04000C24 RID: 3108
		SteamDeck_RightPad_DPadEast,
		// Token: 0x04000C25 RID: 3109
		SteamDeck_L2_SoftPull,
		// Token: 0x04000C26 RID: 3110
		SteamDeck_L2,
		// Token: 0x04000C27 RID: 3111
		SteamDeck_R2_SoftPull,
		// Token: 0x04000C28 RID: 3112
		SteamDeck_R2,
		// Token: 0x04000C29 RID: 3113
		SteamDeck_LeftStick_Move,
		// Token: 0x04000C2A RID: 3114
		SteamDeck_L3,
		// Token: 0x04000C2B RID: 3115
		SteamDeck_LeftStick_DPadNorth,
		// Token: 0x04000C2C RID: 3116
		SteamDeck_LeftStick_DPadSouth,
		// Token: 0x04000C2D RID: 3117
		SteamDeck_LeftStick_DPadWest,
		// Token: 0x04000C2E RID: 3118
		SteamDeck_LeftStick_DPadEast,
		// Token: 0x04000C2F RID: 3119
		SteamDeck_LeftStick_Touch,
		// Token: 0x04000C30 RID: 3120
		SteamDeck_RightStick_Move,
		// Token: 0x04000C31 RID: 3121
		SteamDeck_R3,
		// Token: 0x04000C32 RID: 3122
		SteamDeck_RightStick_DPadNorth,
		// Token: 0x04000C33 RID: 3123
		SteamDeck_RightStick_DPadSouth,
		// Token: 0x04000C34 RID: 3124
		SteamDeck_RightStick_DPadWest,
		// Token: 0x04000C35 RID: 3125
		SteamDeck_RightStick_DPadEast,
		// Token: 0x04000C36 RID: 3126
		SteamDeck_RightStick_Touch,
		// Token: 0x04000C37 RID: 3127
		SteamDeck_L4,
		// Token: 0x04000C38 RID: 3128
		SteamDeck_R4,
		// Token: 0x04000C39 RID: 3129
		SteamDeck_L5,
		// Token: 0x04000C3A RID: 3130
		SteamDeck_R5,
		// Token: 0x04000C3B RID: 3131
		SteamDeck_DPad_Move,
		// Token: 0x04000C3C RID: 3132
		SteamDeck_DPad_North,
		// Token: 0x04000C3D RID: 3133
		SteamDeck_DPad_South,
		// Token: 0x04000C3E RID: 3134
		SteamDeck_DPad_West,
		// Token: 0x04000C3F RID: 3135
		SteamDeck_DPad_East,
		// Token: 0x04000C40 RID: 3136
		SteamDeck_Gyro_Move,
		// Token: 0x04000C41 RID: 3137
		SteamDeck_Gyro_Pitch,
		// Token: 0x04000C42 RID: 3138
		SteamDeck_Gyro_Yaw,
		// Token: 0x04000C43 RID: 3139
		SteamDeck_Gyro_Roll,
		// Token: 0x04000C44 RID: 3140
		SteamDeck_Reserved1,
		// Token: 0x04000C45 RID: 3141
		SteamDeck_Reserved2,
		// Token: 0x04000C46 RID: 3142
		SteamDeck_Reserved3,
		// Token: 0x04000C47 RID: 3143
		SteamDeck_Reserved4,
		// Token: 0x04000C48 RID: 3144
		SteamDeck_Reserved5,
		// Token: 0x04000C49 RID: 3145
		SteamDeck_Reserved6,
		// Token: 0x04000C4A RID: 3146
		SteamDeck_Reserved7,
		// Token: 0x04000C4B RID: 3147
		SteamDeck_Reserved8,
		// Token: 0x04000C4C RID: 3148
		SteamDeck_Reserved9,
		// Token: 0x04000C4D RID: 3149
		SteamDeck_Reserved10,
		// Token: 0x04000C4E RID: 3150
		SteamDeck_Reserved11,
		// Token: 0x04000C4F RID: 3151
		SteamDeck_Reserved12,
		// Token: 0x04000C50 RID: 3152
		SteamDeck_Reserved13,
		// Token: 0x04000C51 RID: 3153
		SteamDeck_Reserved14,
		// Token: 0x04000C52 RID: 3154
		SteamDeck_Reserved15,
		// Token: 0x04000C53 RID: 3155
		SteamDeck_Reserved16,
		// Token: 0x04000C54 RID: 3156
		SteamDeck_Reserved17,
		// Token: 0x04000C55 RID: 3157
		SteamDeck_Reserved18,
		// Token: 0x04000C56 RID: 3158
		SteamDeck_Reserved19,
		// Token: 0x04000C57 RID: 3159
		SteamDeck_Reserved20,
		// Token: 0x04000C58 RID: 3160
		Count,
		// Token: 0x04000C59 RID: 3161
		MaximumPossibleValue = 32767
	}
}
