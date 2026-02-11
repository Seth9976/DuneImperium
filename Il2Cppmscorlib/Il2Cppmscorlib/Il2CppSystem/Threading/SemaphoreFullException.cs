using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200018C RID: 396
	[Serializable]
	public class SemaphoreFullException : SystemException
	{
		// Token: 0x06001A0C RID: 6668 RVA: 0x000A06E8 File Offset: 0x0009E8E8
		// Note: this type is marked as 'beforefieldinit'.
		static SemaphoreFullException()
		{
			Il2CppClassPointerStore<SemaphoreFullException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SemaphoreFullException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemaphoreFullException>.NativeClassPtr);
			SemaphoreFullException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreFullException>.NativeClassPtr, 100667845);
			SemaphoreFullException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreFullException>.NativeClassPtr, 100667846);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x000A0740 File Offset: 0x0009E940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351618, XrefRangeEnd = 1351621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreFullException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreFullException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreFullException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x000A077C File Offset: 0x0009E97C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreFullException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreFullException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreFullException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x000084E0 File Offset: 0x000066E0
		public SemaphoreFullException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
