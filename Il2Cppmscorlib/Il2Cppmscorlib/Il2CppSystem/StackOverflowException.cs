using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000E5 RID: 229
	[Serializable]
	public sealed class StackOverflowException : SystemException
	{
		// Token: 0x06000EEC RID: 3820 RVA: 0x0006BA9C File Offset: 0x00069C9C
		// Note: this type is marked as 'beforefieldinit'.
		static StackOverflowException()
		{
			Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "StackOverflowException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr);
			StackOverflowException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr, 100665911);
			StackOverflowException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr, 100665912);
			StackOverflowException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr, 100665913);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0006BB08 File Offset: 0x00069D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320660, XrefRangeEnd = 1320666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackOverflowException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackOverflowException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0006BB44 File Offset: 0x00069D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1320666, XrefRangeEnd = 1320670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackOverflowException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackOverflowException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0006BB90 File Offset: 0x00069D90
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 1318224, RefRangeEnd = 1318290, XrefRangeStart = 1318224, XrefRangeEnd = 1318290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackOverflowException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackOverflowException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackOverflowException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0000595C File Offset: 0x00003B5C
		public StackOverflowException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C30 RID: 3120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C31 RID: 3121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C32 RID: 3122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
