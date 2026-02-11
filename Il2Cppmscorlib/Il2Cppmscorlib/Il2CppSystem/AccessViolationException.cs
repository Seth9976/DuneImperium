using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000059 RID: 89
	[Serializable]
	public class AccessViolationException : SystemException
	{
		// Token: 0x0600059D RID: 1437 RVA: 0x0003E75C File Offset: 0x0003C95C
		// Note: this type is marked as 'beforefieldinit'.
		static AccessViolationException()
		{
			Il2CppClassPointerStore<AccessViolationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AccessViolationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessViolationException>.NativeClassPtr);
			AccessViolationException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessViolationException>.NativeClassPtr, 100664277);
			AccessViolationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessViolationException>.NativeClassPtr, 100664278);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0003E7B4 File Offset: 0x0003C9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1296736, XrefRangeEnd = 1296739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccessViolationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccessViolationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessViolationException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0003E7F0 File Offset: 0x0003C9F0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccessViolationException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccessViolationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessViolationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00003AE2 File Offset: 0x00001CE2
		public AccessViolationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
