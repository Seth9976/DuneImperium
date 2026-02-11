using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000018 RID: 24
	public class JsonContainerAttribute : Attribute
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00012C58 File Offset: 0x00010E58
		// Note: this type is marked as 'beforefieldinit'.
		static JsonContainerAttribute()
		{
			Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json", "JsonContainerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr);
			JsonContainerAttribute.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, "<Id>k__BackingField");
			JsonContainerAttribute.NativeFieldInfoPtr__Title_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, "<Title>k__BackingField");
			JsonContainerAttribute.NativeFieldInfoPtr__Description_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, "<Description>k__BackingField");
			JsonContainerAttribute.NativeFieldInfoPtr__ItemConverterType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, "<ItemConverterType>k__BackingField");
			JsonContainerAttribute.NativeFieldInfoPtr__ItemConverterParameters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, "<ItemConverterParameters>k__BackingField");
			JsonContainerAttribute.NativeFieldInfoPtr__NamingStrategyInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, "<NamingStrategyInstance>k__BackingField");
			JsonContainerAttribute.NativeFieldInfoPtr__isReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, "_isReference");
			JsonContainerAttribute.NativeFieldInfoPtr__itemIsReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, "_itemIsReference");
			JsonContainerAttribute.NativeFieldInfoPtr__itemReferenceLoopHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, "_itemReferenceLoopHandling");
			JsonContainerAttribute.NativeFieldInfoPtr__itemTypeNameHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, "_itemTypeNameHandling");
			JsonContainerAttribute.NativeFieldInfoPtr__namingStrategyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, "_namingStrategyType");
			JsonContainerAttribute.NativeFieldInfoPtr__namingStrategyParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, "_namingStrategyParameters");
			JsonContainerAttribute.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663328);
			JsonContainerAttribute.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663329);
			JsonContainerAttribute.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663330);
			JsonContainerAttribute.NativeMethodInfoPtr_set_Title_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663331);
			JsonContainerAttribute.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663332);
			JsonContainerAttribute.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663333);
			JsonContainerAttribute.NativeMethodInfoPtr_get_ItemConverterType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663334);
			JsonContainerAttribute.NativeMethodInfoPtr_set_ItemConverterType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663335);
			JsonContainerAttribute.NativeMethodInfoPtr_get_ItemConverterParameters_Public_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663336);
			JsonContainerAttribute.NativeMethodInfoPtr_set_ItemConverterParameters_Public_set_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663337);
			JsonContainerAttribute.NativeMethodInfoPtr_get_NamingStrategyType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663338);
			JsonContainerAttribute.NativeMethodInfoPtr_set_NamingStrategyType_Public_set_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663339);
			JsonContainerAttribute.NativeMethodInfoPtr_get_NamingStrategyParameters_Public_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663340);
			JsonContainerAttribute.NativeMethodInfoPtr_set_NamingStrategyParameters_Public_set_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663341);
			JsonContainerAttribute.NativeMethodInfoPtr_get_NamingStrategyInstance_Internal_get_NamingStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663342);
			JsonContainerAttribute.NativeMethodInfoPtr_set_NamingStrategyInstance_Internal_set_Void_NamingStrategy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663343);
			JsonContainerAttribute.NativeMethodInfoPtr_get_IsReference_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663344);
			JsonContainerAttribute.NativeMethodInfoPtr_set_IsReference_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663345);
			JsonContainerAttribute.NativeMethodInfoPtr_get_ItemIsReference_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663346);
			JsonContainerAttribute.NativeMethodInfoPtr_set_ItemIsReference_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663347);
			JsonContainerAttribute.NativeMethodInfoPtr_get_ItemReferenceLoopHandling_Public_get_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663348);
			JsonContainerAttribute.NativeMethodInfoPtr_set_ItemReferenceLoopHandling_Public_set_Void_ReferenceLoopHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663349);
			JsonContainerAttribute.NativeMethodInfoPtr_get_ItemTypeNameHandling_Public_get_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663350);
			JsonContainerAttribute.NativeMethodInfoPtr_set_ItemTypeNameHandling_Public_set_Void_TypeNameHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663351);
			JsonContainerAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663352);
			JsonContainerAttribute.NativeMethodInfoPtr__ctor_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr, 100663353);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00012F80 File Offset: 0x00011180
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00012FB8 File Offset: 0x000111B8
		public unsafe string Id
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_get_Id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00012FFC File Offset: 0x000111FC
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00013034 File Offset: 0x00011234
		public unsafe string Title
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_set_Title_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00013078 File Offset: 0x00011278
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000130B0 File Offset: 0x000112B0
		public unsafe string Description
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000130F4 File Offset: 0x000112F4
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00013134 File Offset: 0x00011334
		public unsafe Type ItemConverterType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_get_ItemConverterType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_set_ItemConverterType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00013178 File Offset: 0x00011378
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000131B8 File Offset: 0x000113B8
		public unsafe Il2CppReferenceArray<Object> ItemConverterParameters
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_get_ItemConverterParameters_Public_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_set_ItemConverterParameters_Public_set_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000131FC File Offset: 0x000113FC
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0001323C File Offset: 0x0001143C
		public unsafe Type NamingStrategyType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_get_NamingStrategyType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726992, XrefRangeEnd = 726994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_set_NamingStrategyType_Public_set_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00013280 File Offset: 0x00011480
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000132C0 File Offset: 0x000114C0
		public unsafe Il2CppReferenceArray<Object> NamingStrategyParameters
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_get_NamingStrategyParameters_Public_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726994, XrefRangeEnd = 726996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_set_NamingStrategyParameters_Public_set_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00013304 File Offset: 0x00011504
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00013344 File Offset: 0x00011544
		public unsafe NamingStrategy NamingStrategyInstance
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_get_NamingStrategyInstance_Internal_get_NamingStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NamingStrategy>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_set_NamingStrategyInstance_Internal_set_Void_NamingStrategy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00013388 File Offset: 0x00011588
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000133C4 File Offset: 0x000115C4
		public unsafe bool IsReference
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726996, XrefRangeEnd = 726997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_get_IsReference_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726997, XrefRangeEnd = 727000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_set_IsReference_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00013404 File Offset: 0x00011604
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00013440 File Offset: 0x00011640
		public unsafe bool ItemIsReference
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727000, XrefRangeEnd = 727001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_get_ItemIsReference_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727001, XrefRangeEnd = 727004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_set_ItemIsReference_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00013480 File Offset: 0x00011680
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000134BC File Offset: 0x000116BC
		public unsafe ReferenceLoopHandling ItemReferenceLoopHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727004, XrefRangeEnd = 727005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_get_ItemReferenceLoopHandling_Public_get_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727005, XrefRangeEnd = 727008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_set_ItemReferenceLoopHandling_Public_set_Void_ReferenceLoopHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000134FC File Offset: 0x000116FC
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00013538 File Offset: 0x00011738
		public unsafe TypeNameHandling ItemTypeNameHandling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727008, XrefRangeEnd = 727009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_get_ItemTypeNameHandling_Public_get_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727009, XrefRangeEnd = 727012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr_set_ItemTypeNameHandling_Public_set_Void_TypeNameHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00013578 File Offset: 0x00011778
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonContainerAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000135B4 File Offset: 0x000117B4
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonContainerAttribute(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonContainerAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonContainerAttribute.NativeMethodInfoPtr__ctor_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002312 File Offset: 0x00000512
		public JsonContainerAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00013600 File Offset: 0x00011800
		// (set) Token: 0x06000069 RID: 105 RVA: 0x0000231B File Offset: 0x0000051B
		public unsafe string _Id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__Id_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__Id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00013628 File Offset: 0x00011828
		// (set) Token: 0x0600006B RID: 107 RVA: 0x0000233A File Offset: 0x0000053A
		public unsafe string _Title_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__Title_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__Title_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00013650 File Offset: 0x00011850
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002359 File Offset: 0x00000559
		public unsafe string _Description_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__Description_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__Description_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00013678 File Offset: 0x00011878
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002378 File Offset: 0x00000578
		public unsafe Type _ItemConverterType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__ItemConverterType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__ItemConverterType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000136A8 File Offset: 0x000118A8
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002397 File Offset: 0x00000597
		public unsafe Il2CppReferenceArray<Object> _ItemConverterParameters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__ItemConverterParameters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__ItemConverterParameters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000136D8 File Offset: 0x000118D8
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000023B6 File Offset: 0x000005B6
		public unsafe NamingStrategy _NamingStrategyInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__NamingStrategyInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NamingStrategy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__NamingStrategyInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00013708 File Offset: 0x00011908
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000023D5 File Offset: 0x000005D5
		public Nullable<bool> _isReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__isReference);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__isReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00013738 File Offset: 0x00011938
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002403 File Offset: 0x00000603
		public Nullable<bool> _itemIsReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__itemIsReference);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__itemIsReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00013768 File Offset: 0x00011968
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002431 File Offset: 0x00000631
		public Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__itemReferenceLoopHandling);
				return new Nullable<ReferenceLoopHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<ReferenceLoopHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__itemReferenceLoopHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<ReferenceLoopHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00013798 File Offset: 0x00011998
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000245F File Offset: 0x0000065F
		public Nullable<TypeNameHandling> _itemTypeNameHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__itemTypeNameHandling);
				return new Nullable<TypeNameHandling>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<TypeNameHandling>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__itemTypeNameHandling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<TypeNameHandling>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000137C8 File Offset: 0x000119C8
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0000248D File Offset: 0x0000068D
		public unsafe Type _namingStrategyType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__namingStrategyType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__namingStrategyType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000137F8 File Offset: 0x000119F8
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000024AC File Offset: 0x000006AC
		public unsafe Il2CppReferenceArray<Object> _namingStrategyParameters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__namingStrategyParameters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonContainerAttribute.NativeFieldInfoPtr__namingStrategyParameters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr__Title_k__BackingField;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr__Description_k__BackingField;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr__ItemConverterType_k__BackingField;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr__ItemConverterParameters_k__BackingField;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr__NamingStrategyInstance_k__BackingField;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr__isReference;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr__itemIsReference;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr__itemReferenceLoopHandling;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr__itemTypeNameHandling;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr__namingStrategyType;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr__namingStrategyParameters;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_String_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_set_Title_Public_set_Void_String_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_String_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemConverterType_Public_get_Type_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemConverterType_Public_set_Void_Type_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemConverterParameters_Public_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemConverterParameters_Public_set_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_NamingStrategyType_Public_get_Type_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_set_NamingStrategyType_Public_set_Void_Type_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_get_NamingStrategyParameters_Public_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_set_NamingStrategyParameters_Public_set_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_get_NamingStrategyInstance_Internal_get_NamingStrategy_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_set_NamingStrategyInstance_Internal_set_Void_NamingStrategy_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReference_Public_get_Boolean_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_set_IsReference_Public_set_Void_Boolean_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemIsReference_Public_get_Boolean_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemIsReference_Public_set_Void_Boolean_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemReferenceLoopHandling_Public_get_ReferenceLoopHandling_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemReferenceLoopHandling_Public_set_Void_ReferenceLoopHandling_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemTypeNameHandling_Public_get_TypeNameHandling_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemTypeNameHandling_Public_set_Void_TypeNameHandling_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_0;
	}
}
