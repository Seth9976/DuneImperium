using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200010A RID: 266
	public class WormComplexityRenderer : Subscriber<WormComplexityData>
	{
		// Token: 0x06000BD6 RID: 3030 RVA: 0x0003BF00 File Offset: 0x0003A100
		// Note: this type is marked as 'beforefieldinit'.
		static WormComplexityRenderer()
		{
			Il2CppClassPointerStore<WormComplexityRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormComplexityRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormComplexityRenderer>.NativeClassPtr);
			WormComplexityRenderer.NativeFieldInfoPtr_image1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormComplexityRenderer>.NativeClassPtr, "image1");
			WormComplexityRenderer.NativeFieldInfoPtr_image2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormComplexityRenderer>.NativeClassPtr, "image2");
			WormComplexityRenderer.NativeFieldInfoPtr_image3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormComplexityRenderer>.NativeClassPtr, "image3");
			WormComplexityRenderer.NativeFieldInfoPtr_onPip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormComplexityRenderer>.NativeClassPtr, "onPip");
			WormComplexityRenderer.NativeFieldInfoPtr_offPip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormComplexityRenderer>.NativeClassPtr, "offPip");
			WormComplexityRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormComplexityRenderer>.NativeClassPtr, 100664926);
			WormComplexityRenderer.NativeMethodInfoPtr_GetComplexity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormComplexityRenderer>.NativeClassPtr, 100664927);
			WormComplexityRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormComplexityRenderer>.NativeClassPtr, 100664928);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0003BFD0 File Offset: 0x0003A1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703699, XrefRangeEnd = 703710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormComplexityRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0003C00C File Offset: 0x0003A20C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 703713, RefRangeEnd = 703714, XrefRangeStart = 703710, XrefRangeEnd = 703713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetComplexity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormComplexityRenderer.NativeMethodInfoPtr_GetComplexity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0003C048 File Offset: 0x0003A248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 703714, XrefRangeEnd = 703717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormComplexityRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormComplexityRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormComplexityRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000083C2 File Offset: 0x000065C2
		public WormComplexityRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x0003C084 File Offset: 0x0003A284
		// (set) Token: 0x06000BDC RID: 3036 RVA: 0x000083CB File Offset: 0x000065CB
		public unsafe Image image1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityRenderer.NativeFieldInfoPtr_image1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityRenderer.NativeFieldInfoPtr_image1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x0003C0B4 File Offset: 0x0003A2B4
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x000083EA File Offset: 0x000065EA
		public unsafe Image image2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityRenderer.NativeFieldInfoPtr_image2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityRenderer.NativeFieldInfoPtr_image2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0003C0E4 File Offset: 0x0003A2E4
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x00008409 File Offset: 0x00006609
		public unsafe Image image3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityRenderer.NativeFieldInfoPtr_image3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityRenderer.NativeFieldInfoPtr_image3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0003C114 File Offset: 0x0003A314
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x00008428 File Offset: 0x00006628
		public unsafe Sprite onPip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityRenderer.NativeFieldInfoPtr_onPip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityRenderer.NativeFieldInfoPtr_onPip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0003C144 File Offset: 0x0003A344
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x00008447 File Offset: 0x00006647
		public unsafe Sprite offPip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityRenderer.NativeFieldInfoPtr_offPip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormComplexityRenderer.NativeFieldInfoPtr_offPip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeFieldInfoPtr_image1;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeFieldInfoPtr_image2;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeFieldInfoPtr_image3;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeFieldInfoPtr_onPip;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_offPip;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_GetComplexity_Public_Int32_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
