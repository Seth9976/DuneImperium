using System;
using dwd.core.loader.caching;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dwd.core.loader.loaders
{
	// Token: 0x02000198 RID: 408
	public class BundleLoader<T> : BaseBundleLoader<T> where T : global::UnityEngine.Object
	{
		// Token: 0x06001708 RID: 5896 RVA: 0x000701B8 File Offset: 0x0006E3B8
		// Note: this type is marked as 'beforefieldinit'.
		static BundleLoader()
		{
			Il2CppClassPointerStore<BundleLoader<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.loaders", "BundleLoader`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BundleLoader<T>>.NativeClassPtr);
			BundleLoader<T>.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleLoader<T>>.NativeClassPtr, 100666830);
			BundleLoader<T>.NativeMethodInfoPtr_LoadAsset_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleLoader<T>>.NativeClassPtr, 100666831);
			BundleLoader<T>.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleLoader<T>>.NativeClassPtr, 100666832);
			BundleLoader<T>.NativeMethodInfoPtr_createAssetName_Private_AssetName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleLoader<T>>.NativeClassPtr, 100666833);
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00070274 File Offset: 0x0006E474
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 878785, RefRangeEnd = 878789, XrefRangeStart = 878784, XrefRangeEnd = 878785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BundleLoader(IReferenceTracker source, Action stateChangedCallback = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BundleLoader<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateChangedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleLoader<T>.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x000702D4 File Offset: 0x0006E4D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 878792, RefRangeEnd = 878794, XrefRangeStart = 878789, XrefRangeEnd = 878792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsset(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleLoader<T>.NativeMethodInfoPtr_LoadAsset_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x00070318 File Offset: 0x0006E518
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 878799, RefRangeEnd = 878801, XrefRangeStart = 878794, XrefRangeEnd = 878799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadAndWait(string assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assetName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleLoader<T>.NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x00070368 File Offset: 0x0006E568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 878802, RefRangeEnd = 878803, XrefRangeStart = 878801, XrefRangeEnd = 878802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetName createAssetName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleLoader<T>.NativeMethodInfoPtr_createAssetName_Private_AssetName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AssetName(intPtr);
			}
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x0000A191 File Offset: 0x00008391
		public BundleLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_Action_0;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_Void_String_0;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndWait_Public_IEnumerator_String_0;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeMethodInfoPtr_createAssetName_Private_AssetName_String_0;

		// Token: 0x0200032E RID: 814
		[ObfuscatedName("dwd.core.loader.loaders.BundleLoader`1+<LoadAndWait>d__2")]
		public sealed class _LoadAndWait_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x0600251C RID: 9500 RVA: 0x000A0080 File Offset: 0x0009E280
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadAndWait_d__2()
			{
				Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BundleLoader<T>>.NativeClassPtr, "<LoadAndWait>d__2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr);
				BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr, "<>1__state");
				BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr, "<>2__current");
				BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr, "assetName");
				BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr, "<>4__this");
				BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr__l_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr, "<l>5__2");
				BundleLoader<T>._LoadAndWait_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr, 100666834);
				BundleLoader<T>._LoadAndWait_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr, 100666835);
				BundleLoader<T>._LoadAndWait_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr, 100666836);
				BundleLoader<T>._LoadAndWait_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr, 100666837);
				BundleLoader<T>._LoadAndWait_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr, 100666838);
				BundleLoader<T>._LoadAndWait_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr, 100666839);
			}

			// Token: 0x0600251D RID: 9501 RVA: 0x000A01C4 File Offset: 0x0009E3C4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadAndWait_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BundleLoader<T>._LoadAndWait_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleLoader<T>._LoadAndWait_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600251E RID: 9502 RVA: 0x000A020C File Offset: 0x0009E40C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleLoader<T>._LoadAndWait_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600251F RID: 9503 RVA: 0x000A0240 File Offset: 0x0009E440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878777, XrefRangeEnd = 878784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleLoader<T>._LoadAndWait_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A5A RID: 2650
			// (get) Token: 0x06002520 RID: 9504 RVA: 0x000A027C File Offset: 0x0009E47C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleLoader<T>._LoadAndWait_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002521 RID: 9505 RVA: 0x000A02BC File Offset: 0x0009E4BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleLoader<T>._LoadAndWait_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A5B RID: 2651
			// (get) Token: 0x06002522 RID: 9506 RVA: 0x000A02F0 File Offset: 0x0009E4F0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleLoader<T>._LoadAndWait_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002523 RID: 9507 RVA: 0x00010B40 File Offset: 0x0000ED40
			public _LoadAndWait_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A55 RID: 2645
			// (get) Token: 0x06002524 RID: 9508 RVA: 0x000A0330 File Offset: 0x0009E530
			// (set) Token: 0x06002525 RID: 9509 RVA: 0x00010B49 File Offset: 0x0000ED49
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A56 RID: 2646
			// (get) Token: 0x06002526 RID: 9510 RVA: 0x000A0358 File Offset: 0x0009E558
			// (set) Token: 0x06002527 RID: 9511 RVA: 0x00010B64 File Offset: 0x0000ED64
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A57 RID: 2647
			// (get) Token: 0x06002528 RID: 9512 RVA: 0x000A0388 File Offset: 0x0009E588
			// (set) Token: 0x06002529 RID: 9513 RVA: 0x00010B83 File Offset: 0x0000ED83
			public unsafe string assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr_assetName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr_assetName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000A58 RID: 2648
			// (get) Token: 0x0600252A RID: 9514 RVA: 0x000A03B0 File Offset: 0x0009E5B0
			// (set) Token: 0x0600252B RID: 9515 RVA: 0x00010BA2 File Offset: 0x0000EDA2
			public unsafe BundleLoader<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BundleLoader<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A59 RID: 2649
			// (get) Token: 0x0600252C RID: 9516 RVA: 0x000A03E0 File Offset: 0x0009E5E0
			// (set) Token: 0x0600252D RID: 9517 RVA: 0x00010BC1 File Offset: 0x0000EDC1
			public unsafe IEnumerator _l_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr__l_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleLoader<T>._LoadAndWait_d__2.NativeFieldInfoPtr__l_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001942 RID: 6466
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001943 RID: 6467
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001944 RID: 6468
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x04001945 RID: 6469
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001946 RID: 6470
			private static readonly IntPtr NativeFieldInfoPtr__l_5__2;

			// Token: 0x04001947 RID: 6471
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001948 RID: 6472
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001949 RID: 6473
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400194A RID: 6474
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400194B RID: 6475
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400194C RID: 6476
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
