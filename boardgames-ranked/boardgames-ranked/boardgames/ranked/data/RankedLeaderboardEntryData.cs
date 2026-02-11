using System;
using boardgames.ranked.networking.responses;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.ranked.data
{
	// Token: 0x02000032 RID: 50
	public class RankedLeaderboardEntryData : DataComponent
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x000086C8 File Offset: 0x000068C8
		// Note: this type is marked as 'beforefieldinit'.
		static RankedLeaderboardEntryData()
		{
			Il2CppClassPointerStore<RankedLeaderboardEntryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.data", "RankedLeaderboardEntryData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedLeaderboardEntryData>.NativeClassPtr);
			RankedLeaderboardEntryData.NativeFieldInfoPtr__Entry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardEntryData>.NativeClassPtr, "<Entry>k__BackingField");
			RankedLeaderboardEntryData.NativeMethodInfoPtr__ctor_Public_Void_RankedLeaderboardEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboardEntryData>.NativeClassPtr, 100663453);
			RankedLeaderboardEntryData.NativeMethodInfoPtr_get_Entry_Public_get_RankedLeaderboardEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboardEntryData>.NativeClassPtr, 100663454);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00008734 File Offset: 0x00006934
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedLeaderboardEntryData(RankedLeaderboardEntry entry)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedLeaderboardEntryData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedLeaderboardEntryData.NativeMethodInfoPtr__ctor_Public_Void_RankedLeaderboardEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00008780 File Offset: 0x00006980
		public unsafe RankedLeaderboardEntry Entry
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedLeaderboardEntryData.NativeMethodInfoPtr_get_Entry_Public_get_RankedLeaderboardEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RankedLeaderboardEntry>(intPtr3) : null;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00003049 File Offset: 0x00001249
		public RankedLeaderboardEntryData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x000087C0 File Offset: 0x000069C0
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00003052 File Offset: 0x00001252
		public unsafe RankedLeaderboardEntry _Entry_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntryData.NativeFieldInfoPtr__Entry_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedLeaderboardEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntryData.NativeFieldInfoPtr__Entry_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeFieldInfoPtr__Entry_k__BackingField;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RankedLeaderboardEntry_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_get_RankedLeaderboardEntry_0;
	}
}
