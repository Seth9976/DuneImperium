using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x02000048 RID: 72
	public sealed class SafeRegistryHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x000352AC File Offset: 0x000334AC
		// Note: this type is marked as 'beforefieldinit'.
		static SafeRegistryHandle()
		{
			Il2CppClassPointerStore<SafeRegistryHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeRegistryHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeRegistryHandle>.NativeClassPtr);
			SafeRegistryHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeRegistryHandle>.NativeClassPtr, 100663887);
			SafeRegistryHandle.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeRegistryHandle>.NativeClassPtr, 100663888);
			SafeRegistryHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeRegistryHandle>.NativeClassPtr, 100663889);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00035318 File Offset: 0x00033518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281057, XrefRangeEnd = 1281058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeRegistryHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00035354 File Offset: 0x00033554
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 470438, RefRangeEnd = 470444, XrefRangeStart = 470438, XrefRangeEnd = 470444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeRegistryHandle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeRegistryHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeRegistryHandle.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00035390 File Offset: 0x00033590
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1281059, RefRangeEnd = 1281069, XrefRangeStart = 1281058, XrefRangeEnd = 1281059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeRegistryHandle(IntPtr preexistingHandle, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeRegistryHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref preexistingHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeRegistryHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000378C File Offset: 0x0000198C
		public SafeRegistryHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;
	}
}
