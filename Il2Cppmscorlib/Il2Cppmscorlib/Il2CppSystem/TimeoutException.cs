using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000F2 RID: 242
	[Serializable]
	public class TimeoutException : SystemException
	{
		// Token: 0x06000F9B RID: 3995 RVA: 0x0006E4BC File Offset: 0x0006C6BC
		// Note: this type is marked as 'beforefieldinit'.
		static TimeoutException()
		{
			Il2CppClassPointerStore<TimeoutException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeoutException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr);
			TimeoutException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr, 100666006);
			TimeoutException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr, 100666007);
			TimeoutException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr, 100666008);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0006E528 File Offset: 0x0006C728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1321547, RefRangeEnd = 1321548, XrefRangeStart = 1321541, XrefRangeEnd = 1321547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeoutException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeoutException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0006E564 File Offset: 0x0006C764
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1321552, RefRangeEnd = 1321556, XrefRangeStart = 1321548, XrefRangeEnd = 1321552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeoutException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeoutException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0006E5B0 File Offset: 0x0006C7B0
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 1318224, RefRangeEnd = 1318290, XrefRangeStart = 1318224, XrefRangeEnd = 1318290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeoutException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeoutException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeoutException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00005C19 File Offset: 0x00003E19
		public TimeoutException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CB7 RID: 3255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CB8 RID: 3256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
