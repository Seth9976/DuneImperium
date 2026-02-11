using System;
using boardgames.menus.prompts;
using dbgclient.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.canis
{
	// Token: 0x0200004D RID: 77
	public class MatchStatsFilterToggle : MonoBehaviour
	{
		// Token: 0x060002EE RID: 750 RVA: 0x00026C68 File Offset: 0x00024E68
		// Note: this type is marked as 'beforefieldinit'.
		static MatchStatsFilterToggle()
		{
			Il2CppClassPointerStore<MatchStatsFilterToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis", "MatchStatsFilterToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchStatsFilterToggle>.NativeClassPtr);
			MatchStatsFilterToggle.NativeFieldInfoPtr_filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsFilterToggle>.NativeClassPtr, "filter");
			MatchStatsFilterToggle.NativeFieldInfoPtr_statsBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsFilterToggle>.NativeClassPtr, "statsBehaviour");
			MatchStatsFilterToggle.NativeFieldInfoPtr_filterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchStatsFilterToggle>.NativeClassPtr, "filterType");
			MatchStatsFilterToggle.NativeMethodInfoPtr_ToggleActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsFilterToggle>.NativeClassPtr, 100663769);
			MatchStatsFilterToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchStatsFilterToggle>.NativeClassPtr, 100663770);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00026CFC File Offset: 0x00024EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499308, XrefRangeEnd = 499311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsFilterToggle.NativeMethodInfoPtr_ToggleActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00026D3C File Offset: 0x00024F3C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchStatsFilterToggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchStatsFilterToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchStatsFilterToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000034C6 File Offset: 0x000016C6
		public MatchStatsFilterToggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00026D78 File Offset: 0x00024F78
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x000034CF File Offset: 0x000016CF
		public unsafe StatsFilter filter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsFilterToggle.NativeFieldInfoPtr_filter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StatsFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsFilterToggle.NativeFieldInfoPtr_filter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00026DA8 File Offset: 0x00024FA8
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x000034EE File Offset: 0x000016EE
		public unsafe MatchStatsBehaviour statsBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsFilterToggle.NativeFieldInfoPtr_statsBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchStatsBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsFilterToggle.NativeFieldInfoPtr_statsBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00026DD8 File Offset: 0x00024FD8
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x0000350D File Offset: 0x0000170D
		public unsafe MatchStatsFilterType filterType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsFilterToggle.NativeFieldInfoPtr_filterType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchStatsFilterToggle.NativeFieldInfoPtr_filterType)) = value;
			}
		}

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr_filter;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr_statsBehaviour;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr_filterType;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_ToggleActive_Public_Void_Boolean_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
