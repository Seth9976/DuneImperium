using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.attributes.meta
{
	// Token: 0x02000028 RID: 40
	public class TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue> : Object
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x0000D0E4 File Offset: 0x0000B2E4
		// Note: this type is marked as 'beforefieldinit'.
		static TransformAttribute()
		{
			Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes.meta", "TransformAttribute`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSourceValue1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSourceValue2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTargetValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr);
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__source1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, "_source1");
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__source2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, "_source2");
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, "_definition");
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__transformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, "_transformation");
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__asReadonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, "_asReadonly");
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, "_cachedVersion");
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__cachedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, "_cachedValue");
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__cachedModValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, "_cachedModValue");
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_TSourceValue1_IAttribute_1_TSourceValue2_AttributeDefinition_1_TTargetValue_Func_3_TSourceValue1_TSourceValue2_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, 100663620);
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, 100663621);
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, 100663622);
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, 100663623);
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, 100663624);
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_get_ModValue_Public_Virtual_Final_New_get_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, 100663625);
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Value_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, 100663626);
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_ModValue_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, 100663627);
			TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_get_AsReadOnly_Public_Virtual_Final_New_get_ReadOnlyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr, 100663628);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000D2C8 File Offset: 0x0000B4C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1219433, RefRangeEnd = 1219435, XrefRangeStart = 1219406, XrefRangeEnd = 1219433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformAttribute(IAttribute<TSourceValue1> source1, IAttribute<TSourceValue2> source2, AttributeDefinition<TTargetValue> definition, Func<TSourceValue1, TSourceValue2, TTargetValue> transformation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_TSourceValue1_IAttribute_1_TSourceValue2_AttributeDefinition_1_TTargetValue_Func_3_TSourceValue1_TSourceValue2_TTargetValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000D34C File Offset: 0x0000B54C
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219435, XrefRangeEnd = 1219440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000D388 File Offset: 0x0000B588
		public unsafe virtual int Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000D3C4 File Offset: 0x0000B5C4
		public unsafe virtual Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219440, XrefRangeEnd = 1219470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000D404 File Offset: 0x0000B604
		public unsafe virtual TTargetValue Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1219480, RefRangeEnd = 1219481, XrefRangeStart = 1219470, XrefRangeEnd = 1219480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TTargetValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TTargetValue>(intPtr, false, true);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000D440 File Offset: 0x0000B640
		public unsafe virtual TTargetValue ModValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1219491, RefRangeEnd = 1219492, XrefRangeStart = 1219481, XrefRangeEnd = 1219491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_get_ModValue_Public_Virtual_Final_New_get_TTargetValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TTargetValue>(intPtr, false, true);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000D47C File Offset: 0x0000B67C
		public unsafe virtual Object Canis.attributes.IAttribute.Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219492, XrefRangeEnd = 1219494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Value_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000D4BC File Offset: 0x0000B6BC
		public unsafe virtual Object Canis.attributes.IAttribute.ModValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219494, XrefRangeEnd = 1219496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_ModValue_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000D4FC File Offset: 0x0000B6FC
		public unsafe virtual ReadOnlyAttribute AsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219496, XrefRangeEnd = 1219500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeMethodInfoPtr_get_AsReadOnly_Public_Virtual_Final_New_get_ReadOnlyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002F96 File Offset: 0x00001196
		public TransformAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0000D53C File Offset: 0x0000B73C
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00002F9F File Offset: 0x0000119F
		public unsafe IAttribute<TSourceValue1> _source1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__source1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<TSourceValue1>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__source1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000D56C File Offset: 0x0000B76C
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x00002FBE File Offset: 0x000011BE
		public unsafe IAttribute<TSourceValue2> _source2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__source2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<TSourceValue2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__source2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000D59C File Offset: 0x0000B79C
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00002FDD File Offset: 0x000011DD
		public unsafe AttributeDefinition<TTargetValue> _definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<TTargetValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000D5CC File Offset: 0x0000B7CC
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00002FFC File Offset: 0x000011FC
		public unsafe Func<TSourceValue1, TSourceValue2, TTargetValue> _transformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__transformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSourceValue1, TSourceValue2, TTargetValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__transformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x0000301B File Offset: 0x0000121B
		public unsafe ReadOnlyAttribute<TTargetValue> _asReadonly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__asReadonly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<TTargetValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__asReadonly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000D62C File Offset: 0x0000B82C
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0000303A File Offset: 0x0000123A
		public unsafe ulong _cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__cachedVersion)) = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000D654 File Offset: 0x0000B854
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0000D67C File Offset: 0x0000B87C
		public unsafe TTargetValue _cachedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__cachedValue);
				return IL2CPP.PointerToValueGeneric<TTargetValue>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__cachedValue);
				Type typeFromHandle = typeof(TTargetValue);
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000D724 File Offset: 0x0000B924
		// (set) Token: 0x060002BE RID: 702 RVA: 0x0000D74C File Offset: 0x0000B94C
		public unsafe TTargetValue _cachedModValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__cachedModValue);
				return IL2CPP.PointerToValueGeneric<TTargetValue>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue1, TSourceValue2, TTargetValue>.NativeFieldInfoPtr__cachedModValue);
				Type typeFromHandle = typeof(TTargetValue);
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

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr__source1;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr__source2;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr__definition;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeFieldInfoPtr__transformation;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr__asReadonly;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr__cachedVersion;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr__cachedValue;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr__cachedModValue;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_TSourceValue1_IAttribute_1_TSourceValue2_AttributeDefinition_1_TTargetValue_Func_3_TSourceValue1_TSourceValue2_TTargetValue_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TTargetValue_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_get_ModValue_Public_Virtual_Final_New_get_TTargetValue_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Value_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IAttribute_get_ModValue_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_get_AsReadOnly_Public_Virtual_Final_New_get_ReadOnlyAttribute_0;
	}
}
