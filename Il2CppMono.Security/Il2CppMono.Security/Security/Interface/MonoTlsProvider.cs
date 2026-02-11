using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Authentication;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x0200002A RID: 42
	public class MonoTlsProvider : Object
	{
		// Token: 0x06000247 RID: 583 RVA: 0x0000CB74 File Offset: 0x0000AD74
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsProvider()
		{
			Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "MonoTlsProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr);
			MonoTlsProvider.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663634);
			MonoTlsProvider.NativeMethodInfoPtr_get_ID_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663635);
			MonoTlsProvider.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663636);
			MonoTlsProvider.NativeMethodInfoPtr_get_SupportsSslStream_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663637);
			MonoTlsProvider.NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663638);
			MonoTlsProvider.NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663639);
			MonoTlsProvider.NativeMethodInfoPtr_get_SupportedProtocols_Public_Abstract_Virtual_New_get_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663640);
			MonoTlsProvider.NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663641);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000CC44 File Offset: 0x0000AE44
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProvider.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0000CC80 File Offset: 0x0000AE80
		public unsafe virtual Guid ID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_ID_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0000CCC8 File Offset: 0x0000AEC8
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000CD0C File Offset: 0x0000AF0C
		public unsafe virtual bool SupportsSslStream
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_SupportsSslStream_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000CD54 File Offset: 0x0000AF54
		public unsafe virtual bool SupportsConnectionInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		public unsafe virtual bool SupportsMonoExtensions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0000CDE4 File Offset: 0x0000AFE4
		public unsafe virtual SslProtocols SupportedProtocols
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_SupportedProtocols_Public_Abstract_Virtual_New_get_SslProtocols_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000CE2C File Offset: 0x0000B02C
		public unsafe virtual bool SupportsCleanShutdown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002F85 File Offset: 0x00001185
		public MonoTlsProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsSslStream_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportedProtocols_Public_Abstract_Virtual_New_get_SslProtocols_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Abstract_Virtual_New_get_Boolean_0;
	}
}
