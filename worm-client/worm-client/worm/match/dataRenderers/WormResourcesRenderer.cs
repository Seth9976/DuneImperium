using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200015A RID: 346
	public class WormResourcesRenderer : VersionedDataComponentObserver<WormResourcesData>
	{
		// Token: 0x06000F79 RID: 3961 RVA: 0x0004691C File Offset: 0x00044B1C
		// Note: this type is marked as 'beforefieldinit'.
		static WormResourcesRenderer()
		{
			Il2CppClassPointerStore<WormResourcesRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormResourcesRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormResourcesRenderer>.NativeClassPtr);
			WormResourcesRenderer.NativeFieldInfoPtr_spiceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResourcesRenderer>.NativeClassPtr, "spiceText");
			WormResourcesRenderer.NativeFieldInfoPtr_waterText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResourcesRenderer>.NativeClassPtr, "waterText");
			WormResourcesRenderer.NativeFieldInfoPtr_solariText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormResourcesRenderer>.NativeClassPtr, "solariText");
			WormResourcesRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResourcesRenderer>.NativeClassPtr, 100665386);
			WormResourcesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormResourcesRenderer>.NativeClassPtr, 100665387);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x000469B0 File Offset: 0x00044BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707824, XrefRangeEnd = 707872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormResourcesRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x000469EC File Offset: 0x00044BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707872, XrefRangeEnd = 707875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormResourcesRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormResourcesRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormResourcesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0000A282 File Offset: 0x00008482
		public WormResourcesRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00046A28 File Offset: 0x00044C28
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x0000A28B File Offset: 0x0000848B
		public unsafe TMP_Text spiceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResourcesRenderer.NativeFieldInfoPtr_spiceText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResourcesRenderer.NativeFieldInfoPtr_spiceText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x00046A58 File Offset: 0x00044C58
		// (set) Token: 0x06000F80 RID: 3968 RVA: 0x0000A2AA File Offset: 0x000084AA
		public unsafe TMP_Text waterText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResourcesRenderer.NativeFieldInfoPtr_waterText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResourcesRenderer.NativeFieldInfoPtr_waterText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x00046A88 File Offset: 0x00044C88
		// (set) Token: 0x06000F82 RID: 3970 RVA: 0x0000A2C9 File Offset: 0x000084C9
		public unsafe TMP_Text solariText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResourcesRenderer.NativeFieldInfoPtr_solariText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormResourcesRenderer.NativeFieldInfoPtr_solariText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_spiceText;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_waterText;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_solariText;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
