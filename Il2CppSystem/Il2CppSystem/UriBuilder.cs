using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000059 RID: 89
	public class UriBuilder : Object
	{
		// Token: 0x06000505 RID: 1285 RVA: 0x0002F524 File Offset: 0x0002D724
		// Note: this type is marked as 'beforefieldinit'.
		static UriBuilder()
		{
			Il2CppClassPointerStore<UriBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "UriBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr);
			UriBuilder.NativeFieldInfoPtr__changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_changed");
			UriBuilder.NativeFieldInfoPtr__fragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_fragment");
			UriBuilder.NativeFieldInfoPtr__host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_host");
			UriBuilder.NativeFieldInfoPtr__password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_password");
			UriBuilder.NativeFieldInfoPtr__path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_path");
			UriBuilder.NativeFieldInfoPtr__port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_port");
			UriBuilder.NativeFieldInfoPtr__query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_query");
			UriBuilder.NativeFieldInfoPtr__scheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_scheme");
			UriBuilder.NativeFieldInfoPtr__schemeDelimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_schemeDelimiter");
			UriBuilder.NativeFieldInfoPtr__uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_uri");
			UriBuilder.NativeFieldInfoPtr__username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, "_username");
			UriBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100664182);
			UriBuilder.NativeMethodInfoPtr__ctor_Public_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100664183);
			UriBuilder.NativeMethodInfoPtr_Init_Private_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100664184);
			UriBuilder.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100664185);
			UriBuilder.NativeMethodInfoPtr_get_Query_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100664186);
			UriBuilder.NativeMethodInfoPtr_set_Query_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100664187);
			UriBuilder.NativeMethodInfoPtr_get_Uri_Public_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100664188);
			UriBuilder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100664189);
			UriBuilder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100664190);
			UriBuilder.NativeMethodInfoPtr_SetFieldsFromUri_Private_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100664191);
			UriBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr, 100664192);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0002F70C File Offset: 0x0002D90C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433740, RefRangeEnd = 433741, XrefRangeStart = 433699, XrefRangeEnd = 433740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriBuilder(string uri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0002F758 File Offset: 0x0002D958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433775, RefRangeEnd = 433776, XrefRangeStart = 433741, XrefRangeEnd = 433775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriBuilder(Uri uri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriBuilder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr__ctor_Public_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0002F7A4 File Offset: 0x0002D9A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 433806, RefRangeEnd = 433808, XrefRangeStart = 433776, XrefRangeEnd = 433806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr_Init_Private_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000162 RID: 354
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x0002F7E8 File Offset: 0x0002D9E8
		public unsafe string Path
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 433816, RefRangeEnd = 433817, XrefRangeStart = 433808, XrefRangeEnd = 433816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0002F82C File Offset: 0x0002DA2C
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x0002F864 File Offset: 0x0002DA64
		public unsafe string Query
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr_get_Query_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 433824, RefRangeEnd = 433826, XrefRangeStart = 433817, XrefRangeEnd = 433824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr_set_Query_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0002F8A8 File Offset: 0x0002DAA8
		public unsafe Uri Uri
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 433832, RefRangeEnd = 433836, XrefRangeStart = 433826, XrefRangeEnd = 433832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr_get_Uri_Public_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0002F8E8 File Offset: 0x0002DAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433836, XrefRangeEnd = 433837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object rparam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rparam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriBuilder.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0002F940 File Offset: 0x0002DB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433837, XrefRangeEnd = 433839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriBuilder.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0002F988 File Offset: 0x0002DB88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 433862, RefRangeEnd = 433864, XrefRangeStart = 433839, XrefRangeEnd = 433862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFieldsFromUri(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriBuilder.NativeMethodInfoPtr_SetFieldsFromUri_Private_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0002F9CC File Offset: 0x0002DBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433864, XrefRangeEnd = 433932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriBuilder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00003A65 File Offset: 0x00001C65
		public UriBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0002FA10 File Offset: 0x0002DC10
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00003A6E File Offset: 0x00001C6E
		public unsafe bool _changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__changed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__changed)) = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x0002FA38 File Offset: 0x0002DC38
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00003A89 File Offset: 0x00001C89
		public unsafe string _fragment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__fragment);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__fragment), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0002FA60 File Offset: 0x0002DC60
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00003AA8 File Offset: 0x00001CA8
		public unsafe string _host
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__host);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__host), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0002FA88 File Offset: 0x0002DC88
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00003AC7 File Offset: 0x00001CC7
		public unsafe string _password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0002FAB0 File Offset: 0x0002DCB0
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00003AE6 File Offset: 0x00001CE6
		public unsafe string _path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0002FAD8 File Offset: 0x0002DCD8
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00003B05 File Offset: 0x00001D05
		public unsafe int _port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__port)) = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x0002FB00 File Offset: 0x0002DD00
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00003B20 File Offset: 0x00001D20
		public unsafe string _query
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__query);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__query), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0002FB28 File Offset: 0x0002DD28
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00003B3F File Offset: 0x00001D3F
		public unsafe string _scheme
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__scheme);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__scheme), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x0002FB50 File Offset: 0x0002DD50
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00003B5E File Offset: 0x00001D5E
		public unsafe string _schemeDelimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__schemeDelimiter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__schemeDelimiter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0002FB78 File Offset: 0x0002DD78
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00003B7D File Offset: 0x00001D7D
		public unsafe Uri _uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__uri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__uri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x0002FBA8 File Offset: 0x0002DDA8
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00003B9C File Offset: 0x00001D9C
		public unsafe string _username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriBuilder.NativeFieldInfoPtr__username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeFieldInfoPtr__changed;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeFieldInfoPtr__fragment;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeFieldInfoPtr__host;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeFieldInfoPtr__password;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr__path;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr__port;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeFieldInfoPtr__query;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeFieldInfoPtr__scheme;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeFieldInfoPtr__schemeDelimiter;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr__uri;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr__username;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_Uri_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_set_Path_Public_set_Void_String_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_get_Query_Public_get_String_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_set_Query_Public_set_Void_String_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_get_Uri_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_SetFieldsFromUri_Private_Void_Uri_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
