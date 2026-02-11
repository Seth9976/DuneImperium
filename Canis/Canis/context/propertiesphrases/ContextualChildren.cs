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
	// Token: 0x0200013D RID: 317
	[Serializable]
	public class ContextualChildren : ContextToList<Entity>
	{
		// Token: 0x06000E4A RID: 3658 RVA: 0x00055F80 File Offset: 0x00054180
		// Note: this type is marked as 'beforefieldinit'.
		static ContextualChildren()
		{
			Il2CppClassPointerStore<ContextualChildren>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "ContextualChildren");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextualChildren>.NativeClassPtr);
			ContextualChildren.NativeFieldInfoPtr_parentsGen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualChildren>.NativeClassPtr, "parentsGen");
			ContextualChildren.NativeMethodInfoPtr__ctor_Public_Void_ContextToList_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualChildren>.NativeClassPtr, 100666408);
			ContextualChildren.NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_Entity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualChildren>.NativeClassPtr, 100666409);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00055FEC File Offset: 0x000541EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577330, XrefRangeEnd = 577334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextualChildren(ContextToList<Entity> parentsGen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextualChildren>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentsGen);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualChildren.NativeMethodInfoPtr__ctor_Public_Void_ContextToList_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00056038 File Offset: 0x00054238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577334, XrefRangeEnd = 577353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Entity> Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextualChildren.NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_Entity_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x000073B9 File Offset: 0x000055B9
		public ContextualChildren(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00056094 File Offset: 0x00054294
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x000073C2 File Offset: 0x000055C2
		public unsafe ContextToList<Entity> parentsGen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualChildren.NativeFieldInfoPtr_parentsGen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToList<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextualChildren.NativeFieldInfoPtr_parentsGen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeFieldInfoPtr_parentsGen;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ContextToList_1_Entity_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_IEnumerable_1_Entity_Context_0;

		// Token: 0x02000390 RID: 912
		[ObfuscatedName("Canis.context.propertiesphrases.ContextualChildren+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060025F7 RID: 9719 RVA: 0x000A7AEC File Offset: 0x000A5CEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ContextualChildren.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ContextualChildren>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextualChildren.__c>.NativeClassPtr);
				ContextualChildren.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualChildren.__c>.NativeClassPtr, "<>9");
				ContextualChildren.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextualChildren.__c>.NativeClassPtr, "<>9__2_0");
				ContextualChildren.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualChildren.__c>.NativeClassPtr, 100666411);
				ContextualChildren.__c.NativeMethodInfoPtr__Evaluate_b__2_0_Internal_IEnumerable_1_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextualChildren.__c>.NativeClassPtr, 100666412);
			}

			// Token: 0x060025F8 RID: 9720 RVA: 0x000A7B68 File Offset: 0x000A5D68
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextualChildren.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualChildren.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025F9 RID: 9721 RVA: 0x000A7BA4 File Offset: 0x000A5DA4
			[CallerCount(0)]
			public unsafe IEnumerable<Entity> _Evaluate_b__2_0(Entity parent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextualChildren.__c.NativeMethodInfoPtr__Evaluate_b__2_0_Internal_IEnumerable_1_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x060025FA RID: 9722 RVA: 0x000121BE File Offset: 0x000103BE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000955 RID: 2389
			// (get) Token: 0x060025FB RID: 9723 RVA: 0x000A7BF4 File Offset: 0x000A5DF4
			// (set) Token: 0x060025FC RID: 9724 RVA: 0x000121C7 File Offset: 0x000103C7
			public unsafe static ContextualChildren.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ContextualChildren.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextualChildren.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ContextualChildren.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000956 RID: 2390
			// (get) Token: 0x060025FD RID: 9725 RVA: 0x000A7C1C File Offset: 0x000A5E1C
			// (set) Token: 0x060025FE RID: 9726 RVA: 0x000121D9 File Offset: 0x000103D9
			public unsafe static Func<Entity, IEnumerable<Entity>> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ContextualChildren.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ContextualChildren.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017B5 RID: 6069
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040017B6 RID: 6070
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040017B7 RID: 6071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017B8 RID: 6072
			private static readonly IntPtr NativeMethodInfoPtr__Evaluate_b__2_0_Internal_IEnumerable_1_Entity_Entity_0;
		}
	}
}
