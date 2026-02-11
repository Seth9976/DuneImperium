using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000064 RID: 100
	public class ReflectionDelegateFactory : Object
	{
		// Token: 0x060008C7 RID: 2247 RVA: 0x0003ADFC File Offset: 0x00038FFC
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionDelegateFactory()
		{
			Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "ReflectionDelegateFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr);
			ReflectionDelegateFactory.NativeMethodInfoPtr_CreateGet_Public_Func_2_T_Object_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr, 100664976);
			ReflectionDelegateFactory.NativeMethodInfoPtr_CreateSet_Public_Action_2_T_Object_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr, 100664977);
			ReflectionDelegateFactory.NativeMethodInfoPtr_CreateMethodCall_Public_Abstract_Virtual_New_MethodCall_2_T_Object_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr, 100664978);
			ReflectionDelegateFactory.NativeMethodInfoPtr_CreateParameterizedConstructor_Public_Abstract_Virtual_New_ObjectConstructor_1_Object_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr, 100664979);
			ReflectionDelegateFactory.NativeMethodInfoPtr_CreateDefaultConstructor_Public_Abstract_Virtual_New_Func_1_T_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr, 100664980);
			ReflectionDelegateFactory.NativeMethodInfoPtr_CreateGet_Public_Abstract_Virtual_New_Func_2_T_Object_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr, 100664981);
			ReflectionDelegateFactory.NativeMethodInfoPtr_CreateGet_Public_Abstract_Virtual_New_Func_2_T_Object_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr, 100664982);
			ReflectionDelegateFactory.NativeMethodInfoPtr_CreateSet_Public_Abstract_Virtual_New_Action_2_T_Object_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr, 100664983);
			ReflectionDelegateFactory.NativeMethodInfoPtr_CreateSet_Public_Abstract_Virtual_New_Action_2_T_Object_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr, 100664984);
			ReflectionDelegateFactory.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr, 100664985);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0003AEF4 File Offset: 0x000390F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 744799, RefRangeEnd = 744802, XrefRangeStart = 744769, XrefRangeEnd = 744799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<T, Object> CreateGet<T>(MemberInfo memberInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionDelegateFactory.MethodInfoStoreGeneric_CreateGet_Public_Func_2_T_Object_MemberInfo_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0003AF44 File Offset: 0x00039144
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 744821, RefRangeEnd = 744824, XrefRangeStart = 744802, XrefRangeEnd = 744821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action<T, Object> CreateSet<T>(MemberInfo memberInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionDelegateFactory.MethodInfoStoreGeneric_CreateSet_Public_Action_2_T_Object_MemberInfo_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<T, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0003AF94 File Offset: 0x00039194
		[CallerCount(0)]
		public unsafe virtual MethodCall<T, Object> CreateMethodCall<T>(MethodBase method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReflectionDelegateFactory.MethodInfoStoreGeneric_CreateMethodCall_Public_Abstract_Virtual_New_MethodCall_2_T_Object_MethodBase_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCall<T, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0003AFF0 File Offset: 0x000391F0
		[CallerCount(0)]
		public unsafe virtual ObjectConstructor<Object> CreateParameterizedConstructor(MethodBase method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReflectionDelegateFactory.NativeMethodInfoPtr_CreateParameterizedConstructor_Public_Abstract_Virtual_New_ObjectConstructor_1_Object_MethodBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0003B04C File Offset: 0x0003924C
		[CallerCount(0)]
		public unsafe virtual Func<T> CreateDefaultConstructor<T>(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReflectionDelegateFactory.MethodInfoStoreGeneric_CreateDefaultConstructor_Public_Abstract_Virtual_New_Func_1_T_Type_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0003B0A8 File Offset: 0x000392A8
		[CallerCount(0)]
		public unsafe virtual Func<T, Object> CreateGet<T>(PropertyInfo propertyInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReflectionDelegateFactory.MethodInfoStoreGeneric_CreateGet_Public_Abstract_Virtual_New_Func_2_T_Object_PropertyInfo_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0003B104 File Offset: 0x00039304
		[CallerCount(0)]
		public unsafe virtual Func<T, Object> CreateGet<T>(FieldInfo fieldInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fieldInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReflectionDelegateFactory.MethodInfoStoreGeneric_CreateGet_Public_Abstract_Virtual_New_Func_2_T_Object_FieldInfo_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<T, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0003B160 File Offset: 0x00039360
		[CallerCount(0)]
		public unsafe virtual Action<T, Object> CreateSet<T>(FieldInfo fieldInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fieldInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReflectionDelegateFactory.MethodInfoStoreGeneric_CreateSet_Public_Abstract_Virtual_New_Action_2_T_Object_FieldInfo_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<T, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0003B1BC File Offset: 0x000393BC
		[CallerCount(0)]
		public unsafe virtual Action<T, Object> CreateSet<T>(PropertyInfo propertyInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReflectionDelegateFactory.MethodInfoStoreGeneric_CreateSet_Public_Abstract_Virtual_New_Action_2_T_Object_PropertyInfo_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<T, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0003B218 File Offset: 0x00039418
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionDelegateFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionDelegateFactory.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00004C29 File Offset: 0x00002E29
		public ReflectionDelegateFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeMethodInfoPtr_CreateGet_Public_Func_2_T_Object_MemberInfo_0;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeMethodInfoPtr_CreateSet_Public_Action_2_T_Object_MemberInfo_0;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeMethodInfoPtr_CreateMethodCall_Public_Abstract_Virtual_New_MethodCall_2_T_Object_MethodBase_0;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_CreateParameterizedConstructor_Public_Abstract_Virtual_New_ObjectConstructor_1_Object_MethodBase_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultConstructor_Public_Abstract_Virtual_New_Func_1_T_Type_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_CreateGet_Public_Abstract_Virtual_New_Func_2_T_Object_PropertyInfo_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_CreateGet_Public_Abstract_Virtual_New_Func_2_T_Object_FieldInfo_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_CreateSet_Public_Abstract_Virtual_New_Action_2_T_Object_FieldInfo_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_CreateSet_Public_Abstract_Virtual_New_Action_2_T_Object_PropertyInfo_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020001AC RID: 428
		private sealed class MethodInfoStoreGeneric_CreateGet_Public_Func_2_T_Object_MemberInfo_0<T>
		{
			// Token: 0x040015E2 RID: 5602
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionDelegateFactory.NativeMethodInfoPtr_CreateGet_Public_Func_2_T_Object_MemberInfo_0, Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AD RID: 429
		private sealed class MethodInfoStoreGeneric_CreateSet_Public_Action_2_T_Object_MemberInfo_0<T>
		{
			// Token: 0x040015E3 RID: 5603
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionDelegateFactory.NativeMethodInfoPtr_CreateSet_Public_Action_2_T_Object_MemberInfo_0, Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AE RID: 430
		private sealed class MethodInfoStoreGeneric_CreateMethodCall_Public_Abstract_Virtual_New_MethodCall_2_T_Object_MethodBase_0<T>
		{
			// Token: 0x040015E4 RID: 5604
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionDelegateFactory.NativeMethodInfoPtr_CreateMethodCall_Public_Abstract_Virtual_New_MethodCall_2_T_Object_MethodBase_0, Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001AF RID: 431
		private sealed class MethodInfoStoreGeneric_CreateDefaultConstructor_Public_Abstract_Virtual_New_Func_1_T_Type_0<T>
		{
			// Token: 0x040015E5 RID: 5605
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionDelegateFactory.NativeMethodInfoPtr_CreateDefaultConstructor_Public_Abstract_Virtual_New_Func_1_T_Type_0, Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001B0 RID: 432
		private sealed class MethodInfoStoreGeneric_CreateGet_Public_Abstract_Virtual_New_Func_2_T_Object_PropertyInfo_0<T>
		{
			// Token: 0x040015E6 RID: 5606
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionDelegateFactory.NativeMethodInfoPtr_CreateGet_Public_Abstract_Virtual_New_Func_2_T_Object_PropertyInfo_0, Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001B1 RID: 433
		private sealed class MethodInfoStoreGeneric_CreateGet_Public_Abstract_Virtual_New_Func_2_T_Object_FieldInfo_0<T>
		{
			// Token: 0x040015E7 RID: 5607
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionDelegateFactory.NativeMethodInfoPtr_CreateGet_Public_Abstract_Virtual_New_Func_2_T_Object_FieldInfo_0, Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001B2 RID: 434
		private sealed class MethodInfoStoreGeneric_CreateSet_Public_Abstract_Virtual_New_Action_2_T_Object_FieldInfo_0<T>
		{
			// Token: 0x040015E8 RID: 5608
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionDelegateFactory.NativeMethodInfoPtr_CreateSet_Public_Abstract_Virtual_New_Action_2_T_Object_FieldInfo_0, Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020001B3 RID: 435
		private sealed class MethodInfoStoreGeneric_CreateSet_Public_Abstract_Virtual_New_Action_2_T_Object_PropertyInfo_0<T>
		{
			// Token: 0x040015E9 RID: 5609
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReflectionDelegateFactory.NativeMethodInfoPtr_CreateSet_Public_Abstract_Virtual_New_Action_2_T_Object_PropertyInfo_0, Il2CppClassPointerStore<ReflectionDelegateFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
