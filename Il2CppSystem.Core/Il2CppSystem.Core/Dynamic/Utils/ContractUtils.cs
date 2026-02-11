using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Dynamic.Utils
{
	// Token: 0x02000128 RID: 296
	public static class ContractUtils : Object
	{
		// Token: 0x06001158 RID: 4440 RVA: 0x0005ABA4 File Offset: 0x00058DA4
		// Note: this type is marked as 'beforefieldinit'.
		static ContractUtils()
		{
			Il2CppClassPointerStore<ContractUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic.Utils", "ContractUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContractUtils>.NativeClassPtr);
			ContractUtils.NativeMethodInfoPtr_get_Unreachable_Public_Static_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractUtils>.NativeClassPtr, 100666585);
			ContractUtils.NativeMethodInfoPtr_Requires_Public_Static_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractUtils>.NativeClassPtr, 100666586);
			ContractUtils.NativeMethodInfoPtr_RequiresNotNull_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractUtils>.NativeClassPtr, 100666587);
			ContractUtils.NativeMethodInfoPtr_RequiresNotNull_Public_Static_Void_Object_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractUtils>.NativeClassPtr, 100666588);
			ContractUtils.NativeMethodInfoPtr_RequiresNotNullItems_Public_Static_Void_IList_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractUtils>.NativeClassPtr, 100666589);
			ContractUtils.NativeMethodInfoPtr_GetParamName_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractUtils>.NativeClassPtr, 100666590);
			ContractUtils.NativeMethodInfoPtr_RequiresArrayRange_Public_Static_Void_IList_1_T_Int32_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractUtils>.NativeClassPtr, 100666591);
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x0005AC60 File Offset: 0x00058E60
		public unsafe static Exception Unreachable
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 1029684, RefRangeEnd = 1029712, XrefRangeStart = 1029678, XrefRangeEnd = 1029684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractUtils.NativeMethodInfoPtr_get_Unreachable_Public_Static_get_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0005AC94 File Offset: 0x00058E94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1029712, RefRangeEnd = 1029717, XrefRangeStart = 1029712, XrefRangeEnd = 1029712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Requires(bool precondition, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref precondition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractUtils.NativeMethodInfoPtr_Requires_Public_Static_Void_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0005ACD8 File Offset: 0x00058ED8
		[CallerCount(123)]
		[CachedScanResults(RefRangeStart = 1029722, RefRangeEnd = 1029845, XrefRangeStart = 1029717, XrefRangeEnd = 1029722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequiresNotNull(Object value, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractUtils.NativeMethodInfoPtr_RequiresNotNull_Public_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0005AD20 File Offset: 0x00058F20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1029845, RefRangeEnd = 1029847, XrefRangeStart = 1029845, XrefRangeEnd = 1029845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequiresNotNull(Object value, string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractUtils.NativeMethodInfoPtr_RequiresNotNull_Public_Static_Void_Object_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0005AD78 File Offset: 0x00058F78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1029853, RefRangeEnd = 1029860, XrefRangeStart = 1029847, XrefRangeEnd = 1029853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequiresNotNullItems<T>(IList<T> array, string arrayName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arrayName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractUtils.MethodInfoStoreGeneric_RequiresNotNullItems_Public_Static_Void_IList_1_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0005ADC0 File Offset: 0x00058FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029860, XrefRangeEnd = 1029866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetParamName(string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractUtils.NativeMethodInfoPtr_GetParamName_Private_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0005AE0C File Offset: 0x0005900C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1029869, RefRangeEnd = 1029872, XrefRangeStart = 1029866, XrefRangeEnd = 1029869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequiresArrayRange<T>(IList<T> array, int offset, int count, string offsetName, string countName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(offsetName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(countName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractUtils.MethodInfoStoreGeneric_RequiresArrayRange_Public_Static_Void_IList_1_T_Int32_Int32_String_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00007525 File Offset: 0x00005725
		public ContractUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C72 RID: 3186
		private static readonly IntPtr NativeMethodInfoPtr_get_Unreachable_Public_Static_get_Exception_0;

		// Token: 0x04000C73 RID: 3187
		private static readonly IntPtr NativeMethodInfoPtr_Requires_Public_Static_Void_Boolean_String_0;

		// Token: 0x04000C74 RID: 3188
		private static readonly IntPtr NativeMethodInfoPtr_RequiresNotNull_Public_Static_Void_Object_String_0;

		// Token: 0x04000C75 RID: 3189
		private static readonly IntPtr NativeMethodInfoPtr_RequiresNotNull_Public_Static_Void_Object_String_Int32_0;

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_RequiresNotNullItems_Public_Static_Void_IList_1_T_String_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_GetParamName_Private_Static_String_String_Int32_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr_RequiresArrayRange_Public_Static_Void_IList_1_T_Int32_Int32_String_String_0;

		// Token: 0x02000350 RID: 848
		private sealed class MethodInfoStoreGeneric_RequiresNotNullItems_Public_Static_Void_IList_1_T_String_0<T>
		{
			// Token: 0x040012F9 RID: 4857
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ContractUtils.NativeMethodInfoPtr_RequiresNotNullItems_Public_Static_Void_IList_1_T_String_0, Il2CppClassPointerStore<ContractUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000351 RID: 849
		private sealed class MethodInfoStoreGeneric_RequiresArrayRange_Public_Static_Void_IList_1_T_Int32_Int32_String_String_0<T>
		{
			// Token: 0x040012FA RID: 4858
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ContractUtils.NativeMethodInfoPtr_RequiresArrayRange_Public_Static_Void_IList_1_T_Int32_Int32_String_String_0, Il2CppClassPointerStore<ContractUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
