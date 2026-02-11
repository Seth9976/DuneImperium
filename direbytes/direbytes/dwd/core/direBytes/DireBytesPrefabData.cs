using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.direBytes
{
	// Token: 0x0200000B RID: 11
	public class DireBytesPrefabData : ImageLookup
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00004418 File Offset: 0x00002618
		// Note: this type is marked as 'beforefieldinit'.
		static DireBytesPrefabData()
		{
			Il2CppClassPointerStore<DireBytesPrefabData>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "DireBytesPrefabData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DireBytesPrefabData>.NativeClassPtr);
			DireBytesPrefabData.NativeFieldInfoPtr_prefabString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DireBytesPrefabData>.NativeClassPtr, "prefabString");
			DireBytesPrefabData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesPrefabData>.NativeClassPtr, 100663329);
			DireBytesPrefabData.NativeMethodInfoPtr_SetImage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesPrefabData>.NativeClassPtr, 100663330);
			DireBytesPrefabData.NativeMethodInfoPtr_imageName_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DireBytesPrefabData>.NativeClassPtr, 100663331);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004498 File Offset: 0x00002698
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 504779, RefRangeEnd = 504807, XrefRangeStart = 504779, XrefRangeEnd = 504807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DireBytesPrefabData(string prefabString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DireBytesPrefabData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesPrefabData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000044E4 File Offset: 0x000026E4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DireBytesPrefabData.NativeMethodInfoPtr_SetImage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004528 File Offset: 0x00002728
		[CallerCount(0)]
		public unsafe override string imageName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DireBytesPrefabData.NativeMethodInfoPtr_imageName_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000022DD File Offset: 0x000004DD
		public DireBytesPrefabData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000456C File Offset: 0x0000276C
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000022E6 File Offset: 0x000004E6
		public unsafe string prefabString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesPrefabData.NativeFieldInfoPtr_prefabString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DireBytesPrefabData.NativeFieldInfoPtr_prefabString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_prefabString;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_SetImage_Public_Void_String_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_imageName_Protected_Virtual_String_0;
	}
}
