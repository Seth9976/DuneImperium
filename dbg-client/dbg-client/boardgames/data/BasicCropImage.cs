using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.data
{
	// Token: 0x0200017C RID: 380
	public class BasicCropImage : BasicImage
	{
		// Token: 0x060010B6 RID: 4278 RVA: 0x00052560 File Offset: 0x00050760
		// Note: this type is marked as 'beforefieldinit'.
		static BasicCropImage()
		{
			Il2CppClassPointerStore<BasicCropImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "BasicCropImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicCropImage>.NativeClassPtr);
			BasicCropImage.NativeFieldInfoPtr_cropImageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicCropImage>.NativeClassPtr, "cropImageName");
			BasicCropImage.NativeMethodInfoPtr_get_CropImageName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicCropImage>.NativeClassPtr, 100665643);
			BasicCropImage.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicCropImage>.NativeClassPtr, 100665644);
			BasicCropImage.NativeMethodInfoPtr_cropImage_Protected_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicCropImage>.NativeClassPtr, 100665645);
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x000525E0 File Offset: 0x000507E0
		public unsafe string CropImageName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicCropImage.NativeMethodInfoPtr_get_CropImageName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00052618 File Offset: 0x00050818
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 514302, RefRangeEnd = 514309, XrefRangeStart = 514299, XrefRangeEnd = 514302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicCropImage(string imageName, string cropImageName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicCropImage>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(imageName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cropImageName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicCropImage.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00052678 File Offset: 0x00050878
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string cropImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicCropImage.NativeMethodInfoPtr_cropImage_Protected_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0000A116 File Offset: 0x00008316
		public BasicCropImage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x000526B0 File Offset: 0x000508B0
		// (set) Token: 0x060010BC RID: 4284 RVA: 0x0000A11F File Offset: 0x0000831F
		public unsafe string cropImageName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicCropImage.NativeFieldInfoPtr_cropImageName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicCropImage.NativeFieldInfoPtr_cropImageName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeFieldInfoPtr_cropImageName;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_get_CropImageName_Public_get_String_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_cropImage_Protected_String_0;
	}
}
