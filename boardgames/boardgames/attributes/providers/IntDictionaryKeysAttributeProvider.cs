using System;
using Canis.attributes;
using Canis.attributes.meta;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace boardgames.attributes.providers
{
	// Token: 0x0200016E RID: 366
	public class IntDictionaryKeysAttributeProvider : AttributeView
	{
		// Token: 0x0600127D RID: 4733 RVA: 0x00049E98 File Offset: 0x00048098
		// Note: this type is marked as 'beforefieldinit'.
		static IntDictionaryKeysAttributeProvider()
		{
			Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.providers", "IntDictionaryKeysAttributeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr);
			IntDictionaryKeysAttributeProvider.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr, "attributes");
			IntDictionaryKeysAttributeProvider.NativeFieldInfoPtr_OnAttributesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr, "OnAttributesChanged");
			IntDictionaryKeysAttributeProvider.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr, "Attributes");
			IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr, 100666001);
			IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr, 100666002);
			IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr, 100666003);
			IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr, 100666004);
			IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr, 100666005);
			IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr, 100666006);
			IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr, 100666007);
			IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr, 100666008);
			IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr, 100666009);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00049FB8 File Offset: 0x000481B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000977, XrefRangeEnd = 1000981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnAttributesChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00049FFC File Offset: 0x000481FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000981, XrefRangeEnd = 1000985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnAttributesChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0004A040 File Offset: 0x00048240
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0004A07C File Offset: 0x0004827C
		[CallerCount(0)]
		public unsafe virtual IHasAttributes GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0004A0BC File Offset: 0x000482BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000985, XrefRangeEnd = 1001017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewChanged(IHasAttributes newView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0004A10C File Offset: 0x0004830C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001017, XrefRangeEnd = 1001021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<IAttributeDefinition> ProvidesAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttributeDefinition>>(intPtr3) : null;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0004A14C File Offset: 0x0004834C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0004A190 File Offset: 0x00048390
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0004A1D4 File Offset: 0x000483D4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1000333, RefRangeEnd = 1000339, XrefRangeStart = 1000333, XrefRangeEnd = 1000339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntDictionaryKeysAttributeProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntDictionaryKeysAttributeProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0000AA18 File Offset: 0x00008C18
		public IntDictionaryKeysAttributeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x0004A210 File Offset: 0x00048410
		// (set) Token: 0x06001289 RID: 4745 RVA: 0x0000AA21 File Offset: 0x00008C21
		public unsafe MetaAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntDictionaryKeysAttributeProvider.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntDictionaryKeysAttributeProvider.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x0004A240 File Offset: 0x00048440
		// (set) Token: 0x0600128B RID: 4747 RVA: 0x0000AA40 File Offset: 0x00008C40
		public new unsafe Action OnAttributesChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntDictionaryKeysAttributeProvider.NativeFieldInfoPtr_OnAttributesChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntDictionaryKeysAttributeProvider.NativeFieldInfoPtr_OnAttributesChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x0004A270 File Offset: 0x00048470
		// (set) Token: 0x0600128D RID: 4749 RVA: 0x0000AA5F File Offset: 0x00008C5F
		public unsafe static Il2CppReferenceArray<IAttributeDefinition> Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(IntDictionaryKeysAttributeProvider.NativeFieldInfoPtr_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IAttributeDefinition>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntDictionaryKeysAttributeProvider.NativeFieldInfoPtr_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeFieldInfoPtr_OnAttributesChanged;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000289 RID: 649
		[ObfuscatedName("boardgames.attributes.providers.IntDictionaryKeysAttributeProvider+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001DF4 RID: 7668 RVA: 0x0006D5A0 File Offset: 0x0006B7A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider.__c>.NativeClassPtr);
				IntDictionaryKeysAttributeProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider.__c>.NativeClassPtr, "<>9");
				IntDictionaryKeysAttributeProvider.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider.__c>.NativeClassPtr, "<>9__6_0");
				IntDictionaryKeysAttributeProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider.__c>.NativeClassPtr, 100666012);
				IntDictionaryKeysAttributeProvider.__c.NativeMethodInfoPtr__OnViewChanged_b__6_0_Internal_Il2CppStructArray_1_Int32_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider.__c>.NativeClassPtr, 100666013);
			}

			// Token: 0x06001DF5 RID: 7669 RVA: 0x0006D61C File Offset: 0x0006B81C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntDictionaryKeysAttributeProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntDictionaryKeysAttributeProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DF6 RID: 7670 RVA: 0x0006D658 File Offset: 0x0006B858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000963, XrefRangeEnd = 1000977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<int> _OnViewChanged_b__6_0(IAttribute a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntDictionaryKeysAttributeProvider.__c.NativeMethodInfoPtr__OnViewChanged_b__6_0_Internal_Il2CppStructArray_1_Int32_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
			}

			// Token: 0x06001DF7 RID: 7671 RVA: 0x000101B2 File Offset: 0x0000E3B2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008F4 RID: 2292
			// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x0006D6A8 File Offset: 0x0006B8A8
			// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x000101BB File Offset: 0x0000E3BB
			public unsafe static IntDictionaryKeysAttributeProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IntDictionaryKeysAttributeProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntDictionaryKeysAttributeProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IntDictionaryKeysAttributeProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008F5 RID: 2293
			// (get) Token: 0x06001DFA RID: 7674 RVA: 0x0006D6D0 File Offset: 0x0006B8D0
			// (set) Token: 0x06001DFB RID: 7675 RVA: 0x000101CD File Offset: 0x0000E3CD
			public unsafe static Func<IAttribute, Il2CppStructArray<int>> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IntDictionaryKeysAttributeProvider.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAttribute, Il2CppStructArray<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IntDictionaryKeysAttributeProvider.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400123A RID: 4666
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400123B RID: 4667
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400123C RID: 4668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400123D RID: 4669
			private static readonly IntPtr NativeMethodInfoPtr__OnViewChanged_b__6_0_Internal_Il2CppStructArray_1_Int32_IAttribute_0;
		}
	}
}
