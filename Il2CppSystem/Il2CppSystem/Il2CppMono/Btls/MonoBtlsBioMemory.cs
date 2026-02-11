using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Btls
{
	// Token: 0x02000028 RID: 40
	public class MonoBtlsBioMemory : MonoBtlsBio
	{
		// Token: 0x0600024D RID: 589 RVA: 0x00023CD8 File Offset: 0x00021ED8
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsBioMemory()
		{
			Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsBioMemory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr);
			MonoBtlsBioMemory.NativeMethodInfoPtr_mono_btls_bio_mem_new_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr, 100663706);
			MonoBtlsBioMemory.NativeMethodInfoPtr_mono_btls_bio_mem_get_data_Private_Static_Int32_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr, 100663707);
			MonoBtlsBioMemory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr, 100663708);
			MonoBtlsBioMemory.NativeMethodInfoPtr_GetData_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr, 100663709);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00023D58 File Offset: 0x00021F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429360, XrefRangeEnd = 429362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_bio_mem_new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMemory.NativeMethodInfoPtr_mono_btls_bio_mem_new_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00023D88 File Offset: 0x00021F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429362, XrefRangeEnd = 429364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_bio_mem_get_data(IntPtr handle, out IntPtr data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMemory.NativeMethodInfoPtr_mono_btls_bio_mem_get_data_Private_Static_Int32_IntPtr_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00023DD4 File Offset: 0x00021FD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429372, RefRangeEnd = 429373, XrefRangeStart = 429364, XrefRangeEnd = 429372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsBioMemory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMemory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00023E10 File Offset: 0x00022010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429392, RefRangeEnd = 429393, XrefRangeStart = 429373, XrefRangeEnd = 429392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBioMemory.NativeMethodInfoPtr_GetData_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002D8C File Offset: 0x00000F8C
		public MonoBtlsBioMemory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_bio_mem_new_Private_Static_IntPtr_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_bio_mem_get_data_Private_Static_Int32_IntPtr_byref_IntPtr_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Il2CppStructArray_1_Byte_0;
	}
}
