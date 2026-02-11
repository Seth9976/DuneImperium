using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.ComponentModel;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020000A8 RID: 168
	public class ProcessModule : Component
	{
		// Token: 0x06000C4C RID: 3148 RVA: 0x00049DD8 File Offset: 0x00047FD8
		// Note: this type is marked as 'beforefieldinit'.
		static ProcessModule()
		{
			Il2CppClassPointerStore<ProcessModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "ProcessModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProcessModule>.NativeClassPtr);
			ProcessModule.NativeFieldInfoPtr_baseaddr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessModule>.NativeClassPtr, "baseaddr");
			ProcessModule.NativeFieldInfoPtr_entryaddr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessModule>.NativeClassPtr, "entryaddr");
			ProcessModule.NativeFieldInfoPtr_filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessModule>.NativeClassPtr, "filename");
			ProcessModule.NativeFieldInfoPtr_version_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessModule>.NativeClassPtr, "version_info");
			ProcessModule.NativeFieldInfoPtr_memory_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessModule>.NativeClassPtr, "memory_size");
			ProcessModule.NativeFieldInfoPtr_modulename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProcessModule>.NativeClassPtr, "modulename");
			ProcessModule.NativeMethodInfoPtr_get_FileName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessModule>.NativeClassPtr, 100665058);
			ProcessModule.NativeMethodInfoPtr_get_ModuleName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessModule>.NativeClassPtr, 100665059);
			ProcessModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessModule>.NativeClassPtr, 100665060);
			ProcessModule.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProcessModule>.NativeClassPtr, 100665061);
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00049ED0 File Offset: 0x000480D0
		public unsafe string FileName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessModule.NativeMethodInfoPtr_get_FileName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x00049F08 File Offset: 0x00048108
		public unsafe string ModuleName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessModule.NativeMethodInfoPtr_get_ModuleName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00049F40 File Offset: 0x00048140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProcessModule.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00049F84 File Offset: 0x00048184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451897, XrefRangeEnd = 451907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProcessModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProcessModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProcessModule.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0000693F File Offset: 0x00004B3F
		public ProcessModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x00049FC0 File Offset: 0x000481C0
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x00006948 File Offset: 0x00004B48
		public unsafe IntPtr baseaddr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessModule.NativeFieldInfoPtr_baseaddr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessModule.NativeFieldInfoPtr_baseaddr)) = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x00049FE8 File Offset: 0x000481E8
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x00006963 File Offset: 0x00004B63
		public unsafe IntPtr entryaddr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessModule.NativeFieldInfoPtr_entryaddr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessModule.NativeFieldInfoPtr_entryaddr)) = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0004A010 File Offset: 0x00048210
		// (set) Token: 0x06000C57 RID: 3159 RVA: 0x0000697E File Offset: 0x00004B7E
		public unsafe string filename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessModule.NativeFieldInfoPtr_filename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessModule.NativeFieldInfoPtr_filename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0004A038 File Offset: 0x00048238
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0000699D File Offset: 0x00004B9D
		public unsafe FileVersionInfo version_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessModule.NativeFieldInfoPtr_version_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileVersionInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessModule.NativeFieldInfoPtr_version_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0004A068 File Offset: 0x00048268
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x000069BC File Offset: 0x00004BBC
		public unsafe int memory_size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessModule.NativeFieldInfoPtr_memory_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessModule.NativeFieldInfoPtr_memory_size)) = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0004A090 File Offset: 0x00048290
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x000069D7 File Offset: 0x00004BD7
		public unsafe string modulename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessModule.NativeFieldInfoPtr_modulename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProcessModule.NativeFieldInfoPtr_modulename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeFieldInfoPtr_baseaddr;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeFieldInfoPtr_entryaddr;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeFieldInfoPtr_filename;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeFieldInfoPtr_version_info;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeFieldInfoPtr_memory_size;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeFieldInfoPtr_modulename;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_get_FileName_Public_get_String_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_get_ModuleName_Public_get_String_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
