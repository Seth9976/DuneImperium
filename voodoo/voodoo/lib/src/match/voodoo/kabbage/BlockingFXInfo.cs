using System;
using dwd.core.animation;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace lib.src.match.voodoo.kabbage
{
	// Token: 0x0200000B RID: 11
	[Serializable]
	public sealed class BlockingFXInfo : ValueType
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00009D84 File Offset: 0x00007F84
		// Note: this type is marked as 'beforefieldinit'.
		static BlockingFXInfo()
		{
			Il2CppClassPointerStore<BlockingFXInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lib.src.match.voodoo.kabbage", "BlockingFXInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockingFXInfo>.NativeClassPtr);
			BlockingFXInfo.NativeFieldInfoPtr_fxName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockingFXInfo>.NativeClassPtr, "fxName");
			BlockingFXInfo.NativeFieldInfoPtr_runInParallel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockingFXInfo>.NativeClassPtr, "runInParallel");
			BlockingFXInfo.NativeFieldInfoPtr_fxAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockingFXInfo>.NativeClassPtr, "fxAnimations");
			BlockingFXInfo.NativeMethodInfoPtr_TriggerAndBlock_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingFXInfo>.NativeClassPtr, 100663316);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00009E04 File Offset: 0x00008004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106588, XrefRangeEnd = 1106593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TriggerAndBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingFXInfo.NativeMethodInfoPtr_TriggerAndBlock_Public_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000022B6 File Offset: 0x000004B6
		public BlockingFXInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000022BF File Offset: 0x000004BF
		public BlockingFXInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockingFXInfo>.NativeClassPtr))
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00009E48 File Offset: 0x00008048
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000022D1 File Offset: 0x000004D1
		public unsafe string fxName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo.NativeFieldInfoPtr_fxName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo.NativeFieldInfoPtr_fxName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00009E70 File Offset: 0x00008070
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000022F0 File Offset: 0x000004F0
		public unsafe bool runInParallel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo.NativeFieldInfoPtr_runInParallel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo.NativeFieldInfoPtr_runInParallel)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00009E98 File Offset: 0x00008098
		// (set) Token: 0x06000048 RID: 72 RVA: 0x0000230B File Offset: 0x0000050B
		public unsafe Il2CppReferenceArray<TriggeredBlockingAnimation> fxAnimations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo.NativeFieldInfoPtr_fxAnimations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TriggeredBlockingAnimation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo.NativeFieldInfoPtr_fxAnimations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr_fxName;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr_runInParallel;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_fxAnimations;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_TriggerAndBlock_Public_IEnumerator_0;

		// Token: 0x020000AF RID: 175
		[ObfuscatedName("lib.src.match.voodoo.kabbage.BlockingFXInfo+<>O")]
		public static class __O : Object
		{
			// Token: 0x060009D8 RID: 2520 RVA: 0x00006C83 File Offset: 0x00004E83
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<BlockingFXInfo.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlockingFXInfo>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockingFXInfo.__O>.NativeClassPtr);
				BlockingFXInfo.__O.NativeFieldInfoPtr__0___AsCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockingFXInfo.__O>.NativeClassPtr, "<0>__AsCommand");
			}

			// Token: 0x060009D9 RID: 2521 RVA: 0x00006CB7 File Offset: 0x00004EB7
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002D4 RID: 724
			// (get) Token: 0x060009DA RID: 2522 RVA: 0x0002A1FC File Offset: 0x000283FC
			// (set) Token: 0x060009DB RID: 2523 RVA: 0x00006CC0 File Offset: 0x00004EC0
			public unsafe static Func<IEnumerator, Command> _0___AsCommand
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BlockingFXInfo.__O.NativeFieldInfoPtr__0___AsCommand, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerator, Command>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BlockingFXInfo.__O.NativeFieldInfoPtr__0___AsCommand, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400061F RID: 1567
			private static readonly IntPtr NativeFieldInfoPtr__0___AsCommand;
		}

		// Token: 0x020000B0 RID: 176
		[ObfuscatedName("lib.src.match.voodoo.kabbage.BlockingFXInfo+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060009DC RID: 2524 RVA: 0x0002A224 File Offset: 0x00028424
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BlockingFXInfo.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlockingFXInfo>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockingFXInfo.__c>.NativeClassPtr);
				BlockingFXInfo.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockingFXInfo.__c>.NativeClassPtr, "<>9");
				BlockingFXInfo.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockingFXInfo.__c>.NativeClassPtr, "<>9__3_0");
				BlockingFXInfo.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockingFXInfo.__c>.NativeClassPtr, "<>9__3_1");
				BlockingFXInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingFXInfo.__c>.NativeClassPtr, 100663318);
				BlockingFXInfo.__c.NativeMethodInfoPtr__TriggerAndBlock_b__3_0_Internal_Boolean_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingFXInfo.__c>.NativeClassPtr, 100663319);
				BlockingFXInfo.__c.NativeMethodInfoPtr__TriggerAndBlock_b__3_1_Internal_IEnumerator_TriggeredBlockingAnimation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingFXInfo.__c>.NativeClassPtr, 100663320);
			}

			// Token: 0x060009DD RID: 2525 RVA: 0x0002A2C8 File Offset: 0x000284C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockingFXInfo.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingFXInfo.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060009DE RID: 2526 RVA: 0x0002A304 File Offset: 0x00028504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TriggerAndBlock_b__3_0(TriggeredBlockingAnimation a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingFXInfo.__c.NativeMethodInfoPtr__TriggerAndBlock_b__3_0_Internal_Boolean_TriggeredBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060009DF RID: 2527 RVA: 0x0002A354 File Offset: 0x00028554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106491, XrefRangeEnd = 1106493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator _TriggerAndBlock_b__3_1(TriggeredBlockingAnimation a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingFXInfo.__c.NativeMethodInfoPtr__TriggerAndBlock_b__3_1_Internal_IEnumerator_TriggeredBlockingAnimation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}
			}

			// Token: 0x060009E0 RID: 2528 RVA: 0x00006CD2 File Offset: 0x00004ED2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002D5 RID: 725
			// (get) Token: 0x060009E1 RID: 2529 RVA: 0x0002A3A4 File Offset: 0x000285A4
			// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00006CDB File Offset: 0x00004EDB
			public unsafe static BlockingFXInfo.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BlockingFXInfo.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlockingFXInfo.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BlockingFXInfo.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002D6 RID: 726
			// (get) Token: 0x060009E3 RID: 2531 RVA: 0x0002A3CC File Offset: 0x000285CC
			// (set) Token: 0x060009E4 RID: 2532 RVA: 0x00006CED File Offset: 0x00004EED
			public unsafe static Func<TriggeredBlockingAnimation, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BlockingFXInfo.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TriggeredBlockingAnimation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BlockingFXInfo.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002D7 RID: 727
			// (get) Token: 0x060009E5 RID: 2533 RVA: 0x0002A3F4 File Offset: 0x000285F4
			// (set) Token: 0x060009E6 RID: 2534 RVA: 0x00006CFF File Offset: 0x00004EFF
			public unsafe static Func<TriggeredBlockingAnimation, IEnumerator> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BlockingFXInfo.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TriggeredBlockingAnimation, IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BlockingFXInfo.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000620 RID: 1568
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000621 RID: 1569
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04000622 RID: 1570
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x04000623 RID: 1571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000624 RID: 1572
			private static readonly IntPtr NativeMethodInfoPtr__TriggerAndBlock_b__3_0_Internal_Boolean_TriggeredBlockingAnimation_0;

			// Token: 0x04000625 RID: 1573
			private static readonly IntPtr NativeMethodInfoPtr__TriggerAndBlock_b__3_1_Internal_IEnumerator_TriggeredBlockingAnimation_0;
		}

		// Token: 0x020000B1 RID: 177
		[ObfuscatedName("lib.src.match.voodoo.kabbage.BlockingFXInfo+<TriggerAndBlock>d__3")]
		public sealed class _TriggerAndBlock_d__3 : Object
		{
			// Token: 0x060009E7 RID: 2535 RVA: 0x0002A41C File Offset: 0x0002861C
			// Note: this type is marked as 'beforefieldinit'.
			static _TriggerAndBlock_d__3()
			{
				Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlockingFXInfo>.NativeClassPtr, "<TriggerAndBlock>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr);
				BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr, "<>1__state");
				BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr, "<>2__current");
				BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr, "<>4__this");
				BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr, "<>7__wrap1");
				BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr__anim_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr, "<anim>5__3");
				BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr, 100663321);
				BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr, 100663322);
				BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr, 100663323);
				BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr, 100663324);
				BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr, 100663325);
				BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr, 100663326);
				BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr, 100663327);
			}

			// Token: 0x060009E8 RID: 2536 RVA: 0x0002A538 File Offset: 0x00028738
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TriggerAndBlock_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockingFXInfo._TriggerAndBlock_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060009E9 RID: 2537 RVA: 0x0002A580 File Offset: 0x00028780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106493, XrefRangeEnd = 1106498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060009EA RID: 2538 RVA: 0x0002A5B4 File Offset: 0x000287B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106498, XrefRangeEnd = 1106580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060009EB RID: 2539 RVA: 0x0002A5F0 File Offset: 0x000287F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106580, XrefRangeEnd = 1106583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170002DD RID: 733
			// (get) Token: 0x060009EC RID: 2540 RVA: 0x0002A624 File Offset: 0x00028824
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060009ED RID: 2541 RVA: 0x0002A664 File Offset: 0x00028864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106583, XrefRangeEnd = 1106588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170002DE RID: 734
			// (get) Token: 0x060009EE RID: 2542 RVA: 0x0002A698 File Offset: 0x00028898
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingFXInfo._TriggerAndBlock_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060009EF RID: 2543 RVA: 0x00006D11 File Offset: 0x00004F11
			public _TriggerAndBlock_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170002D8 RID: 728
			// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0002A6D8 File Offset: 0x000288D8
			// (set) Token: 0x060009F1 RID: 2545 RVA: 0x00006D1A File Offset: 0x00004F1A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170002D9 RID: 729
			// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0002A700 File Offset: 0x00028900
			// (set) Token: 0x060009F3 RID: 2547 RVA: 0x00006D35 File Offset: 0x00004F35
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002DA RID: 730
			// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0002A730 File Offset: 0x00028930
			// (set) Token: 0x060009F5 RID: 2549 RVA: 0x00006D54 File Offset: 0x00004F54
			public BlockingFXInfo __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr___4__this);
					return new BlockingFXInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlockingFXInfo>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlockingFXInfo>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170002DB RID: 731
			// (get) Token: 0x060009F6 RID: 2550 RVA: 0x0002A760 File Offset: 0x00028960
			// (set) Token: 0x060009F7 RID: 2551 RVA: 0x00006D82 File Offset: 0x00004F82
			public unsafe IEnumerator<IEnumerator> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IEnumerator>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170002DC RID: 732
			// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0002A790 File Offset: 0x00028990
			// (set) Token: 0x060009F9 RID: 2553 RVA: 0x00006DA1 File Offset: 0x00004FA1
			public unsafe IEnumerator _anim_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr__anim_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingFXInfo._TriggerAndBlock_d__3.NativeFieldInfoPtr__anim_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000626 RID: 1574
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000627 RID: 1575
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000628 RID: 1576
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000629 RID: 1577
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400062A RID: 1578
			private static readonly IntPtr NativeFieldInfoPtr__anim_5__3;

			// Token: 0x0400062B RID: 1579
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400062C RID: 1580
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400062D RID: 1581
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400062E RID: 1582
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400062F RID: 1583
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000630 RID: 1584
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000631 RID: 1585
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
