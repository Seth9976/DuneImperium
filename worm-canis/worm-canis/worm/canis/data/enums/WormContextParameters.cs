using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace worm.canis.data.enums
{
	// Token: 0x020000DE RID: 222
	public static class WormContextParameters : Object
	{
		// Token: 0x06000F62 RID: 3938 RVA: 0x00099F88 File Offset: 0x00098188
		// Note: this type is marked as 'beforefieldinit'.
		static WormContextParameters()
		{
			Il2CppClassPointerStore<WormContextParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.enums", "WormContextParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormContextParameters>.NativeClassPtr);
			WormContextParameters.NativeFieldInfoPtr_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextParameters>.NativeClassPtr, "Faction");
			WormContextParameters.NativeFieldInfoPtr_ToArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextParameters>.NativeClassPtr, "ToArea");
			WormContextParameters.NativeFieldInfoPtr_TrashEntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextParameters>.NativeClassPtr, "TrashEntityID");
			WormContextParameters.NativeFieldInfoPtr_AgentCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextParameters>.NativeClassPtr, "AgentCard");
			WormContextParameters.NativeFieldInfoPtr_ChosenSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextParameters>.NativeClassPtr, "ChosenSpace");
			WormContextParameters.NativeFieldInfoPtr_Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextParameters>.NativeClassPtr, "Cards");
			WormContextParameters.NativeFieldInfoPtr_Units = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextParameters>.NativeClassPtr, "Units");
			WormContextParameters.NativeFieldInfoPtr_TechTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextParameters>.NativeClassPtr, "TechTile");
			WormContextParameters.NativeFieldInfoPtr_GraftedCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextParameters>.NativeClassPtr, "GraftedCard");
			WormContextParameters.NativeFieldInfoPtr_WormAgent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormContextParameters>.NativeClassPtr, "WormAgent");
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00008299 File Offset: 0x00006499
		public WormContextParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06000F64 RID: 3940 RVA: 0x0009A080 File Offset: 0x00098280
		// (set) Token: 0x06000F65 RID: 3941 RVA: 0x000082A2 File Offset: 0x000064A2
		public unsafe static string Faction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormContextParameters.NativeFieldInfoPtr_Faction, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormContextParameters.NativeFieldInfoPtr_Faction, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x0009A0A0 File Offset: 0x000982A0
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x000082B4 File Offset: 0x000064B4
		public unsafe static string ToArea
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormContextParameters.NativeFieldInfoPtr_ToArea, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormContextParameters.NativeFieldInfoPtr_ToArea, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0009A0C0 File Offset: 0x000982C0
		// (set) Token: 0x06000F69 RID: 3945 RVA: 0x000082C6 File Offset: 0x000064C6
		public unsafe static string TrashEntityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormContextParameters.NativeFieldInfoPtr_TrashEntityID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormContextParameters.NativeFieldInfoPtr_TrashEntityID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x0009A0E0 File Offset: 0x000982E0
		// (set) Token: 0x06000F6B RID: 3947 RVA: 0x000082D8 File Offset: 0x000064D8
		public unsafe static string AgentCard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormContextParameters.NativeFieldInfoPtr_AgentCard, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormContextParameters.NativeFieldInfoPtr_AgentCard, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0009A100 File Offset: 0x00098300
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x000082EA File Offset: 0x000064EA
		public unsafe static string ChosenSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormContextParameters.NativeFieldInfoPtr_ChosenSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormContextParameters.NativeFieldInfoPtr_ChosenSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x0009A120 File Offset: 0x00098320
		// (set) Token: 0x06000F6F RID: 3951 RVA: 0x000082FC File Offset: 0x000064FC
		public unsafe static string Cards
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormContextParameters.NativeFieldInfoPtr_Cards, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormContextParameters.NativeFieldInfoPtr_Cards, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x0009A140 File Offset: 0x00098340
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0000830E File Offset: 0x0000650E
		public unsafe static string Units
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormContextParameters.NativeFieldInfoPtr_Units, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormContextParameters.NativeFieldInfoPtr_Units, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06000F72 RID: 3954 RVA: 0x0009A160 File Offset: 0x00098360
		// (set) Token: 0x06000F73 RID: 3955 RVA: 0x00008320 File Offset: 0x00006520
		public unsafe static string TechTile
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormContextParameters.NativeFieldInfoPtr_TechTile, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormContextParameters.NativeFieldInfoPtr_TechTile, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06000F74 RID: 3956 RVA: 0x0009A180 File Offset: 0x00098380
		// (set) Token: 0x06000F75 RID: 3957 RVA: 0x00008332 File Offset: 0x00006532
		public unsafe static string GraftedCard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormContextParameters.NativeFieldInfoPtr_GraftedCard, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormContextParameters.NativeFieldInfoPtr_GraftedCard, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x0009A1A0 File Offset: 0x000983A0
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x00008344 File Offset: 0x00006544
		public unsafe static string WormAgent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormContextParameters.NativeFieldInfoPtr_WormAgent, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormContextParameters.NativeFieldInfoPtr_WormAgent, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeFieldInfoPtr_Faction;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeFieldInfoPtr_ToArea;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr_TrashEntityID;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr_AgentCard;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeFieldInfoPtr_ChosenSpace;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeFieldInfoPtr_Cards;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeFieldInfoPtr_Units;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeFieldInfoPtr_TechTile;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeFieldInfoPtr_GraftedCard;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeFieldInfoPtr_WormAgent;
	}
}
