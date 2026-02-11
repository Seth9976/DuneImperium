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
	// Token: 0x0200016B RID: 363
	public class CombineBoolAttributesProvider : AttributeView
	{
		// Token: 0x0600124B RID: 4683 RVA: 0x00049360 File Offset: 0x00047560
		// Note: this type is marked as 'beforefieldinit'.
		static CombineBoolAttributesProvider()
		{
			Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.providers", "CombineBoolAttributesProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr);
			CombineBoolAttributesProvider.NativeFieldInfoPtr_combine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, "combine");
			CombineBoolAttributesProvider.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, "attributes");
			CombineBoolAttributesProvider.NativeFieldInfoPtr_OnAttributesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, "OnAttributesChanged");
			CombineBoolAttributesProvider.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, "Attributes");
			CombineBoolAttributesProvider.NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, 100665967);
			CombineBoolAttributesProvider.NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, 100665968);
			CombineBoolAttributesProvider.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, 100665969);
			CombineBoolAttributesProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, 100665970);
			CombineBoolAttributesProvider.NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, 100665971);
			CombineBoolAttributesProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, 100665972);
			CombineBoolAttributesProvider.NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, 100665973);
			CombineBoolAttributesProvider.NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, 100665974);
			CombineBoolAttributesProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, 100665975);
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00049494 File Offset: 0x00047694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000845, XrefRangeEnd = 1000849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnAttributesChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineBoolAttributesProvider.NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x000494D8 File Offset: 0x000476D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000849, XrefRangeEnd = 1000853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnAttributesChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineBoolAttributesProvider.NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0004951C File Offset: 0x0004771C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombineBoolAttributesProvider.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00049558 File Offset: 0x00047758
		[CallerCount(0)]
		public unsafe virtual IHasAttributes GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineBoolAttributesProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00049598 File Offset: 0x00047798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000853, XrefRangeEnd = 1000889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewChanged(IHasAttributes newView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombineBoolAttributesProvider.NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x000495E8 File Offset: 0x000477E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000889, XrefRangeEnd = 1000893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<IAttributeDefinition> ProvidesAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineBoolAttributesProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttributeDefinition>>(intPtr3) : null;
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x00049628 File Offset: 0x00047828
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineBoolAttributesProvider.NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0004966C File Offset: 0x0004786C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineBoolAttributesProvider.NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x000496B0 File Offset: 0x000478B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000893, XrefRangeEnd = 1000900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombineBoolAttributesProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineBoolAttributesProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0000A8E1 File Offset: 0x00008AE1
		public CombineBoolAttributesProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x000496EC File Offset: 0x000478EC
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x0000A8EA File Offset: 0x00008AEA
		public unsafe Il2CppReferenceArray<CombineBoolAttributesProvider.Transformation> combine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombineBoolAttributesProvider.NativeFieldInfoPtr_combine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CombineBoolAttributesProvider.Transformation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombineBoolAttributesProvider.NativeFieldInfoPtr_combine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x0004971C File Offset: 0x0004791C
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x0000A909 File Offset: 0x00008B09
		public unsafe MetaAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombineBoolAttributesProvider.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombineBoolAttributesProvider.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x0004974C File Offset: 0x0004794C
		// (set) Token: 0x0600125B RID: 4699 RVA: 0x0000A928 File Offset: 0x00008B28
		public new unsafe Action OnAttributesChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombineBoolAttributesProvider.NativeFieldInfoPtr_OnAttributesChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombineBoolAttributesProvider.NativeFieldInfoPtr_OnAttributesChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x0004977C File Offset: 0x0004797C
		// (set) Token: 0x0600125D RID: 4701 RVA: 0x0000A947 File Offset: 0x00008B47
		public unsafe static Il2CppReferenceArray<IAttributeDefinition> Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CombineBoolAttributesProvider.NativeFieldInfoPtr_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IAttributeDefinition>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombineBoolAttributesProvider.NativeFieldInfoPtr_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeFieldInfoPtr_combine;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeFieldInfoPtr_OnAttributesChanged;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000286 RID: 646
		public enum Operation
		{
			// Token: 0x0400122C RID: 4652
			Or,
			// Token: 0x0400122D RID: 4653
			And,
			// Token: 0x0400122E RID: 4654
			Equals
		}

		// Token: 0x02000287 RID: 647
		[Serializable]
		public class Transformation : Object
		{
			// Token: 0x06001DE1 RID: 7649 RVA: 0x0006D1C4 File Offset: 0x0006B3C4
			// Note: this type is marked as 'beforefieldinit'.
			static Transformation()
			{
				Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombineBoolAttributesProvider>.NativeClassPtr, "Transformation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation>.NativeClassPtr);
				CombineBoolAttributesProvider.Transformation.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation>.NativeClassPtr, "attribute");
				CombineBoolAttributesProvider.Transformation.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation>.NativeClassPtr, "operation");
				CombineBoolAttributesProvider.Transformation.NativeMethodInfoPtr_GetFunc_Public_Func_3_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation>.NativeClassPtr, 100665977);
				CombineBoolAttributesProvider.Transformation.NativeMethodInfoPtr_Or_Public_Static_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation>.NativeClassPtr, 100665978);
				CombineBoolAttributesProvider.Transformation.NativeMethodInfoPtr_And_Public_Static_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation>.NativeClassPtr, 100665979);
				CombineBoolAttributesProvider.Transformation.NativeMethodInfoPtr_Equals_Public_Static_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation>.NativeClassPtr, 100665980);
				CombineBoolAttributesProvider.Transformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation>.NativeClassPtr, 100665981);
			}

			// Token: 0x06001DE2 RID: 7650 RVA: 0x0006D27C File Offset: 0x0006B47C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1000831, RefRangeEnd = 1000832, XrefRangeStart = 1000818, XrefRangeEnd = 1000831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Func<Nullable<bool>, Nullable<bool>, Nullable<bool>> GetFunc()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineBoolAttributesProvider.Transformation.NativeMethodInfoPtr_GetFunc_Public_Func_3_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Nullable<bool>, Nullable<bool>, Nullable<bool>>>(intPtr3) : null;
			}

			// Token: 0x06001DE3 RID: 7651 RVA: 0x0006D2BC File Offset: 0x0006B4BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000832, XrefRangeEnd = 1000836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Nullable<bool> Or(Nullable<bool> a, Nullable<bool> b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineBoolAttributesProvider.Transformation.NativeMethodInfoPtr_Or_Public_Static_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}

			// Token: 0x06001DE4 RID: 7652 RVA: 0x0006D314 File Offset: 0x0006B514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000836, XrefRangeEnd = 1000840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Nullable<bool> And(Nullable<bool> a, Nullable<bool> b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineBoolAttributesProvider.Transformation.NativeMethodInfoPtr_And_Public_Static_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}

			// Token: 0x06001DE5 RID: 7653 RVA: 0x0006D36C File Offset: 0x0006B56C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000840, XrefRangeEnd = 1000845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Nullable<bool> Equals(Nullable<bool> a, Nullable<bool> b)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineBoolAttributesProvider.Transformation.NativeMethodInfoPtr_Equals_Public_Static_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}

			// Token: 0x06001DE6 RID: 7654 RVA: 0x0006D3C4 File Offset: 0x0006B5C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Transformation()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombineBoolAttributesProvider.Transformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DE7 RID: 7655 RVA: 0x00010146 File Offset: 0x0000E346
			public Transformation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008F0 RID: 2288
			// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x0006D400 File Offset: 0x0006B600
			// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x0001014F File Offset: 0x0000E34F
			public unsafe int attribute
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombineBoolAttributesProvider.Transformation.NativeFieldInfoPtr_attribute);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombineBoolAttributesProvider.Transformation.NativeFieldInfoPtr_attribute)) = value;
				}
			}

			// Token: 0x170008F1 RID: 2289
			// (get) Token: 0x06001DEA RID: 7658 RVA: 0x0006D428 File Offset: 0x0006B628
			// (set) Token: 0x06001DEB RID: 7659 RVA: 0x0001016A File Offset: 0x0000E36A
			public unsafe CombineBoolAttributesProvider.Operation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombineBoolAttributesProvider.Transformation.NativeFieldInfoPtr_operation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombineBoolAttributesProvider.Transformation.NativeFieldInfoPtr_operation)) = value;
				}
			}

			// Token: 0x0400122F RID: 4655
			private static readonly IntPtr NativeFieldInfoPtr_attribute;

			// Token: 0x04001230 RID: 4656
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x04001231 RID: 4657
			private static readonly IntPtr NativeMethodInfoPtr_GetFunc_Public_Func_3_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_Boolean_0;

			// Token: 0x04001232 RID: 4658
			private static readonly IntPtr NativeMethodInfoPtr_Or_Public_Static_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_Boolean_0;

			// Token: 0x04001233 RID: 4659
			private static readonly IntPtr NativeMethodInfoPtr_And_Public_Static_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_Boolean_0;

			// Token: 0x04001234 RID: 4660
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Nullable_1_Boolean_Nullable_1_Boolean_Nullable_1_Boolean_0;

			// Token: 0x04001235 RID: 4661
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200029B RID: 667
			[ObfuscatedName("boardgames.attributes.providers.CombineBoolAttributesProvider+Transformation+<>O")]
			public static class __O : Object
			{
				// Token: 0x06001E54 RID: 7764 RVA: 0x0006E624 File Offset: 0x0006C824
				// Note: this type is marked as 'beforefieldinit'.
				static __O()
				{
					Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation>.NativeClassPtr, "<>O");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation.__O>.NativeClassPtr);
					CombineBoolAttributesProvider.Transformation.__O.NativeFieldInfoPtr__0___Or = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation.__O>.NativeClassPtr, "<0>__Or");
					CombineBoolAttributesProvider.Transformation.__O.NativeFieldInfoPtr__1___And = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation.__O>.NativeClassPtr, "<1>__And");
					CombineBoolAttributesProvider.Transformation.__O.NativeFieldInfoPtr__2___Equals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombineBoolAttributesProvider.Transformation.__O>.NativeClassPtr, "<2>__Equals");
				}

				// Token: 0x06001E55 RID: 7765 RVA: 0x0001043F File Offset: 0x0000E63F
				public __O(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000909 RID: 2313
				// (get) Token: 0x06001E56 RID: 7766 RVA: 0x0006E68C File Offset: 0x0006C88C
				// (set) Token: 0x06001E57 RID: 7767 RVA: 0x00010448 File Offset: 0x0000E648
				public unsafe static Func<Nullable<bool>, Nullable<bool>, Nullable<bool>> _0___Or
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(CombineBoolAttributesProvider.Transformation.__O.NativeFieldInfoPtr__0___Or, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Nullable<bool>, Nullable<bool>, Nullable<bool>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(CombineBoolAttributesProvider.Transformation.__O.NativeFieldInfoPtr__0___Or, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700090A RID: 2314
				// (get) Token: 0x06001E58 RID: 7768 RVA: 0x0006E6B4 File Offset: 0x0006C8B4
				// (set) Token: 0x06001E59 RID: 7769 RVA: 0x0001045A File Offset: 0x0000E65A
				public unsafe static Func<Nullable<bool>, Nullable<bool>, Nullable<bool>> _1___And
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(CombineBoolAttributesProvider.Transformation.__O.NativeFieldInfoPtr__1___And, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Nullable<bool>, Nullable<bool>, Nullable<bool>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(CombineBoolAttributesProvider.Transformation.__O.NativeFieldInfoPtr__1___And, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700090B RID: 2315
				// (get) Token: 0x06001E5A RID: 7770 RVA: 0x0006E6DC File Offset: 0x0006C8DC
				// (set) Token: 0x06001E5B RID: 7771 RVA: 0x0001046C File Offset: 0x0000E66C
				public unsafe static Func<Nullable<bool>, Nullable<bool>, Nullable<bool>> _2___Equals
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(CombineBoolAttributesProvider.Transformation.__O.NativeFieldInfoPtr__2___Equals, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Nullable<bool>, Nullable<bool>, Nullable<bool>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(CombineBoolAttributesProvider.Transformation.__O.NativeFieldInfoPtr__2___Equals, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400126E RID: 4718
				private static readonly IntPtr NativeFieldInfoPtr__0___Or;

				// Token: 0x0400126F RID: 4719
				private static readonly IntPtr NativeFieldInfoPtr__1___And;

				// Token: 0x04001270 RID: 4720
				private static readonly IntPtr NativeFieldInfoPtr__2___Equals;
			}
		}
	}
}
