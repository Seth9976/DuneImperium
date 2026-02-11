using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000D8 RID: 216
	[Serializable]
	public class PlatformNotSupportedException : NotSupportedException
	{
		// Token: 0x06000DF8 RID: 3576 RVA: 0x00067440 File Offset: 0x00065640
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformNotSupportedException()
		{
			Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "PlatformNotSupportedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr);
			PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr, 100665750);
			PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr, 100665751);
			PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr, 100665752);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x000674AC File Offset: 0x000656AC
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 1318481, RefRangeEnd = 1318689, XrefRangeStart = 1318478, XrefRangeEnd = 1318481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformNotSupportedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x000674E8 File Offset: 0x000656E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1318690, RefRangeEnd = 1318691, XrefRangeStart = 1318689, XrefRangeEnd = 1318690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformNotSupportedException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00067534 File Offset: 0x00065734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformNotSupportedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformNotSupportedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformNotSupportedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x000055F9 File Offset: 0x000037F9
		public PlatformNotSupportedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
