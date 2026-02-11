using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x02000049 RID: 73
	public sealed class SafePasswordHandle : SafeHandle
	{
		// Token: 0x060003F2 RID: 1010 RVA: 0x000353E8 File Offset: 0x000335E8
		// Note: this type is marked as 'beforefieldinit'.
		static SafePasswordHandle()
		{
			Il2CppClassPointerStore<SafePasswordHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafePasswordHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafePasswordHandle>.NativeClassPtr);
			SafePasswordHandle.NativeMethodInfoPtr_CreateHandle_Private_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePasswordHandle>.NativeClassPtr, 100663890);
			SafePasswordHandle.NativeMethodInfoPtr_FreeHandle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePasswordHandle>.NativeClassPtr, 100663891);
			SafePasswordHandle.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePasswordHandle>.NativeClassPtr, 100663892);
			SafePasswordHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePasswordHandle>.NativeClassPtr, 100663893);
			SafePasswordHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePasswordHandle>.NativeClassPtr, 100663894);
			SafePasswordHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePasswordHandle>.NativeClassPtr, 100663895);
			SafePasswordHandle.NativeMethodInfoPtr_Mono_DangerousGetString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafePasswordHandle>.NativeClassPtr, 100663896);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000354A4 File Offset: 0x000336A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281069, XrefRangeEnd = 1281073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr CreateHandle(string password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePasswordHandle.NativeMethodInfoPtr_CreateHandle_Private_IntPtr_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000354F4 File Offset: 0x000336F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281073, XrefRangeEnd = 1281077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePasswordHandle.NativeMethodInfoPtr_FreeHandle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00035528 File Offset: 0x00033728
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1281082, RefRangeEnd = 1281089, XrefRangeStart = 1281077, XrefRangeEnd = 1281082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafePasswordHandle(string password)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafePasswordHandle>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(password);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePasswordHandle.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00035574 File Offset: 0x00033774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281089, XrefRangeEnd = 1281095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePasswordHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000355B0 File Offset: 0x000337B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281095, XrefRangeEnd = 1281099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePasswordHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x000355F0 File Offset: 0x000337F0
		public unsafe override bool IsInvalid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1281099, XrefRangeEnd = 1281101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePasswordHandle.NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0003562C File Offset: 0x0003382C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1281105, RefRangeEnd = 1281109, XrefRangeStart = 1281101, XrefRangeEnd = 1281105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Mono_DangerousGetString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafePasswordHandle.NativeMethodInfoPtr_Mono_DangerousGetString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00003795 File Offset: 0x00001995
		public SafePasswordHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandle_Private_IntPtr_String_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_FreeHandle_Private_Void_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_Mono_DangerousGetString_Internal_String_0;
	}
}
