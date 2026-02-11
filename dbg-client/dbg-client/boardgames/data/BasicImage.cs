using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.data
{
	// Token: 0x0200017D RID: 381
	public class BasicImage : ImageLookup
	{
		// Token: 0x060010BD RID: 4285 RVA: 0x000526D8 File Offset: 0x000508D8
		// Note: this type is marked as 'beforefieldinit'.
		static BasicImage()
		{
			Il2CppClassPointerStore<BasicImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "BasicImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicImage>.NativeClassPtr);
			BasicImage.NativeFieldInfoPtr_imageString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicImage>.NativeClassPtr, "imageString");
			BasicImage.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicImage>.NativeClassPtr, 100665646);
			BasicImage.NativeMethodInfoPtr_SetImage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicImage>.NativeClassPtr, 100665647);
			BasicImage.NativeMethodInfoPtr_imageName_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicImage>.NativeClassPtr, 100665648);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00052758 File Offset: 0x00050958
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 504779, RefRangeEnd = 504807, XrefRangeStart = 504779, XrefRangeEnd = 504807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicImage(string imageString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicImage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(imageString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicImage.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x000527A4 File Offset: 0x000509A4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 514283, RefRangeEnd = 514296, XrefRangeStart = 514283, XrefRangeEnd = 514296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetImage(string image)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(image);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicImage.NativeMethodInfoPtr_SetImage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x000527E8 File Offset: 0x000509E8
		[CallerCount(0)]
		public unsafe override string imageName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicImage.NativeMethodInfoPtr_imageName_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0000A13E File Offset: 0x0000833E
		public BasicImage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0005282C File Offset: 0x00050A2C
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x0000A147 File Offset: 0x00008347
		public unsafe string imageString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicImage.NativeFieldInfoPtr_imageString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicImage.NativeFieldInfoPtr_imageString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr_imageString;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_SetImage_Public_Void_String_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_imageName_Protected_Virtual_String_0;
	}
}
