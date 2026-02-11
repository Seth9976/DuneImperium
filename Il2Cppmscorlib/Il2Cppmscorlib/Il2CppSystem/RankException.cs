using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000DA RID: 218
	[Serializable]
	public class RankException : SystemException
	{
		// Token: 0x06000E1A RID: 3610 RVA: 0x00067B54 File Offset: 0x00065D54
		// Note: this type is marked as 'beforefieldinit'.
		static RankException()
		{
			Il2CppClassPointerStore<RankException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "RankException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankException>.NativeClassPtr);
			RankException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankException>.NativeClassPtr, 100665765);
			RankException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankException>.NativeClassPtr, 100665766);
			RankException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankException>.NativeClassPtr, 100665767);
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00067BC0 File Offset: 0x00065DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318762, XrefRangeEnd = 1318768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00067BFC File Offset: 0x00065DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318768, XrefRangeEnd = 1318772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00067C48 File Offset: 0x00065E48
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 1318224, RefRangeEnd = 1318290, XrefRangeStart = 1318224, XrefRangeEnd = 1318290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x000056AE File Offset: 0x000038AE
		public RankException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
