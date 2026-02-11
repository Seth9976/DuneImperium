using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppMono.Btls
{
	// Token: 0x0200002D RID: 45
	public class MonoBtlsException : Exception
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x000257C0 File Offset: 0x000239C0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsException()
		{
			Il2CppClassPointerStore<MonoBtlsException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsException>.NativeClassPtr);
			MonoBtlsException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsException>.NativeClassPtr, 100663768);
			MonoBtlsException.NativeMethodInfoPtr__ctor_Public_Void_MonoBtlsSslError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsException>.NativeClassPtr, 100663769);
			MonoBtlsException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsException>.NativeClassPtr, 100663770);
			MonoBtlsException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsException>.NativeClassPtr, 100663771);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00025840 File Offset: 0x00023A40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 429998, RefRangeEnd = 430001, XrefRangeStart = 429994, XrefRangeEnd = 429998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0002587C File Offset: 0x00023A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430001, XrefRangeEnd = 430008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsException(MonoBtlsSslError error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref error;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsException.NativeMethodInfoPtr__ctor_Public_Void_MonoBtlsSslError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000258C4 File Offset: 0x00023AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 430008, XrefRangeEnd = 430012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00025910 File Offset: 0x00023B10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 430017, RefRangeEnd = 430019, XrefRangeStart = 430012, XrefRangeEnd = 430017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsException(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsException>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00003024 File Offset: 0x00001224
		public MonoBtlsException(string format, params Object[] args)
			: this(format, new Il2CppReferenceArray<Object>(args))
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00003033 File Offset: 0x00001233
		public MonoBtlsException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MonoBtlsSslError_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0;
	}
}
