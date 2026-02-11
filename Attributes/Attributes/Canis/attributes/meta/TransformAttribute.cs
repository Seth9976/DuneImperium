using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.attributes.meta
{
	// Token: 0x02000027 RID: 39
	public class TransformAttribute<TSourceValue, TTargetValue> : Object
	{
		// Token: 0x0600028B RID: 651 RVA: 0x0000CA3C File Offset: 0x0000AC3C
		// Note: this type is marked as 'beforefieldinit'.
		static TransformAttribute()
		{
			Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes.meta", "TransformAttribute`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSourceValue>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTargetValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr);
			TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, "_source");
			TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, "_definition");
			TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__transformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, "_transformation");
			TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__asReadonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, "_asReadonly");
			TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, "_cachedVersion");
			TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, "_cachedValue");
			TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedModValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, "_cachedModValue");
			TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663611);
			TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663612);
			TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663613);
			TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663614);
			TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663615);
			TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_ModValue_Public_Virtual_Final_New_get_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663616);
			TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Value_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663617);
			TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_ModValue_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663618);
			TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_AsReadOnly_Public_Virtual_Final_New_get_ReadOnlyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663619);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219320, XrefRangeEnd = 1219335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformAttribute(IAttribute<TSourceValue> source, AttributeDefinition<TTargetValue> definition, Func<TSourceValue, TTargetValue> transformation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformAttribute<TSourceValue, TTargetValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transformation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000CC6C File Offset: 0x0000AE6C
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219335, XrefRangeEnd = 1219340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		public unsafe virtual int Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219340, XrefRangeEnd = 1219342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0000CCE4 File Offset: 0x0000AEE4
		public unsafe virtual Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219342, XrefRangeEnd = 1219346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0000CD24 File Offset: 0x0000AF24
		public unsafe virtual TTargetValue Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219346, XrefRangeEnd = 1219371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TTargetValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TTargetValue>(intPtr, false, true);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0000CD60 File Offset: 0x0000AF60
		public unsafe virtual TTargetValue ModValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219371, XrefRangeEnd = 1219396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_ModValue_Public_Virtual_Final_New_get_TTargetValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TTargetValue>(intPtr, false, true);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		public unsafe virtual Object Canis.attributes.IAttribute.Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219396, XrefRangeEnd = 1219398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Value_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000CDDC File Offset: 0x0000AFDC
		public unsafe virtual Object Canis.attributes.IAttribute.ModValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219398, XrefRangeEnd = 1219400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_ModValue_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000CE1C File Offset: 0x0000B01C
		public unsafe virtual ReadOnlyAttribute AsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219400, XrefRangeEnd = 1219406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_AsReadOnly_Public_Virtual_Final_New_get_ReadOnlyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002EF6 File Offset: 0x000010F6
		public TransformAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000CE5C File Offset: 0x0000B05C
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00002EFF File Offset: 0x000010FF
		public unsafe IAttribute<TSourceValue> _source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<TSourceValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000CE8C File Offset: 0x0000B08C
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00002F1E File Offset: 0x0000111E
		public unsafe AttributeDefinition<TTargetValue> _definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<TTargetValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00002F3D File Offset: 0x0000113D
		public unsafe Func<TSourceValue, TTargetValue> _transformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__transformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSourceValue, TTargetValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__transformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000CEEC File Offset: 0x0000B0EC
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00002F5C File Offset: 0x0000115C
		public unsafe ReadOnlyAttribute<TTargetValue> _asReadonly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__asReadonly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<TTargetValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__asReadonly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000CF1C File Offset: 0x0000B11C
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00002F7B File Offset: 0x0000117B
		public unsafe ulong _cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedVersion)) = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000CF44 File Offset: 0x0000B144
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0000CF6C File Offset: 0x0000B16C
		public unsafe TTargetValue _cachedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedValue);
				return IL2CPP.PointerToValueGeneric<TTargetValue>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedValue);
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000D014 File Offset: 0x0000B214
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0000D03C File Offset: 0x0000B23C
		public unsafe TTargetValue _cachedModValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedModValue);
				return IL2CPP.PointerToValueGeneric<TTargetValue>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedModValue);
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

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeFieldInfoPtr__source;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr__definition;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr__transformation;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr__asReadonly;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeFieldInfoPtr__cachedVersion;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr__cachedValue;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr__cachedModValue;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_1_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TTargetValue_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_get_ModValue_Public_Virtual_Final_New_get_TTargetValue_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Value_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IAttribute_get_ModValue_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_get_AsReadOnly_Public_Virtual_Final_New_get_ReadOnlyAttribute_0;
	}
}
