using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200012C RID: 300
	[Serializable]
	public class Attribute : Object
	{
		// Token: 0x060013E8 RID: 5096 RVA: 0x00085DA4 File Offset: 0x00083FA4
		// Note: this type is marked as 'beforefieldinit'.
		static Attribute()
		{
			Il2CppClassPointerStore<Attribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Attribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Attribute>.NativeClassPtr);
			Attribute.NativeMethodInfoPtr_InternalGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_PropertyInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666814);
			Attribute.NativeMethodInfoPtr_InternalGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_EventInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666815);
			Attribute.NativeMethodInfoPtr_InternalParamGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_ParameterInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666816);
			Attribute.NativeMethodInfoPtr_InternalIsDefined_Private_Static_Boolean_PropertyInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666817);
			Attribute.NativeMethodInfoPtr_InternalIsDefined_Private_Static_Boolean_EventInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666818);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666819);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666820);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666821);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666822);
			Attribute.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666823);
			Attribute.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666824);
			Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666825);
			Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666826);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_ParameterInfo_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666827);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_ParameterInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666828);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Module_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666829);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Module_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666830);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666831);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666832);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666833);
			Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666834);
			Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666835);
			Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666836);
			Attribute.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666837);
			Attribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666838);
			Attribute.NativeMethodInfoPtr_AreFieldValuesEqual_Private_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666839);
			Attribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666840);
			Attribute.NativeMethodInfoPtr_get_TypeId_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666841);
			Attribute.NativeMethodInfoPtr_Match_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666842);
			Attribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100666843);
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0008602C File Offset: 0x0008422C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338337, RefRangeEnd = 1338338, XrefRangeStart = 1338331, XrefRangeEnd = 1338337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_InternalGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_PropertyInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060013EA RID: 5098 RVA: 0x00086090 File Offset: 0x00084290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1338344, RefRangeEnd = 1338346, XrefRangeStart = 1338338, XrefRangeEnd = 1338344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> InternalGetCustomAttributes(EventInfo element, Type type, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_InternalGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_EventInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x000860F4 File Offset: 0x000842F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338397, RefRangeEnd = 1338398, XrefRangeStart = 1338346, XrefRangeEnd = 1338397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_InternalParamGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_ParameterInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00086158 File Offset: 0x00084358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338398, XrefRangeEnd = 1338402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_InternalIsDefined_Private_Static_Boolean_PropertyInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x000861BC File Offset: 0x000843BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338402, XrefRangeEnd = 1338406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_InternalIsDefined_Private_Static_Boolean_EventInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00086220 File Offset: 0x00084420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338407, RefRangeEnd = 1338408, XrefRangeStart = 1338406, XrefRangeEnd = 1338407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(MemberInfo element, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00086278 File Offset: 0x00084478
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1338428, RefRangeEnd = 1338431, XrefRangeStart = 1338408, XrefRangeEnd = 1338428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(MemberInfo element, Type type, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x000862DC File Offset: 0x000844DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338432, RefRangeEnd = 1338433, XrefRangeStart = 1338431, XrefRangeEnd = 1338432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(MemberInfo element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
			}
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00086320 File Offset: 0x00084520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338462, RefRangeEnd = 1338463, XrefRangeStart = 1338433, XrefRangeEnd = 1338462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(MemberInfo element, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00086374 File Offset: 0x00084574
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1338464, RefRangeEnd = 1338469, XrefRangeStart = 1338463, XrefRangeEnd = 1338464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDefined(MemberInfo element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x000863C8 File Offset: 0x000845C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1338489, RefRangeEnd = 1338491, XrefRangeStart = 1338469, XrefRangeEnd = 1338489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDefined(MemberInfo element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0008642C File Offset: 0x0008462C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1338492, RefRangeEnd = 1338498, XrefRangeStart = 1338491, XrefRangeEnd = 1338492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(MemberInfo element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00086484 File Offset: 0x00084684
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1338499, RefRangeEnd = 1338502, XrefRangeStart = 1338498, XrefRangeEnd = 1338499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x000864E8 File Offset: 0x000846E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338502, XrefRangeEnd = 1338520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_ParameterInfo_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0008654C File Offset: 0x0008474C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338520, XrefRangeEnd = 1338546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(ParameterInfo element, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_ParameterInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x000865A0 File Offset: 0x000847A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338546, XrefRangeEnd = 1338558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(Module element, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Module_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x000865F4 File Offset: 0x000847F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338558, XrefRangeEnd = 1338578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(Module element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Module_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x00086658 File Offset: 0x00084858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338579, RefRangeEnd = 1338580, XrefRangeStart = 1338578, XrefRangeEnd = 1338579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(Assembly element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x000866B0 File Offset: 0x000848B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1338597, RefRangeEnd = 1338600, XrefRangeStart = 1338580, XrefRangeEnd = 1338597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(Assembly element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x00086714 File Offset: 0x00084914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338609, RefRangeEnd = 1338610, XrefRangeStart = 1338600, XrefRangeEnd = 1338609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(Assembly element)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
			}
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x00086758 File Offset: 0x00084958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338610, XrefRangeEnd = 1338619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Attribute> GetCustomAttributes(Assembly element, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Attribute>>(intPtr3) : null;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x000867AC File Offset: 0x000849AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338620, RefRangeEnd = 1338621, XrefRangeStart = 1338619, XrefRangeEnd = 1338620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(Assembly element, Type attributeType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x00086804 File Offset: 0x00084A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338621, XrefRangeEnd = 1338622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Attribute>(intPtr3) : null;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x00086868 File Offset: 0x00084A68
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Attribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Attribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001401 RID: 5121 RVA: 0x000868A4 File Offset: 0x00084AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338622, XrefRangeEnd = 1338637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Attribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001402 RID: 5122 RVA: 0x000868FC File Offset: 0x00084AFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1338638, RefRangeEnd = 1338639, XrefRangeStart = 1338637, XrefRangeEnd = 1338638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreFieldValuesEqual(Object thisValue, Object thatValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thatValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_AreFieldValuesEqual_Private_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001403 RID: 5123 RVA: 0x00086950 File Offset: 0x00084B50
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1338649, RefRangeEnd = 1338662, XrefRangeStart = 1338639, XrefRangeEnd = 1338649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Attribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x00086998 File Offset: 0x00084B98
		public unsafe virtual Object TypeId
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 1322242, RefRangeEnd = 1322256, XrefRangeStart = 1322242, XrefRangeEnd = 1322256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Attribute.NativeMethodInfoPtr_get_TypeId_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x000869E4 File Offset: 0x00084BE4
		[CallerCount(0)]
		public unsafe virtual bool Match(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Attribute.NativeMethodInfoPtr_Match_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00086A3C File Offset: 0x00084C3C
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Attribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x000065EC File Offset: 0x000047EC
		public Attribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_PropertyInfo_Type_Boolean_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_EventInfo_Type_Boolean_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr_InternalParamGetCustomAttributes_Private_Static_Il2CppReferenceArray_1_Attribute_ParameterInfo_Type_Boolean_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsDefined_Private_Static_Boolean_PropertyInfo_Type_Boolean_0;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_InternalIsDefined_Private_Static_Boolean_EventInfo_Type_Boolean_0;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Type_Boolean_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_MemberInfo_Boolean_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Static_Boolean_MemberInfo_Type_Boolean_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_MemberInfo_Type_Boolean_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_ParameterInfo_Type_Boolean_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_ParameterInfo_Boolean_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Module_Boolean_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Module_Type_Boolean_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_Type_0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_Type_Boolean_0;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Static_Il2CppReferenceArray_1_Attribute_Assembly_Boolean_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttribute_Public_Static_Attribute_Assembly_Type_Boolean_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_AreFieldValuesEqual_Private_Static_Boolean_Object_Object_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeId_Public_Virtual_New_get_Object_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_New_Boolean_0;
	}
}
