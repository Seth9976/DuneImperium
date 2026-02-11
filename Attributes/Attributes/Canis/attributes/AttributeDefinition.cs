using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.attributes
{
	// Token: 0x02000009 RID: 9
	public sealed class AttributeDefinition<V> : Object
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00003CF0 File Offset: 0x00001EF0
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeDefinition()
		{
			Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "AttributeDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr);
			AttributeDefinition<V>.NativeFieldInfoPtr__ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, "_ValueType");
			AttributeDefinition<V>.NativeFieldInfoPtr__Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, "_Default");
			AttributeDefinition<V>.NativeFieldInfoPtr__Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, "<Key>k__BackingField");
			AttributeDefinition<V>.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, "<Name>k__BackingField");
			AttributeDefinition<V>.NativeMethodInfoPtr__ctor_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, 100663310);
			AttributeDefinition<V>.NativeMethodInfoPtr_Create_Public_Static_AttributeDefinition_1_V_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, 100663311);
			AttributeDefinition<V>.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, 100663312);
			AttributeDefinition<V>.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, 100663313);
			AttributeDefinition<V>.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, 100663314);
			AttributeDefinition<V>.NativeMethodInfoPtr_Canis_attributes_IAttributeDefinition_Factory_Private_Virtual_Final_New_IMutableAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, 100663315);
			AttributeDefinition<V>.NativeMethodInfoPtr_Factory_Public_MutableAttribute_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, 100663316);
			AttributeDefinition<V>.NativeMethodInfoPtr_Factory_Public_MutableAttribute_1_V_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, 100663317);
			AttributeDefinition<V>.NativeMethodInfoPtr_Factory_Public_MutableAttribute_1_V_V_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, 100663318);
			AttributeDefinition<V>.NativeMethodInfoPtr_Canis_attributes_IAttributeDefinition_Factory_Private_Virtual_Final_New_IMutableAttribute_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, 100663319);
			AttributeDefinition<V>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, 100663320);
			AttributeDefinition<V>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, 100663321);
			AttributeDefinition<V>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr, 100663322);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003EB0 File Offset: 0x000020B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 568210, RefRangeEnd = 568211, XrefRangeStart = 568210, XrefRangeEnd = 568211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeDefinition(string fieldName, int key)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeDefinition<V>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fieldName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinition<V>.NativeMethodInfoPtr__ctor_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003F0C File Offset: 0x0000210C
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 1215147, RefRangeEnd = 1215207, XrefRangeStart = 1215080, XrefRangeEnd = 1215147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeDefinition<V> Create(string name, int key)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinition<V>.NativeMethodInfoPtr_Create_Public_Static_AttributeDefinition_1_V_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<V>>(intPtr3) : null;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003F60 File Offset: 0x00002160
		public unsafe int Key
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinition<V>.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003F9C File Offset: 0x0000219C
		public unsafe string Name
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinition<V>.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003FD4 File Offset: 0x000021D4
		public unsafe Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215207, XrefRangeEnd = 1215209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinition<V>.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004014 File Offset: 0x00002214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215209, XrefRangeEnd = 1215215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMutableAttribute Canis_attributes_IAttributeDefinition_Factory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinition<V>.NativeMethodInfoPtr_Canis_attributes_IAttributeDefinition_Factory_Private_Virtual_Final_New_IMutableAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMutableAttribute>(intPtr3) : null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004054 File Offset: 0x00002254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1215221, RefRangeEnd = 1215223, XrefRangeStart = 1215215, XrefRangeEnd = 1215221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttribute<V> Factory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinition<V>.NativeMethodInfoPtr_Factory_Public_MutableAttribute_1_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttribute<V>>(intPtr3) : null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004094 File Offset: 0x00002294
		[CallerCount(104)]
		[CachedScanResults(RefRangeStart = 1215226, RefRangeEnd = 1215330, XrefRangeStart = 1215223, XrefRangeEnd = 1215226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttribute<V> Factory(V value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(V).IsValueType)
				{
					V v = value;
					intPtr = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AttributeDefinition<V>.NativeMethodInfoPtr_Factory_Public_MutableAttribute_1_V_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<MutableAttribute<V>>(intPtr4) : null;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000411C File Offset: 0x0000231C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215330, XrefRangeEnd = 1215333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttribute<V> Factory(V value, V modValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(V).IsValueType)
				{
					V v = value;
					intPtr = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(V).IsValueType)
			{
				V v2 = modValue;
				intPtr2 = ((v2 is string) ? IL2CPP.ManagedStringToIl2Cpp(v2 as string) : IL2CPP.Il2CppObjectBaseToPtr(v2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref modValue;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AttributeDefinition<V>.NativeMethodInfoPtr_Factory_Public_MutableAttribute_1_V_V_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<MutableAttribute<V>>(intPtr5) : null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000041EC File Offset: 0x000023EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215333, XrefRangeEnd = 1215340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IMutableAttribute Canis_attributes_IAttributeDefinition_Factory(Object value, Object modValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinition<V>.NativeMethodInfoPtr_Canis_attributes_IAttributeDefinition_Factory_Private_Virtual_Final_New_IMutableAttribute_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMutableAttribute>(intPtr3) : null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004250 File Offset: 0x00002450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215340, XrefRangeEnd = 1215352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(IAttributeDefinition other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinition<V>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000042A0 File Offset: 0x000024A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215352, XrefRangeEnd = 1215353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinition<V>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000042F0 File Offset: 0x000024F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeDefinition<V>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002194 File Offset: 0x00000394
		public AttributeDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000432C File Offset: 0x0000252C
		// (set) Token: 0x06000036 RID: 54 RVA: 0x0000219D File Offset: 0x0000039D
		public unsafe static Type _ValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeDefinition<V>.NativeFieldInfoPtr__ValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AttributeDefinition<V>.NativeFieldInfoPtr__ValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00004354 File Offset: 0x00002554
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00004378 File Offset: 0x00002578
		public unsafe static V _Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AttributeDefinition<V>.NativeFieldInfoPtr__Default, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<V>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr__Default = AttributeDefinition<V>.NativeFieldInfoPtr__Default;
				ref V ptr2;
				if (!typeof(V).IsValueType)
				{
					V v = value;
					if (!(v is string))
					{
						ref V ptr = (ptr2 = IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
						if ((ref ptr) != null)
						{
							ptr2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(v as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr__Default, (void*)(&ptr2));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000043E0 File Offset: 0x000025E0
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000021AF File Offset: 0x000003AF
		public unsafe int _Key_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeDefinition<V>.NativeFieldInfoPtr__Key_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeDefinition<V>.NativeFieldInfoPtr__Key_k__BackingField)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00004408 File Offset: 0x00002608
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000021CA File Offset: 0x000003CA
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeDefinition<V>.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeDefinition<V>.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr__ValueType;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr__Default;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr__Key_k__BackingField;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_Int32_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AttributeDefinition_1_V_String_Int32_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IAttributeDefinition_Factory_Private_Virtual_Final_New_IMutableAttribute_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_Factory_Public_MutableAttribute_1_V_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_Factory_Public_MutableAttribute_1_V_V_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_Factory_Public_MutableAttribute_1_V_V_V_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IAttributeDefinition_Factory_Private_Virtual_Final_New_IMutableAttribute_Object_Object_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IAttributeDefinition_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
