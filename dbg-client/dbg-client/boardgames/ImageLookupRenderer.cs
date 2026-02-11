using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;
using voodoo;

namespace boardgames
{
	// Token: 0x020000E7 RID: 231
	public class ImageLookupRenderer : VersionedDataComponentObserver<ImageLookup>
	{
		// Token: 0x06000A06 RID: 2566 RVA: 0x0003D078 File Offset: 0x0003B278
		// Note: this type is marked as 'beforefieldinit'.
		static ImageLookupRenderer()
		{
			Il2CppClassPointerStore<ImageLookupRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames", "ImageLookupRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageLookupRenderer>.NativeClassPtr);
			ImageLookupRenderer.NativeFieldInfoPtr_assetPathFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageLookupRenderer>.NativeClassPtr, "assetPathFormat");
			ImageLookupRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageLookupRenderer>.NativeClassPtr, "image");
			ImageLookupRenderer.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageLookupRenderer>.NativeClassPtr, "spriteRenderer");
			ImageLookupRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLookupRenderer>.NativeClassPtr, 100664759);
			ImageLookupRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLookupRenderer>.NativeClassPtr, 100664760);
			ImageLookupRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLookupRenderer>.NativeClassPtr, 100664761);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0003D120 File Offset: 0x0003B320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506528, XrefRangeEnd = 506541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageLookupRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0003D15C File Offset: 0x0003B35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506541, XrefRangeEnd = 506565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageLookupRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0003D198 File Offset: 0x0003B398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506565, XrefRangeEnd = 506571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageLookupRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageLookupRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageLookupRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00006C84 File Offset: 0x00004E84
		public ImageLookupRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0003D1D4 File Offset: 0x0003B3D4
		// (set) Token: 0x06000A0C RID: 2572 RVA: 0x00006C8D File Offset: 0x00004E8D
		public unsafe string assetPathFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupRenderer.NativeFieldInfoPtr_assetPathFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupRenderer.NativeFieldInfoPtr_assetPathFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x0003D1FC File Offset: 0x0003B3FC
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00006CAC File Offset: 0x00004EAC
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0003D22C File Offset: 0x0003B42C
		// (set) Token: 0x06000A10 RID: 2576 RVA: 0x00006CCB File Offset: 0x00004ECB
		public unsafe SpriteRenderer spriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupRenderer.NativeFieldInfoPtr_spriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupRenderer.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeFieldInfoPtr_assetPathFormat;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
