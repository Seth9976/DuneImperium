using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200023B RID: 571
	[Serializable]
	public class CryptographicUnexpectedOperationException : CryptographicException
	{
		// Token: 0x06002599 RID: 9625 RVA: 0x000CF9D0 File Offset: 0x000CDBD0
		// Note: this type is marked as 'beforefieldinit'.
		static CryptographicUnexpectedOperationException()
		{
			Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptographicUnexpectedOperationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr);
			CryptographicUnexpectedOperationException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr, 100669594);
			CryptographicUnexpectedOperationException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr, 100669595);
			CryptographicUnexpectedOperationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr, 100669596);
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x000CFA3C File Offset: 0x000CDC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371645, XrefRangeEnd = 1371651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicUnexpectedOperationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicUnexpectedOperationException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000CFA78 File Offset: 0x000CDC78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1371654, RefRangeEnd = 1371655, XrefRangeStart = 1371651, XrefRangeEnd = 1371654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicUnexpectedOperationException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicUnexpectedOperationException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x000CFAC4 File Offset: 0x000CDCC4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CryptographicUnexpectedOperationException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CryptographicUnexpectedOperationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptographicUnexpectedOperationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x0000C2A1 File Offset: 0x0000A4A1
		public CryptographicUnexpectedOperationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040020B3 RID: 8371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040020B4 RID: 8372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040020B5 RID: 8373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
