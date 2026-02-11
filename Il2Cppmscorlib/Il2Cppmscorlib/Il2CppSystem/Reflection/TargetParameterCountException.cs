using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000430 RID: 1072
	[Serializable]
	public sealed class TargetParameterCountException : ApplicationException
	{
		// Token: 0x06003DAE RID: 15790 RVA: 0x00127D64 File Offset: 0x00125F64
		// Note: this type is marked as 'beforefieldinit'.
		static TargetParameterCountException()
		{
			Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "TargetParameterCountException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr);
			TargetParameterCountException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr, 100672564);
			TargetParameterCountException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr, 100672565);
			TargetParameterCountException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr, 100672566);
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x00127DD0 File Offset: 0x00125FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399620, XrefRangeEnd = 1399623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetParameterCountException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetParameterCountException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x00127E0C File Offset: 0x0012600C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1399623, XrefRangeEnd = 1399624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetParameterCountException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetParameterCountException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x00127E58 File Offset: 0x00126058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetParameterCountException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetParameterCountException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TargetParameterCountException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x0001698A File Offset: 0x00014B8A
		public TargetParameterCountException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003263 RID: 12899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003264 RID: 12900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04003265 RID: 12901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;
	}
}
