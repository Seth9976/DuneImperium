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
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.attributes
{
	// Token: 0x0200001F RID: 31
	[Serializable]
	public sealed class ReadOnlyAttributes : Object
	{
		// Token: 0x06000202 RID: 514 RVA: 0x0000A120 File Offset: 0x00008320
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyAttributes()
		{
			Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "ReadOnlyAttributes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr);
			ReadOnlyAttributes.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, "source");
			ReadOnlyAttributes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663488);
			ReadOnlyAttributes.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663489);
			ReadOnlyAttributes.NativeMethodInfoPtr__ctor_Public_Void_IList_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663490);
			ReadOnlyAttributes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663491);
			ReadOnlyAttributes.NativeMethodInfoPtr__ctor_Public_Void_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663492);
			ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663493);
			ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663494);
			ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663495);
			ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663496);
			ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663497);
			ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663498);
			ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663499);
			ReadOnlyAttributes.NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663500);
			ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663501);
			ReadOnlyAttributes.NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663502);
			ReadOnlyAttributes.NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663503);
			ReadOnlyAttributes.NativeMethodInfoPtr_HasAttribute_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663504);
			ReadOnlyAttributes.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_ReadOnlyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663505);
			ReadOnlyAttributes.NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663506);
			ReadOnlyAttributes.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663507);
			ReadOnlyAttributes.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, 100663508);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000A308 File Offset: 0x00008508
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1218083, RefRangeEnd = 1218108, XrefRangeStart = 1218077, XrefRangeEnd = 1218083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttributes()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000A344 File Offset: 0x00008544
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 1218114, RefRangeEnd = 1218170, XrefRangeStart = 1218108, XrefRangeEnd = 1218114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttributes(IEnumerable<IAttribute> attrs, int capacity = 8)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000A3A0 File Offset: 0x000085A0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1218176, RefRangeEnd = 1218189, XrefRangeStart = 1218170, XrefRangeEnd = 1218176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttributes(IList<IAttribute> attrs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr__ctor_Public_Void_IList_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000A3EC File Offset: 0x000085EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1218195, RefRangeEnd = 1218200, XrefRangeStart = 1218189, XrefRangeEnd = 1218195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttributes([Optional] Il2CppReferenceArray<IAttribute> attrs)
		{
			if (attrs == null)
			{
				attrs = new Il2CppReferenceArray<IAttribute>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000A444 File Offset: 0x00008644
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttributes(MutableAttributes source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr__ctor_Public_Void_MutableAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000A490 File Offset: 0x00008690
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1218209, RefRangeEnd = 1218213, XrefRangeStart = 1218200, XrefRangeEnd = 1218209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute<Nullable<int>> GetAttribute(AttributeDefinition<Nullable<int>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<int>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000A4E0 File Offset: 0x000086E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218213, XrefRangeEnd = 1218222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute<Nullable<float>> GetAttribute(AttributeDefinition<Nullable<float>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<float>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000A530 File Offset: 0x00008730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218222, XrefRangeEnd = 1218231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute<string> GetAttribute(AttributeDefinition<string> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000A580 File Offset: 0x00008780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218231, XrefRangeEnd = 1218240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute<Il2CppStringArray> GetAttribute(AttributeDefinition<Il2CppStringArray> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Il2CppStringArray>>(intPtr3) : null;
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000A5D0 File Offset: 0x000087D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1218249, RefRangeEnd = 1218253, XrefRangeStart = 1218240, XrefRangeEnd = 1218249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute<LocalizableText> GetAttribute(AttributeDefinition<LocalizableText> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<LocalizableText>>(intPtr3) : null;
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000A620 File Offset: 0x00008820
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1218262, RefRangeEnd = 1218266, XrefRangeStart = 1218253, XrefRangeEnd = 1218262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute<Nullable<bool>> GetAttribute(AttributeDefinition<Nullable<bool>> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<Nullable<bool>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000A670 File Offset: 0x00008870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218266, XrefRangeEnd = 1218275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute<V> GetAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.MethodInfoStoreGeneric_GetAttribute_Public_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0<V>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000A6C0 File Offset: 0x000088C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218275, XrefRangeEnd = 1218284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAttribute<V> Canis_attributes_IHasAttributes_GetAttribute<V>(AttributeDefinition<V> definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.MethodInfoStoreGeneric_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<V>>(intPtr3) : null;
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000A710 File Offset: 0x00008910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218284, XrefRangeEnd = 1218289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute GetAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000A75C File Offset: 0x0000895C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1218298, RefRangeEnd = 1218306, XrefRangeStart = 1218289, XrefRangeEnd = 1218298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.MethodInfoStoreGeneric_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000A7F0 File Offset: 0x000089F0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1218314, RefRangeEnd = 1218329, XrefRangeStart = 1218306, XrefRangeEnd = 1218314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.MethodInfoStoreGeneric_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000A884 File Offset: 0x00008A84
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1218331, RefRangeEnd = 1218342, XrefRangeStart = 1218329, XrefRangeEnd = 1218331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr_HasAttribute_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000A8D0 File Offset: 0x00008AD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1218347, RefRangeEnd = 1218348, XrefRangeStart = 1218342, XrefRangeEnd = 1218347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<ReadOnlyAttribute> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_ReadOnlyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ReadOnlyAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000A910 File Offset: 0x00008B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAttribute Canis_attributes_IHasAttributes_GetAttribute(int key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000A95C File Offset: 0x00008B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218348, XrefRangeEnd = 1218353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<IAttribute> System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000A99C File Offset: 0x00008B9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1218347, RefRangeEnd = 1218348, XrefRangeStart = 1218347, XrefRangeEnd = 1218348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002CB3 File Offset: 0x00000EB3
		public ReadOnlyAttributes(params IAttribute[] attrs)
			: this(new Il2CppReferenceArray<IAttribute>(attrs))
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002CC1 File Offset: 0x00000EC1
		public ReadOnlyAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000A9DC File Offset: 0x00008BDC
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00002CCA File Offset: 0x00000ECA
		public unsafe MutableAttributes source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IAttribute_Int32_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_IAttribute_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_IAttribute_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MutableAttributes_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_Nullable_1_Int32_AttributeDefinition_1_Nullable_1_Int32_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_Nullable_1_Single_AttributeDefinition_1_Nullable_1_Single_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_String_AttributeDefinition_1_String_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_Il2CppStringArray_AttributeDefinition_1_Il2CppStringArray_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_LocalizableText_AttributeDefinition_1_LocalizableText_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_Nullable_1_Boolean_AttributeDefinition_1_Nullable_1_Boolean_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_Int32_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_HasAttribute_Public_Boolean_Int32_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_1_ReadOnlyAttribute_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_Int32_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x02000044 RID: 68
		[ObfuscatedName("Canis.attributes.ReadOnlyAttributes+<GetEnumerator>d__18")]
		public sealed class _GetEnumerator_d__18 : Object
		{
			// Token: 0x06000326 RID: 806 RVA: 0x0000EC9C File Offset: 0x0000CE9C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__18()
			{
				Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, "<GetEnumerator>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr);
				ReadOnlyAttributes._GetEnumerator_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr, "<>1__state");
				ReadOnlyAttributes._GetEnumerator_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr, "<>2__current");
				ReadOnlyAttributes._GetEnumerator_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr, "<>4__this");
				ReadOnlyAttributes._GetEnumerator_d__18.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr, "<>7__wrap1");
				ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr, 100663509);
				ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr, 100663510);
				ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr, 100663511);
				ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr, 100663512);
				ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_ReadOnlyAttribute__get_Current_Private_Virtual_Final_New_get_ReadOnlyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr, 100663513);
				ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr, 100663514);
				ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr, 100663515);
			}

			// Token: 0x06000327 RID: 807 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttributes._GetEnumerator_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000328 RID: 808 RVA: 0x0000EDEC File Offset: 0x0000CFEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218003, XrefRangeEnd = 1218008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000329 RID: 809 RVA: 0x0000EE20 File Offset: 0x0000D020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218008, XrefRangeEnd = 1218032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600032A RID: 810 RVA: 0x0000EE5C File Offset: 0x0000D05C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218032, XrefRangeEnd = 1218035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x0600032B RID: 811 RVA: 0x0000EE90 File Offset: 0x0000D090
			public unsafe ReadOnlyAttribute System.Collections.Generic.IEnumerator<Canis.attributes.ReadOnlyAttribute>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_ReadOnlyAttribute__get_Current_Private_Virtual_Final_New_get_ReadOnlyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x0600032C RID: 812 RVA: 0x0000EED0 File Offset: 0x0000D0D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218035, XrefRangeEnd = 1218040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x0600032D RID: 813 RVA: 0x0000EF04 File Offset: 0x0000D104
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes._GetEnumerator_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600032E RID: 814 RVA: 0x0000335C File Offset: 0x0000155C
			public _GetEnumerator_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x0600032F RID: 815 RVA: 0x0000EF44 File Offset: 0x0000D144
			// (set) Token: 0x06000330 RID: 816 RVA: 0x00003365 File Offset: 0x00001565
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes._GetEnumerator_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes._GetEnumerator_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x06000331 RID: 817 RVA: 0x0000EF6C File Offset: 0x0000D16C
			// (set) Token: 0x06000332 RID: 818 RVA: 0x00003380 File Offset: 0x00001580
			public unsafe ReadOnlyAttribute __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes._GetEnumerator_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes._GetEnumerator_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000333 RID: 819 RVA: 0x0000EF9C File Offset: 0x0000D19C
			// (set) Token: 0x06000334 RID: 820 RVA: 0x0000339F File Offset: 0x0000159F
			public unsafe ReadOnlyAttributes __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes._GetEnumerator_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes._GetEnumerator_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000335 RID: 821 RVA: 0x0000EFCC File Offset: 0x0000D1CC
			// (set) Token: 0x06000336 RID: 822 RVA: 0x000033BE File Offset: 0x000015BE
			public unsafe IEnumerator<IAttribute> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes._GetEnumerator_d__18.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes._GetEnumerator_d__18.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000200 RID: 512
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000201 RID: 513
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000202 RID: 514
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000203 RID: 515
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000204 RID: 516
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000205 RID: 517
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000206 RID: 518
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000207 RID: 519
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000208 RID: 520
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_ReadOnlyAttribute__get_Current_Private_Virtual_Final_New_get_ReadOnlyAttribute_0;

			// Token: 0x04000209 RID: 521
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400020A RID: 522
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000045 RID: 69
		[ObfuscatedName("Canis.attributes.ReadOnlyAttributes+<System-Collections-Generic-IEnumerable<Canis-attributes-IAttribute>-GetEnumerator>d__20")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique : Object
		{
			// Token: 0x06000337 RID: 823 RVA: 0x0000EFFC File Offset: 0x0000D1FC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique()
			{
				Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr, "<System-Collections-Generic-IEnumerable<Canis-attributes-IAttribute>-GetEnumerator>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr);
				ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr, "<>1__state");
				ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr, "<>2__current");
				ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr, "<>4__this");
				ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr, "<>7__wrap1");
				ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr, 100663516);
				ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr, 100663517);
				ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr, 100663518);
				ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr, 100663519);
				ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr, 100663520);
				ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr, 100663521);
				ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr, 100663522);
			}

			// Token: 0x06000338 RID: 824 RVA: 0x0000F104 File Offset: 0x0000D304
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000339 RID: 825 RVA: 0x0000F14C File Offset: 0x0000D34C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218040, XrefRangeEnd = 1218045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600033A RID: 826 RVA: 0x0000F180 File Offset: 0x0000D380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218045, XrefRangeEnd = 1218069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600033B RID: 827 RVA: 0x0000F1BC File Offset: 0x0000D3BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218069, XrefRangeEnd = 1218072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x0600033C RID: 828 RVA: 0x0000F1F0 File Offset: 0x0000D3F0
			public unsafe IAttribute System.Collections.Generic.IEnumerator<Canis.attributes.IAttribute>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x0600033D RID: 829 RVA: 0x0000F230 File Offset: 0x0000D430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218072, XrefRangeEnd = 1218077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x0600033E RID: 830 RVA: 0x0000F264 File Offset: 0x0000D464
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600033F RID: 831 RVA: 0x000033DD File Offset: 0x000015DD
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000340 RID: 832 RVA: 0x0000F2A4 File Offset: 0x0000D4A4
			// (set) Token: 0x06000341 RID: 833 RVA: 0x000033E6 File Offset: 0x000015E6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000342 RID: 834 RVA: 0x0000F2CC File Offset: 0x0000D4CC
			// (set) Token: 0x06000343 RID: 835 RVA: 0x00003401 File Offset: 0x00001601
			public unsafe IAttribute __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000344 RID: 836 RVA: 0x0000F2FC File Offset: 0x0000D4FC
			// (set) Token: 0x06000345 RID: 837 RVA: 0x00003420 File Offset: 0x00001620
			public unsafe ReadOnlyAttributes __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000346 RID: 838 RVA: 0x0000F32C File Offset: 0x0000D52C
			// (set) Token: 0x06000347 RID: 839 RVA: 0x0000343F File Offset: 0x0000163F
			public unsafe IEnumerator<IAttribute> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttributes.ObjectCompilerGeneratedNPrivateSealedIEnumerator1IAttributeIEnumeratorIDisposableInIAReIE1ObIAIAUnique.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400020B RID: 523
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400020C RID: 524
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400020D RID: 525
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400020E RID: 526
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400020F RID: 527
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000210 RID: 528
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000211 RID: 529
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000212 RID: 530
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000213 RID: 531
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0;

			// Token: 0x04000214 RID: 532
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000215 RID: 533
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000046 RID: 70
		private sealed class MethodInfoStoreGeneric_GetAttribute_Public_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x04000216 RID: 534
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReadOnlyAttributes.NativeMethodInfoPtr_GetAttribute_Public_ReadOnlyAttribute_1_V_AttributeDefinition_1_V_0, Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}

		// Token: 0x02000047 RID: 71
		private sealed class MethodInfoStoreGeneric_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0<V>
		{
			// Token: 0x04000217 RID: 535
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReadOnlyAttributes.NativeMethodInfoPtr_Canis_attributes_IHasAttributes_GetAttribute_Private_Virtual_Final_New_IAttribute_1_V_AttributeDefinition_1_V_0, Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr)) }))));
		}

		// Token: 0x02000048 RID: 72
		private sealed class MethodInfoStoreGeneric_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0<T>
		{
			// Token: 0x04000218 RID: 536
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReadOnlyAttributes.NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_T_T_0, Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000049 RID: 73
		private sealed class MethodInfoStoreGeneric_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0<T>
		{
			// Token: 0x04000219 RID: 537
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReadOnlyAttributes.NativeMethodInfoPtr_GetAttributeValue_Public_T_AttributeDefinition_1_Nullable_1_T_T_0, Il2CppClassPointerStore<ReadOnlyAttributes>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
