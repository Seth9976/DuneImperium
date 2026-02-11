using System;
using System.Runtime.InteropServices;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.attributes
{
	// Token: 0x0200001A RID: 26
	[Serializable]
	public class MutableAttributes : Object
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x000081D0 File Offset: 0x000063D0
		// Note: this type is marked as 'beforefieldinit'.
		static MutableAttributes()
		{
			Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "MutableAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr);
			MutableAttributes.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, "_data");
			MutableAttributes.NativeFieldInfoPtr__ReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, "_ReadOnly");
			MutableAttributes.NativeMethodInfoPtr_get_data_Protected_get_ConcurrentDictionary_2_Int32_IMutableAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663403);
			MutableAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663404);
			MutableAttributes.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663405);
			MutableAttributes.NativeMethodInfoPtr__ctor_Public_Void_List_1_IMutableAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663406);
			MutableAttributes.NativeMethodInfoPtr__ctor_Public_Void_IList_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663407);
			MutableAttributes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663408);
			MutableAttributes.NativeMethodInfoPtr__ctor_Public_Void_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663409);
			MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663410);
			MutableAttributes.NativeMethodInfoPtr_HasAttribute_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663411);
			MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663412);
			MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663413);
			MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_String_AttributeDefinition_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663414);
			MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663415);
			MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663416);
			MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663417);
			MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_V_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663418);
			MutableAttributes.NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663419);
			MutableAttributes.NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663420);
			MutableAttributes.NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663421);
			MutableAttributes.NativeMethodInfoPtr_SetAttribute_Public_Void_IAttribute_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663422);
			MutableAttributes.NativeMethodInfoPtr_SetAttribute_Public_Void_AttributeDefinition_1_V_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663423);
			MutableAttributes.NativeMethodInfoPtr_SetAttribute_Public_Virtual_New_Void_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663424);
			MutableAttributes.NativeMethodInfoPtr_ClearAttribute_Public_Void_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663425);
			MutableAttributes.NativeMethodInfoPtr_ClearAttribute_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663426);
			MutableAttributes.NativeMethodInfoPtr_RemoveAttribute_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663427);
			MutableAttributes.NativeMethodInfoPtr_ReplaceWith_Public_Void_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663428);
			MutableAttributes.NativeMethodInfoPtr_UpdateWith_Public_Void_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663429);
			MutableAttributes.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663430);
			MutableAttributes.NativeMethodInfoPtr_get_AsReadOnly_Public_get_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663431);
			MutableAttributes.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663432);
			MutableAttributes.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663433);
			MutableAttributes.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttributes_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663434);
			MutableAttributes.NativeMethodInfoPtr_Clone_Public_Virtual_New_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663435);
			MutableAttributes.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, 100663436);
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000084D0 File Offset: 0x000066D0
		public unsafe ConcurrentDictionary<int, IMutableAttribute> data
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1216174, RefRangeEnd = 1216182, XrefRangeStart = 1216170, XrefRangeEnd = 1216174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_get_data_Protected_get_ConcurrentDictionary_2_Int32_IMutableAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<int, IMutableAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00008510 File Offset: 0x00006710
		[CallerCount(116)]
		[CachedScanResults(RefRangeStart = 1216190, RefRangeEnd = 1216306, XrefRangeStart = 1216182, XrefRangeEnd = 1216190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000854C File Offset: 0x0000674C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1216340, RefRangeEnd = 1216353, XrefRangeStart = 1216306, XrefRangeEnd = 1216340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttributes(IEnumerable<IAttribute> attributes, int capacity = 8)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000085A8 File Offset: 0x000067A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216353, XrefRangeEnd = 1216385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttributes(List<IMutableAttribute> attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr__ctor_Public_Void_List_1_IMutableAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000085F4 File Offset: 0x000067F4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1216411, RefRangeEnd = 1216417, XrefRangeStart = 1216385, XrefRangeEnd = 1216411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttributes(IList<IAttribute> attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr__ctor_Public_Void_IList_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00008640 File Offset: 0x00006840
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1216418, RefRangeEnd = 1216441, XrefRangeStart = 1216417, XrefRangeEnd = 1216418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttributes([Optional] Il2CppReferenceArray<IAttribute> attributes)
		{
			if (attributes == null)
			{
				attributes = new Il2CppReferenceArray<IAttribute>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00008698 File Offset: 0x00006898
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1216477, RefRangeEnd = 1216483, XrefRangeStart = 1216441, XrefRangeEnd = 1216477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttributes(MutableAttributes other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr__ctor_Public_Void_MutableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000086E4 File Offset: 0x000068E4
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1216512, RefRangeEnd = 1216537, XrefRangeStart = 1216483, XrefRangeEnd = 1216512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAttribute GetAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00008730 File Offset: 0x00006930
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1216544, RefRangeEnd = 1216550, XrefRangeStart = 1216537, XrefRangeEnd = 1216544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_HasAttribute_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000877C File Offset: 0x0000697C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1216554, RefRangeEnd = 1216563, XrefRangeStart = 1216550, XrefRangeEnd = 1216554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttribute<Nullable<int>> GetAttribute(AttributeDefinition<Nullable<int>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttribute<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000087CC File Offset: 0x000069CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1216567, RefRangeEnd = 1216571, XrefRangeStart = 1216563, XrefRangeEnd = 1216567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttribute<Nullable<float>> GetAttribute(AttributeDefinition<Nullable<float>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttribute<Nullable<float>>>(intPtr3) : null;
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000881C File Offset: 0x00006A1C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1216575, RefRangeEnd = 1216590, XrefRangeStart = 1216571, XrefRangeEnd = 1216575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttribute<string> GetAttribute(AttributeDefinition<string> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_String_AttributeDefinition_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttribute<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000886C File Offset: 0x00006A6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1216594, RefRangeEnd = 1216598, XrefRangeStart = 1216590, XrefRangeEnd = 1216594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttribute<Il2CppStringArray> GetAttribute(AttributeDefinition<Il2CppStringArray> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttribute<Il2CppStringArray>>(intPtr3) : null;
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000088BC File Offset: 0x00006ABC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1216602, RefRangeEnd = 1216610, XrefRangeStart = 1216598, XrefRangeEnd = 1216602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttribute<LocalizableText> GetAttribute(AttributeDefinition<LocalizableText> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttribute<LocalizableText>>(intPtr3) : null;
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000890C File Offset: 0x00006B0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1216614, RefRangeEnd = 1216619, XrefRangeStart = 1216610, XrefRangeEnd = 1216614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttribute<Nullable<bool>> GetAttribute(AttributeDefinition<Nullable<bool>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttribute<Nullable<bool>>>(intPtr3) : null;
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000895C File Offset: 0x00006B5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1216630, RefRangeEnd = 1216633, XrefRangeStart = 1216619, XrefRangeEnd = 1216630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttribute<V> GetAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.MethodInfoStoreGeneric_GetAttribute_Public_MutableAttribute_1_V_AttributeDefinition_1_V_0<V>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000089AC File Offset: 0x00006BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216633, XrefRangeEnd = 1216637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAttribute<V> Canis_attributes_IHasAttributes_GetAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.MethodInfoStoreGeneric_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000089FC File Offset: 0x00006BFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1216640, RefRangeEnd = 1216642, XrefRangeStart = 1216637, XrefRangeEnd = 1216640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetAttributeValue<T>(AttributeDefinition<T> definition, T defaultValue) where T : class
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.MethodInfoStoreGeneric_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00008A90 File Offset: 0x00006C90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1216645, RefRangeEnd = 1216647, XrefRangeStart = 1216642, XrefRangeEnd = 1216645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.MethodInfoStoreGeneric_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00008B24 File Offset: 0x00006D24
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 1216665, RefRangeEnd = 1216713, XrefRangeStart = 1216647, XrefRangeEnd = 1216665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttribute<V>(IAttribute<V> attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.MethodInfoStoreGeneric_SetAttribute_Public_Void_IAttribute_1_V_0<V>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00008B68 File Offset: 0x00006D68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1216726, RefRangeEnd = 1216729, XrefRangeStart = 1216713, XrefRangeEnd = 1216726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttribute<V>(AttributeDefinition<V> attrDef, V value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrDef);
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.MethodInfoStoreGeneric_SetAttribute_Public_Void_AttributeDefinition_1_V_V_0<V>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00008BF4 File Offset: 0x00006DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216729, XrefRangeEnd = 1216738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetAttribute(IAttribute attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MutableAttributes.NativeMethodInfoPtr_SetAttribute_Public_Virtual_New_Void_IAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00008C44 File Offset: 0x00006E44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1216750, RefRangeEnd = 1216752, XrefRangeStart = 1216738, XrefRangeEnd = 1216750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAttribute(IAttributeDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_ClearAttribute_Public_Void_IAttributeDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00008C88 File Offset: 0x00006E88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1216761, RefRangeEnd = 1216764, XrefRangeStart = 1216752, XrefRangeEnd = 1216761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAttribute(int attributeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attributeName;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_ClearAttribute_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00008CC8 File Offset: 0x00006EC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1216770, RefRangeEnd = 1216773, XrefRangeStart = 1216764, XrefRangeEnd = 1216770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAttribute(int attributename)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref attributename;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_RemoveAttribute_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00008D08 File Offset: 0x00006F08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1216774, RefRangeEnd = 1216776, XrefRangeStart = 1216773, XrefRangeEnd = 1216774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceWith(IEnumerable<IAttribute> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_ReplaceWith_Public_Void_IEnumerable_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00008D4C File Offset: 0x00006F4C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1216800, RefRangeEnd = 1216810, XrefRangeStart = 1216776, XrefRangeEnd = 1216800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWith(IEnumerable<IAttribute> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_UpdateWith_Public_Void_IEnumerable_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00008D90 File Offset: 0x00006F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216810, XrefRangeEnd = 1216835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MutableAttributes.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00008DCC File Offset: 0x00006FCC
		public unsafe ReadOnlyAttributes AsReadOnly
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1216841, RefRangeEnd = 1216857, XrefRangeStart = 1216835, XrefRangeEnd = 1216841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_get_AsReadOnly_Public_get_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00008E0C File Offset: 0x0000700C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1216862, RefRangeEnd = 1216867, XrefRangeStart = 1216857, XrefRangeEnd = 1216862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<IAttribute> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00008E4C File Offset: 0x0000704C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216867, XrefRangeEnd = 1216872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00008E8C File Offset: 0x0000708C
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 1216878, RefRangeEnd = 1216921, XrefRangeStart = 1216872, XrefRangeEnd = 1216878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ReadOnlyAttributes(MutableAttributes attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttributes_MutableAttributes_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00008ED0 File Offset: 0x000070D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216921, XrefRangeEnd = 1216925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MutableAttributes Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MutableAttributes.NativeMethodInfoPtr_Clone_Public_Virtual_New_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr3) : null;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00008F1C File Offset: 0x0000711C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1007052, RefRangeEnd = 1007057, XrefRangeStart = 1007052, XrefRangeEnd = 1007057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002B8D File Offset: 0x00000D8D
		public MutableAttributes(params IAttribute[] attributes)
			: this(new Il2CppReferenceArray<IAttribute>(attributes))
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002B9B File Offset: 0x00000D9B
		public MutableAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00008F5C File Offset: 0x0000715C
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002BA4 File Offset: 0x00000DA4
		public unsafe Lazy<ConcurrentDictionary<int, IMutableAttribute>> _data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes.NativeFieldInfoPtr__data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lazy<ConcurrentDictionary<int, IMutableAttribute>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00008F8C File Offset: 0x0000718C
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002BC3 File Offset: 0x00000DC3
		public unsafe ReadOnlyAttributes _ReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes.NativeFieldInfoPtr__ReadOnly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes.NativeFieldInfoPtr__ReadOnly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr__data;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr__ReadOnly;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_get_data_Protected_get_ConcurrentDictionary_2_Int32_IMutableAttribute_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_Int32_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_IMutableAttribute_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_IAttribute_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IAttribute_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MutableAttributes_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_Virtual_Final_New_IAttribute_Int32_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_HasAttribute_Public_Boolean_Int32_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_String_AttributeDefinition_1_String_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_V_AttributeDefinition_1_V_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_SetAttribute_Public_Void_IAttribute_1_V_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_SetAttribute_Public_Void_AttributeDefinition_1_V_V_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_SetAttribute_Public_Virtual_New_Void_IAttribute_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_ClearAttribute_Public_Void_IAttributeDefinition_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_ClearAttribute_Public_Void_Int32_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAttribute_Public_Void_Int32_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceWith_Public_Void_IEnumerable_1_IAttribute_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWith_Public_Void_IEnumerable_1_IAttribute_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_get_AsReadOnly_Public_get_ReadOnlyAttributes_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_IAttribute_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ReadOnlyAttributes_MutableAttributes_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_MutableAttributes_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x02000035 RID: 53
		[ObfuscatedName("Canis.attributes.MutableAttributes+<GetEnumerator>d__33")]
		public sealed class _GetEnumerator_d__33 : Object
		{
			// Token: 0x060002F7 RID: 759 RVA: 0x0000E198 File Offset: 0x0000C398
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__33()
			{
				Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, "<GetEnumerator>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr);
				MutableAttributes._GetEnumerator_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr, "<>1__state");
				MutableAttributes._GetEnumerator_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr, "<>2__current");
				MutableAttributes._GetEnumerator_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr, "<>4__this");
				MutableAttributes._GetEnumerator_d__33.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr, "<>7__wrap1");
				MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr, 100663437);
				MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr, 100663438);
				MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr, 100663439);
				MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr, 100663440);
				MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr, 100663441);
				MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr, 100663442);
				MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr, 100663443);
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x0000E2A0 File Offset: 0x0000C4A0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__33(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableAttributes._GetEnumerator_d__33>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x0000E2E8 File Offset: 0x0000C4E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216098, XrefRangeEnd = 1216103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002FA RID: 762 RVA: 0x0000E31C File Offset: 0x0000C51C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216103, XrefRangeEnd = 1216126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002FB RID: 763 RVA: 0x0000E358 File Offset: 0x0000C558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216126, XrefRangeEnd = 1216129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x060002FC RID: 764 RVA: 0x0000E38C File Offset: 0x0000C58C
			public unsafe IAttribute System.Collections.Generic.IEnumerator<Canis.attributes.IAttribute>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x060002FD RID: 765 RVA: 0x0000E3CC File Offset: 0x0000C5CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216129, XrefRangeEnd = 1216134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x060002FE RID: 766 RVA: 0x0000E400 File Offset: 0x0000C600
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes._GetEnumerator_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002FF RID: 767 RVA: 0x0000325A File Offset: 0x0000145A
			public _GetEnumerator_d__33(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x06000300 RID: 768 RVA: 0x0000E440 File Offset: 0x0000C640
			// (set) Token: 0x06000301 RID: 769 RVA: 0x00003263 File Offset: 0x00001463
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes._GetEnumerator_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes._GetEnumerator_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000302 RID: 770 RVA: 0x0000E468 File Offset: 0x0000C668
			// (set) Token: 0x06000303 RID: 771 RVA: 0x0000327E File Offset: 0x0000147E
			public unsafe IAttribute __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes._GetEnumerator_d__33.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes._GetEnumerator_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000304 RID: 772 RVA: 0x0000E498 File Offset: 0x0000C698
			// (set) Token: 0x06000305 RID: 773 RVA: 0x0000329D File Offset: 0x0000149D
			public unsafe MutableAttributes __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes._GetEnumerator_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes._GetEnumerator_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000306 RID: 774 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
			// (set) Token: 0x06000307 RID: 775 RVA: 0x000032BC File Offset: 0x000014BC
			public unsafe IEnumerator<KeyValuePair<int, IMutableAttribute>> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes._GetEnumerator_d__33.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<int, IMutableAttribute>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes._GetEnumerator_d__33.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001DD RID: 477
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001DE RID: 478
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001DF RID: 479
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001E0 RID: 480
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040001E1 RID: 481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001E2 RID: 482
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001E3 RID: 483
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001E4 RID: 484
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040001E5 RID: 485
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0;

			// Token: 0x040001E6 RID: 486
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001E7 RID: 487
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000036 RID: 54
		[ObfuscatedName("Canis.attributes.MutableAttributes+<System-Collections-IEnumerable-GetEnumerator>d__34")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique : Object
		{
			// Token: 0x06000308 RID: 776 RVA: 0x0000E4F8 File Offset: 0x0000C6F8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique()
			{
				Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr, "<System-Collections-IEnumerable-GetEnumerator>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr);
				MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr, "<>1__state");
				MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr, "<>2__current");
				MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr, "<>4__this");
				MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr, "<>7__wrap1");
				MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr, 100663444);
				MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr, 100663445);
				MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr, 100663446);
				MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr, 100663447);
				MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr, 100663448);
				MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr, 100663449);
				MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr, 100663450);
			}

			// Token: 0x06000309 RID: 777 RVA: 0x0000E600 File Offset: 0x0000C800
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600030A RID: 778 RVA: 0x0000E648 File Offset: 0x0000C848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216134, XrefRangeEnd = 1216139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600030B RID: 779 RVA: 0x0000E67C File Offset: 0x0000C87C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216139, XrefRangeEnd = 1216162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600030C RID: 780 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216162, XrefRangeEnd = 1216165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x0600030D RID: 781 RVA: 0x0000E6EC File Offset: 0x0000C8EC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600030E RID: 782 RVA: 0x0000E72C File Offset: 0x0000C92C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216165, XrefRangeEnd = 1216170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x0600030F RID: 783 RVA: 0x0000E760 File Offset: 0x0000C960
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000310 RID: 784 RVA: 0x000032DB File Offset: 0x000014DB
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000311 RID: 785 RVA: 0x0000E7A0 File Offset: 0x0000C9A0
			// (set) Token: 0x06000312 RID: 786 RVA: 0x000032E4 File Offset: 0x000014E4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000313 RID: 787 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
			// (set) Token: 0x06000314 RID: 788 RVA: 0x000032FF File Offset: 0x000014FF
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000315 RID: 789 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
			// (set) Token: 0x06000316 RID: 790 RVA: 0x0000331E File Offset: 0x0000151E
			public unsafe MutableAttributes __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000317 RID: 791 RVA: 0x0000E828 File Offset: 0x0000CA28
			// (set) Token: 0x06000318 RID: 792 RVA: 0x0000333D File Offset: 0x0000153D
			public unsafe IEnumerator<KeyValuePair<int, IMutableAttribute>> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<int, IMutableAttribute>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MutableAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMuIE1Ke2IMInObUnique.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001E8 RID: 488
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040001E9 RID: 489
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040001EA RID: 490
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040001EB RID: 491
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040001EC RID: 492
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040001ED RID: 493
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001EE RID: 494
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040001EF RID: 495
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040001F0 RID: 496
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040001F1 RID: 497
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040001F2 RID: 498
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000037 RID: 55
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_MutableAttribute_1_V_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x040001F3 RID: 499
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MutableAttributes.NativeMethodInfoPtr_GetAttribute_Public_MutableAttribute_1_V_AttributeDefinition_1_V_0, Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}

		// Token: 0x02000038 RID: 56
		private sealed class MethodInfoStoreGeneric_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x040001F4 RID: 500
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MutableAttributes.NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0, Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}

		// Token: 0x02000039 RID: 57
		private sealed class MethodInfoStoreGeneric_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0<T>
		{
			// Token: 0x040001F5 RID: 501
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MutableAttributes.NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0, Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003A RID: 58
		private sealed class MethodInfoStoreGeneric_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0<T>
		{
			// Token: 0x040001F6 RID: 502
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MutableAttributes.NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0, Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003B RID: 59
		private sealed class MethodInfoStoreGeneric_SetAttribute_Public_Void_IAttribute_1_V_0<V>
		{
			// Token: 0x040001F7 RID: 503
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MutableAttributes.NativeMethodInfoPtr_SetAttribute_Public_Void_IAttribute_1_V_0, Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}

		// Token: 0x0200003C RID: 60
		private sealed class MethodInfoStoreGeneric_SetAttribute_Public_Void_AttributeDefinition_1_V_V_0<V>
		{
			// Token: 0x040001F8 RID: 504
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MutableAttributes.NativeMethodInfoPtr_SetAttribute_Public_Void_AttributeDefinition_1_V_V_0, Il2CppClassPointerStore<MutableAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}
	}
}
