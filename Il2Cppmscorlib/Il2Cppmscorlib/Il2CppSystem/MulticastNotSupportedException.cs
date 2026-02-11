using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000C9 RID: 201
	[Serializable]
	public sealed class MulticastNotSupportedException : SystemException
	{
		// Token: 0x06000D06 RID: 3334 RVA: 0x0006236C File Offset: 0x0006056C
		// Note: this type is marked as 'beforefieldinit'.
		static MulticastNotSupportedException()
		{
			Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MulticastNotSupportedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr);
			MulticastNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr, 100665581);
			MulticastNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr, 100665582);
			MulticastNotSupportedException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr, 100665583);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x000623D8 File Offset: 0x000605D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311484, XrefRangeEnd = 1311487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastNotSupportedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00062414 File Offset: 0x00060614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1311488, RefRangeEnd = 1311489, XrefRangeStart = 1311487, XrefRangeEnd = 1311488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastNotSupportedException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00062460 File Offset: 0x00060660
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MulticastNotSupportedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MulticastNotSupportedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastNotSupportedException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x0000529B File Offset: 0x0000349B
		public MulticastNotSupportedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
