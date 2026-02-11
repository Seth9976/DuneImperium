using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000CD RID: 205
	[Serializable]
	public class NullReferenceException : SystemException
	{
		// Token: 0x06000D19 RID: 3353 RVA: 0x00062824 File Offset: 0x00060A24
		// Note: this type is marked as 'beforefieldinit'.
		static NullReferenceException()
		{
			Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NullReferenceException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr);
			NullReferenceException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr, 100665592);
			NullReferenceException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr, 100665593);
			NullReferenceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr, 100665594);
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00062890 File Offset: 0x00060A90
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1316286, RefRangeEnd = 1316295, XrefRangeStart = 1316283, XrefRangeEnd = 1316286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullReferenceException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullReferenceException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x000628CC File Offset: 0x00060ACC
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1316296, RefRangeEnd = 1316327, XrefRangeStart = 1316295, XrefRangeEnd = 1316296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullReferenceException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullReferenceException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00062918 File Offset: 0x00060B18
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullReferenceException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullReferenceException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullReferenceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x000052F8 File Offset: 0x000034F8
		public NullReferenceException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
