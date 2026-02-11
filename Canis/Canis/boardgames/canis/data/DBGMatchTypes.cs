using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.canis.data
{
	// Token: 0x0200000C RID: 12
	public class DBGMatchTypes : Object
	{
		// Token: 0x0600005C RID: 92 RVA: 0x0001AA4C File Offset: 0x00018C4C
		// Note: this type is marked as 'beforefieldinit'.
		static DBGMatchTypes()
		{
			Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "boardgames.canis.data", "DBGMatchTypes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr);
			DBGMatchTypes.NativeFieldInfoPtr_TutorialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr, "TutorialType");
			DBGMatchTypes.NativeFieldInfoPtr_AdvancedTutorialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr, "AdvancedTutorialType");
			DBGMatchTypes.NativeFieldInfoPtr_ChallengeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr, "ChallengeType");
			DBGMatchTypes.NativeFieldInfoPtr_SoloType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr, "SoloType");
			DBGMatchTypes.NativeFieldInfoPtr_PassAndPlayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr, "PassAndPlayType");
			DBGMatchTypes.NativeFieldInfoPtr_SimultaneousSoloType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr, "SimultaneousSoloType");
			DBGMatchTypes.NativeFieldInfoPtr_CasualType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr, "CasualType");
			DBGMatchTypes.NativeFieldInfoPtr_LiveType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr, "LiveType");
			DBGMatchTypes.NativeFieldInfoPtr_FriendType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr, "FriendType");
			DBGMatchTypes.NativeFieldInfoPtr_DailyChallengeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr, "DailyChallengeType");
			DBGMatchTypes.NativeFieldInfoPtr_SoloScenarioType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr, "SoloScenarioType");
			DBGMatchTypes.NativeFieldInfoPtr_ObserverType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr, "ObserverType");
			DBGMatchTypes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr, 100663312);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0001AB80 File Offset: 0x00018D80
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGMatchTypes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGMatchTypes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchTypes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000023AA File Offset: 0x000005AA
		public DBGMatchTypes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0001ABBC File Offset: 0x00018DBC
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000023B3 File Offset: 0x000005B3
		public unsafe static string TutorialType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchTypes.NativeFieldInfoPtr_TutorialType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchTypes.NativeFieldInfoPtr_TutorialType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0001ABDC File Offset: 0x00018DDC
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000023C5 File Offset: 0x000005C5
		public unsafe static string AdvancedTutorialType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchTypes.NativeFieldInfoPtr_AdvancedTutorialType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchTypes.NativeFieldInfoPtr_AdvancedTutorialType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0001ABFC File Offset: 0x00018DFC
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000023D7 File Offset: 0x000005D7
		public unsafe static string ChallengeType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchTypes.NativeFieldInfoPtr_ChallengeType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchTypes.NativeFieldInfoPtr_ChallengeType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0001AC1C File Offset: 0x00018E1C
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000023E9 File Offset: 0x000005E9
		public unsafe static string SoloType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchTypes.NativeFieldInfoPtr_SoloType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchTypes.NativeFieldInfoPtr_SoloType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0001AC3C File Offset: 0x00018E3C
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000023FB File Offset: 0x000005FB
		public unsafe static string PassAndPlayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchTypes.NativeFieldInfoPtr_PassAndPlayType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchTypes.NativeFieldInfoPtr_PassAndPlayType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0001AC5C File Offset: 0x00018E5C
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000240D File Offset: 0x0000060D
		public unsafe static string SimultaneousSoloType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchTypes.NativeFieldInfoPtr_SimultaneousSoloType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchTypes.NativeFieldInfoPtr_SimultaneousSoloType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0001AC7C File Offset: 0x00018E7C
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000241F File Offset: 0x0000061F
		public unsafe static string CasualType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchTypes.NativeFieldInfoPtr_CasualType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchTypes.NativeFieldInfoPtr_CasualType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0001AC9C File Offset: 0x00018E9C
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002431 File Offset: 0x00000631
		public unsafe static string LiveType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchTypes.NativeFieldInfoPtr_LiveType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchTypes.NativeFieldInfoPtr_LiveType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0001ACBC File Offset: 0x00018EBC
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002443 File Offset: 0x00000643
		public unsafe static string FriendType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchTypes.NativeFieldInfoPtr_FriendType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchTypes.NativeFieldInfoPtr_FriendType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0001ACDC File Offset: 0x00018EDC
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002455 File Offset: 0x00000655
		public unsafe static string DailyChallengeType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchTypes.NativeFieldInfoPtr_DailyChallengeType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchTypes.NativeFieldInfoPtr_DailyChallengeType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0001ACFC File Offset: 0x00018EFC
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002467 File Offset: 0x00000667
		public unsafe static string SoloScenarioType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchTypes.NativeFieldInfoPtr_SoloScenarioType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchTypes.NativeFieldInfoPtr_SoloScenarioType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0001AD1C File Offset: 0x00018F1C
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002479 File Offset: 0x00000679
		public unsafe static string ObserverType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DBGMatchTypes.NativeFieldInfoPtr_ObserverType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DBGMatchTypes.NativeFieldInfoPtr_ObserverType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_TutorialType;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr_AdvancedTutorialType;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_ChallengeType;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_SoloType;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_PassAndPlayType;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr_SimultaneousSoloType;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_CasualType;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_LiveType;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_FriendType;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_DailyChallengeType;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_SoloScenarioType;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_ObserverType;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
