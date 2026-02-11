using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.canis.lib.canis.dbg_client.moz
{
	// Token: 0x02000053 RID: 83
	public class DropdownItemTooltipSource : MonoBehaviour
	{
		// Token: 0x06000339 RID: 825 RVA: 0x00027D6C File Offset: 0x00025F6C
		// Note: this type is marked as 'beforefieldinit'.
		static DropdownItemTooltipSource()
		{
			Il2CppClassPointerStore<DropdownItemTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.moz", "DropdownItemTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropdownItemTooltipSource>.NativeClassPtr);
			DropdownItemTooltipSource.NativeFieldInfoPtr_tooltipLocs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropdownItemTooltipSource>.NativeClassPtr, "tooltipLocs");
			DropdownItemTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownItemTooltipSource>.NativeClassPtr, 100663811);
			DropdownItemTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropdownItemTooltipSource>.NativeClassPtr, 100663812);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00027DD8 File Offset: 0x00025FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499612, XrefRangeEnd = 499634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownItemTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00027E10 File Offset: 0x00026010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499634, XrefRangeEnd = 499642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DropdownItemTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropdownItemTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DropdownItemTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000369A File Offset: 0x0000189A
		public DropdownItemTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00027E4C File Offset: 0x0002604C
		// (set) Token: 0x0600033E RID: 830 RVA: 0x000036A3 File Offset: 0x000018A3
		public unsafe List<string> tooltipLocs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownItemTooltipSource.NativeFieldInfoPtr_tooltipLocs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DropdownItemTooltipSource.NativeFieldInfoPtr_tooltipLocs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeFieldInfoPtr_tooltipLocs;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
