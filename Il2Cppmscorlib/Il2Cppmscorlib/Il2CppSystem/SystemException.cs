using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x020000ED RID: 237
	[Serializable]
	public class SystemException : Exception
	{
		// Token: 0x06000F2F RID: 3887 RVA: 0x0006CD78 File Offset: 0x0006AF78
		// Note: this type is marked as 'beforefieldinit'.
		static SystemException()
		{
			Il2CppClassPointerStore<SystemException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "SystemException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemException>.NativeClassPtr);
			SystemException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemException>.NativeClassPtr, 100665951);
			SystemException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemException>.NativeClassPtr, 100665952);
			SystemException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemException>.NativeClassPtr, 100665953);
			SystemException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemException>.NativeClassPtr, 100665954);
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0006CDF8 File Offset: 0x0006AFF8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1320890, RefRangeEnd = 1320895, XrefRangeStart = 1320884, XrefRangeEnd = 1320890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x0006CE34 File Offset: 0x0006B034
		[CallerCount(230)]
		[CachedScanResults(RefRangeStart = 1320899, RefRangeEnd = 1321129, XrefRangeStart = 1320895, XrefRangeEnd = 1320899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x0006CE80 File Offset: 0x0006B080
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1321133, RefRangeEnd = 1321169, XrefRangeStart = 1321129, XrefRangeEnd = 1321133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0006CEE0 File Offset: 0x0006B0E0
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 1318224, RefRangeEnd = 1318290, XrefRangeStart = 1318224, XrefRangeEnd = 1318290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00005A3D File Offset: 0x00003C3D
		public SystemException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C69 RID: 3177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C6A RID: 3178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C6B RID: 3179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000C6C RID: 3180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
