using System;
using Canis.utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace dwd.core.settings.config
{
	// Token: 0x020000EE RID: 238
	public class VersionedConfig : VersionedModel
	{
		// Token: 0x06000E2A RID: 3626 RVA: 0x0004B928 File Offset: 0x00049B28
		// Note: this type is marked as 'beforefieldinit'.
		static VersionedConfig()
		{
			Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.config", "VersionedConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr);
			VersionedConfig.NativeFieldInfoPtr_filepath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr, "filepath");
			VersionedConfig.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr, "cachedVersion");
			VersionedConfig.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr, "config");
			VersionedConfig.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr, 100665343);
			VersionedConfig.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr, 100665344);
			VersionedConfig.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr, 100665345);
			VersionedConfig.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr, 100665346);
			VersionedConfig.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr, 100665347);
			VersionedConfig.NativeMethodInfoPtr_handleFileChange_Private_Void_Object_FileSystemEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr, 100665348);
			VersionedConfig.NativeMethodInfoPtr_updateConfig_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr, 100665349);
			VersionedConfig.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr, 100665350);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x0004BA34 File Offset: 0x00049C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 866990, XrefRangeEnd = 867008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionedConfig(string directory, string filename)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(directory);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(filename);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedConfig.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0004BA94 File Offset: 0x00049C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867008, XrefRangeEnd = 867012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionedConfig(string contents)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedConfig>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedConfig.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x0004BAE0 File Offset: 0x00049CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867012, XrefRangeEnd = 867016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedConfig.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x0004BB14 File Offset: 0x00049D14
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 867019, RefRangeEnd = 867033, XrefRangeStart = 867016, XrefRangeEnd = 867019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedConfig.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0004BB50 File Offset: 0x00049D50
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedConfig.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0004BB90 File Offset: 0x00049D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867033, XrefRangeEnd = 867034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleFileChange(Object o, FileSystemEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedConfig.NativeMethodInfoPtr_handleFileChange_Private_Void_Object_FileSystemEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x0004BBE4 File Offset: 0x00049DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867034, XrefRangeEnd = 867039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateConfig()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedConfig.NativeMethodInfoPtr_updateConfig_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0004BC18 File Offset: 0x00049E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867039, XrefRangeEnd = 867047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Get(string key, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VersionedConfig.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Boolean_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00006D63 File Offset: 0x00004F63
		public VersionedConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x0004BC80 File Offset: 0x00049E80
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00006D6C File Offset: 0x00004F6C
		public unsafe string filepath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedConfig.NativeFieldInfoPtr_filepath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedConfig.NativeFieldInfoPtr_filepath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x0004BCA8 File Offset: 0x00049EA8
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00006D8B File Offset: 0x00004F8B
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedConfig.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedConfig.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x0004BCD0 File Offset: 0x00049ED0
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00006DA6 File Offset: 0x00004FA6
		public unsafe ConfigFile config
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedConfig.NativeFieldInfoPtr_config);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigFile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedConfig.NativeFieldInfoPtr_config), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeFieldInfoPtr_filepath;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeFieldInfoPtr_config;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_handleFileChange_Private_Void_Object_FileSystemEventArgs_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_updateConfig_Private_Void_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Boolean_String_byref_String_0;
	}
}
