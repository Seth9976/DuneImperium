using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.direBytes.data
{
	// Token: 0x0200001E RID: 30
	public class DireByteMultiImageData : DataComponent
	{
		// Token: 0x06000162 RID: 354 RVA: 0x00007470 File Offset: 0x00005670
		// Note: this type is marked as 'beforefieldinit'.
		static DireByteMultiImageData()
		{
			Il2CppClassPointerStore<DireByteMultiImageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes.data", "DireByteMultiImageData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireByteMultiImageData>.NativeClassPtr);
			DireByteMultiImageData.NativeFieldInfoPtr_ImageLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireByteMultiImageData>.NativeClassPtr, "ImageLookup");
			DireByteMultiImageData.NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_DireByteImageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteMultiImageData>.NativeClassPtr, 100663435);
			DireByteMultiImageData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireByteMultiImageData>.NativeClassPtr, 100663436);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000074DC File Offset: 0x000056DC
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireByteMultiImageData(HashSet<DireBytesProvider.DireByteImageData> imageLookup)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireByteMultiImageData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(imageLookup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireByteMultiImageData.NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_DireByteImageData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00007528 File Offset: 0x00005728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1235025, XrefRangeEnd = 1235064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireByteMultiImageData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002C63 File Offset: 0x00000E63
		public DireByteMultiImageData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000756C File Offset: 0x0000576C
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002C6C File Offset: 0x00000E6C
		public unsafe HashSet<DireBytesProvider.DireByteImageData> ImageLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteMultiImageData.NativeFieldInfoPtr_ImageLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<DireBytesProvider.DireByteImageData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireByteMultiImageData.NativeFieldInfoPtr_ImageLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr_ImageLookup;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_DireByteImageData_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
