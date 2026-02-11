using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200031A RID: 794
	public sealed class SerializationInfoEnumerator : Object
	{
		// Token: 0x0600309F RID: 12447 RVA: 0x000F7F20 File Offset: 0x000F6120
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationInfoEnumerator()
		{
			Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationInfoEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr);
			SerializationInfoEnumerator.NativeFieldInfoPtr__members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "_members");
			SerializationInfoEnumerator.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "_data");
			SerializationInfoEnumerator.NativeFieldInfoPtr__types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "_types");
			SerializationInfoEnumerator.NativeFieldInfoPtr__numItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "_numItems");
			SerializationInfoEnumerator.NativeFieldInfoPtr__currItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "_currItem");
			SerializationInfoEnumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, "_current");
			SerializationInfoEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100670963);
			SerializationInfoEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100670964);
			SerializationInfoEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100670965);
			SerializationInfoEnumerator.NativeMethodInfoPtr_get_Current_Public_get_SerializationEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100670966);
			SerializationInfoEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100670967);
			SerializationInfoEnumerator.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100670968);
			SerializationInfoEnumerator.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100670969);
			SerializationInfoEnumerator.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr, 100670970);
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x000F8068 File Offset: 0x000F6268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1384497, RefRangeEnd = 1384498, XrefRangeStart = 1384493, XrefRangeEnd = 1384497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationInfoEnumerator(Il2CppStringArray members, Il2CppReferenceArray<Object> info, Il2CppReferenceArray<Type> types, int numItems)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationInfoEnumerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(members);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(types);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numItems;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x000F80E8 File Offset: 0x000F62E8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1384498, RefRangeEnd = 1384515, XrefRangeStart = 1384498, XrefRangeEnd = 1384498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x000F8124 File Offset: 0x000F6324
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1384515, XrefRangeEnd = 1384519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x000F8164 File Offset: 0x000F6364
		public unsafe SerializationEntry Current
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1384522, RefRangeEnd = 1384531, XrefRangeStart = 1384519, XrefRangeEnd = 1384522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_get_Current_Public_get_SerializationEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new SerializationEntry(intPtr);
			}
		}

		// Token: 0x060030A4 RID: 12452 RVA: 0x000F819C File Offset: 0x000F639C
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060030A5 RID: 12453 RVA: 0x000F81D0 File Offset: 0x000F63D0
		public unsafe string Name
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1384531, RefRangeEnd = 1384544, XrefRangeStart = 1384531, XrefRangeEnd = 1384531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060030A6 RID: 12454 RVA: 0x000F8208 File Offset: 0x000F6408
		public unsafe Object Value
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1384544, RefRangeEnd = 1384558, XrefRangeStart = 1384544, XrefRangeEnd = 1384544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060030A7 RID: 12455 RVA: 0x000F8248 File Offset: 0x000F6448
		public unsafe Type ObjectType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1384558, RefRangeEnd = 1384559, XrefRangeStart = 1384558, XrefRangeEnd = 1384558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationInfoEnumerator.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x00010B65 File Offset: 0x0000ED65
		public SerializationInfoEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x000F8288 File Offset: 0x000F6488
		// (set) Token: 0x060030AA RID: 12458 RVA: 0x00010B6E File Offset: 0x0000ED6E
		public unsafe Il2CppStringArray _members
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr__members);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr__members), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060030AB RID: 12459 RVA: 0x000F82B8 File Offset: 0x000F64B8
		// (set) Token: 0x060030AC RID: 12460 RVA: 0x00010B8D File Offset: 0x0000ED8D
		public unsafe Il2CppReferenceArray<Object> _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x000F82E8 File Offset: 0x000F64E8
		// (set) Token: 0x060030AE RID: 12462 RVA: 0x00010BAC File Offset: 0x0000EDAC
		public unsafe Il2CppReferenceArray<Type> _types
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr__types);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr__types), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060030AF RID: 12463 RVA: 0x000F8318 File Offset: 0x000F6518
		// (set) Token: 0x060030B0 RID: 12464 RVA: 0x00010BCB File Offset: 0x0000EDCB
		public unsafe int _numItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr__numItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr__numItems)) = value;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060030B1 RID: 12465 RVA: 0x000F8340 File Offset: 0x000F6540
		// (set) Token: 0x060030B2 RID: 12466 RVA: 0x00010BE6 File Offset: 0x0000EDE6
		public unsafe int _currItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr__currItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr__currItem)) = value;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060030B3 RID: 12467 RVA: 0x000F8368 File Offset: 0x000F6568
		// (set) Token: 0x060030B4 RID: 12468 RVA: 0x00010C01 File Offset: 0x0000EE01
		public unsafe bool _current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr__current);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationInfoEnumerator.NativeFieldInfoPtr__current)) = value;
			}
		}

		// Token: 0x04002825 RID: 10277
		private static readonly IntPtr NativeFieldInfoPtr__members;

		// Token: 0x04002826 RID: 10278
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x04002827 RID: 10279
		private static readonly IntPtr NativeFieldInfoPtr__types;

		// Token: 0x04002828 RID: 10280
		private static readonly IntPtr NativeFieldInfoPtr__numItems;

		// Token: 0x04002829 RID: 10281
		private static readonly IntPtr NativeFieldInfoPtr__currItem;

		// Token: 0x0400282A RID: 10282
		private static readonly IntPtr NativeFieldInfoPtr__current;

		// Token: 0x0400282B RID: 10283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStringArray_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Type_Int32_0;

		// Token: 0x0400282C RID: 10284
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400282D RID: 10285
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400282E RID: 10286
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_SerializationEntry_0;

		// Token: 0x0400282F RID: 10287
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002830 RID: 10288
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04002831 RID: 10289
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x04002832 RID: 10290
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;
	}
}
