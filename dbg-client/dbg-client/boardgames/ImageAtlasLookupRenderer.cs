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
	// Token: 0x020000E6 RID: 230
	public class ImageAtlasLookupRenderer : VersionedDataComponentObserver<ImageLookup>
	{
		// Token: 0x060009F9 RID: 2553 RVA: 0x0003CE58 File Offset: 0x0003B058
		// Note: this type is marked as 'beforefieldinit'.
		static ImageAtlasLookupRenderer()
		{
			Il2CppClassPointerStore<ImageAtlasLookupRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames", "ImageAtlasLookupRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageAtlasLookupRenderer>.NativeClassPtr);
			ImageAtlasLookupRenderer.NativeFieldInfoPtr_atlasName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageAtlasLookupRenderer>.NativeClassPtr, "atlasName");
			ImageAtlasLookupRenderer.NativeFieldInfoPtr_spriteNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageAtlasLookupRenderer>.NativeClassPtr, "spriteNameFormat");
			ImageAtlasLookupRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageAtlasLookupRenderer>.NativeClassPtr, "image");
			ImageAtlasLookupRenderer.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageAtlasLookupRenderer>.NativeClassPtr, "spriteRenderer");
			ImageAtlasLookupRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageAtlasLookupRenderer>.NativeClassPtr, 100664756);
			ImageAtlasLookupRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageAtlasLookupRenderer>.NativeClassPtr, 100664757);
			ImageAtlasLookupRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageAtlasLookupRenderer>.NativeClassPtr, 100664758);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0003CF14 File Offset: 0x0003B114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506473, XrefRangeEnd = 506486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageAtlasLookupRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0003CF50 File Offset: 0x0003B150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506486, XrefRangeEnd = 506520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageAtlasLookupRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0003CF8C File Offset: 0x0003B18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506520, XrefRangeEnd = 506528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageAtlasLookupRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageAtlasLookupRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageAtlasLookupRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00006BFF File Offset: 0x00004DFF
		public ImageAtlasLookupRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0003CFC8 File Offset: 0x0003B1C8
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x00006C08 File Offset: 0x00004E08
		public unsafe string atlasName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageAtlasLookupRenderer.NativeFieldInfoPtr_atlasName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageAtlasLookupRenderer.NativeFieldInfoPtr_atlasName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0003CFF0 File Offset: 0x0003B1F0
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x00006C27 File Offset: 0x00004E27
		public unsafe string spriteNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageAtlasLookupRenderer.NativeFieldInfoPtr_spriteNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageAtlasLookupRenderer.NativeFieldInfoPtr_spriteNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x0003D018 File Offset: 0x0003B218
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00006C46 File Offset: 0x00004E46
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageAtlasLookupRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageAtlasLookupRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0003D048 File Offset: 0x0003B248
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00006C65 File Offset: 0x00004E65
		public unsafe SpriteRenderer spriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageAtlasLookupRenderer.NativeFieldInfoPtr_spriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageAtlasLookupRenderer.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeFieldInfoPtr_atlasName;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr_spriteNameFormat;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
