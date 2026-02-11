using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMono.Btls
{
	// Token: 0x02000040 RID: 64
	public class MonoBtlsX509Lookup : MonoBtlsObject
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x0002A360 File Offset: 0x00028560
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsX509Lookup()
		{
			Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509Lookup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr);
			MonoBtlsX509Lookup.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, "store");
			MonoBtlsX509Lookup.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, "type");
			MonoBtlsX509Lookup.NativeFieldInfoPtr_monoLookups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, "monoLookups");
			MonoBtlsX509Lookup.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509LookupHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663979);
			MonoBtlsX509Lookup.NativeMethodInfoPtr_mono_btls_x509_lookup_new_Private_Static_IntPtr_IntPtr_MonoBtlsX509LookupType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663980);
			MonoBtlsX509Lookup.NativeMethodInfoPtr_mono_btls_x509_lookup_add_dir_Private_Static_Int32_IntPtr_IntPtr_MonoBtlsX509FileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663981);
			MonoBtlsX509Lookup.NativeMethodInfoPtr_mono_btls_x509_lookup_add_mono_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663982);
			MonoBtlsX509Lookup.NativeMethodInfoPtr_mono_btls_x509_lookup_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663983);
			MonoBtlsX509Lookup.NativeMethodInfoPtr_mono_btls_x509_lookup_peek_lookup_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663984);
			MonoBtlsX509Lookup.NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509LookupHandle_MonoBtlsX509Store_MonoBtlsX509LookupType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663985);
			MonoBtlsX509Lookup.NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509Store_MonoBtlsX509LookupType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663986);
			MonoBtlsX509Lookup.NativeMethodInfoPtr_GetNativeLookup_Internal_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663987);
			MonoBtlsX509Lookup.NativeMethodInfoPtr_AddDirectory_Public_Void_String_MonoBtlsX509FileType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663988);
			MonoBtlsX509Lookup.NativeMethodInfoPtr_AddMono_Internal_Void_MonoBtlsX509LookupMono_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663989);
			MonoBtlsX509Lookup.NativeMethodInfoPtr_AddCertificate_Internal_Void_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663990);
			MonoBtlsX509Lookup.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, 100663991);
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0002A4D0 File Offset: 0x000286D0
		public new unsafe MonoBtlsX509Lookup.BoringX509LookupHandle Handle
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 431727, RefRangeEnd = 431732, XrefRangeStart = 431724, XrefRangeEnd = 431727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Lookup.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509LookupHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Lookup.BoringX509LookupHandle>(intPtr3) : null;
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0002A510 File Offset: 0x00028710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431732, XrefRangeEnd = 431734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref store;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Lookup.NativeMethodInfoPtr_mono_btls_x509_lookup_new_Private_Static_IntPtr_IntPtr_MonoBtlsX509LookupType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0002A55C File Offset: 0x0002875C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431734, XrefRangeEnd = 431736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_lookup_add_dir(IntPtr handle, IntPtr dir, MonoBtlsX509FileType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Lookup.NativeMethodInfoPtr_mono_btls_x509_lookup_add_dir_Private_Static_Int32_IntPtr_IntPtr_MonoBtlsX509FileType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0002A5B8 File Offset: 0x000287B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431736, XrefRangeEnd = 431738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref monoLookup;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Lookup.NativeMethodInfoPtr_mono_btls_x509_lookup_add_mono_Private_Static_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0002A604 File Offset: 0x00028804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431738, XrefRangeEnd = 431740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_x509_lookup_free(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Lookup.NativeMethodInfoPtr_mono_btls_x509_lookup_free_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0002A638 File Offset: 0x00028838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431740, XrefRangeEnd = 431742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_lookup_peek_lookup(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Lookup.NativeMethodInfoPtr_mono_btls_x509_lookup_peek_lookup_Private_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0002A678 File Offset: 0x00028878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431742, XrefRangeEnd = 431750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MonoBtlsX509Lookup.BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Lookup.NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509LookupHandle_MonoBtlsX509Store_MonoBtlsX509LookupType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Lookup.BoringX509LookupHandle>(intPtr3) : null;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0002A6CC File Offset: 0x000288CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 431760, RefRangeEnd = 431763, XrefRangeStart = 431750, XrefRangeEnd = 431760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509Lookup(MonoBtlsX509Store store, MonoBtlsX509LookupType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Lookup.NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509Store_MonoBtlsX509LookupType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0002A728 File Offset: 0x00028928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431763, XrefRangeEnd = 431766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetNativeLookup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Lookup.NativeMethodInfoPtr_GetNativeLookup_Internal_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0002A764 File Offset: 0x00028964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431782, RefRangeEnd = 431783, XrefRangeStart = 431766, XrefRangeEnd = 431782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDirectory(string dir, MonoBtlsX509FileType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Lookup.NativeMethodInfoPtr_AddDirectory_Public_Void_String_MonoBtlsX509FileType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0002A7B4 File Offset: 0x000289B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431814, RefRangeEnd = 431815, XrefRangeStart = 431783, XrefRangeEnd = 431814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMono(MonoBtlsX509LookupMono monoLookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(monoLookup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Lookup.NativeMethodInfoPtr_AddMono_Internal_Void_MonoBtlsX509LookupMono_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0002A7F8 File Offset: 0x000289F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431815, XrefRangeEnd = 431823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCertificate(MonoBtlsX509 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509Lookup.NativeMethodInfoPtr_AddCertificate_Internal_Void_MonoBtlsX509_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0002A83C File Offset: 0x00028A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431823, XrefRangeEnd = 431842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509Lookup.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000334E File Offset: 0x0000154E
		public MonoBtlsX509Lookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0002A878 File Offset: 0x00028A78
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00003357 File Offset: 0x00001557
		public unsafe MonoBtlsX509Store store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509Lookup.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Store>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509Lookup.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x0002A8A8 File Offset: 0x00028AA8
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x00003376 File Offset: 0x00001576
		public unsafe MonoBtlsX509LookupType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509Lookup.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509Lookup.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0002A8D0 File Offset: 0x00028AD0
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00003391 File Offset: 0x00001591
		public unsafe List<MonoBtlsX509LookupMono> monoLookups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509Lookup.NativeFieldInfoPtr_monoLookups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MonoBtlsX509LookupMono>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509Lookup.NativeFieldInfoPtr_monoLookups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeFieldInfoPtr_monoLookups;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509LookupHandle_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_lookup_new_Private_Static_IntPtr_IntPtr_MonoBtlsX509LookupType_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_lookup_add_dir_Private_Static_Int32_IntPtr_IntPtr_MonoBtlsX509FileType_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_lookup_add_mono_Private_Static_Int32_IntPtr_IntPtr_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_lookup_free_Private_Static_Void_IntPtr_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_lookup_peek_lookup_Private_Static_IntPtr_IntPtr_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509LookupHandle_MonoBtlsX509Store_MonoBtlsX509LookupType_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_MonoBtlsX509Store_MonoBtlsX509LookupType_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeLookup_Internal_IntPtr_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_AddDirectory_Public_Void_String_MonoBtlsX509FileType_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_AddMono_Internal_Void_MonoBtlsX509LookupMono_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Internal_Void_MonoBtlsX509_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_0;

		// Token: 0x020002B7 RID: 695
		public class BoringX509LookupHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06002B14 RID: 11028 RVA: 0x000133FF File Offset: 0x000115FF
			// Note: this type is marked as 'beforefieldinit'.
			static BoringX509LookupHandle()
			{
				Il2CppClassPointerStore<MonoBtlsX509Lookup.BoringX509LookupHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509Lookup>.NativeClassPtr, "BoringX509LookupHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509Lookup.BoringX509LookupHandle>.NativeClassPtr);
				MonoBtlsX509Lookup.BoringX509LookupHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Lookup.BoringX509LookupHandle>.NativeClassPtr, 100663993);
			}

			// Token: 0x06002B15 RID: 11029 RVA: 0x000BF9B0 File Offset: 0x000BDBB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431722, XrefRangeEnd = 431724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509Lookup.BoringX509LookupHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B16 RID: 11030 RVA: 0x00013433 File Offset: 0x00011633
			public BoringX509LookupHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021D8 RID: 8664
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}
	}
}
