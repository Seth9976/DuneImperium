using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

namespace dwd.core.prefabs
{
	// Token: 0x02000107 RID: 263
	public class PrefabLoader<TPrefabLookup, TMeta, TPrefab> : MonoBehaviour where TPrefabLookup : PrefabLookup<TMeta, TPrefab> where TMeta : new() where TPrefab : global::UnityEngine.Object
	{
		// Token: 0x06000F27 RID: 3879 RVA: 0x0004FDE4 File Offset: 0x0004DFE4
		// Note: this type is marked as 'beforefieldinit'.
		static PrefabLoader()
		{
			Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.prefabs", "PrefabLoader`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrefabLookup>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMeta>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrefab>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>>.NativeClassPtr);
			PrefabLoader<TPrefabLookup, TMeta, TPrefab>.NativeFieldInfoPtr_warnOnLookupFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>>.NativeClassPtr, "warnOnLookupFailure");
			PrefabLoader<TPrefabLookup, TMeta, TPrefab>.NativeMethodInfoPtr_get_lookup_Protected_Abstract_Virtual_New_get_TPrefabLookup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>>.NativeClassPtr, 100665509);
			PrefabLoader<TPrefabLookup, TMeta, TPrefab>.NativeMethodInfoPtr_GetPrefab_Public_TPrefab_IMetadataMatcher_1_TMeta_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>>.NativeClassPtr, 100665510);
			PrefabLoader<TPrefabLookup, TMeta, TPrefab>.NativeMethodInfoPtr_GetAndInstantiatePrefab_Public_TPrefab_IMetadataMatcher_1_TMeta_Transform_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>>.NativeClassPtr, 100665511);
			PrefabLoader<TPrefabLookup, TMeta, TPrefab>.NativeMethodInfoPtr_GetPrefabAsync_Public_Task_1_TPrefab_IMetadataMatcher_1_TMeta_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>>.NativeClassPtr, 100665512);
			PrefabLoader<TPrefabLookup, TMeta, TPrefab>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>>.NativeClassPtr, 100665513);
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x0004FEEC File Offset: 0x0004E0EC
		public unsafe virtual TPrefabLookup lookup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrefabLoader<TPrefabLookup, TMeta, TPrefab>.NativeMethodInfoPtr_get_lookup_Protected_Abstract_Virtual_New_get_TPrefabLookup_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TPrefabLookup>(intPtr, false, true);
			}
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x0004FF30 File Offset: 0x0004E130
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 868085, RefRangeEnd = 868095, XrefRangeStart = 868084, XrefRangeEnd = 868085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TPrefab GetPrefab(IMetadataMatcher<TMeta> matcher, global::UnityEngine.Object context = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matcher);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<TPrefabLookup, TMeta, TPrefab>.NativeMethodInfoPtr_GetPrefab_Public_TPrefab_IMetadataMatcher_1_TMeta_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TPrefab>(intPtr, false, true);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x0004FF8C File Offset: 0x0004E18C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 868096, RefRangeEnd = 868097, XrefRangeStart = 868095, XrefRangeEnd = 868096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TPrefab GetAndInstantiatePrefab(IMetadataMatcher<TMeta> matcher, Transform parent = null, bool worldPositionStays = false, global::UnityEngine.Object context = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matcher);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPositionStays;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<TPrefabLookup, TMeta, TPrefab>.NativeMethodInfoPtr_GetAndInstantiatePrefab_Public_TPrefab_IMetadataMatcher_1_TMeta_Transform_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TPrefab>(intPtr, false, true);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x0005000C File Offset: 0x0004E20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868097, XrefRangeEnd = 868106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TPrefab> GetPrefabAsync(IMetadataMatcher<TMeta> matcher, global::UnityEngine.Object context = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matcher);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<TPrefabLookup, TMeta, TPrefab>.NativeMethodInfoPtr_GetPrefabAsync_Public_Task_1_TPrefab_IMetadataMatcher_1_TMeta_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TPrefab>>(intPtr3) : null;
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00050070 File Offset: 0x0004E270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506167, RefRangeEnd = 506168, XrefRangeStart = 506167, XrefRangeEnd = 506168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrefabLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<TPrefabLookup, TMeta, TPrefab>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x000071FA File Offset: 0x000053FA
		public PrefabLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x000500AC File Offset: 0x0004E2AC
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x00007203 File Offset: 0x00005403
		public unsafe bool warnOnLookupFailure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>.NativeFieldInfoPtr_warnOnLookupFailure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>.NativeFieldInfoPtr_warnOnLookupFailure)) = value;
			}
		}

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeFieldInfoPtr_warnOnLookupFailure;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_get_lookup_Protected_Abstract_Virtual_New_get_TPrefabLookup_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefab_Public_TPrefab_IMetadataMatcher_1_TMeta_Object_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_GetAndInstantiatePrefab_Public_TPrefab_IMetadataMatcher_1_TMeta_Transform_Boolean_Object_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefabAsync_Public_Task_1_TPrefab_IMetadataMatcher_1_TMeta_Object_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020002BF RID: 703
		[ObfuscatedName("dwd.core.prefabs.PrefabLoader`3+<GetPrefabAsync>d__5")]
		public sealed class _GetPrefabAsync_d__5 : ValueType
		{
			// Token: 0x060020CD RID: 8397 RVA: 0x00093C9C File Offset: 0x00091E9C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetPrefabAsync_d__5()
			{
				Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>>.NativeClassPtr, "<GetPrefabAsync>d__5"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrefabLookup>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMeta>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrefab>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5>.NativeClassPtr);
				PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5>.NativeClassPtr, "<>1__state");
				PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5>.NativeClassPtr, "<>t__builder");
				PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5>.NativeClassPtr, "<>4__this");
				PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr_matcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5>.NativeClassPtr, "matcher");
				PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5>.NativeClassPtr, "context");
				PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5>.NativeClassPtr, "<>u__1");
				PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5>.NativeClassPtr, 100665514);
				PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5>.NativeClassPtr, 100665515);
			}

			// Token: 0x060020CE RID: 8398 RVA: 0x00093DC8 File Offset: 0x00091FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868065, XrefRangeEnd = 868079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020CF RID: 8399 RVA: 0x00093E00 File Offset: 0x00092000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 868079, XrefRangeEnd = 868084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020D0 RID: 8400 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
			public _GetPrefabAsync_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060020D1 RID: 8401 RVA: 0x0000DFB9 File Offset: 0x0000C1B9
			public _GetPrefabAsync_d__5()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5>.NativeClassPtr))
			{
			}

			// Token: 0x170008EC RID: 2284
			// (get) Token: 0x060020D2 RID: 8402 RVA: 0x00093E48 File Offset: 0x00092048
			// (set) Token: 0x060020D3 RID: 8403 RVA: 0x0000DFCB File Offset: 0x0000C1CB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008ED RID: 2285
			// (get) Token: 0x060020D4 RID: 8404 RVA: 0x00093E70 File Offset: 0x00092070
			// (set) Token: 0x060020D5 RID: 8405 RVA: 0x0000DFE6 File Offset: 0x0000C1E6
			public AsyncTaskMethodBuilder<TPrefab> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<TPrefab>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TPrefab>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TPrefab>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008EE RID: 2286
			// (get) Token: 0x060020D6 RID: 8406 RVA: 0x00093EA0 File Offset: 0x000920A0
			// (set) Token: 0x060020D7 RID: 8407 RVA: 0x0000E014 File Offset: 0x0000C214
			public unsafe PrefabLoader<TPrefabLookup, TMeta, TPrefab> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabLoader<TPrefabLookup, TMeta, TPrefab>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008EF RID: 2287
			// (get) Token: 0x060020D8 RID: 8408 RVA: 0x00093ED0 File Offset: 0x000920D0
			// (set) Token: 0x060020D9 RID: 8409 RVA: 0x0000E033 File Offset: 0x0000C233
			public unsafe IMetadataMatcher<TMeta> matcher
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr_matcher);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMetadataMatcher<TMeta>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr_matcher), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F0 RID: 2288
			// (get) Token: 0x060020DA RID: 8410 RVA: 0x00093F00 File Offset: 0x00092100
			// (set) Token: 0x060020DB RID: 8411 RVA: 0x0000E052 File Offset: 0x0000C252
			public unsafe global::UnityEngine.Object context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F1 RID: 2289
			// (get) Token: 0x060020DC RID: 8412 RVA: 0x00093F30 File Offset: 0x00092130
			// (set) Token: 0x060020DD RID: 8413 RVA: 0x0000E071 File Offset: 0x0000C271
			public TaskAwaiter<TPrefab> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<TPrefab>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<TPrefab>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrefabLoader<TPrefabLookup, TMeta, TPrefab>._GetPrefabAsync_d__5.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<TPrefab>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040016CD RID: 5837
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040016CE RID: 5838
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040016CF RID: 5839
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040016D0 RID: 5840
			private static readonly IntPtr NativeFieldInfoPtr_matcher;

			// Token: 0x040016D1 RID: 5841
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040016D2 RID: 5842
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040016D3 RID: 5843
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040016D4 RID: 5844
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
