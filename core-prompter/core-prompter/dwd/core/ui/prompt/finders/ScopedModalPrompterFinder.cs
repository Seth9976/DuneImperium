using System;
using dwd.core.ui.prompt.prompters;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace dwd.core.ui.prompt.finders
{
	// Token: 0x0200002C RID: 44
	public static class ScopedModalPrompterFinder<TScopes> : global::Il2CppSystem.Object
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x00009254 File Offset: 0x00007454
		// Note: this type is marked as 'beforefieldinit'.
		static ScopedModalPrompterFinder()
		{
			Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.finders", "ScopedModalPrompterFinder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TScopes>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>>.NativeClassPtr);
			ScopedModalPrompterFinder<TScopes>.NativeMethodInfoPtr_FindPrompterForScope_Public_Static_IModalPrompter_1_TPrompt_TScopes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>>.NativeClassPtr, 100663464);
			ScopedModalPrompterFinder<TScopes>.NativeMethodInfoPtr_FindPrompterForScope_Public_Static_IModalPrompter_TScopes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>>.NativeClassPtr, 100663465);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000092E8 File Offset: 0x000074E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214001, XrefRangeEnd = 1214035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IModalPrompter<TPrompt> FindPrompterForScope<TPrompt>(TScopes scope)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TScopes).IsValueType)
				{
					TScopes tscopes = scope;
					intPtr = ((tscopes is string) ? IL2CPP.ManagedStringToIl2Cpp(tscopes as string) : IL2CPP.Il2CppObjectBaseToPtr(tscopes as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref scope;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ScopedModalPrompterFinder<TPrompt>.MethodInfoStoreGeneric_FindPrompterForScope_Public_Static_IModalPrompter_1_TPrompt_TScopes_0.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IModalPrompter<TPrompt>>(intPtr4) : null;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00009364 File Offset: 0x00007564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1214035, XrefRangeEnd = 1214080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IModalPrompter FindPrompterForScope(TScopes scope)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TScopes).IsValueType)
				{
					TScopes tscopes = scope;
					intPtr = ((tscopes is string) ? IL2CPP.ManagedStringToIl2Cpp(tscopes as string) : IL2CPP.Il2CppObjectBaseToPtr(tscopes as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref scope;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ScopedModalPrompterFinder<TScopes>.NativeMethodInfoPtr_FindPrompterForScope_Public_Static_IModalPrompter_TScopes_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<IModalPrompter>(intPtr4) : null;
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public ScopedModalPrompterFinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_FindPrompterForScope_Public_Static_IModalPrompter_1_TPrompt_TScopes_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_FindPrompterForScope_Public_Static_IModalPrompter_TScopes_0;

		// Token: 0x0200004E RID: 78
		[ObfuscatedName("dwd.core.ui.prompt.finders.ScopedModalPrompterFinder`1+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600030B RID: 779 RVA: 0x0000D7F8 File Offset: 0x0000B9F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TScopes>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c>.NativeClassPtr);
				ScopedModalPrompterFinder<TScopes>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c>.NativeClassPtr, "<>9");
				ScopedModalPrompterFinder<TScopes>.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c>.NativeClassPtr, "<>9__1_0");
				ScopedModalPrompterFinder<TScopes>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c>.NativeClassPtr, 100663467);
				ScopedModalPrompterFinder<TScopes>.__c.NativeMethodInfoPtr__FindPrompterForScope_b__1_0_Internal_IEnumerable_1_IScopedModalPrompter_1_TScopes_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c>.NativeClassPtr, 100663468);
			}

			// Token: 0x0600030C RID: 780 RVA: 0x0000D8B0 File Offset: 0x0000BAB0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedModalPrompterFinder<TScopes>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600030D RID: 781 RVA: 0x0000D8EC File Offset: 0x0000BAEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213984, XrefRangeEnd = 1213996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IScopedModalPrompter<TScopes>> _FindPrompterForScope_b__1_0(GameObject fastFindTaggedObj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(fastFindTaggedObj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedModalPrompterFinder<TScopes>.__c.NativeMethodInfoPtr__FindPrompterForScope_b__1_0_Internal_IEnumerable_1_IScopedModalPrompter_1_TScopes_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IScopedModalPrompter<TScopes>>>(intPtr3) : null;
				}
			}

			// Token: 0x0600030E RID: 782 RVA: 0x0000391F File Offset: 0x00001B1F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x0600030F RID: 783 RVA: 0x0000D93C File Offset: 0x0000BB3C
			// (set) Token: 0x06000310 RID: 784 RVA: 0x00003928 File Offset: 0x00001B28
			public unsafe static ScopedModalPrompterFinder<TScopes>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScopedModalPrompterFinder<TScopes>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScopedModalPrompterFinder<TScopes>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScopedModalPrompterFinder<TScopes>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000311 RID: 785 RVA: 0x0000D964 File Offset: 0x0000BB64
			// (set) Token: 0x06000312 RID: 786 RVA: 0x0000393A File Offset: 0x00001B3A
			public unsafe static Func<GameObject, IEnumerable<IScopedModalPrompter<TScopes>>> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScopedModalPrompterFinder<TScopes>.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameObject, IEnumerable<IScopedModalPrompter<TScopes>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScopedModalPrompterFinder<TScopes>.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001B6 RID: 438
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001B7 RID: 439
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040001B8 RID: 440
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001B9 RID: 441
			private static readonly IntPtr NativeMethodInfoPtr__FindPrompterForScope_b__1_0_Internal_IEnumerable_1_IScopedModalPrompter_1_TScopes_GameObject_0;
		}

		// Token: 0x0200004F RID: 79
		[ObfuscatedName("dwd.core.ui.prompt.finders.ScopedModalPrompterFinder`1+<>c__0`1")]
		[Serializable]
		public sealed class __c__0<TPrompt> : global::Il2CppSystem.Object
		{
			// Token: 0x06000313 RID: 787 RVA: 0x0000D98C File Offset: 0x0000BB8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__0()
			{
				Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>>.NativeClassPtr, "<>c__0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TScopes>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrompt>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>>.NativeClassPtr);
				ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>>.NativeClassPtr, "<>9");
				ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>>.NativeClassPtr, "<>9__0_0");
				ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>>.NativeClassPtr, 100663470);
				ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>.NativeMethodInfoPtr__FindPrompterForScope_b__0_0_Internal_IEnumerable_1_IScopedModalPrompter_1_TScopes_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>>.NativeClassPtr, 100663471);
			}

			// Token: 0x06000314 RID: 788 RVA: 0x0000DA54 File Offset: 0x0000BC54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000315 RID: 789 RVA: 0x0000DA90 File Offset: 0x0000BC90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IScopedModalPrompter<TScopes>> _FindPrompterForScope_b__0_0(GameObject fastFindTaggedObj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(fastFindTaggedObj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>.NativeMethodInfoPtr__FindPrompterForScope_b__0_0_Internal_IEnumerable_1_IScopedModalPrompter_1_TScopes_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IScopedModalPrompter<TScopes>>>(intPtr3) : null;
				}
			}

			// Token: 0x06000316 RID: 790 RVA: 0x0000394C File Offset: 0x00001B4C
			public __c__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x06000317 RID: 791 RVA: 0x0000DAE0 File Offset: 0x0000BCE0
			// (set) Token: 0x06000318 RID: 792 RVA: 0x00003955 File Offset: 0x00001B55
			public unsafe static ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x06000319 RID: 793 RVA: 0x0000DB08 File Offset: 0x0000BD08
			// (set) Token: 0x0600031A RID: 794 RVA: 0x00003967 File Offset: 0x00001B67
			public unsafe static Func<GameObject, IEnumerable<IScopedModalPrompter<TScopes>>> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameObject, IEnumerable<IScopedModalPrompter<TScopes>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScopedModalPrompterFinder<TScopes>.__c__0<TPrompt>.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001BA RID: 442
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040001BB RID: 443
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x040001BC RID: 444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001BD RID: 445
			private static readonly IntPtr NativeMethodInfoPtr__FindPrompterForScope_b__0_0_Internal_IEnumerable_1_IScopedModalPrompter_1_TScopes_GameObject_0;
		}

		// Token: 0x02000050 RID: 80
		[ObfuscatedName("dwd.core.ui.prompt.finders.ScopedModalPrompterFinder`1+<>c__DisplayClass0_0`1")]
		public sealed class __c__DisplayClass0_0<TPrompt> : global::Il2CppSystem.Object
		{
			// Token: 0x0600031B RID: 795 RVA: 0x0000DB30 File Offset: 0x0000BD30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__DisplayClass0_0<TPrompt>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>>.NativeClassPtr, "<>c__DisplayClass0_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TScopes>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrompt>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__DisplayClass0_0<TPrompt>>.NativeClassPtr);
				ScopedModalPrompterFinder<TScopes>.__c__DisplayClass0_0<TPrompt>.NativeFieldInfoPtr_scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__DisplayClass0_0<TPrompt>>.NativeClassPtr, "scope");
				ScopedModalPrompterFinder<TScopes>.__c__DisplayClass0_0<TPrompt>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__DisplayClass0_0<TPrompt>>.NativeClassPtr, 100663472);
				ScopedModalPrompterFinder<TScopes>.__c__DisplayClass0_0<TPrompt>.NativeMethodInfoPtr__FindPrompterForScope_b__1_Internal_Boolean_IScopedModalPrompter_1_TScopes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__DisplayClass0_0<TPrompt>>.NativeClassPtr, 100663473);
			}

			// Token: 0x0600031C RID: 796 RVA: 0x0000DBE4 File Offset: 0x0000BDE4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__DisplayClass0_0<TPrompt>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedModalPrompterFinder<TScopes>.__c__DisplayClass0_0<TPrompt>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600031D RID: 797 RVA: 0x0000DC20 File Offset: 0x0000BE20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213996, XrefRangeEnd = 1214001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindPrompterForScope_b__1(IScopedModalPrompter<TScopes> scopedPrompter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(scopedPrompter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedModalPrompterFinder<TScopes>.__c__DisplayClass0_0<TPrompt>.NativeMethodInfoPtr__FindPrompterForScope_b__1_Internal_Boolean_IScopedModalPrompter_1_TScopes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600031E RID: 798 RVA: 0x00003979 File Offset: 0x00001B79
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x0600031F RID: 799 RVA: 0x0000DC70 File Offset: 0x0000BE70
			// (set) Token: 0x06000320 RID: 800 RVA: 0x0000DC98 File Offset: 0x0000BE98
			public unsafe TScopes scope
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedModalPrompterFinder<TScopes>.__c__DisplayClass0_0<TPrompt>.NativeFieldInfoPtr_scope);
					return IL2CPP.PointerToValueGeneric<TScopes>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedModalPrompterFinder<TScopes>.__c__DisplayClass0_0<TPrompt>.NativeFieldInfoPtr_scope);
					Type typeFromHandle = typeof(TScopes);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x040001BE RID: 446
			private static readonly IntPtr NativeFieldInfoPtr_scope;

			// Token: 0x040001BF RID: 447
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001C0 RID: 448
			private static readonly IntPtr NativeMethodInfoPtr__FindPrompterForScope_b__1_Internal_Boolean_IScopedModalPrompter_1_TScopes_0;
		}

		// Token: 0x02000051 RID: 81
		[ObfuscatedName("dwd.core.ui.prompt.finders.ScopedModalPrompterFinder`1+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000321 RID: 801 RVA: 0x0000DD40 File Offset: 0x0000BF40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>>.NativeClassPtr, "<>c__DisplayClass1_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TScopes>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__DisplayClass1_0>.NativeClassPtr);
				ScopedModalPrompterFinder<TScopes>.__c__DisplayClass1_0.NativeFieldInfoPtr_scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__DisplayClass1_0>.NativeClassPtr, "scope");
				ScopedModalPrompterFinder<TScopes>.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__DisplayClass1_0>.NativeClassPtr, 100663474);
				ScopedModalPrompterFinder<TScopes>.__c__DisplayClass1_0.NativeMethodInfoPtr__FindPrompterForScope_b__1_Internal_Boolean_IScopedModalPrompter_1_TScopes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__DisplayClass1_0>.NativeClassPtr, 100663475);
			}

			// Token: 0x06000322 RID: 802 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScopedModalPrompterFinder<TScopes>.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedModalPrompterFinder<TScopes>.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000323 RID: 803 RVA: 0x0000DE20 File Offset: 0x0000C020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindPrompterForScope_b__1(IScopedModalPrompter<TScopes> scopedPrompter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(scopedPrompter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScopedModalPrompterFinder<TScopes>.__c__DisplayClass1_0.NativeMethodInfoPtr__FindPrompterForScope_b__1_Internal_Boolean_IScopedModalPrompter_1_TScopes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000324 RID: 804 RVA: 0x00003982 File Offset: 0x00001B82
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x06000325 RID: 805 RVA: 0x0000DE70 File Offset: 0x0000C070
			// (set) Token: 0x06000326 RID: 806 RVA: 0x0000DE98 File Offset: 0x0000C098
			public unsafe TScopes scope
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedModalPrompterFinder<TScopes>.__c__DisplayClass1_0.NativeFieldInfoPtr_scope);
					return IL2CPP.PointerToValueGeneric<TScopes>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScopedModalPrompterFinder<TScopes>.__c__DisplayClass1_0.NativeFieldInfoPtr_scope);
					Type typeFromHandle = typeof(TScopes);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x040001C1 RID: 449
			private static readonly IntPtr NativeFieldInfoPtr_scope;

			// Token: 0x040001C2 RID: 450
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040001C3 RID: 451
			private static readonly IntPtr NativeMethodInfoPtr__FindPrompterForScope_b__1_Internal_Boolean_IScopedModalPrompter_1_TScopes_0;
		}

		// Token: 0x02000052 RID: 82
		private sealed class MethodInfoStoreGeneric_FindPrompterForScope_Public_Static_IModalPrompter_1_TPrompt_TScopes_0
		{
			// Token: 0x040001C4 RID: 452
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ScopedModalPrompterFinder<TPrompt>.NativeMethodInfoPtr_FindPrompterForScope_Public_Static_IModalPrompter_1_TPrompt_TScopes_0, Il2CppClassPointerStore<ScopedModalPrompterFinder<TPrompt>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrompt>.NativeClassPtr)) }))));
		}
	}
}
