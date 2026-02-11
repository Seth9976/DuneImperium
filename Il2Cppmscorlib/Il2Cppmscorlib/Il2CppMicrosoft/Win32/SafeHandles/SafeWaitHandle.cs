using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x0200004C RID: 76
	public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06000403 RID: 1027 RVA: 0x0003582C File Offset: 0x00033A2C
		// Note: this type is marked as 'beforefieldinit'.
		static SafeWaitHandle()
		{
			Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeWaitHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr);
			SafeWaitHandle.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr, 100663901);
			SafeWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr, 100663902);
			SafeWaitHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr, 100663903);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00035898 File Offset: 0x00033A98
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 470438, RefRangeEnd = 470444, XrefRangeStart = 470438, XrefRangeEnd = 470444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeWaitHandle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeWaitHandle.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000358D4 File Offset: 0x00033AD4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1281059, RefRangeEnd = 1281069, XrefRangeStart = 1281059, XrefRangeEnd = 1281069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeWaitHandle(IntPtr existingHandle, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeWaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref existingHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0003592C File Offset: 0x00033B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281117, XrefRangeEnd = 1281118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeWaitHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000037B0 File Offset: 0x000019B0
		public SafeWaitHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
	}
}
