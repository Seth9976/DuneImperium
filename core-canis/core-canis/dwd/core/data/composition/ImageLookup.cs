using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.data.composition
{
	// Token: 0x020001E0 RID: 480
	public class ImageLookup : VersionedDataComponent
	{
		// Token: 0x06001A71 RID: 6769 RVA: 0x0007D4CC File Offset: 0x0007B6CC
		// Note: this type is marked as 'beforefieldinit'.
		static ImageLookup()
		{
			Il2CppClassPointerStore<ImageLookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition", "ImageLookup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageLookup>.NativeClassPtr);
			ImageLookup.NativeMethodInfoPtr_get_ImageName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLookup>.NativeClassPtr, 100667492);
			ImageLookup.NativeMethodInfoPtr_imageName_Protected_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLookup>.NativeClassPtr, 100667493);
			ImageLookup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLookup>.NativeClassPtr, 100667494);
			ImageLookup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageLookup>.NativeClassPtr, 100667495);
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x0007D54C File Offset: 0x0007B74C
		public unsafe string ImageName
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 285957, RefRangeEnd = 285998, XrefRangeStart = 285957, XrefRangeEnd = 285998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageLookup.NativeMethodInfoPtr_get_ImageName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0007D584 File Offset: 0x0007B784
		[CallerCount(0)]
		public unsafe virtual string imageName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageLookup.NativeMethodInfoPtr_imageName_Protected_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0007D5C8 File Offset: 0x0007B7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883678, XrefRangeEnd = 883683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ImageLookup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A75 RID: 6773 RVA: 0x0007D60C File Offset: 0x0007B80C
		[CallerCount(97)]
		[CachedScanResults(RefRangeStart = 883581, RefRangeEnd = 883678, XrefRangeStart = 883581, XrefRangeEnd = 883678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageLookup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageLookup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageLookup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0000B704 File Offset: 0x00009904
		public ImageLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageName_Public_get_String_0;

		// Token: 0x04001294 RID: 4756
		private static readonly IntPtr NativeMethodInfoPtr_imageName_Protected_Abstract_Virtual_New_String_0;

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
