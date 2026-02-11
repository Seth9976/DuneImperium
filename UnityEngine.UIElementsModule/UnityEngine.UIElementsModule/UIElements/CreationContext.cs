using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000217 RID: 535
	public sealed class CreationContext : ValueType
	{
		// Token: 0x060028DA RID: 10458 RVA: 0x000B326C File Offset: 0x000B146C
		// Note: this type is marked as 'beforefieldinit'.
		static CreationContext()
		{
			Il2CppClassPointerStore<CreationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "CreationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreationContext>.NativeClassPtr);
			CreationContext.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, "Default");
			CreationContext.NativeFieldInfoPtr__target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, "<target>k__BackingField");
			CreationContext.NativeFieldInfoPtr__visualTreeAsset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, "<visualTreeAsset>k__BackingField");
			CreationContext.NativeFieldInfoPtr__slotInsertionPoints_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, "<slotInsertionPoints>k__BackingField");
			CreationContext.NativeFieldInfoPtr__attributeOverrides_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, "<attributeOverrides>k__BackingField");
			CreationContext.NativeMethodInfoPtr_get_target_Public_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, 100669446);
			CreationContext.NativeMethodInfoPtr_set_target_Private_set_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, 100669447);
			CreationContext.NativeMethodInfoPtr_get_visualTreeAsset_Public_get_VisualTreeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, 100669448);
			CreationContext.NativeMethodInfoPtr_set_visualTreeAsset_Private_set_Void_VisualTreeAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, 100669449);
			CreationContext.NativeMethodInfoPtr_get_slotInsertionPoints_Public_get_Dictionary_2_String_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, 100669450);
			CreationContext.NativeMethodInfoPtr_set_slotInsertionPoints_Private_set_Void_Dictionary_2_String_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, 100669451);
			CreationContext.NativeMethodInfoPtr_get_attributeOverrides_Internal_get_List_1_AttributeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, 100669452);
			CreationContext.NativeMethodInfoPtr_set_attributeOverrides_Private_set_Void_List_1_AttributeOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, 100669453);
			CreationContext.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_String_VisualElement_VisualTreeAsset_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, 100669454);
			CreationContext.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_String_VisualElement_List_1_AttributeOverride_VisualTreeAsset_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, 100669455);
			CreationContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, 100669456);
			CreationContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, 100669457);
			CreationContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, 100669458);
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x000B3404 File Offset: 0x000B1604
		// (set) Token: 0x060028DC RID: 10460 RVA: 0x000B3448 File Offset: 0x000B1648
		public unsafe VisualElement target
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreationContext.NativeMethodInfoPtr_get_target_Public_get_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreationContext.NativeMethodInfoPtr_set_target_Private_set_Void_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x000B3490 File Offset: 0x000B1690
		// (set) Token: 0x060028DE RID: 10462 RVA: 0x000B34D4 File Offset: 0x000B16D4
		public unsafe VisualTreeAsset visualTreeAsset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreationContext.NativeMethodInfoPtr_get_visualTreeAsset_Public_get_VisualTreeAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315685, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreationContext.NativeMethodInfoPtr_set_visualTreeAsset_Private_set_Void_VisualTreeAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x000B351C File Offset: 0x000B171C
		// (set) Token: 0x060028E0 RID: 10464 RVA: 0x000B3560 File Offset: 0x000B1760
		public unsafe Dictionary<string, VisualElement> slotInsertionPoints
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreationContext.NativeMethodInfoPtr_get_slotInsertionPoints_Public_get_Dictionary_2_String_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, VisualElement>>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreationContext.NativeMethodInfoPtr_set_slotInsertionPoints_Private_set_Void_Dictionary_2_String_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x000B35A8 File Offset: 0x000B17A8
		// (set) Token: 0x060028E2 RID: 10466 RVA: 0x000B35EC File Offset: 0x000B17EC
		public unsafe List<TemplateAsset.AttributeOverride> attributeOverrides
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreationContext.NativeMethodInfoPtr_get_attributeOverrides_Internal_get_List_1_AttributeOverride_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TemplateAsset.AttributeOverride>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreationContext.NativeMethodInfoPtr_set_attributeOverrides_Private_set_Void_List_1_AttributeOverride_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x000B3634 File Offset: 0x000B1834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346006, XrefRangeEnd = 346010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreationContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slotInsertionPoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vta);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreationContext.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_String_VisualElement_VisualTreeAsset_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x000B36A8 File Offset: 0x000B18A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346017, RefRangeEnd = 346018, XrefRangeStart = 346010, XrefRangeEnd = 346017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreationContext(Dictionary<string, VisualElement> slotInsertionPoints, List<TemplateAsset.AttributeOverride> attributeOverrides, VisualTreeAsset vta, VisualElement target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreationContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slotInsertionPoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeOverrides);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vta);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreationContext.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_String_VisualElement_List_1_AttributeOverride_VisualTreeAsset_VisualElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x000B3730 File Offset: 0x000B1930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346018, XrefRangeEnd = 346024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreationContext.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x000B3784 File Offset: 0x000B1984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346041, RefRangeEnd = 346042, XrefRangeStart = 346024, XrefRangeEnd = 346041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CreationContext other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreationContext.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CreationContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x000B37DC File Offset: 0x000B19DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346042, XrefRangeEnd = 346054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreationContext.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x000107A0 File Offset: 0x0000E9A0
		public CreationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x000107A9 File Offset: 0x0000E9A9
		public CreationContext()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreationContext>.NativeClassPtr))
		{
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060028EA RID: 10474 RVA: 0x000B3820 File Offset: 0x000B1A20
		// (set) Token: 0x060028EB RID: 10475 RVA: 0x000107BB File Offset: 0x0000E9BB
		public unsafe static CreationContext Default
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(CreationContext.NativeFieldInfoPtr_Default, intPtr);
				return new CreationContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreationContext>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreationContext.NativeFieldInfoPtr_Default, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060028EC RID: 10476 RVA: 0x000B385C File Offset: 0x000B1A5C
		// (set) Token: 0x060028ED RID: 10477 RVA: 0x000107D2 File Offset: 0x0000E9D2
		public unsafe VisualElement _target_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreationContext.NativeFieldInfoPtr__target_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreationContext.NativeFieldInfoPtr__target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x000B388C File Offset: 0x000B1A8C
		// (set) Token: 0x060028EF RID: 10479 RVA: 0x000107F1 File Offset: 0x0000E9F1
		public unsafe VisualTreeAsset _visualTreeAsset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreationContext.NativeFieldInfoPtr__visualTreeAsset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreationContext.NativeFieldInfoPtr__visualTreeAsset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x000B38BC File Offset: 0x000B1ABC
		// (set) Token: 0x060028F1 RID: 10481 RVA: 0x00010810 File Offset: 0x0000EA10
		public unsafe Dictionary<string, VisualElement> _slotInsertionPoints_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreationContext.NativeFieldInfoPtr__slotInsertionPoints_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreationContext.NativeFieldInfoPtr__slotInsertionPoints_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x000B38EC File Offset: 0x000B1AEC
		// (set) Token: 0x060028F3 RID: 10483 RVA: 0x0001082F File Offset: 0x0000EA2F
		public unsafe List<TemplateAsset.AttributeOverride> _attributeOverrides_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreationContext.NativeFieldInfoPtr__attributeOverrides_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TemplateAsset.AttributeOverride>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreationContext.NativeFieldInfoPtr__attributeOverrides_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x000B391C File Offset: 0x000B1B1C
		public static bool operator ==(CreationContext context1, CreationContext context2)
		{
			return context1.Equals(context2);
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x000B3938 File Offset: 0x000B1B38
		public static bool operator !=(CreationContext context1, CreationContext context2)
		{
			return !(context1 == context2);
		}

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeFieldInfoPtr__target_k__BackingField;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeFieldInfoPtr__visualTreeAsset_k__BackingField;

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeFieldInfoPtr__slotInsertionPoints_k__BackingField;

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeFieldInfoPtr__attributeOverrides_k__BackingField;

		// Token: 0x04001CE1 RID: 7393
		private static readonly IntPtr NativeMethodInfoPtr_get_target_Public_get_VisualElement_0;

		// Token: 0x04001CE2 RID: 7394
		private static readonly IntPtr NativeMethodInfoPtr_set_target_Private_set_Void_VisualElement_0;

		// Token: 0x04001CE3 RID: 7395
		private static readonly IntPtr NativeMethodInfoPtr_get_visualTreeAsset_Public_get_VisualTreeAsset_0;

		// Token: 0x04001CE4 RID: 7396
		private static readonly IntPtr NativeMethodInfoPtr_set_visualTreeAsset_Private_set_Void_VisualTreeAsset_0;

		// Token: 0x04001CE5 RID: 7397
		private static readonly IntPtr NativeMethodInfoPtr_get_slotInsertionPoints_Public_get_Dictionary_2_String_VisualElement_0;

		// Token: 0x04001CE6 RID: 7398
		private static readonly IntPtr NativeMethodInfoPtr_set_slotInsertionPoints_Private_set_Void_Dictionary_2_String_VisualElement_0;

		// Token: 0x04001CE7 RID: 7399
		private static readonly IntPtr NativeMethodInfoPtr_get_attributeOverrides_Internal_get_List_1_AttributeOverride_0;

		// Token: 0x04001CE8 RID: 7400
		private static readonly IntPtr NativeMethodInfoPtr_set_attributeOverrides_Private_set_Void_List_1_AttributeOverride_0;

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_String_VisualElement_VisualTreeAsset_VisualElement_0;

		// Token: 0x04001CEA RID: 7402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_String_VisualElement_List_1_AttributeOverride_VisualTreeAsset_VisualElement_0;

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CreationContext_0;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
