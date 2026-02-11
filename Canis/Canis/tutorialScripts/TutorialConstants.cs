using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.tutorialScripts
{
	// Token: 0x0200003E RID: 62
	public static class TutorialConstants : Object
	{
		// Token: 0x060003BE RID: 958 RVA: 0x000289F8 File Offset: 0x00026BF8
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialConstants()
		{
			Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.tutorialScripts", "TutorialConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr);
			TutorialConstants.NativeFieldInfoPtr_Dialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "Dialog");
			TutorialConstants.NativeFieldInfoPtr_VisualHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "VisualHighlight");
			TutorialConstants.NativeFieldInfoPtr_TutorialFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "TutorialFocus");
			TutorialConstants.NativeFieldInfoPtr_HideTutorialAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "HideTutorialAction");
			TutorialConstants.NativeFieldInfoPtr_CallToAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "CallToAction");
			TutorialConstants.NativeFieldInfoPtr_ShowHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "ShowHint");
			TutorialConstants.NativeFieldInfoPtr_MoveCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "MoveCamera");
			TutorialConstants.NativeFieldInfoPtr_InvokeTutorialEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "InvokeTutorialEvent");
			TutorialConstants.NativeFieldInfoPtr_EndOfTutorialChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "EndOfTutorialChoice");
			TutorialConstants.NativeFieldInfoPtr_ClickToContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "ClickToContinue");
			TutorialConstants.NativeFieldInfoPtr_Persistent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "Persistent");
			TutorialConstants.NativeFieldInfoPtr_Goals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "Goals");
			TutorialConstants.NativeFieldInfoPtr_MozEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "MozEntity");
			TutorialConstants.NativeFieldInfoPtr_SelectEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "SelectEntity");
			TutorialConstants.NativeFieldInfoPtr_SelectWithLayerEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "SelectWithLayerEntity");
			TutorialConstants.NativeFieldInfoPtr_StopEntityMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "StopEntityMoz");
			TutorialConstants.NativeFieldInfoPtr_ApplyHideForTutorialAnimationParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "ApplyHideForTutorialAnimationParam");
			TutorialConstants.NativeFieldInfoPtr_FirstLiveGameFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "FirstLiveGameFTT");
			TutorialConstants.NativeFieldInfoPtr_CheckForFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "CheckForFTT");
			TutorialConstants.NativeFieldInfoPtr_CheckForPrerequisite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "CheckForPrerequisite");
			TutorialConstants.NativeFieldInfoPtr_AcknowledgeFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialConstants>.NativeClassPtr, "AcknowledgeFTT");
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00003987 File Offset: 0x00001B87
		public TutorialConstants(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00028BCC File Offset: 0x00026DCC
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00003990 File Offset: 0x00001B90
		public unsafe static string Dialog
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_Dialog, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_Dialog, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00028BEC File Offset: 0x00026DEC
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x000039A2 File Offset: 0x00001BA2
		public unsafe static string VisualHighlight
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_VisualHighlight, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_VisualHighlight, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00028C0C File Offset: 0x00026E0C
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000039B4 File Offset: 0x00001BB4
		public unsafe static string TutorialFocus
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_TutorialFocus, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_TutorialFocus, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00028C2C File Offset: 0x00026E2C
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x000039C6 File Offset: 0x00001BC6
		public unsafe static string HideTutorialAction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_HideTutorialAction, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_HideTutorialAction, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00028C4C File Offset: 0x00026E4C
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x000039D8 File Offset: 0x00001BD8
		public unsafe static string CallToAction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_CallToAction, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_CallToAction, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00028C6C File Offset: 0x00026E6C
		// (set) Token: 0x060003CB RID: 971 RVA: 0x000039EA File Offset: 0x00001BEA
		public unsafe static string ShowHint
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_ShowHint, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_ShowHint, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00028C8C File Offset: 0x00026E8C
		// (set) Token: 0x060003CD RID: 973 RVA: 0x000039FC File Offset: 0x00001BFC
		public unsafe static string MoveCamera
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_MoveCamera, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_MoveCamera, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00028CAC File Offset: 0x00026EAC
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00003A0E File Offset: 0x00001C0E
		public unsafe static string InvokeTutorialEvent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_InvokeTutorialEvent, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_InvokeTutorialEvent, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00028CCC File Offset: 0x00026ECC
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00003A20 File Offset: 0x00001C20
		public unsafe static string EndOfTutorialChoice
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_EndOfTutorialChoice, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_EndOfTutorialChoice, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00028CEC File Offset: 0x00026EEC
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00003A32 File Offset: 0x00001C32
		public unsafe static string ClickToContinue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_ClickToContinue, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_ClickToContinue, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00028D0C File Offset: 0x00026F0C
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00003A44 File Offset: 0x00001C44
		public unsafe static string Persistent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_Persistent, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_Persistent, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00028D2C File Offset: 0x00026F2C
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00003A56 File Offset: 0x00001C56
		public unsafe static string Goals
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_Goals, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_Goals, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00028D4C File Offset: 0x00026F4C
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00003A68 File Offset: 0x00001C68
		public unsafe static string MozEntity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_MozEntity, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_MozEntity, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00028D6C File Offset: 0x00026F6C
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00003A7A File Offset: 0x00001C7A
		public unsafe static string SelectEntity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_SelectEntity, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_SelectEntity, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00028D8C File Offset: 0x00026F8C
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00003A8C File Offset: 0x00001C8C
		public unsafe static string SelectWithLayerEntity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_SelectWithLayerEntity, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_SelectWithLayerEntity, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00028DAC File Offset: 0x00026FAC
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00003A9E File Offset: 0x00001C9E
		public unsafe static string StopEntityMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_StopEntityMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_StopEntityMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x00028DCC File Offset: 0x00026FCC
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00003AB0 File Offset: 0x00001CB0
		public unsafe static string ApplyHideForTutorialAnimationParam
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_ApplyHideForTutorialAnimationParam, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_ApplyHideForTutorialAnimationParam, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00028DEC File Offset: 0x00026FEC
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00003AC2 File Offset: 0x00001CC2
		public unsafe static string FirstLiveGameFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_FirstLiveGameFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_FirstLiveGameFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00028E0C File Offset: 0x0002700C
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00003AD4 File Offset: 0x00001CD4
		public unsafe static string CheckForFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_CheckForFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_CheckForFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00028E2C File Offset: 0x0002702C
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00003AE6 File Offset: 0x00001CE6
		public unsafe static string CheckForPrerequisite
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_CheckForPrerequisite, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_CheckForPrerequisite, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00028E4C File Offset: 0x0002704C
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00003AF8 File Offset: 0x00001CF8
		public unsafe static string AcknowledgeFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TutorialConstants.NativeFieldInfoPtr_AcknowledgeFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TutorialConstants.NativeFieldInfoPtr_AcknowledgeFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_Dialog;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr_VisualHighlight;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr_TutorialFocus;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeFieldInfoPtr_HideTutorialAction;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr_CallToAction;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr_ShowHint;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr_MoveCamera;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr_InvokeTutorialEvent;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_EndOfTutorialChoice;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_ClickToContinue;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr_Persistent;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr_Goals;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_MozEntity;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_SelectEntity;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr_SelectWithLayerEntity;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr_StopEntityMoz;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_ApplyHideForTutorialAnimationParam;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr_FirstLiveGameFTT;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr_CheckForFTT;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr_CheckForPrerequisite;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr_AcknowledgeFTT;
	}
}
