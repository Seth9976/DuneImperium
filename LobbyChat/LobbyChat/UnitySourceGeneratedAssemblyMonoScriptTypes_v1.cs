using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000005 RID: 5
public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
	// Token: 0x0600000F RID: 15 RVA: 0x0000268C File Offset: 0x0000088C
	// Note: this type is marked as 'beforefieldinit'.
	static UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
		Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr = IL2CPP.GetIl2CppClass("LobbyChat.dll", "", "UnitySourceGeneratedAssemblyMonoScriptTypes_v1");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr);
		global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100663301);
		global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100663302);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000026E4 File Offset: 0x000008E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273490, XrefRangeEnd = 1273503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return new global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData(intPtr);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002710 File Offset: 0x00000910
	[CallerCount(2676)]
	[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000020DE File Offset: 0x000002DE
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000010 RID: 16
	public sealed class MonoScriptData : ValueType
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00002F20 File Offset: 0x00001120
		// Note: this type is marked as 'beforefieldinit'.
		static MonoScriptData()
		{
			Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, "MonoScriptData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr);
			global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "FilePathsData");
			global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TypesData");
			global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TotalTypes");
			global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TotalFiles");
			global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "IsEditorOnly");
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000235E File Offset: 0x0000055E
		public MonoScriptData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002367 File Offset: 0x00000567
		public MonoScriptData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr))
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002FB0 File Offset: 0x000011B0
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002379 File Offset: 0x00000579
		public unsafe Il2CppStructArray<byte> FilePathsData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002FE0 File Offset: 0x000011E0
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002398 File Offset: 0x00000598
		public unsafe Il2CppStructArray<byte> TypesData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00003010 File Offset: 0x00001210
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000023B7 File Offset: 0x000005B7
		public unsafe int TotalTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003038 File Offset: 0x00001238
		// (set) Token: 0x06000058 RID: 88 RVA: 0x000023D2 File Offset: 0x000005D2
		public unsafe int TotalFiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00003060 File Offset: 0x00001260
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000023ED File Offset: 0x000005ED
		public unsafe bool IsEditorOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly)) = value;
			}
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_FilePathsData;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_TypesData;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_TotalTypes;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_TotalFiles;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_IsEditorOnly;
	}
}
