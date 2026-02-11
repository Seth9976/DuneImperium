using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

namespace dwd.core.prefabs
{
	// Token: 0x02000105 RID: 261
	public static class LookupUtil : global::Il2CppSystem.Object
	{
		// Token: 0x06000F1E RID: 3870 RVA: 0x0004FB1C File Offset: 0x0004DD1C
		// Note: this type is marked as 'beforefieldinit'.
		static LookupUtil()
		{
			Il2CppClassPointerStore<LookupUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs", "LookupUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookupUtil>.NativeClassPtr);
			LookupUtil.NativeMethodInfoPtr_GetPrefab_Public_Static_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupUtil>.NativeClassPtr, 100665494);
			LookupUtil.NativeMethodInfoPtr_GetAndInstantiatePrefab_Public_Static_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Transform_Boolean_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupUtil>.NativeClassPtr, 100665495);
			LookupUtil.NativeMethodInfoPtr_GetPrefabAsync_Public_Static_Task_1_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupUtil>.NativeClassPtr, 100665496);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0004FB88 File Offset: 0x0004DD88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 868022, RefRangeEnd = 868025, XrefRangeStart = 868007, XrefRangeEnd = 868022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TPrefab GetPrefab<TMeta, TPrefab>(PrefabLookup<TMeta> lookup, IMetadataMatcher<TMeta> matcher, global::UnityEngine.Object context = null, bool warnOnLookupFailure = true) where TMeta : new() where TPrefab : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matcher);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warnOnLookupFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupUtil.MethodInfoStoreGeneric_GetPrefab_Public_Static_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Object_Boolean_0<TMeta, TPrefab>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TPrefab>(intPtr, false, true);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0004FBF8 File Offset: 0x0004DDF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 868037, RefRangeEnd = 868038, XrefRangeStart = 868025, XrefRangeEnd = 868037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TPrefab GetAndInstantiatePrefab<TMeta, TPrefab>(PrefabLookup<TMeta> lookup, IMetadataMatcher<TMeta> matcher, Transform parent = null, bool worldPositionStays = false, bool warnOnLookupFailure = true, global::UnityEngine.Object context = null) where TMeta : new() where TPrefab : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matcher);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warnOnLookupFailure;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupUtil.MethodInfoStoreGeneric_GetAndInstantiatePrefab_Public_Static_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Transform_Boolean_Boolean_Object_0<TMeta, TPrefab>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TPrefab>(intPtr, false, true);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0004FC8C File Offset: 0x0004DE8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 868048, RefRangeEnd = 868049, XrefRangeStart = 868038, XrefRangeEnd = 868048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TPrefab> GetPrefabAsync<TMeta, TPrefab>(PrefabLookup<TMeta> lookup, IMetadataMatcher<TMeta> matcher, global::UnityEngine.Object context = null, bool warnOnLookupFailure = true) where TMeta : new() where TPrefab : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matcher);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warnOnLookupFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupUtil.MethodInfoStoreGeneric_GetPrefabAsync_Public_Static_Task_1_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Object_Boolean_0<TMeta, TPrefab>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TPrefab>>(intPtr3) : null;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x000071E8 File Offset: 0x000053E8
		public LookupUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefab_Public_Static_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Object_Boolean_0;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr_GetAndInstantiatePrefab_Public_Static_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Transform_Boolean_Boolean_Object_0;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefabAsync_Public_Static_Task_1_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Object_Boolean_0;

		// Token: 0x020002BA RID: 698
		[ObfuscatedName("dwd.core.prefabs.LookupUtil+<GetPrefabAsync>d__2`2")]
		public sealed class _GetPrefabAsync_d__2<TMeta, TPrefab> : ValueType where TMeta : new() where TPrefab : global::UnityEngine.Object
		{
			// Token: 0x060020A7 RID: 8359 RVA: 0x00093520 File Offset: 0x00091720
			// Note: this type is marked as 'beforefieldinit'.
			static _GetPrefabAsync_d__2()
			{
				Il2CppClassPointerStore<LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LookupUtil>.NativeClassPtr, "<GetPrefabAsync>d__2`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMeta>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrefab>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>>.NativeClassPtr);
				LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>>.NativeClassPtr, "<>1__state");
				LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>>.NativeClassPtr, "<>t__builder");
				LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr_lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>>.NativeClassPtr, "lookup");
				LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr_matcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>>.NativeClassPtr, "matcher");
				LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>>.NativeClassPtr, "context");
				LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr_warnOnLookupFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>>.NativeClassPtr, "warnOnLookupFailure");
				LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>>.NativeClassPtr, "<>u__1");
				LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>>.NativeClassPtr, 100665497);
				LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>>.NativeClassPtr, 100665498);
			}

			// Token: 0x060020A8 RID: 8360 RVA: 0x0009364C File Offset: 0x0009184C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867977, XrefRangeEnd = 868002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020A9 RID: 8361 RVA: 0x00093684 File Offset: 0x00091884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868002, XrefRangeEnd = 868007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020AA RID: 8362 RVA: 0x0000DE48 File Offset: 0x0000C048
			public _GetPrefabAsync_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020AB RID: 8363 RVA: 0x0000DE51 File Offset: 0x0000C051
			public _GetPrefabAsync_d__2()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>>.NativeClassPtr))
			{
			}

			// Token: 0x170008E0 RID: 2272
			// (get) Token: 0x060020AC RID: 8364 RVA: 0x000936CC File Offset: 0x000918CC
			// (set) Token: 0x060020AD RID: 8365 RVA: 0x0000DE63 File Offset: 0x0000C063
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008E1 RID: 2273
			// (get) Token: 0x060020AE RID: 8366 RVA: 0x000936F4 File Offset: 0x000918F4
			// (set) Token: 0x060020AF RID: 8367 RVA: 0x0000DE7E File Offset: 0x0000C07E
			public AsyncTaskMethodBuilder<TPrefab> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TPrefab>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TPrefab>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TPrefab>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008E2 RID: 2274
			// (get) Token: 0x060020B0 RID: 8368 RVA: 0x00093724 File Offset: 0x00091924
			// (set) Token: 0x060020B1 RID: 8369 RVA: 0x0000DEAC File Offset: 0x0000C0AC
			public unsafe PrefabLookup<TMeta> lookup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr_lookup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabLookup<TMeta>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr_lookup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E3 RID: 2275
			// (get) Token: 0x060020B2 RID: 8370 RVA: 0x00093754 File Offset: 0x00091954
			// (set) Token: 0x060020B3 RID: 8371 RVA: 0x0000DECB File Offset: 0x0000C0CB
			public unsafe IMetadataMatcher<TMeta> matcher
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr_matcher);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMetadataMatcher<TMeta>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr_matcher), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E4 RID: 2276
			// (get) Token: 0x060020B4 RID: 8372 RVA: 0x00093784 File Offset: 0x00091984
			// (set) Token: 0x060020B5 RID: 8373 RVA: 0x0000DEEA File Offset: 0x0000C0EA
			public unsafe global::UnityEngine.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E5 RID: 2277
			// (get) Token: 0x060020B6 RID: 8374 RVA: 0x000937B4 File Offset: 0x000919B4
			// (set) Token: 0x060020B7 RID: 8375 RVA: 0x0000DF09 File Offset: 0x0000C109
			public unsafe bool warnOnLookupFailure
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr_warnOnLookupFailure);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr_warnOnLookupFailure)) = value;
				}
			}

			// Token: 0x170008E6 RID: 2278
			// (get) Token: 0x060020B8 RID: 8376 RVA: 0x000937DC File Offset: 0x000919DC
			// (set) Token: 0x060020B9 RID: 8377 RVA: 0x0000DF24 File Offset: 0x0000C124
			public TaskAwaiter<TPrefab> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<TPrefab>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<TPrefab>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupUtil._GetPrefabAsync_d__2<TMeta, TPrefab>.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<TPrefab>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040016B6 RID: 5814
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016B7 RID: 5815
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040016B8 RID: 5816
			private static readonly IntPtr NativeFieldInfoPtr_lookup;

			// Token: 0x040016B9 RID: 5817
			private static readonly IntPtr NativeFieldInfoPtr_matcher;

			// Token: 0x040016BA RID: 5818
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040016BB RID: 5819
			private static readonly IntPtr NativeFieldInfoPtr_warnOnLookupFailure;

			// Token: 0x040016BC RID: 5820
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040016BD RID: 5821
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016BE RID: 5822
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002BB RID: 699
		private sealed class MethodInfoStoreGeneric_GetPrefab_Public_Static_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Object_Boolean_0<TMeta, TPrefab>
		{
			// Token: 0x040016BF RID: 5823
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LookupUtil.NativeMethodInfoPtr_GetPrefab_Public_Static_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Object_Boolean_0, Il2CppClassPointerStore<LookupUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMeta>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrefab>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002BC RID: 700
		private sealed class MethodInfoStoreGeneric_GetAndInstantiatePrefab_Public_Static_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Transform_Boolean_Boolean_Object_0<TMeta, TPrefab>
		{
			// Token: 0x040016C0 RID: 5824
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LookupUtil.NativeMethodInfoPtr_GetAndInstantiatePrefab_Public_Static_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Transform_Boolean_Boolean_Object_0, Il2CppClassPointerStore<LookupUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMeta>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrefab>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002BD RID: 701
		private sealed class MethodInfoStoreGeneric_GetPrefabAsync_Public_Static_Task_1_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Object_Boolean_0<TMeta, TPrefab>
		{
			// Token: 0x040016C1 RID: 5825
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LookupUtil.NativeMethodInfoPtr_GetPrefabAsync_Public_Static_Task_1_TPrefab_PrefabLookup_1_TMeta_IMetadataMatcher_1_TMeta_Object_Boolean_0, Il2CppClassPointerStore<LookupUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMeta>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrefab>.NativeClassPtr))
			}))));
		}
	}
}
