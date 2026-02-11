using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000F6 RID: 246
	public class AttributeCollection : Object
	{
		// Token: 0x06000FBD RID: 4029 RVA: 0x0005738C File Offset: 0x0005558C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeCollection()
		{
			Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "AttributeCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr);
			AttributeCollection.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, "Empty");
			AttributeCollection.NativeFieldInfoPtr_s_defaultAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, "s_defaultAttributes");
			AttributeCollection.NativeFieldInfoPtr__attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, "_attributes");
			AttributeCollection.NativeFieldInfoPtr_s_internalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, "s_internalSyncObject");
			AttributeCollection.NativeFieldInfoPtr__foundAttributeTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, "_foundAttributeTypes");
			AttributeCollection.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, "_index");
			AttributeCollection.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, 100665563);
			AttributeCollection.NativeMethodInfoPtr_get_Attributes_Protected_Virtual_New_get_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, 100665564);
			AttributeCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, 100665565);
			AttributeCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Attribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, 100665566);
			AttributeCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, 100665567);
			AttributeCollection.NativeMethodInfoPtr_GetDefaultAttribute_Protected_Attribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, 100665568);
			AttributeCollection.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, 100665569);
			AttributeCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, 100665570);
			AttributeCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, 100665571);
			AttributeCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, 100665572);
			AttributeCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, 100665573);
			AttributeCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, 100665574);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00057524 File Offset: 0x00055724
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 456449, RefRangeEnd = 456457, XrefRangeStart = 456443, XrefRangeEnd = 456449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeCollection([Optional] Il2CppReferenceArray<Attribute> attributes)
		{
			if (attributes == null)
			{
				attributes = new Il2CppReferenceArray<Attribute>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCollection.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x0005757C File Offset: 0x0005577C
		public unsafe virtual Il2CppReferenceArray<Attribute> Attributes
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeCollection.NativeMethodInfoPtr_get_Attributes_Protected_Virtual_New_get_Il2CppReferenceArray_1_Attribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x000575C8 File Offset: 0x000557C8
		public unsafe int Count
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 456457, RefRangeEnd = 456462, XrefRangeStart = 456457, XrefRangeEnd = 456457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D4 RID: 1236
		public unsafe virtual Attribute this[Type attributeType]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456462, XrefRangeEnd = 456499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Attribute_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00057660 File Offset: 0x00055860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 456500, RefRangeEnd = 456502, XrefRangeStart = 456499, XrefRangeEnd = 456500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(Attribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCollection.NativeMethodInfoPtr_Contains_Public_Boolean_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x000576B0 File Offset: 0x000558B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 456558, RefRangeEnd = 456560, XrefRangeStart = 456502, XrefRangeEnd = 456558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Attribute GetDefaultAttribute(Type attributeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCollection.NativeMethodInfoPtr_GetDefaultAttribute_Protected_Attribute_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00057700 File Offset: 0x00055900
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 456562, RefRangeEnd = 456566, XrefRangeStart = 456560, XrefRangeEnd = 456562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCollection.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00057740 File Offset: 0x00055940
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x0005777C File Offset: 0x0005597C
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x000577BC File Offset: 0x000559BC
		public unsafe virtual int System.Collections.ICollection.Count
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 456457, RefRangeEnd = 456462, XrefRangeStart = 456457, XrefRangeEnd = 456462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x000577F8 File Offset: 0x000559F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 456562, RefRangeEnd = 456566, XrefRangeStart = 456562, XrefRangeEnd = 456566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00057838 File Offset: 0x00055A38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 456567, RefRangeEnd = 456569, XrefRangeStart = 456566, XrefRangeEnd = 456567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00007AD5 File Offset: 0x00005CD5
		public AttributeCollection(params Attribute[] attributes)
			: this(new Il2CppReferenceArray<Attribute>(attributes))
		{
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00007AE3 File Offset: 0x00005CE3
		public AttributeCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00057888 File Offset: 0x00055A88
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x00007AEC File Offset: 0x00005CEC
		public unsafe static AttributeCollection Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeCollection.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeCollection.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000FCE RID: 4046 RVA: 0x000578B0 File Offset: 0x00055AB0
		// (set) Token: 0x06000FCF RID: 4047 RVA: 0x00007AFE File Offset: 0x00005CFE
		public unsafe static Hashtable s_defaultAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeCollection.NativeFieldInfoPtr_s_defaultAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeCollection.NativeFieldInfoPtr_s_defaultAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000FD0 RID: 4048 RVA: 0x000578D8 File Offset: 0x00055AD8
		// (set) Token: 0x06000FD1 RID: 4049 RVA: 0x00007B10 File Offset: 0x00005D10
		public unsafe Il2CppReferenceArray<Attribute> _attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollection.NativeFieldInfoPtr__attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollection.NativeFieldInfoPtr__attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000FD2 RID: 4050 RVA: 0x00057908 File Offset: 0x00055B08
		// (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00007B2F File Offset: 0x00005D2F
		public unsafe static Object s_internalSyncObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeCollection.NativeFieldInfoPtr_s_internalSyncObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeCollection.NativeFieldInfoPtr_s_internalSyncObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00057930 File Offset: 0x00055B30
		// (set) Token: 0x06000FD5 RID: 4053 RVA: 0x00007B41 File Offset: 0x00005D41
		public unsafe Il2CppReferenceArray<AttributeCollection.AttributeEntry> _foundAttributeTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollection.NativeFieldInfoPtr__foundAttributeTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AttributeCollection.AttributeEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollection.NativeFieldInfoPtr__foundAttributeTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00057960 File Offset: 0x00055B60
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00007B60 File Offset: 0x00005D60
		public unsafe int _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollection.NativeFieldInfoPtr__index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollection.NativeFieldInfoPtr__index)) = value;
			}
		}

		// Token: 0x04000CB9 RID: 3257
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultAttributes;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeFieldInfoPtr__attributes;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeFieldInfoPtr_s_internalSyncObject;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeFieldInfoPtr__foundAttributeTypes;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Protected_Virtual_New_get_Il2CppReferenceArray_1_Attribute_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_Attribute_Type_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Attribute_0;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultAttribute_Protected_Attribute_Type_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x020002D8 RID: 728
		public sealed class AttributeEntry : ValueType
		{
			// Token: 0x06002C06 RID: 11270 RVA: 0x000C242C File Offset: 0x000C062C
			// Note: this type is marked as 'beforefieldinit'.
			static AttributeEntry()
			{
				Il2CppClassPointerStore<AttributeCollection.AttributeEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeCollection>.NativeClassPtr, "AttributeEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeCollection.AttributeEntry>.NativeClassPtr);
				AttributeCollection.AttributeEntry.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollection.AttributeEntry>.NativeClassPtr, "type");
				AttributeCollection.AttributeEntry.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeCollection.AttributeEntry>.NativeClassPtr, "index");
			}

			// Token: 0x06002C07 RID: 11271 RVA: 0x00013D59 File Offset: 0x00011F59
			public AttributeEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002C08 RID: 11272 RVA: 0x00013D62 File Offset: 0x00011F62
			public AttributeEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeCollection.AttributeEntry>.NativeClassPtr))
			{
			}

			// Token: 0x17000DD2 RID: 3538
			// (get) Token: 0x06002C09 RID: 11273 RVA: 0x000C2480 File Offset: 0x000C0680
			// (set) Token: 0x06002C0A RID: 11274 RVA: 0x00013D74 File Offset: 0x00011F74
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollection.AttributeEntry.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollection.AttributeEntry.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD3 RID: 3539
			// (get) Token: 0x06002C0B RID: 11275 RVA: 0x000C24B0 File Offset: 0x000C06B0
			// (set) Token: 0x06002C0C RID: 11276 RVA: 0x00013D93 File Offset: 0x00011F93
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollection.AttributeEntry.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeCollection.AttributeEntry.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x040022D3 RID: 8915
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x040022D4 RID: 8916
			private static readonly IntPtr NativeFieldInfoPtr_index;
		}
	}
}
