using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000F0 RID: 240
	[Serializable]
	public class InvalidEnumArgumentException : ArgumentException
	{
		// Token: 0x06000F91 RID: 3985 RVA: 0x00056A5C File Offset: 0x00054C5C
		// Note: this type is marked as 'beforefieldinit'.
		static InvalidEnumArgumentException()
		{
			Il2CppClassPointerStore<InvalidEnumArgumentException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "InvalidEnumArgumentException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidEnumArgumentException>.NativeClassPtr);
			InvalidEnumArgumentException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidEnumArgumentException>.NativeClassPtr, 100665542);
			InvalidEnumArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidEnumArgumentException>.NativeClassPtr, 100665543);
			InvalidEnumArgumentException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidEnumArgumentException>.NativeClassPtr, 100665544);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00056AC8 File Offset: 0x00054CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456362, XrefRangeEnd = 456363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidEnumArgumentException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidEnumArgumentException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidEnumArgumentException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00056B04 File Offset: 0x00054D04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 456364, RefRangeEnd = 456365, XrefRangeStart = 456363, XrefRangeEnd = 456364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidEnumArgumentException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidEnumArgumentException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidEnumArgumentException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00056B50 File Offset: 0x00054D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456365, XrefRangeEnd = 456366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidEnumArgumentException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidEnumArgumentException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidEnumArgumentException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000079E9 File Offset: 0x00005BE9
		public InvalidEnumArgumentException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
