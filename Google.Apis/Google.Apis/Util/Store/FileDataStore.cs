using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Google.Apis.Util.Store
{
	// Token: 0x02000003 RID: 3
	public class FileDataStore : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00004A58 File Offset: 0x00002C58
		// Note: this type is marked as 'beforefieldinit'.
		static FileDataStore()
		{
			Il2CppClassPointerStore<FileDataStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.dll", "Google.Apis.Util.Store", "FileDataStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileDataStore>.NativeClassPtr);
			FileDataStore.NativeFieldInfoPtr_XdgDataHomeSubdirectory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDataStore>.NativeClassPtr, "XdgDataHomeSubdirectory");
			FileDataStore.NativeFieldInfoPtr_CompletedTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDataStore>.NativeClassPtr, "CompletedTask");
			FileDataStore.NativeFieldInfoPtr_folderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileDataStore>.NativeClassPtr, "folderPath");
			FileDataStore.NativeMethodInfoPtr_get_FolderPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileDataStore>.NativeClassPtr, 100663297);
			FileDataStore.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileDataStore>.NativeClassPtr, 100663298);
			FileDataStore.NativeMethodInfoPtr_GetHomeDirectory_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileDataStore>.NativeClassPtr, 100663299);
			FileDataStore.NativeMethodInfoPtr_StoreAsync_Public_Virtual_Final_New_Task_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileDataStore>.NativeClassPtr, 100663300);
			FileDataStore.NativeMethodInfoPtr_DeleteAsync_Public_Virtual_Final_New_Task_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileDataStore>.NativeClassPtr, 100663301);
			FileDataStore.NativeMethodInfoPtr_GetAsync_Public_Virtual_Final_New_Task_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileDataStore>.NativeClassPtr, 100663302);
			FileDataStore.NativeMethodInfoPtr_ClearAsync_Public_Virtual_Final_New_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileDataStore>.NativeClassPtr, 100663303);
			FileDataStore.NativeMethodInfoPtr_GenerateStoredKey_Public_Static_String_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileDataStore>.NativeClassPtr, 100663304);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00004B64 File Offset: 0x00002D64
		public unsafe string FolderPath
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileDataStore.NativeMethodInfoPtr_get_FolderPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00004B9C File Offset: 0x00002D9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1195378, RefRangeEnd = 1195379, XrefRangeStart = 1195345, XrefRangeEnd = 1195378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileDataStore(string folder, bool fullPath = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileDataStore>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(folder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullPath;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileDataStore.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00004BF8 File Offset: 0x00002DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195379, XrefRangeEnd = 1195404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetHomeDirectory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileDataStore.NativeMethodInfoPtr_GetHomeDirectory_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00004C30 File Offset: 0x00002E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195404, XrefRangeEnd = 1195428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task StoreAsync<T>(string key, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FileDataStore.MethodInfoStoreGeneric_StoreAsync_Public_Virtual_Final_New_Task_String_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task>(intPtr4) : null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195428, XrefRangeEnd = 1195447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task DeleteAsync<T>(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileDataStore.MethodInfoStoreGeneric_DeleteAsync_Public_Virtual_Final_New_Task_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00004D18 File Offset: 0x00002F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195447, XrefRangeEnd = 1195467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<T> GetAsync<T>(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileDataStore.MethodInfoStoreGeneric_GetAsync_Public_Virtual_Final_New_Task_1_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00004D68 File Offset: 0x00002F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195467, XrefRangeEnd = 1195474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task ClearAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileDataStore.NativeMethodInfoPtr_ClearAsync_Public_Virtual_Final_New_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00004DA8 File Offset: 0x00002FA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1195478, RefRangeEnd = 1195481, XrefRangeStart = 1195474, XrefRangeEnd = 1195478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GenerateStoredKey(string key, Type t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileDataStore.NativeMethodInfoPtr_GenerateStoredKey_Public_Static_String_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		public FileDataStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00004DF8 File Offset: 0x00002FF8
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe static string XdgDataHomeSubdirectory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileDataStore.NativeFieldInfoPtr_XdgDataHomeSubdirectory, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileDataStore.NativeFieldInfoPtr_XdgDataHomeSubdirectory, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00004E18 File Offset: 0x00003018
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000206B File Offset: 0x0000026B
		public unsafe static Task CompletedTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileDataStore.NativeFieldInfoPtr_CompletedTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileDataStore.NativeFieldInfoPtr_CompletedTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00004E40 File Offset: 0x00003040
		// (set) Token: 0x06000010 RID: 16 RVA: 0x0000207D File Offset: 0x0000027D
		public unsafe string folderPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDataStore.NativeFieldInfoPtr_folderPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileDataStore.NativeFieldInfoPtr_folderPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_XdgDataHomeSubdirectory;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_CompletedTask;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_folderPath;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_FolderPath_Public_get_String_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_GetHomeDirectory_Private_String_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_StoreAsync_Public_Virtual_Final_New_Task_String_T_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_DeleteAsync_Public_Virtual_Final_New_Task_String_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_GetAsync_Public_Virtual_Final_New_Task_1_T_String_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_ClearAsync_Public_Virtual_Final_New_Task_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_GenerateStoredKey_Public_Static_String_String_Type_0;

		// Token: 0x0200001C RID: 28
		private sealed class MethodInfoStoreGeneric_StoreAsync_Public_Virtual_Final_New_Task_String_T_0<T>
		{
			// Token: 0x04000156 RID: 342
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FileDataStore.NativeMethodInfoPtr_StoreAsync_Public_Virtual_Final_New_Task_String_T_0, Il2CppClassPointerStore<FileDataStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001D RID: 29
		private sealed class MethodInfoStoreGeneric_DeleteAsync_Public_Virtual_Final_New_Task_String_0<T>
		{
			// Token: 0x04000157 RID: 343
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FileDataStore.NativeMethodInfoPtr_DeleteAsync_Public_Virtual_Final_New_Task_String_0, Il2CppClassPointerStore<FileDataStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001E RID: 30
		private sealed class MethodInfoStoreGeneric_GetAsync_Public_Virtual_Final_New_Task_1_T_String_0<T>
		{
			// Token: 0x04000158 RID: 344
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FileDataStore.NativeMethodInfoPtr_GetAsync_Public_Virtual_Final_New_Task_1_T_String_0, Il2CppClassPointerStore<FileDataStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
