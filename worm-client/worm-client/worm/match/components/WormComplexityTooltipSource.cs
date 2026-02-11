using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using worm.match.dataRenderers;

namespace worm.match.components
{
	// Token: 0x020001DB RID: 475
	public class WormComplexityTooltipSource : MonoBehaviour
	{
		// Token: 0x06001508 RID: 5384 RVA: 0x00057ED4 File Offset: 0x000560D4
		// Note: this type is marked as 'beforefieldinit'.
		static WormComplexityTooltipSource()
		{
			Il2CppClassPointerStore<WormComplexityTooltipSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormComplexityTooltipSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormComplexityTooltipSource>.NativeClassPtr);
			WormComplexityTooltipSource.NativeFieldInfoPtr_complexitySource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormComplexityTooltipSource>.NativeClassPtr, "complexitySource");
			WormComplexityTooltipSource.NativeFieldInfoPtr_tooltips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormComplexityTooltipSource>.NativeClassPtr, "tooltips");
			WormComplexityTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormComplexityTooltipSource>.NativeClassPtr, 100666169);
			WormComplexityTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormComplexityTooltipSource>.NativeClassPtr, 100666170);
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00057F54 File Offset: 0x00056154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714672, XrefRangeEnd = 714681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormComplexityTooltipSource.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00057F8C File Offset: 0x0005618C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 714681, XrefRangeEnd = 714689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormComplexityTooltipSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormComplexityTooltipSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormComplexityTooltipSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0000CD4E File Offset: 0x0000AF4E
		public WormComplexityTooltipSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x00057FC8 File Offset: 0x000561C8
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x0000CD57 File Offset: 0x0000AF57
		public unsafe WormComplexityRenderer complexitySource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityTooltipSource.NativeFieldInfoPtr_complexitySource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormComplexityRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityTooltipSource.NativeFieldInfoPtr_complexitySource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x00057FF8 File Offset: 0x000561F8
		// (set) Token: 0x0600150F RID: 5391 RVA: 0x0000CD76 File Offset: 0x0000AF76
		public unsafe List<string> tooltips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityTooltipSource.NativeFieldInfoPtr_tooltips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityTooltipSource.NativeFieldInfoPtr_tooltips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeFieldInfoPtr_complexitySource;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeFieldInfoPtr_tooltips;

		// Token: 0x04000C33 RID: 3123
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x04000C34 RID: 3124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
