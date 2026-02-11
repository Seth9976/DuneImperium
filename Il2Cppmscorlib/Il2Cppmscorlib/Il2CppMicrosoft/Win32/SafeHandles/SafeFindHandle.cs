using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x0200004B RID: 75
	public class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060003FF RID: 1023 RVA: 0x00035750 File Offset: 0x00033950
		// Note: this type is marked as 'beforefieldinit'.
		static SafeFindHandle()
		{
			Il2CppClassPointerStore<SafeFindHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeFindHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeFindHandle>.NativeClassPtr);
			SafeFindHandle.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFindHandle>.NativeClassPtr, 100663899);
			SafeFindHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFindHandle>.NativeClassPtr, 100663900);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000357A8 File Offset: 0x000339A8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 470438, RefRangeEnd = 470444, XrefRangeStart = 470438, XrefRangeEnd = 470444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeFindHandle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeFindHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeFindHandle.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000357E4 File Offset: 0x000339E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281113, XrefRangeEnd = 1281117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeFindHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000037A7 File Offset: 0x000019A7
		public SafeFindHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
	}
}
