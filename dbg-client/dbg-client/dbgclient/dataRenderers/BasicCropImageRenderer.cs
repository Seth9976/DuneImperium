using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;
using voodoo;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000B3 RID: 179
	public class BasicCropImageRenderer : VersionedDataComponentObserver<ImageLookup>
	{
		// Token: 0x06000736 RID: 1846 RVA: 0x00034540 File Offset: 0x00032740
		// Note: this type is marked as 'beforefieldinit'.
		static BasicCropImageRenderer()
		{
			Il2CppClassPointerStore<BasicCropImageRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "BasicCropImageRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicCropImageRenderer>.NativeClassPtr);
			BasicCropImageRenderer.NativeFieldInfoPtr_assetPathFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicCropImageRenderer>.NativeClassPtr, "assetPathFormat");
			BasicCropImageRenderer.NativeFieldInfoPtr_cropNameFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicCropImageRenderer>.NativeClassPtr, "cropNameFormat");
			BasicCropImageRenderer.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicCropImageRenderer>.NativeClassPtr, "image");
			BasicCropImageRenderer.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicCropImageRenderer>.NativeClassPtr, "spriteRenderer");
			BasicCropImageRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicCropImageRenderer>.NativeClassPtr, 100664408);
			BasicCropImageRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicCropImageRenderer>.NativeClassPtr, 100664409);
			BasicCropImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicCropImageRenderer>.NativeClassPtr, 100664410);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000345FC File Offset: 0x000327FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504098, XrefRangeEnd = 504111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicCropImageRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00034638 File Offset: 0x00032838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504111, XrefRangeEnd = 504152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicCropImageRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00034674 File Offset: 0x00032874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504152, XrefRangeEnd = 504160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicCropImageRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicCropImageRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicCropImageRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000054B7 File Offset: 0x000036B7
		public BasicCropImageRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x000346B0 File Offset: 0x000328B0
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x000054C0 File Offset: 0x000036C0
		public unsafe string assetPathFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicCropImageRenderer.NativeFieldInfoPtr_assetPathFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicCropImageRenderer.NativeFieldInfoPtr_assetPathFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x000346D8 File Offset: 0x000328D8
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x000054DF File Offset: 0x000036DF
		public unsafe string cropNameFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicCropImageRenderer.NativeFieldInfoPtr_cropNameFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicCropImageRenderer.NativeFieldInfoPtr_cropNameFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00034700 File Offset: 0x00032900
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x000054FE File Offset: 0x000036FE
		public unsafe Image image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicCropImageRenderer.NativeFieldInfoPtr_image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicCropImageRenderer.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00034730 File Offset: 0x00032930
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x0000551D File Offset: 0x0000371D
		public unsafe SpriteRenderer spriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicCropImageRenderer.NativeFieldInfoPtr_spriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicCropImageRenderer.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr_assetPathFormat;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeFieldInfoPtr_cropNameFormat;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr_image;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
