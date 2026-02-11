using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x0200017F RID: 383
	public static class ComputedTransitionUtils : Object
	{
		// Token: 0x06001CE2 RID: 7394 RVA: 0x00083D0C File Offset: 0x00081F0C
		// Note: this type is marked as 'beforefieldinit'.
		static ComputedTransitionUtils()
		{
			Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ComputedTransitionUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr);
			ComputedTransitionUtils.NativeFieldInfoPtr_s_ComputedTransitionsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, "s_ComputedTransitionsBuffer");
			ComputedTransitionUtils.NativeMethodInfoPtr_UpdateComputedTransitions_Internal_Static_Void_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, 100667517);
			ComputedTransitionUtils.NativeMethodInfoPtr_HasTransitionProperty_Internal_Static_Boolean_byref_ComputedStyle_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, 100667518);
			ComputedTransitionUtils.NativeMethodInfoPtr_GetTransitionProperty_Internal_Static_Boolean_byref_ComputedStyle_StylePropertyId_byref_ComputedTransitionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, 100667519);
			ComputedTransitionUtils.NativeMethodInfoPtr_GetOrComputeTransitionPropertyData_Private_Static_Il2CppReferenceArray_1_ComputedTransitionProperty_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, 100667520);
			ComputedTransitionUtils.NativeMethodInfoPtr_GetTransitionHashCode_Private_Static_Int32_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, 100667521);
			ComputedTransitionUtils.NativeMethodInfoPtr_SameTransitionProperty_Internal_Static_Boolean_byref_ComputedStyle_byref_ComputedStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, 100667522);
			ComputedTransitionUtils.NativeMethodInfoPtr_SameTransitionProperty_Private_Static_Boolean_List_1_StylePropertyName_List_1_StylePropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, 100667523);
			ComputedTransitionUtils.NativeMethodInfoPtr_SameTransitionProperty_Private_Static_Boolean_List_1_TimeValue_List_1_TimeValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, 100667524);
			ComputedTransitionUtils.NativeMethodInfoPtr_ComputeTransitionPropertyData_Private_Static_Void_byref_ComputedStyle_List_1_ComputedTransitionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, 100667525);
			ComputedTransitionUtils.NativeMethodInfoPtr_GetWrappingTransitionData_Private_Static_T_List_1_T_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, 100667526);
			ComputedTransitionUtils.NativeMethodInfoPtr_ConvertTransitionTime_Private_Static_Int32_TimeValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, 100667527);
			ComputedTransitionUtils.NativeMethodInfoPtr_ConvertTransitionFunction_Private_Static_Func_2_Single_Single_EasingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, 100667528);
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00083E40 File Offset: 0x00082040
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 327875, RefRangeEnd = 327880, XrefRangeStart = 327844, XrefRangeEnd = 327875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateComputedTransitions(ref ComputedStyle computedStyle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.NativeMethodInfoPtr_UpdateComputedTransitions_Internal_Static_Void_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00083E78 File Offset: 0x00082078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327884, RefRangeEnd = 327885, XrefRangeStart = 327880, XrefRangeEnd = 327884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasTransitionProperty(this ComputedStyle computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.NativeMethodInfoPtr_HasTransitionProperty_Internal_Static_Boolean_byref_ComputedStyle_StylePropertyId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00083EC8 File Offset: 0x000820C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 327889, RefRangeEnd = 327892, XrefRangeStart = 327885, XrefRangeEnd = 327889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetTransitionProperty(this ComputedStyle computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id, out ComputedTransitionProperty result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.NativeMethodInfoPtr_GetTransitionProperty_Internal_Static_Boolean_byref_ComputedStyle_StylePropertyId_byref_ComputedTransitionProperty_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new ComputedTransitionProperty(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00083F3C File Offset: 0x0008213C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327892, XrefRangeEnd = 327919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ComputedTransitionProperty> GetOrComputeTransitionPropertyData(ref ComputedStyle computedStyle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.NativeMethodInfoPtr_GetOrComputeTransitionPropertyData_Private_Static_Il2CppReferenceArray_1_ComputedTransitionProperty_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ComputedTransitionProperty>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00083F84 File Offset: 0x00082184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327978, RefRangeEnd = 327980, XrefRangeStart = 327919, XrefRangeEnd = 327978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetTransitionHashCode(ref ComputedStyle cs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(cs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.NativeMethodInfoPtr_GetTransitionHashCode_Private_Static_Int32_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00083FC8 File Offset: 0x000821C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327981, RefRangeEnd = 327983, XrefRangeStart = 327980, XrefRangeEnd = 327981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SameTransitionProperty(ref ComputedStyle x, ref ComputedStyle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.NativeMethodInfoPtr_SameTransitionProperty_Internal_Static_Boolean_byref_ComputedStyle_byref_ComputedStyle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x00084020 File Offset: 0x00082220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327983, XrefRangeEnd = 327990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SameTransitionProperty(List<StylePropertyName> a, List<StylePropertyName> b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.NativeMethodInfoPtr_SameTransitionProperty_Private_Static_Boolean_List_1_StylePropertyName_List_1_StylePropertyName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00084074 File Offset: 0x00082274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327990, XrefRangeEnd = 327997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SameTransitionProperty(List<TimeValue> a, List<TimeValue> b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.NativeMethodInfoPtr_SameTransitionProperty_Private_Static_Boolean_List_1_TimeValue_List_1_TimeValue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x000840C8 File Offset: 0x000822C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328031, RefRangeEnd = 328033, XrefRangeStart = 327997, XrefRangeEnd = 328031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ComputeTransitionPropertyData(ref ComputedStyle computedStyle, List<ComputedTransitionProperty> outData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(computedStyle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.NativeMethodInfoPtr_ComputeTransitionPropertyData_Private_Static_Void_byref_ComputedStyle_List_1_ComputedTransitionProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00084114 File Offset: 0x00082314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328035, RefRangeEnd = 328036, XrefRangeStart = 328033, XrefRangeEnd = 328035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetWrappingTransitionData<T>(List<T> list, int i, T defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.MethodInfoStoreGeneric_GetWrappingTransitionData_Private_Static_T_List_1_T_Int32_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000841A8 File Offset: 0x000823A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 328036, XrefRangeEnd = 328037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConvertTransitionTime(TimeValue time)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.NativeMethodInfoPtr_ConvertTransitionTime_Private_Static_Int32_TimeValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x000841E8 File Offset: 0x000823E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 328338, RefRangeEnd = 328339, XrefRangeStart = 328037, XrefRangeEnd = 328338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<float, float> ConvertTransitionFunction(EasingMode mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.NativeMethodInfoPtr_ConvertTransitionFunction_Private_Static_Func_2_Single_Single_EasingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0000CD92 File Offset: 0x0000AF92
		public ComputedTransitionUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x00084228 File Offset: 0x00082428
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x0000CD9B File Offset: 0x0000AF9B
		public unsafe static List<ComputedTransitionProperty> s_ComputedTransitionsBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.NativeFieldInfoPtr_s_ComputedTransitionsBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ComputedTransitionProperty>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.NativeFieldInfoPtr_s_ComputedTransitionsBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeFieldInfoPtr_s_ComputedTransitionsBuffer;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr_UpdateComputedTransitions_Internal_Static_Void_byref_ComputedStyle_0;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeMethodInfoPtr_HasTransitionProperty_Internal_Static_Boolean_byref_ComputedStyle_StylePropertyId_0;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeMethodInfoPtr_GetTransitionProperty_Internal_Static_Boolean_byref_ComputedStyle_StylePropertyId_byref_ComputedTransitionProperty_0;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeMethodInfoPtr_GetOrComputeTransitionPropertyData_Private_Static_Il2CppReferenceArray_1_ComputedTransitionProperty_byref_ComputedStyle_0;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeMethodInfoPtr_GetTransitionHashCode_Private_Static_Int32_byref_ComputedStyle_0;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_SameTransitionProperty_Internal_Static_Boolean_byref_ComputedStyle_byref_ComputedStyle_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_SameTransitionProperty_Private_Static_Boolean_List_1_StylePropertyName_List_1_StylePropertyName_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr_SameTransitionProperty_Private_Static_Boolean_List_1_TimeValue_List_1_TimeValue_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr_ComputeTransitionPropertyData_Private_Static_Void_byref_ComputedStyle_List_1_ComputedTransitionProperty_0;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr_GetWrappingTransitionData_Private_Static_T_List_1_T_Int32_T_0;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTransitionTime_Private_Static_Int32_TimeValue_0;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTransitionFunction_Private_Static_Func_2_Single_Single_EasingMode_0;

		// Token: 0x0200049E RID: 1182
		[ObfuscatedName("UnityEngine.UIElements.ComputedTransitionUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003D1C RID: 15644 RVA: 0x000F3DB0 File Offset: 0x000F1FB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr);
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_0");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_1");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_2");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_3");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_4");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_5");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_6");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_7");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_8");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_9");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_10");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_11");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_12");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_13");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_14");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_15");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_16");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_17");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_18");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_19");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_20");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_21 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_21");
				ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_22 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, "<>9__12_22");
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667531);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_0_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667532);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_1_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667533);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_2_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667534);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_3_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667535);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_4_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667536);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_5_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667537);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_6_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667538);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_7_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667539);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_8_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667540);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_9_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667541);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_10_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667542);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_11_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667543);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_12_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667544);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_13_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667545);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_14_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667546);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_15_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667547);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_16_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667548);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_17_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667549);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_18_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667550);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_19_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667551);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_20_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667552);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_21_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667553);
				ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_22_Internal_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr, 100667554);
			}

			// Token: 0x06003D1D RID: 15645 RVA: 0x000F419C File Offset: 0x000F239C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputedTransitionUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003D1E RID: 15646 RVA: 0x000F41D8 File Offset: 0x000F23D8
			[CallerCount(0)]
			public unsafe float _ConvertTransitionFunction_b__12_0(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_0_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D1F RID: 15647 RVA: 0x000F4224 File Offset: 0x000F2424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327822, XrefRangeEnd = 327823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_1(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_1_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D20 RID: 15648 RVA: 0x000F4270 File Offset: 0x000F2470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327823, XrefRangeEnd = 327824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_2(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_2_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D21 RID: 15649 RVA: 0x000F42BC File Offset: 0x000F24BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327824, XrefRangeEnd = 327825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_3(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_3_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D22 RID: 15650 RVA: 0x000F4308 File Offset: 0x000F2508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327825, XrefRangeEnd = 327826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_4(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_4_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D23 RID: 15651 RVA: 0x000F4354 File Offset: 0x000F2554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327826, XrefRangeEnd = 327827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_5(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_5_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D24 RID: 15652 RVA: 0x000F43A0 File Offset: 0x000F25A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327827, XrefRangeEnd = 327828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_6(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_6_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D25 RID: 15653 RVA: 0x000F43EC File Offset: 0x000F25EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327828, XrefRangeEnd = 327829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_7(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_7_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D26 RID: 15654 RVA: 0x000F4438 File Offset: 0x000F2638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327829, XrefRangeEnd = 327830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_8(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_8_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D27 RID: 15655 RVA: 0x000F4484 File Offset: 0x000F2684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327830, XrefRangeEnd = 327831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_9(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_9_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D28 RID: 15656 RVA: 0x000F44D0 File Offset: 0x000F26D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327831, XrefRangeEnd = 327832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_10(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_10_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D29 RID: 15657 RVA: 0x000F451C File Offset: 0x000F271C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327832, XrefRangeEnd = 327833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_11(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_11_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D2A RID: 15658 RVA: 0x000F4568 File Offset: 0x000F2768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327833, XrefRangeEnd = 327834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_12(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_12_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D2B RID: 15659 RVA: 0x000F45B4 File Offset: 0x000F27B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327834, XrefRangeEnd = 327835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_13(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_13_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D2C RID: 15660 RVA: 0x000F4600 File Offset: 0x000F2800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327835, XrefRangeEnd = 327836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_14(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_14_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D2D RID: 15661 RVA: 0x000F464C File Offset: 0x000F284C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327836, XrefRangeEnd = 327837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_15(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_15_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D2E RID: 15662 RVA: 0x000F4698 File Offset: 0x000F2898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327837, XrefRangeEnd = 327838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_16(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_16_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D2F RID: 15663 RVA: 0x000F46E4 File Offset: 0x000F28E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327838, XrefRangeEnd = 327839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_17(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_17_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D30 RID: 15664 RVA: 0x000F4730 File Offset: 0x000F2930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327839, XrefRangeEnd = 327840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_18(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_18_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D31 RID: 15665 RVA: 0x000F477C File Offset: 0x000F297C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327840, XrefRangeEnd = 327841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_19(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_19_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D32 RID: 15666 RVA: 0x000F47C8 File Offset: 0x000F29C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327841, XrefRangeEnd = 327842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_20(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_20_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D33 RID: 15667 RVA: 0x000F4814 File Offset: 0x000F2A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327842, XrefRangeEnd = 327843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_21(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_21_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D34 RID: 15668 RVA: 0x000F4860 File Offset: 0x000F2A60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327843, XrefRangeEnd = 327844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _ConvertTransitionFunction_b__12_22(float t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComputedTransitionUtils.__c.NativeMethodInfoPtr__ConvertTransitionFunction_b__12_22_Internal_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003D35 RID: 15669 RVA: 0x00019C18 File Offset: 0x00017E18
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001283 RID: 4739
			// (get) Token: 0x06003D36 RID: 15670 RVA: 0x000F48AC File Offset: 0x000F2AAC
			// (set) Token: 0x06003D37 RID: 15671 RVA: 0x00019C21 File Offset: 0x00017E21
			public unsafe static ComputedTransitionUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputedTransitionUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001284 RID: 4740
			// (get) Token: 0x06003D38 RID: 15672 RVA: 0x000F48D4 File Offset: 0x000F2AD4
			// (set) Token: 0x06003D39 RID: 15673 RVA: 0x00019C33 File Offset: 0x00017E33
			public unsafe static Func<float, float> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001285 RID: 4741
			// (get) Token: 0x06003D3A RID: 15674 RVA: 0x000F48FC File Offset: 0x000F2AFC
			// (set) Token: 0x06003D3B RID: 15675 RVA: 0x00019C45 File Offset: 0x00017E45
			public unsafe static Func<float, float> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001286 RID: 4742
			// (get) Token: 0x06003D3C RID: 15676 RVA: 0x000F4924 File Offset: 0x000F2B24
			// (set) Token: 0x06003D3D RID: 15677 RVA: 0x00019C57 File Offset: 0x00017E57
			public unsafe static Func<float, float> __9__12_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001287 RID: 4743
			// (get) Token: 0x06003D3E RID: 15678 RVA: 0x000F494C File Offset: 0x000F2B4C
			// (set) Token: 0x06003D3F RID: 15679 RVA: 0x00019C69 File Offset: 0x00017E69
			public unsafe static Func<float, float> __9__12_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001288 RID: 4744
			// (get) Token: 0x06003D40 RID: 15680 RVA: 0x000F4974 File Offset: 0x000F2B74
			// (set) Token: 0x06003D41 RID: 15681 RVA: 0x00019C7B File Offset: 0x00017E7B
			public unsafe static Func<float, float> __9__12_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001289 RID: 4745
			// (get) Token: 0x06003D42 RID: 15682 RVA: 0x000F499C File Offset: 0x000F2B9C
			// (set) Token: 0x06003D43 RID: 15683 RVA: 0x00019C8D File Offset: 0x00017E8D
			public unsafe static Func<float, float> __9__12_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700128A RID: 4746
			// (get) Token: 0x06003D44 RID: 15684 RVA: 0x000F49C4 File Offset: 0x000F2BC4
			// (set) Token: 0x06003D45 RID: 15685 RVA: 0x00019C9F File Offset: 0x00017E9F
			public unsafe static Func<float, float> __9__12_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700128B RID: 4747
			// (get) Token: 0x06003D46 RID: 15686 RVA: 0x000F49EC File Offset: 0x000F2BEC
			// (set) Token: 0x06003D47 RID: 15687 RVA: 0x00019CB1 File Offset: 0x00017EB1
			public unsafe static Func<float, float> __9__12_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700128C RID: 4748
			// (get) Token: 0x06003D48 RID: 15688 RVA: 0x000F4A14 File Offset: 0x000F2C14
			// (set) Token: 0x06003D49 RID: 15689 RVA: 0x00019CC3 File Offset: 0x00017EC3
			public unsafe static Func<float, float> __9__12_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700128D RID: 4749
			// (get) Token: 0x06003D4A RID: 15690 RVA: 0x000F4A3C File Offset: 0x000F2C3C
			// (set) Token: 0x06003D4B RID: 15691 RVA: 0x00019CD5 File Offset: 0x00017ED5
			public unsafe static Func<float, float> __9__12_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700128E RID: 4750
			// (get) Token: 0x06003D4C RID: 15692 RVA: 0x000F4A64 File Offset: 0x000F2C64
			// (set) Token: 0x06003D4D RID: 15693 RVA: 0x00019CE7 File Offset: 0x00017EE7
			public unsafe static Func<float, float> __9__12_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700128F RID: 4751
			// (get) Token: 0x06003D4E RID: 15694 RVA: 0x000F4A8C File Offset: 0x000F2C8C
			// (set) Token: 0x06003D4F RID: 15695 RVA: 0x00019CF9 File Offset: 0x00017EF9
			public unsafe static Func<float, float> __9__12_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001290 RID: 4752
			// (get) Token: 0x06003D50 RID: 15696 RVA: 0x000F4AB4 File Offset: 0x000F2CB4
			// (set) Token: 0x06003D51 RID: 15697 RVA: 0x00019D0B File Offset: 0x00017F0B
			public unsafe static Func<float, float> __9__12_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001291 RID: 4753
			// (get) Token: 0x06003D52 RID: 15698 RVA: 0x000F4ADC File Offset: 0x000F2CDC
			// (set) Token: 0x06003D53 RID: 15699 RVA: 0x00019D1D File Offset: 0x00017F1D
			public unsafe static Func<float, float> __9__12_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001292 RID: 4754
			// (get) Token: 0x06003D54 RID: 15700 RVA: 0x000F4B04 File Offset: 0x000F2D04
			// (set) Token: 0x06003D55 RID: 15701 RVA: 0x00019D2F File Offset: 0x00017F2F
			public unsafe static Func<float, float> __9__12_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001293 RID: 4755
			// (get) Token: 0x06003D56 RID: 15702 RVA: 0x000F4B2C File Offset: 0x000F2D2C
			// (set) Token: 0x06003D57 RID: 15703 RVA: 0x00019D41 File Offset: 0x00017F41
			public unsafe static Func<float, float> __9__12_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001294 RID: 4756
			// (get) Token: 0x06003D58 RID: 15704 RVA: 0x000F4B54 File Offset: 0x000F2D54
			// (set) Token: 0x06003D59 RID: 15705 RVA: 0x00019D53 File Offset: 0x00017F53
			public unsafe static Func<float, float> __9__12_16
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_16, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_16, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001295 RID: 4757
			// (get) Token: 0x06003D5A RID: 15706 RVA: 0x000F4B7C File Offset: 0x000F2D7C
			// (set) Token: 0x06003D5B RID: 15707 RVA: 0x00019D65 File Offset: 0x00017F65
			public unsafe static Func<float, float> __9__12_17
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_17, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_17, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001296 RID: 4758
			// (get) Token: 0x06003D5C RID: 15708 RVA: 0x000F4BA4 File Offset: 0x000F2DA4
			// (set) Token: 0x06003D5D RID: 15709 RVA: 0x00019D77 File Offset: 0x00017F77
			public unsafe static Func<float, float> __9__12_18
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_18, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_18, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001297 RID: 4759
			// (get) Token: 0x06003D5E RID: 15710 RVA: 0x000F4BCC File Offset: 0x000F2DCC
			// (set) Token: 0x06003D5F RID: 15711 RVA: 0x00019D89 File Offset: 0x00017F89
			public unsafe static Func<float, float> __9__12_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001298 RID: 4760
			// (get) Token: 0x06003D60 RID: 15712 RVA: 0x000F4BF4 File Offset: 0x000F2DF4
			// (set) Token: 0x06003D61 RID: 15713 RVA: 0x00019D9B File Offset: 0x00017F9B
			public unsafe static Func<float, float> __9__12_20
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_20, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_20, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001299 RID: 4761
			// (get) Token: 0x06003D62 RID: 15714 RVA: 0x000F4C1C File Offset: 0x000F2E1C
			// (set) Token: 0x06003D63 RID: 15715 RVA: 0x00019DAD File Offset: 0x00017FAD
			public unsafe static Func<float, float> __9__12_21
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_21, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_21, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700129A RID: 4762
			// (get) Token: 0x06003D64 RID: 15716 RVA: 0x000F4C44 File Offset: 0x000F2E44
			// (set) Token: 0x06003D65 RID: 15717 RVA: 0x00019DBF File Offset: 0x00017FBF
			public unsafe static Func<float, float> __9__12_22
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_22, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ComputedTransitionUtils.__c.NativeFieldInfoPtr___9__12_22, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B2E RID: 11054
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002B2F RID: 11055
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04002B30 RID: 11056
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04002B31 RID: 11057
			private static readonly IntPtr NativeFieldInfoPtr___9__12_2;

			// Token: 0x04002B32 RID: 11058
			private static readonly IntPtr NativeFieldInfoPtr___9__12_3;

			// Token: 0x04002B33 RID: 11059
			private static readonly IntPtr NativeFieldInfoPtr___9__12_4;

			// Token: 0x04002B34 RID: 11060
			private static readonly IntPtr NativeFieldInfoPtr___9__12_5;

			// Token: 0x04002B35 RID: 11061
			private static readonly IntPtr NativeFieldInfoPtr___9__12_6;

			// Token: 0x04002B36 RID: 11062
			private static readonly IntPtr NativeFieldInfoPtr___9__12_7;

			// Token: 0x04002B37 RID: 11063
			private static readonly IntPtr NativeFieldInfoPtr___9__12_8;

			// Token: 0x04002B38 RID: 11064
			private static readonly IntPtr NativeFieldInfoPtr___9__12_9;

			// Token: 0x04002B39 RID: 11065
			private static readonly IntPtr NativeFieldInfoPtr___9__12_10;

			// Token: 0x04002B3A RID: 11066
			private static readonly IntPtr NativeFieldInfoPtr___9__12_11;

			// Token: 0x04002B3B RID: 11067
			private static readonly IntPtr NativeFieldInfoPtr___9__12_12;

			// Token: 0x04002B3C RID: 11068
			private static readonly IntPtr NativeFieldInfoPtr___9__12_13;

			// Token: 0x04002B3D RID: 11069
			private static readonly IntPtr NativeFieldInfoPtr___9__12_14;

			// Token: 0x04002B3E RID: 11070
			private static readonly IntPtr NativeFieldInfoPtr___9__12_15;

			// Token: 0x04002B3F RID: 11071
			private static readonly IntPtr NativeFieldInfoPtr___9__12_16;

			// Token: 0x04002B40 RID: 11072
			private static readonly IntPtr NativeFieldInfoPtr___9__12_17;

			// Token: 0x04002B41 RID: 11073
			private static readonly IntPtr NativeFieldInfoPtr___9__12_18;

			// Token: 0x04002B42 RID: 11074
			private static readonly IntPtr NativeFieldInfoPtr___9__12_19;

			// Token: 0x04002B43 RID: 11075
			private static readonly IntPtr NativeFieldInfoPtr___9__12_20;

			// Token: 0x04002B44 RID: 11076
			private static readonly IntPtr NativeFieldInfoPtr___9__12_21;

			// Token: 0x04002B45 RID: 11077
			private static readonly IntPtr NativeFieldInfoPtr___9__12_22;

			// Token: 0x04002B46 RID: 11078
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B47 RID: 11079
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_0_Internal_Single_Single_0;

			// Token: 0x04002B48 RID: 11080
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_1_Internal_Single_Single_0;

			// Token: 0x04002B49 RID: 11081
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_2_Internal_Single_Single_0;

			// Token: 0x04002B4A RID: 11082
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_3_Internal_Single_Single_0;

			// Token: 0x04002B4B RID: 11083
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_4_Internal_Single_Single_0;

			// Token: 0x04002B4C RID: 11084
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_5_Internal_Single_Single_0;

			// Token: 0x04002B4D RID: 11085
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_6_Internal_Single_Single_0;

			// Token: 0x04002B4E RID: 11086
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_7_Internal_Single_Single_0;

			// Token: 0x04002B4F RID: 11087
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_8_Internal_Single_Single_0;

			// Token: 0x04002B50 RID: 11088
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_9_Internal_Single_Single_0;

			// Token: 0x04002B51 RID: 11089
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_10_Internal_Single_Single_0;

			// Token: 0x04002B52 RID: 11090
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_11_Internal_Single_Single_0;

			// Token: 0x04002B53 RID: 11091
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_12_Internal_Single_Single_0;

			// Token: 0x04002B54 RID: 11092
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_13_Internal_Single_Single_0;

			// Token: 0x04002B55 RID: 11093
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_14_Internal_Single_Single_0;

			// Token: 0x04002B56 RID: 11094
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_15_Internal_Single_Single_0;

			// Token: 0x04002B57 RID: 11095
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_16_Internal_Single_Single_0;

			// Token: 0x04002B58 RID: 11096
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_17_Internal_Single_Single_0;

			// Token: 0x04002B59 RID: 11097
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_18_Internal_Single_Single_0;

			// Token: 0x04002B5A RID: 11098
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_19_Internal_Single_Single_0;

			// Token: 0x04002B5B RID: 11099
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_20_Internal_Single_Single_0;

			// Token: 0x04002B5C RID: 11100
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_21_Internal_Single_Single_0;

			// Token: 0x04002B5D RID: 11101
			private static readonly IntPtr NativeMethodInfoPtr__ConvertTransitionFunction_b__12_22_Internal_Single_Single_0;
		}

		// Token: 0x0200049F RID: 1183
		private sealed class MethodInfoStoreGeneric_GetWrappingTransitionData_Private_Static_T_List_1_T_Int32_T_0<T>
		{
			// Token: 0x04002B5E RID: 11102
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ComputedTransitionUtils.NativeMethodInfoPtr_GetWrappingTransitionData_Private_Static_T_List_1_T_Int32_T_0, Il2CppClassPointerStore<ComputedTransitionUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020004A0 RID: 1184
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
