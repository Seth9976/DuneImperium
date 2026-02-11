using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200015A RID: 346
	public static class MonoCustomAttrs : Object
	{
		// Token: 0x06001783 RID: 6019 RVA: 0x00095DC4 File Offset: 0x00093FC4
		// Note: this type is marked as 'beforefieldinit'.
		static MonoCustomAttrs()
		{
			Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoCustomAttrs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr);
			MonoCustomAttrs.NativeFieldInfoPtr_corlib = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "corlib");
			MonoCustomAttrs.NativeFieldInfoPtr_usage_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "usage_cache");
			MonoCustomAttrs.NativeFieldInfoPtr_DefaultAttributeUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "DefaultAttributeUsage");
			MonoCustomAttrs.NativeMethodInfoPtr_IsUserCattrProvider_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667402);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_Il2CppReferenceArray_1_Attribute_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667403);
			MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667404);
			MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributes_Private_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667405);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesBase_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667406);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667407);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667408);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesDataInternal_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667409);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667410);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667411);
			MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesDataBase_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667412);
			MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributesData_Internal_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667413);
			MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributesData_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667414);
			MonoCustomAttrs.NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_ICustomAttributeProvider_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667415);
			MonoCustomAttrs.NativeMethodInfoPtr_IsDefinedInternal_Internal_Static_Boolean_ICustomAttributeProvider_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667416);
			MonoCustomAttrs.NativeMethodInfoPtr_GetBasePropertyDefinition_Private_Static_PropertyInfo_RuntimePropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667417);
			MonoCustomAttrs.NativeMethodInfoPtr_GetBaseEventDefinition_Private_Static_EventInfo_RuntimeEventInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667418);
			MonoCustomAttrs.NativeMethodInfoPtr_GetBase_Private_Static_ICustomAttributeProvider_ICustomAttributeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667419);
			MonoCustomAttrs.NativeMethodInfoPtr_RetrieveAttributeUsageNoCache_Private_Static_AttributeUsageAttribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667420);
			MonoCustomAttrs.NativeMethodInfoPtr_RetrieveAttributeUsage_Private_Static_AttributeUsageAttribute_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, 100667421);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00095FC0 File Offset: 0x000941C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1346521, RefRangeEnd = 1346524, XrefRangeStart = 1346514, XrefRangeEnd = 1346521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUserCattrProvider(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_IsUserCattrProvider_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00096004 File Offset: 0x00094204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346524, XrefRangeEnd = 1346525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pseudoAttrs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_Il2CppReferenceArray_1_Attribute_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00096068 File Offset: 0x00094268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1346562, RefRangeEnd = 1346564, XrefRangeStart = 1346525, XrefRangeEnd = 1346562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x000960C0 File Offset: 0x000942C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1346580, RefRangeEnd = 1346581, XrefRangeStart = 1346564, XrefRangeEnd = 1346580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetPseudoCustomAttributes(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributes_Private_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00096104 File Offset: 0x00094304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1346600, RefRangeEnd = 1346602, XrefRangeStart = 1346581, XrefRangeEnd = 1346600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inheritedOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesBase_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00096168 File Offset: 0x00094368
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1346708, RefRangeEnd = 1346722, XrefRangeStart = 1346602, XrefRangeEnd = 1346708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x000961CC File Offset: 0x000943CC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1346733, RefRangeEnd = 1346741, XrefRangeStart = 1346722, XrefRangeEnd = 1346733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> GetCustomAttributes(ICustomAttributeProvider obj, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00096220 File Offset: 0x00094420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346741, XrefRangeEnd = 1346742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CustomAttributeData> GetCustomAttributesDataInternal(ICustomAttributeProvider obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesDataInternal_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00096264 File Offset: 0x00094464
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1346761, RefRangeEnd = 1346770, XrefRangeStart = 1346742, XrefRangeEnd = 1346761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, bool inherit = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x000962B8 File Offset: 0x000944B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1346815, RefRangeEnd = 1346816, XrefRangeStart = 1346770, XrefRangeEnd = 1346815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0009631C File Offset: 0x0009451C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1346841, RefRangeEnd = 1346843, XrefRangeStart = 1346816, XrefRangeEnd = 1346841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IList<CustomAttributeData> GetCustomAttributesDataBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inheritedOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetCustomAttributesDataBase_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00096380 File Offset: 0x00094580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1346880, RefRangeEnd = 1346881, XrefRangeStart = 1346843, XrefRangeEnd = 1346880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CustomAttributeData> GetPseudoCustomAttributesData(ICustomAttributeProvider obj, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributesData_Internal_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomAttributeData>>(intPtr3) : null;
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x000963D8 File Offset: 0x000945D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1346911, RefRangeEnd = 1346912, XrefRangeStart = 1346881, XrefRangeEnd = 1346911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CustomAttributeData> GetPseudoCustomAttributesData(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetPseudoCustomAttributesData_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CustomAttributeData>>(intPtr3) : null;
			}
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0009641C File Offset: 0x0009461C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1346935, RefRangeEnd = 1346946, XrefRangeStart = 1346912, XrefRangeEnd = 1346935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_ICustomAttributeProvider_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00096480 File Offset: 0x00094680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346946, XrefRangeEnd = 1346947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(AttributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_IsDefinedInternal_Internal_Static_Boolean_ICustomAttributeProvider_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x000964D4 File Offset: 0x000946D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1346963, RefRangeEnd = 1346964, XrefRangeStart = 1346947, XrefRangeEnd = 1346963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetBasePropertyDefinition(RuntimePropertyInfo property)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetBasePropertyDefinition_Private_Static_PropertyInfo_RuntimePropertyInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00096518 File Offset: 0x00094718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346964, XrefRangeEnd = 1346977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EventInfo GetBaseEventDefinition(RuntimeEventInfo evt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetBaseEventDefinition_Private_Static_EventInfo_RuntimeEventInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0009655C File Offset: 0x0009475C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1346998, RefRangeEnd = 1347001, XrefRangeStart = 1346977, XrefRangeEnd = 1346998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_GetBase_Private_Static_ICustomAttributeProvider_ICustomAttributeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomAttributeProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x000965A0 File Offset: 0x000947A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1347028, RefRangeEnd = 1347029, XrefRangeStart = 1347001, XrefRangeEnd = 1347028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_RetrieveAttributeUsageNoCache_Private_Static_AttributeUsageAttribute_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x000965E4 File Offset: 0x000947E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1347062, RefRangeEnd = 1347066, XrefRangeStart = 1347029, XrefRangeEnd = 1347062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.NativeMethodInfoPtr_RetrieveAttributeUsage_Private_Static_AttributeUsageAttribute_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00007766 File Offset: 0x00005966
		public MonoCustomAttrs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x00096628 File Offset: 0x00094828
		// (set) Token: 0x0600179A RID: 6042 RVA: 0x0000776F File Offset: 0x0000596F
		public unsafe static Assembly corlib
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoCustomAttrs.NativeFieldInfoPtr_corlib, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoCustomAttrs.NativeFieldInfoPtr_corlib, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x00096650 File Offset: 0x00094850
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x00007781 File Offset: 0x00005981
		public unsafe static Dictionary<Type, AttributeUsageAttribute> usage_cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoCustomAttrs.NativeFieldInfoPtr_usage_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, AttributeUsageAttribute>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoCustomAttrs.NativeFieldInfoPtr_usage_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x00096678 File Offset: 0x00094878
		// (set) Token: 0x0600179E RID: 6046 RVA: 0x00007793 File Offset: 0x00005993
		public unsafe static AttributeUsageAttribute DefaultAttributeUsage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MonoCustomAttrs.NativeFieldInfoPtr_DefaultAttributeUsage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MonoCustomAttrs.NativeFieldInfoPtr_DefaultAttributeUsage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeFieldInfoPtr_corlib;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeFieldInfoPtr_usage_cache;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeFieldInfoPtr_DefaultAttributeUsage;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeMethodInfoPtr_IsUserCattrProvider_Private_Static_Boolean_Object_0;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesInternal_Internal_Static_Il2CppReferenceArray_1_Attribute_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_0;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributes_Private_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesBase_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Internal_Static_Il2CppReferenceArray_1_Object_ICustomAttributeProvider_Boolean_0;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesDataInternal_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_0;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Boolean_0;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesData_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributesDataBase_Internal_Static_IList_1_CustomAttributeData_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributesData_Internal_Static_Il2CppReferenceArray_1_CustomAttributeData_ICustomAttributeProvider_Type_0;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeMethodInfoPtr_GetPseudoCustomAttributesData_Private_Static_Il2CppReferenceArray_1_CustomAttributeData_Type_0;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_ICustomAttributeProvider_Type_Boolean_0;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeMethodInfoPtr_IsDefinedInternal_Internal_Static_Boolean_ICustomAttributeProvider_Type_0;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeMethodInfoPtr_GetBasePropertyDefinition_Private_Static_PropertyInfo_RuntimePropertyInfo_0;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseEventDefinition_Private_Static_EventInfo_RuntimeEventInfo_0;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeMethodInfoPtr_GetBase_Private_Static_ICustomAttributeProvider_ICustomAttributeProvider_0;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveAttributeUsageNoCache_Private_Static_AttributeUsageAttribute_Type_0;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveAttributeUsage_Private_Static_AttributeUsageAttribute_Type_0;

		// Token: 0x020005F5 RID: 1525
		public class AttributeInfo : Object
		{
			// Token: 0x060057B1 RID: 22449 RVA: 0x00193E94 File Offset: 0x00192094
			// Note: this type is marked as 'beforefieldinit'.
			static AttributeInfo()
			{
				Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoCustomAttrs>.NativeClassPtr, "AttributeInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr);
				MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, "_usage");
				MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__inheritanceLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, "_inheritanceLevel");
				MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr__ctor_Public_Void_AttributeUsageAttribute_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, 100667423);
				MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr_get_Usage_Public_get_AttributeUsageAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, 100667424);
				MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr_get_InheritanceLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr, 100667425);
			}

			// Token: 0x060057B2 RID: 22450 RVA: 0x00193F24 File Offset: 0x00192124
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346513, XrefRangeEnd = 1346514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoCustomAttrs.AttributeInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(usage);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inheritanceLevel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr__ctor_Public_Void_AttributeUsageAttribute_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700165E RID: 5726
			// (get) Token: 0x060057B3 RID: 22451 RVA: 0x00193F80 File Offset: 0x00192180
			public unsafe AttributeUsageAttribute Usage
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr_get_Usage_Public_get_AttributeUsageAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x1700165F RID: 5727
			// (get) Token: 0x060057B4 RID: 22452 RVA: 0x00193FC0 File Offset: 0x001921C0
			public unsafe int InheritanceLevel
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoCustomAttrs.AttributeInfo.NativeMethodInfoPtr_get_InheritanceLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060057B5 RID: 22453 RVA: 0x0001F31F File Offset: 0x0001D51F
			public AttributeInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700165C RID: 5724
			// (get) Token: 0x060057B6 RID: 22454 RVA: 0x00193FFC File Offset: 0x001921FC
			// (set) Token: 0x060057B7 RID: 22455 RVA: 0x0001F328 File Offset: 0x0001D528
			public unsafe AttributeUsageAttribute _usage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__usage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeUsageAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__usage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700165D RID: 5725
			// (get) Token: 0x060057B8 RID: 22456 RVA: 0x0019402C File Offset: 0x0019222C
			// (set) Token: 0x060057B9 RID: 22457 RVA: 0x0001F347 File Offset: 0x0001D547
			public unsafe int _inheritanceLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__inheritanceLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoCustomAttrs.AttributeInfo.NativeFieldInfoPtr__inheritanceLevel)) = value;
				}
			}

			// Token: 0x0400482A RID: 18474
			private static readonly IntPtr NativeFieldInfoPtr__usage;

			// Token: 0x0400482B RID: 18475
			private static readonly IntPtr NativeFieldInfoPtr__inheritanceLevel;

			// Token: 0x0400482C RID: 18476
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeUsageAttribute_Int32_0;

			// Token: 0x0400482D RID: 18477
			private static readonly IntPtr NativeMethodInfoPtr_get_Usage_Public_get_AttributeUsageAttribute_0;

			// Token: 0x0400482E RID: 18478
			private static readonly IntPtr NativeMethodInfoPtr_get_InheritanceLevel_Public_get_Int32_0;
		}
	}
}
