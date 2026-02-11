using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000074 RID: 116
	[Serializable]
	public class ArithmeticException : SystemException
	{
		// Token: 0x0600066C RID: 1644 RVA: 0x00042AE4 File Offset: 0x00040CE4
		// Note: this type is marked as 'beforefieldinit'.
		static ArithmeticException()
		{
			Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArithmeticException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr);
			ArithmeticException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr, 100664359);
			ArithmeticException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr, 100664360);
			ArithmeticException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr, 100664361);
			ArithmeticException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr, 100664362);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00042B64 File Offset: 0x00040D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1298771, XrefRangeEnd = 1298774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArithmeticException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArithmeticException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00042BA0 File Offset: 0x00040DA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1298775, RefRangeEnd = 1298779, XrefRangeStart = 1298774, XrefRangeEnd = 1298775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArithmeticException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArithmeticException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00042BEC File Offset: 0x00040DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1298780, RefRangeEnd = 1298781, XrefRangeStart = 1298779, XrefRangeEnd = 1298780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArithmeticException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArithmeticException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00042C4C File Offset: 0x00040E4C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArithmeticException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArithmeticException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArithmeticException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00003F82 File Offset: 0x00002182
		public ArithmeticException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
