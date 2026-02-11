using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000373 RID: 883
	public sealed class ValueFixup : Object
	{
		// Token: 0x06003700 RID: 14080 RVA: 0x0010E258 File Offset: 0x0010C458
		// Note: this type is marked as 'beforefieldinit'.
		static ValueFixup()
		{
			Il2CppClassPointerStore<ValueFixup>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ValueFixup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr);
			ValueFixup.NativeFieldInfoPtr_valueFixupEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "valueFixupEnum");
			ValueFixup.NativeFieldInfoPtr_arrayObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "arrayObj");
			ValueFixup.NativeFieldInfoPtr_indexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "indexMap");
			ValueFixup.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "header");
			ValueFixup.NativeFieldInfoPtr_memberObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "memberObject");
			ValueFixup.NativeFieldInfoPtr_valueInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "valueInfo");
			ValueFixup.NativeFieldInfoPtr_objectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "objectInfo");
			ValueFixup.NativeFieldInfoPtr_memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "memberName");
			ValueFixup.NativeMethodInfoPtr__ctor_Internal_Void_Array_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, 100671583);
			ValueFixup.NativeMethodInfoPtr__ctor_Internal_Void_Object_String_ReadObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, 100671584);
			ValueFixup.NativeMethodInfoPtr_Fixup_Internal_Void_ParseRecord_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, 100671585);
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x0010E364 File Offset: 0x0010C564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1391155, RefRangeEnd = 1391156, XrefRangeStart = 1391152, XrefRangeEnd = 1391155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueFixup(Array arrayObj, Il2CppStructArray<int> indexMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrayObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueFixup.NativeMethodInfoPtr__ctor_Internal_Void_Array_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x0010E3C4 File Offset: 0x0010C5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391156, XrefRangeEnd = 1391160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueFixup(Object memberObject, string memberName, ReadObjectInfo objectInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueFixup.NativeMethodInfoPtr__ctor_Internal_Void_Object_String_ReadObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x0010E434 File Offset: 0x0010C634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1391160, XrefRangeEnd = 1391167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fixup(ParseRecord record, ParseRecord parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueFixup.NativeMethodInfoPtr_Fixup_Internal_Void_ParseRecord_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00013FAA File Offset: 0x000121AA
		public ValueFixup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x0010E488 File Offset: 0x0010C688
		// (set) Token: 0x06003706 RID: 14086 RVA: 0x00013FB3 File Offset: 0x000121B3
		public unsafe ValueFixupEnum valueFixupEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_valueFixupEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_valueFixupEnum)) = value;
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06003707 RID: 14087 RVA: 0x0010E4B0 File Offset: 0x0010C6B0
		// (set) Token: 0x06003708 RID: 14088 RVA: 0x00013FCE File Offset: 0x000121CE
		public unsafe Array arrayObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_arrayObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_arrayObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06003709 RID: 14089 RVA: 0x0010E4E0 File Offset: 0x0010C6E0
		// (set) Token: 0x0600370A RID: 14090 RVA: 0x00013FED File Offset: 0x000121ED
		public unsafe Il2CppStructArray<int> indexMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_indexMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_indexMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x0600370B RID: 14091 RVA: 0x0010E510 File Offset: 0x0010C710
		// (set) Token: 0x0600370C RID: 14092 RVA: 0x0001400C File Offset: 0x0001220C
		public unsafe Object header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_header);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_header), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x0600370D RID: 14093 RVA: 0x0010E540 File Offset: 0x0010C740
		// (set) Token: 0x0600370E RID: 14094 RVA: 0x0001402B File Offset: 0x0001222B
		public unsafe Object memberObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_memberObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_memberObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x0600370F RID: 14095 RVA: 0x0010E570 File Offset: 0x0010C770
		// (set) Token: 0x06003710 RID: 14096 RVA: 0x0001404A File Offset: 0x0001224A
		public unsafe static MemberInfo valueInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValueFixup.NativeFieldInfoPtr_valueInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValueFixup.NativeFieldInfoPtr_valueInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06003711 RID: 14097 RVA: 0x0010E598 File Offset: 0x0010C798
		// (set) Token: 0x06003712 RID: 14098 RVA: 0x0001405C File Offset: 0x0001225C
		public unsafe ReadObjectInfo objectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_objectInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_objectInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06003713 RID: 14099 RVA: 0x0010E5C8 File Offset: 0x0010C7C8
		// (set) Token: 0x06003714 RID: 14100 RVA: 0x0001407B File Offset: 0x0001227B
		public unsafe string memberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_memberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_memberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002CB6 RID: 11446
		private static readonly IntPtr NativeFieldInfoPtr_valueFixupEnum;

		// Token: 0x04002CB7 RID: 11447
		private static readonly IntPtr NativeFieldInfoPtr_arrayObj;

		// Token: 0x04002CB8 RID: 11448
		private static readonly IntPtr NativeFieldInfoPtr_indexMap;

		// Token: 0x04002CB9 RID: 11449
		private static readonly IntPtr NativeFieldInfoPtr_header;

		// Token: 0x04002CBA RID: 11450
		private static readonly IntPtr NativeFieldInfoPtr_memberObject;

		// Token: 0x04002CBB RID: 11451
		private static readonly IntPtr NativeFieldInfoPtr_valueInfo;

		// Token: 0x04002CBC RID: 11452
		private static readonly IntPtr NativeFieldInfoPtr_objectInfo;

		// Token: 0x04002CBD RID: 11453
		private static readonly IntPtr NativeFieldInfoPtr_memberName;

		// Token: 0x04002CBE RID: 11454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Array_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002CBF RID: 11455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_String_ReadObjectInfo_0;

		// Token: 0x04002CC0 RID: 11456
		private static readonly IntPtr NativeMethodInfoPtr_Fixup_Internal_Void_ParseRecord_ParseRecord_0;
	}
}
