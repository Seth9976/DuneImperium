using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.diagnostics
{
	// Token: 0x020001BE RID: 446
	public class MemoryTracker : Object
	{
		// Token: 0x060018DD RID: 6365 RVA: 0x00076F20 File Offset: 0x00075120
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryTracker()
		{
			Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.diagnostics", "MemoryTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr);
			MemoryTracker.NativeFieldInfoPtr__CurrentMemoryUsage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, "<CurrentMemoryUsage>k__BackingField");
			MemoryTracker.NativeFieldInfoPtr__FreeMemory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, "<FreeMemory>k__BackingField");
			MemoryTracker.NativeFieldInfoPtr__MinMemoryUsage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, "<MinMemoryUsage>k__BackingField");
			MemoryTracker.NativeFieldInfoPtr__MaxMemoryUsage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, "<MaxMemoryUsage>k__BackingField");
			MemoryTracker.NativeFieldInfoPtr__ProfilerMemoryUsage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, "<ProfilerMemoryUsage>k__BackingField");
			MemoryTracker.NativeMethodInfoPtr_GetCurrentMemoryUsage_Public_Static_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667260);
			MemoryTracker.NativeMethodInfoPtr_GetFreeMemory_Private_Static_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667261);
			MemoryTracker.NativeMethodInfoPtr_get_CurrentMemoryUsage_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667262);
			MemoryTracker.NativeMethodInfoPtr_set_CurrentMemoryUsage_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667263);
			MemoryTracker.NativeMethodInfoPtr_get_FreeMemory_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667264);
			MemoryTracker.NativeMethodInfoPtr_set_FreeMemory_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667265);
			MemoryTracker.NativeMethodInfoPtr_get_MinMemoryUsage_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667266);
			MemoryTracker.NativeMethodInfoPtr_set_MinMemoryUsage_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667267);
			MemoryTracker.NativeMethodInfoPtr_get_MaxMemoryUsage_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667268);
			MemoryTracker.NativeMethodInfoPtr_set_MaxMemoryUsage_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667269);
			MemoryTracker.NativeMethodInfoPtr_get_ProfilerMemoryUsage_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667270);
			MemoryTracker.NativeMethodInfoPtr_set_ProfilerMemoryUsage_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667271);
			MemoryTracker.NativeMethodInfoPtr_UpdateMemory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667272);
			MemoryTracker.NativeMethodInfoPtr_GetCurrentProfilerMemoryUsage_Private_Static_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667273);
			MemoryTracker.NativeMethodInfoPtr_GetReportableMemoryUsage_Public_Static_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667274);
			MemoryTracker.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667275);
			MemoryTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr, 100667276);
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00077108 File Offset: 0x00075308
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 880750, RefRangeEnd = 880756, XrefRangeStart = 880749, XrefRangeEnd = 880750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong GetCurrentMemoryUsage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_GetCurrentMemoryUsage_Public_Static_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00077138 File Offset: 0x00075338
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong GetFreeMemory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_GetFreeMemory_Private_Static_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x00077168 File Offset: 0x00075368
		// (set) Token: 0x060018E1 RID: 6369 RVA: 0x000771A4 File Offset: 0x000753A4
		public unsafe ulong CurrentMemoryUsage
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_get_CurrentMemoryUsage_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_set_CurrentMemoryUsage_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x000771E4 File Offset: 0x000753E4
		// (set) Token: 0x060018E3 RID: 6371 RVA: 0x00077220 File Offset: 0x00075420
		public unsafe ulong FreeMemory
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_get_FreeMemory_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_set_FreeMemory_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x00077260 File Offset: 0x00075460
		// (set) Token: 0x060018E5 RID: 6373 RVA: 0x0007729C File Offset: 0x0007549C
		public unsafe ulong MinMemoryUsage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_get_MinMemoryUsage_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_set_MinMemoryUsage_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x000772DC File Offset: 0x000754DC
		// (set) Token: 0x060018E7 RID: 6375 RVA: 0x00077318 File Offset: 0x00075518
		public unsafe ulong MaxMemoryUsage
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_get_MaxMemoryUsage_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312312, RefRangeEnd = 312313, XrefRangeStart = 312312, XrefRangeEnd = 312313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_set_MaxMemoryUsage_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00077358 File Offset: 0x00075558
		// (set) Token: 0x060018E9 RID: 6377 RVA: 0x00077394 File Offset: 0x00075594
		public unsafe ulong ProfilerMemoryUsage
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_get_ProfilerMemoryUsage_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_set_ProfilerMemoryUsage_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x000773D4 File Offset: 0x000755D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880756, XrefRangeEnd = 880757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMemory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_UpdateMemory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00077408 File Offset: 0x00075608
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong GetCurrentProfilerMemoryUsage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_GetCurrentProfilerMemoryUsage_Private_Static_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00077438 File Offset: 0x00075638
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 880761, RefRangeEnd = 880763, XrefRangeStart = 880757, XrefRangeEnd = 880761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong GetReportableMemoryUsage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_GetReportableMemoryUsage_Public_Static_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x00077468 File Offset: 0x00075668
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0007749C File Offset: 0x0007569C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryTracker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryTracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0000AEC0 File Offset: 0x000090C0
		public MemoryTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x000774D8 File Offset: 0x000756D8
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x0000AEC9 File Offset: 0x000090C9
		public unsafe ulong _CurrentMemoryUsage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTracker.NativeFieldInfoPtr__CurrentMemoryUsage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTracker.NativeFieldInfoPtr__CurrentMemoryUsage_k__BackingField)) = value;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x00077500 File Offset: 0x00075700
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x0000AEE4 File Offset: 0x000090E4
		public unsafe ulong _FreeMemory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTracker.NativeFieldInfoPtr__FreeMemory_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTracker.NativeFieldInfoPtr__FreeMemory_k__BackingField)) = value;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x00077528 File Offset: 0x00075728
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x0000AEFF File Offset: 0x000090FF
		public unsafe ulong _MinMemoryUsage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTracker.NativeFieldInfoPtr__MinMemoryUsage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTracker.NativeFieldInfoPtr__MinMemoryUsage_k__BackingField)) = value;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x00077550 File Offset: 0x00075750
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x0000AF1A File Offset: 0x0000911A
		public unsafe ulong _MaxMemoryUsage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTracker.NativeFieldInfoPtr__MaxMemoryUsage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTracker.NativeFieldInfoPtr__MaxMemoryUsage_k__BackingField)) = value;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00077578 File Offset: 0x00075778
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x0000AF35 File Offset: 0x00009135
		public unsafe ulong _ProfilerMemoryUsage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTracker.NativeFieldInfoPtr__ProfilerMemoryUsage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemoryTracker.NativeFieldInfoPtr__ProfilerMemoryUsage_k__BackingField)) = value;
			}
		}

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeFieldInfoPtr__CurrentMemoryUsage_k__BackingField;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeFieldInfoPtr__FreeMemory_k__BackingField;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeFieldInfoPtr__MinMemoryUsage_k__BackingField;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeFieldInfoPtr__MaxMemoryUsage_k__BackingField;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeFieldInfoPtr__ProfilerMemoryUsage_k__BackingField;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentMemoryUsage_Public_Static_UInt64_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_GetFreeMemory_Private_Static_UInt64_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentMemoryUsage_Public_get_UInt64_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentMemoryUsage_Private_set_Void_UInt64_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_get_FreeMemory_Public_get_UInt64_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_set_FreeMemory_Private_set_Void_UInt64_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_get_MinMemoryUsage_Public_get_UInt64_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_set_MinMemoryUsage_Private_set_Void_UInt64_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxMemoryUsage_Public_get_UInt64_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxMemoryUsage_Private_set_Void_UInt64_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_get_ProfilerMemoryUsage_Public_get_UInt64_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_set_ProfilerMemoryUsage_Private_set_Void_UInt64_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMemory_Public_Void_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentProfilerMemoryUsage_Private_Static_UInt64_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_GetReportableMemoryUsage_Public_Static_UInt64_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
