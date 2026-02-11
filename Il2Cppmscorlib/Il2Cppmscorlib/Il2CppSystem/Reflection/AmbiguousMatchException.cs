using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020003F3 RID: 1011
	[Serializable]
	public sealed class AmbiguousMatchException : SystemException
	{
		// Token: 0x06003B68 RID: 15208 RVA: 0x0011D628 File Offset: 0x0011B828
		// Note: this type is marked as 'beforefieldinit'.
		static AmbiguousMatchException()
		{
			Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AmbiguousMatchException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr);
			AmbiguousMatchException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr, 100672167);
			AmbiguousMatchException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr, 100672168);
			AmbiguousMatchException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr, 100672169);
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x0011D694 File Offset: 0x0011B894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398062, XrefRangeEnd = 1398065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbiguousMatchException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbiguousMatchException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x0011D6D0 File Offset: 0x0011B8D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1398066, RefRangeEnd = 1398067, XrefRangeStart = 1398065, XrefRangeEnd = 1398066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbiguousMatchException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbiguousMatchException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x0011D71C File Offset: 0x0011B91C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbiguousMatchException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbiguousMatchException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbiguousMatchException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x000161EF File Offset: 0x000143EF
		public AmbiguousMatchException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400300C RID: 12300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400300D RID: 12301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400300E RID: 12302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
