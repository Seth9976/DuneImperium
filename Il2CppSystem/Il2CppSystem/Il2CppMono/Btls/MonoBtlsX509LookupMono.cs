using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMono.Btls
{
	// Token: 0x02000041 RID: 65
	public class MonoBtlsX509LookupMono : MonoBtlsObject
	{
		// Token: 0x060003D5 RID: 981 RVA: 0x0002A900 File Offset: 0x00028B00
		// Note: this type is marked as 'beforefieldinit'.
		static MonoBtlsX509LookupMono()
		{
			Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509LookupMono");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr);
			MonoBtlsX509LookupMono.NativeFieldInfoPtr_gch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, "gch");
			MonoBtlsX509LookupMono.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, "instance");
			MonoBtlsX509LookupMono.NativeFieldInfoPtr_bySubjectFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, "bySubjectFunc");
			MonoBtlsX509LookupMono.NativeFieldInfoPtr_bySubjectFuncPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, "bySubjectFuncPtr");
			MonoBtlsX509LookupMono.NativeFieldInfoPtr_lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, "lookup");
			MonoBtlsX509LookupMono.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509LookupMonoHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, 100663994);
			MonoBtlsX509LookupMono.NativeMethodInfoPtr_mono_btls_x509_lookup_mono_new_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, 100663995);
			MonoBtlsX509LookupMono.NativeMethodInfoPtr_mono_btls_x509_lookup_mono_init_Private_Static_Void_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, 100663996);
			MonoBtlsX509LookupMono.NativeMethodInfoPtr_mono_btls_x509_lookup_mono_free_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, 100663997);
			MonoBtlsX509LookupMono.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, 100663998);
			MonoBtlsX509LookupMono.NativeMethodInfoPtr_Install_Internal_Void_MonoBtlsX509Lookup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, 100663999);
			MonoBtlsX509LookupMono.NativeMethodInfoPtr_AddCertificate_Protected_Void_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, 100664000);
			MonoBtlsX509LookupMono.NativeMethodInfoPtr_OnGetBySubject_Protected_Abstract_Virtual_New_MonoBtlsX509_MonoBtlsX509Name_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, 100664001);
			MonoBtlsX509LookupMono.NativeMethodInfoPtr_OnGetBySubject_Private_Static_Int32_IntPtr_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, 100664002);
			MonoBtlsX509LookupMono.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, 100664003);
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0002AA5C File Offset: 0x00028C5C
		public new unsafe MonoBtlsX509LookupMono.BoringX509LookupMonoHandle Handle
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 431847, RefRangeEnd = 431849, XrefRangeStart = 431844, XrefRangeEnd = 431847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509LookupMono.NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509LookupMonoHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509LookupMono.BoringX509LookupMonoHandle>(intPtr3) : null;
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0002AA9C File Offset: 0x00028C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431849, XrefRangeEnd = 431851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr mono_btls_x509_lookup_mono_new()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509LookupMono.NativeMethodInfoPtr_mono_btls_x509_lookup_mono_new_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0002AACC File Offset: 0x00028CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431851, XrefRangeEnd = 431853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void mono_btls_x509_lookup_mono_init(IntPtr handle, IntPtr instance, IntPtr by_subject_func)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref by_subject_func;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509LookupMono.NativeMethodInfoPtr_mono_btls_x509_lookup_mono_init_Private_Static_Void_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0002AB1C File Offset: 0x00028D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431853, XrefRangeEnd = 431855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int mono_btls_x509_lookup_mono_free(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509LookupMono.NativeMethodInfoPtr_mono_btls_x509_lookup_mono_free_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0002AB5C File Offset: 0x00028D5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431882, RefRangeEnd = 431884, XrefRangeStart = 431855, XrefRangeEnd = 431882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoBtlsX509LookupMono()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509LookupMono.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0002AB98 File Offset: 0x00028D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431884, XrefRangeEnd = 431890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Install(MonoBtlsX509Lookup lookup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509LookupMono.NativeMethodInfoPtr_Install_Internal_Void_MonoBtlsX509Lookup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0002ABDC File Offset: 0x00028DDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 431898, RefRangeEnd = 431899, XrefRangeStart = 431890, XrefRangeEnd = 431898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCertificate(MonoBtlsX509 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509LookupMono.NativeMethodInfoPtr_AddCertificate_Protected_Void_MonoBtlsX509_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0002AC20 File Offset: 0x00028E20
		[CallerCount(0)]
		public unsafe virtual MonoBtlsX509 OnGetBySubject(MonoBtlsX509Name name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509LookupMono.NativeMethodInfoPtr_OnGetBySubject_Protected_Abstract_Virtual_New_MonoBtlsX509_MonoBtlsX509Name_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr3) : null;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0002AC7C File Offset: 0x00028E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431899, XrefRangeEnd = 431922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int OnGetBySubject(IntPtr instance, IntPtr name_ptr, out IntPtr x509_ptr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instance;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name_ptr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &x509_ptr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509LookupMono.NativeMethodInfoPtr_OnGetBySubject_Private_Static_Int32_IntPtr_IntPtr_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0002ACD8 File Offset: 0x00028ED8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 431928, RefRangeEnd = 431930, XrefRangeStart = 431922, XrefRangeEnd = 431928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509LookupMono.NativeMethodInfoPtr_Close_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000033B0 File Offset: 0x000015B0
		public MonoBtlsX509LookupMono(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0002AD14 File Offset: 0x00028F14
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x000033B9 File Offset: 0x000015B9
		public unsafe GCHandle gch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMono.NativeFieldInfoPtr_gch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMono.NativeFieldInfoPtr_gch)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0002AD3C File Offset: 0x00028F3C
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x000033D4 File Offset: 0x000015D4
		public unsafe IntPtr instance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMono.NativeFieldInfoPtr_instance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMono.NativeFieldInfoPtr_instance)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0002AD64 File Offset: 0x00028F64
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000033EF File Offset: 0x000015EF
		public unsafe MonoBtlsX509LookupMono.BySubjectFunc bySubjectFunc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMono.NativeFieldInfoPtr_bySubjectFunc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509LookupMono.BySubjectFunc>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMono.NativeFieldInfoPtr_bySubjectFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0002AD94 File Offset: 0x00028F94
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x0000340E File Offset: 0x0000160E
		public unsafe IntPtr bySubjectFuncPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMono.NativeFieldInfoPtr_bySubjectFuncPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMono.NativeFieldInfoPtr_bySubjectFuncPtr)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0002ADBC File Offset: 0x00028FBC
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x00003429 File Offset: 0x00001629
		public unsafe MonoBtlsX509Lookup lookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMono.NativeFieldInfoPtr_lookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBtlsX509Lookup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBtlsX509LookupMono.NativeFieldInfoPtr_lookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_gch;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr_bySubjectFunc;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr_bySubjectFuncPtr;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr_lookup;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509LookupMonoHandle_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_lookup_mono_new_Private_Static_IntPtr_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_lookup_mono_init_Private_Static_Void_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_lookup_mono_free_Private_Static_Int32_IntPtr_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_Install_Internal_Void_MonoBtlsX509Lookup_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Protected_Void_MonoBtlsX509_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_OnGetBySubject_Protected_Abstract_Virtual_New_MonoBtlsX509_MonoBtlsX509Name_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_OnGetBySubject_Private_Static_Int32_IntPtr_IntPtr_byref_IntPtr_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_0;

		// Token: 0x020002B8 RID: 696
		public class BoringX509LookupMonoHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06002B17 RID: 11031 RVA: 0x0001343C File Offset: 0x0001163C
			// Note: this type is marked as 'beforefieldinit'.
			static BoringX509LookupMonoHandle()
			{
				Il2CppClassPointerStore<MonoBtlsX509LookupMono.BoringX509LookupMonoHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, "BoringX509LookupMonoHandle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509LookupMono.BoringX509LookupMonoHandle>.NativeClassPtr);
				MonoBtlsX509LookupMono.BoringX509LookupMonoHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMono.BoringX509LookupMonoHandle>.NativeClassPtr, 100664005);
			}

			// Token: 0x06002B18 RID: 11032 RVA: 0x000BF9F8 File Offset: 0x000BDBF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 431842, XrefRangeEnd = 431844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool ReleaseHandle()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBtlsX509LookupMono.BoringX509LookupMonoHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B19 RID: 11033 RVA: 0x00013470 File Offset: 0x00011670
			public BoringX509LookupMonoHandle(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021D9 RID: 8665
			private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
		}

		// Token: 0x020002B9 RID: 697
		public sealed class BySubjectFunc : MulticastDelegate
		{
			// Token: 0x06002B1A RID: 11034 RVA: 0x00013479 File Offset: 0x00011679
			// Note: this type is marked as 'beforefieldinit'.
			static BySubjectFunc()
			{
				Il2CppClassPointerStore<MonoBtlsX509LookupMono.BySubjectFunc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509LookupMono>.NativeClassPtr, "BySubjectFunc");
				MonoBtlsX509LookupMono.BySubjectFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMono.BySubjectFunc>.NativeClassPtr, 100664006);
				MonoBtlsX509LookupMono.BySubjectFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509LookupMono.BySubjectFunc>.NativeClassPtr, 100664007);
			}

			// Token: 0x06002B1B RID: 11035 RVA: 0x000BFA40 File Offset: 0x000BDC40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BySubjectFunc(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509LookupMono.BySubjectFunc>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509LookupMono.BySubjectFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B1C RID: 11036 RVA: 0x000BFA9C File Offset: 0x000BDC9C
			[CallerCount(0)]
			public unsafe int Invoke(IntPtr instance, IntPtr name, out IntPtr x509_ptr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref instance;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref name;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &x509_ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBtlsX509LookupMono.BySubjectFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_IntPtr_byref_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002B1D RID: 11037 RVA: 0x000134B7 File Offset: 0x000116B7
			public BySubjectFunc(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040021DA RID: 8666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040021DB RID: 8667
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_IntPtr_IntPtr_byref_IntPtr_0;
		}
	}
}
