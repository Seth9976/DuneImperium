using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000C2 RID: 194
	[Serializable]
	public class MemberAccessException : SystemException
	{
		// Token: 0x06000CC1 RID: 3265 RVA: 0x00060D50 File Offset: 0x0005EF50
		// Note: this type is marked as 'beforefieldinit'.
		static MemberAccessException()
		{
			Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MemberAccessException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr);
			MemberAccessException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr, 100665531);
			MemberAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr, 100665532);
			MemberAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr, 100665533);
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00060DBC File Offset: 0x0005EFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1311065, XrefRangeEnd = 1311068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberAccessException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberAccessException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00060DF8 File Offset: 0x0005EFF8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1311069, RefRangeEnd = 1311078, XrefRangeStart = 1311068, XrefRangeEnd = 1311069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberAccessException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberAccessException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00060E44 File Offset: 0x0005F044
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberAccessException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberAccessException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberAccessException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x000051FE File Offset: 0x000033FE
		public MemberAccessException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
