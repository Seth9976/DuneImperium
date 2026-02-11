using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200008A RID: 138
	[Serializable]
	public class DivideByZeroException : ArithmeticException
	{
		// Token: 0x060009B1 RID: 2481 RVA: 0x00051CC8 File Offset: 0x0004FEC8
		// Note: this type is marked as 'beforefieldinit'.
		static DivideByZeroException()
		{
			Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DivideByZeroException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr);
			DivideByZeroException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr, 100664997);
			DivideByZeroException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr, 100664998);
			DivideByZeroException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr, 100664999);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00051D34 File Offset: 0x0004FF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1304253, XrefRangeEnd = 1304256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DivideByZeroException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivideByZeroException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00051D70 File Offset: 0x0004FF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1304256, XrefRangeEnd = 1304257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DivideByZeroException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivideByZeroException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00051DBC File Offset: 0x0004FFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DivideByZeroException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivideByZeroException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00004679 File Offset: 0x00002879
		public DivideByZeroException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
