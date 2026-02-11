using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.attributes.meta
{
	// Token: 0x02000024 RID: 36
	public class ComputedAttribute<TSourceValue, TTargetValue> : Object
	{
		// Token: 0x0600025B RID: 603 RVA: 0x0000BB2C File Offset: 0x00009D2C
		// Note: this type is marked as 'beforefieldinit'.
		static ComputedAttribute()
		{
			Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes.meta", "ComputedAttribute`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSourceValue>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTargetValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr);
			ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, "_source");
			ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, "_definition");
			ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, "_compute");
			ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__asReadonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, "_asReadonly");
			ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, "_cachedVersion");
			ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, "_cachedValue");
			ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr__ctor_Public_Void_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663572);
			ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663573);
			ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663574);
			ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663575);
			ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663576);
			ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_TTargetValue__get_ModValue_Private_Virtual_Final_New_get_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663577);
			ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Value_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663578);
			ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_ModValue_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663579);
			ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_AsReadOnly_Public_Virtual_Final_New_get_ReadOnlyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663580);
			ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr___ctor_b__6_0_Private_ReadOnlyAttribute_1_TTargetValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr, 100663581);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000BCEC File Offset: 0x00009EEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1219030, RefRangeEnd = 1219032, XrefRangeStart = 1219002, XrefRangeEnd = 1219030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComputedAttribute(TSourceValue source, AttributeDefinition<TTargetValue> definition, Func<TSourceValue, TTargetValue> compute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputedAttribute<TSourceValue, TTargetValue>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TSourceValue).IsValueType)
				{
					TSourceValue tsourceValue = source;
					intPtr = ((tsourceValue is string) ? IL2CPP.ManagedStringToIl2Cpp(tsourceValue as string) : IL2CPP.Il2CppObjectBaseToPtr(tsourceValue as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref source;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(compute);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr__ctor_Public_Void_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000BD94 File Offset: 0x00009F94
		public unsafe virtual ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219032, XrefRangeEnd = 1219050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000BDD0 File Offset: 0x00009FD0
		public unsafe virtual int Name
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1219050, RefRangeEnd = 1219054, XrefRangeStart = 1219050, XrefRangeEnd = 1219050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000BE0C File Offset: 0x0000A00C
		public unsafe virtual Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219054, XrefRangeEnd = 1219076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000BE4C File Offset: 0x0000A04C
		public unsafe virtual TTargetValue Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219076, XrefRangeEnd = 1219082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TTargetValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TTargetValue>(intPtr, false, true);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0000BE88 File Offset: 0x0000A088
		public unsafe virtual TTargetValue Canis.attributes.IAttribute<TTargetValue>.ModValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219082, XrefRangeEnd = 1219086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_TTargetValue__get_ModValue_Private_Virtual_Final_New_get_TTargetValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TTargetValue>(intPtr, false, true);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
		public unsafe virtual Object Canis.attributes.IAttribute.Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219086, XrefRangeEnd = 1219088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Value_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000BF04 File Offset: 0x0000A104
		public unsafe virtual Object Canis.attributes.IAttribute.ModValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_ModValue_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000BF44 File Offset: 0x0000A144
		public unsafe virtual ReadOnlyAttribute AsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219088, XrefRangeEnd = 1219091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr_get_AsReadOnly_Public_Virtual_Final_New_get_ReadOnlyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000BF84 File Offset: 0x0000A184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1219091, XrefRangeEnd = 1219094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute<TTargetValue> __ctor_b__6_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedAttribute<TSourceValue, TTargetValue>.NativeMethodInfoPtr___ctor_b__6_0_Private_ReadOnlyAttribute_1_TTargetValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<TTargetValue>>(intPtr3) : null;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002E36 File Offset: 0x00001036
		public ComputedAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000BFC4 File Offset: 0x0000A1C4
		// (set) Token: 0x06000268 RID: 616 RVA: 0x0000BFEC File Offset: 0x0000A1EC
		public unsafe TSourceValue _source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__source);
				return IL2CPP.PointerToValueGeneric<TSourceValue>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__source);
				Type typeFromHandle = typeof(TSourceValue);
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

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000C094 File Offset: 0x0000A294
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00002E3F File Offset: 0x0000103F
		public unsafe AttributeDefinition<TTargetValue> _definition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__definition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<TTargetValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__definition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000C0C4 File Offset: 0x0000A2C4
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002E5E File Offset: 0x0000105E
		public unsafe Func<TSourceValue, TTargetValue> _compute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__compute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TSourceValue, TTargetValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00002E7D File Offset: 0x0000107D
		public unsafe Lazy<ReadOnlyAttribute<TTargetValue>> _asReadonly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__asReadonly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lazy<ReadOnlyAttribute<TTargetValue>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__asReadonly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000C124 File Offset: 0x0000A324
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00002E9C File Offset: 0x0000109C
		public unsafe ulong _cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedVersion)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000C14C File Offset: 0x0000A34C
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0000C174 File Offset: 0x0000A374
		public unsafe TTargetValue _cachedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedValue);
				return IL2CPP.PointerToValueGeneric<TTargetValue>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComputedAttribute<TSourceValue, TTargetValue>.NativeFieldInfoPtr__cachedValue);
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

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr__source;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr__definition;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr__compute;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr__asReadonly;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr__cachedVersion;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr__cachedValue;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TSourceValue_AttributeDefinition_1_TTargetValue_Func_2_TSourceValue_TTargetValue_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TTargetValue_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IAttribute_TTargetValue__get_ModValue_Private_Virtual_Final_New_get_TTargetValue_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Value_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IAttribute_get_ModValue_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_get_AsReadOnly_Public_Virtual_Final_New_get_ReadOnlyAttribute_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__6_0_Private_ReadOnlyAttribute_1_TTargetValue_0;
	}
}
