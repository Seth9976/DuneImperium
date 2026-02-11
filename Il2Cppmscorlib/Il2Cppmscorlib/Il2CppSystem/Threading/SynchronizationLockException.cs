using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200018E RID: 398
	[Serializable]
	public class SynchronizationLockException : SystemException
	{
		// Token: 0x06001A17 RID: 6679 RVA: 0x000A08D0 File Offset: 0x0009EAD0
		// Note: this type is marked as 'beforefieldinit'.
		static SynchronizationLockException()
		{
			Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SynchronizationLockException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr);
			SynchronizationLockException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr, 100667849);
			SynchronizationLockException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr, 100667850);
			SynchronizationLockException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr, 100667851);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x000A093C File Offset: 0x0009EB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351621, XrefRangeEnd = 1351624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SynchronizationLockException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationLockException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x000A0978 File Offset: 0x0009EB78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1351625, RefRangeEnd = 1351632, XrefRangeStart = 1351624, XrefRangeEnd = 1351625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SynchronizationLockException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationLockException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x000A09C4 File Offset: 0x0009EBC4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SynchronizationLockException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationLockException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationLockException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00008519 File Offset: 0x00006719
		public SynchronizationLockException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
