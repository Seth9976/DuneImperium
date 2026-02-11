using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Dynamic;
using Il2CppSystem.Linq.Expressions;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000052 RID: 82
	public sealed class DynamicProxyMetaObject<T> : DynamicMetaObject
	{
		// Token: 0x060007A6 RID: 1958 RVA: 0x00036458 File Offset: 0x00034658
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicProxyMetaObject()
		{
			Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "DynamicProxyMetaObject`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr);
			DynamicProxyMetaObject<T>.NativeFieldInfoPtr__proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "_proxy");
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr__ctor_Internal_Void_Expression_T_DynamicProxy_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664754);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_IsOverridden_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664755);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindGetMember_Public_Virtual_DynamicMetaObject_GetMemberBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664756);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindSetMember_Public_Virtual_DynamicMetaObject_SetMemberBinder_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664757);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindDeleteMember_Public_Virtual_DynamicMetaObject_DeleteMemberBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664758);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindConvert_Public_Virtual_DynamicMetaObject_ConvertBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664759);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindInvokeMember_Public_Virtual_DynamicMetaObject_InvokeMemberBinder_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664760);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindCreateInstance_Public_Virtual_DynamicMetaObject_CreateInstanceBinder_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664761);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindInvoke_Public_Virtual_DynamicMetaObject_InvokeBinder_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664762);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindBinaryOperation_Public_Virtual_DynamicMetaObject_BinaryOperationBinder_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664763);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindUnaryOperation_Public_Virtual_DynamicMetaObject_UnaryOperationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664764);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindGetIndex_Public_Virtual_DynamicMetaObject_GetIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664765);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindSetIndex_Public_Virtual_DynamicMetaObject_SetIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664766);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindDeleteIndex_Public_Virtual_DynamicMetaObject_DeleteIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664767);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_get_NoArgs_Private_Static_get_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664768);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_GetArgs_Private_Static_IEnumerable_1_Expression_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664769);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_GetArgArray_Private_Static_Il2CppReferenceArray_1_Expression_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664770);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_GetArgArray_Private_Static_Il2CppReferenceArray_1_Expression_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664771);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_Constant_Private_Static_ConstantExpression_DynamicMetaObjectBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664772);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_CallMethodWithResult_Private_DynamicMetaObject_String_DynamicMetaObjectBinder_IEnumerable_1_Expression_Fallback_T_Fallback_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664773);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BuildCallMethodWithResult_Private_DynamicMetaObject_String_DynamicMetaObjectBinder_IEnumerable_1_Expression_DynamicMetaObject_Fallback_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664774);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_CallMethodReturnLast_Private_DynamicMetaObject_String_DynamicMetaObjectBinder_IEnumerable_1_Expression_Fallback_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664775);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_CallMethodNoResult_Private_DynamicMetaObject_String_DynamicMetaObjectBinder_Il2CppReferenceArray_1_Expression_Fallback_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664776);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_GetRestrictions_Private_BindingRestrictions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664777);
			DynamicProxyMetaObject<T>.NativeMethodInfoPtr_GetDynamicMemberNames_Public_Virtual_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, 100664778);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x000366CC File Offset: 0x000348CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 742319, RefRangeEnd = 742322, XrefRangeStart = 742310, XrefRangeEnd = 742319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicProxyMetaObject(Expression expression, T value, DynamicProxy<T> proxy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr__ctor_Internal_Void_Expression_T_DynamicProxy_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00036774 File Offset: 0x00034974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742322, XrefRangeEnd = 742332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOverridden(string method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_IsOverridden_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000367C4 File Offset: 0x000349C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742332, XrefRangeEnd = 742346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindGetMember_Public_Virtual_DynamicMetaObject_GetMemberBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00036814 File Offset: 0x00034A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742346, XrefRangeEnd = 742366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindSetMember_Public_Virtual_DynamicMetaObject_SetMemberBinder_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00036878 File Offset: 0x00034A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742366, XrefRangeEnd = 742380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindDeleteMember_Public_Virtual_DynamicMetaObject_DeleteMemberBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000368C8 File Offset: 0x00034AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742380, XrefRangeEnd = 742394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject BindConvert(ConvertBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindConvert_Public_Virtual_DynamicMetaObject_ConvertBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00036918 File Offset: 0x00034B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742394, XrefRangeEnd = 742419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, Il2CppReferenceArray<DynamicMetaObject> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindInvokeMember_Public_Virtual_DynamicMetaObject_InvokeMemberBinder_Il2CppReferenceArray_1_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0003697C File Offset: 0x00034B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742419, XrefRangeEnd = 742434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, Il2CppReferenceArray<DynamicMetaObject> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindCreateInstance_Public_Virtual_DynamicMetaObject_CreateInstanceBinder_Il2CppReferenceArray_1_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000369E0 File Offset: 0x00034BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742434, XrefRangeEnd = 742449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject BindInvoke(InvokeBinder binder, Il2CppReferenceArray<DynamicMetaObject> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindInvoke_Public_Virtual_DynamicMetaObject_InvokeBinder_Il2CppReferenceArray_1_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00036A44 File Offset: 0x00034C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742449, XrefRangeEnd = 742469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindBinaryOperation_Public_Virtual_DynamicMetaObject_BinaryOperationBinder_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00036AA8 File Offset: 0x00034CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742469, XrefRangeEnd = 742483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindUnaryOperation_Public_Virtual_DynamicMetaObject_UnaryOperationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00036AF8 File Offset: 0x00034CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742483, XrefRangeEnd = 742498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject BindGetIndex(GetIndexBinder binder, Il2CppReferenceArray<DynamicMetaObject> indexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindGetIndex_Public_Virtual_DynamicMetaObject_GetIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00036B5C File Offset: 0x00034D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742498, XrefRangeEnd = 742514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject BindSetIndex(SetIndexBinder binder, Il2CppReferenceArray<DynamicMetaObject> indexes, DynamicMetaObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindSetIndex_Public_Virtual_DynamicMetaObject_SetIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00036BD0 File Offset: 0x00034DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742514, XrefRangeEnd = 742529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, Il2CppReferenceArray<DynamicMetaObject> indexes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BindDeleteIndex_Public_Virtual_DynamicMetaObject_DeleteIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00036C34 File Offset: 0x00034E34
		public unsafe static Il2CppReferenceArray<Expression> NoArgs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742529, XrefRangeEnd = 742534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_get_NoArgs_Private_Static_get_Il2CppReferenceArray_1_Expression_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Expression>>(intPtr3) : null;
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00036C68 File Offset: 0x00034E68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 742557, RefRangeEnd = 742561, XrefRangeStart = 742534, XrefRangeEnd = 742557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Expression> GetArgs([Optional] Il2CppReferenceArray<DynamicMetaObject> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<DynamicMetaObject>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_GetArgs_Private_Static_IEnumerable_1_Expression_Il2CppReferenceArray_1_DynamicMetaObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Expression>>(intPtr3) : null;
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00036CBC File Offset: 0x00034EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742561, XrefRangeEnd = 742578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Expression> GetArgArray(Il2CppReferenceArray<DynamicMetaObject> args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_GetArgArray_Private_Static_Il2CppReferenceArray_1_Expression_Il2CppReferenceArray_1_DynamicMetaObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Expression>>(intPtr3) : null;
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00036D00 File Offset: 0x00034F00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 742605, RefRangeEnd = 742606, XrefRangeStart = 742578, XrefRangeEnd = 742605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Expression> GetArgArray(Il2CppReferenceArray<DynamicMetaObject> args, DynamicMetaObject value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_GetArgArray_Private_Static_Il2CppReferenceArray_1_Expression_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Expression>>(intPtr3) : null;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00036D58 File Offset: 0x00034F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742606, XrefRangeEnd = 742615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConstantExpression Constant(DynamicMetaObjectBinder binder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_Constant_Private_Static_ConstantExpression_DynamicMetaObjectBinder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstantExpression>(intPtr3) : null;
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00036D9C File Offset: 0x00034F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742615, XrefRangeEnd = 742617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicProxyMetaObject<T>.Fallback fallback, DynamicProxyMetaObject<T>.Fallback fallbackInvoke = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fallback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fallbackInvoke);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_CallMethodWithResult_Private_DynamicMetaObject_String_DynamicMetaObjectBinder_IEnumerable_1_Expression_Fallback_T_Fallback_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00036E38 File Offset: 0x00035038
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 742696, RefRangeEnd = 742706, XrefRangeStart = 742617, XrefRangeEnd = 742696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, DynamicProxyMetaObject<T>.Fallback fallbackInvoke)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fallbackResult);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fallbackInvoke);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_BuildCallMethodWithResult_Private_DynamicMetaObject_String_DynamicMetaObjectBinder_IEnumerable_1_Expression_DynamicMetaObject_Fallback_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00036ED4 File Offset: 0x000350D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 742777, RefRangeEnd = 742779, XrefRangeStart = 742706, XrefRangeEnd = 742777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicProxyMetaObject<T>.Fallback fallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_CallMethodReturnLast_Private_DynamicMetaObject_String_DynamicMetaObjectBinder_IEnumerable_1_Expression_Fallback_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00036F5C File Offset: 0x0003515C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 742824, RefRangeEnd = 742826, XrefRangeStart = 742779, XrefRangeEnd = 742824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Il2CppReferenceArray<Expression> args, DynamicProxyMetaObject<T>.Fallback fallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_CallMethodNoResult_Private_DynamicMetaObject_String_DynamicMetaObjectBinder_Il2CppReferenceArray_1_Expression_Fallback_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00036FE4 File Offset: 0x000351E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742826, XrefRangeEnd = 742837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindingRestrictions GetRestrictions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_GetRestrictions_Private_BindingRestrictions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingRestrictions>(intPtr3) : null;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00037024 File Offset: 0x00035224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742837, XrefRangeEnd = 742843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<string> GetDynamicMemberNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.NativeMethodInfoPtr_GetDynamicMemberNames_Public_Virtual_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x000045B6 File Offset: 0x000027B6
		public static IEnumerable<Expression> GetArgs(params DynamicMetaObject[] args)
		{
			return DynamicProxyMetaObject.GetArgs(new Il2CppReferenceArray<DynamicMetaObject>(args));
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x000045C3 File Offset: 0x000027C3
		public DynamicProxyMetaObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00037064 File Offset: 0x00035264
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x000045CC File Offset: 0x000027CC
		public unsafe DynamicProxy<T> _proxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.NativeFieldInfoPtr__proxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxy<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.NativeFieldInfoPtr__proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr__proxy;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_T_DynamicProxy_1_T_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr_IsOverridden_Private_Boolean_String_0;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeMethodInfoPtr_BindGetMember_Public_Virtual_DynamicMetaObject_GetMemberBinder_0;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeMethodInfoPtr_BindSetMember_Public_Virtual_DynamicMetaObject_SetMemberBinder_DynamicMetaObject_0;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeMethodInfoPtr_BindDeleteMember_Public_Virtual_DynamicMetaObject_DeleteMemberBinder_0;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeMethodInfoPtr_BindConvert_Public_Virtual_DynamicMetaObject_ConvertBinder_0;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeMethodInfoPtr_BindInvokeMember_Public_Virtual_DynamicMetaObject_InvokeMemberBinder_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeMethodInfoPtr_BindCreateInstance_Public_Virtual_DynamicMetaObject_CreateInstanceBinder_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_BindInvoke_Public_Virtual_DynamicMetaObject_InvokeBinder_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_BindBinaryOperation_Public_Virtual_DynamicMetaObject_BinaryOperationBinder_DynamicMetaObject_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr_BindUnaryOperation_Public_Virtual_DynamicMetaObject_UnaryOperationBinder_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_BindGetIndex_Public_Virtual_DynamicMetaObject_GetIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_BindSetIndex_Public_Virtual_DynamicMetaObject_SetIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_BindDeleteIndex_Public_Virtual_DynamicMetaObject_DeleteIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_get_NoArgs_Private_Static_get_Il2CppReferenceArray_1_Expression_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_GetArgs_Private_Static_IEnumerable_1_Expression_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_GetArgArray_Private_Static_Il2CppReferenceArray_1_Expression_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_GetArgArray_Private_Static_Il2CppReferenceArray_1_Expression_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_Constant_Private_Static_ConstantExpression_DynamicMetaObjectBinder_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_CallMethodWithResult_Private_DynamicMetaObject_String_DynamicMetaObjectBinder_IEnumerable_1_Expression_Fallback_T_Fallback_T_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_BuildCallMethodWithResult_Private_DynamicMetaObject_String_DynamicMetaObjectBinder_IEnumerable_1_Expression_DynamicMetaObject_Fallback_T_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_CallMethodReturnLast_Private_DynamicMetaObject_String_DynamicMetaObjectBinder_IEnumerable_1_Expression_Fallback_T_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_CallMethodNoResult_Private_DynamicMetaObject_String_DynamicMetaObjectBinder_Il2CppReferenceArray_1_Expression_Fallback_T_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_GetRestrictions_Private_BindingRestrictions_0;

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicMemberNames_Public_Virtual_IEnumerable_1_String_0;

		// Token: 0x02000181 RID: 385
		public sealed class Fallback : MulticastDelegate
		{
			// Token: 0x06001C5E RID: 7262 RVA: 0x000860E8 File Offset: 0x000842E8
			// Note: this type is marked as 'beforefieldinit'.
			static Fallback()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.Fallback>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "Fallback"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				DynamicProxyMetaObject<T>.Fallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.Fallback>.NativeClassPtr, 100664779);
				DynamicProxyMetaObject<T>.Fallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.Fallback>.NativeClassPtr, 100664780);
				DynamicProxyMetaObject<T>.Fallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DynamicMetaObject_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.Fallback>.NativeClassPtr, 100664781);
				DynamicProxyMetaObject<T>.Fallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_DynamicMetaObject_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.Fallback>.NativeClassPtr, 100664782);
			}

			// Token: 0x06001C5F RID: 7263 RVA: 0x00086194 File Offset: 0x00084394
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 742264, RefRangeEnd = 742289, XrefRangeStart = 742255, XrefRangeEnd = 742264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Fallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.Fallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.Fallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C60 RID: 7264 RVA: 0x000861F0 File Offset: 0x000843F0
			[CallerCount(0)]
			public unsafe DynamicMetaObject Invoke(DynamicMetaObject errorSuggestion)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(errorSuggestion);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.Fallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001C61 RID: 7265 RVA: 0x00086240 File Offset: 0x00084440
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(DynamicMetaObject errorSuggestion, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(errorSuggestion);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.Fallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DynamicMetaObject_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001C62 RID: 7266 RVA: 0x000862B4 File Offset: 0x000844B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynamicMetaObject EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.Fallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_DynamicMetaObject_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001C63 RID: 7267 RVA: 0x0000DF2F File Offset: 0x0000C12F
			public Fallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001C64 RID: 7268 RVA: 0x0000DF38 File Offset: 0x0000C138
			public static implicit operator DynamicProxyMetaObject<T>.Fallback(Func<DynamicMetaObject, DynamicMetaObject> A_0)
			{
				return DelegateSupport.ConvertDelegate<DynamicProxyMetaObject<T>.Fallback>(A_0);
			}

			// Token: 0x06001C65 RID: 7269 RVA: 0x0000DF40 File Offset: 0x0000C140
			public static DynamicProxyMetaObject<T>.Fallback operator +(DynamicProxyMetaObject<T>.Fallback A_0, DynamicProxyMetaObject<T>.Fallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<DynamicProxyMetaObject<T>.Fallback>();
			}

			// Token: 0x06001C66 RID: 7270 RVA: 0x0000DF4E File Offset: 0x0000C14E
			public static DynamicProxyMetaObject<T>.Fallback operator -(DynamicProxyMetaObject<T>.Fallback A_0, DynamicProxyMetaObject<T>.Fallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<DynamicProxyMetaObject<T>.Fallback>();
				}
				return delegate2;
			}

			// Token: 0x0400151C RID: 5404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400151D RID: 5405
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_DynamicMetaObject_DynamicMetaObject_0;

			// Token: 0x0400151E RID: 5406
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_DynamicMetaObject_AsyncCallback_Object_0;

			// Token: 0x0400151F RID: 5407
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_DynamicMetaObject_IAsyncResult_0;
		}

		// Token: 0x02000182 RID: 386
		public sealed class GetBinderAdapter : GetMemberBinder
		{
			// Token: 0x06001C67 RID: 7271 RVA: 0x00086304 File Offset: 0x00084504
			// Note: this type is marked as 'beforefieldinit'.
			static GetBinderAdapter()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.GetBinderAdapter>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "GetBinderAdapter"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.GetBinderAdapter>.NativeClassPtr);
				DynamicProxyMetaObject<T>.GetBinderAdapter.NativeMethodInfoPtr__ctor_Internal_Void_InvokeMemberBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.GetBinderAdapter>.NativeClassPtr, 100664783);
				DynamicProxyMetaObject<T>.GetBinderAdapter.NativeMethodInfoPtr_FallbackGetMember_Public_Virtual_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.GetBinderAdapter>.NativeClassPtr, 100664784);
			}

			// Token: 0x06001C68 RID: 7272 RVA: 0x00086394 File Offset: 0x00084594
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 742291, RefRangeEnd = 742292, XrefRangeStart = 742289, XrefRangeEnd = 742291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetBinderAdapter(InvokeMemberBinder binder)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.GetBinderAdapter>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.GetBinderAdapter.NativeMethodInfoPtr__ctor_Internal_Void_InvokeMemberBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C69 RID: 7273 RVA: 0x000863E0 File Offset: 0x000845E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742292, XrefRangeEnd = 742298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorSuggestion);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.GetBinderAdapter.NativeMethodInfoPtr_FallbackGetMember_Public_Virtual_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}

			// Token: 0x06001C6A RID: 7274 RVA: 0x0000DF5F File Offset: 0x0000C15F
			public GetBinderAdapter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001520 RID: 5408
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InvokeMemberBinder_0;

			// Token: 0x04001521 RID: 5409
			private static readonly IntPtr NativeMethodInfoPtr_FallbackGetMember_Public_Virtual_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0;
		}

		// Token: 0x02000183 RID: 387
		[ObfuscatedName("Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C6B RID: 7275 RVA: 0x00086444 File Offset: 0x00084644
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c>.NativeClassPtr);
				DynamicProxyMetaObject<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c>.NativeClassPtr, "<>9");
				DynamicProxyMetaObject<T>.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c>.NativeClassPtr, "<>9__18_0");
				DynamicProxyMetaObject<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c>.NativeClassPtr, 100664786);
				DynamicProxyMetaObject<T>.__c.NativeMethodInfoPtr__GetArgs_b__18_0_Internal_Expression_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c>.NativeClassPtr, 100664787);
			}

			// Token: 0x06001C6C RID: 7276 RVA: 0x000864FC File Offset: 0x000846FC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C6D RID: 7277 RVA: 0x00086538 File Offset: 0x00084738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742298, XrefRangeEnd = 742309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Expression _GetArgs_b__18_0(DynamicMetaObject arg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c.NativeMethodInfoPtr__GetArgs_b__18_0_Internal_Expression_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
				}
			}

			// Token: 0x06001C6E RID: 7278 RVA: 0x0000DF68 File Offset: 0x0000C168
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000801 RID: 2049
			// (get) Token: 0x06001C6F RID: 7279 RVA: 0x00086588 File Offset: 0x00084788
			// (set) Token: 0x06001C70 RID: 7280 RVA: 0x0000DF71 File Offset: 0x0000C171
			public unsafe static DynamicProxyMetaObject<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicProxyMetaObject<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxyMetaObject<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicProxyMetaObject<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000802 RID: 2050
			// (get) Token: 0x06001C71 RID: 7281 RVA: 0x000865B0 File Offset: 0x000847B0
			// (set) Token: 0x06001C72 RID: 7282 RVA: 0x0000DF83 File Offset: 0x0000C183
			public unsafe static Func<DynamicMetaObject, Expression> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicProxyMetaObject<T>.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DynamicMetaObject, Expression>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicProxyMetaObject<T>.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001522 RID: 5410
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001523 RID: 5411
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04001524 RID: 5412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001525 RID: 5413
			private static readonly IntPtr NativeMethodInfoPtr__GetArgs_b__18_0_Internal_Expression_DynamicMetaObject_0;
		}

		// Token: 0x02000184 RID: 388
		[ObfuscatedName("Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06001C73 RID: 7283 RVA: 0x000865D8 File Offset: 0x000847D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "<>c__DisplayClass10_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass10_0>.NativeClassPtr);
				DynamicProxyMetaObject<T>.__c__DisplayClass10_0.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass10_0>.NativeClassPtr, "binder");
				DynamicProxyMetaObject<T>.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				DynamicProxyMetaObject<T>.__c__DisplayClass10_0.NativeFieldInfoPtr_arg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass10_0>.NativeClassPtr, "arg");
				DynamicProxyMetaObject<T>.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass10_0>.NativeClassPtr, 100664788);
				DynamicProxyMetaObject<T>.__c__DisplayClass10_0.NativeMethodInfoPtr__BindBinaryOperation_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass10_0>.NativeClassPtr, 100664789);
			}

			// Token: 0x06001C74 RID: 7284 RVA: 0x000866A4 File Offset: 0x000848A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C75 RID: 7285 RVA: 0x000866E0 File Offset: 0x000848E0
			[CallerCount(0)]
			public unsafe DynamicMetaObject _BindBinaryOperation_b__0(DynamicMetaObject e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass10_0.NativeMethodInfoPtr__BindBinaryOperation_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001C76 RID: 7286 RVA: 0x0000DF95 File Offset: 0x0000C195
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000803 RID: 2051
			// (get) Token: 0x06001C77 RID: 7287 RVA: 0x00086730 File Offset: 0x00084930
			// (set) Token: 0x06001C78 RID: 7288 RVA: 0x0000DF9E File Offset: 0x0000C19E
			public unsafe BinaryOperationBinder binder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass10_0.NativeFieldInfoPtr_binder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryOperationBinder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass10_0.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000804 RID: 2052
			// (get) Token: 0x06001C79 RID: 7289 RVA: 0x00086760 File Offset: 0x00084960
			// (set) Token: 0x06001C7A RID: 7290 RVA: 0x0000DFBD File Offset: 0x0000C1BD
			public unsafe DynamicProxyMetaObject<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxyMetaObject<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000805 RID: 2053
			// (get) Token: 0x06001C7B RID: 7291 RVA: 0x00086790 File Offset: 0x00084990
			// (set) Token: 0x06001C7C RID: 7292 RVA: 0x0000DFDC File Offset: 0x0000C1DC
			public unsafe DynamicMetaObject arg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass10_0.NativeFieldInfoPtr_arg);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass10_0.NativeFieldInfoPtr_arg), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001526 RID: 5414
			private static readonly IntPtr NativeFieldInfoPtr_binder;

			// Token: 0x04001527 RID: 5415
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001528 RID: 5416
			private static readonly IntPtr NativeFieldInfoPtr_arg;

			// Token: 0x04001529 RID: 5417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400152A RID: 5418
			private static readonly IntPtr NativeMethodInfoPtr__BindBinaryOperation_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0;
		}

		// Token: 0x02000185 RID: 389
		[ObfuscatedName("Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06001C7D RID: 7293 RVA: 0x000867C0 File Offset: 0x000849C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "<>c__DisplayClass11_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass11_0>.NativeClassPtr);
				DynamicProxyMetaObject<T>.__c__DisplayClass11_0.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass11_0>.NativeClassPtr, "binder");
				DynamicProxyMetaObject<T>.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				DynamicProxyMetaObject<T>.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass11_0>.NativeClassPtr, 100664790);
				DynamicProxyMetaObject<T>.__c__DisplayClass11_0.NativeMethodInfoPtr__BindUnaryOperation_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass11_0>.NativeClassPtr, 100664791);
			}

			// Token: 0x06001C7E RID: 7294 RVA: 0x00086878 File Offset: 0x00084A78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C7F RID: 7295 RVA: 0x000868B4 File Offset: 0x00084AB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 742309, XrefRangeEnd = 742310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynamicMetaObject _BindUnaryOperation_b__0(DynamicMetaObject e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass11_0.NativeMethodInfoPtr__BindUnaryOperation_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001C80 RID: 7296 RVA: 0x0000DFFB File Offset: 0x0000C1FB
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000806 RID: 2054
			// (get) Token: 0x06001C81 RID: 7297 RVA: 0x00086904 File Offset: 0x00084B04
			// (set) Token: 0x06001C82 RID: 7298 RVA: 0x0000E004 File Offset: 0x0000C204
			public unsafe UnaryOperationBinder binder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass11_0.NativeFieldInfoPtr_binder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnaryOperationBinder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass11_0.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000807 RID: 2055
			// (get) Token: 0x06001C83 RID: 7299 RVA: 0x00086934 File Offset: 0x00084B34
			// (set) Token: 0x06001C84 RID: 7300 RVA: 0x0000E023 File Offset: 0x0000C223
			public unsafe DynamicProxyMetaObject<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxyMetaObject<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400152B RID: 5419
			private static readonly IntPtr NativeFieldInfoPtr_binder;

			// Token: 0x0400152C RID: 5420
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400152D RID: 5421
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400152E RID: 5422
			private static readonly IntPtr NativeMethodInfoPtr__BindUnaryOperation_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0;
		}

		// Token: 0x02000186 RID: 390
		[ObfuscatedName("Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x06001C85 RID: 7301 RVA: 0x00086964 File Offset: 0x00084B64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "<>c__DisplayClass12_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass12_0>.NativeClassPtr);
				DynamicProxyMetaObject<T>.__c__DisplayClass12_0.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass12_0>.NativeClassPtr, "binder");
				DynamicProxyMetaObject<T>.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				DynamicProxyMetaObject<T>.__c__DisplayClass12_0.NativeFieldInfoPtr_indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass12_0>.NativeClassPtr, "indexes");
				DynamicProxyMetaObject<T>.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass12_0>.NativeClassPtr, 100664792);
				DynamicProxyMetaObject<T>.__c__DisplayClass12_0.NativeMethodInfoPtr__BindGetIndex_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass12_0>.NativeClassPtr, 100664793);
			}

			// Token: 0x06001C86 RID: 7302 RVA: 0x00086A30 File Offset: 0x00084C30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C87 RID: 7303 RVA: 0x00086A6C File Offset: 0x00084C6C
			[CallerCount(0)]
			public unsafe DynamicMetaObject _BindGetIndex_b__0(DynamicMetaObject e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass12_0.NativeMethodInfoPtr__BindGetIndex_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001C88 RID: 7304 RVA: 0x0000E042 File Offset: 0x0000C242
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000808 RID: 2056
			// (get) Token: 0x06001C89 RID: 7305 RVA: 0x00086ABC File Offset: 0x00084CBC
			// (set) Token: 0x06001C8A RID: 7306 RVA: 0x0000E04B File Offset: 0x0000C24B
			public unsafe GetIndexBinder binder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass12_0.NativeFieldInfoPtr_binder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetIndexBinder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass12_0.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000809 RID: 2057
			// (get) Token: 0x06001C8B RID: 7307 RVA: 0x00086AEC File Offset: 0x00084CEC
			// (set) Token: 0x06001C8C RID: 7308 RVA: 0x0000E06A File Offset: 0x0000C26A
			public unsafe DynamicProxyMetaObject<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxyMetaObject<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080A RID: 2058
			// (get) Token: 0x06001C8D RID: 7309 RVA: 0x00086B1C File Offset: 0x00084D1C
			// (set) Token: 0x06001C8E RID: 7310 RVA: 0x0000E089 File Offset: 0x0000C289
			public unsafe Il2CppReferenceArray<DynamicMetaObject> indexes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass12_0.NativeFieldInfoPtr_indexes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicMetaObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass12_0.NativeFieldInfoPtr_indexes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400152F RID: 5423
			private static readonly IntPtr NativeFieldInfoPtr_binder;

			// Token: 0x04001530 RID: 5424
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001531 RID: 5425
			private static readonly IntPtr NativeFieldInfoPtr_indexes;

			// Token: 0x04001532 RID: 5426
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001533 RID: 5427
			private static readonly IntPtr NativeMethodInfoPtr__BindGetIndex_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0;
		}

		// Token: 0x02000187 RID: 391
		[ObfuscatedName("Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06001C8F RID: 7311 RVA: 0x00086B4C File Offset: 0x00084D4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "<>c__DisplayClass13_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass13_0>.NativeClassPtr);
				DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass13_0>.NativeClassPtr, "binder");
				DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeFieldInfoPtr_indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass13_0>.NativeClassPtr, "indexes");
				DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass13_0>.NativeClassPtr, "value");
				DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass13_0>.NativeClassPtr, 100664794);
				DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeMethodInfoPtr__BindSetIndex_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass13_0>.NativeClassPtr, 100664795);
			}

			// Token: 0x06001C90 RID: 7312 RVA: 0x00086C2C File Offset: 0x00084E2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C91 RID: 7313 RVA: 0x00086C68 File Offset: 0x00084E68
			[CallerCount(0)]
			public unsafe DynamicMetaObject _BindSetIndex_b__0(DynamicMetaObject e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeMethodInfoPtr__BindSetIndex_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001C92 RID: 7314 RVA: 0x0000E0A8 File Offset: 0x0000C2A8
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700080B RID: 2059
			// (get) Token: 0x06001C93 RID: 7315 RVA: 0x00086CB8 File Offset: 0x00084EB8
			// (set) Token: 0x06001C94 RID: 7316 RVA: 0x0000E0B1 File Offset: 0x0000C2B1
			public unsafe SetIndexBinder binder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeFieldInfoPtr_binder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetIndexBinder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080C RID: 2060
			// (get) Token: 0x06001C95 RID: 7317 RVA: 0x00086CE8 File Offset: 0x00084EE8
			// (set) Token: 0x06001C96 RID: 7318 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
			public unsafe DynamicProxyMetaObject<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxyMetaObject<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080D RID: 2061
			// (get) Token: 0x06001C97 RID: 7319 RVA: 0x00086D18 File Offset: 0x00084F18
			// (set) Token: 0x06001C98 RID: 7320 RVA: 0x0000E0EF File Offset: 0x0000C2EF
			public unsafe Il2CppReferenceArray<DynamicMetaObject> indexes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeFieldInfoPtr_indexes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicMetaObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeFieldInfoPtr_indexes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080E RID: 2062
			// (get) Token: 0x06001C99 RID: 7321 RVA: 0x00086D48 File Offset: 0x00084F48
			// (set) Token: 0x06001C9A RID: 7322 RVA: 0x0000E10E File Offset: 0x0000C30E
			public unsafe DynamicMetaObject value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass13_0.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001534 RID: 5428
			private static readonly IntPtr NativeFieldInfoPtr_binder;

			// Token: 0x04001535 RID: 5429
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001536 RID: 5430
			private static readonly IntPtr NativeFieldInfoPtr_indexes;

			// Token: 0x04001537 RID: 5431
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04001538 RID: 5432
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001539 RID: 5433
			private static readonly IntPtr NativeMethodInfoPtr__BindSetIndex_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0;
		}

		// Token: 0x02000188 RID: 392
		[ObfuscatedName("Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x06001C9B RID: 7323 RVA: 0x00086D78 File Offset: 0x00084F78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "<>c__DisplayClass14_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass14_0>.NativeClassPtr);
				DynamicProxyMetaObject<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass14_0>.NativeClassPtr, "binder");
				DynamicProxyMetaObject<T>.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				DynamicProxyMetaObject<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass14_0>.NativeClassPtr, "indexes");
				DynamicProxyMetaObject<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass14_0>.NativeClassPtr, 100664796);
				DynamicProxyMetaObject<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__BindDeleteIndex_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass14_0>.NativeClassPtr, 100664797);
			}

			// Token: 0x06001C9C RID: 7324 RVA: 0x00086E44 File Offset: 0x00085044
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C9D RID: 7325 RVA: 0x00086E80 File Offset: 0x00085080
			[CallerCount(0)]
			public unsafe DynamicMetaObject _BindDeleteIndex_b__0(DynamicMetaObject e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass14_0.NativeMethodInfoPtr__BindDeleteIndex_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001C9E RID: 7326 RVA: 0x0000E12D File Offset: 0x0000C32D
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700080F RID: 2063
			// (get) Token: 0x06001C9F RID: 7327 RVA: 0x00086ED0 File Offset: 0x000850D0
			// (set) Token: 0x06001CA0 RID: 7328 RVA: 0x0000E136 File Offset: 0x0000C336
			public unsafe DeleteIndexBinder binder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_binder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteIndexBinder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000810 RID: 2064
			// (get) Token: 0x06001CA1 RID: 7329 RVA: 0x00086F00 File Offset: 0x00085100
			// (set) Token: 0x06001CA2 RID: 7330 RVA: 0x0000E155 File Offset: 0x0000C355
			public unsafe DynamicProxyMetaObject<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxyMetaObject<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000811 RID: 2065
			// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x00086F30 File Offset: 0x00085130
			// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x0000E174 File Offset: 0x0000C374
			public unsafe Il2CppReferenceArray<DynamicMetaObject> indexes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_indexes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicMetaObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass14_0.NativeFieldInfoPtr_indexes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400153A RID: 5434
			private static readonly IntPtr NativeFieldInfoPtr_binder;

			// Token: 0x0400153B RID: 5435
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400153C RID: 5436
			private static readonly IntPtr NativeFieldInfoPtr_indexes;

			// Token: 0x0400153D RID: 5437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400153E RID: 5438
			private static readonly IntPtr NativeMethodInfoPtr__BindDeleteIndex_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0;
		}

		// Token: 0x02000189 RID: 393
		[ObfuscatedName("Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06001CA5 RID: 7333 RVA: 0x00086F60 File Offset: 0x00085160
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "<>c__DisplayClass3_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass3_0>.NativeClassPtr);
				DynamicProxyMetaObject<T>.__c__DisplayClass3_0.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass3_0>.NativeClassPtr, "binder");
				DynamicProxyMetaObject<T>.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
				DynamicProxyMetaObject<T>.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass3_0>.NativeClassPtr, 100664798);
				DynamicProxyMetaObject<T>.__c__DisplayClass3_0.NativeMethodInfoPtr__BindGetMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass3_0>.NativeClassPtr, 100664799);
			}

			// Token: 0x06001CA6 RID: 7334 RVA: 0x00087018 File Offset: 0x00085218
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CA7 RID: 7335 RVA: 0x00087054 File Offset: 0x00085254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynamicMetaObject _BindGetMember_b__0(DynamicMetaObject e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass3_0.NativeMethodInfoPtr__BindGetMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001CA8 RID: 7336 RVA: 0x0000E193 File Offset: 0x0000C393
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000812 RID: 2066
			// (get) Token: 0x06001CA9 RID: 7337 RVA: 0x000870A4 File Offset: 0x000852A4
			// (set) Token: 0x06001CAA RID: 7338 RVA: 0x0000E19C File Offset: 0x0000C39C
			public unsafe GetMemberBinder binder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass3_0.NativeFieldInfoPtr_binder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetMemberBinder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass3_0.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000813 RID: 2067
			// (get) Token: 0x06001CAB RID: 7339 RVA: 0x000870D4 File Offset: 0x000852D4
			// (set) Token: 0x06001CAC RID: 7340 RVA: 0x0000E1BB File Offset: 0x0000C3BB
			public unsafe DynamicProxyMetaObject<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxyMetaObject<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400153F RID: 5439
			private static readonly IntPtr NativeFieldInfoPtr_binder;

			// Token: 0x04001540 RID: 5440
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001541 RID: 5441
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001542 RID: 5442
			private static readonly IntPtr NativeMethodInfoPtr__BindGetMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0;
		}

		// Token: 0x0200018A RID: 394
		[ObfuscatedName("Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06001CAD RID: 7341 RVA: 0x00087104 File Offset: 0x00085304
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "<>c__DisplayClass4_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass4_0>.NativeClassPtr);
				DynamicProxyMetaObject<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass4_0>.NativeClassPtr, "binder");
				DynamicProxyMetaObject<T>.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
				DynamicProxyMetaObject<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass4_0>.NativeClassPtr, "value");
				DynamicProxyMetaObject<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass4_0>.NativeClassPtr, 100664800);
				DynamicProxyMetaObject<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__BindSetMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass4_0>.NativeClassPtr, 100664801);
			}

			// Token: 0x06001CAE RID: 7342 RVA: 0x000871D0 File Offset: 0x000853D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CAF RID: 7343 RVA: 0x0008720C File Offset: 0x0008540C
			[CallerCount(0)]
			public unsafe DynamicMetaObject _BindSetMember_b__0(DynamicMetaObject e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass4_0.NativeMethodInfoPtr__BindSetMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001CB0 RID: 7344 RVA: 0x0000E1DA File Offset: 0x0000C3DA
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000814 RID: 2068
			// (get) Token: 0x06001CB1 RID: 7345 RVA: 0x0008725C File Offset: 0x0008545C
			// (set) Token: 0x06001CB2 RID: 7346 RVA: 0x0000E1E3 File Offset: 0x0000C3E3
			public unsafe SetMemberBinder binder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_binder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetMemberBinder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000815 RID: 2069
			// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x0008728C File Offset: 0x0008548C
			// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x0000E202 File Offset: 0x0000C402
			public unsafe DynamicProxyMetaObject<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxyMetaObject<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000816 RID: 2070
			// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x000872BC File Offset: 0x000854BC
			// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x0000E221 File Offset: 0x0000C421
			public unsafe DynamicMetaObject value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass4_0.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001543 RID: 5443
			private static readonly IntPtr NativeFieldInfoPtr_binder;

			// Token: 0x04001544 RID: 5444
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001545 RID: 5445
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04001546 RID: 5446
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001547 RID: 5447
			private static readonly IntPtr NativeMethodInfoPtr__BindSetMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0;
		}

		// Token: 0x0200018B RID: 395
		[ObfuscatedName("Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06001CB7 RID: 7351 RVA: 0x000872EC File Offset: 0x000854EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "<>c__DisplayClass5_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass5_0>.NativeClassPtr);
				DynamicProxyMetaObject<T>.__c__DisplayClass5_0.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass5_0>.NativeClassPtr, "binder");
				DynamicProxyMetaObject<T>.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				DynamicProxyMetaObject<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass5_0>.NativeClassPtr, 100664802);
				DynamicProxyMetaObject<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__BindDeleteMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass5_0>.NativeClassPtr, 100664803);
			}

			// Token: 0x06001CB8 RID: 7352 RVA: 0x000873A4 File Offset: 0x000855A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CB9 RID: 7353 RVA: 0x000873E0 File Offset: 0x000855E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynamicMetaObject _BindDeleteMember_b__0(DynamicMetaObject e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass5_0.NativeMethodInfoPtr__BindDeleteMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001CBA RID: 7354 RVA: 0x0000E240 File Offset: 0x0000C440
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000817 RID: 2071
			// (get) Token: 0x06001CBB RID: 7355 RVA: 0x00087430 File Offset: 0x00085630
			// (set) Token: 0x06001CBC RID: 7356 RVA: 0x0000E249 File Offset: 0x0000C449
			public unsafe DeleteMemberBinder binder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass5_0.NativeFieldInfoPtr_binder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeleteMemberBinder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass5_0.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000818 RID: 2072
			// (get) Token: 0x06001CBD RID: 7357 RVA: 0x00087460 File Offset: 0x00085660
			// (set) Token: 0x06001CBE RID: 7358 RVA: 0x0000E268 File Offset: 0x0000C468
			public unsafe DynamicProxyMetaObject<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxyMetaObject<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001548 RID: 5448
			private static readonly IntPtr NativeFieldInfoPtr_binder;

			// Token: 0x04001549 RID: 5449
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400154A RID: 5450
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400154B RID: 5451
			private static readonly IntPtr NativeMethodInfoPtr__BindDeleteMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0;
		}

		// Token: 0x0200018C RID: 396
		[ObfuscatedName("Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06001CBF RID: 7359 RVA: 0x00087490 File Offset: 0x00085690
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "<>c__DisplayClass6_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass6_0>.NativeClassPtr);
				DynamicProxyMetaObject<T>.__c__DisplayClass6_0.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass6_0>.NativeClassPtr, "binder");
				DynamicProxyMetaObject<T>.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				DynamicProxyMetaObject<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass6_0>.NativeClassPtr, 100664804);
				DynamicProxyMetaObject<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__BindConvert_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass6_0>.NativeClassPtr, 100664805);
			}

			// Token: 0x06001CC0 RID: 7360 RVA: 0x00087548 File Offset: 0x00085748
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CC1 RID: 7361 RVA: 0x00087584 File Offset: 0x00085784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DynamicMetaObject _BindConvert_b__0(DynamicMetaObject e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass6_0.NativeMethodInfoPtr__BindConvert_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001CC2 RID: 7362 RVA: 0x0000E287 File Offset: 0x0000C487
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000819 RID: 2073
			// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x000875D4 File Offset: 0x000857D4
			// (set) Token: 0x06001CC4 RID: 7364 RVA: 0x0000E290 File Offset: 0x0000C490
			public unsafe ConvertBinder binder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass6_0.NativeFieldInfoPtr_binder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConvertBinder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass6_0.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081A RID: 2074
			// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x00087604 File Offset: 0x00085804
			// (set) Token: 0x06001CC6 RID: 7366 RVA: 0x0000E2AF File Offset: 0x0000C4AF
			public unsafe DynamicProxyMetaObject<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxyMetaObject<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400154C RID: 5452
			private static readonly IntPtr NativeFieldInfoPtr_binder;

			// Token: 0x0400154D RID: 5453
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400154E RID: 5454
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400154F RID: 5455
			private static readonly IntPtr NativeMethodInfoPtr__BindConvert_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0;
		}

		// Token: 0x0200018D RID: 397
		[ObfuscatedName("Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06001CC7 RID: 7367 RVA: 0x00087634 File Offset: 0x00085834
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "<>c__DisplayClass7_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass7_0>.NativeClassPtr);
				DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass7_0>.NativeClassPtr, "binder");
				DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass7_0>.NativeClassPtr, "args");
				DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass7_0>.NativeClassPtr, 100664806);
				DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeMethodInfoPtr__BindInvokeMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass7_0>.NativeClassPtr, 100664807);
				DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeMethodInfoPtr__BindInvokeMember_b__1_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass7_0>.NativeClassPtr, 100664808);
			}

			// Token: 0x06001CC8 RID: 7368 RVA: 0x00087714 File Offset: 0x00085914
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CC9 RID: 7369 RVA: 0x00087750 File Offset: 0x00085950
			[CallerCount(0)]
			public unsafe DynamicMetaObject _BindInvokeMember_b__0(DynamicMetaObject e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeMethodInfoPtr__BindInvokeMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001CCA RID: 7370 RVA: 0x000877A0 File Offset: 0x000859A0
			[CallerCount(0)]
			public unsafe DynamicMetaObject _BindInvokeMember_b__1(DynamicMetaObject e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeMethodInfoPtr__BindInvokeMember_b__1_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001CCB RID: 7371 RVA: 0x0000E2CE File Offset: 0x0000C4CE
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700081B RID: 2075
			// (get) Token: 0x06001CCC RID: 7372 RVA: 0x000877F0 File Offset: 0x000859F0
			// (set) Token: 0x06001CCD RID: 7373 RVA: 0x0000E2D7 File Offset: 0x0000C4D7
			public unsafe InvokeMemberBinder binder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeFieldInfoPtr_binder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvokeMemberBinder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081C RID: 2076
			// (get) Token: 0x06001CCE RID: 7374 RVA: 0x00087820 File Offset: 0x00085A20
			// (set) Token: 0x06001CCF RID: 7375 RVA: 0x0000E2F6 File Offset: 0x0000C4F6
			public unsafe DynamicProxyMetaObject<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxyMetaObject<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081D RID: 2077
			// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x00087850 File Offset: 0x00085A50
			// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x0000E315 File Offset: 0x0000C515
			public unsafe Il2CppReferenceArray<DynamicMetaObject> args
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeFieldInfoPtr_args);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicMetaObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass7_0.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001550 RID: 5456
			private static readonly IntPtr NativeFieldInfoPtr_binder;

			// Token: 0x04001551 RID: 5457
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001552 RID: 5458
			private static readonly IntPtr NativeFieldInfoPtr_args;

			// Token: 0x04001553 RID: 5459
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001554 RID: 5460
			private static readonly IntPtr NativeMethodInfoPtr__BindInvokeMember_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0;

			// Token: 0x04001555 RID: 5461
			private static readonly IntPtr NativeMethodInfoPtr__BindInvokeMember_b__1_Internal_DynamicMetaObject_DynamicMetaObject_0;
		}

		// Token: 0x0200018E RID: 398
		[ObfuscatedName("Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06001CD2 RID: 7378 RVA: 0x00087880 File Offset: 0x00085A80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "<>c__DisplayClass8_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass8_0>.NativeClassPtr);
				DynamicProxyMetaObject<T>.__c__DisplayClass8_0.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass8_0>.NativeClassPtr, "binder");
				DynamicProxyMetaObject<T>.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				DynamicProxyMetaObject<T>.__c__DisplayClass8_0.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass8_0>.NativeClassPtr, "args");
				DynamicProxyMetaObject<T>.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass8_0>.NativeClassPtr, 100664809);
				DynamicProxyMetaObject<T>.__c__DisplayClass8_0.NativeMethodInfoPtr__BindCreateInstance_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass8_0>.NativeClassPtr, 100664810);
			}

			// Token: 0x06001CD3 RID: 7379 RVA: 0x0008794C File Offset: 0x00085B4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CD4 RID: 7380 RVA: 0x00087988 File Offset: 0x00085B88
			[CallerCount(0)]
			public unsafe DynamicMetaObject _BindCreateInstance_b__0(DynamicMetaObject e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass8_0.NativeMethodInfoPtr__BindCreateInstance_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001CD5 RID: 7381 RVA: 0x0000E334 File Offset: 0x0000C534
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700081E RID: 2078
			// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x000879D8 File Offset: 0x00085BD8
			// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x0000E33D File Offset: 0x0000C53D
			public unsafe CreateInstanceBinder binder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass8_0.NativeFieldInfoPtr_binder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateInstanceBinder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass8_0.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700081F RID: 2079
			// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x00087A08 File Offset: 0x00085C08
			// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x0000E35C File Offset: 0x0000C55C
			public unsafe DynamicProxyMetaObject<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxyMetaObject<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000820 RID: 2080
			// (get) Token: 0x06001CDA RID: 7386 RVA: 0x00087A38 File Offset: 0x00085C38
			// (set) Token: 0x06001CDB RID: 7387 RVA: 0x0000E37B File Offset: 0x0000C57B
			public unsafe Il2CppReferenceArray<DynamicMetaObject> args
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass8_0.NativeFieldInfoPtr_args);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicMetaObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass8_0.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001556 RID: 5462
			private static readonly IntPtr NativeFieldInfoPtr_binder;

			// Token: 0x04001557 RID: 5463
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001558 RID: 5464
			private static readonly IntPtr NativeFieldInfoPtr_args;

			// Token: 0x04001559 RID: 5465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400155A RID: 5466
			private static readonly IntPtr NativeMethodInfoPtr__BindCreateInstance_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0;
		}

		// Token: 0x0200018F RID: 399
		[ObfuscatedName("Newtonsoft.Json.Utilities.DynamicProxyMetaObject`1+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06001CDC RID: 7388 RVA: 0x00087A68 File Offset: 0x00085C68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicProxyMetaObject<T>>.NativeClassPtr, "<>c__DisplayClass9_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass9_0>.NativeClassPtr);
				DynamicProxyMetaObject<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass9_0>.NativeClassPtr, "binder");
				DynamicProxyMetaObject<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				DynamicProxyMetaObject<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass9_0>.NativeClassPtr, "args");
				DynamicProxyMetaObject<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass9_0>.NativeClassPtr, 100664811);
				DynamicProxyMetaObject<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__BindInvoke_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass9_0>.NativeClassPtr, 100664812);
			}

			// Token: 0x06001CDD RID: 7389 RVA: 0x00087B34 File Offset: 0x00085D34
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicProxyMetaObject<T>.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CDE RID: 7390 RVA: 0x00087B70 File Offset: 0x00085D70
			[CallerCount(0)]
			public unsafe DynamicMetaObject _BindInvoke_b__0(DynamicMetaObject e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicProxyMetaObject<T>.__c__DisplayClass9_0.NativeMethodInfoPtr__BindInvoke_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
				}
			}

			// Token: 0x06001CDF RID: 7391 RVA: 0x0000E39A File Offset: 0x0000C59A
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000821 RID: 2081
			// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x00087BC0 File Offset: 0x00085DC0
			// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x0000E3A3 File Offset: 0x0000C5A3
			public unsafe InvokeBinder binder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_binder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InvokeBinder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000822 RID: 2082
			// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x00087BF0 File Offset: 0x00085DF0
			// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x0000E3C2 File Offset: 0x0000C5C2
			public unsafe DynamicProxyMetaObject<T> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicProxyMetaObject<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000823 RID: 2083
			// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00087C20 File Offset: 0x00085E20
			// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x0000E3E1 File Offset: 0x0000C5E1
			public unsafe Il2CppReferenceArray<DynamicMetaObject> args
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_args);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicMetaObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicProxyMetaObject<T>.__c__DisplayClass9_0.NativeFieldInfoPtr_args), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400155B RID: 5467
			private static readonly IntPtr NativeFieldInfoPtr_binder;

			// Token: 0x0400155C RID: 5468
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400155D RID: 5469
			private static readonly IntPtr NativeFieldInfoPtr_args;

			// Token: 0x0400155E RID: 5470
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400155F RID: 5471
			private static readonly IntPtr NativeMethodInfoPtr__BindInvoke_b__0_Internal_DynamicMetaObject_DynamicMetaObject_0;
		}
	}
}
