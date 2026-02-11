using System;
using boardgames.menus.prompts;
using dwd.canis.dbg_client.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.canis.dbg_client.prompts.behaviours
{
	// Token: 0x02000071 RID: 113
	public class FriendsWinnerMatchStatsFilterToggle : MonoBehaviour
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x0002ABC8 File Offset: 0x00028DC8
		// Note: this type is marked as 'beforefieldinit'.
		static FriendsWinnerMatchStatsFilterToggle()
		{
			Il2CppClassPointerStore<FriendsWinnerMatchStatsFilterToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.prompts.behaviours", "FriendsWinnerMatchStatsFilterToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendsWinnerMatchStatsFilterToggle>.NativeClassPtr);
			FriendsWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsWinnerMatchStatsFilterToggle>.NativeClassPtr, "filter");
			FriendsWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_statsBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsWinnerMatchStatsFilterToggle>.NativeClassPtr, "statsBehaviour");
			FriendsWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_filterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendsWinnerMatchStatsFilterToggle>.NativeClassPtr, "filterType");
			FriendsWinnerMatchStatsFilterToggle.NativeMethodInfoPtr_ToggleActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsWinnerMatchStatsFilterToggle>.NativeClassPtr, 100663928);
			FriendsWinnerMatchStatsFilterToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendsWinnerMatchStatsFilterToggle>.NativeClassPtr, 100663929);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0002AC5C File Offset: 0x00028E5C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsWinnerMatchStatsFilterToggle.NativeMethodInfoPtr_ToggleActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0002AC9C File Offset: 0x00028E9C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendsWinnerMatchStatsFilterToggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendsWinnerMatchStatsFilterToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendsWinnerMatchStatsFilterToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00003E86 File Offset: 0x00002086
		public FriendsWinnerMatchStatsFilterToggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0002ACD8 File Offset: 0x00028ED8
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00003E8F File Offset: 0x0000208F
		public unsafe FriendsWinnerStatsFilter filter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_filter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendsWinnerStatsFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_filter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0002AD08 File Offset: 0x00028F08
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00003EAE File Offset: 0x000020AE
		public unsafe MatchStatsBehaviour statsBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_statsBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchStatsBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_statsBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0002AD38 File Offset: 0x00028F38
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00003ECD File Offset: 0x000020CD
		public unsafe MatchStatsFilterType filterType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_filterType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendsWinnerMatchStatsFilterToggle.NativeFieldInfoPtr_filterType)) = value;
			}
		}

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr_filter;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_statsBehaviour;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_filterType;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_ToggleActive_Public_Void_Boolean_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
