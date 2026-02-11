using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000098 RID: 152
	public class CallInstruction : Instruction
	{
		// Token: 0x06000841 RID: 2113 RVA: 0x00035154 File Offset: 0x00033354
		// Note: this type is marked as 'beforefieldinit'.
		static CallInstruction()
		{
			Il2CppClassPointerStore<CallInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "CallInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr);
			CallInstruction.NativeMethodInfoPtr_get_ArgumentCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr, 100664889);
			CallInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr, 100664890);
			CallInstruction.NativeMethodInfoPtr_Create_Public_Static_CallInstruction_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr, 100664891);
			CallInstruction.NativeMethodInfoPtr_Create_Public_Static_CallInstruction_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr, 100664892);
			CallInstruction.NativeMethodInfoPtr_GetArrayAccessor_Private_Static_CallInstruction_MethodInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr, 100664893);
			CallInstruction.NativeMethodInfoPtr_ArrayItemSetter1_Public_Static_Void_Array_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr, 100664894);
			CallInstruction.NativeMethodInfoPtr_ArrayItemSetter2_Public_Static_Void_Array_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr, 100664895);
			CallInstruction.NativeMethodInfoPtr_ArrayItemSetter3_Public_Static_Void_Array_Int32_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr, 100664896);
			CallInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr, 100664897);
			CallInstruction.NativeMethodInfoPtr_TryGetLightLambdaTarget_Protected_Static_Boolean_Object_byref_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr, 100664898);
			CallInstruction.NativeMethodInfoPtr_InterpretLambdaInvoke_Protected_Object_LightLambda_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr, 100664899);
			CallInstruction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr, 100664900);
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x00035274 File Offset: 0x00033474
		public unsafe virtual int ArgumentCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallInstruction.NativeMethodInfoPtr_get_ArgumentCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x000352BC File Offset: 0x000334BC
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015787, XrefRangeEnd = 1015789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00035300 File Offset: 0x00033500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1015794, RefRangeEnd = 1015795, XrefRangeStart = 1015789, XrefRangeEnd = 1015794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallInstruction Create(MethodInfo info)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInstruction.NativeMethodInfoPtr_Create_Public_Static_CallInstruction_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallInstruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00035344 File Offset: 0x00033544
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1015813, RefRangeEnd = 1015818, XrefRangeStart = 1015795, XrefRangeEnd = 1015813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallInstruction Create(MethodInfo info, Il2CppReferenceArray<ParameterInfo> parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInstruction.NativeMethodInfoPtr_Create_Public_Static_CallInstruction_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallInstruction>(intPtr3) : null;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0003539C File Offset: 0x0003359C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1015888, RefRangeEnd = 1015889, XrefRangeStart = 1015818, XrefRangeEnd = 1015888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argumentCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInstruction.NativeMethodInfoPtr_GetArrayAccessor_Private_Static_CallInstruction_MethodInfo_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallInstruction>(intPtr3) : null;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000353F0 File Offset: 0x000335F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015889, XrefRangeEnd = 1015891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ArrayItemSetter1(Array array, int index0, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInstruction.NativeMethodInfoPtr_ArrayItemSetter1_Public_Static_Void_Array_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00035448 File Offset: 0x00033648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015891, XrefRangeEnd = 1015893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ArrayItemSetter2(Array array, int index0, int index1, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInstruction.NativeMethodInfoPtr_ArrayItemSetter2_Public_Static_Void_Array_Int32_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000354AC File Offset: 0x000336AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015893, XrefRangeEnd = 1015894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ArrayItemSetter3(Array array, int index0, int index1, int index2, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInstruction.NativeMethodInfoPtr_ArrayItemSetter3_Public_Static_Void_Array_Int32_Int32_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00035520 File Offset: 0x00033720
		public unsafe override int ConsumedStack
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1007052, RefRangeEnd = 1007057, XrefRangeStart = 1007052, XrefRangeEnd = 1007057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00035568 File Offset: 0x00033768
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1015907, RefRangeEnd = 1015909, XrefRangeStart = 1015894, XrefRangeEnd = 1015907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetLightLambdaTarget(Object instance, out LightLambda lightLambda)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CallInstruction.NativeMethodInfoPtr_TryGetLightLambdaTarget_Protected_Static_Boolean_Object_byref_LightLambda_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			lightLambda = ((intPtr4 == 0) ? null : new LightLambda(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000355CC File Offset: 0x000337CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015909, XrefRangeEnd = 1015912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object InterpretLambdaInvoke(LightLambda targetLambda, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetLambda);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInstruction.NativeMethodInfoPtr_InterpretLambdaInvoke_Protected_Object_LightLambda_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00035630 File Offset: 0x00033830
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInstruction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00004353 File Offset: 0x00002553
		public CallInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_CallInstruction_MethodInfo_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_CallInstruction_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayAccessor_Private_Static_CallInstruction_MethodInfo_Int32_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_ArrayItemSetter1_Public_Static_Void_Array_Int32_Object_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_ArrayItemSetter2_Public_Static_Void_Array_Int32_Int32_Object_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_ArrayItemSetter3_Public_Static_Void_Array_Int32_Int32_Int32_Object_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_TryGetLightLambdaTarget_Protected_Static_Boolean_Object_byref_LightLambda_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_InterpretLambdaInvoke_Protected_Object_LightLambda_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
