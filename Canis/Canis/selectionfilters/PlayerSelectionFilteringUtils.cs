using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.selectionfilters
{
	// Token: 0x02000054 RID: 84
	public static class PlayerSelectionFilteringUtils : Object
	{
		// Token: 0x06000513 RID: 1299 RVA: 0x00004369 File Offset: 0x00002569
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSelectionFilteringUtils()
		{
			Il2CppClassPointerStore<PlayerSelectionFilteringUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.selectionfilters", "PlayerSelectionFilteringUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSelectionFilteringUtils>.NativeClassPtr);
			PlayerSelectionFilteringUtils.NativeMethodInfoPtr_GetValidSelectionFilters_Public_Static_IEnumerable_1_SelectionFilter_IEnumerable_1_SelectionFilter_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilteringUtils>.NativeClassPtr, 100664341);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0002D248 File Offset: 0x0002B448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 554420, RefRangeEnd = 554422, XrefRangeStart = 554405, XrefRangeEnd = 554420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<SelectionFilter> GetValidSelectionFilters(this IEnumerable<SelectionFilter> filters, NetworkMessageEvent evt)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilteringUtils.NativeMethodInfoPtr_GetValidSelectionFilters_Public_Static_IEnumerable_1_SelectionFilter_IEnumerable_1_SelectionFilter_NetworkMessageEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SelectionFilter>>(intPtr3) : null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000043A2 File Offset: 0x000025A2
		public PlayerSelectionFilteringUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_GetValidSelectionFilters_Public_Static_IEnumerable_1_SelectionFilter_IEnumerable_1_SelectionFilter_NetworkMessageEvent_0;

		// Token: 0x020002AA RID: 682
		[ObfuscatedName("Canis.selectionfilters.PlayerSelectionFilteringUtils+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x06001D02 RID: 7426 RVA: 0x00089140 File Offset: 0x00087340
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<PlayerSelectionFilteringUtils.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSelectionFilteringUtils>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSelectionFilteringUtils.__c__DisplayClass0_0>.NativeClassPtr);
				PlayerSelectionFilteringUtils.__c__DisplayClass0_0.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSelectionFilteringUtils.__c__DisplayClass0_0>.NativeClassPtr, "evt");
				PlayerSelectionFilteringUtils.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilteringUtils.__c__DisplayClass0_0>.NativeClassPtr, 100664342);
				PlayerSelectionFilteringUtils.__c__DisplayClass0_0.NativeMethodInfoPtr__GetValidSelectionFilters_b__0_Internal_Boolean_SelectionFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSelectionFilteringUtils.__c__DisplayClass0_0>.NativeClassPtr, 100664343);
			}

			// Token: 0x06001D03 RID: 7427 RVA: 0x000891A8 File Offset: 0x000873A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSelectionFilteringUtils.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilteringUtils.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D04 RID: 7428 RVA: 0x000891E4 File Offset: 0x000873E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetValidSelectionFilters_b__0(SelectionFilter filter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSelectionFilteringUtils.__c__DisplayClass0_0.NativeMethodInfoPtr__GetValidSelectionFilters_b__0_Internal_Boolean_SelectionFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D05 RID: 7429 RVA: 0x0000DE26 File Offset: 0x0000C026
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006C2 RID: 1730
			// (get) Token: 0x06001D06 RID: 7430 RVA: 0x00089234 File Offset: 0x00087434
			// (set) Token: 0x06001D07 RID: 7431 RVA: 0x0000DE2F File Offset: 0x0000C02F
			public unsafe NetworkMessageEvent evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilteringUtils.__c__DisplayClass0_0.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSelectionFilteringUtils.__c__DisplayClass0_0.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400127A RID: 4730
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x0400127B RID: 4731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400127C RID: 4732
			private static readonly IntPtr NativeMethodInfoPtr__GetValidSelectionFilters_b__0_Internal_Boolean_SelectionFilter_0;
		}
	}
}
