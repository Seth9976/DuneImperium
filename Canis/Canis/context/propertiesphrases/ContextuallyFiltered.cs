using System;
using Canis.context.contextToList;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.context.propertiesphrases
{
	// Token: 0x0200013C RID: 316
	[Serializable]
	public class ContextuallyFiltered : ContextToList<Entity>
	{
		// Token: 0x06000E42 RID: 3650 RVA: 0x00055DE4 File Offset: 0x00053FE4
		// Note: this type is marked as 'beforefieldinit'.
		static ContextuallyFiltered()
		{
			Il2CppClassPointerStore<ContextuallyFiltered>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "ContextuallyFiltered");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextuallyFiltered>.NativeClassPtr);
			ContextuallyFiltered.NativeFieldInfoPtr_baseList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextuallyFiltered>.NativeClassPtr, "baseList");
			ContextuallyFiltered.NativeFieldInfoPtr_props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextuallyFiltered>.NativeClassPtr, "props");
			ContextuallyFiltered.NativeMethodInfoPtr__ctor_Public_Void_ContextToList_1_Entity_PropertiesPhrase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextuallyFiltered>.NativeClassPtr, 100666404);
			ContextuallyFiltered.NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextuallyFiltered>.NativeClassPtr, 100666405);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00055E64 File Offset: 0x00054064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577244, XrefRangeEnd = 577314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextuallyFiltered(ContextToList<Entity> baseList, PropertiesPhrase props)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextuallyFiltered>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(props);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextuallyFiltered.NativeMethodInfoPtr__ctor_Public_Void_ContextToList_1_Entity_PropertiesPhrase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00055EC4 File Offset: 0x000540C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577314, XrefRangeEnd = 577330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Entity> Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextuallyFiltered.NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_Entity_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00007372 File Offset: 0x00005572
		public ContextuallyFiltered(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x00055F20 File Offset: 0x00054120
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x0000737B File Offset: 0x0000557B
		public unsafe ContextToList<Entity> baseList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextuallyFiltered.NativeFieldInfoPtr_baseList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToList<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextuallyFiltered.NativeFieldInfoPtr_baseList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00055F50 File Offset: 0x00054150
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x0000739A File Offset: 0x0000559A
		public unsafe PropertiesPhrase props
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextuallyFiltered.NativeFieldInfoPtr_props);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextuallyFiltered.NativeFieldInfoPtr_props), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeFieldInfoPtr_baseList;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeFieldInfoPtr_props;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ContextToList_1_Entity_PropertiesPhrase_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_Entity_Context_0;

		// Token: 0x0200038F RID: 911
		[ObfuscatedName("Canis.context.propertiesphrases.ContextuallyFiltered+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x060025EF RID: 9711 RVA: 0x000A7984 File Offset: 0x000A5B84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<ContextuallyFiltered.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContextuallyFiltered>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextuallyFiltered.__c__DisplayClass3_0>.NativeClassPtr);
				ContextuallyFiltered.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextuallyFiltered.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				ContextuallyFiltered.__c__DisplayClass3_0.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextuallyFiltered.__c__DisplayClass3_0>.NativeClassPtr, "context");
				ContextuallyFiltered.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextuallyFiltered.__c__DisplayClass3_0>.NativeClassPtr, 100666406);
				ContextuallyFiltered.__c__DisplayClass3_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextuallyFiltered.__c__DisplayClass3_0>.NativeClassPtr, 100666407);
			}

			// Token: 0x060025F0 RID: 9712 RVA: 0x000A7A00 File Offset: 0x000A5C00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextuallyFiltered.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextuallyFiltered.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025F1 RID: 9713 RVA: 0x000A7A3C File Offset: 0x000A5C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577223, XrefRangeEnd = 577244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Evaluate_b__0(Entity target)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextuallyFiltered.__c__DisplayClass3_0.NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025F2 RID: 9714 RVA: 0x00012177 File Offset: 0x00010377
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000953 RID: 2387
			// (get) Token: 0x060025F3 RID: 9715 RVA: 0x000A7A8C File Offset: 0x000A5C8C
			// (set) Token: 0x060025F4 RID: 9716 RVA: 0x00012180 File Offset: 0x00010380
			public unsafe ContextuallyFiltered __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextuallyFiltered.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextuallyFiltered>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextuallyFiltered.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000954 RID: 2388
			// (get) Token: 0x060025F5 RID: 9717 RVA: 0x000A7ABC File Offset: 0x000A5CBC
			// (set) Token: 0x060025F6 RID: 9718 RVA: 0x0001219F File Offset: 0x0001039F
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextuallyFiltered.__c__DisplayClass3_0.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextuallyFiltered.__c__DisplayClass3_0.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017B1 RID: 6065
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017B2 RID: 6066
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x040017B3 RID: 6067
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017B4 RID: 6068
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__0_Internal_Boolean_Entity_0;
		}
	}
}
