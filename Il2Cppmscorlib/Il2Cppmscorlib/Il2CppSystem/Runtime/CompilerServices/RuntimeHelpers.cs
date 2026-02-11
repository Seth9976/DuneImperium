using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003E0 RID: 992
	public static class RuntimeHelpers : Object
	{
		// Token: 0x06003A38 RID: 14904 RVA: 0x00118AC8 File Offset: 0x00116CC8
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeHelpers()
		{
			Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "RuntimeHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr);
			RuntimeHelpers.NativeMethodInfoPtr_InitializeArray_Private_Static_Void_Array_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671983);
			RuntimeHelpers.NativeMethodInfoPtr_InitializeArray_Public_Static_Void_Array_RuntimeFieldHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671984);
			RuntimeHelpers.NativeMethodInfoPtr_get_OffsetToStringData_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671985);
			RuntimeHelpers.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671986);
			RuntimeHelpers.NativeMethodInfoPtr_GetObjectValue_Public_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671987);
			RuntimeHelpers.NativeMethodInfoPtr_RunClassConstructor_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671988);
			RuntimeHelpers.NativeMethodInfoPtr_RunClassConstructor_Public_Static_Void_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671989);
			RuntimeHelpers.NativeMethodInfoPtr_SufficientExecutionStack_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671990);
			RuntimeHelpers.NativeMethodInfoPtr_EnsureSufficientExecutionStack_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671991);
			RuntimeHelpers.NativeMethodInfoPtr_TryEnsureSufficientExecutionStack_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671992);
			RuntimeHelpers.NativeMethodInfoPtr_PrepareConstrainedRegions_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671993);
			RuntimeHelpers.NativeMethodInfoPtr_IsReferenceOrContainsReferences_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671994);
			RuntimeHelpers.NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671995);
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x00118BFC File Offset: 0x00116DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1395972, XrefRangeEnd = 1395973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeArray(Array array, IntPtr fldHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fldHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_InitializeArray_Private_Static_Void_Array_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x00118C40 File Offset: 0x00116E40
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 1395980, RefRangeEnd = 1396177, XrefRangeStart = 1395973, XrefRangeEnd = 1395980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeArray(Array array, RuntimeFieldHandle fldHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fldHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_InitializeArray_Public_Static_Void_Array_RuntimeFieldHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06003A3B RID: 14907 RVA: 0x00118C84 File Offset: 0x00116E84
		public unsafe static int OffsetToStringData
		{
			[CallerCount(250)]
			[CachedScanResults(RefRangeStart = 1396178, RefRangeEnd = 1396428, XrefRangeStart = 1396177, XrefRangeEnd = 1396178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_get_OffsetToStringData_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x00118CB4 File Offset: 0x00116EB4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 389658, RefRangeEnd = 389671, XrefRangeStart = 389658, XrefRangeEnd = 389671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCode(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003A3D RID: 14909 RVA: 0x00118CF8 File Offset: 0x00116EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1396429, RefRangeEnd = 1396430, XrefRangeStart = 1396428, XrefRangeEnd = 1396429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetObjectValue(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_GetObjectValue_Public_Static_Object_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x00118D3C File Offset: 0x00116F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396430, XrefRangeEnd = 1396431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunClassConstructor(IntPtr type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_RunClassConstructor_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x00118D70 File Offset: 0x00116F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1396440, RefRangeEnd = 1396441, XrefRangeStart = 1396431, XrefRangeEnd = 1396440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunClassConstructor(RuntimeTypeHandle type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_RunClassConstructor_Public_Static_Void_RuntimeTypeHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x00118DA4 File Offset: 0x00116FA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 489856, RefRangeEnd = 489860, XrefRangeStart = 489856, XrefRangeEnd = 489860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SufficientExecutionStack()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_SufficientExecutionStack_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x00118DD4 File Offset: 0x00116FD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1396442, RefRangeEnd = 1396446, XrefRangeStart = 1396441, XrefRangeEnd = 1396442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureSufficientExecutionStack()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_EnsureSufficientExecutionStack_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x00118DFC File Offset: 0x00116FFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 489856, RefRangeEnd = 489860, XrefRangeStart = 489856, XrefRangeEnd = 489860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryEnsureSufficientExecutionStack()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_TryEnsureSufficientExecutionStack_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x00118E2C File Offset: 0x0011702C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareConstrainedRegions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_PrepareConstrainedRegions_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x00118E54 File Offset: 0x00117054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396446, XrefRangeEnd = 1396453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsReferenceOrContainsReferences<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.MethodInfoStoreGeneric_IsReferenceOrContainsReferences_Public_Static_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x00118E84 File Offset: 0x00117084
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1396457, RefRangeEnd = 1396459, XrefRangeStart = 1396453, XrefRangeEnd = 1396457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetUninitializedObject(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeHelpers.NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x00015AB1 File Offset: 0x00013CB1
		public RuntimeHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002F21 RID: 12065
		private static readonly IntPtr NativeMethodInfoPtr_InitializeArray_Private_Static_Void_Array_IntPtr_0;

		// Token: 0x04002F22 RID: 12066
		private static readonly IntPtr NativeMethodInfoPtr_InitializeArray_Public_Static_Void_Array_RuntimeFieldHandle_0;

		// Token: 0x04002F23 RID: 12067
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetToStringData_Public_Static_get_Int32_0;

		// Token: 0x04002F24 RID: 12068
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0;

		// Token: 0x04002F25 RID: 12069
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectValue_Public_Static_Object_Object_0;

		// Token: 0x04002F26 RID: 12070
		private static readonly IntPtr NativeMethodInfoPtr_RunClassConstructor_Private_Static_Void_IntPtr_0;

		// Token: 0x04002F27 RID: 12071
		private static readonly IntPtr NativeMethodInfoPtr_RunClassConstructor_Public_Static_Void_RuntimeTypeHandle_0;

		// Token: 0x04002F28 RID: 12072
		private static readonly IntPtr NativeMethodInfoPtr_SufficientExecutionStack_Private_Static_Boolean_0;

		// Token: 0x04002F29 RID: 12073
		private static readonly IntPtr NativeMethodInfoPtr_EnsureSufficientExecutionStack_Public_Static_Void_0;

		// Token: 0x04002F2A RID: 12074
		private static readonly IntPtr NativeMethodInfoPtr_TryEnsureSufficientExecutionStack_Public_Static_Boolean_0;

		// Token: 0x04002F2B RID: 12075
		private static readonly IntPtr NativeMethodInfoPtr_PrepareConstrainedRegions_Public_Static_Void_0;

		// Token: 0x04002F2C RID: 12076
		private static readonly IntPtr NativeMethodInfoPtr_IsReferenceOrContainsReferences_Public_Static_Boolean_0;

		// Token: 0x04002F2D RID: 12077
		private static readonly IntPtr NativeMethodInfoPtr_GetUninitializedObject_Public_Static_Object_Type_0;

		// Token: 0x020006A3 RID: 1699
		private sealed class MethodInfoStoreGeneric_IsReferenceOrContainsReferences_Public_Static_Boolean_0<T>
		{
			// Token: 0x04004AFC RID: 19196
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RuntimeHelpers.NativeMethodInfoPtr_IsReferenceOrContainsReferences_Public_Static_Boolean_0, Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
