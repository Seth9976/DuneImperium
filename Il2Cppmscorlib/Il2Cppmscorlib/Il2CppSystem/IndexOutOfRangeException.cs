using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000B2 RID: 178
	[Serializable]
	public sealed class IndexOutOfRangeException : SystemException
	{
		// Token: 0x06000BAF RID: 2991 RVA: 0x0005BB10 File Offset: 0x00059D10
		// Note: this type is marked as 'beforefieldinit'.
		static IndexOutOfRangeException()
		{
			Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IndexOutOfRangeException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr);
			IndexOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr, 100665325);
			IndexOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr, 100665326);
			IndexOutOfRangeException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr, 100665327);
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0005BB7C File Offset: 0x00059D7C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1308144, RefRangeEnd = 1308152, XrefRangeStart = 1308141, XrefRangeEnd = 1308144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexOutOfRangeException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0005BBB8 File Offset: 0x00059DB8
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 1308153, RefRangeEnd = 1308182, XrefRangeStart = 1308152, XrefRangeEnd = 1308153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexOutOfRangeException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0005BC04 File Offset: 0x00059E04
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexOutOfRangeException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexOutOfRangeException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexOutOfRangeException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00004FE8 File Offset: 0x000031E8
		public IndexOutOfRangeException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
