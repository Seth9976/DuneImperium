using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000005 RID: 5
public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
{
	// Token: 0x0600000F RID: 15 RVA: 0x00069034 File Offset: 0x00067234
	// Note: this type is marked as 'beforefieldinit'.
	static UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
		Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "", "UnitySourceGeneratedAssemblyMonoScriptTypes_v1");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr);
		global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100663301);
		global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100663302);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0006908C File Offset: 0x0006728C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327, XrefRangeEnd = 340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return new global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData(intPtr);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x000690B8 File Offset: 0x000672B8
	[CallerCount(2676)]
	[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 340, XrefRangeEnd = 341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	// Token: 0x0200054F RID: 1359
	public sealed class MonoScriptData : ValueType
	{
		// Token: 0x06004063 RID: 16483 RVA: 0x00176670 File Offset: 0x00174870
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

		// Token: 0x06004064 RID: 16484 RVA: 0x0001453A File Offset: 0x0001273A
		public MonoScriptData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004065 RID: 16485 RVA: 0x00014543 File Offset: 0x00012743
		public MonoScriptData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<global::UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr))
		{
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x00176700 File Offset: 0x00174900
		// (set) Token: 0x06004067 RID: 16487 RVA: 0x00014555 File Offset: 0x00012755
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

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x00176730 File Offset: 0x00174930
		// (set) Token: 0x06004069 RID: 16489 RVA: 0x00014574 File Offset: 0x00012774
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

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x0600406A RID: 16490 RVA: 0x00176760 File Offset: 0x00174960
		// (set) Token: 0x0600406B RID: 16491 RVA: 0x00014593 File Offset: 0x00012793
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

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x0600406C RID: 16492 RVA: 0x00176788 File Offset: 0x00174988
		// (set) Token: 0x0600406D RID: 16493 RVA: 0x000145AE File Offset: 0x000127AE
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

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x001767B0 File Offset: 0x001749B0
		// (set) Token: 0x0600406F RID: 16495 RVA: 0x000145C9 File Offset: 0x000127C9
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

		// Token: 0x04002AD2 RID: 10962
		private static readonly IntPtr NativeFieldInfoPtr_FilePathsData;

		// Token: 0x04002AD3 RID: 10963
		private static readonly IntPtr NativeFieldInfoPtr_TypesData;

		// Token: 0x04002AD4 RID: 10964
		private static readonly IntPtr NativeFieldInfoPtr_TotalTypes;

		// Token: 0x04002AD5 RID: 10965
		private static readonly IntPtr NativeFieldInfoPtr_TotalFiles;

		// Token: 0x04002AD6 RID: 10966
		private static readonly IntPtr NativeFieldInfoPtr_IsEditorOnly;
	}
}
