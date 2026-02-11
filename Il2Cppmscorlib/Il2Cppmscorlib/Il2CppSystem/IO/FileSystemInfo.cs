using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO.Enumeration;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000538 RID: 1336
	[Serializable]
	public class FileSystemInfo : MarshalByRefObject
	{
		// Token: 0x060051EC RID: 20972 RVA: 0x0017D530 File Offset: 0x0017B730
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemInfo()
		{
			Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileSystemInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr);
			FileSystemInfo.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "_data");
			FileSystemInfo.NativeFieldInfoPtr__dataInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "_dataInitialized");
			FileSystemInfo.NativeFieldInfoPtr_FullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "FullPath");
			FileSystemInfo.NativeFieldInfoPtr_OriginalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "OriginalPath");
			FileSystemInfo.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, "_name");
			FileSystemInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675775);
			FileSystemInfo.NativeMethodInfoPtr_Create_Internal_Static_FileSystemInfo_String_byref_FileSystemEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675776);
			FileSystemInfo.NativeMethodInfoPtr_Invalidate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675777);
			FileSystemInfo.NativeMethodInfoPtr_Init_Internal_Void_ptr_FILE_FULL_DIR_INFORMATION_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675778);
			FileSystemInfo.NativeMethodInfoPtr_get_Attributes_Public_get_FileAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675779);
			FileSystemInfo.NativeMethodInfoPtr_get_ExistsCore_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675780);
			FileSystemInfo.NativeMethodInfoPtr_get_LengthCore_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675781);
			FileSystemInfo.NativeMethodInfoPtr_EnsureDataInitialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675782);
			FileSystemInfo.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675783);
			FileSystemInfo.NativeMethodInfoPtr_get_NormalizedPath_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675784);
			FileSystemInfo.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675785);
			FileSystemInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675786);
			FileSystemInfo.NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675787);
			FileSystemInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675788);
			FileSystemInfo.NativeMethodInfoPtr_get_Exists_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675789);
			FileSystemInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr, 100675790);
		}

		// Token: 0x060051ED RID: 20973 RVA: 0x0017D704 File Offset: 0x0017B904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060051EE RID: 20974 RVA: 0x0017D740 File Offset: 0x0017B940
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1430916, RefRangeEnd = 1430917, XrefRangeStart = 1430872, XrefRangeEnd = 1430916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileSystemInfo Create(string fullPath, ref FileSystemEntry findData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(findData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_Create_Internal_Static_FileSystemInfo_String_byref_FileSystemEntry_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileSystemInfo>(intPtr3) : null;
		}

		// Token: 0x060051EF RID: 20975 RVA: 0x0017D798 File Offset: 0x0017B998
		[CallerCount(0)]
		public unsafe void Invalidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_Invalidate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060051F0 RID: 20976 RVA: 0x0017D7CC File Offset: 0x0017B9CC
		[CallerCount(0)]
		public unsafe void Init(Interop.NtDll.FILE_FULL_DIR_INFORMATION* info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = info;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_Init_Internal_Void_ptr_FILE_FULL_DIR_INFORMATION_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x060051F1 RID: 20977 RVA: 0x0017D80C File Offset: 0x0017BA0C
		public unsafe FileAttributes Attributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430917, XrefRangeEnd = 1430918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_get_Attributes_Public_get_FileAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x060051F2 RID: 20978 RVA: 0x0017D848 File Offset: 0x0017BA48
		public unsafe bool ExistsCore
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430918, XrefRangeEnd = 1430921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_get_ExistsCore_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x060051F3 RID: 20979 RVA: 0x0017D884 File Offset: 0x0017BA84
		public unsafe long LengthCore
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430921, XrefRangeEnd = 1430922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_get_LengthCore_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x0017D8C0 File Offset: 0x0017BAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430922, XrefRangeEnd = 1430923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureDataInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_EnsureDataInitialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x0017D8F4 File Offset: 0x0017BAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430923, XrefRangeEnd = 1430924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x060051F6 RID: 20982 RVA: 0x0017D928 File Offset: 0x0017BB28
		public unsafe string NormalizedPath
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1430931, RefRangeEnd = 1430934, XrefRangeStart = 1430924, XrefRangeEnd = 1430931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr_get_NormalizedPath_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x0017D960 File Offset: 0x0017BB60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1430957, RefRangeEnd = 1430959, XrefRangeStart = 1430934, XrefRangeEnd = 1430957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemInfo(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemInfo.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x0017D9C4 File Offset: 0x0017BBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430959, XrefRangeEnd = 1430978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemInfo.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x060051F9 RID: 20985 RVA: 0x0017DA28 File Offset: 0x0017BC28
		public unsafe virtual string FullName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemInfo.NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x060051FA RID: 20986 RVA: 0x0017DA6C File Offset: 0x0017BC6C
		public unsafe virtual string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemInfo.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x060051FB RID: 20987 RVA: 0x0017DAB0 File Offset: 0x0017BCB0
		public unsafe virtual bool Exists
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430978, XrefRangeEnd = 1430983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemInfo.NativeMethodInfoPtr_get_Exists_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x0017DAF8 File Offset: 0x0017BCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430983, XrefRangeEnd = 1430985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x0001D26F File Offset: 0x0001B46F
		public FileSystemInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x060051FE RID: 20990 RVA: 0x0017DB3C File Offset: 0x0017BD3C
		// (set) Token: 0x060051FF RID: 20991 RVA: 0x0001D278 File Offset: 0x0001B478
		public unsafe Interop.Kernel32.WIN32_FILE_ATTRIBUTE_DATA _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__data)) = value;
			}
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06005200 RID: 20992 RVA: 0x0017DB64 File Offset: 0x0017BD64
		// (set) Token: 0x06005201 RID: 20993 RVA: 0x0001D293 File Offset: 0x0001B493
		public unsafe int _dataInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__dataInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__dataInitialized)) = value;
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06005202 RID: 20994 RVA: 0x0017DB8C File Offset: 0x0017BD8C
		// (set) Token: 0x06005203 RID: 20995 RVA: 0x0001D2AE File Offset: 0x0001B4AE
		public unsafe string FullPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr_FullPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr_FullPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06005204 RID: 20996 RVA: 0x0017DBB4 File Offset: 0x0017BDB4
		// (set) Token: 0x06005205 RID: 20997 RVA: 0x0001D2CD File Offset: 0x0001B4CD
		public unsafe string OriginalPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr_OriginalPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr_OriginalPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x06005206 RID: 20998 RVA: 0x0017DBDC File Offset: 0x0017BDDC
		// (set) Token: 0x06005207 RID: 20999 RVA: 0x0001D2EC File Offset: 0x0001B4EC
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemInfo.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040042CE RID: 17102
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x040042CF RID: 17103
		private static readonly IntPtr NativeFieldInfoPtr__dataInitialized;

		// Token: 0x040042D0 RID: 17104
		private static readonly IntPtr NativeFieldInfoPtr_FullPath;

		// Token: 0x040042D1 RID: 17105
		private static readonly IntPtr NativeFieldInfoPtr_OriginalPath;

		// Token: 0x040042D2 RID: 17106
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x040042D3 RID: 17107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040042D4 RID: 17108
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_FileSystemInfo_String_byref_FileSystemEntry_0;

		// Token: 0x040042D5 RID: 17109
		private static readonly IntPtr NativeMethodInfoPtr_Invalidate_Internal_Void_0;

		// Token: 0x040042D6 RID: 17110
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_ptr_FILE_FULL_DIR_INFORMATION_0;

		// Token: 0x040042D7 RID: 17111
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_FileAttributes_0;

		// Token: 0x040042D8 RID: 17112
		private static readonly IntPtr NativeMethodInfoPtr_get_ExistsCore_Internal_get_Boolean_0;

		// Token: 0x040042D9 RID: 17113
		private static readonly IntPtr NativeMethodInfoPtr_get_LengthCore_Internal_get_Int64_0;

		// Token: 0x040042DA RID: 17114
		private static readonly IntPtr NativeMethodInfoPtr_EnsureDataInitialized_Private_Void_0;

		// Token: 0x040042DB RID: 17115
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x040042DC RID: 17116
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedPath_Internal_get_String_0;

		// Token: 0x040042DD RID: 17117
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040042DE RID: 17118
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040042DF RID: 17119
		private static readonly IntPtr NativeMethodInfoPtr_get_FullName_Public_Virtual_New_get_String_0;

		// Token: 0x040042E0 RID: 17120
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

		// Token: 0x040042E1 RID: 17121
		private static readonly IntPtr NativeMethodInfoPtr_get_Exists_Public_Virtual_New_get_Boolean_0;

		// Token: 0x040042E2 RID: 17122
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
