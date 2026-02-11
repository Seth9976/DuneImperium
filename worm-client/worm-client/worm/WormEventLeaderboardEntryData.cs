using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.networking.responses;

namespace worm
{
	// Token: 0x0200004E RID: 78
	public class WormEventLeaderboardEntryData : DataComponent
	{
		// Token: 0x0600033F RID: 831 RVA: 0x00022DF8 File Offset: 0x00020FF8
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventLeaderboardEntryData()
		{
			Il2CppClassPointerStore<WormEventLeaderboardEntryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormEventLeaderboardEntryData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventLeaderboardEntryData>.NativeClassPtr);
			WormEventLeaderboardEntryData.NativeFieldInfoPtr__Entry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventLeaderboardEntryData>.NativeClassPtr, "<Entry>k__BackingField");
			WormEventLeaderboardEntryData.NativeMethodInfoPtr__ctor_Public_Void_EventLeaderboardEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardEntryData>.NativeClassPtr, 100663815);
			WormEventLeaderboardEntryData.NativeMethodInfoPtr_get_Entry_Public_get_EventLeaderboardEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventLeaderboardEntryData>.NativeClassPtr, 100663816);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00022E64 File Offset: 0x00021064
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventLeaderboardEntryData(EventLeaderboardEntry entry)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventLeaderboardEntryData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLeaderboardEntryData.NativeMethodInfoPtr__ctor_Public_Void_EventLeaderboardEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00022EB0 File Offset: 0x000210B0
		public unsafe EventLeaderboardEntry Entry
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventLeaderboardEntryData.NativeMethodInfoPtr_get_Entry_Public_get_EventLeaderboardEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventLeaderboardEntry>(intPtr3) : null;
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000037F1 File Offset: 0x000019F1
		public WormEventLeaderboardEntryData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00022EF0 File Offset: 0x000210F0
		// (set) Token: 0x06000344 RID: 836 RVA: 0x000037FA File Offset: 0x000019FA
		public unsafe EventLeaderboardEntry _Entry_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardEntryData.NativeFieldInfoPtr__Entry_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventLeaderboardEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventLeaderboardEntryData.NativeFieldInfoPtr__Entry_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeFieldInfoPtr__Entry_k__BackingField;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventLeaderboardEntry_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_get_EventLeaderboardEntry_0;
	}
}
