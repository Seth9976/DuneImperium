using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x02000003 RID: 3
	public class SystemDependencyProvider : Object
	{
		// Token: 0x06000014 RID: 20 RVA: 0x0001AC4C File Offset: 0x00018E4C
		// Note: this type is marked as 'beforefieldinit'.
		static SystemDependencyProvider()
		{
			Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono", "SystemDependencyProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr);
			SystemDependencyProvider.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, "instance");
			SystemDependencyProvider.NativeFieldInfoPtr_syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, "syncRoot");
			SystemDependencyProvider.NativeFieldInfoPtr__CertificateProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, "<CertificateProvider>k__BackingField");
			SystemDependencyProvider.NativeMethodInfoPtr_get_Instance_Public_Static_get_SystemDependencyProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, 100663307);
			SystemDependencyProvider.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, 100663308);
			SystemDependencyProvider.NativeMethodInfoPtr_Mono_ISystemDependencyProvider_get_CertificateProvider_Private_Virtual_Final_New_get_ISystemCertificateProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, 100663309);
			SystemDependencyProvider.NativeMethodInfoPtr_get_CertificateProvider_Public_get_SystemCertificateProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, 100663310);
			SystemDependencyProvider.NativeMethodInfoPtr_get_X509Pal_Public_get_X509PalImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, 100663311);
			SystemDependencyProvider.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr, 100663312);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0001AD30 File Offset: 0x00018F30
		public unsafe static SystemDependencyProvider Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426730, XrefRangeEnd = 426735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemDependencyProvider.NativeMethodInfoPtr_get_Instance_Public_Static_get_SystemDependencyProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SystemDependencyProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0001AD64 File Offset: 0x00018F64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 426764, RefRangeEnd = 426767, XrefRangeStart = 426735, XrefRangeEnd = 426764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemDependencyProvider.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000017 RID: 23 RVA: 0x0001AD8C File Offset: 0x00018F8C
		public unsafe virtual ISystemCertificateProvider Mono.ISystemDependencyProvider.CertificateProvider
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemDependencyProvider.NativeMethodInfoPtr_Mono_ISystemDependencyProvider_get_CertificateProvider_Private_Virtual_Final_New_get_ISystemCertificateProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISystemCertificateProvider>(intPtr3) : null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0001ADCC File Offset: 0x00018FCC
		public unsafe SystemCertificateProvider CertificateProvider
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemDependencyProvider.NativeMethodInfoPtr_get_CertificateProvider_Public_get_SystemCertificateProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SystemCertificateProvider>(intPtr3) : null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0001AE0C File Offset: 0x0001900C
		public unsafe X509PalImpl X509Pal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426767, XrefRangeEnd = 426772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemDependencyProvider.NativeMethodInfoPtr_get_X509Pal_Public_get_X509PalImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509PalImpl>(intPtr3) : null;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0001AE4C File Offset: 0x0001904C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426772, XrefRangeEnd = 426782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SystemDependencyProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemDependencyProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SystemDependencyProvider.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000209D File Offset: 0x0000029D
		public SystemDependencyProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0001AE88 File Offset: 0x00019088
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020A6 File Offset: 0x000002A6
		public unsafe static SystemDependencyProvider instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SystemDependencyProvider.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SystemDependencyProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemDependencyProvider.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0001AEB0 File Offset: 0x000190B0
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000020B8 File Offset: 0x000002B8
		public unsafe static Object syncRoot
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SystemDependencyProvider.NativeFieldInfoPtr_syncRoot, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SystemDependencyProvider.NativeFieldInfoPtr_syncRoot, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0001AED8 File Offset: 0x000190D8
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000020CA File Offset: 0x000002CA
		public unsafe SystemCertificateProvider _CertificateProvider_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemDependencyProvider.NativeFieldInfoPtr__CertificateProvider_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SystemCertificateProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SystemDependencyProvider.NativeFieldInfoPtr__CertificateProvider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_syncRoot;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr__CertificateProvider_k__BackingField;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_SystemDependencyProvider_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_Mono_ISystemDependencyProvider_get_CertificateProvider_Private_Virtual_Final_New_get_ISystemCertificateProvider_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_CertificateProvider_Public_get_SystemCertificateProvider_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_X509Pal_Public_get_X509PalImpl_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
	}
}
