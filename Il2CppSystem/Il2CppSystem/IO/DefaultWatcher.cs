using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Threading;

namespace Il2CppSystem.IO
{
	// Token: 0x0200017D RID: 381
	public class DefaultWatcher : Object
	{
		// Token: 0x06001747 RID: 5959 RVA: 0x000772FC File Offset: 0x000754FC
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultWatcher()
		{
			Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "DefaultWatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr);
			DefaultWatcher.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, "instance");
			DefaultWatcher.NativeFieldInfoPtr_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, "thread");
			DefaultWatcher.NativeFieldInfoPtr_watches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, "watches");
			DefaultWatcher.NativeFieldInfoPtr_NoStringsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, "NoStringsArray");
			DefaultWatcher.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, 100666973);
			DefaultWatcher.NativeMethodInfoPtr_GetInstance_Public_Static_Boolean_byref_IFileWatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, 100666974);
			DefaultWatcher.NativeMethodInfoPtr_StartDispatching_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, 100666975);
			DefaultWatcher.NativeMethodInfoPtr_StopDispatching_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, 100666976);
			DefaultWatcher.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, 100666977);
			DefaultWatcher.NativeMethodInfoPtr_Monitor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, 100666978);
			DefaultWatcher.NativeMethodInfoPtr_UpdateDataAndDispatch_Private_Boolean_DefaultWatcherData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, 100666979);
			DefaultWatcher.NativeMethodInfoPtr_DispatchEvents_Private_Static_Void_FileSystemWatcher_FileAction_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, 100666980);
			DefaultWatcher.NativeMethodInfoPtr_DoFiles_Private_Void_DefaultWatcherData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, 100666981);
			DefaultWatcher.NativeMethodInfoPtr_IterateAndModifyFilesData_Private_Void_DefaultWatcherData_String_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, 100666982);
			DefaultWatcher.NativeMethodInfoPtr_CreateFileData_Private_Static_FileData_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr, 100666983);
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00077458 File Offset: 0x00075658
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultWatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultWatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultWatcher.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00077494 File Offset: 0x00075694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469344, XrefRangeEnd = 469357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetInstance(out IFileWatcher watcher)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DefaultWatcher.NativeMethodInfoPtr_GetInstance_Public_Static_Boolean_byref_IFileWatcher_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				watcher = ((intPtr4 == 0) ? null : new IFileWatcher(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x000774E8 File Offset: 0x000756E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469357, XrefRangeEnd = 469479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartDispatching(Object handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultWatcher.NativeMethodInfoPtr_StartDispatching_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x0007752C File Offset: 0x0007572C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469479, XrefRangeEnd = 469514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopDispatching(Object handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultWatcher.NativeMethodInfoPtr_StopDispatching_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x00077570 File Offset: 0x00075770
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(Object handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultWatcher.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x000775B4 File Offset: 0x000757B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469514, XrefRangeEnd = 469578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Monitor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultWatcher.NativeMethodInfoPtr_Monitor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x000775E8 File Offset: 0x000757E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469581, RefRangeEnd = 469582, XrefRangeStart = 469578, XrefRangeEnd = 469581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateDataAndDispatch(DefaultWatcherData data, bool dispatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultWatcher.NativeMethodInfoPtr_UpdateDataAndDispatch_Private_Boolean_DefaultWatcherData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00077644 File Offset: 0x00075844
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 469588, RefRangeEnd = 469592, XrefRangeStart = 469582, XrefRangeEnd = 469588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DispatchEvents(FileSystemWatcher fsw, FileAction action, string filename)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fsw);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultWatcher.NativeMethodInfoPtr_DispatchEvents_Private_Static_Void_FileSystemWatcher_FileAction_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x0007769C File Offset: 0x0007589C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 469618, RefRangeEnd = 469621, XrefRangeStart = 469592, XrefRangeEnd = 469618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoFiles(DefaultWatcherData data, string directory, bool dispatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultWatcher.NativeMethodInfoPtr_DoFiles_Private_Void_DefaultWatcherData_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00077700 File Offset: 0x00075900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469753, RefRangeEnd = 469754, XrefRangeStart = 469621, XrefRangeEnd = 469753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IterateAndModifyFilesData(DefaultWatcherData data, string directory, bool dispatch, Il2CppStringArray files)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(directory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dispatch;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(files);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultWatcher.NativeMethodInfoPtr_IterateAndModifyFilesData_Private_Void_DefaultWatcherData_String_Boolean_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00077778 File Offset: 0x00075978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469766, RefRangeEnd = 469767, XrefRangeStart = 469754, XrefRangeEnd = 469766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FileData CreateFileData(string directory, string filename)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultWatcher.NativeMethodInfoPtr_CreateFileData_Private_Static_FileData_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FileData>(intPtr3) : null;
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0000A161 File Offset: 0x00008361
		public DefaultWatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x000777D0 File Offset: 0x000759D0
		// (set) Token: 0x06001755 RID: 5973 RVA: 0x0000A16A File Offset: 0x0000836A
		public unsafe static DefaultWatcher instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultWatcher.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultWatcher>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultWatcher.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x000777F8 File Offset: 0x000759F8
		// (set) Token: 0x06001757 RID: 5975 RVA: 0x0000A17C File Offset: 0x0000837C
		public unsafe static Thread thread
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultWatcher.NativeFieldInfoPtr_thread, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultWatcher.NativeFieldInfoPtr_thread, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x00077820 File Offset: 0x00075A20
		// (set) Token: 0x06001759 RID: 5977 RVA: 0x0000A18E File Offset: 0x0000838E
		public unsafe static Hashtable watches
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultWatcher.NativeFieldInfoPtr_watches, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultWatcher.NativeFieldInfoPtr_watches, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x00077848 File Offset: 0x00075A48
		// (set) Token: 0x0600175B RID: 5979 RVA: 0x0000A1A0 File Offset: 0x000083A0
		public unsafe static Il2CppStringArray NoStringsArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultWatcher.NativeFieldInfoPtr_NoStringsArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultWatcher.NativeFieldInfoPtr_NoStringsArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001218 RID: 4632
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04001219 RID: 4633
		private static readonly IntPtr NativeFieldInfoPtr_thread;

		// Token: 0x0400121A RID: 4634
		private static readonly IntPtr NativeFieldInfoPtr_watches;

		// Token: 0x0400121B RID: 4635
		private static readonly IntPtr NativeFieldInfoPtr_NoStringsArray;

		// Token: 0x0400121C RID: 4636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Public_Static_Boolean_byref_IFileWatcher_0;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr_StartDispatching_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr_StopDispatching_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_Monitor_Private_Void_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDataAndDispatch_Private_Boolean_DefaultWatcherData_Boolean_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvents_Private_Static_Void_FileSystemWatcher_FileAction_String_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_DoFiles_Private_Void_DefaultWatcherData_String_Boolean_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_IterateAndModifyFilesData_Private_Void_DefaultWatcherData_String_Boolean_Il2CppStringArray_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_CreateFileData_Private_Static_FileData_String_String_0;
	}
}
