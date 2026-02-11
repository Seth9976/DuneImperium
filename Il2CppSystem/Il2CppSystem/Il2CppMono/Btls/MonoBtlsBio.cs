using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Btls
{
	// Token: 0x02000027 RID: 39
	public class MonoBtlsBio : MonoBtlsObject
	{
		// Token: 0x06000248 RID: 584 RVA: 0x00023BAC File Offset: 0x00021DAC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsBio()
		{
			Il2CppClassPointerStore<MonoBtlsBio>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsBio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsBio>.NativeClassPtr);
			MonoBtlsBio.NativeMethodInfoPtr__ctor_Internal_Void_BoringBioHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBio>.NativeClassPtr, 100663701);
			MonoBtlsBio.NativeMethodInfoPtr_get_Handle_FamOrAssem_get_BoringBioHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBio>.NativeClassPtr, 100663702);
			MonoBtlsBio.NativeMethodInfoPtr_mono_btls_bio_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBio>.NativeClassPtr, 100663703);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00023C18 File Offset: 0x00021E18
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsBio(MonoBtlsBio.BoringBioHandle handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsBio>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBio.NativeMethodInfoPtr__ctor_Internal_Void_BoringBioHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00023C64 File Offset: 0x00021E64
		public new unsafe MonoBtlsBio.BoringBioHandle Handle
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 429352, RefRangeEnd = 429358, XrefRangeStart = 429349, XrefRangeEnd = 429352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBio.NativeMethodInfoPtr_get_Handle_FamOrAssem_get_BoringBioHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsBio.BoringBioHandle>(intPtr3) : null;
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00023CA4 File Offset: 0x00021EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429358, XrefRangeEnd = 429360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_bio_free(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsBio.NativeMethodInfoPtr_mono_btls_bio_free_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002D83 File Offset: 0x00000F83
		public MonoBtlsBio(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BoringBioHandle_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_FamOrAssem_get_BoringBioHandle_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_bio_free_Private_Static_Void_IntPtr_0;

		// Token: 0x020002A6 RID: 678
		public class BoringBioHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06002ACB RID: 10955 RVA: 0x00012FA4 File Offset: 0x000111A4
			// Note: this type is marked as 'beforefieldinit'.
			static BoringBioHandle()
			{
				Il2CppClassPointerStore<MonoBtlsBio.BoringBioHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsBio>.NativeClassPtr, "BoringBioHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsBio.BoringBioHandle>.NativeClassPtr);
				MonoBtlsBio.BoringBioHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBio.BoringBioHandle>.NativeClassPtr, 100663705);
			}

			// Token: 0x06002ACC RID: 10956 RVA: 0x000BF088 File Offset: 0x000BD288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429346, XrefRangeEnd = 429349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsBio.BoringBioHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002ACD RID: 10957 RVA: 0x00012FD8 File Offset: 0x000111D8
			public BoringBioHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021BD RID: 8637
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}
	}
}
