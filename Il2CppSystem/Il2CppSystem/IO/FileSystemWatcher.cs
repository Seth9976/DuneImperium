using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.IO
{
	// Token: 0x02000181 RID: 385
	public class FileSystemWatcher : Component
	{
		// Token: 0x06001765 RID: 5989 RVA: 0x00077970 File Offset: 0x00075B70
		// Note: this type is marked as 'beforefieldinit'.
		static FileSystemWatcher()
		{
			Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "FileSystemWatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr);
			FileSystemWatcher.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "inited");
			FileSystemWatcher.NativeFieldInfoPtr_start_requested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "start_requested");
			FileSystemWatcher.NativeFieldInfoPtr_enableRaisingEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "enableRaisingEvents");
			FileSystemWatcher.NativeFieldInfoPtr_filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "filter");
			FileSystemWatcher.NativeFieldInfoPtr_includeSubdirectories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "includeSubdirectories");
			FileSystemWatcher.NativeFieldInfoPtr_internalBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "internalBufferSize");
			FileSystemWatcher.NativeFieldInfoPtr_notifyFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "notifyFilter");
			FileSystemWatcher.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "path");
			FileSystemWatcher.NativeFieldInfoPtr_fullpath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "fullpath");
			FileSystemWatcher.NativeFieldInfoPtr_synchronizingObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "synchronizingObject");
			FileSystemWatcher.NativeFieldInfoPtr_lastData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "lastData");
			FileSystemWatcher.NativeFieldInfoPtr_waiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "waiting");
			FileSystemWatcher.NativeFieldInfoPtr_pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "pattern");
			FileSystemWatcher.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "disposed");
			FileSystemWatcher.NativeFieldInfoPtr_mangledFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "mangledFilter");
			FileSystemWatcher.NativeFieldInfoPtr_watcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "watcher");
			FileSystemWatcher.NativeFieldInfoPtr_watcher_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "watcher_handle");
			FileSystemWatcher.NativeFieldInfoPtr_lockobj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "lockobj");
			FileSystemWatcher.NativeFieldInfoPtr_Changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "Changed");
			FileSystemWatcher.NativeFieldInfoPtr_Created = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "Created");
			FileSystemWatcher.NativeFieldInfoPtr_Deleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "Deleted");
			FileSystemWatcher.NativeFieldInfoPtr_Renamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "Renamed");
			FileSystemWatcher.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100666987);
			FileSystemWatcher.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100666988);
			FileSystemWatcher.NativeMethodInfoPtr_InitWatcher_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100666989);
			FileSystemWatcher.NativeMethodInfoPtr_get_Waiting_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100666990);
			FileSystemWatcher.NativeMethodInfoPtr_set_Waiting_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100666991);
			FileSystemWatcher.NativeMethodInfoPtr_get_MangledFilter_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100666992);
			FileSystemWatcher.NativeMethodInfoPtr_get_Pattern_Internal_get_SearchPattern2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100666993);
			FileSystemWatcher.NativeMethodInfoPtr_get_FullPath_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100666994);
			FileSystemWatcher.NativeMethodInfoPtr_set_EnableRaisingEvents_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100666995);
			FileSystemWatcher.NativeMethodInfoPtr_set_Filter_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100666996);
			FileSystemWatcher.NativeMethodInfoPtr_get_IncludeSubdirectories_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100666997);
			FileSystemWatcher.NativeMethodInfoPtr_get_Site_Public_Virtual_get_ISite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100666998);
			FileSystemWatcher.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100666999);
			FileSystemWatcher.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100667000);
			FileSystemWatcher.NativeMethodInfoPtr_RaiseEvent_Private_Void_Delegate_EventArgs_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100667001);
			FileSystemWatcher.NativeMethodInfoPtr_OnChanged_Protected_Void_FileSystemEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100667002);
			FileSystemWatcher.NativeMethodInfoPtr_OnCreated_Protected_Void_FileSystemEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100667003);
			FileSystemWatcher.NativeMethodInfoPtr_OnDeleted_Protected_Void_FileSystemEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100667004);
			FileSystemWatcher.NativeMethodInfoPtr_OnRenamed_Protected_Void_RenamedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100667005);
			FileSystemWatcher.NativeMethodInfoPtr_DispatchEvents_Internal_Void_FileAction_String_byref_RenamedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100667006);
			FileSystemWatcher.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100667007);
			FileSystemWatcher.NativeMethodInfoPtr_Stop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100667008);
			FileSystemWatcher.NativeMethodInfoPtr_add_Changed_Public_add_Void_FileSystemEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100667009);
			FileSystemWatcher.NativeMethodInfoPtr_remove_Changed_Public_rem_Void_FileSystemEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, 100667010);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00077D38 File Offset: 0x00075F38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469786, RefRangeEnd = 469787, XrefRangeStart = 469783, XrefRangeEnd = 469786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemWatcher(string path)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00077D84 File Offset: 0x00075F84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469832, RefRangeEnd = 469833, XrefRangeStart = 469787, XrefRangeEnd = 469832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileSystemWatcher(string path, string filter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00077DE4 File Offset: 0x00075FE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 469882, RefRangeEnd = 469883, XrefRangeStart = 469833, XrefRangeEnd = 469882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitWatcher()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_InitWatcher_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00077E18 File Offset: 0x00076018
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x00077E54 File Offset: 0x00076054
		public unsafe bool Waiting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_get_Waiting_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_set_Waiting_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x00077E94 File Offset: 0x00076094
		public unsafe string MangledFilter
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 469887, RefRangeEnd = 469891, XrefRangeStart = 469883, XrefRangeEnd = 469887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_get_MangledFilter_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x00077ECC File Offset: 0x000760CC
		public unsafe SearchPattern2 Pattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469891, XrefRangeEnd = 469899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_get_Pattern_Internal_get_SearchPattern2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SearchPattern2>(intPtr3) : null;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x00077F0C File Offset: 0x0007610C
		public unsafe string FullPath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469899, XrefRangeEnd = 469907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_get_FullPath_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006FF RID: 1791
		// (set) Token: 0x0600176E RID: 5998 RVA: 0x00077F44 File Offset: 0x00076144
		public unsafe bool EnableRaisingEvents
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 469910, RefRangeEnd = 469911, XrefRangeStart = 469907, XrefRangeEnd = 469910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_set_EnableRaisingEvents_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000700 RID: 1792
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x00077F84 File Offset: 0x00076184
		public unsafe string Filter
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 469931, RefRangeEnd = 469932, XrefRangeStart = 469911, XrefRangeEnd = 469931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_set_Filter_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x00077FC8 File Offset: 0x000761C8
		public unsafe bool IncludeSubdirectories
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_get_IncludeSubdirectories_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x00078004 File Offset: 0x00076204
		public unsafe override ISite Site
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemWatcher.NativeMethodInfoPtr_get_Site_Public_Virtual_get_ISite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISite>(intPtr3) : null;
			}
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00078050 File Offset: 0x00076250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469932, XrefRangeEnd = 469945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemWatcher.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0007809C File Offset: 0x0007629C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469945, XrefRangeEnd = 469950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FileSystemWatcher.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x000780D8 File Offset: 0x000762D8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 469966, RefRangeEnd = 469974, XrefRangeStart = 469950, XrefRangeEnd = 469966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseEvent(Delegate ev, EventArgs arg, FileSystemWatcher.EventType evtype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ev);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evtype;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_RaiseEvent_Private_Void_Delegate_EventArgs_EventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x0007813C File Offset: 0x0007633C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469974, XrefRangeEnd = 469975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnChanged(FileSystemEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_OnChanged_Protected_Void_FileSystemEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00078180 File Offset: 0x00076380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469975, XrefRangeEnd = 469976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCreated(FileSystemEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_OnCreated_Protected_Void_FileSystemEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x000781C4 File Offset: 0x000763C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469976, XrefRangeEnd = 469977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeleted(FileSystemEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_OnDeleted_Protected_Void_FileSystemEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00078208 File Offset: 0x00076408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469977, XrefRangeEnd = 469978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRenamed(RenamedEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_OnRenamed_Protected_Void_RenamedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x0007824C File Offset: 0x0007644C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 470015, RefRangeEnd = 470016, XrefRangeStart = 469978, XrefRangeEnd = 470015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchEvents(FileAction act, string filename, ref RenamedEventArgs renamed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref act;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filename);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(renamed);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_DispatchEvents_Internal_Void_FileAction_String_byref_RenamedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			renamed = ((intPtr4 == 0) ? null : new RenamedEventArgs(intPtr4));
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x000782C4 File Offset: 0x000764C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470016, XrefRangeEnd = 470019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x000782F8 File Offset: 0x000764F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470019, XrefRangeEnd = 470022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_Stop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0007832C File Offset: 0x0007652C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 470026, RefRangeEnd = 470027, XrefRangeStart = 470022, XrefRangeEnd = 470026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Changed(FileSystemEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_add_Changed_Public_add_Void_FileSystemEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00078370 File Offset: 0x00076570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470027, XrefRangeEnd = 470031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Changed(FileSystemEventHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.NativeMethodInfoPtr_remove_Changed_Public_rem_Void_FileSystemEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x0000A210 File Offset: 0x00008410
		public FileSystemWatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600177F RID: 6015 RVA: 0x000783B4 File Offset: 0x000765B4
		// (set) Token: 0x06001780 RID: 6016 RVA: 0x0000A219 File Offset: 0x00008419
		public unsafe bool inited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_inited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_inited)) = value;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x000783DC File Offset: 0x000765DC
		// (set) Token: 0x06001782 RID: 6018 RVA: 0x0000A234 File Offset: 0x00008434
		public unsafe bool start_requested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_start_requested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_start_requested)) = value;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x00078404 File Offset: 0x00076604
		// (set) Token: 0x06001784 RID: 6020 RVA: 0x0000A24F File Offset: 0x0000844F
		public unsafe bool enableRaisingEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_enableRaisingEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_enableRaisingEvents)) = value;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x0007842C File Offset: 0x0007662C
		// (set) Token: 0x06001786 RID: 6022 RVA: 0x0000A26A File Offset: 0x0000846A
		public unsafe string filter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_filter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_filter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x00078454 File Offset: 0x00076654
		// (set) Token: 0x06001788 RID: 6024 RVA: 0x0000A289 File Offset: 0x00008489
		public unsafe bool includeSubdirectories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_includeSubdirectories);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_includeSubdirectories)) = value;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x0007847C File Offset: 0x0007667C
		// (set) Token: 0x0600178A RID: 6026 RVA: 0x0000A2A4 File Offset: 0x000084A4
		public unsafe int internalBufferSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_internalBufferSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_internalBufferSize)) = value;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x000784A4 File Offset: 0x000766A4
		// (set) Token: 0x0600178C RID: 6028 RVA: 0x0000A2BF File Offset: 0x000084BF
		public unsafe NotifyFilters notifyFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_notifyFilter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_notifyFilter)) = value;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x000784CC File Offset: 0x000766CC
		// (set) Token: 0x0600178E RID: 6030 RVA: 0x0000A2DA File Offset: 0x000084DA
		public unsafe string path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x000784F4 File Offset: 0x000766F4
		// (set) Token: 0x06001790 RID: 6032 RVA: 0x0000A2F9 File Offset: 0x000084F9
		public unsafe string fullpath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_fullpath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_fullpath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x0007851C File Offset: 0x0007671C
		// (set) Token: 0x06001792 RID: 6034 RVA: 0x0000A318 File Offset: 0x00008518
		public unsafe ISynchronizeInvoke synchronizingObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_synchronizingObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISynchronizeInvoke>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_synchronizingObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x0007854C File Offset: 0x0007674C
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x0000A337 File Offset: 0x00008537
		public WaitForChangedResult lastData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_lastData);
				return new WaitForChangedResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_lastData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WaitForChangedResult>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x0007857C File Offset: 0x0007677C
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x0000A365 File Offset: 0x00008565
		public unsafe bool waiting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_waiting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_waiting)) = value;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x000785A4 File Offset: 0x000767A4
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x0000A380 File Offset: 0x00008580
		public unsafe SearchPattern2 pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_pattern);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SearchPattern2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_pattern), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x000785D4 File Offset: 0x000767D4
		// (set) Token: 0x0600179A RID: 6042 RVA: 0x0000A39F File Offset: 0x0000859F
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x000785FC File Offset: 0x000767FC
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x0000A3BA File Offset: 0x000085BA
		public unsafe string mangledFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_mangledFilter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_mangledFilter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x00078624 File Offset: 0x00076824
		// (set) Token: 0x0600179E RID: 6046 RVA: 0x0000A3D9 File Offset: 0x000085D9
		public unsafe IFileWatcher watcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_watcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFileWatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_watcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x00078654 File Offset: 0x00076854
		// (set) Token: 0x060017A0 RID: 6048 RVA: 0x0000A3F8 File Offset: 0x000085F8
		public unsafe Object watcher_handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_watcher_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_watcher_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x00078684 File Offset: 0x00076884
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x0000A417 File Offset: 0x00008617
		public unsafe static Object lockobj
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FileSystemWatcher.NativeFieldInfoPtr_lockobj, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FileSystemWatcher.NativeFieldInfoPtr_lockobj, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x000786AC File Offset: 0x000768AC
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x0000A429 File Offset: 0x00008629
		public unsafe FileSystemEventHandler Changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_Changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_Changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x000786DC File Offset: 0x000768DC
		// (set) Token: 0x060017A6 RID: 6054 RVA: 0x0000A448 File Offset: 0x00008648
		public unsafe FileSystemEventHandler Created
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_Created);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_Created), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x0007870C File Offset: 0x0007690C
		// (set) Token: 0x060017A8 RID: 6056 RVA: 0x0000A467 File Offset: 0x00008667
		public unsafe FileSystemEventHandler Deleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_Deleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_Deleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x0007873C File Offset: 0x0007693C
		// (set) Token: 0x060017AA RID: 6058 RVA: 0x0000A486 File Offset: 0x00008686
		public unsafe RenamedEventHandler Renamed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_Renamed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenamedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.NativeFieldInfoPtr_Renamed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeFieldInfoPtr_start_requested;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeFieldInfoPtr_enableRaisingEvents;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeFieldInfoPtr_filter;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeFieldInfoPtr_includeSubdirectories;

		// Token: 0x04001234 RID: 4660
		private static readonly IntPtr NativeFieldInfoPtr_internalBufferSize;

		// Token: 0x04001235 RID: 4661
		private static readonly IntPtr NativeFieldInfoPtr_notifyFilter;

		// Token: 0x04001236 RID: 4662
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04001237 RID: 4663
		private static readonly IntPtr NativeFieldInfoPtr_fullpath;

		// Token: 0x04001238 RID: 4664
		private static readonly IntPtr NativeFieldInfoPtr_synchronizingObject;

		// Token: 0x04001239 RID: 4665
		private static readonly IntPtr NativeFieldInfoPtr_lastData;

		// Token: 0x0400123A RID: 4666
		private static readonly IntPtr NativeFieldInfoPtr_waiting;

		// Token: 0x0400123B RID: 4667
		private static readonly IntPtr NativeFieldInfoPtr_pattern;

		// Token: 0x0400123C RID: 4668
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x0400123D RID: 4669
		private static readonly IntPtr NativeFieldInfoPtr_mangledFilter;

		// Token: 0x0400123E RID: 4670
		private static readonly IntPtr NativeFieldInfoPtr_watcher;

		// Token: 0x0400123F RID: 4671
		private static readonly IntPtr NativeFieldInfoPtr_watcher_handle;

		// Token: 0x04001240 RID: 4672
		private static readonly IntPtr NativeFieldInfoPtr_lockobj;

		// Token: 0x04001241 RID: 4673
		private static readonly IntPtr NativeFieldInfoPtr_Changed;

		// Token: 0x04001242 RID: 4674
		private static readonly IntPtr NativeFieldInfoPtr_Created;

		// Token: 0x04001243 RID: 4675
		private static readonly IntPtr NativeFieldInfoPtr_Deleted;

		// Token: 0x04001244 RID: 4676
		private static readonly IntPtr NativeFieldInfoPtr_Renamed;

		// Token: 0x04001245 RID: 4677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001246 RID: 4678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04001247 RID: 4679
		private static readonly IntPtr NativeMethodInfoPtr_InitWatcher_Private_Void_0;

		// Token: 0x04001248 RID: 4680
		private static readonly IntPtr NativeMethodInfoPtr_get_Waiting_Internal_get_Boolean_0;

		// Token: 0x04001249 RID: 4681
		private static readonly IntPtr NativeMethodInfoPtr_set_Waiting_Internal_set_Void_Boolean_0;

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeMethodInfoPtr_get_MangledFilter_Internal_get_String_0;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_get_Pattern_Internal_get_SearchPattern2_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_get_FullPath_Internal_get_String_0;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeMethodInfoPtr_set_EnableRaisingEvents_Public_set_Void_Boolean_0;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeMethodInfoPtr_set_Filter_Public_set_Void_String_0;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeMethodInfoPtr_get_IncludeSubdirectories_Public_get_Boolean_0;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeMethodInfoPtr_get_Site_Public_Virtual_get_ISite_0;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeMethodInfoPtr_RaiseEvent_Private_Void_Delegate_EventArgs_EventType_0;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr_OnChanged_Protected_Void_FileSystemEventArgs_0;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr_OnCreated_Protected_Void_FileSystemEventArgs_0;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeMethodInfoPtr_OnDeleted_Protected_Void_FileSystemEventArgs_0;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr_OnRenamed_Protected_Void_RenamedEventArgs_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr_DispatchEvents_Internal_Void_FileAction_String_byref_RenamedEventArgs_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Private_Void_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_add_Changed_Public_add_Void_FileSystemEventHandler_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_remove_Changed_Public_rem_Void_FileSystemEventHandler_0;

		// Token: 0x02000306 RID: 774
		public enum EventType
		{
			// Token: 0x04002452 RID: 9298
			FileSystemEvent,
			// Token: 0x04002453 RID: 9299
			ErrorEvent,
			// Token: 0x04002454 RID: 9300
			RenameEvent
		}

		// Token: 0x02000307 RID: 775
		[ObfuscatedName("System.IO.FileSystemWatcher+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Object
		{
			// Token: 0x06002E47 RID: 11847 RVA: 0x000CB50C File Offset: 0x000C970C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_0>.NativeClassPtr);
				FileSystemWatcher.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_0>.NativeClassPtr, "<>4__this");
				FileSystemWatcher.__c__DisplayClass70_0.NativeFieldInfoPtr_filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_0>.NativeClassPtr, "filename");
				FileSystemWatcher.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_0>.NativeClassPtr, 100667012);
				FileSystemWatcher.__c__DisplayClass70_0.NativeMethodInfoPtr__DispatchEvents_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_0>.NativeClassPtr, 100667013);
				FileSystemWatcher.__c__DisplayClass70_0.NativeMethodInfoPtr__DispatchEvents_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_0>.NativeClassPtr, 100667014);
				FileSystemWatcher.__c__DisplayClass70_0.NativeMethodInfoPtr__DispatchEvents_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_0>.NativeClassPtr, 100667015);
			}

			// Token: 0x06002E48 RID: 11848 RVA: 0x000CB5B0 File Offset: 0x000C97B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E49 RID: 11849 RVA: 0x000CB5EC File Offset: 0x000C97EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469767, XrefRangeEnd = 469772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DispatchEvents_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.__c__DisplayClass70_0.NativeMethodInfoPtr__DispatchEvents_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E4A RID: 11850 RVA: 0x000CB620 File Offset: 0x000C9820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469772, XrefRangeEnd = 469777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DispatchEvents_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.__c__DisplayClass70_0.NativeMethodInfoPtr__DispatchEvents_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E4B RID: 11851 RVA: 0x000CB654 File Offset: 0x000C9854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469777, XrefRangeEnd = 469782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DispatchEvents_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.__c__DisplayClass70_0.NativeMethodInfoPtr__DispatchEvents_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E4C RID: 11852 RVA: 0x00014A89 File Offset: 0x00012C89
			public __c__DisplayClass70_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E89 RID: 3721
			// (get) Token: 0x06002E4D RID: 11853 RVA: 0x000CB688 File Offset: 0x000C9888
			// (set) Token: 0x06002E4E RID: 11854 RVA: 0x00014A92 File Offset: 0x00012C92
			public unsafe FileSystemWatcher __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemWatcher>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E8A RID: 3722
			// (get) Token: 0x06002E4F RID: 11855 RVA: 0x000CB6B8 File Offset: 0x000C98B8
			// (set) Token: 0x06002E50 RID: 11856 RVA: 0x00014AB1 File Offset: 0x00012CB1
			public unsafe string filename
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.__c__DisplayClass70_0.NativeFieldInfoPtr_filename);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.__c__DisplayClass70_0.NativeFieldInfoPtr_filename), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002455 RID: 9301
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002456 RID: 9302
			private static readonly IntPtr NativeFieldInfoPtr_filename;

			// Token: 0x04002457 RID: 9303
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002458 RID: 9304
			private static readonly IntPtr NativeMethodInfoPtr__DispatchEvents_b__0_Internal_Void_0;

			// Token: 0x04002459 RID: 9305
			private static readonly IntPtr NativeMethodInfoPtr__DispatchEvents_b__1_Internal_Void_0;

			// Token: 0x0400245A RID: 9306
			private static readonly IntPtr NativeMethodInfoPtr__DispatchEvents_b__2_Internal_Void_0;
		}

		// Token: 0x02000308 RID: 776
		[ObfuscatedName("System.IO.FileSystemWatcher+<>c__DisplayClass70_1")]
		public sealed class __c__DisplayClass70_1 : Object
		{
			// Token: 0x06002E51 RID: 11857 RVA: 0x000CB6E0 File Offset: 0x000C98E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_1()
			{
				Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FileSystemWatcher>.NativeClassPtr, "<>c__DisplayClass70_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_1>.NativeClassPtr);
				FileSystemWatcher.__c__DisplayClass70_1.NativeFieldInfoPtr_renamed_ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_1>.NativeClassPtr, "renamed_ref");
				FileSystemWatcher.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_1>.NativeClassPtr, "CS$<>8__locals1");
				FileSystemWatcher.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_1>.NativeClassPtr, 100667016);
				FileSystemWatcher.__c__DisplayClass70_1.NativeMethodInfoPtr__DispatchEvents_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_1>.NativeClassPtr, 100667017);
			}

			// Token: 0x06002E52 RID: 11858 RVA: 0x000CB75C File Offset: 0x000C995C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileSystemWatcher.__c__DisplayClass70_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E53 RID: 11859 RVA: 0x000CB798 File Offset: 0x000C9998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469782, XrefRangeEnd = 469783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DispatchEvents_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileSystemWatcher.__c__DisplayClass70_1.NativeMethodInfoPtr__DispatchEvents_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E54 RID: 11860 RVA: 0x00014AD0 File Offset: 0x00012CD0
			public __c__DisplayClass70_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E8B RID: 3723
			// (get) Token: 0x06002E55 RID: 11861 RVA: 0x000CB7CC File Offset: 0x000C99CC
			// (set) Token: 0x06002E56 RID: 11862 RVA: 0x00014AD9 File Offset: 0x00012CD9
			public unsafe RenamedEventArgs renamed_ref
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.__c__DisplayClass70_1.NativeFieldInfoPtr_renamed_ref);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenamedEventArgs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.__c__DisplayClass70_1.NativeFieldInfoPtr_renamed_ref), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E8C RID: 3724
			// (get) Token: 0x06002E57 RID: 11863 RVA: 0x000CB7FC File Offset: 0x000C99FC
			// (set) Token: 0x06002E58 RID: 11864 RVA: 0x00014AF8 File Offset: 0x00012CF8
			public unsafe FileSystemWatcher.__c__DisplayClass70_0 field_Public___c__DisplayClass70_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemWatcher.__c__DisplayClass70_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileSystemWatcher.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400245B RID: 9307
			private static readonly IntPtr NativeFieldInfoPtr_renamed_ref;

			// Token: 0x0400245C RID: 9308
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0;

			// Token: 0x0400245D RID: 9309
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400245E RID: 9310
			private static readonly IntPtr NativeMethodInfoPtr__DispatchEvents_b__3_Internal_Void_0;
		}
	}
}
