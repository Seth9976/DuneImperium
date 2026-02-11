using System;
using Canis.attributes;
using Canis.attributes.meta;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;

namespace boardgames.attributes.providers
{
	// Token: 0x0200016C RID: 364
	public class EntityViewNumChildrenAttributeProvider : Observer
	{
		// Token: 0x0600125E RID: 4702 RVA: 0x000497A4 File Offset: 0x000479A4
		// Note: this type is marked as 'beforefieldinit'.
		static EntityViewNumChildrenAttributeProvider()
		{
			Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.providers", "EntityViewNumChildrenAttributeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr);
			EntityViewNumChildrenAttributeProvider.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr, "attributes");
			EntityViewNumChildrenAttributeProvider.NativeFieldInfoPtr_lastChildList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr, "lastChildList");
			EntityViewNumChildrenAttributeProvider.NativeFieldInfoPtr_OnAttributesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr, "OnAttributesChanged");
			EntityViewNumChildrenAttributeProvider.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr, "Attributes");
			EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr, 100665982);
			EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr, 100665983);
			EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr, 100665984);
			EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr, 100665985);
			EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr, 100665986);
			EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr, 100665987);
			EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr, 100665988);
			EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr, 100665989);
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x000498C4 File Offset: 0x00047AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000906, XrefRangeEnd = 1000910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnAttributesChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00049908 File Offset: 0x00047B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000910, XrefRangeEnd = 1000914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnAttributesChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x0004994C File Offset: 0x00047B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000914, XrefRangeEnd = 1000947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00049988 File Offset: 0x00047B88
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IHasAttributes GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x000499C8 File Offset: 0x00047BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000947, XrefRangeEnd = 1000951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<IAttributeDefinition> ProvidesAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttributeDefinition>>(intPtr3) : null;
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00049A08 File Offset: 0x00047C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterOnAttributesChanged(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00049A4C File Offset: 0x00047C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnregisterOnAttributesChanged(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00049A90 File Offset: 0x00047C90
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityViewNumChildrenAttributeProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewNumChildrenAttributeProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0000A959 File Offset: 0x00008B59
		public EntityViewNumChildrenAttributeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x00049ACC File Offset: 0x00047CCC
		// (set) Token: 0x06001269 RID: 4713 RVA: 0x0000A962 File Offset: 0x00008B62
		public unsafe MetaAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityViewNumChildrenAttributeProvider.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityViewNumChildrenAttributeProvider.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x00049AFC File Offset: 0x00047CFC
		// (set) Token: 0x0600126B RID: 4715 RVA: 0x0000A981 File Offset: 0x00008B81
		public unsafe ReadOnlyVersionedList<EntityComponent> lastChildList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityViewNumChildrenAttributeProvider.NativeFieldInfoPtr_lastChildList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedList<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityViewNumChildrenAttributeProvider.NativeFieldInfoPtr_lastChildList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x00049B2C File Offset: 0x00047D2C
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x0000A9A0 File Offset: 0x00008BA0
		public unsafe Action OnAttributesChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityViewNumChildrenAttributeProvider.NativeFieldInfoPtr_OnAttributesChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityViewNumChildrenAttributeProvider.NativeFieldInfoPtr_OnAttributesChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x00049B5C File Offset: 0x00047D5C
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x0000A9BF File Offset: 0x00008BBF
		public unsafe static Il2CppReferenceArray<IAttributeDefinition> Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityViewNumChildrenAttributeProvider.NativeFieldInfoPtr_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IAttributeDefinition>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityViewNumChildrenAttributeProvider.NativeFieldInfoPtr_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeFieldInfoPtr_lastChildList;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeFieldInfoPtr_OnAttributesChanged;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000288 RID: 648
		[ObfuscatedName("boardgames.attributes.providers.EntityViewNumChildrenAttributeProvider+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001DEC RID: 7660 RVA: 0x0006D450 File Offset: 0x0006B650
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider.__c>.NativeClassPtr);
				EntityViewNumChildrenAttributeProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider.__c>.NativeClassPtr, "<>9");
				EntityViewNumChildrenAttributeProvider.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider.__c>.NativeClassPtr, "<>9__5_0");
				EntityViewNumChildrenAttributeProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider.__c>.NativeClassPtr, 100665992);
				EntityViewNumChildrenAttributeProvider.__c.NativeMethodInfoPtr__DirtyUpdate_b__5_0_Internal_Nullable_1_Int32_ReadOnlyVersionedList_1_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider.__c>.NativeClassPtr, 100665993);
			}

			// Token: 0x06001DED RID: 7661 RVA: 0x0006D4CC File Offset: 0x0006B6CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityViewNumChildrenAttributeProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewNumChildrenAttributeProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DEE RID: 7662 RVA: 0x0006D508 File Offset: 0x0006B708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000900, XrefRangeEnd = 1000906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<int> _DirtyUpdate_b__5_0(ReadOnlyVersionedList<EntityComponent> children)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(children);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewNumChildrenAttributeProvider.__c.NativeMethodInfoPtr__DirtyUpdate_b__5_0_Internal_Nullable_1_Int32_ReadOnlyVersionedList_1_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<int>(intPtr);
				}
			}

			// Token: 0x06001DEF RID: 7663 RVA: 0x00010185 File Offset: 0x0000E385
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008F2 RID: 2290
			// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x0006D550 File Offset: 0x0006B750
			// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x0001018E File Offset: 0x0000E38E
			public unsafe static EntityViewNumChildrenAttributeProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityViewNumChildrenAttributeProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityViewNumChildrenAttributeProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityViewNumChildrenAttributeProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F3 RID: 2291
			// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x0006D578 File Offset: 0x0006B778
			// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x000101A0 File Offset: 0x0000E3A0
			public unsafe static Func<ReadOnlyVersionedList<EntityComponent>, Nullable<int>> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EntityViewNumChildrenAttributeProvider.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ReadOnlyVersionedList<EntityComponent>, Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EntityViewNumChildrenAttributeProvider.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001236 RID: 4662
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001237 RID: 4663
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04001238 RID: 4664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001239 RID: 4665
			private static readonly IntPtr NativeMethodInfoPtr__DirtyUpdate_b__5_0_Internal_Nullable_1_Int32_ReadOnlyVersionedList_1_EntityComponent_0;
		}
	}
}
