using System;
using boardgames.menus.prompts;
using dwd.canis.dbg_client.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.canis.dbg_client.prompts.behaviours
{
	// Token: 0x02000072 RID: 114
	public class OwnerWinnerMatchStatsFilterToggle : MonoBehaviour
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x0002AD60 File Offset: 0x00028F60
		// Note: this type is marked as 'beforefieldinit'.
		static OwnerWinnerMatchStatsFilterToggle()
		{
			Il2CppClassPointerStore<OwnerWinnerMatchStatsFilterToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.prompts.behaviours", "OwnerWinnerMatchStatsFilterToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OwnerWinnerMatchStatsFilterToggle>.NativeClassPtr);
			OwnerWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OwnerWinnerMatchStatsFilterToggle>.NativeClassPtr, "filter");
			OwnerWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_statsBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OwnerWinnerMatchStatsFilterToggle>.NativeClassPtr, "statsBehaviour");
			OwnerWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_filterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OwnerWinnerMatchStatsFilterToggle>.NativeClassPtr, "filterType");
			OwnerWinnerMatchStatsFilterToggle.NativeMethodInfoPtr_ToggleActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnerWinnerMatchStatsFilterToggle>.NativeClassPtr, 100663930);
			OwnerWinnerMatchStatsFilterToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OwnerWinnerMatchStatsFilterToggle>.NativeClassPtr, 100663931);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0002ADF4 File Offset: 0x00028FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnerWinnerMatchStatsFilterToggle.NativeMethodInfoPtr_ToggleActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0002AE34 File Offset: 0x00029034
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OwnerWinnerMatchStatsFilterToggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OwnerWinnerMatchStatsFilterToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OwnerWinnerMatchStatsFilterToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00003EE8 File Offset: 0x000020E8
		public OwnerWinnerMatchStatsFilterToggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0002AE70 File Offset: 0x00029070
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x00003EF1 File Offset: 0x000020F1
		public unsafe OwnerWinnerStatsFilter filter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnerWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_filter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OwnerWinnerStatsFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnerWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_filter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0002AEA0 File Offset: 0x000290A0
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00003F10 File Offset: 0x00002110
		public unsafe MatchStatsBehaviour statsBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnerWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_statsBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchStatsBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnerWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_statsBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0002AED0 File Offset: 0x000290D0
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00003F2F File Offset: 0x0000212F
		public unsafe MatchStatsFilterType filterType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnerWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_filterType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OwnerWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_filterType)) = value;
			}
		}

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_filter;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr_statsBehaviour;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeFieldInfoPtr_filterType;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_ToggleActive_Public_Void_Boolean_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
