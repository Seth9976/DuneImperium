using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using voodoo;

namespace boardgames
{
	// Token: 0x020000E8 RID: 232
	public class ImageLookupTextureRenderer : VersionedDataComponentObserver<ImageLookup>
	{
		// Token: 0x06000A11 RID: 2577 RVA: 0x0003D25C File Offset: 0x0003B45C
		// Note: this type is marked as 'beforefieldinit'.
		static ImageLookupTextureRenderer()
		{
			Il2CppClassPointerStore<ImageLookupTextureRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames", "ImageLookupTextureRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageLookupTextureRenderer>.NativeClassPtr);
			ImageLookupTextureRenderer.NativeFieldInfoPtr_assetPathFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageLookupTextureRenderer>.NativeClassPtr, "assetPathFormat");
			ImageLookupTextureRenderer.NativeFieldInfoPtr_cachedRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageLookupTextureRenderer>.NativeClassPtr, "cachedRenderer");
			ImageLookupTextureRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLookupTextureRenderer>.NativeClassPtr, 100664762);
			ImageLookupTextureRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLookupTextureRenderer>.NativeClassPtr, 100664763);
			ImageLookupTextureRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLookupTextureRenderer>.NativeClassPtr, 100664764);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0003D2F0 File Offset: 0x0003B4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506571, XrefRangeEnd = 506576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageLookupTextureRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0003D32C File Offset: 0x0003B52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506576, XrefRangeEnd = 506595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageLookupTextureRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0003D368 File Offset: 0x0003B568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506595, XrefRangeEnd = 506601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageLookupTextureRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageLookupTextureRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageLookupTextureRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00006CEA File Offset: 0x00004EEA
		public ImageLookupTextureRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0003D3A4 File Offset: 0x0003B5A4
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00006CF3 File Offset: 0x00004EF3
		public unsafe string assetPathFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupTextureRenderer.NativeFieldInfoPtr_assetPathFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupTextureRenderer.NativeFieldInfoPtr_assetPathFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x0003D3CC File Offset: 0x0003B5CC
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x00006D12 File Offset: 0x00004F12
		public unsafe Renderer cachedRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupTextureRenderer.NativeFieldInfoPtr_cachedRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupTextureRenderer.NativeFieldInfoPtr_cachedRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeFieldInfoPtr_assetPathFormat;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeFieldInfoPtr_cachedRenderer;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
