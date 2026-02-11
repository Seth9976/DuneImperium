using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using voodoo;

namespace boardgames.dataRenderers
{
	// Token: 0x0200014F RID: 335
	public class ImageLookupMaterialRenderer : VersionedDataComponentObserver<ImageLookup>
	{
		// Token: 0x06000F22 RID: 3874 RVA: 0x0004DCC8 File Offset: 0x0004BEC8
		// Note: this type is marked as 'beforefieldinit'.
		static ImageLookupMaterialRenderer()
		{
			Il2CppClassPointerStore<ImageLookupMaterialRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "ImageLookupMaterialRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageLookupMaterialRenderer>.NativeClassPtr);
			ImageLookupMaterialRenderer.NativeFieldInfoPtr_assetPathFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageLookupMaterialRenderer>.NativeClassPtr, "assetPathFormat");
			ImageLookupMaterialRenderer.NativeFieldInfoPtr_cachedRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageLookupMaterialRenderer>.NativeClassPtr, "cachedRenderer");
			ImageLookupMaterialRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLookupMaterialRenderer>.NativeClassPtr, 100665489);
			ImageLookupMaterialRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLookupMaterialRenderer>.NativeClassPtr, 100665490);
			ImageLookupMaterialRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLookupMaterialRenderer>.NativeClassPtr, 100665491);
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0004DD5C File Offset: 0x0004BF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513078, XrefRangeEnd = 513083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageLookupMaterialRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0004DD98 File Offset: 0x0004BF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513083, XrefRangeEnd = 513101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageLookupMaterialRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x0004DDD4 File Offset: 0x0004BFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513101, XrefRangeEnd = 513107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageLookupMaterialRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageLookupMaterialRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageLookupMaterialRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x0000944C File Offset: 0x0000764C
		public ImageLookupMaterialRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x0004DE10 File Offset: 0x0004C010
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x00009455 File Offset: 0x00007655
		public unsafe string assetPathFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupMaterialRenderer.NativeFieldInfoPtr_assetPathFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupMaterialRenderer.NativeFieldInfoPtr_assetPathFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x0004DE38 File Offset: 0x0004C038
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x00009474 File Offset: 0x00007674
		public unsafe Renderer cachedRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupMaterialRenderer.NativeFieldInfoPtr_cachedRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageLookupMaterialRenderer.NativeFieldInfoPtr_cachedRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeFieldInfoPtr_assetPathFormat;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeFieldInfoPtr_cachedRenderer;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
