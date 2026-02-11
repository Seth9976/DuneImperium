using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x0200004A RID: 74
	public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060003FB RID: 1019 RVA: 0x00035664 File Offset: 0x00033864
		// Note: this type is marked as 'beforefieldinit'.
		static SafeFileHandle()
		{
			Il2CppClassPointerStore<SafeFileHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeFileHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeFileHandle>.NativeClassPtr);
			SafeFileHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFileHandle>.NativeClassPtr, 100663897);
			SafeFileHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFileHandle>.NativeClassPtr, 100663898);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000356BC File Offset: 0x000338BC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1281059, RefRangeEnd = 1281069, XrefRangeStart = 1281059, XrefRangeEnd = 1281069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeFileHandle(IntPtr preexistingHandle, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeFileHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref preexistingHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFileHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00035714 File Offset: 0x00033914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281109, XrefRangeEnd = 1281113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFileHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000379E File Offset: 0x0000199E
		public SafeFileHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
	}
}
