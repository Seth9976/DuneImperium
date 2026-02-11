using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200041A RID: 1050
	[Serializable]
	public class MethodInfo : MethodBase
	{
		// Token: 0x06003C5A RID: 15450 RVA: 0x00121788 File Offset: 0x0011F988
		// Note: this type is marked as 'beforefieldinit'.
		static MethodInfo()
		{
			Il2CppClassPointerStore<MethodInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MethodInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr);
			MethodInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672311);
			MethodInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672312);
			MethodInfo.NativeMethodInfoPtr_get_ReturnParameter_Public_Virtual_New_get_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672313);
			MethodInfo.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672314);
			MethodInfo.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672315);
			MethodInfo.NativeMethodInfoPtr_GetGenericMethodDefinition_Public_Virtual_New_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672316);
			MethodInfo.NativeMethodInfoPtr_MakeGenericMethod_Public_Virtual_New_MethodInfo_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672317);
			MethodInfo.NativeMethodInfoPtr_GetBaseDefinition_Public_Abstract_Virtual_New_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672318);
			MethodInfo.NativeMethodInfoPtr_CreateDelegate_Public_Virtual_New_Delegate_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672319);
			MethodInfo.NativeMethodInfoPtr_CreateDelegate_Public_Virtual_New_Delegate_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672320);
			MethodInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672321);
			MethodInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672322);
			MethodInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MethodInfo_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672323);
			MethodInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MethodInfo_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672324);
			MethodInfo.NativeMethodInfoPtr_get_GenericParameterCount_Internal_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr, 100672325);
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x001218E4 File Offset: 0x0011FAE4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethodInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x06003C5C RID: 15452 RVA: 0x00121920 File Offset: 0x0011FB20
		public unsafe override MemberTypes MemberType
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 72449, RefRangeEnd = 72472, XrefRangeStart = 72449, XrefRangeEnd = 72472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x00121968 File Offset: 0x0011FB68
		public unsafe virtual ParameterInfo ReturnParameter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398852, XrefRangeEnd = 1398855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_get_ReturnParameter_Public_Virtual_New_get_ParameterInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06003C5E RID: 15454 RVA: 0x001219B4 File Offset: 0x0011FBB4
		public unsafe virtual Type ReturnType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398855, XrefRangeEnd = 1398858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x00121A00 File Offset: 0x0011FC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398858, XrefRangeEnd = 1398864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Type> GetGenericArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x00121A4C File Offset: 0x0011FC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398864, XrefRangeEnd = 1398870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo GetGenericMethodDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_GetGenericMethodDefinition_Public_Virtual_New_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x00121A98 File Offset: 0x0011FC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398870, XrefRangeEnd = 1398876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodInfo MakeGenericMethod([Optional] Il2CppReferenceArray<Type> typeArguments)
		{
			if (typeArguments == null)
			{
				typeArguments = new Il2CppReferenceArray<Type>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeArguments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_MakeGenericMethod_Public_Virtual_New_MethodInfo_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x00121B00 File Offset: 0x0011FD00
		[CallerCount(0)]
		public unsafe virtual MethodInfo GetBaseDefinition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_GetBaseDefinition_Public_Abstract_Virtual_New_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x00121B4C File Offset: 0x0011FD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398876, XrefRangeEnd = 1398882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Delegate CreateDelegate(Type delegateType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_CreateDelegate_Public_Virtual_New_Delegate_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x00121BA8 File Offset: 0x0011FDA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398882, XrefRangeEnd = 1398888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Delegate CreateDelegate(Type delegateType, Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_CreateDelegate_Public_Virtual_New_Delegate_Type_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x00121C18 File Offset: 0x0011FE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x00121C70 File Offset: 0x0011FE70
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 389658, RefRangeEnd = 389671, XrefRangeStart = 389658, XrefRangeEnd = 389671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x00121CB8 File Offset: 0x0011FEB8
		[CallerCount(239)]
		[CachedScanResults(RefRangeStart = 1347122, RefRangeEnd = 1347361, XrefRangeStart = 1347122, XrefRangeEnd = 1347361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(MethodInfo left, MethodInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MethodInfo_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x00121D0C File Offset: 0x0011FF0C
		[CallerCount(154)]
		[CachedScanResults(RefRangeStart = 1398150, RefRangeEnd = 1398304, XrefRangeStart = 1398150, XrefRangeEnd = 1398304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(MethodInfo left, MethodInfo right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MethodInfo_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06003C69 RID: 15465 RVA: 0x00121D60 File Offset: 0x0011FF60
		public unsafe virtual int GenericParameterCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfo.NativeMethodInfoPtr_get_GenericParameterCount_Internal_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x000165E3 File Offset: 0x000147E3
		public virtual MethodInfo MakeGenericMethod(params Type[] typeArguments)
		{
			return this.MakeGenericMethod(new Il2CppReferenceArray<Type>(typeArguments));
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x000165F1 File Offset: 0x000147F1
		public MethodInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400312F RID: 12591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04003130 RID: 12592
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_get_MemberTypes_0;

		// Token: 0x04003131 RID: 12593
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnParameter_Public_Virtual_New_get_ParameterInfo_0;

		// Token: 0x04003132 RID: 12594
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_New_get_Type_0;

		// Token: 0x04003133 RID: 12595
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Virtual_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003134 RID: 12596
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericMethodDefinition_Public_Virtual_New_MethodInfo_0;

		// Token: 0x04003135 RID: 12597
		private static readonly IntPtr NativeMethodInfoPtr_MakeGenericMethod_Public_Virtual_New_MethodInfo_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04003136 RID: 12598
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseDefinition_Public_Abstract_Virtual_New_MethodInfo_0;

		// Token: 0x04003137 RID: 12599
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Virtual_New_Delegate_Type_0;

		// Token: 0x04003138 RID: 12600
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Virtual_New_Delegate_Type_Object_0;

		// Token: 0x04003139 RID: 12601
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400313A RID: 12602
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400313B RID: 12603
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MethodInfo_MethodInfo_0;

		// Token: 0x0400313C RID: 12604
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MethodInfo_MethodInfo_0;

		// Token: 0x0400313D RID: 12605
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericParameterCount_Internal_Virtual_New_get_Int32_0;
	}
}
