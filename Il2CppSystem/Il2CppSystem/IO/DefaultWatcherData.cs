using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.IO
{
	// Token: 0x0200017B RID: 379
	public class DefaultWatcherData : Object
	{
		// Token: 0x06001725 RID: 5925 RVA: 0x00076E9C File Offset: 0x0007509C
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultWatcherData()
		{
			Il2CppClassPointerStore<DefaultWatcherData>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "DefaultWatcherData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultWatcherData>.NativeClassPtr);
			DefaultWatcherData.NativeFieldInfoPtr_FSW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWatcherData>.NativeClassPtr, "FSW");
			DefaultWatcherData.NativeFieldInfoPtr_Directory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWatcherData>.NativeClassPtr, "Directory");
			DefaultWatcherData.NativeFieldInfoPtr_FileMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWatcherData>.NativeClassPtr, "FileMask");
			DefaultWatcherData.NativeFieldInfoPtr_IncludeSubdirs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWatcherData>.NativeClassPtr, "IncludeSubdirs");
			DefaultWatcherData.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWatcherData>.NativeClassPtr, "Enabled");
			DefaultWatcherData.NativeFieldInfoPtr_NoWildcards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWatcherData>.NativeClassPtr, "NoWildcards");
			DefaultWatcherData.NativeFieldInfoPtr_DisabledTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWatcherData>.NativeClassPtr, "DisabledTime");
			DefaultWatcherData.NativeFieldInfoPtr_FilesLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWatcherData>.NativeClassPtr, "FilesLock");
			DefaultWatcherData.NativeFieldInfoPtr_Files = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultWatcherData>.NativeClassPtr, "Files");
			DefaultWatcherData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultWatcherData>.NativeClassPtr, 100666971);
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00076F94 File Offset: 0x00075194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 469338, XrefRangeEnd = 469344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultWatcherData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultWatcherData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultWatcherData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00009FBD File Offset: 0x000081BD
		public DefaultWatcherData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x00076FD0 File Offset: 0x000751D0
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x00009FC6 File Offset: 0x000081C6
		public unsafe FileSystemWatcher FSW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_FSW);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemWatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_FSW), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x00077000 File Offset: 0x00075200
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x00009FE5 File Offset: 0x000081E5
		public unsafe string Directory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_Directory);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_Directory), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600172C RID: 5932 RVA: 0x00077028 File Offset: 0x00075228
		// (set) Token: 0x0600172D RID: 5933 RVA: 0x0000A004 File Offset: 0x00008204
		public unsafe string FileMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_FileMask);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_FileMask), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x00077050 File Offset: 0x00075250
		// (set) Token: 0x0600172F RID: 5935 RVA: 0x0000A023 File Offset: 0x00008223
		public unsafe bool IncludeSubdirs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_IncludeSubdirs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_IncludeSubdirs)) = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x00077078 File Offset: 0x00075278
		// (set) Token: 0x06001731 RID: 5937 RVA: 0x0000A03E File Offset: 0x0000823E
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x000770A0 File Offset: 0x000752A0
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x0000A059 File Offset: 0x00008259
		public unsafe bool NoWildcards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_NoWildcards);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_NoWildcards)) = value;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x000770C8 File Offset: 0x000752C8
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x0000A074 File Offset: 0x00008274
		public unsafe DateTime DisabledTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_DisabledTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_DisabledTime)) = value;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x000770F0 File Offset: 0x000752F0
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x0000A08F File Offset: 0x0000828F
		public unsafe Object FilesLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_FilesLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_FilesLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00077120 File Offset: 0x00075320
		// (set) Token: 0x06001739 RID: 5945 RVA: 0x0000A0AE File Offset: 0x000082AE
		public unsafe Dictionary<string, FileData> Files
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_Files);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, FileData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultWatcherData.NativeFieldInfoPtr_Files), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeFieldInfoPtr_FSW;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeFieldInfoPtr_Directory;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeFieldInfoPtr_FileMask;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeFieldInfoPtr_IncludeSubdirs;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeFieldInfoPtr_NoWildcards;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeFieldInfoPtr_DisabledTime;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeFieldInfoPtr_FilesLock;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeFieldInfoPtr_Files;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
