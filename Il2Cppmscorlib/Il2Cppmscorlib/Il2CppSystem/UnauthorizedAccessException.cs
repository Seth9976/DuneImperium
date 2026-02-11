using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000100 RID: 256
	[Serializable]
	public class UnauthorizedAccessException : SystemException
	{
		// Token: 0x0600111D RID: 4381 RVA: 0x00076D08 File Offset: 0x00074F08
		// Note: this type is marked as 'beforefieldinit'.
		static UnauthorizedAccessException()
		{
			Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UnauthorizedAccessException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr);
			UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr, 100666313);
			UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr, 100666314);
			UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr, 100666315);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00076D74 File Offset: 0x00074F74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1327845, RefRangeEnd = 1327846, XrefRangeStart = 1327839, XrefRangeEnd = 1327845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnauthorizedAccessException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00076DB0 File Offset: 0x00074FB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1327850, RefRangeEnd = 1327856, XrefRangeStart = 1327846, XrefRangeEnd = 1327850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnauthorizedAccessException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00076DFC File Offset: 0x00074FFC
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 1318224, RefRangeEnd = 1318290, XrefRangeStart = 1318224, XrefRangeEnd = 1318290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnauthorizedAccessException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnauthorizedAccessException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnauthorizedAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00005E55 File Offset: 0x00004055
		public UnauthorizedAccessException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
