using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x0200004E RID: 78
	public class SafeHandleMinusOneIsInvalid : SafeHandle
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x00035A50 File Offset: 0x00033C50
		// Note: this type is marked as 'beforefieldinit'.
		static SafeHandleMinusOneIsInvalid()
		{
			Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeHandleMinusOneIsInvalid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr);
			SafeHandleMinusOneIsInvalid.NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr, 100663906);
			SafeHandleMinusOneIsInvalid.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr, 100663907);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00035AA8 File Offset: 0x00033CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1281126, RefRangeEnd = 1281127, XrefRangeStart = 1281124, XrefRangeEnd = 1281126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeHandleMinusOneIsInvalid(bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ownsHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandleMinusOneIsInvalid.NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00035AF0 File Offset: 0x00033CF0
		public unsafe override bool IsInvalid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281127, XrefRangeEnd = 1281129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SafeHandleMinusOneIsInvalid.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000037C2 File Offset: 0x000019C2
		public SafeHandleMinusOneIsInvalid(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0;
	}
}
