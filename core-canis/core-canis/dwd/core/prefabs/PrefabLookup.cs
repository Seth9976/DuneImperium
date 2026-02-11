using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.prefabs
{
	// Token: 0x02000108 RID: 264
	public class PrefabLookup : ScriptableObject
	{
		// Token: 0x06000F30 RID: 3888 RVA: 0x000500D4 File Offset: 0x0004E2D4
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabLookup()
		{
			Il2CppClassPointerStore<PrefabLookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs", "PrefabLookup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabLookup>.NativeClassPtr);
			PrefabLookup.NativeFieldInfoPtr_defaultPathRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLookup>.NativeClassPtr, "defaultPathRoot");
			PrefabLookup.NativeFieldInfoPtr_folder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLookup>.NativeClassPtr, "folder");
			PrefabLookup.NativeFieldInfoPtr_simplifyNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLookup>.NativeClassPtr, "simplifyNames");
			PrefabLookup.NativeMethodInfoPtr_get_Folders_Public_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup>.NativeClassPtr, 100665516);
			PrefabLookup.NativeMethodInfoPtr_get_SimplifyNames_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup>.NativeClassPtr, 100665517);
			PrefabLookup.NativeMethodInfoPtr_get_PathRoot_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup>.NativeClassPtr, 100665518);
			PrefabLookup.NativeMethodInfoPtr_get_EntryCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup>.NativeClassPtr, 100665519);
			PrefabLookup.NativeMethodInfoPtr_GetMonoType_Public_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup>.NativeClassPtr, 100665520);
			PrefabLookup.NativeMethodInfoPtr_GetMetaType_Public_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup>.NativeClassPtr, 100665521);
			PrefabLookup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLookup>.NativeClassPtr, 100665522);
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x000501CC File Offset: 0x0004E3CC
		public unsafe virtual Il2CppStringArray Folders
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868106, XrefRangeEnd = 868110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookup.NativeMethodInfoPtr_get_Folders_Public_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x00050218 File Offset: 0x0004E418
		public unsafe virtual bool SimplifyNames
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookup.NativeMethodInfoPtr_get_SimplifyNames_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00050260 File Offset: 0x0004E460
		public unsafe virtual string PathRoot
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookup.NativeMethodInfoPtr_get_PathRoot_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x000502A4 File Offset: 0x0004E4A4
		public unsafe virtual int EntryCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookup.NativeMethodInfoPtr_get_EntryCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x000502EC File Offset: 0x0004E4EC
		[CallerCount(0)]
		public unsafe virtual Type GetMonoType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookup.NativeMethodInfoPtr_GetMonoType_Public_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00050338 File Offset: 0x0004E538
		[CallerCount(0)]
		public unsafe virtual Type GetMetaType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLookup.NativeMethodInfoPtr_GetMetaType_Public_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00050384 File Offset: 0x0004E584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 868118, RefRangeEnd = 868120, XrefRangeStart = 868110, XrefRangeEnd = 868118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabLookup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLookup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLookup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x0000721E File Offset: 0x0000541E
		public PrefabLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x000503C0 File Offset: 0x0004E5C0
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x00007227 File Offset: 0x00005427
		public unsafe string defaultPathRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLookup.NativeFieldInfoPtr_defaultPathRoot);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLookup.NativeFieldInfoPtr_defaultPathRoot), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x000503E8 File Offset: 0x0004E5E8
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x00007246 File Offset: 0x00005446
		public unsafe string folder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLookup.NativeFieldInfoPtr_folder);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLookup.NativeFieldInfoPtr_folder), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00050410 File Offset: 0x0004E610
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x00007265 File Offset: 0x00005465
		public unsafe bool simplifyNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLookup.NativeFieldInfoPtr_simplifyNames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLookup.NativeFieldInfoPtr_simplifyNames)) = value;
			}
		}

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeFieldInfoPtr_defaultPathRoot;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeFieldInfoPtr_folder;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeFieldInfoPtr_simplifyNames;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_get_Folders_Public_Virtual_New_get_Il2CppStringArray_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr_get_SimplifyNames_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr_get_PathRoot_Public_Virtual_New_get_String_0;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr_get_EntryCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeMethodInfoPtr_GetMonoType_Public_Abstract_Virtual_New_Type_0;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_GetMetaType_Public_Abstract_Virtual_New_Type_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
