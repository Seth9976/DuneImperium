using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lib.src.match.components
{
	// Token: 0x02000033 RID: 51
	public class DisableWhenNoGrandchildren : MonoBehaviour
	{
		// Token: 0x06000221 RID: 545 RVA: 0x0001F978 File Offset: 0x0001DB78
		// Note: this type is marked as 'beforefieldinit'.
		static DisableWhenNoGrandchildren()
		{
			Il2CppClassPointerStore<DisableWhenNoGrandchildren>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "lib.src.match.components", "DisableWhenNoGrandchildren");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableWhenNoGrandchildren>.NativeClassPtr);
			DisableWhenNoGrandchildren.NativeFieldInfoPtr_cachedChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoGrandchildren>.NativeClassPtr, "cachedChildren");
			DisableWhenNoGrandchildren.NativeFieldInfoPtr_destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoGrandchildren>.NativeClassPtr, "destroyed");
			DisableWhenNoGrandchildren.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoGrandchildren>.NativeClassPtr, 100663670);
			DisableWhenNoGrandchildren.NativeMethodInfoPtr_CheckGrandchildCount_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoGrandchildren>.NativeClassPtr, 100663671);
			DisableWhenNoGrandchildren.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoGrandchildren>.NativeClassPtr, 100663672);
			DisableWhenNoGrandchildren.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoGrandchildren>.NativeClassPtr, 100663673);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0001FA20 File Offset: 0x0001DC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689922, XrefRangeEnd = 689952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoGrandchildren.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0001FA54 File Offset: 0x0001DC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689952, XrefRangeEnd = 689957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CheckGrandchildCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoGrandchildren.NativeMethodInfoPtr_CheckGrandchildCount_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0001FA94 File Offset: 0x0001DC94
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 689957, RefRangeEnd = 689983, XrefRangeStart = 689957, XrefRangeEnd = 689957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoGrandchildren.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0001FAC8 File Offset: 0x0001DCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689983, XrefRangeEnd = 689991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisableWhenNoGrandchildren()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableWhenNoGrandchildren>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoGrandchildren.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002FED File Offset: 0x000011ED
		public DisableWhenNoGrandchildren(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0001FB04 File Offset: 0x0001DD04
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002FF6 File Offset: 0x000011F6
		public unsafe List<Transform> cachedChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableWhenNoGrandchildren.NativeFieldInfoPtr_cachedChildren);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableWhenNoGrandchildren.NativeFieldInfoPtr_cachedChildren), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0001FB34 File Offset: 0x0001DD34
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00003015 File Offset: 0x00001215
		public unsafe bool destroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableWhenNoGrandchildren.NativeFieldInfoPtr_destroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableWhenNoGrandchildren.NativeFieldInfoPtr_destroyed)) = value;
			}
		}

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_cachedChildren;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_destroyed;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_CheckGrandchildCount_Private_IEnumerator_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002D0 RID: 720
		[ObfuscatedName("lib.src.match.components.DisableWhenNoGrandchildren+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001D7D RID: 7549 RVA: 0x000728D8 File Offset: 0x00070AD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DisableWhenNoGrandchildren.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisableWhenNoGrandchildren>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableWhenNoGrandchildren.__c>.NativeClassPtr);
				DisableWhenNoGrandchildren.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoGrandchildren.__c>.NativeClassPtr, "<>9");
				DisableWhenNoGrandchildren.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoGrandchildren.__c>.NativeClassPtr, "<>9__3_0");
				DisableWhenNoGrandchildren.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoGrandchildren.__c>.NativeClassPtr, 100663675);
				DisableWhenNoGrandchildren.__c.NativeMethodInfoPtr__CheckGrandchildCount_b__3_0_Internal_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoGrandchildren.__c>.NativeClassPtr, 100663676);
			}

			// Token: 0x06001D7E RID: 7550 RVA: 0x00072954 File Offset: 0x00070B54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableWhenNoGrandchildren.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoGrandchildren.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D7F RID: 7551 RVA: 0x00072990 File Offset: 0x00070B90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689895, XrefRangeEnd = 689896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckGrandchildCount_b__3_0(Transform child)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoGrandchildren.__c.NativeMethodInfoPtr__CheckGrandchildCount_b__3_0_Internal_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D80 RID: 7552 RVA: 0x00010D8C File Offset: 0x0000EF8C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000813 RID: 2067
			// (get) Token: 0x06001D81 RID: 7553 RVA: 0x000729E0 File Offset: 0x00070BE0
			// (set) Token: 0x06001D82 RID: 7554 RVA: 0x00010D95 File Offset: 0x0000EF95
			public unsafe static DisableWhenNoGrandchildren.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DisableWhenNoGrandchildren.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisableWhenNoGrandchildren.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DisableWhenNoGrandchildren.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000814 RID: 2068
			// (get) Token: 0x06001D83 RID: 7555 RVA: 0x00072A08 File Offset: 0x00070C08
			// (set) Token: 0x06001D84 RID: 7556 RVA: 0x00010DA7 File Offset: 0x0000EFA7
			public unsafe static Func<Transform, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DisableWhenNoGrandchildren.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DisableWhenNoGrandchildren.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400110A RID: 4362
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400110B RID: 4363
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400110C RID: 4364
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400110D RID: 4365
			private static readonly IntPtr NativeMethodInfoPtr__CheckGrandchildCount_b__3_0_Internal_Boolean_Transform_0;
		}

		// Token: 0x020002D1 RID: 721
		[ObfuscatedName("lib.src.match.components.DisableWhenNoGrandchildren+<CheckGrandchildCount>d__3")]
		public sealed class _CheckGrandchildCount_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x06001D85 RID: 7557 RVA: 0x00072A30 File Offset: 0x00070C30
			// Note: this type is marked as 'beforefieldinit'.
			static _CheckGrandchildCount_d__3()
			{
				Il2CppClassPointerStore<DisableWhenNoGrandchildren._CheckGrandchildCount_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisableWhenNoGrandchildren>.NativeClassPtr, "<CheckGrandchildCount>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisableWhenNoGrandchildren._CheckGrandchildCount_d__3>.NativeClassPtr);
				DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoGrandchildren._CheckGrandchildCount_d__3>.NativeClassPtr, "<>1__state");
				DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoGrandchildren._CheckGrandchildCount_d__3>.NativeClassPtr, "<>2__current");
				DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisableWhenNoGrandchildren._CheckGrandchildCount_d__3>.NativeClassPtr, "<>4__this");
				DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoGrandchildren._CheckGrandchildCount_d__3>.NativeClassPtr, 100663677);
				DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoGrandchildren._CheckGrandchildCount_d__3>.NativeClassPtr, 100663678);
				DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoGrandchildren._CheckGrandchildCount_d__3>.NativeClassPtr, 100663679);
				DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoGrandchildren._CheckGrandchildCount_d__3>.NativeClassPtr, 100663680);
				DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoGrandchildren._CheckGrandchildCount_d__3>.NativeClassPtr, 100663681);
				DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisableWhenNoGrandchildren._CheckGrandchildCount_d__3>.NativeClassPtr, 100663682);
			}

			// Token: 0x06001D86 RID: 7558 RVA: 0x00072B10 File Offset: 0x00070D10
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CheckGrandchildCount_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisableWhenNoGrandchildren._CheckGrandchildCount_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D87 RID: 7559 RVA: 0x00072B58 File Offset: 0x00070D58
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D88 RID: 7560 RVA: 0x00072B8C File Offset: 0x00070D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689896, XrefRangeEnd = 689917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000818 RID: 2072
			// (get) Token: 0x06001D89 RID: 7561 RVA: 0x00072BC8 File Offset: 0x00070DC8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D8A RID: 7562 RVA: 0x00072C08 File Offset: 0x00070E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 689917, XrefRangeEnd = 689922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000819 RID: 2073
			// (get) Token: 0x06001D8B RID: 7563 RVA: 0x00072C3C File Offset: 0x00070E3C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D8C RID: 7564 RVA: 0x00010DB9 File Offset: 0x0000EFB9
			public _CheckGrandchildCount_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000815 RID: 2069
			// (get) Token: 0x06001D8D RID: 7565 RVA: 0x00072C7C File Offset: 0x00070E7C
			// (set) Token: 0x06001D8E RID: 7566 RVA: 0x00010DC2 File Offset: 0x0000EFC2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000816 RID: 2070
			// (get) Token: 0x06001D8F RID: 7567 RVA: 0x00072CA4 File Offset: 0x00070EA4
			// (set) Token: 0x06001D90 RID: 7568 RVA: 0x00010DDD File Offset: 0x0000EFDD
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000817 RID: 2071
			// (get) Token: 0x06001D91 RID: 7569 RVA: 0x00072CD4 File Offset: 0x00070ED4
			// (set) Token: 0x06001D92 RID: 7570 RVA: 0x00010DFC File Offset: 0x0000EFFC
			public unsafe DisableWhenNoGrandchildren __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisableWhenNoGrandchildren>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisableWhenNoGrandchildren._CheckGrandchildCount_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400110E RID: 4366
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400110F RID: 4367
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001110 RID: 4368
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001111 RID: 4369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001112 RID: 4370
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001113 RID: 4371
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001114 RID: 4372
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001115 RID: 4373
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001116 RID: 4374
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
