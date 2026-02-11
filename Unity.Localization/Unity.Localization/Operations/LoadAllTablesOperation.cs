using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	// Token: 0x020000B7 RID: 183
	public class LoadAllTablesOperation<TTable, TEntry> : WaitForCurrentOperationAsyncOperationBase<IList<TTable>> where TTable : DetailedLocalizationTable<TEntry> where TEntry : TableEntry
	{
		// Token: 0x06000991 RID: 2449 RVA: 0x0002DC1C File Offset: 0x0002BE1C
		// Note: this type is marked as 'beforefieldinit'.
		static LoadAllTablesOperation()
		{
			Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Operations", "LoadAllTablesOperation`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr);
			LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadingCompletedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_LoadingCompletedAction");
			LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_AllTablesOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_AllTablesOperation");
			LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_Database");
			LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr, "m_SelectedLocale");
			LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr, "Pool");
			LoadAllTablesOperation<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr, 100664941);
			LoadAllTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr, 100664942);
			LoadAllTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr, 100664943);
			LoadAllTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_LoadingCompleted_Private_Void_AsyncOperationHandle_1_IList_1_TTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr, 100664944);
			LoadAllTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr, 100664945);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0002DD64 File Offset: 0x0002BF64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1077797, RefRangeEnd = 1077800, XrefRangeStart = 1077792, XrefRangeEnd = 1077797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadAllTablesOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAllTablesOperation<TTable, TEntry>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0002DDA0 File Offset: 0x0002BFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077800, XrefRangeEnd = 1077802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(LocalizedDatabase<TTable, TEntry> database, Locale locale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(database);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAllTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0002DDF4 File Offset: 0x0002BFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077802, XrefRangeEnd = 1077815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadAllTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0002DE30 File Offset: 0x0002C030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077815, XrefRangeEnd = 1077846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadingCompleted(AsyncOperationHandle<IList<TTable>> obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAllTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_LoadingCompleted_Private_Void_AsyncOperationHandle_1_IList_1_TTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0002DE78 File Offset: 0x0002C078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077846, XrefRangeEnd = 1077853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadAllTablesOperation<TTable, TEntry>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00005C7C File Offset: 0x00003E7C
		public LoadAllTablesOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0002DEB4 File Offset: 0x0002C0B4
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x00005C85 File Offset: 0x00003E85
		public unsafe Action<AsyncOperationHandle<IList<TTable>>> m_LoadingCompletedAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadingCompletedAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<IList<TTable>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_LoadingCompletedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x0002DEE4 File Offset: 0x0002C0E4
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x00005CA4 File Offset: 0x00003EA4
		public AsyncOperationHandle<IList<TTable>> m_AllTablesOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_AllTablesOperation);
				return new AsyncOperationHandle<IList<TTable>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<TTable>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_AllTablesOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<TTable>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0002DF14 File Offset: 0x0002C114
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x00005CD2 File Offset: 0x00003ED2
		public unsafe LocalizedDatabase<TTable, TEntry> m_Database
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedDatabase<TTable, TEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_Database), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x0002DF44 File Offset: 0x0002C144
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x00005CF1 File Offset: 0x00003EF1
		public unsafe Locale m_SelectedLocale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_m_SelectedLocale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0002DF74 File Offset: 0x0002C174
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x00005D10 File Offset: 0x00003F10
		public unsafe static ObjectPool<LoadAllTablesOperation<TTable, TEntry>> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<LoadAllTablesOperation<TTable, TEntry>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadAllTablesOperation<TTable, TEntry>.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadingCompletedAction;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr_m_AllTablesOperation;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr_m_Database;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedLocale;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_LocalizedDatabase_2_TTable_TEntry_Locale_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_LoadingCompleted_Private_Void_AsyncOperationHandle_1_IList_1_TTable_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x0200016C RID: 364
		[ObfuscatedName("UnityEngine.Localization.Operations.LoadAllTablesOperation`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F72 RID: 3954 RVA: 0x000420A8 File Offset: 0x000402A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEntry>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>.__c>.NativeClassPtr);
				LoadAllTablesOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>.__c>.NativeClassPtr, "<>9");
				LoadAllTablesOperation<TTable, TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>.__c>.NativeClassPtr, 100664948);
				LoadAllTablesOperation<TTable, TEntry>.__c.NativeMethodInfoPtr___cctor_b__10_0_Internal_LoadAllTablesOperation_2_TTable_TEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>.__c>.NativeClassPtr, 100664949);
			}

			// Token: 0x06000F73 RID: 3955 RVA: 0x0004215C File Offset: 0x0004035C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadAllTablesOperation<TTable, TEntry>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAllTablesOperation<TTable, TEntry>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F74 RID: 3956 RVA: 0x00042198 File Offset: 0x00040398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077789, XrefRangeEnd = 1077792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LoadAllTablesOperation<TTable, TEntry> __cctor_b__10_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadAllTablesOperation<TTable, TEntry>.__c.NativeMethodInfoPtr___cctor_b__10_0_Internal_LoadAllTablesOperation_2_TTable_TEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LoadAllTablesOperation<TTable, TEntry>>(intPtr3) : null;
			}

			// Token: 0x06000F75 RID: 3957 RVA: 0x0000871D File Offset: 0x0000691D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000426 RID: 1062
			// (get) Token: 0x06000F76 RID: 3958 RVA: 0x000421D8 File Offset: 0x000403D8
			// (set) Token: 0x06000F77 RID: 3959 RVA: 0x00008726 File Offset: 0x00006926
			public unsafe static LoadAllTablesOperation<TTable, TEntry>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadAllTablesOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadAllTablesOperation<TTable, TEntry>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadAllTablesOperation<TTable, TEntry>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AA3 RID: 2723
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000AA4 RID: 2724
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000AA5 RID: 2725
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__10_0_Internal_LoadAllTablesOperation_2_TTable_TEntry_0;
		}
	}
}
