using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.attributes
{
	// Token: 0x02000021 RID: 33
	public class SerializableAttributes : Object
	{
		// Token: 0x06000224 RID: 548 RVA: 0x0000ABB8 File Offset: 0x00008DB8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableAttributes()
		{
			Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "SerializableAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr);
			SerializableAttributes.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, "data");
			SerializableAttributes.NativeFieldInfoPtr__ReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, "_ReadOnly");
			SerializableAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663525);
			SerializableAttributes.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663526);
			SerializableAttributes.NativeMethodInfoPtr__ctor_Public_Void_IList_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663527);
			SerializableAttributes.NativeMethodInfoPtr__ctor_Public_Void_SerializableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663528);
			SerializableAttributes.NativeMethodInfoPtr_set_Private_Void_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663529);
			SerializableAttributes.NativeMethodInfoPtr_TryGetAttribute_Public_Boolean_AttributeDefinition_1_T_byref_ReadOnlyAttribute_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663530);
			SerializableAttributes.NativeMethodInfoPtr_TryGetValue_Public_Boolean_AttributeDefinition_1_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663531);
			SerializableAttributes.NativeMethodInfoPtr_TryGetValue_Public_T_AttributeDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663532);
			SerializableAttributes.NativeMethodInfoPtr_Clone_Public_SerializableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663533);
			SerializableAttributes.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663534);
			SerializableAttributes.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_ReadOnlyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663535);
			SerializableAttributes.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663536);
			SerializableAttributes.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663537);
			SerializableAttributes.NativeMethodInfoPtr_get_AsReadOnly_Public_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663538);
			SerializableAttributes.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttributes_SerializableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663539);
			SerializableAttributes.NativeMethodInfoPtr_op_Implicit_Public_Static_MutableAttributes_SerializableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663540);
			SerializableAttributes.NativeMethodInfoPtr_op_Implicit_Public_Static_SerializableAttributes_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663541);
			SerializableAttributes.NativeMethodInfoPtr_op_Implicit_Public_Static_SerializableAttributes_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663542);
			SerializableAttributes.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, 100663543);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000AD8C File Offset: 0x00008F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218514, XrefRangeEnd = 1218522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000ADC8 File Offset: 0x00008FC8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1218548, RefRangeEnd = 1218554, XrefRangeStart = 1218522, XrefRangeEnd = 1218548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableAttributes(IEnumerable<IAttribute> attributes, int capacity = 8)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000AE24 File Offset: 0x00009024
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1218583, RefRangeEnd = 1218593, XrefRangeStart = 1218554, XrefRangeEnd = 1218583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableAttributes(IList<IAttribute> attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr__ctor_Public_Void_IList_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000AE70 File Offset: 0x00009070
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1218655, RefRangeEnd = 1218658, XrefRangeStart = 1218593, XrefRangeEnd = 1218655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableAttributes(SerializableAttributes other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr__ctor_Public_Void_SerializableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000AEBC File Offset: 0x000090BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1218689, RefRangeEnd = 1218691, XrefRangeStart = 1218658, XrefRangeEnd = 1218689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set(IAttribute attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr_set_Private_Void_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000AF00 File Offset: 0x00009100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1218700, RefRangeEnd = 1218701, XrefRangeStart = 1218691, XrefRangeEnd = 1218700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetAttribute<T>(AttributeDefinition<T> definition, out ReadOnlyAttribute<T> attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.MethodInfoStoreGeneric_TryGetAttribute_Public_Boolean_AttributeDefinition_1_T_byref_ReadOnlyAttribute_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			attribute = ((intPtr4 == 0) ? null : new ReadOnlyAttribute<T>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000AF70 File Offset: 0x00009170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1218714, RefRangeEnd = 1218715, XrefRangeStart = 1218701, XrefRangeEnd = 1218714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue<T>(AttributeDefinition<T> definition, out T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.MethodInfoStoreGeneric_TryGetValue_Public_Boolean_AttributeDefinition_1_T_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000B00C File Offset: 0x0000920C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218715, XrefRangeEnd = 1218721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T TryGetValue<T>(AttributeDefinition<T> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.MethodInfoStoreGeneric_TryGetValue_Public_T_AttributeDefinition_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000B058 File Offset: 0x00009258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218721, XrefRangeEnd = 1218725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableAttributes Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr_Clone_Public_SerializableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableAttributes>(intPtr3) : null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000B098 File Offset: 0x00009298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000B0D8 File Offset: 0x000092D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1218730, RefRangeEnd = 1218731, XrefRangeStart = 1218725, XrefRangeEnd = 1218730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<ReadOnlyAttribute> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_ReadOnlyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ReadOnlyAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000B118 File Offset: 0x00009318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218731, XrefRangeEnd = 1218736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<IAttribute> System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000B158 File Offset: 0x00009358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1218730, RefRangeEnd = 1218731, XrefRangeStart = 1218730, XrefRangeEnd = 1218731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000B198 File Offset: 0x00009398
		public unsafe ReadOnlyAttributes AsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218736, XrefRangeEnd = 1218746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr_get_AsReadOnly_Public_get_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000B1D8 File Offset: 0x000093D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1218756, RefRangeEnd = 1218760, XrefRangeStart = 1218746, XrefRangeEnd = 1218756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ReadOnlyAttributes(SerializableAttributes attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttributes_SerializableAttributes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000B21C File Offset: 0x0000941C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1218764, RefRangeEnd = 1218767, XrefRangeStart = 1218760, XrefRangeEnd = 1218764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator MutableAttributes(SerializableAttributes attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr_op_Implicit_Public_Static_MutableAttributes_SerializableAttributes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000B260 File Offset: 0x00009460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1218771, RefRangeEnd = 1218772, XrefRangeStart = 1218767, XrefRangeEnd = 1218771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SerializableAttributes(MutableAttributes attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr_op_Implicit_Public_Static_SerializableAttributes_MutableAttributes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000B2A4 File Offset: 0x000094A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1218776, RefRangeEnd = 1218778, XrefRangeStart = 1218772, XrefRangeEnd = 1218776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SerializableAttributes(ReadOnlyAttributes attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.NativeMethodInfoPtr_op_Implicit_Public_Static_SerializableAttributes_ReadOnlyAttributes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializableAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000B2E8 File Offset: 0x000094E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218778, XrefRangeEnd = 1218811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializableAttributes.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002D23 File Offset: 0x00000F23
		public SerializableAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000B32C File Offset: 0x0000952C
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002D2C File Offset: 0x00000F2C
		public unsafe Dictionary<int, IMutableAttribute> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, IMutableAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0000B35C File Offset: 0x0000955C
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00002D4B File Offset: 0x00000F4B
		public unsafe ReadOnlyAttributes _ReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes.NativeFieldInfoPtr__ReadOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes.NativeFieldInfoPtr__ReadOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr__ReadOnly;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_Int32_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_IAttribute_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializableAttributes_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_set_Private_Void_IAttribute_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_TryGetAttribute_Public_Boolean_AttributeDefinition_1_T_byref_ReadOnlyAttribute_1_T_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_AttributeDefinition_1_T_byref_T_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_T_AttributeDefinition_1_T_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_SerializableAttributes_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_ReadOnlyAttribute_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_get_AsReadOnly_Public_get_ReadOnlyAttributes_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttributes_SerializableAttributes_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_MutableAttributes_SerializableAttributes_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SerializableAttributes_MutableAttributes_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SerializableAttributes_ReadOnlyAttributes_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0200004A RID: 74
		[ObfuscatedName("Canis.attributes.SerializableAttributes+<GetEnumerator>d__11")]
		public sealed class _GetEnumerator_d__11 : Object
		{
			// Token: 0x0600034C RID: 844 RVA: 0x0000F4AC File Offset: 0x0000D6AC
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__11()
			{
				Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, "<GetEnumerator>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr);
				SerializableAttributes._GetEnumerator_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr, "<>1__state");
				SerializableAttributes._GetEnumerator_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr, "<>2__current");
				SerializableAttributes._GetEnumerator_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr, "<>4__this");
				SerializableAttributes._GetEnumerator_d__11.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr, "<>7__wrap1");
				SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr, 100663544);
				SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr, 100663545);
				SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr, 100663546);
				SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr, 100663547);
				SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_ReadOnlyAttribute__get_Current_Private_Virtual_Final_New_get_ReadOnlyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr, 100663548);
				SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr, 100663549);
				SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr, 100663550);
			}

			// Token: 0x0600034D RID: 845 RVA: 0x0000F5B4 File Offset: 0x0000D7B4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableAttributes._GetEnumerator_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600034E RID: 846 RVA: 0x0000F5FC File Offset: 0x0000D7FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218451, XrefRangeEnd = 1218456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600034F RID: 847 RVA: 0x0000F630 File Offset: 0x0000D830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218456, XrefRangeEnd = 1218476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000350 RID: 848 RVA: 0x0000F66C File Offset: 0x0000D86C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218476, XrefRangeEnd = 1218479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000351 RID: 849 RVA: 0x0000F6A0 File Offset: 0x0000D8A0
			public unsafe ReadOnlyAttribute System.Collections.Generic.IEnumerator<Canis.attributes.ReadOnlyAttribute>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_ReadOnlyAttribute__get_Current_Private_Virtual_Final_New_get_ReadOnlyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x06000352 RID: 850 RVA: 0x0000F6E0 File Offset: 0x0000D8E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218479, XrefRangeEnd = 1218484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x06000353 RID: 851 RVA: 0x0000F714 File Offset: 0x0000D914
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes._GetEnumerator_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000354 RID: 852 RVA: 0x0000345E File Offset: 0x0000165E
			public _GetEnumerator_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000355 RID: 853 RVA: 0x0000F754 File Offset: 0x0000D954
			// (set) Token: 0x06000356 RID: 854 RVA: 0x00003467 File Offset: 0x00001667
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes._GetEnumerator_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes._GetEnumerator_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000357 RID: 855 RVA: 0x0000F77C File Offset: 0x0000D97C
			// (set) Token: 0x06000358 RID: 856 RVA: 0x00003482 File Offset: 0x00001682
			public unsafe ReadOnlyAttribute __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes._GetEnumerator_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes._GetEnumerator_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000359 RID: 857 RVA: 0x0000F7AC File Offset: 0x0000D9AC
			// (set) Token: 0x0600035A RID: 858 RVA: 0x000034A1 File Offset: 0x000016A1
			public unsafe SerializableAttributes __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes._GetEnumerator_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes._GetEnumerator_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x0600035B RID: 859 RVA: 0x0000F7DC File Offset: 0x0000D9DC
			// (set) Token: 0x0600035C RID: 860 RVA: 0x000034C0 File Offset: 0x000016C0
			public Dictionary<int, IMutableAttribute>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes._GetEnumerator_d__11.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<int, IMutableAttribute>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<int, IMutableAttribute>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes._GetEnumerator_d__11.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<int, IMutableAttribute>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400021A RID: 538
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400021B RID: 539
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400021C RID: 540
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400021D RID: 541
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400021E RID: 542
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400021F RID: 543
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000220 RID: 544
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000221 RID: 545
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000222 RID: 546
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_ReadOnlyAttribute__get_Current_Private_Virtual_Final_New_get_ReadOnlyAttribute_0;

			// Token: 0x04000223 RID: 547
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000224 RID: 548
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200004B RID: 75
		[ObfuscatedName("Canis.attributes.SerializableAttributes+<System-Collections-Generic-IEnumerable<Canis-attributes-IAttribute>-GetEnumerator>d__12")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique : Object
		{
			// Token: 0x0600035D RID: 861 RVA: 0x0000F80C File Offset: 0x0000DA0C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique()
			{
				Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr, "<System-Collections-Generic-IEnumerable<Canis-attributes-IAttribute>-GetEnumerator>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr);
				SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr, "<>1__state");
				SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr, "<>2__current");
				SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr, "<>4__this");
				SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr, "<>7__wrap1");
				SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr, 100663551);
				SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr, 100663552);
				SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr, 100663553);
				SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr, 100663554);
				SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr, 100663555);
				SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr, 100663556);
				SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr, 100663557);
			}

			// Token: 0x0600035E RID: 862 RVA: 0x0000F914 File Offset: 0x0000DB14
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600035F RID: 863 RVA: 0x0000F95C File Offset: 0x0000DB5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218484, XrefRangeEnd = 1218489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000360 RID: 864 RVA: 0x0000F990 File Offset: 0x0000DB90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218489, XrefRangeEnd = 1218506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000361 RID: 865 RVA: 0x0000F9CC File Offset: 0x0000DBCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218506, XrefRangeEnd = 1218509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000362 RID: 866 RVA: 0x0000FA00 File Offset: 0x0000DC00
			public unsafe IAttribute System.Collections.Generic.IEnumerator<Canis.attributes.IAttribute>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x06000363 RID: 867 RVA: 0x0000FA40 File Offset: 0x0000DC40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218509, XrefRangeEnd = 1218514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x06000364 RID: 868 RVA: 0x0000FA74 File Offset: 0x0000DC74
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000365 RID: 869 RVA: 0x000034EE File Offset: 0x000016EE
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x06000366 RID: 870 RVA: 0x0000FAB4 File Offset: 0x0000DCB4
			// (set) Token: 0x06000367 RID: 871 RVA: 0x000034F7 File Offset: 0x000016F7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x06000368 RID: 872 RVA: 0x0000FADC File Offset: 0x0000DCDC
			// (set) Token: 0x06000369 RID: 873 RVA: 0x00003512 File Offset: 0x00001712
			public unsafe IAttribute __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x0600036A RID: 874 RVA: 0x0000FB0C File Offset: 0x0000DD0C
			// (set) Token: 0x0600036B RID: 875 RVA: 0x00003531 File Offset: 0x00001731
			public unsafe SerializableAttributes __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x0600036C RID: 876 RVA: 0x0000FB3C File Offset: 0x0000DD3C
			// (set) Token: 0x0600036D RID: 877 RVA: 0x00003550 File Offset: 0x00001750
			public Dictionary<int, IMutableAttribute>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<int, IMutableAttribute>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<int, IMutableAttribute>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIASeEn2IMInObIAUnique.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<int, IMutableAttribute>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000225 RID: 549
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000226 RID: 550
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000227 RID: 551
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000228 RID: 552
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000229 RID: 553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400022A RID: 554
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400022B RID: 555
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400022C RID: 556
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400022D RID: 557
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0;

			// Token: 0x0400022E RID: 558
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400022F RID: 559
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200004C RID: 76
		private sealed class MethodInfoStoreGeneric_TryGetAttribute_Public_Boolean_AttributeDefinition_1_T_byref_ReadOnlyAttribute_1_T_0<T>
		{
			// Token: 0x04000230 RID: 560
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializableAttributes.NativeMethodInfoPtr_TryGetAttribute_Public_Boolean_AttributeDefinition_1_T_byref_ReadOnlyAttribute_1_T_0, Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004D RID: 77
		private sealed class MethodInfoStoreGeneric_TryGetValue_Public_Boolean_AttributeDefinition_1_T_byref_T_0<T>
		{
			// Token: 0x04000231 RID: 561
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializableAttributes.NativeMethodInfoPtr_TryGetValue_Public_Boolean_AttributeDefinition_1_T_byref_T_0, Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200004E RID: 78
		private sealed class MethodInfoStoreGeneric_TryGetValue_Public_T_AttributeDefinition_1_T_0<T>
		{
			// Token: 0x04000232 RID: 562
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SerializableAttributes.NativeMethodInfoPtr_TryGetValue_Public_T_AttributeDefinition_1_T_0, Il2CppClassPointerStore<SerializableAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
