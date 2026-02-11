using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000087 RID: 135
	public class JsonContract : Object
	{
		// Token: 0x06000ACD RID: 2765 RVA: 0x00043D44 File Offset: 0x00041F44
		// Note: this type is marked as 'beforefieldinit'.
		static JsonContract()
		{
			Il2CppClassPointerStore<JsonContract>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonContract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonContract>.NativeClassPtr);
			JsonContract.NativeFieldInfoPtr_IsNullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "IsNullable");
			JsonContract.NativeFieldInfoPtr_IsConvertable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "IsConvertable");
			JsonContract.NativeFieldInfoPtr_IsEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "IsEnum");
			JsonContract.NativeFieldInfoPtr_NonNullableUnderlyingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "NonNullableUnderlyingType");
			JsonContract.NativeFieldInfoPtr_InternalReadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "InternalReadType");
			JsonContract.NativeFieldInfoPtr_ContractType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "ContractType");
			JsonContract.NativeFieldInfoPtr_IsReadOnlyOrFixedSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "IsReadOnlyOrFixedSize");
			JsonContract.NativeFieldInfoPtr_IsSealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "IsSealed");
			JsonContract.NativeFieldInfoPtr_IsInstantiable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "IsInstantiable");
			JsonContract.NativeFieldInfoPtr__onDeserializedCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "_onDeserializedCallbacks");
			JsonContract.NativeFieldInfoPtr__onDeserializingCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "_onDeserializingCallbacks");
			JsonContract.NativeFieldInfoPtr__onSerializedCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "_onSerializedCallbacks");
			JsonContract.NativeFieldInfoPtr__onSerializingCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "_onSerializingCallbacks");
			JsonContract.NativeFieldInfoPtr__onErrorCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "_onErrorCallbacks");
			JsonContract.NativeFieldInfoPtr__createdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "_createdType");
			JsonContract.NativeFieldInfoPtr__UnderlyingType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "<UnderlyingType>k__BackingField");
			JsonContract.NativeFieldInfoPtr__IsReference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "<IsReference>k__BackingField");
			JsonContract.NativeFieldInfoPtr__Converter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "<Converter>k__BackingField");
			JsonContract.NativeFieldInfoPtr__InternalConverter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "<InternalConverter>k__BackingField");
			JsonContract.NativeFieldInfoPtr__DefaultCreator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "<DefaultCreator>k__BackingField");
			JsonContract.NativeFieldInfoPtr__DefaultCreatorNonPublic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "<DefaultCreatorNonPublic>k__BackingField");
			JsonContract.NativeMethodInfoPtr_get_UnderlyingType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665336);
			JsonContract.NativeMethodInfoPtr_get_CreatedType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665337);
			JsonContract.NativeMethodInfoPtr_set_CreatedType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665338);
			JsonContract.NativeMethodInfoPtr_get_IsReference_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665339);
			JsonContract.NativeMethodInfoPtr_set_IsReference_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665340);
			JsonContract.NativeMethodInfoPtr_get_Converter_Public_get_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665341);
			JsonContract.NativeMethodInfoPtr_set_Converter_Public_set_Void_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665342);
			JsonContract.NativeMethodInfoPtr_get_InternalConverter_Public_get_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665343);
			JsonContract.NativeMethodInfoPtr_set_InternalConverter_Internal_set_Void_JsonConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665344);
			JsonContract.NativeMethodInfoPtr_get_OnDeserializedCallbacks_Public_get_IList_1_SerializationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665345);
			JsonContract.NativeMethodInfoPtr_get_OnDeserializingCallbacks_Public_get_IList_1_SerializationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665346);
			JsonContract.NativeMethodInfoPtr_get_OnSerializedCallbacks_Public_get_IList_1_SerializationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665347);
			JsonContract.NativeMethodInfoPtr_get_OnSerializingCallbacks_Public_get_IList_1_SerializationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665348);
			JsonContract.NativeMethodInfoPtr_get_OnErrorCallbacks_Public_get_IList_1_SerializationErrorCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665349);
			JsonContract.NativeMethodInfoPtr_get_DefaultCreator_Public_get_Func_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665350);
			JsonContract.NativeMethodInfoPtr_set_DefaultCreator_Public_set_Void_Func_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665351);
			JsonContract.NativeMethodInfoPtr_get_DefaultCreatorNonPublic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665352);
			JsonContract.NativeMethodInfoPtr_set_DefaultCreatorNonPublic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665353);
			JsonContract.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665354);
			JsonContract.NativeMethodInfoPtr_InvokeOnSerializing_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665355);
			JsonContract.NativeMethodInfoPtr_InvokeOnSerialized_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665356);
			JsonContract.NativeMethodInfoPtr_InvokeOnDeserializing_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665357);
			JsonContract.NativeMethodInfoPtr_InvokeOnDeserialized_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665358);
			JsonContract.NativeMethodInfoPtr_InvokeOnError_Internal_Void_Object_StreamingContext_ErrorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665359);
			JsonContract.NativeMethodInfoPtr_CreateSerializationCallback_Internal_Static_SerializationCallback_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665360);
			JsonContract.NativeMethodInfoPtr_CreateSerializationErrorCallback_Internal_Static_SerializationErrorCallback_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, 100665361);
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00044120 File Offset: 0x00042320
		public unsafe Type UnderlyingType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_get_UnderlyingType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00044160 File Offset: 0x00042360
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x000441A0 File Offset: 0x000423A0
		public unsafe Type CreatedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_get_CreatedType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 749303, RefRangeEnd = 749307, XrefRangeStart = 749298, XrefRangeEnd = 749303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_set_CreatedType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x000441E4 File Offset: 0x000423E4
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x0004421C File Offset: 0x0004241C
		public unsafe Nullable<bool> IsReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_get_IsReference_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_set_IsReference_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00044264 File Offset: 0x00042464
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x000442A4 File Offset: 0x000424A4
		public unsafe JsonConverter Converter
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_get_Converter_Public_get_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_set_Converter_Public_set_Void_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x000442E8 File Offset: 0x000424E8
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00044328 File Offset: 0x00042528
		public unsafe JsonConverter InternalConverter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_get_InternalConverter_Public_get_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_set_InternalConverter_Internal_set_Void_JsonConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0004436C File Offset: 0x0004256C
		public unsafe IList<SerializationCallback> OnDeserializedCallbacks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749307, XrefRangeEnd = 749314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_get_OnDeserializedCallbacks_Public_get_IList_1_SerializationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SerializationCallback>>(intPtr3) : null;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x000443AC File Offset: 0x000425AC
		public unsafe IList<SerializationCallback> OnDeserializingCallbacks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749314, XrefRangeEnd = 749321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_get_OnDeserializingCallbacks_Public_get_IList_1_SerializationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SerializationCallback>>(intPtr3) : null;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x000443EC File Offset: 0x000425EC
		public unsafe IList<SerializationCallback> OnSerializedCallbacks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749321, XrefRangeEnd = 749328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_get_OnSerializedCallbacks_Public_get_IList_1_SerializationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SerializationCallback>>(intPtr3) : null;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0004442C File Offset: 0x0004262C
		public unsafe IList<SerializationCallback> OnSerializingCallbacks
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 749335, RefRangeEnd = 749338, XrefRangeStart = 749328, XrefRangeEnd = 749335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_get_OnSerializingCallbacks_Public_get_IList_1_SerializationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SerializationCallback>>(intPtr3) : null;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0004446C File Offset: 0x0004266C
		public unsafe IList<SerializationErrorCallback> OnErrorCallbacks
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 749345, RefRangeEnd = 749347, XrefRangeStart = 749338, XrefRangeEnd = 749345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_get_OnErrorCallbacks_Public_get_IList_1_SerializationErrorCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<SerializationErrorCallback>>(intPtr3) : null;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x000444AC File Offset: 0x000426AC
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x000444EC File Offset: 0x000426EC
		public unsafe Func<Object> DefaultCreator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_get_DefaultCreator_Public_get_Func_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Object>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_set_DefaultCreator_Public_set_Void_Func_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00044530 File Offset: 0x00042730
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x0004456C File Offset: 0x0004276C
		public unsafe bool DefaultCreatorNonPublic
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 311955, RefRangeEnd = 311956, XrefRangeStart = 311955, XrefRangeEnd = 311956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_get_DefaultCreatorNonPublic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_set_DefaultCreatorNonPublic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x000445AC File Offset: 0x000427AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 749367, RefRangeEnd = 749372, XrefRangeStart = 749347, XrefRangeEnd = 749367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonContract(Type underlyingType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonContract>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x000445F8 File Offset: 0x000427F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 749386, RefRangeEnd = 749387, XrefRangeStart = 749372, XrefRangeEnd = 749386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnSerializing(Object o, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_InvokeOnSerializing_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00044654 File Offset: 0x00042854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 749401, RefRangeEnd = 749402, XrefRangeStart = 749387, XrefRangeEnd = 749401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnSerialized(Object o, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_InvokeOnSerialized_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x000446B0 File Offset: 0x000428B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 749416, RefRangeEnd = 749417, XrefRangeStart = 749402, XrefRangeEnd = 749416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnDeserializing(Object o, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_InvokeOnDeserializing_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0004470C File Offset: 0x0004290C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 749431, RefRangeEnd = 749432, XrefRangeStart = 749417, XrefRangeEnd = 749431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnDeserialized(Object o, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_InvokeOnDeserialized_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00044768 File Offset: 0x00042968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 749446, RefRangeEnd = 749447, XrefRangeStart = 749432, XrefRangeEnd = 749446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeOnError(Object o, StreamingContext context, ErrorContext errorContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_InvokeOnError_Internal_Void_Object_StreamingContext_ErrorContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x000447D4 File Offset: 0x000429D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 749458, RefRangeEnd = 749462, XrefRangeStart = 749447, XrefRangeEnd = 749458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackMethodInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_CreateSerializationCallback_Internal_Static_SerializationCallback_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationCallback>(intPtr3) : null;
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00044818 File Offset: 0x00042A18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 749483, RefRangeEnd = 749484, XrefRangeStart = 749462, XrefRangeEnd = 749483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackMethodInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.NativeMethodInfoPtr_CreateSerializationErrorCallback_Internal_Static_SerializationErrorCallback_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationErrorCallback>(intPtr3) : null;
			}
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x000055C3 File Offset: 0x000037C3
		public JsonContract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x0004485C File Offset: 0x00042A5C
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x000055CC File Offset: 0x000037CC
		public unsafe bool IsNullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_IsNullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_IsNullable)) = value;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00044884 File Offset: 0x00042A84
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x000055E7 File Offset: 0x000037E7
		public unsafe bool IsConvertable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_IsConvertable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_IsConvertable)) = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x000448AC File Offset: 0x00042AAC
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x00005602 File Offset: 0x00003802
		public unsafe bool IsEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_IsEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_IsEnum)) = value;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x000448D4 File Offset: 0x00042AD4
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x0000561D File Offset: 0x0000381D
		public unsafe Type NonNullableUnderlyingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_NonNullableUnderlyingType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_NonNullableUnderlyingType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00044904 File Offset: 0x00042B04
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x0000563C File Offset: 0x0000383C
		public unsafe ReadType InternalReadType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_InternalReadType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_InternalReadType)) = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0004492C File Offset: 0x00042B2C
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x00005657 File Offset: 0x00003857
		public unsafe JsonContractType ContractType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_ContractType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_ContractType)) = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x00044954 File Offset: 0x00042B54
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x00005672 File Offset: 0x00003872
		public unsafe bool IsReadOnlyOrFixedSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_IsReadOnlyOrFixedSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_IsReadOnlyOrFixedSize)) = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0004497C File Offset: 0x00042B7C
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x0000568D File Offset: 0x0000388D
		public unsafe bool IsSealed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_IsSealed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_IsSealed)) = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x000449A4 File Offset: 0x00042BA4
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x000056A8 File Offset: 0x000038A8
		public unsafe bool IsInstantiable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_IsInstantiable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr_IsInstantiable)) = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x000449CC File Offset: 0x00042BCC
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x000056C3 File Offset: 0x000038C3
		public unsafe List<SerializationCallback> _onDeserializedCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__onDeserializedCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializationCallback>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__onDeserializedCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x000449FC File Offset: 0x00042BFC
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x000056E2 File Offset: 0x000038E2
		public unsafe List<SerializationCallback> _onDeserializingCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__onDeserializingCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializationCallback>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__onDeserializingCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00044A2C File Offset: 0x00042C2C
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00005701 File Offset: 0x00003901
		public unsafe List<SerializationCallback> _onSerializedCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__onSerializedCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializationCallback>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__onSerializedCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00044A5C File Offset: 0x00042C5C
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x00005720 File Offset: 0x00003920
		public unsafe List<SerializationCallback> _onSerializingCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__onSerializingCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializationCallback>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__onSerializingCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00044A8C File Offset: 0x00042C8C
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x0000573F File Offset: 0x0000393F
		public unsafe List<SerializationErrorCallback> _onErrorCallbacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__onErrorCallbacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializationErrorCallback>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__onErrorCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00044ABC File Offset: 0x00042CBC
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x0000575E File Offset: 0x0000395E
		public unsafe Type _createdType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__createdType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__createdType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00044AEC File Offset: 0x00042CEC
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x0000577D File Offset: 0x0000397D
		public unsafe Type _UnderlyingType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__UnderlyingType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__UnderlyingType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00044B1C File Offset: 0x00042D1C
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x0000579C File Offset: 0x0000399C
		public Nullable<bool> _IsReference_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__IsReference_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__IsReference_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00044B4C File Offset: 0x00042D4C
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x000057CA File Offset: 0x000039CA
		public unsafe JsonConverter _Converter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__Converter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__Converter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00044B7C File Offset: 0x00042D7C
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x000057E9 File Offset: 0x000039E9
		public unsafe JsonConverter _InternalConverter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__InternalConverter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__InternalConverter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00044BAC File Offset: 0x00042DAC
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x00005808 File Offset: 0x00003A08
		public unsafe Func<Object> _DefaultCreator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__DefaultCreator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__DefaultCreator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00044BDC File Offset: 0x00042DDC
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00005827 File Offset: 0x00003A27
		public unsafe bool _DefaultCreatorNonPublic_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__DefaultCreatorNonPublic_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.NativeFieldInfoPtr__DefaultCreatorNonPublic_k__BackingField)) = value;
			}
		}

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeFieldInfoPtr_IsNullable;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeFieldInfoPtr_IsConvertable;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeFieldInfoPtr_IsEnum;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeFieldInfoPtr_NonNullableUnderlyingType;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_InternalReadType;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_ContractType;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_IsReadOnlyOrFixedSize;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_IsSealed;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeFieldInfoPtr_IsInstantiable;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeFieldInfoPtr__onDeserializedCallbacks;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr__onDeserializingCallbacks;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeFieldInfoPtr__onSerializedCallbacks;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeFieldInfoPtr__onSerializingCallbacks;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeFieldInfoPtr__onErrorCallbacks;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr__createdType;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr__UnderlyingType_k__BackingField;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr__IsReference_k__BackingField;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr__Converter_k__BackingField;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr__InternalConverter_k__BackingField;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeFieldInfoPtr__DefaultCreator_k__BackingField;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr__DefaultCreatorNonPublic_k__BackingField;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingType_Public_get_Type_0;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeMethodInfoPtr_get_CreatedType_Public_get_Type_0;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_set_CreatedType_Public_set_Void_Type_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReference_Public_get_Nullable_1_Boolean_0;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReference_Public_set_Void_Nullable_1_Boolean_0;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr_get_Converter_Public_get_JsonConverter_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_set_Converter_Public_set_Void_JsonConverter_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalConverter_Public_get_JsonConverter_0;

		// Token: 0x040008FF RID: 2303
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalConverter_Internal_set_Void_JsonConverter_0;

		// Token: 0x04000900 RID: 2304
		private static readonly IntPtr NativeMethodInfoPtr_get_OnDeserializedCallbacks_Public_get_IList_1_SerializationCallback_0;

		// Token: 0x04000901 RID: 2305
		private static readonly IntPtr NativeMethodInfoPtr_get_OnDeserializingCallbacks_Public_get_IList_1_SerializationCallback_0;

		// Token: 0x04000902 RID: 2306
		private static readonly IntPtr NativeMethodInfoPtr_get_OnSerializedCallbacks_Public_get_IList_1_SerializationCallback_0;

		// Token: 0x04000903 RID: 2307
		private static readonly IntPtr NativeMethodInfoPtr_get_OnSerializingCallbacks_Public_get_IList_1_SerializationCallback_0;

		// Token: 0x04000904 RID: 2308
		private static readonly IntPtr NativeMethodInfoPtr_get_OnErrorCallbacks_Public_get_IList_1_SerializationErrorCallback_0;

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultCreator_Public_get_Func_1_Object_0;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultCreator_Public_set_Void_Func_1_Object_0;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultCreatorNonPublic_Public_get_Boolean_0;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultCreatorNonPublic_Public_set_Void_Boolean_0;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;

		// Token: 0x0400090A RID: 2314
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnSerializing_Internal_Void_Object_StreamingContext_0;

		// Token: 0x0400090B RID: 2315
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnSerialized_Internal_Void_Object_StreamingContext_0;

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnDeserializing_Internal_Void_Object_StreamingContext_0;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnDeserialized_Internal_Void_Object_StreamingContext_0;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnError_Internal_Void_Object_StreamingContext_ErrorContext_0;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeMethodInfoPtr_CreateSerializationCallback_Internal_Static_SerializationCallback_MethodInfo_0;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeMethodInfoPtr_CreateSerializationErrorCallback_Internal_Static_SerializationErrorCallback_MethodInfo_0;

		// Token: 0x020001CC RID: 460
		[ObfuscatedName("Newtonsoft.Json.Serialization.JsonContract+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : Object
		{
			// Token: 0x06001E86 RID: 7814 RVA: 0x0008CC3C File Offset: 0x0008AE3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<JsonContract.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonContract.__c__DisplayClass57_0>.NativeClassPtr);
				JsonContract.__c__DisplayClass57_0.NativeFieldInfoPtr_callbackMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract.__c__DisplayClass57_0>.NativeClassPtr, "callbackMethodInfo");
				JsonContract.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract.__c__DisplayClass57_0>.NativeClassPtr, 100665362);
				JsonContract.__c__DisplayClass57_0.NativeMethodInfoPtr__CreateSerializationCallback_b__0_Internal_Void_Object_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract.__c__DisplayClass57_0>.NativeClassPtr, 100665363);
			}

			// Token: 0x06001E87 RID: 7815 RVA: 0x0008CCA4 File Offset: 0x0008AEA4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonContract.__c__DisplayClass57_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E88 RID: 7816 RVA: 0x0008CCE0 File Offset: 0x0008AEE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749278, XrefRangeEnd = 749287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateSerializationCallback_b__0(Object o, StreamingContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.__c__DisplayClass57_0.NativeMethodInfoPtr__CreateSerializationCallback_b__0_Internal_Void_Object_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E89 RID: 7817 RVA: 0x0000F15F File Offset: 0x0000D35F
			public __c__DisplayClass57_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000892 RID: 2194
			// (get) Token: 0x06001E8A RID: 7818 RVA: 0x0008CD3C File Offset: 0x0008AF3C
			// (set) Token: 0x06001E8B RID: 7819 RVA: 0x0000F168 File Offset: 0x0000D368
			public unsafe MethodInfo callbackMethodInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.__c__DisplayClass57_0.NativeFieldInfoPtr_callbackMethodInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.__c__DisplayClass57_0.NativeFieldInfoPtr_callbackMethodInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001648 RID: 5704
			private static readonly IntPtr NativeFieldInfoPtr_callbackMethodInfo;

			// Token: 0x04001649 RID: 5705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400164A RID: 5706
			private static readonly IntPtr NativeMethodInfoPtr__CreateSerializationCallback_b__0_Internal_Void_Object_StreamingContext_0;
		}

		// Token: 0x020001CD RID: 461
		[ObfuscatedName("Newtonsoft.Json.Serialization.JsonContract+<>c__DisplayClass58_0")]
		public sealed class __c__DisplayClass58_0 : Object
		{
			// Token: 0x06001E8C RID: 7820 RVA: 0x0008CD6C File Offset: 0x0008AF6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_0()
			{
				Il2CppClassPointerStore<JsonContract.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonContract>.NativeClassPtr, "<>c__DisplayClass58_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonContract.__c__DisplayClass58_0>.NativeClassPtr);
				JsonContract.__c__DisplayClass58_0.NativeFieldInfoPtr_callbackMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContract.__c__DisplayClass58_0>.NativeClassPtr, "callbackMethodInfo");
				JsonContract.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract.__c__DisplayClass58_0>.NativeClassPtr, 100665364);
				JsonContract.__c__DisplayClass58_0.NativeMethodInfoPtr__CreateSerializationErrorCallback_b__0_Internal_Void_Object_StreamingContext_ErrorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContract.__c__DisplayClass58_0>.NativeClassPtr, 100665365);
			}

			// Token: 0x06001E8D RID: 7821 RVA: 0x0008CDD4 File Offset: 0x0008AFD4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonContract.__c__DisplayClass58_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E8E RID: 7822 RVA: 0x0008CE10 File Offset: 0x0008B010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749287, XrefRangeEnd = 749298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateSerializationErrorCallback_b__0(Object o, StreamingContext context, ErrorContext econtext)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(econtext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContract.__c__DisplayClass58_0.NativeMethodInfoPtr__CreateSerializationErrorCallback_b__0_Internal_Void_Object_StreamingContext_ErrorContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E8F RID: 7823 RVA: 0x0000F187 File Offset: 0x0000D387
			public __c__DisplayClass58_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000893 RID: 2195
			// (get) Token: 0x06001E90 RID: 7824 RVA: 0x0008CE7C File Offset: 0x0008B07C
			// (set) Token: 0x06001E91 RID: 7825 RVA: 0x0000F190 File Offset: 0x0000D390
			public unsafe MethodInfo callbackMethodInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.__c__DisplayClass58_0.NativeFieldInfoPtr_callbackMethodInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContract.__c__DisplayClass58_0.NativeFieldInfoPtr_callbackMethodInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400164B RID: 5707
			private static readonly IntPtr NativeFieldInfoPtr_callbackMethodInfo;

			// Token: 0x0400164C RID: 5708
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400164D RID: 5709
			private static readonly IntPtr NativeMethodInfoPtr__CreateSerializationErrorCallback_b__0_Internal_Void_Object_StreamingContext_ErrorContext_0;
		}
	}
}
