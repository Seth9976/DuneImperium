using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000030 RID: 48
	[Serializable]
	public class InControlException : Exception
	{
		// Token: 0x06000397 RID: 919 RVA: 0x00014BFC File Offset: 0x00012DFC
		// Note: this type is marked as 'beforefieldinit'.
		static InControlException()
		{
			Il2CppClassPointerStore<InControlException>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "InControlException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InControlException>.NativeClassPtr);
			InControlException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlException>.NativeClassPtr, 100663786);
			InControlException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlException>.NativeClassPtr, 100663787);
			InControlException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InControlException>.NativeClassPtr, 100663788);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00014C68 File Offset: 0x00012E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773662, XrefRangeEnd = 773666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InControlException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InControlException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00014CA4 File Offset: 0x00012EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 773670, RefRangeEnd = 773671, XrefRangeStart = 773666, XrefRangeEnd = 773670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InControlException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InControlException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00014CF0 File Offset: 0x00012EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773671, XrefRangeEnd = 773675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InControlException(string message, Exception inner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InControlException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InControlException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000352E File Offset: 0x0000172E
		public InControlException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;
	}
}
