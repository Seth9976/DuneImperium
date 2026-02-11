using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004EC RID: 1260
	[Serializable]
	public class KeyNotFoundException : SystemException
	{
		// Token: 0x06004DB0 RID: 19888 RVA: 0x00168864 File Offset: 0x00166A64
		// Note: this type is marked as 'beforefieldinit'.
		static KeyNotFoundException()
		{
			Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "KeyNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr);
			KeyNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr, 100674968);
			KeyNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr, 100674969);
			KeyNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr, 100674970);
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x001688D0 File Offset: 0x00166AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1420602, RefRangeEnd = 1420603, XrefRangeStart = 1420599, XrefRangeEnd = 1420602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x0016890C File Offset: 0x00166B0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1420604, RefRangeEnd = 1420607, XrefRangeStart = 1420603, XrefRangeEnd = 1420604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyNotFoundException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x00168958 File Offset: 0x00166B58
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x0001C1BB File Offset: 0x0001A3BB
		public KeyNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003F86 RID: 16262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003F87 RID: 16263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003F88 RID: 16264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
