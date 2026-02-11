using System;
using dwd.core.ui.prompt.prompters;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.ui.prompt.finders
{
	// Token: 0x0200002B RID: 43
	public static class GenericPrompterFinder : global::Il2CppSystem.Object
	{
		// Token: 0x060001AE RID: 430 RVA: 0x00002D9E File Offset: 0x00000F9E
		// Note: this type is marked as 'beforefieldinit'.
		static GenericPrompterFinder()
		{
			Il2CppClassPointerStore<GenericPrompterFinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.finders", "GenericPrompterFinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPrompterFinder>.NativeClassPtr);
			GenericPrompterFinder.NativeMethodInfoPtr_FindPrompterForScope_Public_Static_IModalPrompter_ModalScope_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompterFinder>.NativeClassPtr, 100663456);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00009200 File Offset: 0x00007400
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1213969, RefRangeEnd = 1213984, XrefRangeStart = 1213877, XrefRangeEnd = 1213969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IModalPrompter FindPrompterForScope(ModalScope scope, bool fallbackToNoScope = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackToNoScope;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompterFinder.NativeMethodInfoPtr_FindPrompterForScope_Public_Static_IModalPrompter_ModalScope_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IModalPrompter>(intPtr3) : null;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002DD7 File Offset: 0x00000FD7
		public GenericPrompterFinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_FindPrompterForScope_Public_Static_IModalPrompter_ModalScope_Boolean_0;

		// Token: 0x0200004C RID: 76
		[ObfuscatedName("dwd.core.ui.prompt.finders.GenericPrompterFinder+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060002F7 RID: 759 RVA: 0x0000D444 File Offset: 0x0000B644
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GenericPrompterFinder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericPrompterFinder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPrompterFinder.__c>.NativeClassPtr);
				GenericPrompterFinder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompterFinder.__c>.NativeClassPtr, "<>9");
				GenericPrompterFinder.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompterFinder.__c>.NativeClassPtr, "<>9__0_0");
				GenericPrompterFinder.__c.NativeFieldInfoPtr___9__0_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompterFinder.__c>.NativeClassPtr, "<>9__0_2");
				GenericPrompterFinder.__c.NativeFieldInfoPtr___9__0_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompterFinder.__c>.NativeClassPtr, "<>9__0_3");
				GenericPrompterFinder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompterFinder.__c>.NativeClassPtr, 100663458);
				GenericPrompterFinder.__c.NativeMethodInfoPtr__FindPrompterForScope_b__0_0_Internal_IEnumerable_1_GenericPrompter_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompterFinder.__c>.NativeClassPtr, 100663459);
				GenericPrompterFinder.__c.NativeMethodInfoPtr__FindPrompterForScope_b__0_2_Internal_String_GenericPrompter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompterFinder.__c>.NativeClassPtr, 100663460);
				GenericPrompterFinder.__c.NativeMethodInfoPtr__FindPrompterForScope_b__0_3_Internal_Boolean_GenericPrompter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompterFinder.__c>.NativeClassPtr, 100663461);
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x0000D510 File Offset: 0x0000B710
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericPrompterFinder.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompterFinder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x0000D54C File Offset: 0x0000B74C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213859, XrefRangeEnd = 1213863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<GenericPrompter> _FindPrompterForScope_b__0_0(GameObject fastFindTaggedObj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(fastFindTaggedObj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompterFinder.__c.NativeMethodInfoPtr__FindPrompterForScope_b__0_0_Internal_IEnumerable_1_GenericPrompter_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<GenericPrompter>>(intPtr3) : null;
				}
			}

			// Token: 0x060002FA RID: 762 RVA: 0x0000D59C File Offset: 0x0000B79C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213863, XrefRangeEnd = 1213866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _FindPrompterForScope_b__0_2(GenericPrompter prompter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prompter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompterFinder.__c.NativeMethodInfoPtr__FindPrompterForScope_b__0_2_Internal_String_GenericPrompter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002FB RID: 763 RVA: 0x0000D5E4 File Offset: 0x0000B7E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213866, XrefRangeEnd = 1213868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindPrompterForScope_b__0_3(GenericPrompter scopedPrompter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(scopedPrompter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompterFinder.__c.NativeMethodInfoPtr__FindPrompterForScope_b__0_3_Internal_Boolean_GenericPrompter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002FC RID: 764 RVA: 0x000038A6 File Offset: 0x00001AA6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x060002FD RID: 765 RVA: 0x0000D634 File Offset: 0x0000B834
			// (set) Token: 0x060002FE RID: 766 RVA: 0x000038AF File Offset: 0x00001AAF
			public unsafe static GenericPrompterFinder.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GenericPrompterFinder.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericPrompterFinder.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GenericPrompterFinder.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060002FF RID: 767 RVA: 0x0000D65C File Offset: 0x0000B85C
			// (set) Token: 0x06000300 RID: 768 RVA: 0x000038C1 File Offset: 0x00001AC1
			public unsafe static Func<GameObject, IEnumerable<GenericPrompter>> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GenericPrompterFinder.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameObject, IEnumerable<GenericPrompter>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GenericPrompterFinder.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x06000301 RID: 769 RVA: 0x0000D684 File Offset: 0x0000B884
			// (set) Token: 0x06000302 RID: 770 RVA: 0x000038D3 File Offset: 0x00001AD3
			public unsafe static Func<GenericPrompter, string> __9__0_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GenericPrompterFinder.__c.NativeFieldInfoPtr___9__0_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GenericPrompter, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GenericPrompterFinder.__c.NativeFieldInfoPtr___9__0_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x06000303 RID: 771 RVA: 0x0000D6AC File Offset: 0x0000B8AC
			// (set) Token: 0x06000304 RID: 772 RVA: 0x000038E5 File Offset: 0x00001AE5
			public unsafe static Func<GenericPrompter, bool> __9__0_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GenericPrompterFinder.__c.NativeFieldInfoPtr___9__0_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GenericPrompter, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GenericPrompterFinder.__c.NativeFieldInfoPtr___9__0_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001AB RID: 427
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001AC RID: 428
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x040001AD RID: 429
			private static readonly IntPtr NativeFieldInfoPtr___9__0_2;

			// Token: 0x040001AE RID: 430
			private static readonly IntPtr NativeFieldInfoPtr___9__0_3;

			// Token: 0x040001AF RID: 431
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001B0 RID: 432
			private static readonly IntPtr NativeMethodInfoPtr__FindPrompterForScope_b__0_0_Internal_IEnumerable_1_GenericPrompter_GameObject_0;

			// Token: 0x040001B1 RID: 433
			private static readonly IntPtr NativeMethodInfoPtr__FindPrompterForScope_b__0_2_Internal_String_GenericPrompter_0;

			// Token: 0x040001B2 RID: 434
			private static readonly IntPtr NativeMethodInfoPtr__FindPrompterForScope_b__0_3_Internal_Boolean_GenericPrompter_0;
		}

		// Token: 0x0200004D RID: 77
		[ObfuscatedName("dwd.core.ui.prompt.finders.GenericPrompterFinder+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000305 RID: 773 RVA: 0x0000D6D4 File Offset: 0x0000B8D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<GenericPrompterFinder.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericPrompterFinder>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericPrompterFinder.__c__DisplayClass0_0>.NativeClassPtr);
				GenericPrompterFinder.__c__DisplayClass0_0.NativeFieldInfoPtr_scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericPrompterFinder.__c__DisplayClass0_0>.NativeClassPtr, "scope");
				GenericPrompterFinder.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompterFinder.__c__DisplayClass0_0>.NativeClassPtr, 100663462);
				GenericPrompterFinder.__c__DisplayClass0_0.NativeMethodInfoPtr__FindPrompterForScope_b__1_Internal_Boolean_GenericPrompter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericPrompterFinder.__c__DisplayClass0_0>.NativeClassPtr, 100663463);
			}

			// Token: 0x06000306 RID: 774 RVA: 0x0000D73C File Offset: 0x0000B93C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericPrompterFinder.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompterFinder.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000307 RID: 775 RVA: 0x0000D778 File Offset: 0x0000B978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213868, XrefRangeEnd = 1213877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindPrompterForScope_b__1(GenericPrompter scopedPrompter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(scopedPrompter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericPrompterFinder.__c__DisplayClass0_0.NativeMethodInfoPtr__FindPrompterForScope_b__1_Internal_Boolean_GenericPrompter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000308 RID: 776 RVA: 0x000038F7 File Offset: 0x00001AF7
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x06000309 RID: 777 RVA: 0x0000D7C8 File Offset: 0x0000B9C8
			// (set) Token: 0x0600030A RID: 778 RVA: 0x00003900 File Offset: 0x00001B00
			public unsafe ModalScope scope
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompterFinder.__c__DisplayClass0_0.NativeFieldInfoPtr_scope);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericPrompterFinder.__c__DisplayClass0_0.NativeFieldInfoPtr_scope), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001B3 RID: 435
			private static readonly IntPtr NativeFieldInfoPtr_scope;

			// Token: 0x040001B4 RID: 436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001B5 RID: 437
			private static readonly IntPtr NativeMethodInfoPtr__FindPrompterForScope_b__1_Internal_Boolean_GenericPrompter_0;
		}
	}
}
