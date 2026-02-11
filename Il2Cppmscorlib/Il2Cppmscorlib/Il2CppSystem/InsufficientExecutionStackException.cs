using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000B3 RID: 179
	[Serializable]
	public sealed class InsufficientExecutionStackException : SystemException
	{
		// Token: 0x06000BB4 RID: 2996 RVA: 0x0005BC68 File Offset: 0x00059E68
		// Note: this type is marked as 'beforefieldinit'.
		static InsufficientExecutionStackException()
		{
			Il2CppClassPointerStore<InsufficientExecutionStackException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "InsufficientExecutionStackException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InsufficientExecutionStackException>.NativeClassPtr);
			InsufficientExecutionStackException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsufficientExecutionStackException>.NativeClassPtr, 100665328);
			InsufficientExecutionStackException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InsufficientExecutionStackException>.NativeClassPtr, 100665329);
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0005BCC0 File Offset: 0x00059EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1308182, XrefRangeEnd = 1308185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InsufficientExecutionStackException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InsufficientExecutionStackException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InsufficientExecutionStackException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0005BCFC File Offset: 0x00059EFC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InsufficientExecutionStackException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InsufficientExecutionStackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InsufficientExecutionStackException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00004FF1 File Offset: 0x000031F1
		public InsufficientExecutionStackException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
