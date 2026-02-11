using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x0200007A RID: 122
	public class UnitPathGroup : PathProvider
	{
		// Token: 0x0600073F RID: 1855 RVA: 0x00021648 File Offset: 0x0001F848
		// Note: this type is marked as 'beforefieldinit'.
		static UnitPathGroup()
		{
			Il2CppClassPointerStore<UnitPathGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "UnitPathGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitPathGroup>.NativeClassPtr);
			UnitPathGroup.NativeFieldInfoPtr_defaultPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPathGroup>.NativeClassPtr, "defaultPath");
			UnitPathGroup.NativeFieldInfoPtr_paths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPathGroup>.NativeClassPtr, "paths");
			UnitPathGroup.NativeFieldInfoPtr_pathMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPathGroup>.NativeClassPtr, "pathMap");
			UnitPathGroup.NativeFieldInfoPtr_vm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPathGroup>.NativeClassPtr, "vm");
			UnitPathGroup.NativeFieldInfoPtr_suffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPathGroup>.NativeClassPtr, "suffix");
			UnitPathGroup.NativeMethodInfoPtr_Init_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPathGroup>.NativeClassPtr, 100664283);
			UnitPathGroup.NativeMethodInfoPtr_setPath_Protected_Virtual_New_Boolean_String_MoveContext_LocalDataManager_2_String_UnitPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPathGroup>.NativeClassPtr, 100664284);
			UnitPathGroup.NativeMethodInfoPtr_AddPathToContext_Public_Virtual_Void_MoveContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPathGroup>.NativeClassPtr, 100664285);
			UnitPathGroup.NativeMethodInfoPtr_addPathToContext_Protected_Void_MoveContext_LocalDataManager_2_String_UnitPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPathGroup>.NativeClassPtr, 100664286);
			UnitPathGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPathGroup>.NativeClassPtr, 100664287);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00021740 File Offset: 0x0001F940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114202, XrefRangeEnd = 1114210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitPathGroup.NativeMethodInfoPtr_Init_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0002177C File Offset: 0x0001F97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114210, XrefRangeEnd = 1114213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool setPath(string key, MoveContext context, LocalDataManager<string, UnitPath> paths)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitPathGroup.NativeMethodInfoPtr_setPath_Protected_Virtual_New_Boolean_String_MoveContext_LocalDataManager_2_String_UnitPath_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000217F8 File Offset: 0x0001F9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114213, XrefRangeEnd = 1114214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddPathToContext(MoveContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitPathGroup.NativeMethodInfoPtr_AddPathToContext_Public_Virtual_Void_MoveContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00021848 File Offset: 0x0001FA48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1114228, RefRangeEnd = 1114229, XrefRangeStart = 1114214, XrefRangeEnd = 1114228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void addPathToContext(MoveContext context, LocalDataManager<string, UnitPath> paths)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitPathGroup.NativeMethodInfoPtr_addPathToContext_Protected_Void_MoveContext_LocalDataManager_2_String_UnitPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0002189C File Offset: 0x0001FA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitPathGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitPathGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitPathGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00005949 File Offset: 0x00003B49
		public UnitPathGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x000218D8 File Offset: 0x0001FAD8
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00005952 File Offset: 0x00003B52
		public unsafe UnitPath defaultPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPathGroup.NativeFieldInfoPtr_defaultPath);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitPath>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPathGroup.NativeFieldInfoPtr_defaultPath), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00021908 File Offset: 0x0001FB08
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00005971 File Offset: 0x00003B71
		public unsafe List<UnitPath> paths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPathGroup.NativeFieldInfoPtr_paths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitPath>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPathGroup.NativeFieldInfoPtr_paths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00021938 File Offset: 0x0001FB38
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00005990 File Offset: 0x00003B90
		public unsafe LocalDataManager<string, UnitPath> pathMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPathGroup.NativeFieldInfoPtr_pathMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataManager<string, UnitPath>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPathGroup.NativeFieldInfoPtr_pathMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00021968 File Offset: 0x0001FB68
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x000059AF File Offset: 0x00003BAF
		public unsafe ViewManager vm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPathGroup.NativeFieldInfoPtr_vm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPathGroup.NativeFieldInfoPtr_vm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00021998 File Offset: 0x0001FB98
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x000059CE File Offset: 0x00003BCE
		public unsafe string suffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPathGroup.NativeFieldInfoPtr_suffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPathGroup.NativeFieldInfoPtr_suffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeFieldInfoPtr_defaultPath;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeFieldInfoPtr_paths;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeFieldInfoPtr_pathMap;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr_vm;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeFieldInfoPtr_suffix;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_setPath_Protected_Virtual_New_Boolean_String_MoveContext_LocalDataManager_2_String_UnitPath_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_AddPathToContext_Public_Virtual_Void_MoveContext_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_addPathToContext_Protected_Void_MoveContext_LocalDataManager_2_String_UnitPath_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
