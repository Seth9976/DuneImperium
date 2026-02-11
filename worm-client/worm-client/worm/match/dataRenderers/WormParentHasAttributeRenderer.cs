using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x02000149 RID: 329
	public class WormParentHasAttributeRenderer : Observer
	{
		// Token: 0x06000EC8 RID: 3784 RVA: 0x0004498C File Offset: 0x00042B8C
		// Note: this type is marked as 'beforefieldinit'.
		static WormParentHasAttributeRenderer()
		{
			Il2CppClassPointerStore<WormParentHasAttributeRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormParentHasAttributeRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormParentHasAttributeRenderer>.NativeClassPtr);
			WormParentHasAttributeRenderer.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormParentHasAttributeRenderer>.NativeClassPtr, "display");
			WormParentHasAttributeRenderer.NativeFieldInfoPtr_attributeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormParentHasAttributeRenderer>.NativeClassPtr, "attributeKey");
			WormParentHasAttributeRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormParentHasAttributeRenderer>.NativeClassPtr, 100665294);
			WormParentHasAttributeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormParentHasAttributeRenderer>.NativeClassPtr, 100665295);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00044A0C File Offset: 0x00042C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707021, XrefRangeEnd = 707034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormParentHasAttributeRenderer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00044A48 File Offset: 0x00042C48
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormParentHasAttributeRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormParentHasAttributeRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormParentHasAttributeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x00009C93 File Offset: 0x00007E93
		public WormParentHasAttributeRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x00044A84 File Offset: 0x00042C84
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x00009C9C File Offset: 0x00007E9C
		public unsafe GameObject display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormParentHasAttributeRenderer.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormParentHasAttributeRenderer.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x00044AB4 File Offset: 0x00042CB4
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x00009CBB File Offset: 0x00007EBB
		public unsafe int attributeKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormParentHasAttributeRenderer.NativeFieldInfoPtr_attributeKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormParentHasAttributeRenderer.NativeFieldInfoPtr_attributeKey)) = value;
			}
		}

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeFieldInfoPtr_attributeKey;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
