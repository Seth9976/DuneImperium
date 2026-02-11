using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200014A RID: 330
	[Serializable]
	public class Delegate : Object
	{
		// Token: 0x060016F9 RID: 5881 RVA: 0x000939F0 File Offset: 0x00091BF0
		// Note: this type is marked as 'beforefieldinit'.
		static Delegate()
		{
			Il2CppClassPointerStore<Delegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Delegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Delegate>.NativeClassPtr);
			Delegate.NativeFieldInfoPtr_method_ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method_ptr");
			Delegate.NativeFieldInfoPtr_invoke_impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "invoke_impl");
			Delegate.NativeFieldInfoPtr_m_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "m_target");
			Delegate.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method");
			Delegate.NativeFieldInfoPtr_delegate_trampoline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "delegate_trampoline");
			Delegate.NativeFieldInfoPtr_extra_arg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "extra_arg");
			Delegate.NativeFieldInfoPtr_method_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method_code");
			Delegate.NativeFieldInfoPtr_interp_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "interp_method");
			Delegate.NativeFieldInfoPtr_interp_invoke_impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "interp_invoke_impl");
			Delegate.NativeFieldInfoPtr_method_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method_info");
			Delegate.NativeFieldInfoPtr_original_method_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "original_method_info");
			Delegate.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "data");
			Delegate.NativeFieldInfoPtr_method_is_virtual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Delegate>.NativeClassPtr, "method_is_virtual");
			Delegate.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667325);
			Delegate.NativeMethodInfoPtr_GetVirtualMethod_internal_Private_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667326);
			Delegate.NativeMethodInfoPtr_get_Target_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667327);
			Delegate.NativeMethodInfoPtr_CreateDelegate_internal_Internal_Static_Delegate_Type_Object_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667328);
			Delegate.NativeMethodInfoPtr_arg_type_match_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667329);
			Delegate.NativeMethodInfoPtr_arg_type_match_this_Private_Static_Boolean_Type_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667330);
			Delegate.NativeMethodInfoPtr_return_type_match_Private_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667331);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Private_Static_Delegate_Type_Object_MethodInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667332);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667333);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667334);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667335);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667336);
			Delegate.NativeMethodInfoPtr_GetCandidateMethod_Private_Static_MethodInfo_Type_Type_String_BindingFlags_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667337);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667338);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667339);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667340);
			Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667341);
			Delegate.NativeMethodInfoPtr_DynamicInvoke_Public_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667342);
			Delegate.NativeMethodInfoPtr_InitializeDelegateData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667343);
			Delegate.NativeMethodInfoPtr_DynamicInvokeImpl_Protected_Virtual_New_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667344);
			Delegate.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667345);
			Delegate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667346);
			Delegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667347);
			Delegate.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_New_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667348);
			Delegate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667349);
			Delegate.NativeMethodInfoPtr_GetInvocationList_Public_Virtual_New_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667350);
			Delegate.NativeMethodInfoPtr_Combine_Public_Static_Delegate_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667351);
			Delegate.NativeMethodInfoPtr_Combine_Public_Static_Delegate_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667352);
			Delegate.NativeMethodInfoPtr_CombineImpl_Protected_Virtual_New_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667353);
			Delegate.NativeMethodInfoPtr_Remove_Public_Static_Delegate_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667354);
			Delegate.NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_New_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667355);
			Delegate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667356);
			Delegate.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667357);
			Delegate.NativeMethodInfoPtr_AllocDelegateLike_internal_Internal_Static_MulticastDelegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Delegate>.NativeClassPtr, 100667358);
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x00093DCC File Offset: 0x00091FCC
		public unsafe MethodInfo Method
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 381934, RefRangeEnd = 381975, XrefRangeStart = 381934, XrefRangeEnd = 381975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00093E0C File Offset: 0x0009200C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345248, XrefRangeEnd = 1345249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo GetVirtualMethod_internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_GetVirtualMethod_internal_Private_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x00093E4C File Offset: 0x0009204C
		public unsafe Object Target
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_get_Target_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00093E8C File Offset: 0x0009208C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345249, XrefRangeEnd = 1345250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate_internal(Type type, Object target, MethodInfo info, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_internal_Internal_Static_Delegate_Type_Object_MethodInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00093F04 File Offset: 0x00092104
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1345268, RefRangeEnd = 1345274, XrefRangeStart = 1345250, XrefRangeEnd = 1345268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool arg_type_match(Type delArgType, Type argType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delArgType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_arg_type_match_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00093F58 File Offset: 0x00092158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1345280, RefRangeEnd = 1345281, XrefRangeStart = 1345274, XrefRangeEnd = 1345280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delArgType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref boxedThis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_arg_type_match_this_Private_Static_Boolean_Type_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00093FBC File Offset: 0x000921BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1345287, RefRangeEnd = 1345289, XrefRangeStart = 1345281, XrefRangeEnd = 1345287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool return_type_match(Type delReturnType, Type returnType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delReturnType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_return_type_match_Private_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00094010 File Offset: 0x00092210
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1345330, RefRangeEnd = 1345334, XrefRangeStart = 1345289, XrefRangeEnd = 1345330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstArgument);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowClosed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Private_Static_Delegate_Type_Object_MethodInfo_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00094094 File Offset: 0x00092294
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1345335, RefRangeEnd = 1345350, XrefRangeStart = 1345334, XrefRangeEnd = 1345335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object firstArgument, MethodInfo method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstArgument);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x000940FC File Offset: 0x000922FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345350, XrefRangeEnd = 1345351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x00094160 File Offset: 0x00092360
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1345352, RefRangeEnd = 1345359, XrefRangeStart = 1345351, XrefRangeEnd = 1345352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, MethodInfo method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x000941B8 File Offset: 0x000923B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345359, XrefRangeEnd = 1345363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object target, string method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x00094220 File Offset: 0x00092420
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1345395, RefRangeEnd = 1345401, XrefRangeStart = 1345363, XrefRangeEnd = 1345395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bflags;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_GetCandidateMethod_Private_Static_MethodInfo_Type_Type_String_BindingFlags_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x000942B4 File Offset: 0x000924B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345401, XrefRangeEnd = 1345408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00094338 File Offset: 0x00092538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345408, XrefRangeEnd = 1345415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Type target, string method)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x000943A0 File Offset: 0x000925A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345415, XrefRangeEnd = 1345419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object target, string method, bool ignoreCase, bool throwOnBindFailure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnBindFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x00094424 File Offset: 0x00092624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345419, XrefRangeEnd = 1345423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate CreateDelegate(Type type, Object target, string method, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(method);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x0009449C File Offset: 0x0009269C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 375631, RefRangeEnd = 375635, XrefRangeStart = 375631, XrefRangeEnd = 375635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object DynamicInvoke([Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_DynamicInvoke_Public_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x000944FC File Offset: 0x000926FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345423, XrefRangeEnd = 1345434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDelegateData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_InitializeDelegateData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00094530 File Offset: 0x00092730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345434, XrefRangeEnd = 1345472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object DynamicInvokeImpl(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_DynamicInvokeImpl_Protected_Virtual_New_Object_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x0009458C File Offset: 0x0009278C
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 1345473, RefRangeEnd = 1345530, XrefRangeStart = 1345472, XrefRangeEnd = 1345473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x000945D8 File Offset: 0x000927D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1345535, RefRangeEnd = 1345536, XrefRangeStart = 1345530, XrefRangeEnd = 1345535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00094630 File Offset: 0x00092830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345536, XrefRangeEnd = 1345540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00094678 File Offset: 0x00092878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345540, XrefRangeEnd = 1345544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetMethodImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_New_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x000946C4 File Offset: 0x000928C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345544, XrefRangeEnd = 1345572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00094728 File Offset: 0x00092928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345572, XrefRangeEnd = 1345577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<Delegate> GetInvocationList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_GetInvocationList_Public_Virtual_New_Il2CppReferenceArray_1_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Delegate>>(intPtr3) : null;
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00094774 File Offset: 0x00092974
		[CallerCount(327)]
		[CachedScanResults(RefRangeStart = 1345583, RefRangeEnd = 1345910, XrefRangeStart = 1345577, XrefRangeEnd = 1345583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate Combine(Delegate a, Delegate b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_Combine_Public_Static_Delegate_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000947CC File Offset: 0x000929CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1345918, RefRangeEnd = 1345921, XrefRangeStart = 1345910, XrefRangeEnd = 1345918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate Combine([Optional] Il2CppReferenceArray<Delegate> delegates)
		{
			if (delegates == null)
			{
				delegates = new Il2CppReferenceArray<Delegate>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegates);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_Combine_Public_Static_Delegate_Il2CppReferenceArray_1_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00094820 File Offset: 0x00092A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345921, XrefRangeEnd = 1345928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Delegate CombineImpl(Delegate d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_CombineImpl_Protected_Virtual_New_Delegate_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0009487C File Offset: 0x00092A7C
		[CallerCount(295)]
		[CachedScanResults(RefRangeStart = 1345934, RefRangeEnd = 1346229, XrefRangeStart = 1345928, XrefRangeEnd = 1345934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate Remove(Delegate source, Delegate value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_Remove_Public_Static_Delegate_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x000948D4 File Offset: 0x00092AD4
		[CallerCount(0)]
		public unsafe virtual Delegate RemoveImpl(Delegate d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Delegate.NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_New_Delegate_Delegate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00094930 File Offset: 0x00092B30
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1346229, RefRangeEnd = 1346239, XrefRangeStart = 1346229, XrefRangeEnd = 1346229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Delegate d1, Delegate d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00094984 File Offset: 0x00092B84
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1346239, RefRangeEnd = 1346250, XrefRangeStart = 1346239, XrefRangeEnd = 1346239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Delegate d1, Delegate d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Delegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x000949D8 File Offset: 0x00092BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346250, XrefRangeEnd = 1346251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MulticastDelegate AllocDelegateLike_internal(Delegate d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Delegate.NativeMethodInfoPtr_AllocDelegateLike_internal_Internal_Static_MulticastDelegate_Delegate_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MulticastDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00007477 File Offset: 0x00005677
		public Object DynamicInvoke(params Object[] args)
		{
			return this.DynamicInvoke(new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00007485 File Offset: 0x00005685
		public static Delegate Combine(params Delegate[] delegates)
		{
			return Delegate.Combine(new Il2CppReferenceArray<Delegate>(delegates));
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00007492 File Offset: 0x00005692
		public Delegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x00094A1C File Offset: 0x00092C1C
		// (set) Token: 0x06001720 RID: 5920 RVA: 0x0000749B File Offset: 0x0000569B
		public unsafe IntPtr method_ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_ptr)) = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x00094A44 File Offset: 0x00092C44
		// (set) Token: 0x06001722 RID: 5922 RVA: 0x000074B6 File Offset: 0x000056B6
		public unsafe IntPtr invoke_impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_invoke_impl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_invoke_impl)) = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x00094A6C File Offset: 0x00092C6C
		// (set) Token: 0x06001724 RID: 5924 RVA: 0x000074D1 File Offset: 0x000056D1
		public unsafe Object m_target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_m_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_m_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x00094A9C File Offset: 0x00092C9C
		// (set) Token: 0x06001726 RID: 5926 RVA: 0x000074F0 File Offset: 0x000056F0
		public unsafe IntPtr method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method)) = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x00094AC4 File Offset: 0x00092CC4
		// (set) Token: 0x06001728 RID: 5928 RVA: 0x0000750B File Offset: 0x0000570B
		public unsafe IntPtr delegate_trampoline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_delegate_trampoline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_delegate_trampoline)) = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x00094AEC File Offset: 0x00092CEC
		// (set) Token: 0x0600172A RID: 5930 RVA: 0x00007526 File Offset: 0x00005726
		public unsafe IntPtr extra_arg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_extra_arg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_extra_arg)) = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x00094B14 File Offset: 0x00092D14
		// (set) Token: 0x0600172C RID: 5932 RVA: 0x00007541 File Offset: 0x00005741
		public unsafe IntPtr method_code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_code);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_code)) = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x00094B3C File Offset: 0x00092D3C
		// (set) Token: 0x0600172E RID: 5934 RVA: 0x0000755C File Offset: 0x0000575C
		public unsafe IntPtr interp_method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_interp_method);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_interp_method)) = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x00094B64 File Offset: 0x00092D64
		// (set) Token: 0x06001730 RID: 5936 RVA: 0x00007577 File Offset: 0x00005777
		public unsafe IntPtr interp_invoke_impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_interp_invoke_impl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_interp_invoke_impl)) = value;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x00094B8C File Offset: 0x00092D8C
		// (set) Token: 0x06001732 RID: 5938 RVA: 0x00007592 File Offset: 0x00005792
		public unsafe MethodInfo method_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x00094BBC File Offset: 0x00092DBC
		// (set) Token: 0x06001734 RID: 5940 RVA: 0x000075B1 File Offset: 0x000057B1
		public unsafe MethodInfo original_method_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_original_method_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_original_method_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x00094BEC File Offset: 0x00092DEC
		// (set) Token: 0x06001736 RID: 5942 RVA: 0x000075D0 File Offset: 0x000057D0
		public unsafe DelegateData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00094C1C File Offset: 0x00092E1C
		// (set) Token: 0x06001738 RID: 5944 RVA: 0x000075EF File Offset: 0x000057EF
		public unsafe bool method_is_virtual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_is_virtual);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Delegate.NativeFieldInfoPtr_method_is_virtual)) = value;
			}
		}

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeFieldInfoPtr_method_ptr;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeFieldInfoPtr_invoke_impl;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeFieldInfoPtr_m_target;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeFieldInfoPtr_delegate_trampoline;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeFieldInfoPtr_extra_arg;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeFieldInfoPtr_method_code;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeFieldInfoPtr_interp_method;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeFieldInfoPtr_interp_invoke_impl;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeFieldInfoPtr_method_info;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeFieldInfoPtr_original_method_info;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeFieldInfoPtr_method_is_virtual;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeMethodInfoPtr_GetVirtualMethod_internal_Private_MethodInfo_0;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Object_0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_internal_Internal_Static_Delegate_Type_Object_MethodInfo_Boolean_0;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr_arg_type_match_Private_Static_Boolean_Type_Type_0;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr_arg_type_match_this_Private_Static_Boolean_Type_Type_Boolean_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr_return_type_match_Private_Static_Boolean_Type_Type_0;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Private_Static_Delegate_Type_Object_MethodInfo_Boolean_Boolean_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_MethodInfo_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_Boolean_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_MethodInfo_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_0;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeMethodInfoPtr_GetCandidateMethod_Private_Static_MethodInfo_Type_Type_String_BindingFlags_Boolean_Boolean_0;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_Boolean_Boolean_0;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Type_String_0;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_Boolean_0;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Static_Delegate_Type_Object_String_Boolean_0;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeMethodInfoPtr_DynamicInvoke_Public_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDelegateData_Private_Void_0;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeMethodInfoPtr_DynamicInvokeImpl_Protected_Virtual_New_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_New_Object_0;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_New_MethodInfo_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_GetInvocationList_Public_Virtual_New_Il2CppReferenceArray_1_Delegate_0;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Delegate_Delegate_Delegate_0;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Delegate_Il2CppReferenceArray_1_Delegate_0;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr_CombineImpl_Protected_Virtual_New_Delegate_Delegate_0;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Static_Delegate_Delegate_Delegate_0;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_New_Delegate_Delegate_0;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Delegate_Delegate_0;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Delegate_Delegate_0;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeMethodInfoPtr_AllocDelegateLike_internal_Internal_Static_MulticastDelegate_Delegate_0;
	}
}
