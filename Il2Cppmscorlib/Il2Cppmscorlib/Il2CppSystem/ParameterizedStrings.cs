using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000166 RID: 358
	public static class ParameterizedStrings : Object
	{
		// Token: 0x06001891 RID: 6289 RVA: 0x00099E40 File Offset: 0x00098040
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterizedStrings()
		{
			Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParameterizedStrings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr);
			ParameterizedStrings.NativeFieldInfoPtr__cachedStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, "_cachedStack");
			ParameterizedStrings.NativeMethodInfoPtr_Evaluate_Public_Static_String_String_Il2CppReferenceArray_1_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667544);
			ParameterizedStrings.NativeMethodInfoPtr_EvaluateInternal_Private_Static_String_String_byref_Int32_Il2CppReferenceArray_1_FormatParam_LowLevelStack_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667545);
			ParameterizedStrings.NativeMethodInfoPtr_AsBool_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667546);
			ParameterizedStrings.NativeMethodInfoPtr_AsInt_Private_Static_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667547);
			ParameterizedStrings.NativeMethodInfoPtr_StringFromAsciiBytes_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667548);
			ParameterizedStrings.NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667549);
			ParameterizedStrings.NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667550);
			ParameterizedStrings.NativeMethodInfoPtr_FormatPrintF_Private_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667551);
			ParameterizedStrings.NativeMethodInfoPtr_GetDynamicOrStaticVariables_Private_Static_Il2CppReferenceArray_1_FormatParam_Char_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, 100667552);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00099F38 File Offset: 0x00098138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349255, XrefRangeEnd = 1349273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Evaluate(string format, [Optional] Il2CppReferenceArray<ParameterizedStrings.FormatParam> args)
		{
			if (args == null)
			{
				args = new Il2CppStructArray<ParameterizedStrings.FormatParam>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_Evaluate_Public_Static_String_String_Il2CppReferenceArray_1_FormatParam_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00099F94 File Offset: 0x00098194
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1349400, RefRangeEnd = 1349404, XrefRangeStart = 1349273, XrefRangeEnd = 1349400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EvaluateInternal(string format, ref int pos, Il2CppReferenceArray<ParameterizedStrings.FormatParam> args, ParameterizedStrings.LowLevelStack stack, ref Il2CppReferenceArray<ParameterizedStrings.FormatParam> dynamicVars, ref Il2CppReferenceArray<ParameterizedStrings.FormatParam> staticVars)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stack);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dynamicVars);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(staticVars);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_EvaluateInternal_Private_Static_String_String_byref_Int32_Il2CppReferenceArray_1_FormatParam_LowLevelStack_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			dynamicVars = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			staticVars = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(intPtr6));
			return IL2CPP.Il2CppStringToManaged(intPtr3);
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x0009A058 File Offset: 0x00098258
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1300554, RefRangeEnd = 1300560, XrefRangeStart = 1300554, XrefRangeEnd = 1300560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AsBool(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_AsBool_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0009A098 File Offset: 0x00098298
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1300759, RefRangeEnd = 1300773, XrefRangeStart = 1300759, XrefRangeEnd = 1300773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AsInt(bool b)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_AsInt_Private_Static_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0009A0D8 File Offset: 0x000982D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349404, XrefRangeEnd = 1349410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StringFromAsciiBytes(Il2CppStructArray<byte> buffer, int offset, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_StringFromAsciiBytes_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x0009A130 File Offset: 0x00098330
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1349415, RefRangeEnd = 1349417, XrefRangeStart = 1349410, XrefRangeEnd = 1349415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int snprintf(byte* str, IntPtr size, string format, string arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = str;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x0009A1A0 File Offset: 0x000983A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1349420, RefRangeEnd = 1349422, XrefRangeStart = 1349417, XrefRangeEnd = 1349420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int snprintf(byte* str, IntPtr size, string format, int arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = str;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arg1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0009A20C File Offset: 0x0009840C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1349444, RefRangeEnd = 1349445, XrefRangeStart = 1349422, XrefRangeEnd = 1349444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatPrintF(string format, Object arg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_FormatPrintF_Private_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x0009A25C File Offset: 0x0009845C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1349452, RefRangeEnd = 1349454, XrefRangeStart = 1349445, XrefRangeEnd = 1349452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ParameterizedStrings.FormatParam> GetDynamicOrStaticVariables(char c, ref Il2CppReferenceArray<ParameterizedStrings.FormatParam> dynamicVars, ref Il2CppReferenceArray<ParameterizedStrings.FormatParam> staticVars, out int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dynamicVars);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(staticVars);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.NativeMethodInfoPtr_GetDynamicOrStaticVariables_Private_Static_Il2CppReferenceArray_1_FormatParam_Char_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_byref_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			dynamicVars = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			staticVars = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(intPtr6));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterizedStrings.FormatParam>>(intPtr7) : null;
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00007DC7 File Offset: 0x00005FC7
		public static string Evaluate(string format, params ParameterizedStrings.FormatParam[] args)
		{
			return ParameterizedStrings.Evaluate(format, new Il2CppReferenceArray<ParameterizedStrings.FormatParam>(args));
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00007DD5 File Offset: 0x00005FD5
		public ParameterizedStrings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x0009A2FC File Offset: 0x000984FC
		// (set) Token: 0x0600189E RID: 6302 RVA: 0x00007DDE File Offset: 0x00005FDE
		public unsafe static ParameterizedStrings.LowLevelStack _cachedStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ParameterizedStrings.NativeFieldInfoPtr__cachedStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParameterizedStrings.LowLevelStack>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParameterizedStrings.NativeFieldInfoPtr__cachedStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeFieldInfoPtr__cachedStack;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Static_String_String_Il2CppReferenceArray_1_FormatParam_0;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateInternal_Private_Static_String_String_byref_Int32_Il2CppReferenceArray_1_FormatParam_LowLevelStack_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_0;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeMethodInfoPtr_AsBool_Private_Static_Boolean_Int32_0;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeMethodInfoPtr_AsInt_Private_Static_Int32_Boolean_0;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeMethodInfoPtr_StringFromAsciiBytes_Private_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_String_0;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeMethodInfoPtr_snprintf_Private_Static_Int32_ptr_Byte_IntPtr_String_Int32_0;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeMethodInfoPtr_FormatPrintF_Private_Static_String_String_Object_0;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicOrStaticVariables_Private_Static_Il2CppReferenceArray_1_FormatParam_Char_byref_Il2CppReferenceArray_1_FormatParam_byref_Il2CppReferenceArray_1_FormatParam_byref_Int32_0;

		// Token: 0x020005F6 RID: 1526
		public sealed class FormatParam : ValueType
		{
			// Token: 0x060057BA RID: 22458 RVA: 0x00194054 File Offset: 0x00192254
			// Note: this type is marked as 'beforefieldinit'.
			static FormatParam()
			{
				Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, "FormatParam");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr);
				ParameterizedStrings.FormatParam.NativeFieldInfoPtr__int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, "_int32");
				ParameterizedStrings.FormatParam.NativeFieldInfoPtr__string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, "_string");
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667553);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667554);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr_op_Implicit_Public_Static_FormatParam_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667555);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_Int32_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667556);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_String_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667557);
				ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_Object_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr, 100667558);
			}

			// Token: 0x060057BB RID: 22459 RVA: 0x00194120 File Offset: 0x00192320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349217, XrefRangeEnd = 1349218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FormatParam(int value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060057BC RID: 22460 RVA: 0x0019416C File Offset: 0x0019236C
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 344943, RefRangeEnd = 345022, XrefRangeStart = 344943, XrefRangeEnd = 345022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FormatParam(int intValue, string stringValue)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref intValue;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringValue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057BD RID: 22461 RVA: 0x001941CC File Offset: 0x001923CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe static implicit operator ParameterizedStrings.FormatParam(int value)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr_op_Implicit_Public_Static_FormatParam_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ParameterizedStrings.FormatParam(intPtr);
				}
			}

			// Token: 0x17001662 RID: 5730
			// (get) Token: 0x060057BE RID: 22462 RVA: 0x00194204 File Offset: 0x00192404
			public unsafe int Int32
			{
				[CallerCount(200)]
				[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_Int32_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001663 RID: 5731
			// (get) Token: 0x060057BF RID: 22463 RVA: 0x00194248 File Offset: 0x00192448
			public unsafe string String
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349218, XrefRangeEnd = 1349220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_String_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17001664 RID: 5732
			// (get) Token: 0x060057C0 RID: 22464 RVA: 0x00194284 File Offset: 0x00192484
			public unsafe Object Object
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349220, XrefRangeEnd = 1349223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.FormatParam.NativeMethodInfoPtr_get_Object_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060057C1 RID: 22465 RVA: 0x0001F362 File Offset: 0x0001D562
			public FormatParam(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060057C2 RID: 22466 RVA: 0x0001F36B File Offset: 0x0001D56B
			public FormatParam()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedStrings.FormatParam>.NativeClassPtr))
			{
			}

			// Token: 0x17001660 RID: 5728
			// (get) Token: 0x060057C3 RID: 22467 RVA: 0x001942C8 File Offset: 0x001924C8
			// (set) Token: 0x060057C4 RID: 22468 RVA: 0x0001F37D File Offset: 0x0001D57D
			public unsafe int _int32
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.FormatParam.NativeFieldInfoPtr__int32);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.FormatParam.NativeFieldInfoPtr__int32)) = value;
				}
			}

			// Token: 0x17001661 RID: 5729
			// (get) Token: 0x060057C5 RID: 22469 RVA: 0x001942F0 File Offset: 0x001924F0
			// (set) Token: 0x060057C6 RID: 22470 RVA: 0x0001F398 File Offset: 0x0001D598
			public unsafe string _string
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.FormatParam.NativeFieldInfoPtr__string);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.FormatParam.NativeFieldInfoPtr__string), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400482F RID: 18479
			private static readonly IntPtr NativeFieldInfoPtr__int32;

			// Token: 0x04004830 RID: 18480
			private static readonly IntPtr NativeFieldInfoPtr__string;

			// Token: 0x04004831 RID: 18481
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004832 RID: 18482
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_String_0;

			// Token: 0x04004833 RID: 18483
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_FormatParam_Int32_0;

			// Token: 0x04004834 RID: 18484
			private static readonly IntPtr NativeMethodInfoPtr_get_Int32_Public_get_Int32_0;

			// Token: 0x04004835 RID: 18485
			private static readonly IntPtr NativeMethodInfoPtr_get_String_Public_get_String_0;

			// Token: 0x04004836 RID: 18486
			private static readonly IntPtr NativeMethodInfoPtr_get_Object_Public_get_Object_0;
		}

		// Token: 0x020005F7 RID: 1527
		public sealed class LowLevelStack : Object
		{
			// Token: 0x060057C7 RID: 22471 RVA: 0x00194318 File Offset: 0x00192518
			// Note: this type is marked as 'beforefieldinit'.
			static LowLevelStack()
			{
				Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParameterizedStrings>.NativeClassPtr, "LowLevelStack");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr);
				ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__arr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, "_arr");
				ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, "_count");
				ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, 100667559);
				ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Pop_Public_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, 100667560);
				ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Push_Public_Void_FormatParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, 100667561);
				ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr, 100667562);
			}

			// Token: 0x060057C8 RID: 22472 RVA: 0x001943BC File Offset: 0x001925BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349223, XrefRangeEnd = 1349227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LowLevelStack()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedStrings.LowLevelStack>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057C9 RID: 22473 RVA: 0x001943F8 File Offset: 0x001925F8
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1349227, RefRangeEnd = 1349239, XrefRangeStart = 1349227, XrefRangeEnd = 1349227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParameterizedStrings.FormatParam Pop()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Pop_Public_FormatParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParameterizedStrings.FormatParam(intPtr);
			}

			// Token: 0x060057CA RID: 22474 RVA: 0x00194430 File Offset: 0x00192630
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1349247, RefRangeEnd = 1349254, XrefRangeStart = 1349239, XrefRangeEnd = 1349247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Push(ParameterizedStrings.FormatParam item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Push_Public_Void_FormatParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060057CB RID: 22475 RVA: 0x00194478 File Offset: 0x00192678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1349254, XrefRangeEnd = 1349255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedStrings.LowLevelStack.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060057CC RID: 22476 RVA: 0x0001F3B7 File Offset: 0x0001D5B7
			public LowLevelStack(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001665 RID: 5733
			// (get) Token: 0x060057CD RID: 22477 RVA: 0x001944AC File Offset: 0x001926AC
			// (set) Token: 0x060057CE RID: 22478 RVA: 0x0001F3C0 File Offset: 0x0001D5C0
			public unsafe Il2CppReferenceArray<ParameterizedStrings.FormatParam> _arr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__arr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParameterizedStrings.FormatParam>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__arr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001666 RID: 5734
			// (get) Token: 0x060057CF RID: 22479 RVA: 0x001944DC File Offset: 0x001926DC
			// (set) Token: 0x060057D0 RID: 22480 RVA: 0x0001F3DF File Offset: 0x0001D5DF
			public unsafe int _count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterizedStrings.LowLevelStack.NativeFieldInfoPtr__count)) = value;
				}
			}

			// Token: 0x04004837 RID: 18487
			private static readonly IntPtr NativeFieldInfoPtr__arr;

			// Token: 0x04004838 RID: 18488
			private static readonly IntPtr NativeFieldInfoPtr__count;

			// Token: 0x04004839 RID: 18489
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400483A RID: 18490
			private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_FormatParam_0;

			// Token: 0x0400483B RID: 18491
			private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_FormatParam_0;

			// Token: 0x0400483C RID: 18492
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
		}
	}
}
