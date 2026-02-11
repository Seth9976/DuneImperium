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
	// Token: 0x02000172 RID: 370
	public class TransformIntAttributeProvider : AttributeView
	{
		// Token: 0x060012AB RID: 4779 RVA: 0x0004A8D8 File Offset: 0x00048AD8
		// Note: this type is marked as 'beforefieldinit'.
		static TransformIntAttributeProvider()
		{
			Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes.providers", "TransformIntAttributeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr);
			TransformIntAttributeProvider.NativeFieldInfoPtr_orderedTransformations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, "orderedTransformations");
			TransformIntAttributeProvider.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, "attributes");
			TransformIntAttributeProvider.NativeFieldInfoPtr_OnAttributesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, "OnAttributesChanged");
			TransformIntAttributeProvider.NativeFieldInfoPtr_Attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, "Attributes");
			TransformIntAttributeProvider.NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, 100666030);
			TransformIntAttributeProvider.NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, 100666031);
			TransformIntAttributeProvider.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, 100666032);
			TransformIntAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, 100666033);
			TransformIntAttributeProvider.NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, 100666034);
			TransformIntAttributeProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, 100666035);
			TransformIntAttributeProvider.NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, 100666036);
			TransformIntAttributeProvider.NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, 100666037);
			TransformIntAttributeProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, 100666038);
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0004AA0C File Offset: 0x00048C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001185, XrefRangeEnd = 1001189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnAttributesChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformIntAttributeProvider.NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x0004AA50 File Offset: 0x00048C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001189, XrefRangeEnd = 1001193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnAttributesChanged(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformIntAttributeProvider.NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x0004AA94 File Offset: 0x00048C94
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformIntAttributeProvider.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x0004AAD0 File Offset: 0x00048CD0
		[CallerCount(0)]
		public unsafe virtual IHasAttributes GetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformIntAttributeProvider.NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x0004AB10 File Offset: 0x00048D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001193, XrefRangeEnd = 1001224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewChanged(IHasAttributes newView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformIntAttributeProvider.NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x0004AB60 File Offset: 0x00048D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001224, XrefRangeEnd = 1001228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<IAttributeDefinition> ProvidesAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformIntAttributeProvider.NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttributeDefinition>>(intPtr3) : null;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0004ABA0 File Offset: 0x00048DA0
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformIntAttributeProvider.NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0004ABE4 File Offset: 0x00048DE4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformIntAttributeProvider.NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x0004AC28 File Offset: 0x00048E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001228, XrefRangeEnd = 1001235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformIntAttributeProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformIntAttributeProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x0000AB27 File Offset: 0x00008D27
		public TransformIntAttributeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x0004AC64 File Offset: 0x00048E64
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x0000AB30 File Offset: 0x00008D30
		public unsafe Il2CppReferenceArray<TransformIntAttributeProvider.Transformation> orderedTransformations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformIntAttributeProvider.NativeFieldInfoPtr_orderedTransformations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TransformIntAttributeProvider.Transformation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformIntAttributeProvider.NativeFieldInfoPtr_orderedTransformations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x0004AC94 File Offset: 0x00048E94
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x0000AB4F File Offset: 0x00008D4F
		public unsafe MetaAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformIntAttributeProvider.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformIntAttributeProvider.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x0004ACC4 File Offset: 0x00048EC4
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x0000AB6E File Offset: 0x00008D6E
		public new unsafe Action OnAttributesChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformIntAttributeProvider.NativeFieldInfoPtr_OnAttributesChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformIntAttributeProvider.NativeFieldInfoPtr_OnAttributesChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x0004ACF4 File Offset: 0x00048EF4
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x0000AB8D File Offset: 0x00008D8D
		public unsafe static Il2CppReferenceArray<IAttributeDefinition> Attributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TransformIntAttributeProvider.NativeFieldInfoPtr_Attributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IAttributeDefinition>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TransformIntAttributeProvider.NativeFieldInfoPtr_Attributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeFieldInfoPtr_orderedTransformations;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeFieldInfoPtr_OnAttributesChanged;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeFieldInfoPtr_Attributes;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_add_OnAttributesChanged_Private_add_Void_Action_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnAttributesChanged_Private_rem_Void_Action_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributes_Public_Virtual_Final_New_IHasAttributes_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_ProvidesAttributes_Public_Virtual_Final_New_IEnumerable_1_IAttributeDefinition_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_RegisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterOnAttributesChanged_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200028D RID: 653
		public enum Operation
		{
			// Token: 0x04001245 RID: 4677
			Add,
			// Token: 0x04001246 RID: 4678
			Subtract
		}

		// Token: 0x0200028E RID: 654
		[Serializable]
		public class Transformation : Object
		{
			// Token: 0x06001E09 RID: 7689 RVA: 0x0006D8C8 File Offset: 0x0006BAC8
			// Note: this type is marked as 'beforefieldinit'.
			static Transformation()
			{
				Il2CppClassPointerStore<TransformIntAttributeProvider.Transformation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, "Transformation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformIntAttributeProvider.Transformation>.NativeClassPtr);
				TransformIntAttributeProvider.Transformation.NativeFieldInfoPtr_operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformIntAttributeProvider.Transformation>.NativeClassPtr, "operation");
				TransformIntAttributeProvider.Transformation.NativeFieldInfoPtr_intValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformIntAttributeProvider.Transformation>.NativeClassPtr, "intValue");
				TransformIntAttributeProvider.Transformation.NativeMethodInfoPtr_GetFunc_Public_Func_2_IAttribute_1_Nullable_1_Int32_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider.Transformation>.NativeClassPtr, 100666040);
				TransformIntAttributeProvider.Transformation.NativeMethodInfoPtr_Add_Private_Nullable_1_Int32_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider.Transformation>.NativeClassPtr, 100666041);
				TransformIntAttributeProvider.Transformation.NativeMethodInfoPtr_Subtract_Private_Nullable_1_Int32_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider.Transformation>.NativeClassPtr, 100666042);
				TransformIntAttributeProvider.Transformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider.Transformation>.NativeClassPtr, 100666043);
			}

			// Token: 0x06001E0A RID: 7690 RVA: 0x0006D96C File Offset: 0x0006BB6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001132, XrefRangeEnd = 1001143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Func<IAttribute<Nullable<int>>, Nullable<int>> GetFunc()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformIntAttributeProvider.Transformation.NativeMethodInfoPtr_GetFunc_Public_Func_2_IAttribute_1_Nullable_1_Int32_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<IAttribute<Nullable<int>>, Nullable<int>>>(intPtr3) : null;
			}

			// Token: 0x06001E0B RID: 7691 RVA: 0x0006D9AC File Offset: 0x0006BBAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001143, XrefRangeEnd = 1001150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<int> Add(IAttribute<Nullable<int>> attribute)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformIntAttributeProvider.Transformation.NativeMethodInfoPtr_Add_Private_Nullable_1_Int32_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<int>(intPtr);
				}
			}

			// Token: 0x06001E0C RID: 7692 RVA: 0x0006D9F4 File Offset: 0x0006BBF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001150, XrefRangeEnd = 1001157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<int> Subtract(IAttribute<Nullable<int>> attribute)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformIntAttributeProvider.Transformation.NativeMethodInfoPtr_Subtract_Private_Nullable_1_Int32_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<int>(intPtr);
				}
			}

			// Token: 0x06001E0D RID: 7693 RVA: 0x0006DA3C File Offset: 0x0006BC3C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Transformation()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformIntAttributeProvider.Transformation>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformIntAttributeProvider.Transformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E0E RID: 7694 RVA: 0x0001025B File Offset: 0x0000E45B
			public Transformation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008F9 RID: 2297
			// (get) Token: 0x06001E0F RID: 7695 RVA: 0x0006DA78 File Offset: 0x0006BC78
			// (set) Token: 0x06001E10 RID: 7696 RVA: 0x00010264 File Offset: 0x0000E464
			public unsafe TransformIntAttributeProvider.Operation operation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformIntAttributeProvider.Transformation.NativeFieldInfoPtr_operation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformIntAttributeProvider.Transformation.NativeFieldInfoPtr_operation)) = value;
				}
			}

			// Token: 0x170008FA RID: 2298
			// (get) Token: 0x06001E11 RID: 7697 RVA: 0x0006DAA0 File Offset: 0x0006BCA0
			// (set) Token: 0x06001E12 RID: 7698 RVA: 0x0001027F File Offset: 0x0000E47F
			public unsafe int intValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformIntAttributeProvider.Transformation.NativeFieldInfoPtr_intValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformIntAttributeProvider.Transformation.NativeFieldInfoPtr_intValue)) = value;
				}
			}

			// Token: 0x04001247 RID: 4679
			private static readonly IntPtr NativeFieldInfoPtr_operation;

			// Token: 0x04001248 RID: 4680
			private static readonly IntPtr NativeFieldInfoPtr_intValue;

			// Token: 0x04001249 RID: 4681
			private static readonly IntPtr NativeMethodInfoPtr_GetFunc_Public_Func_2_IAttribute_1_Nullable_1_Int32_Nullable_1_Int32_0;

			// Token: 0x0400124A RID: 4682
			private static readonly IntPtr NativeMethodInfoPtr_Add_Private_Nullable_1_Int32_IAttribute_1_Nullable_1_Int32_0;

			// Token: 0x0400124B RID: 4683
			private static readonly IntPtr NativeMethodInfoPtr_Subtract_Private_Nullable_1_Int32_IAttribute_1_Nullable_1_Int32_0;

			// Token: 0x0400124C RID: 4684
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200028F RID: 655
		[ObfuscatedName("boardgames.attributes.providers.TransformIntAttributeProvider+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E13 RID: 7699 RVA: 0x0006DAC8 File Offset: 0x0006BCC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TransformIntAttributeProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TransformIntAttributeProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformIntAttributeProvider.__c>.NativeClassPtr);
				TransformIntAttributeProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformIntAttributeProvider.__c>.NativeClassPtr, "<>9");
				TransformIntAttributeProvider.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformIntAttributeProvider.__c>.NativeClassPtr, "<>9__9_0");
				TransformIntAttributeProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider.__c>.NativeClassPtr, 100666045);
				TransformIntAttributeProvider.__c.NativeMethodInfoPtr__OnViewChanged_b__9_0_Internal_IAttribute_1_Nullable_1_Int32_IAttribute_1_Nullable_1_Int32_Transformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformIntAttributeProvider.__c>.NativeClassPtr, 100666046);
			}

			// Token: 0x06001E14 RID: 7700 RVA: 0x0006DB44 File Offset: 0x0006BD44
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformIntAttributeProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformIntAttributeProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E15 RID: 7701 RVA: 0x0006DB80 File Offset: 0x0006BD80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001157, XrefRangeEnd = 1001185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAttribute<Nullable<int>> _OnViewChanged_b__9_0(IAttribute<Nullable<int>> current, TransformIntAttributeProvider.Transformation transformation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transformation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformIntAttributeProvider.__c.NativeMethodInfoPtr__OnViewChanged_b__9_0_Internal_IAttribute_1_Nullable_1_Int32_IAttribute_1_Nullable_1_Int32_Transformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr3) : null;
			}

			// Token: 0x06001E16 RID: 7702 RVA: 0x0001029A File Offset: 0x0000E49A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008FB RID: 2299
			// (get) Token: 0x06001E17 RID: 7703 RVA: 0x0006DBE4 File Offset: 0x0006BDE4
			// (set) Token: 0x06001E18 RID: 7704 RVA: 0x000102A3 File Offset: 0x0000E4A3
			public unsafe static TransformIntAttributeProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TransformIntAttributeProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransformIntAttributeProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TransformIntAttributeProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008FC RID: 2300
			// (get) Token: 0x06001E19 RID: 7705 RVA: 0x0006DC0C File Offset: 0x0006BE0C
			// (set) Token: 0x06001E1A RID: 7706 RVA: 0x000102B5 File Offset: 0x0000E4B5
			public unsafe static Func<IAttribute<Nullable<int>>, TransformIntAttributeProvider.Transformation, IAttribute<Nullable<int>>> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TransformIntAttributeProvider.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAttribute<Nullable<int>>, TransformIntAttributeProvider.Transformation, IAttribute<Nullable<int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TransformIntAttributeProvider.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400124D RID: 4685
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400124E RID: 4686
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400124F RID: 4687
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001250 RID: 4688
			private static readonly IntPtr NativeMethodInfoPtr__OnViewChanged_b__9_0_Internal_IAttribute_1_Nullable_1_Int32_IAttribute_1_Nullable_1_Int32_Transformation_0;
		}
	}
}
