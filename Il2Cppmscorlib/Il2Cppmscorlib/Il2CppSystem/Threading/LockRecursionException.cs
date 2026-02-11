using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000189 RID: 393
	[Serializable]
	public class LockRecursionException : Exception
	{
		// Token: 0x060019FD RID: 6653 RVA: 0x000A0458 File Offset: 0x0009E658
		// Note: this type is marked as 'beforefieldinit'.
		static LockRecursionException()
		{
			Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "LockRecursionException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr);
			LockRecursionException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr, 100667839);
			LockRecursionException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr, 100667840);
			LockRecursionException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr, 100667841);
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x000A04C4 File Offset: 0x0009E6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351576, XrefRangeEnd = 1351580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockRecursionException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockRecursionException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x000A0500 File Offset: 0x0009E700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351580, XrefRangeEnd = 1351584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockRecursionException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockRecursionException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x000A054C File Offset: 0x0009E74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351584, XrefRangeEnd = 1351588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockRecursionException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockRecursionException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockRecursionException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00008465 File Offset: 0x00006665
		public LockRecursionException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
