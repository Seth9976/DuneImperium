using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x020000F2 RID: 242
	public class HideVictoryPointsRenderer : MonoBehaviour
	{
		// Token: 0x06000AAA RID: 2730 RVA: 0x00038910 File Offset: 0x00036B10
		// Note: this type is marked as 'beforefieldinit'.
		static HideVictoryPointsRenderer()
		{
			Il2CppClassPointerStore<HideVictoryPointsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "HideVictoryPointsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideVictoryPointsRenderer>.NativeClassPtr);
			HideVictoryPointsRenderer.NativeFieldInfoPtr_VPIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideVictoryPointsRenderer>.NativeClassPtr, "VPIcons");
			HideVictoryPointsRenderer.NativeMethodInfoPtr_SetShown_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideVictoryPointsRenderer>.NativeClassPtr, 100664769);
			HideVictoryPointsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideVictoryPointsRenderer>.NativeClassPtr, 100664770);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0003897C File Offset: 0x00036B7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 701867, RefRangeEnd = 701868, XrefRangeStart = 701852, XrefRangeEnd = 701867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShown(bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideVictoryPointsRenderer.NativeMethodInfoPtr_SetShown_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x000389BC File Offset: 0x00036BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701868, XrefRangeEnd = 701876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HideVictoryPointsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideVictoryPointsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideVictoryPointsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00007911 File Offset: 0x00005B11
		public HideVictoryPointsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x000389F8 File Offset: 0x00036BF8
		// (set) Token: 0x06000AAF RID: 2735 RVA: 0x0000791A File Offset: 0x00005B1A
		public unsafe List<GameObject> VPIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideVictoryPointsRenderer.NativeFieldInfoPtr_VPIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideVictoryPointsRenderer.NativeFieldInfoPtr_VPIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeFieldInfoPtr_VPIcons;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_SetShown_Public_Void_Boolean_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
