using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.input.context
{
	// Token: 0x02000078 RID: 120
	public sealed class CreateMultiHeirarchyInputContext : CreateInputContext
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x0001582C File Offset: 0x00013A2C
		// Note: this type is marked as 'beforefieldinit'.
		static CreateMultiHeirarchyInputContext()
		{
			Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.context", "CreateMultiHeirarchyInputContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr);
			CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_hierarchyParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, "hierarchyParents");
			CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_dynamicParentTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, "dynamicParentTransforms");
			CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, "cachedVersion");
			CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, "started");
			CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_inputContextID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, "inputContextID");
			CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_get_availableSelectables_Protected_Virtual_get_IEnumerable_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, 100663845);
			CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_get_Version_Private_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, 100663846);
			CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, 100663847);
			CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, 100663848);
			CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, 100663849);
			CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, 100663850);
			CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, 100663851);
			CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, 100663852);
			CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_updateDynamicTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, 100663853);
			CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_getSelectablesInHierarchies_Private_IEnumerable_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, 100663854);
			CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_RegisterHierarchyParent_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, 100663855);
			CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_RemoveHierarchyParent_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, 100663856);
			CreateMultiHeirarchyInputContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, 100663857);
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000159C4 File Offset: 0x00013BC4
		public unsafe override IEnumerable<Selectable> availableSelectables
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123077, XrefRangeEnd = 1123083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_get_availableSelectables_Protected_Virtual_get_IEnumerable_1_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Selectable>>(intPtr3) : null;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00015A04 File Offset: 0x00013C04
		public unsafe ulong Version
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1123097, RefRangeEnd = 1123099, XrefRangeStart = 1123083, XrefRangeEnd = 1123097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_get_Version_Private_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00015A40 File Offset: 0x00013C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123099, XrefRangeEnd = 1123117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00015A74 File Offset: 0x00013C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123117, XrefRangeEnd = 1123141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00015AA8 File Offset: 0x00013CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123141, XrefRangeEnd = 1123143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00015ADC File Offset: 0x00013CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123143, XrefRangeEnd = 1123147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00015B10 File Offset: 0x00013D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123147, XrefRangeEnd = 1123148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00015B44 File Offset: 0x00013D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123148, XrefRangeEnd = 1123151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00015B78 File Offset: 0x00013D78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1123195, RefRangeEnd = 1123198, XrefRangeStart = 1123151, XrefRangeEnd = 1123195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateDynamicTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_updateDynamicTransforms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00015BAC File Offset: 0x00013DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Selectable> getSelectablesInHierarchies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_getSelectablesInHierarchies_Private_IEnumerable_1_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Selectable>>(intPtr3) : null;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00015BEC File Offset: 0x00013DEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1123208, RefRangeEnd = 1123211, XrefRangeStart = 1123198, XrefRangeEnd = 1123208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterHierarchyParent(Transform hierarchyParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hierarchyParent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_RegisterHierarchyParent_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00015C30 File Offset: 0x00013E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123211, XrefRangeEnd = 1123218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveHierarchyParent(Transform hierarchyParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hierarchyParent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.NativeMethodInfoPtr_RemoveHierarchyParent_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00015C74 File Offset: 0x00013E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123218, XrefRangeEnd = 1123236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateMultiHeirarchyInputContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00004AC8 File Offset: 0x00002CC8
		public CreateMultiHeirarchyInputContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00015CB0 File Offset: 0x00013EB0
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00004AD1 File Offset: 0x00002CD1
		public unsafe List<Transform> hierarchyParents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_hierarchyParents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_hierarchyParents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00015CE0 File Offset: 0x00013EE0
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00004AF0 File Offset: 0x00002CF0
		public unsafe List<VersionedParentTransform> dynamicParentTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_dynamicParentTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VersionedParentTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_dynamicParentTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00015D10 File Offset: 0x00013F10
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00004B0F File Offset: 0x00002D0F
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00015D38 File Offset: 0x00013F38
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00004B2A File Offset: 0x00002D2A
		public unsafe bool started
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_started);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_started)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00015D60 File Offset: 0x00013F60
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00004B45 File Offset: 0x00002D45
		public unsafe string inputContextID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_inputContextID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.NativeFieldInfoPtr_inputContextID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeFieldInfoPtr_hierarchyParents;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr_dynamicParentTransforms;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeFieldInfoPtr_started;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeFieldInfoPtr_inputContextID;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_get_availableSelectables_Protected_Virtual_get_IEnumerable_1_Selectable_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Private_get_UInt64_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_updateDynamicTransforms_Private_Void_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_getSelectablesInHierarchies_Private_IEnumerable_1_Selectable_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_RegisterHierarchyParent_Public_Void_Transform_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_RemoveHierarchyParent_Public_Void_Transform_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000CE RID: 206
		[ObfuscatedName("dwd.core.input.context.CreateMultiHeirarchyInputContext+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000920 RID: 2336 RVA: 0x0002469C File Offset: 0x0002289C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c>.NativeClassPtr);
				CreateMultiHeirarchyInputContext.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c>.NativeClassPtr, "<>9");
				CreateMultiHeirarchyInputContext.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c>.NativeClassPtr, "<>9__15_0");
				CreateMultiHeirarchyInputContext.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c>.NativeClassPtr, "<>9__16_1");
				CreateMultiHeirarchyInputContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c>.NativeClassPtr, 100663859);
				CreateMultiHeirarchyInputContext.__c.NativeMethodInfoPtr__updateDynamicTransforms_b__15_0_Internal_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c>.NativeClassPtr, 100663860);
				CreateMultiHeirarchyInputContext.__c.NativeMethodInfoPtr__getSelectablesInHierarchies_b__16_1_Internal_Transform_TerminateHeirarchicalContextTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c>.NativeClassPtr, 100663861);
			}

			// Token: 0x06000921 RID: 2337 RVA: 0x00024740 File Offset: 0x00022940
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000922 RID: 2338 RVA: 0x0002477C File Offset: 0x0002297C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122970, XrefRangeEnd = 1122974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _updateDynamicTransforms_b__15_0(Transform hp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hp);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.__c.NativeMethodInfoPtr__updateDynamicTransforms_b__15_0_Internal_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000923 RID: 2339 RVA: 0x000247CC File Offset: 0x000229CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122974, XrefRangeEnd = 1122976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Transform _getSelectablesInHierarchies_b__16_1(TerminateHeirarchicalContextTree t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.__c.NativeMethodInfoPtr__getSelectablesInHierarchies_b__16_1_Internal_Transform_TerminateHeirarchicalContextTree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
				}
			}

			// Token: 0x06000924 RID: 2340 RVA: 0x00006C0F File Offset: 0x00004E0F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x06000925 RID: 2341 RVA: 0x0002481C File Offset: 0x00022A1C
			// (set) Token: 0x06000926 RID: 2342 RVA: 0x00006C18 File Offset: 0x00004E18
			public unsafe static CreateMultiHeirarchyInputContext.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CreateMultiHeirarchyInputContext.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateMultiHeirarchyInputContext.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CreateMultiHeirarchyInputContext.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x06000927 RID: 2343 RVA: 0x00024844 File Offset: 0x00022A44
			// (set) Token: 0x06000928 RID: 2344 RVA: 0x00006C2A File Offset: 0x00004E2A
			public unsafe static Func<Transform, bool> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CreateMultiHeirarchyInputContext.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CreateMultiHeirarchyInputContext.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x06000929 RID: 2345 RVA: 0x0002486C File Offset: 0x00022A6C
			// (set) Token: 0x0600092A RID: 2346 RVA: 0x00006C3C File Offset: 0x00004E3C
			public unsafe static Func<TerminateHeirarchicalContextTree, Transform> __9__16_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CreateMultiHeirarchyInputContext.__c.NativeFieldInfoPtr___9__16_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TerminateHeirarchicalContextTree, Transform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CreateMultiHeirarchyInputContext.__c.NativeFieldInfoPtr___9__16_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005A9 RID: 1449
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040005AA RID: 1450
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x040005AB RID: 1451
			private static readonly IntPtr NativeFieldInfoPtr___9__16_1;

			// Token: 0x040005AC RID: 1452
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005AD RID: 1453
			private static readonly IntPtr NativeMethodInfoPtr__updateDynamicTransforms_b__15_0_Internal_Boolean_Transform_0;

			// Token: 0x040005AE RID: 1454
			private static readonly IntPtr NativeMethodInfoPtr__getSelectablesInHierarchies_b__16_1_Internal_Transform_TerminateHeirarchicalContextTree_0;
		}

		// Token: 0x020000CF RID: 207
		[ObfuscatedName("dwd.core.input.context.CreateMultiHeirarchyInputContext+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600092B RID: 2347 RVA: 0x00024894 File Offset: 0x00022A94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c__DisplayClass16_0>.NativeClassPtr);
				CreateMultiHeirarchyInputContext.__c__DisplayClass16_0.NativeFieldInfoPtr_hierarchyParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c__DisplayClass16_0>.NativeClassPtr, "hierarchyParent");
				CreateMultiHeirarchyInputContext.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				CreateMultiHeirarchyInputContext.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c__DisplayClass16_0>.NativeClassPtr, 100663862);
				CreateMultiHeirarchyInputContext.__c__DisplayClass16_0.NativeMethodInfoPtr__getSelectablesInHierarchies_b__0_Internal_Boolean_TerminateHeirarchicalContextTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c__DisplayClass16_0>.NativeClassPtr, 100663863);
			}

			// Token: 0x0600092C RID: 2348 RVA: 0x00024910 File Offset: 0x00022B10
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600092D RID: 2349 RVA: 0x0002494C File Offset: 0x00022B4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122976, XrefRangeEnd = 1122982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _getSelectablesInHierarchies_b__0(TerminateHeirarchicalContextTree t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext.__c__DisplayClass16_0.NativeMethodInfoPtr__getSelectablesInHierarchies_b__0_Internal_Boolean_TerminateHeirarchicalContextTree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600092E RID: 2350 RVA: 0x00006C4E File Offset: 0x00004E4E
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002A7 RID: 679
			// (get) Token: 0x0600092F RID: 2351 RVA: 0x0002499C File Offset: 0x00022B9C
			// (set) Token: 0x06000930 RID: 2352 RVA: 0x00006C57 File Offset: 0x00004E57
			public unsafe Transform hierarchyParent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.__c__DisplayClass16_0.NativeFieldInfoPtr_hierarchyParent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.__c__DisplayClass16_0.NativeFieldInfoPtr_hierarchyParent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002A8 RID: 680
			// (get) Token: 0x06000931 RID: 2353 RVA: 0x000249CC File Offset: 0x00022BCC
			// (set) Token: 0x06000932 RID: 2354 RVA: 0x00006C76 File Offset: 0x00004E76
			public unsafe CreateMultiHeirarchyInputContext __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateMultiHeirarchyInputContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040005AF RID: 1455
			private static readonly IntPtr NativeFieldInfoPtr_hierarchyParent;

			// Token: 0x040005B0 RID: 1456
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040005B1 RID: 1457
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040005B2 RID: 1458
			private static readonly IntPtr NativeMethodInfoPtr__getSelectablesInHierarchies_b__0_Internal_Boolean_TerminateHeirarchicalContextTree_0;
		}

		// Token: 0x020000D0 RID: 208
		[ObfuscatedName("dwd.core.input.context.CreateMultiHeirarchyInputContext+<getSelectablesInHierarchies>d__16")]
		public sealed class _getSelectablesInHierarchies_d__16 : global::Il2CppSystem.Object
		{
			// Token: 0x06000933 RID: 2355 RVA: 0x000249FC File Offset: 0x00022BFC
			// Note: this type is marked as 'beforefieldinit'.
			static _getSelectablesInHierarchies_d__16()
			{
				Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext>.NativeClassPtr, "<getSelectablesInHierarchies>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr);
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, "<>1__state");
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, "<>2__current");
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, "<>l__initialThreadId");
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, "<>4__this");
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, "<>8__1");
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, "<>7__wrap1");
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr__ignoredList_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, "<ignoredList>5__3");
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, "<>7__wrap3");
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, "<>7__wrap4");
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, 100663864);
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, 100663865);
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, 100663866);
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, 100663867);
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UI_Selectable__get_Current_Private_Virtual_Final_New_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, 100663868);
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, 100663869);
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, 100663870);
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UI_Selectable__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, 100663871);
				CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr, 100663872);
			}

			// Token: 0x06000934 RID: 2356 RVA: 0x00024B90 File Offset: 0x00022D90
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _getSelectablesInHierarchies_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000935 RID: 2357 RVA: 0x00024BD8 File Offset: 0x00022DD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122982, XrefRangeEnd = 1122987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000936 RID: 2358 RVA: 0x00024C0C File Offset: 0x00022E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122987, XrefRangeEnd = 1123067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000937 RID: 2359 RVA: 0x00024C48 File Offset: 0x00022E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123067, XrefRangeEnd = 1123070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x06000938 RID: 2360 RVA: 0x00024C7C File Offset: 0x00022E7C
			public unsafe Selectable System.Collections.Generic.IEnumerator<UnityEngine.UI.Selectable>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UI_Selectable__get_Current_Private_Virtual_Final_New_get_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
				}
			}

			// Token: 0x06000939 RID: 2361 RVA: 0x00024CBC File Offset: 0x00022EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123070, XrefRangeEnd = 1123075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170002B3 RID: 691
			// (get) Token: 0x0600093A RID: 2362 RVA: 0x00024CF0 File Offset: 0x00022EF0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600093B RID: 2363 RVA: 0x00024D30 File Offset: 0x00022F30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123075, XrefRangeEnd = 1123077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Selectable> System_Collections_Generic_IEnumerable_UnityEngine_UI_Selectable__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UI_Selectable__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Selectable>>(intPtr3) : null;
			}

			// Token: 0x0600093C RID: 2364 RVA: 0x00024D70 File Offset: 0x00022F70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600093D RID: 2365 RVA: 0x00006C95 File Offset: 0x00004E95
			public _getSelectablesInHierarchies_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002A9 RID: 681
			// (get) Token: 0x0600093E RID: 2366 RVA: 0x00024DB0 File Offset: 0x00022FB0
			// (set) Token: 0x0600093F RID: 2367 RVA: 0x00006C9E File Offset: 0x00004E9E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170002AA RID: 682
			// (get) Token: 0x06000940 RID: 2368 RVA: 0x00024DD8 File Offset: 0x00022FD8
			// (set) Token: 0x06000941 RID: 2369 RVA: 0x00006CB9 File Offset: 0x00004EB9
			public unsafe Selectable __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002AB RID: 683
			// (get) Token: 0x06000942 RID: 2370 RVA: 0x00024E08 File Offset: 0x00023008
			// (set) Token: 0x06000943 RID: 2371 RVA: 0x00006CD8 File Offset: 0x00004ED8
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x06000944 RID: 2372 RVA: 0x00024E30 File Offset: 0x00023030
			// (set) Token: 0x06000945 RID: 2373 RVA: 0x00006CF3 File Offset: 0x00004EF3
			public unsafe CreateMultiHeirarchyInputContext __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateMultiHeirarchyInputContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002AD RID: 685
			// (get) Token: 0x06000946 RID: 2374 RVA: 0x00024E60 File Offset: 0x00023060
			// (set) Token: 0x06000947 RID: 2375 RVA: 0x00006D12 File Offset: 0x00004F12
			public unsafe CreateMultiHeirarchyInputContext.__c__DisplayClass16_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateMultiHeirarchyInputContext.__c__DisplayClass16_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002AE RID: 686
			// (get) Token: 0x06000948 RID: 2376 RVA: 0x00024E90 File Offset: 0x00023090
			// (set) Token: 0x06000949 RID: 2377 RVA: 0x00006D31 File Offset: 0x00004F31
			public List<Transform>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___7__wrap1);
					return new List<Transform>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Transform>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Transform>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170002AF RID: 687
			// (get) Token: 0x0600094A RID: 2378 RVA: 0x00024EC0 File Offset: 0x000230C0
			// (set) Token: 0x0600094B RID: 2379 RVA: 0x00006D5F File Offset: 0x00004F5F
			public unsafe Il2CppReferenceArray<Transform> _ignoredList_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr__ignoredList_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr__ignoredList_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002B0 RID: 688
			// (get) Token: 0x0600094C RID: 2380 RVA: 0x00024EF0 File Offset: 0x000230F0
			// (set) Token: 0x0600094D RID: 2381 RVA: 0x00006D7E File Offset: 0x00004F7E
			public unsafe Il2CppReferenceArray<Selectable> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002B1 RID: 689
			// (get) Token: 0x0600094E RID: 2382 RVA: 0x00024F20 File Offset: 0x00023120
			// (set) Token: 0x0600094F RID: 2383 RVA: 0x00006D9D File Offset: 0x00004F9D
			public unsafe int __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___7__wrap4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMultiHeirarchyInputContext._getSelectablesInHierarchies_d__16.NativeFieldInfoPtr___7__wrap4)) = value;
				}
			}

			// Token: 0x040005B3 RID: 1459
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040005B4 RID: 1460
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040005B5 RID: 1461
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040005B6 RID: 1462
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040005B7 RID: 1463
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040005B8 RID: 1464
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040005B9 RID: 1465
			private static readonly IntPtr NativeFieldInfoPtr__ignoredList_5__3;

			// Token: 0x040005BA RID: 1466
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040005BB RID: 1467
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x040005BC RID: 1468
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040005BD RID: 1469
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040005BE RID: 1470
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040005BF RID: 1471
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040005C0 RID: 1472
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UI_Selectable__get_Current_Private_Virtual_Final_New_get_Selectable_0;

			// Token: 0x040005C1 RID: 1473
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040005C2 RID: 1474
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040005C3 RID: 1475
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UI_Selectable__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Selectable_0;

			// Token: 0x040005C4 RID: 1476
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
