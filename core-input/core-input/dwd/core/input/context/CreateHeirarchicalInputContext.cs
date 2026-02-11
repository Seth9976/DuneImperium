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
	// Token: 0x02000076 RID: 118
	public sealed class CreateHeirarchicalInputContext : CreateInputContext
	{
		// Token: 0x0600047D RID: 1149 RVA: 0x00014C54 File Offset: 0x00012E54
		// Note: this type is marked as 'beforefieldinit'.
		static CreateHeirarchicalInputContext()
		{
			Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input.context", "CreateHeirarchicalInputContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr);
			CreateHeirarchicalInputContext.NativeFieldInfoPtr_dynamicParentTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr, "dynamicParentTransforms");
			CreateHeirarchicalInputContext.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr, "cachedVersion");
			CreateHeirarchicalInputContext.NativeMethodInfoPtr_get_availableSelectables_Protected_Virtual_get_IEnumerable_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr, 100663798);
			CreateHeirarchicalInputContext.NativeMethodInfoPtr_get_Version_Private_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr, 100663799);
			CreateHeirarchicalInputContext.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr, 100663800);
			CreateHeirarchicalInputContext.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr, 100663801);
			CreateHeirarchicalInputContext.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr, 100663802);
			CreateHeirarchicalInputContext.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr, 100663803);
			CreateHeirarchicalInputContext.NativeMethodInfoPtr_initializeDynamicTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr, 100663804);
			CreateHeirarchicalInputContext.NativeMethodInfoPtr_getSelectablesInChildren_Private_Static_IEnumerable_1_Selectable_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr, 100663805);
			CreateHeirarchicalInputContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr, 100663806);
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00014D60 File Offset: 0x00012F60
		public unsafe override IEnumerable<Selectable> availableSelectables
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122783, XrefRangeEnd = 1122790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext.NativeMethodInfoPtr_get_availableSelectables_Protected_Virtual_get_IEnumerable_1_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Selectable>>(intPtr3) : null;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00014DA0 File Offset: 0x00012FA0
		public unsafe ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122790, XrefRangeEnd = 1122791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext.NativeMethodInfoPtr_get_Version_Private_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00014DDC File Offset: 0x00012FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122791, XrefRangeEnd = 1122798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00014E10 File Offset: 0x00013010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122798, XrefRangeEnd = 1122801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00014E44 File Offset: 0x00013044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122801, XrefRangeEnd = 1122802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00014E78 File Offset: 0x00013078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122802, XrefRangeEnd = 1122809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00014EAC File Offset: 0x000130AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122809, XrefRangeEnd = 1122815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initializeDynamicTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext.NativeMethodInfoPtr_initializeDynamicTransforms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00014EE0 File Offset: 0x000130E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122815, XrefRangeEnd = 1122821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Selectable> getSelectablesInChildren(GameObject go)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext.NativeMethodInfoPtr_getSelectablesInChildren_Private_Static_IEnumerable_1_Selectable_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Selectable>>(intPtr3) : null;
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00014F24 File Offset: 0x00013124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122821, XrefRangeEnd = 1122822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateHeirarchicalInputContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0000496D File Offset: 0x00002B6D
		public CreateHeirarchicalInputContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00014F60 File Offset: 0x00013160
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00004976 File Offset: 0x00002B76
		public unsafe Il2CppReferenceArray<VersionedParentTransform> dynamicParentTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext.NativeFieldInfoPtr_dynamicParentTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VersionedParentTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext.NativeFieldInfoPtr_dynamicParentTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00014F90 File Offset: 0x00013190
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00004995 File Offset: 0x00002B95
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr_dynamicParentTransforms;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_get_availableSelectables_Protected_Virtual_get_IEnumerable_1_Selectable_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Private_get_UInt64_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_initializeDynamicTransforms_Private_Void_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_getSelectablesInChildren_Private_Static_IEnumerable_1_Selectable_GameObject_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000CB RID: 203
		[ObfuscatedName("dwd.core.input.context.CreateHeirarchicalInputContext+<getSelectablesInChildren>d__11")]
		public sealed class _getSelectablesInChildren_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x060008E8 RID: 2280 RVA: 0x00023BF0 File Offset: 0x00021DF0
			// Note: this type is marked as 'beforefieldinit'.
			static _getSelectablesInChildren_d__11()
			{
				Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateHeirarchicalInputContext>.NativeClassPtr, "<getSelectablesInChildren>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr);
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, "<>1__state");
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, "<>2__current");
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, "<>l__initialThreadId");
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr_go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, "go");
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___3__go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, "<>3__go");
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr__ignoredList_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, "<ignoredList>5__2");
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, "<>7__wrap2");
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, "<>7__wrap3");
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, 100663807);
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, 100663808);
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, 100663809);
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UI_Selectable__get_Current_Private_Virtual_Final_New_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, 100663810);
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, 100663811);
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, 100663812);
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UI_Selectable__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, 100663813);
				CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr, 100663814);
			}

			// Token: 0x060008E9 RID: 2281 RVA: 0x00023D5C File Offset: 0x00021F5C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _getSelectablesInChildren_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateHeirarchicalInputContext._getSelectablesInChildren_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060008EA RID: 2282 RVA: 0x00023DA4 File Offset: 0x00021FA4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060008EB RID: 2283 RVA: 0x00023DD8 File Offset: 0x00021FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122737, XrefRangeEnd = 1122770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x060008EC RID: 2284 RVA: 0x00023E14 File Offset: 0x00022014
			public unsafe Selectable System.Collections.Generic.IEnumerator<UnityEngine.UI.Selectable>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UI_Selectable__get_Current_Private_Virtual_Final_New_get_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
				}
			}

			// Token: 0x060008ED RID: 2285 RVA: 0x00023E54 File Offset: 0x00022054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122770, XrefRangeEnd = 1122775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x060008EE RID: 2286 RVA: 0x00023E88 File Offset: 0x00022088
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060008EF RID: 2287 RVA: 0x00023EC8 File Offset: 0x000220C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122775, XrefRangeEnd = 1122783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Selectable> System_Collections_Generic_IEnumerable_UnityEngine_UI_Selectable__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UI_Selectable__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Selectable>>(intPtr3) : null;
			}

			// Token: 0x060008F0 RID: 2288 RVA: 0x00023F08 File Offset: 0x00022108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060008F1 RID: 2289 RVA: 0x00006A37 File Offset: 0x00004C37
			public _getSelectablesInChildren_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700028F RID: 655
			// (get) Token: 0x060008F2 RID: 2290 RVA: 0x00023F48 File Offset: 0x00022148
			// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00006A40 File Offset: 0x00004C40
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000290 RID: 656
			// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00023F70 File Offset: 0x00022170
			// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00006A5B File Offset: 0x00004C5B
			public unsafe Selectable __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x060008F6 RID: 2294 RVA: 0x00023FA0 File Offset: 0x000221A0
			// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00006A7A File Offset: 0x00004C7A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00023FC8 File Offset: 0x000221C8
			// (set) Token: 0x060008F9 RID: 2297 RVA: 0x00006A95 File Offset: 0x00004C95
			public unsafe GameObject go
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr_go);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr_go), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000293 RID: 659
			// (get) Token: 0x060008FA RID: 2298 RVA: 0x00023FF8 File Offset: 0x000221F8
			// (set) Token: 0x060008FB RID: 2299 RVA: 0x00006AB4 File Offset: 0x00004CB4
			public unsafe GameObject __3__go
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___3__go);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___3__go), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000294 RID: 660
			// (get) Token: 0x060008FC RID: 2300 RVA: 0x00024028 File Offset: 0x00022228
			// (set) Token: 0x060008FD RID: 2301 RVA: 0x00006AD3 File Offset: 0x00004CD3
			public unsafe Il2CppReferenceArray<TerminateHeirarchicalContextTree> _ignoredList_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr__ignoredList_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TerminateHeirarchicalContextTree>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr__ignoredList_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000295 RID: 661
			// (get) Token: 0x060008FE RID: 2302 RVA: 0x00024058 File Offset: 0x00022258
			// (set) Token: 0x060008FF RID: 2303 RVA: 0x00006AF2 File Offset: 0x00004CF2
			public unsafe Il2CppReferenceArray<Selectable> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x06000900 RID: 2304 RVA: 0x00024088 File Offset: 0x00022288
			// (set) Token: 0x06000901 RID: 2305 RVA: 0x00006B11 File Offset: 0x00004D11
			public unsafe int __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___7__wrap3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateHeirarchicalInputContext._getSelectablesInChildren_d__11.NativeFieldInfoPtr___7__wrap3)) = value;
				}
			}

			// Token: 0x04000586 RID: 1414
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000587 RID: 1415
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000588 RID: 1416
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04000589 RID: 1417
			private static readonly IntPtr NativeFieldInfoPtr_go;

			// Token: 0x0400058A RID: 1418
			private static readonly IntPtr NativeFieldInfoPtr___3__go;

			// Token: 0x0400058B RID: 1419
			private static readonly IntPtr NativeFieldInfoPtr__ignoredList_5__2;

			// Token: 0x0400058C RID: 1420
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400058D RID: 1421
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400058E RID: 1422
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400058F RID: 1423
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000590 RID: 1424
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000591 RID: 1425
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_UI_Selectable__get_Current_Private_Virtual_Final_New_get_Selectable_0;

			// Token: 0x04000592 RID: 1426
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000593 RID: 1427
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000594 RID: 1428
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UI_Selectable__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Selectable_0;

			// Token: 0x04000595 RID: 1429
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
