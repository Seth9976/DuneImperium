using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x02000047 RID: 71
	public sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060003E9 RID: 1001 RVA: 0x000351DC File Offset: 0x000333DC
		// Note: this type is marked as 'beforefieldinit'.
		static SafeLibraryHandle()
		{
			Il2CppClassPointerStore<SafeLibraryHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeLibraryHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeLibraryHandle>.NativeClassPtr);
			SafeLibraryHandle.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeLibraryHandle>.NativeClassPtr, 100663885);
			SafeLibraryHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeLibraryHandle>.NativeClassPtr, 100663886);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00035234 File Offset: 0x00033434
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 470438, RefRangeEnd = 470444, XrefRangeStart = 470438, XrefRangeEnd = 470444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeLibraryHandle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeLibraryHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeLibraryHandle.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00035270 File Offset: 0x00033470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281056, XrefRangeEnd = 1281057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeLibraryHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00003783 File Offset: 0x00001983
		public SafeLibraryHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
	}
}
