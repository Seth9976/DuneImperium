using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace worm
{
	// Token: 0x0200004B RID: 75
	public class WormReputationTooltipSource : MonoBehaviour
	{
		// Token: 0x0600032C RID: 812 RVA: 0x00022A4C File Offset: 0x00020C4C
		// Note: this type is marked as 'beforefieldinit'.
		static WormReputationTooltipSource()
		{
			Il2CppClassPointerStore<WormReputationTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormReputationTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormReputationTooltipSource>.NativeClassPtr);
			WormReputationTooltipSource.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormReputationTooltipSource>.NativeClassPtr, "tooltip");
			WormReputationTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReputationTooltipSource>.NativeClassPtr, 100663808);
			WormReputationTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReputationTooltipSource>.NativeClassPtr, 100663809);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00022AB8 File Offset: 0x00020CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691428, XrefRangeEnd = 691446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormReputationTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00022AF0 File Offset: 0x00020CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691446, XrefRangeEnd = 691451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormReputationTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormReputationTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormReputationTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00003779 File Offset: 0x00001979
		public WormReputationTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00022B2C File Offset: 0x00020D2C
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00003782 File Offset: 0x00001982
		public unsafe string tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReputationTooltipSource.NativeFieldInfoPtr_tooltip);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReputationTooltipSource.NativeFieldInfoPtr_tooltip), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeFieldInfoPtr_tooltip;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
