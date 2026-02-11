using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200023A RID: 570
	[Serializable]
	public class CryptographicException : SystemException
	{
		// Token: 0x06002591 RID: 9617 RVA: 0x000CF734 File Offset: 0x000CD934
		// Note: this type is marked as 'beforefieldinit'.
		static CryptographicException()
		{
			Il2CppClassPointerStore<CryptographicException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptographicException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr);
			CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr, 100669588);
			CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr, 100669589);
			CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr, 100669590);
			CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr, 100669591);
			CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr, 100669592);
			CryptographicException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr, 100669593);
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x000CF7DC File Offset: 0x000CD9DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1371584, RefRangeEnd = 1371585, XrefRangeStart = 1371579, XrefRangeEnd = 1371584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002593 RID: 9619 RVA: 0x000CF818 File Offset: 0x000CDA18
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 1371587, RefRangeEnd = 1371628, XrefRangeStart = 1371585, XrefRangeEnd = 1371587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x000CF864 File Offset: 0x000CDA64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1371635, RefRangeEnd = 1371639, XrefRangeStart = 1371628, XrefRangeEnd = 1371635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicException(string format, string insert)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(insert);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x000CF8C4 File Offset: 0x000CDAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371639, XrefRangeEnd = 1371641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicException(string message, Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x000CF924 File Offset: 0x000CDB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371641, XrefRangeEnd = 1371645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicException(int hr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicException.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x000CF96C File Offset: 0x000CDB6C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x0000C298 File Offset: 0x0000A498
		public CryptographicException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020AD RID: 8365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020AE RID: 8366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040020AF RID: 8367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040020B0 RID: 8368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040020B1 RID: 8369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040020B2 RID: 8370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
