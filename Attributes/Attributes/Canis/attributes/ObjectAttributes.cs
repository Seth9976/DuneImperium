using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.attributes
{
	// Token: 0x0200001C RID: 28
	[Serializable]
	public class ObjectAttributes : Object
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x00009168 File Offset: 0x00007368
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectAttributes()
		{
			Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "ObjectAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr);
			ObjectAttributes.NativeFieldInfoPtr_parentAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, "parentAttributes");
			ObjectAttributes.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, "attributes");
			ObjectAttributes.NativeFieldInfoPtr_actualAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, "actualAttributes");
			ObjectAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663453);
			ObjectAttributes.NativeMethodInfoPtr__ctor_Public_Void_ObjectAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663454);
			ObjectAttributes.NativeMethodInfoPtr__ctor_Public_Void_SerializableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663455);
			ObjectAttributes.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663456);
			ObjectAttributes.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663457);
			ObjectAttributes.NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663458);
			ObjectAttributes.NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663459);
			ObjectAttributes.NativeMethodInfoPtr_HasParent_Public_Void_ObjectAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663460);
			ObjectAttributes.NativeMethodInfoPtr_Has_Public_ObjectAttributes_AttributeDefinition_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663461);
			ObjectAttributes.NativeMethodInfoPtr_SetAttribute_Public_Void_AttributeDefinition_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663462);
			ObjectAttributes.NativeMethodInfoPtr_RemoveAttribute_Public_Void_AttributeDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663463);
			ObjectAttributes.NativeMethodInfoPtr_ChangeParentAttributes_Public_Void_ObjectAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663464);
			ObjectAttributes.NativeMethodInfoPtr_HasAttribute_Public_Boolean_AttributeDefinition_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663465);
			ObjectAttributes.NativeMethodInfoPtr_SerializeAttributes_Public_Virtual_New_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663466);
			ObjectAttributes.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663467);
			ObjectAttributes.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr, 100663468);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00009314 File Offset: 0x00007514
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1217032, RefRangeEnd = 1217038, XrefRangeStart = 1217018, XrefRangeEnd = 1217032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00009350 File Offset: 0x00007550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1217052, RefRangeEnd = 1217053, XrefRangeStart = 1217038, XrefRangeEnd = 1217052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectAttributes(ObjectAttributes parentAttributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.NativeMethodInfoPtr__ctor_Public_Void_ObjectAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000939C File Offset: 0x0000759C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1217089, RefRangeEnd = 1217094, XrefRangeStart = 1217053, XrefRangeEnd = 1217089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectAttributes(SerializableAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.NativeMethodInfoPtr__ctor_Public_Void_SerializableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000093E8 File Offset: 0x000075E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1217100, RefRangeEnd = 1217104, XrefRangeStart = 1217094, XrefRangeEnd = 1217100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAttribute GetAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00009434 File Offset: 0x00007634
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1217123, RefRangeEnd = 1217130, XrefRangeStart = 1217104, XrefRangeEnd = 1217123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAttribute<V> GetAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.MethodInfoStoreGeneric_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00009484 File Offset: 0x00007684
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1217135, RefRangeEnd = 1217137, XrefRangeStart = 1217130, XrefRangeEnd = 1217135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetAttributeValue<T>(AttributeDefinition<T> definition, T defaultValue)
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
			if (!typeof(T).IsValueType)
			{
				T t = defaultValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.MethodInfoStoreGeneric_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00009518 File Offset: 0x00007718
		[CallerCount(161)]
		[CachedScanResults(RefRangeStart = 1217142, RefRangeEnd = 1217303, XrefRangeStart = 1217137, XrefRangeEnd = 1217142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetAttributeValue<T>(AttributeDefinition<Nullable<T>> definition, T defaultValue) where T : new()
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
			if (!typeof(T).IsValueType)
			{
				T t = defaultValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.MethodInfoStoreGeneric_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000095AC File Offset: 0x000077AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HasParent(ObjectAttributes parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.NativeMethodInfoPtr_HasParent_Public_Void_ObjectAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000095F0 File Offset: 0x000077F0
		[CallerCount(118)]
		[CachedScanResults(RefRangeStart = 1217309, RefRangeEnd = 1217427, XrefRangeStart = 1217303, XrefRangeEnd = 1217309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectAttributes Has<T>(AttributeDefinition<T> attribute, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.MethodInfoStoreGeneric_Has_Public_ObjectAttributes_AttributeDefinition_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<ObjectAttributes>(intPtr4) : null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00009688 File Offset: 0x00007888
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1217450, RefRangeEnd = 1217461, XrefRangeStart = 1217427, XrefRangeEnd = 1217450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttribute<T>(AttributeDefinition<T> attribute, T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.MethodInfoStoreGeneric_SetAttribute_Public_Void_AttributeDefinition_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00009714 File Offset: 0x00007914
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1217473, RefRangeEnd = 1217481, XrefRangeStart = 1217461, XrefRangeEnd = 1217473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAttribute<T>(AttributeDefinition<T> attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.MethodInfoStoreGeneric_RemoveAttribute_Public_Void_AttributeDefinition_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00009758 File Offset: 0x00007958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeParentAttributes(ObjectAttributes parentAttributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentAttributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.NativeMethodInfoPtr_ChangeParentAttributes_Public_Void_ObjectAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000979C File Offset: 0x0000799C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1217489, RefRangeEnd = 1217512, XrefRangeStart = 1217481, XrefRangeEnd = 1217489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasAttribute<T>(AttributeDefinition<T> attribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.MethodInfoStoreGeneric_HasAttribute_Public_Boolean_AttributeDefinition_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000097EC File Offset: 0x000079EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1217533, RefRangeEnd = 1217534, XrefRangeStart = 1217512, XrefRangeEnd = 1217533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MutableAttributes SerializeAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectAttributes.NativeMethodInfoPtr_SerializeAttributes_Public_Virtual_New_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr3) : null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00009838 File Offset: 0x00007A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217534, XrefRangeEnd = 1217539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<IAttribute> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00009878 File Offset: 0x00007A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectAttributes.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002C1C File Offset: 0x00000E1C
		public ObjectAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000098B8 File Offset: 0x00007AB8
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00002C25 File Offset: 0x00000E25
		public unsafe ObjectAttributes parentAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectAttributes.NativeFieldInfoPtr_parentAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectAttributes.NativeFieldInfoPtr_parentAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000098E8 File Offset: 0x00007AE8
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00002C44 File Offset: 0x00000E44
		public unsafe MutableAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectAttributes.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectAttributes.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00009918 File Offset: 0x00007B18
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00002C63 File Offset: 0x00000E63
		public unsafe HashSet<int> actualAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectAttributes.NativeFieldInfoPtr_actualAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectAttributes.NativeFieldInfoPtr_actualAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeFieldInfoPtr_parentAttributes;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeFieldInfoPtr_actualAttributes;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectAttributes_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializableAttributes_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_Int32_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_HasParent_Public_Void_ObjectAttributes_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_ObjectAttributes_AttributeDefinition_1_T_T_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_SetAttribute_Public_Void_AttributeDefinition_1_T_T_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAttribute_Public_Void_AttributeDefinition_1_T_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_ChangeParentAttributes_Public_Void_ObjectAttributes_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_HasAttribute_Public_Boolean_AttributeDefinition_1_T_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_SerializeAttributes_Public_Virtual_New_MutableAttributes_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IAttribute_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0200003D RID: 61
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x040001F9 RID: 505
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ObjectAttributes.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0, Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003E RID: 62
		private sealed class MethodInfoStoreGeneric_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0<T>
		{
			// Token: 0x040001FA RID: 506
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ObjectAttributes.NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0, Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003F RID: 63
		private sealed class MethodInfoStoreGeneric_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0<T>
		{
			// Token: 0x040001FB RID: 507
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ObjectAttributes.NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0, Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000040 RID: 64
		private sealed class MethodInfoStoreGeneric_Has_Public_ObjectAttributes_AttributeDefinition_1_T_T_0<T>
		{
			// Token: 0x040001FC RID: 508
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ObjectAttributes.NativeMethodInfoPtr_Has_Public_ObjectAttributes_AttributeDefinition_1_T_T_0, Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000041 RID: 65
		private sealed class MethodInfoStoreGeneric_SetAttribute_Public_Void_AttributeDefinition_1_T_T_0<T>
		{
			// Token: 0x040001FD RID: 509
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ObjectAttributes.NativeMethodInfoPtr_SetAttribute_Public_Void_AttributeDefinition_1_T_T_0, Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000042 RID: 66
		private sealed class MethodInfoStoreGeneric_RemoveAttribute_Public_Void_AttributeDefinition_1_T_0<T>
		{
			// Token: 0x040001FE RID: 510
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ObjectAttributes.NativeMethodInfoPtr_RemoveAttribute_Public_Void_AttributeDefinition_1_T_0, Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000043 RID: 67
		private sealed class MethodInfoStoreGeneric_HasAttribute_Public_Boolean_AttributeDefinition_1_T_0<T>
		{
			// Token: 0x040001FF RID: 511
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ObjectAttributes.NativeMethodInfoPtr_HasAttribute_Public_Boolean_AttributeDefinition_1_T_0, Il2CppClassPointerStore<ObjectAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
