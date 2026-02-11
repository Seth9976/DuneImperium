using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security.Authentication
{
	// Token: 0x020000AD RID: 173
	[Serializable]
	public class AuthenticationException : SystemException
	{
		// Token: 0x06000C74 RID: 3188 RVA: 0x0004A44C File Offset: 0x0004864C
		// Note: this type is marked as 'beforefieldinit'.
		static AuthenticationException()
		{
			Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Authentication", "AuthenticationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr);
			AuthenticationException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr, 100665071);
			AuthenticationException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr, 100665072);
			AuthenticationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr, 100665073);
			AuthenticationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr, 100665074);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0004A4CC File Offset: 0x000486CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451993, XrefRangeEnd = 451997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0004A508 File Offset: 0x00048708
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 451998, RefRangeEnd = 452001, XrefRangeStart = 451997, XrefRangeEnd = 451998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticationException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0004A554 File Offset: 0x00048754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 452002, RefRangeEnd = 452003, XrefRangeStart = 452001, XrefRangeEnd = 452002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticationException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0004A5B4 File Offset: 0x000487B4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452003, XrefRangeEnd = 452004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00006AAE File Offset: 0x00004CAE
		public AuthenticationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
