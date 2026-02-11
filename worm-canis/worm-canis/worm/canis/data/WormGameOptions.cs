using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace worm.canis.data
{
	// Token: 0x02000043 RID: 67
	public static class WormGameOptions : Object
	{
		// Token: 0x060007D7 RID: 2007 RVA: 0x00083B44 File Offset: 0x00081D44
		// Note: this type is marked as 'beforefieldinit'.
		static WormGameOptions()
		{
			Il2CppClassPointerStore<WormGameOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data", "WormGameOptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGameOptions>.NativeClassPtr);
			WormGameOptions.NativeFieldInfoPtr_LeaderAssignmentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameOptions>.NativeClassPtr, "LeaderAssignmentMode");
			WormGameOptions.NativeFieldInfoPtr_PlayerColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameOptions>.NativeClassPtr, "PlayerColor");
			WormGameOptions.NativeFieldInfoPtr_IsTwoPlayerHagal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameOptions>.NativeClassPtr, "IsTwoPlayerHagal");
			WormGameOptions.NativeFieldInfoPtr_IsEpicGamemode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameOptions>.NativeClassPtr, "IsEpicGamemode");
			WormGameOptions.NativeFieldInfoPtr_IsRiseOfIx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameOptions>.NativeClassPtr, "IsRiseOfIx");
			WormGameOptions.NativeFieldInfoPtr_IsImmortality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameOptions>.NativeClassPtr, "IsImmortality");
			WormGameOptions.NativeFieldInfoPtr_MinReputation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameOptions>.NativeClassPtr, "MinReputation");
			WormGameOptions.NativeFieldInfoPtr_GoTo11Gamemode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameOptions>.NativeClassPtr, "GoTo11Gamemode");
			WormGameOptions.NativeFieldInfoPtr_Sets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGameOptions>.NativeClassPtr, "Sets");
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0000560C File Offset: 0x0000380C
		public WormGameOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x00083C28 File Offset: 0x00081E28
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x00005615 File Offset: 0x00003815
		public unsafe static string LeaderAssignmentMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameOptions.NativeFieldInfoPtr_LeaderAssignmentMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameOptions.NativeFieldInfoPtr_LeaderAssignmentMode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x00083C48 File Offset: 0x00081E48
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x00005627 File Offset: 0x00003827
		public unsafe static string PlayerColor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameOptions.NativeFieldInfoPtr_PlayerColor, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameOptions.NativeFieldInfoPtr_PlayerColor, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x00083C68 File Offset: 0x00081E68
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x00005639 File Offset: 0x00003839
		public unsafe static string IsTwoPlayerHagal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameOptions.NativeFieldInfoPtr_IsTwoPlayerHagal, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameOptions.NativeFieldInfoPtr_IsTwoPlayerHagal, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00083C88 File Offset: 0x00081E88
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x0000564B File Offset: 0x0000384B
		public unsafe static string IsEpicGamemode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameOptions.NativeFieldInfoPtr_IsEpicGamemode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameOptions.NativeFieldInfoPtr_IsEpicGamemode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00083CA8 File Offset: 0x00081EA8
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x0000565D File Offset: 0x0000385D
		public unsafe static string IsRiseOfIx
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameOptions.NativeFieldInfoPtr_IsRiseOfIx, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameOptions.NativeFieldInfoPtr_IsRiseOfIx, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00083CC8 File Offset: 0x00081EC8
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x0000566F File Offset: 0x0000386F
		public unsafe static string IsImmortality
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameOptions.NativeFieldInfoPtr_IsImmortality, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameOptions.NativeFieldInfoPtr_IsImmortality, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00083CE8 File Offset: 0x00081EE8
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00005681 File Offset: 0x00003881
		public unsafe static string MinReputation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameOptions.NativeFieldInfoPtr_MinReputation, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameOptions.NativeFieldInfoPtr_MinReputation, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00083D08 File Offset: 0x00081F08
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00005693 File Offset: 0x00003893
		public unsafe static string GoTo11Gamemode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameOptions.NativeFieldInfoPtr_GoTo11Gamemode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameOptions.NativeFieldInfoPtr_GoTo11Gamemode, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00083D28 File Offset: 0x00081F28
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x000056A5 File Offset: 0x000038A5
		public unsafe static string Sets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormGameOptions.NativeFieldInfoPtr_Sets, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormGameOptions.NativeFieldInfoPtr_Sets, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeFieldInfoPtr_LeaderAssignmentMode;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeFieldInfoPtr_PlayerColor;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeFieldInfoPtr_IsTwoPlayerHagal;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeFieldInfoPtr_IsEpicGamemode;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeFieldInfoPtr_IsRiseOfIx;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeFieldInfoPtr_IsImmortality;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeFieldInfoPtr_MinReputation;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeFieldInfoPtr_GoTo11Gamemode;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeFieldInfoPtr_Sets;
	}
}
