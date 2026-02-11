using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Data.Common
{
	// Token: 0x020000C7 RID: 199
	public sealed class TimeSpanStorage : DataStorage
	{
		// Token: 0x060013CD RID: 5069 RVA: 0x0005F410 File Offset: 0x0005D610
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpanStorage()
		{
			Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.Common", "TimeSpanStorage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr);
			TimeSpanStorage.NativeFieldInfoPtr_s_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, "s_defaultValue");
			TimeSpanStorage.NativeFieldInfoPtr__values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, "_values");
			TimeSpanStorage.NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666565);
			TimeSpanStorage.NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666566);
			TimeSpanStorage.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666567);
			TimeSpanStorage.NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666568);
			TimeSpanStorage.NativeMethodInfoPtr_ConvertToTimeSpan_Private_Static_TimeSpan_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666569);
			TimeSpanStorage.NativeMethodInfoPtr_ConvertValue_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666570);
			TimeSpanStorage.NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666571);
			TimeSpanStorage.NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666572);
			TimeSpanStorage.NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666573);
			TimeSpanStorage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666574);
			TimeSpanStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666575);
			TimeSpanStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666576);
			TimeSpanStorage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666577);
			TimeSpanStorage.NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666578);
			TimeSpanStorage.NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr, 100666579);
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x0005F594 File Offset: 0x0005D794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928300, XrefRangeEnd = 928317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpanStorage(DataColumn column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanStorage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x0005F5E0 File Offset: 0x0005D7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928317, XrefRangeEnd = 928432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Aggregate(Il2CppStructArray<int> records, AggregateType kind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(records);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref kind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x0005F640 File Offset: 0x0005D840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928432, XrefRangeEnd = 928450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Compare(int recordNo1, int recordNo2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordNo1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recordNo2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x0005F698 File Offset: 0x0005D898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928450, XrefRangeEnd = 928458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int CompareValueTo(int recordNo, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordNo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0005F6F4 File Offset: 0x0005D8F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 928486, RefRangeEnd = 928487, XrefRangeStart = 928458, XrefRangeEnd = 928486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan ConvertToTimeSpan(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_ConvertToTimeSpan_Private_Static_TimeSpan_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0005F738 File Offset: 0x0005D938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928487, XrefRangeEnd = 928489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ConvertValue(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_ConvertValue_Public_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0005F788 File Offset: 0x0005D988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928489, XrefRangeEnd = 928490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Copy(int recordNo1, int recordNo2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordNo1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recordNo2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0005F7D4 File Offset: 0x0005D9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928490, XrefRangeEnd = 928501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Get(int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0005F820 File Offset: 0x0005DA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928501, XrefRangeEnd = 928518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Set(int record, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0005F870 File Offset: 0x0005DA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928518, XrefRangeEnd = 928528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0005F8B0 File Offset: 0x0005DAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928528, XrefRangeEnd = 928535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ConvertXmlToObject(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0005F900 File Offset: 0x0005DB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928535, XrefRangeEnd = 928544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ConvertObjectToXml(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0005F948 File Offset: 0x0005DB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928544, XrefRangeEnd = 928547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetEmptyStorage(int recordCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recordCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0005F994 File Offset: 0x0005DB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928547, XrefRangeEnd = 928557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyValue(int record, Object store, BitArray nullbits, int storeIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref record;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(store);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nullbits);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0005FA04 File Offset: 0x0005DC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928557, XrefRangeEnd = 928567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetStorage(Object store, BitArray nullbits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(store);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nullbits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanStorage.NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x00007828 File Offset: 0x00005A28
		public TimeSpanStorage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x0005FA58 File Offset: 0x0005DC58
		// (set) Token: 0x060013DF RID: 5087 RVA: 0x00007831 File Offset: 0x00005A31
		public unsafe static TimeSpan s_defaultValue
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(TimeSpanStorage.NativeFieldInfoPtr_s_defaultValue, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanStorage.NativeFieldInfoPtr_s_defaultValue, (void*)(&value));
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x0005FA74 File Offset: 0x0005DC74
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x0000783F File Offset: 0x00005A3F
		public unsafe Il2CppStructArray<TimeSpan> _values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanStorage.NativeFieldInfoPtr__values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TimeSpan>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanStorage.NativeFieldInfoPtr__values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultValue;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeFieldInfoPtr__values;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataColumn_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_Aggregate_Public_Virtual_Object_Il2CppStructArray_1_Int32_AggregateType_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Int32_Int32_Int32_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_CompareValueTo_Public_Virtual_Int32_Int32_Object_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToTimeSpan_Private_Static_TimeSpan_Object_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValue_Public_Virtual_Object_Object_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Void_Int32_Int32_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Object_Int32_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Void_Int32_Object_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Virtual_Void_Int32_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_ConvertXmlToObject_Public_Virtual_Object_String_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjectToXml_Public_Virtual_String_Object_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr_GetEmptyStorage_Protected_Virtual_Object_Int32_0;

		// Token: 0x040010A0 RID: 4256
		private static readonly IntPtr NativeMethodInfoPtr_CopyValue_Protected_Virtual_Void_Int32_Object_BitArray_Int32_0;

		// Token: 0x040010A1 RID: 4257
		private static readonly IntPtr NativeMethodInfoPtr_SetStorage_Protected_Virtual_Void_Object_BitArray_0;
	}
}
