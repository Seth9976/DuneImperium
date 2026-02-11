using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x0200013A RID: 314
	public static class EnumDataUtility : Object
	{
		// Token: 0x0600183F RID: 6207 RVA: 0x00071F4C File Offset: 0x0007014C
		// Note: this type is marked as 'beforefieldinit'.
		static EnumDataUtility()
		{
			Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "EnumDataUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr);
			EnumDataUtility.NativeFieldInfoPtr_s_EnumData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, "s_EnumData");
			EnumDataUtility.NativeMethodInfoPtr_GetCachedEnumData_Public_Static_EnumData_Type_CachedType_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100666588);
			EnumDataUtility.NativeMethodInfoPtr_HandleInspectorOrderAttribute_Internal_Static_Void_Type_byref_EnumData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100666589);
			EnumDataUtility.NativeMethodInfoPtr_CheckObsoleteAddition_Private_Static_Boolean_FieldInfo_CachedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100666590);
			EnumDataUtility.NativeMethodInfoPtr_EnumTooltipFromEnumField_Private_Static_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100666591);
			EnumDataUtility.NativeMethodInfoPtr_EnumNameFromEnumField_Private_Static_String_FieldInfo_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100666592);
			EnumDataUtility.NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass8_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100666594);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00072008 File Offset: 0x00070208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 664665, RefRangeEnd = 664666, XrefRangeStart = 664421, XrefRangeEnd = 664665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EnumData GetCachedEnumData(Type enumType, EnumDataUtility.CachedType cachedType = EnumDataUtility.CachedType.IncludeObsoleteExceptErrors, Func<string, string> nicifyName = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cachedType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nicifyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_GetCachedEnumData_Public_Static_EnumData_Type_CachedType_Func_2_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new EnumData(intPtr);
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00072064 File Offset: 0x00070264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 664723, RefRangeEnd = 664724, XrefRangeStart = 664666, XrefRangeEnd = 664723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleInspectorOrderAttribute(Type enumType, ref EnumData enumData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(enumData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_HandleInspectorOrderAttribute_Internal_Static_Void_Type_byref_EnumData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x000720B0 File Offset: 0x000702B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664724, XrefRangeEnd = 664735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckObsoleteAddition(FieldInfo field, EnumDataUtility.CachedType cachedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cachedType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_CheckObsoleteAddition_Private_Static_Boolean_FieldInfo_CachedType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00072100 File Offset: 0x00070300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664735, XrefRangeEnd = 664745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EnumTooltipFromEnumField(FieldInfo field)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_EnumTooltipFromEnumField_Private_Static_String_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x0007213C File Offset: 0x0007033C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 664764, RefRangeEnd = 664765, XrefRangeStart = 664745, XrefRangeEnd = 664764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EnumNameFromEnumField(FieldInfo field, Func<string, string> nicifyName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nicifyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_EnumNameFromEnumField_Private_Static_String_FieldInfo_Func_2_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x0007218C File Offset: 0x0007038C
		[CallerCount(0)]
		public unsafe static string Method_Internal_Static_String_byref___c__DisplayClass8_0_PDM_0(ref EnumDataUtility.__c__DisplayClass8_0 A_0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass8_0_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00009A0E File Offset: 0x00007C0E
		public EnumDataUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x000721CC File Offset: 0x000703CC
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x00009A17 File Offset: 0x00007C17
		public unsafe static Dictionary<ValueTuple<EnumDataUtility.CachedType, Type>, EnumData> s_EnumData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.NativeFieldInfoPtr_s_EnumData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<EnumDataUtility.CachedType, Type>, EnumData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.NativeFieldInfoPtr_s_EnumData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x000721F4 File Offset: 0x000703F4
		public static int EnumFlagsToInt(EnumData enumData, Enum enumValue)
		{
			bool unsigned = enumData.unsigned;
			int num;
			if (unsigned)
			{
				bool flag = enumData.underlyingType == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<uint>());
				if (flag)
				{
					num = (int)Convert.ToUInt32(enumValue);
				}
				else
				{
					bool flag2 = enumData.underlyingType == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ushort>());
					if (flag2)
					{
						ushort num2 = Convert.ToUInt16(enumValue);
						num = ((num2 == ushort.MaxValue) ? (-1) : ((int)num2));
					}
					else
					{
						byte b = Convert.ToByte(enumValue);
						num = ((b == byte.MaxValue) ? (-1) : ((int)b));
					}
				}
			}
			else
			{
				num = Convert.ToInt32(enumValue);
			}
			return num;
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00072288 File Offset: 0x00070488
		public static Enum IntToEnumFlags(Type enumType, int value)
		{
			EnumData cachedEnumData = EnumDataUtility.GetCachedEnumData(enumType, EnumDataUtility.CachedType.IncludeObsoleteExceptErrors, null);
			bool unsigned = cachedEnumData.unsigned;
			Enum @enum;
			if (unsigned)
			{
				bool flag = cachedEnumData.underlyingType == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<uint>());
				if (flag)
				{
					uint num = (uint)value;
					@enum = Enum.Parse(enumType, num.ToString()) as Enum;
				}
				else
				{
					bool flag2 = cachedEnumData.underlyingType == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ushort>());
					if (flag2)
					{
						@enum = Enum.Parse(enumType, ((ushort)value).ToString()) as Enum;
					}
					else
					{
						@enum = Enum.Parse(enumType, ((byte)value).ToString()) as Enum;
					}
				}
			}
			else
			{
				@enum = Enum.Parse(enumType, value.ToString()) as Enum;
			}
			return @enum;
		}

		// Token: 0x040015AA RID: 5546
		private static readonly IntPtr NativeFieldInfoPtr_s_EnumData;

		// Token: 0x040015AB RID: 5547
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedEnumData_Public_Static_EnumData_Type_CachedType_Func_2_String_String_0;

		// Token: 0x040015AC RID: 5548
		private static readonly IntPtr NativeMethodInfoPtr_HandleInspectorOrderAttribute_Internal_Static_Void_Type_byref_EnumData_0;

		// Token: 0x040015AD RID: 5549
		private static readonly IntPtr NativeMethodInfoPtr_CheckObsoleteAddition_Private_Static_Boolean_FieldInfo_CachedType_0;

		// Token: 0x040015AE RID: 5550
		private static readonly IntPtr NativeMethodInfoPtr_EnumTooltipFromEnumField_Private_Static_String_FieldInfo_0;

		// Token: 0x040015AF RID: 5551
		private static readonly IntPtr NativeMethodInfoPtr_EnumNameFromEnumField_Private_Static_String_FieldInfo_Func_2_String_String_0;

		// Token: 0x040015B0 RID: 5552
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass8_0_PDM_0;

		// Token: 0x0200073B RID: 1851
		public enum CachedType
		{
			// Token: 0x04002C46 RID: 11334
			ExcludeObsolete,
			// Token: 0x04002C47 RID: 11335
			IncludeObsoleteExceptErrors,
			// Token: 0x04002C48 RID: 11336
			IncludeAllObsolete
		}

		// Token: 0x0200073C RID: 1852
		[ObfuscatedName("UnityEngine.EnumDataUtility+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003736 RID: 14134 RVA: 0x000BB0E8 File Offset: 0x000B92E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr);
				EnumDataUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9");
				EnumDataUtility.__c.NativeFieldInfoPtr___9__2_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_5");
				EnumDataUtility.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_1");
				EnumDataUtility.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_2");
				EnumDataUtility.__c.NativeFieldInfoPtr___9__2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_3");
				EnumDataUtility.__c.NativeFieldInfoPtr___9__2_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_4");
				EnumDataUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100666596);
				EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_5_Internal_Int32_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100666597);
				EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_1_Internal_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100666598);
				EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_2_Internal_Enum_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100666599);
				EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_3_Internal_Int32_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100666600);
				EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_4_Internal_Int32_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100666601);
			}

			// Token: 0x06003737 RID: 14135 RVA: 0x000BB204 File Offset: 0x000B9404
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003738 RID: 14136 RVA: 0x000BB240 File Offset: 0x000B9440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664365, XrefRangeEnd = 664366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetCachedEnumData_b__2_5(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_5_Internal_Int32_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003739 RID: 14137 RVA: 0x000BB290 File Offset: 0x000B9490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664366, XrefRangeEnd = 664379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetCachedEnumData_b__2_1(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_1_Internal_String_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600373A RID: 14138 RVA: 0x000BB2D8 File Offset: 0x000B94D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664379, XrefRangeEnd = 664381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enum _GetCachedEnumData_b__2_2(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_2_Internal_Enum_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600373B RID: 14139 RVA: 0x000BB328 File Offset: 0x000B9528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664381, XrefRangeEnd = 664385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetCachedEnumData_b__2_3(Enum v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_3_Internal_Int32_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600373C RID: 14140 RVA: 0x000BB374 File Offset: 0x000B9574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664385, XrefRangeEnd = 664389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetCachedEnumData_b__2_4(Enum v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_4_Internal_Int32_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600373D RID: 14141 RVA: 0x00013E41 File Offset: 0x00012041
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A1C RID: 2588
			// (get) Token: 0x0600373E RID: 14142 RVA: 0x000BB3C0 File Offset: 0x000B95C0
			// (set) Token: 0x0600373F RID: 14143 RVA: 0x00013E4A File Offset: 0x0001204A
			public unsafe static EnumDataUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumDataUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1D RID: 2589
			// (get) Token: 0x06003740 RID: 14144 RVA: 0x000BB3E8 File Offset: 0x000B95E8
			// (set) Token: 0x06003741 RID: 14145 RVA: 0x00013E5C File Offset: 0x0001205C
			public unsafe static Func<FieldInfo, int> __9__2_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1E RID: 2590
			// (get) Token: 0x06003742 RID: 14146 RVA: 0x000BB410 File Offset: 0x000B9610
			// (set) Token: 0x06003743 RID: 14147 RVA: 0x00013E6E File Offset: 0x0001206E
			public unsafe static Func<FieldInfo, string> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A1F RID: 2591
			// (get) Token: 0x06003744 RID: 14148 RVA: 0x000BB438 File Offset: 0x000B9638
			// (set) Token: 0x06003745 RID: 14149 RVA: 0x00013E80 File Offset: 0x00012080
			public unsafe static Func<FieldInfo, Enum> __9__2_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, Enum>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A20 RID: 2592
			// (get) Token: 0x06003746 RID: 14150 RVA: 0x000BB460 File Offset: 0x000B9660
			// (set) Token: 0x06003747 RID: 14151 RVA: 0x00013E92 File Offset: 0x00012092
			public unsafe static Func<Enum, int> __9__2_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Enum, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A21 RID: 2593
			// (get) Token: 0x06003748 RID: 14152 RVA: 0x000BB488 File Offset: 0x000B9688
			// (set) Token: 0x06003749 RID: 14153 RVA: 0x00013EA4 File Offset: 0x000120A4
			public unsafe static Func<Enum, int> __9__2_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Enum, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C49 RID: 11337
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002C4A RID: 11338
			private static readonly IntPtr NativeFieldInfoPtr___9__2_5;

			// Token: 0x04002C4B RID: 11339
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04002C4C RID: 11340
			private static readonly IntPtr NativeFieldInfoPtr___9__2_2;

			// Token: 0x04002C4D RID: 11341
			private static readonly IntPtr NativeFieldInfoPtr___9__2_3;

			// Token: 0x04002C4E RID: 11342
			private static readonly IntPtr NativeFieldInfoPtr___9__2_4;

			// Token: 0x04002C4F RID: 11343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C50 RID: 11344
			private static readonly IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_5_Internal_Int32_FieldInfo_0;

			// Token: 0x04002C51 RID: 11345
			private static readonly IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_1_Internal_String_FieldInfo_0;

			// Token: 0x04002C52 RID: 11346
			private static readonly IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_2_Internal_Enum_FieldInfo_0;

			// Token: 0x04002C53 RID: 11347
			private static readonly IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_3_Internal_Int32_Enum_0;

			// Token: 0x04002C54 RID: 11348
			private static readonly IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_4_Internal_Int32_Enum_0;
		}

		// Token: 0x0200073D RID: 1853
		[ObfuscatedName("UnityEngine.EnumDataUtility+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600374A RID: 14154 RVA: 0x000BB4B0 File Offset: 0x000B96B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr);
				EnumDataUtility.__c__DisplayClass2_0.NativeFieldInfoPtr_nicifyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr, "nicifyName");
				EnumDataUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr, 100666602);
				EnumDataUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__GetCachedEnumData_b__0_Internal_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr, 100666603);
			}

			// Token: 0x0600374B RID: 14155 RVA: 0x000BB518 File Offset: 0x000B9718
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600374C RID: 14156 RVA: 0x000BB554 File Offset: 0x000B9754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 664389, XrefRangeEnd = 664421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetCachedEnumData_b__0(FieldInfo f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__GetCachedEnumData_b__0_Internal_String_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600374D RID: 14157 RVA: 0x00013EB6 File Offset: 0x000120B6
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A22 RID: 2594
			// (get) Token: 0x0600374E RID: 14158 RVA: 0x000BB59C File Offset: 0x000B979C
			// (set) Token: 0x0600374F RID: 14159 RVA: 0x00013EBF File Offset: 0x000120BF
			public unsafe Func<string, string> nicifyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass2_0.NativeFieldInfoPtr_nicifyName);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass2_0.NativeFieldInfoPtr_nicifyName), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C55 RID: 11349
			private static readonly IntPtr NativeFieldInfoPtr_nicifyName;

			// Token: 0x04002C56 RID: 11350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C57 RID: 11351
			private static readonly IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__0_Internal_String_FieldInfo_0;
		}

		// Token: 0x0200073E RID: 1854
		[ObfuscatedName("UnityEngine.EnumDataUtility+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : ValueType
		{
			// Token: 0x06003750 RID: 14160 RVA: 0x000BB5CC File Offset: 0x000B97CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr);
				EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_nicifyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr, "nicifyName");
				EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr, "field");
			}

			// Token: 0x06003751 RID: 14161 RVA: 0x00013EDE File Offset: 0x000120DE
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003752 RID: 14162 RVA: 0x00013EE7 File Offset: 0x000120E7
			public __c__DisplayClass8_0()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr))
			{
			}

			// Token: 0x17000A23 RID: 2595
			// (get) Token: 0x06003753 RID: 14163 RVA: 0x000BB620 File Offset: 0x000B9820
			// (set) Token: 0x06003754 RID: 14164 RVA: 0x00013EF9 File Offset: 0x000120F9
			public unsafe Func<string, string> nicifyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_nicifyName);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_nicifyName), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A24 RID: 2596
			// (get) Token: 0x06003755 RID: 14165 RVA: 0x000BB650 File Offset: 0x000B9850
			// (set) Token: 0x06003756 RID: 14166 RVA: 0x00013F18 File Offset: 0x00012118
			public unsafe FieldInfo field
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_field);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_field), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C58 RID: 11352
			private static readonly IntPtr NativeFieldInfoPtr_nicifyName;

			// Token: 0x04002C59 RID: 11353
			private static readonly IntPtr NativeFieldInfoPtr_field;
		}

		// Token: 0x0200073F RID: 1855
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x02000740 RID: 1856
		public sealed class <>c__DisplayClass2_0
		{
		}
	}
}
