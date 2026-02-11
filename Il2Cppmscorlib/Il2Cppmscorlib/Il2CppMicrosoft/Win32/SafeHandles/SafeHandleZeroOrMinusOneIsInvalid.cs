using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x0200004D RID: 77
	public class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x00035968 File Offset: 0x00033B68
		// Note: this type is marked as 'beforefieldinit'.
		static SafeHandleZeroOrMinusOneIsInvalid()
		{
			Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeHandleZeroOrMinusOneIsInvalid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr);
			SafeHandleZeroOrMinusOneIsInvalid.NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr, 100663904);
			SafeHandleZeroOrMinusOneIsInvalid.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr, 100663905);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000359C0 File Offset: 0x00033BC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1281119, RefRangeEnd = 1281123, XrefRangeStart = 1281118, XrefRangeEnd = 1281119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ownsHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandleZeroOrMinusOneIsInvalid.NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00035A08 File Offset: 0x00033C08
		public unsafe override bool IsInvalid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281123, XrefRangeEnd = 1281124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandleZeroOrMinusOneIsInvalid.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000037B9 File Offset: 0x000019B9
		public SafeHandleZeroOrMinusOneIsInvalid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0;
	}
}
