using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.data
{
	// Token: 0x02000185 RID: 389
	public class DBGMatchConfigData : VersionedDataComponent
	{
		// Token: 0x060010FB RID: 4347 RVA: 0x00053244 File Offset: 0x00051444
		// Note: this type is marked as 'beforefieldinit'.
		static DBGMatchConfigData()
		{
			Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "DBGMatchConfigData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr);
			DBGMatchConfigData.NativeFieldInfoPtr_turnTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr, "turnTimer");
			DBGMatchConfigData.NativeFieldInfoPtr_matchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr, "matchType");
			DBGMatchConfigData.NativeFieldInfoPtr_aiLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr, "aiLevel");
			DBGMatchConfigData.NativeMethodInfoPtr_get_TurnTimer_Public_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr, 100665664);
			DBGMatchConfigData.NativeMethodInfoPtr_set_TurnTimer_Public_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr, 100665665);
			DBGMatchConfigData.NativeMethodInfoPtr_get_MatchType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr, 100665666);
			DBGMatchConfigData.NativeMethodInfoPtr_set_MatchType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr, 100665667);
			DBGMatchConfigData.NativeMethodInfoPtr_get_AILevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr, 100665668);
			DBGMatchConfigData.NativeMethodInfoPtr_set_AILevel_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr, 100665669);
			DBGMatchConfigData.NativeMethodInfoPtr_get_TimerDisplayString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr, 100665670);
			DBGMatchConfigData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr, 100665671);
			DBGMatchConfigData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr, 100665672);
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x00053364 File Offset: 0x00051564
		// (set) Token: 0x060010FD RID: 4349 RVA: 0x000533A0 File Offset: 0x000515A0
		public unsafe TimeSpan TurnTimer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchConfigData.NativeMethodInfoPtr_get_TurnTimer_Public_get_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 514351, RefRangeEnd = 514353, XrefRangeStart = 514350, XrefRangeEnd = 514351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchConfigData.NativeMethodInfoPtr_set_TurnTimer_Public_set_Void_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x000533E0 File Offset: 0x000515E0
		// (set) Token: 0x060010FF RID: 4351 RVA: 0x00053418 File Offset: 0x00051618
		public unsafe string MatchType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchConfigData.NativeMethodInfoPtr_get_MatchType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 514355, RefRangeEnd = 514362, XrefRangeStart = 514353, XrefRangeEnd = 514355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchConfigData.NativeMethodInfoPtr_set_MatchType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x0005345C File Offset: 0x0005165C
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x00053498 File Offset: 0x00051698
		public unsafe int AILevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchConfigData.NativeMethodInfoPtr_get_AILevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 514363, RefRangeEnd = 514365, XrefRangeStart = 514362, XrefRangeEnd = 514363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchConfigData.NativeMethodInfoPtr_set_AILevel_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x000534D8 File Offset: 0x000516D8
		public unsafe string TimerDisplayString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 514366, RefRangeEnd = 514367, XrefRangeStart = 514365, XrefRangeEnd = 514366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchConfigData.NativeMethodInfoPtr_get_TimerDisplayString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00053510 File Offset: 0x00051710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514367, XrefRangeEnd = 514390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGMatchConfigData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00053554 File Offset: 0x00051754
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 499944, RefRangeEnd = 499953, XrefRangeStart = 499944, XrefRangeEnd = 499953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGMatchConfigData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGMatchConfigData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGMatchConfigData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0000A31F File Offset: 0x0000851F
		public DBGMatchConfigData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x00053590 File Offset: 0x00051790
		// (set) Token: 0x06001107 RID: 4359 RVA: 0x0000A328 File Offset: 0x00008528
		public unsafe TimeSpan turnTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchConfigData.NativeFieldInfoPtr_turnTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchConfigData.NativeFieldInfoPtr_turnTimer)) = value;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x000535B8 File Offset: 0x000517B8
		// (set) Token: 0x06001109 RID: 4361 RVA: 0x0000A343 File Offset: 0x00008543
		public unsafe string matchType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchConfigData.NativeFieldInfoPtr_matchType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchConfigData.NativeFieldInfoPtr_matchType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x000535E0 File Offset: 0x000517E0
		// (set) Token: 0x0600110B RID: 4363 RVA: 0x0000A362 File Offset: 0x00008562
		public unsafe int aiLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchConfigData.NativeFieldInfoPtr_aiLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGMatchConfigData.NativeFieldInfoPtr_aiLevel)) = value;
			}
		}

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeFieldInfoPtr_turnTimer;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeFieldInfoPtr_matchType;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeFieldInfoPtr_aiLevel;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_get_TurnTimer_Public_get_TimeSpan_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_set_TurnTimer_Public_set_Void_TimeSpan_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchType_Public_get_String_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchType_Public_set_Void_String_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_get_AILevel_Public_get_Int32_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_set_AILevel_Public_set_Void_Int32_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_get_TimerDisplayString_Public_get_String_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
