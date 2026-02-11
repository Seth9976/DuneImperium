using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.Exceptions
{
	// Token: 0x02000010 RID: 16
	public class OperationException : Exception
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00009DA8 File Offset: 0x00007FA8
		// Note: this type is marked as 'beforefieldinit'.
		static OperationException()
		{
			Il2CppClassPointerStore<OperationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Exceptions", "OperationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OperationException>.NativeClassPtr);
			OperationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationException>.NativeClassPtr, 100663490);
			OperationException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationException>.NativeClassPtr, 100663491);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00009E00 File Offset: 0x00008000
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1137425, RefRangeEnd = 1137435, XrefRangeStart = 1137421, XrefRangeEnd = 1137425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationException(string message, Exception innerException = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00009E60 File Offset: 0x00008060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137435, XrefRangeEnd = 1137440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OperationException.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000283E File Offset: 0x00000A3E
		public OperationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
