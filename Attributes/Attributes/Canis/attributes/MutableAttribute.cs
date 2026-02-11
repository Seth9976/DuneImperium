using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.attributes
{
	// Token: 0x02000019 RID: 25
	[Serializable]
	public sealed class MutableAttribute<V> : Object
	{
		// Token: 0x0600017D RID: 381 RVA: 0x00007660 File Offset: 0x00005860
		// Note: this type is marked as 'beforefieldinit'.
		static MutableAttribute()
		{
			Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "MutableAttribute`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr);
			MutableAttribute<V>.NativeFieldInfoPtr__ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, "_ValueType");
			MutableAttribute<V>.NativeFieldInfoPtr__Comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, "_Comparer");
			MutableAttribute<V>.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, "Name");
			MutableAttribute<V>.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, "_version");
			MutableAttribute<V>.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, "<Value>k__BackingField");
			MutableAttribute<V>.NativeFieldInfoPtr__ModValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, "<ModValue>k__BackingField");
			MutableAttribute<V>.NativeFieldInfoPtr__AsReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, "_AsReadOnly");
			MutableAttribute<V>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Name_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663383);
			MutableAttribute<V>.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663384);
			MutableAttribute<V>.NativeMethodInfoPtr__ctor_Public_Void_Int32_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663385);
			MutableAttribute<V>.NativeMethodInfoPtr__ctor_Public_Void_Int32_V_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663386);
			MutableAttribute<V>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663387);
			MutableAttribute<V>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663388);
			MutableAttribute<V>.NativeMethodInfoPtr_set_Value_Private_set_Void_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663389);
			MutableAttribute<V>.NativeMethodInfoPtr_get_ModValue_Public_Virtual_Final_New_get_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663390);
			MutableAttribute<V>.NativeMethodInfoPtr_set_ModValue_Private_set_Void_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663391);
			MutableAttribute<V>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Value_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663392);
			MutableAttribute<V>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_ModValue_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663393);
			MutableAttribute<V>.NativeMethodInfoPtr_get_AsReadOnly_Public_get_ReadOnlyAttribute_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663394);
			MutableAttribute<V>.NativeMethodInfoPtr_Set_Public_Void_IAttribute_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663395);
			MutableAttribute<V>.NativeMethodInfoPtr_Canis_attributes_IMutableAttribute_Set_Private_Virtual_Final_New_Void_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663396);
			MutableAttribute<V>.NativeMethodInfoPtr_Set_Public_Void_V_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663397);
			MutableAttribute<V>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663398);
			MutableAttribute<V>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_AsReadOnly_Private_Virtual_Final_New_get_ReadOnlyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663399);
			MutableAttribute<V>.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttribute_1_V_MutableAttribute_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663400);
			MutableAttribute<V>.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttribute_MutableAttribute_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr, 100663401);
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000078D4 File Offset: 0x00005AD4
		public unsafe int Canis.attributes.IAttribute.Name
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Name_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00007910 File Offset: 0x00005B10
		public unsafe Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215872, XrefRangeEnd = 1215874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00007950 File Offset: 0x00005B50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1215875, RefRangeEnd = 1215878, XrefRangeStart = 1215874, XrefRangeEnd = 1215875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttribute(int key, V value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr__ctor_Public_Void_Int32_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000079E0 File Offset: 0x00005BE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1215879, RefRangeEnd = 1215882, XrefRangeStart = 1215878, XrefRangeEnd = 1215879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttribute(int key, V value, V modValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableAttribute<V>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr__ctor_Public_Void_Int32_V_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00007AB8 File Offset: 0x00005CB8
		public unsafe ulong Version
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00007AF4 File Offset: 0x00005CF4
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00007B30 File Offset: 0x00005D30
		public unsafe V Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<V>(intPtr, false, true);
			}
			[CallerCount(0)]
			set
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_set_Value_Private_set_Void_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00007BA8 File Offset: 0x00005DA8
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00007BE4 File Offset: 0x00005DE4
		public unsafe V ModValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_get_ModValue_Public_Virtual_Final_New_get_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<V>(intPtr, false, true);
			}
			[CallerCount(0)]
			set
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
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_set_ModValue_Private_set_Void_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00007C5C File Offset: 0x00005E5C
		public unsafe Object Canis.attributes.IAttribute.Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215882, XrefRangeEnd = 1215883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Value_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00007C9C File Offset: 0x00005E9C
		public unsafe Object Canis.attributes.IAttribute.ModValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215883, XrefRangeEnd = 1215884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_ModValue_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00007CDC File Offset: 0x00005EDC
		public unsafe ReadOnlyAttribute<V> AsReadOnly
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1215888, RefRangeEnd = 1215896, XrefRangeStart = 1215884, XrefRangeEnd = 1215888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_get_AsReadOnly_Public_get_ReadOnlyAttribute_1_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00007D1C File Offset: 0x00005F1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1215919, RefRangeEnd = 1215921, XrefRangeStart = 1215896, XrefRangeEnd = 1215919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(IAttribute<V> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_Set_Public_Void_IAttribute_1_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00007D60 File Offset: 0x00005F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215921, XrefRangeEnd = 1216064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Canis_attributes_IMutableAttribute_Set(IAttribute other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_Canis_attributes_IMutableAttribute_Set_Private_Virtual_Final_New_Void_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00007DA4 File Offset: 0x00005FA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1216076, RefRangeEnd = 1216078, XrefRangeStart = 1216064, XrefRangeEnd = 1216076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(V newValue, V modValue)
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
					V v = newValue;
					intPtr = ((v is string) ? IL2CPP.ManagedStringToIl2Cpp(v as string) : IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref newValue;
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_Set_Public_Void_V_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00007E64 File Offset: 0x00006064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216078, XrefRangeEnd = 1216090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00007E98 File Offset: 0x00006098
		public unsafe ReadOnlyAttribute Canis.attributes.IAttribute.AsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216090, XrefRangeEnd = 1216095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_Canis_attributes_IAttribute_get_AsReadOnly_Private_Virtual_Final_New_get_ReadOnlyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00007ED8 File Offset: 0x000060D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1216097, RefRangeEnd = 1216098, XrefRangeStart = 1216095, XrefRangeEnd = 1216097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ReadOnlyAttribute<V>(MutableAttribute<V> attribute)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttribute_1_V_MutableAttribute_1_V_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00007F1C File Offset: 0x0000611C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1216097, RefRangeEnd = 1216098, XrefRangeStart = 1216097, XrefRangeEnd = 1216098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ReadOnlyAttribute(MutableAttribute<V> attribute)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttribute<V>.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttribute_MutableAttribute_1_V_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002B0B File Offset: 0x00000D0B
		public MutableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00007F60 File Offset: 0x00006160
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002B14 File Offset: 0x00000D14
		public unsafe static Type _ValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MutableAttribute<V>.NativeFieldInfoPtr__ValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MutableAttribute<V>.NativeFieldInfoPtr__ValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00007F88 File Offset: 0x00006188
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00002B26 File Offset: 0x00000D26
		public unsafe static EqualityComparer<V> _Comparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MutableAttribute<V>.NativeFieldInfoPtr__Comparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EqualityComparer<V>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MutableAttribute<V>.NativeFieldInfoPtr__Comparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00007FB0 File Offset: 0x000061B0
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00002B38 File Offset: 0x00000D38
		public unsafe int Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttribute<V>.NativeFieldInfoPtr_Name);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttribute<V>.NativeFieldInfoPtr_Name)) = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00007FD8 File Offset: 0x000061D8
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002B53 File Offset: 0x00000D53
		public unsafe ulong _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttribute<V>.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttribute<V>.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00008000 File Offset: 0x00006200
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00008028 File Offset: 0x00006228
		public unsafe V _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttribute<V>.NativeFieldInfoPtr__Value_k__BackingField);
				return IL2CPP.PointerToValueGeneric<V>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttribute<V>.NativeFieldInfoPtr__Value_k__BackingField);
				Type typeFromHandle = typeof(V);
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

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000080D0 File Offset: 0x000062D0
		// (set) Token: 0x0600019D RID: 413 RVA: 0x000080F8 File Offset: 0x000062F8
		public unsafe V _ModValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttribute<V>.NativeFieldInfoPtr__ModValue_k__BackingField);
				return IL2CPP.PointerToValueGeneric<V>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttribute<V>.NativeFieldInfoPtr__ModValue_k__BackingField);
				Type typeFromHandle = typeof(V);
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

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600019E RID: 414 RVA: 0x000081A0 File Offset: 0x000063A0
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002B6E File Offset: 0x00000D6E
		public unsafe ReadOnlyAttribute<V> _AsReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttribute<V>.NativeFieldInfoPtr__AsReadOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<V>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttribute<V>.NativeFieldInfoPtr__AsReadOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr__ValueType;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr__Comparer;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr__ModValue_k__BackingField;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr__AsReadOnly;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Name_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_V_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_V_V_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_Final_New_get_UInt64_0;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_V_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Private_set_Void_V_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_get_ModValue_Public_Virtual_Final_New_get_V_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_set_ModValue_Private_set_Void_V_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IAttribute_get_Value_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IAttribute_get_ModValue_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_get_AsReadOnly_Public_get_ReadOnlyAttribute_1_V_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_IAttribute_1_V_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IMutableAttribute_Set_Private_Virtual_Final_New_Void_IAttribute_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_V_V_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IAttribute_get_AsReadOnly_Private_Virtual_Final_New_get_ReadOnlyAttribute_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttribute_1_V_MutableAttribute_1_V_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttribute_MutableAttribute_1_V_0;
	}
}
