using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq.Expressions;

namespace Il2CppSystem.Dynamic
{
	// Token: 0x0200011A RID: 282
	public class DynamicMetaObject : Object
	{
		// Token: 0x06001096 RID: 4246 RVA: 0x0005715C File Offset: 0x0005535C
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicMetaObject()
		{
			Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic", "DynamicMetaObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr);
			DynamicMetaObject.NativeFieldInfoPtr_EmptyMetaObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, "EmptyMetaObjects");
			DynamicMetaObject.NativeFieldInfoPtr_s_noValueSentinel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, "s_noValueSentinel");
			DynamicMetaObject.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, "_value");
			DynamicMetaObject.NativeFieldInfoPtr__Expression_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, "<Expression>k__BackingField");
			DynamicMetaObject.NativeFieldInfoPtr__Restrictions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, "<Restrictions>k__BackingField");
			DynamicMetaObject.NativeMethodInfoPtr__ctor_Public_Void_Expression_BindingRestrictions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666398);
			DynamicMetaObject.NativeMethodInfoPtr__ctor_Public_Void_Expression_BindingRestrictions_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666399);
			DynamicMetaObject.NativeMethodInfoPtr_get_Expression_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666400);
			DynamicMetaObject.NativeMethodInfoPtr_get_Restrictions_Public_get_BindingRestrictions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666401);
			DynamicMetaObject.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666402);
			DynamicMetaObject.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666403);
			DynamicMetaObject.NativeMethodInfoPtr_get_RuntimeType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666404);
			DynamicMetaObject.NativeMethodInfoPtr_get_LimitType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666405);
			DynamicMetaObject.NativeMethodInfoPtr_BindConvert_Public_Virtual_New_DynamicMetaObject_ConvertBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666406);
			DynamicMetaObject.NativeMethodInfoPtr_BindGetMember_Public_Virtual_New_DynamicMetaObject_GetMemberBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666407);
			DynamicMetaObject.NativeMethodInfoPtr_BindSetMember_Public_Virtual_New_DynamicMetaObject_SetMemberBinder_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666408);
			DynamicMetaObject.NativeMethodInfoPtr_BindDeleteMember_Public_Virtual_New_DynamicMetaObject_DeleteMemberBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666409);
			DynamicMetaObject.NativeMethodInfoPtr_BindGetIndex_Public_Virtual_New_DynamicMetaObject_GetIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666410);
			DynamicMetaObject.NativeMethodInfoPtr_BindSetIndex_Public_Virtual_New_DynamicMetaObject_SetIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666411);
			DynamicMetaObject.NativeMethodInfoPtr_BindDeleteIndex_Public_Virtual_New_DynamicMetaObject_DeleteIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666412);
			DynamicMetaObject.NativeMethodInfoPtr_BindInvokeMember_Public_Virtual_New_DynamicMetaObject_InvokeMemberBinder_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666413);
			DynamicMetaObject.NativeMethodInfoPtr_BindInvoke_Public_Virtual_New_DynamicMetaObject_InvokeBinder_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666414);
			DynamicMetaObject.NativeMethodInfoPtr_BindCreateInstance_Public_Virtual_New_DynamicMetaObject_CreateInstanceBinder_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666415);
			DynamicMetaObject.NativeMethodInfoPtr_BindUnaryOperation_Public_Virtual_New_DynamicMetaObject_UnaryOperationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666416);
			DynamicMetaObject.NativeMethodInfoPtr_BindBinaryOperation_Public_Virtual_New_DynamicMetaObject_BinaryOperationBinder_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666417);
			DynamicMetaObject.NativeMethodInfoPtr_GetDynamicMemberNames_Public_Virtual_New_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666418);
			DynamicMetaObject.NativeMethodInfoPtr_Create_Public_Static_DynamicMetaObject_Object_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr, 100666419);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x000573A8 File Offset: 0x000555A8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1028311, RefRangeEnd = 1028323, XrefRangeStart = 1028297, XrefRangeEnd = 1028311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicMetaObject(Expression expression, BindingRestrictions restrictions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(restrictions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMetaObject.NativeMethodInfoPtr__ctor_Public_Void_Expression_BindingRestrictions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00057408 File Offset: 0x00055608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1028338, RefRangeEnd = 1028340, XrefRangeStart = 1028323, XrefRangeEnd = 1028338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicMetaObject(Expression expression, BindingRestrictions restrictions, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicMetaObject>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(restrictions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMetaObject.NativeMethodInfoPtr__ctor_Public_Void_Expression_BindingRestrictions_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x00057478 File Offset: 0x00055678
		public unsafe Expression Expression
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMetaObject.NativeMethodInfoPtr_get_Expression_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x000574B8 File Offset: 0x000556B8
		public unsafe BindingRestrictions Restrictions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMetaObject.NativeMethodInfoPtr_get_Restrictions_Public_get_BindingRestrictions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BindingRestrictions>(intPtr3) : null;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x000574F8 File Offset: 0x000556F8
		public unsafe Object Value
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1028344, RefRangeEnd = 1028362, XrefRangeStart = 1028340, XrefRangeEnd = 1028344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMetaObject.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00057538 File Offset: 0x00055738
		public unsafe bool HasValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1028366, RefRangeEnd = 1028367, XrefRangeStart = 1028362, XrefRangeEnd = 1028366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMetaObject.NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x00057574 File Offset: 0x00055774
		public unsafe Type RuntimeType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028367, XrefRangeEnd = 1028374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMetaObject.NativeMethodInfoPtr_get_RuntimeType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x000575B4 File Offset: 0x000557B4
		public unsafe Type LimitType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1028381, RefRangeEnd = 1028384, XrefRangeStart = 1028374, XrefRangeEnd = 1028381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMetaObject.NativeMethodInfoPtr_get_LimitType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x000575F4 File Offset: 0x000557F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028384, XrefRangeEnd = 1028388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicMetaObject BindConvert(ConvertBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObject.NativeMethodInfoPtr_BindConvert_Public_Virtual_New_DynamicMetaObject_ConvertBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00057650 File Offset: 0x00055850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028388, XrefRangeEnd = 1028393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicMetaObject BindGetMember(GetMemberBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObject.NativeMethodInfoPtr_BindGetMember_Public_Virtual_New_DynamicMetaObject_GetMemberBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x000576AC File Offset: 0x000558AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028393, XrefRangeEnd = 1028398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObject.NativeMethodInfoPtr_BindSetMember_Public_Virtual_New_DynamicMetaObject_SetMemberBinder_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0005771C File Offset: 0x0005591C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028398, XrefRangeEnd = 1028402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObject.NativeMethodInfoPtr_BindDeleteMember_Public_Virtual_New_DynamicMetaObject_DeleteMemberBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00057778 File Offset: 0x00055978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028402, XrefRangeEnd = 1028407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicMetaObject BindGetIndex(GetIndexBinder binder, Il2CppReferenceArray<DynamicMetaObject> indexes)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObject.NativeMethodInfoPtr_BindGetIndex_Public_Virtual_New_DynamicMetaObject_GetIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x000577E8 File Offset: 0x000559E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028407, XrefRangeEnd = 1028412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicMetaObject BindSetIndex(SetIndexBinder binder, Il2CppReferenceArray<DynamicMetaObject> indexes, DynamicMetaObject value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObject.NativeMethodInfoPtr_BindSetIndex_Public_Virtual_New_DynamicMetaObject_SetIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00057868 File Offset: 0x00055A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028412, XrefRangeEnd = 1028415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, Il2CppReferenceArray<DynamicMetaObject> indexes)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObject.NativeMethodInfoPtr_BindDeleteIndex_Public_Virtual_New_DynamicMetaObject_DeleteIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x000578D8 File Offset: 0x00055AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028415, XrefRangeEnd = 1028420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, Il2CppReferenceArray<DynamicMetaObject> args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObject.NativeMethodInfoPtr_BindInvokeMember_Public_Virtual_New_DynamicMetaObject_InvokeMemberBinder_Il2CppReferenceArray_1_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00057948 File Offset: 0x00055B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028420, XrefRangeEnd = 1028425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicMetaObject BindInvoke(InvokeBinder binder, Il2CppReferenceArray<DynamicMetaObject> args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObject.NativeMethodInfoPtr_BindInvoke_Public_Virtual_New_DynamicMetaObject_InvokeBinder_Il2CppReferenceArray_1_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x000579B8 File Offset: 0x00055BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028425, XrefRangeEnd = 1028428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, Il2CppReferenceArray<DynamicMetaObject> args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObject.NativeMethodInfoPtr_BindCreateInstance_Public_Virtual_New_DynamicMetaObject_CreateInstanceBinder_Il2CppReferenceArray_1_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00057A28 File Offset: 0x00055C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028428, XrefRangeEnd = 1028433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObject.NativeMethodInfoPtr_BindUnaryOperation_Public_Virtual_New_DynamicMetaObject_UnaryOperationBinder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00057A84 File Offset: 0x00055C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028433, XrefRangeEnd = 1028436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObject.NativeMethodInfoPtr_BindBinaryOperation_Public_Virtual_New_DynamicMetaObject_BinaryOperationBinder_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00057AF4 File Offset: 0x00055CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028436, XrefRangeEnd = 1028453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<string> GetDynamicMemberNames()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObject.NativeMethodInfoPtr_GetDynamicMemberNames_Public_Virtual_New_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00057B40 File Offset: 0x00055D40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1028481, RefRangeEnd = 1028483, XrefRangeStart = 1028453, XrefRangeEnd = 1028481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynamicMetaObject Create(Object value, Expression expression)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expression);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMetaObject.NativeMethodInfoPtr_Create_Public_Static_DynamicMetaObject_Object_Expression_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x000071C0 File Offset: 0x000053C0
		public DynamicMetaObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x00057B98 File Offset: 0x00055D98
		// (set) Token: 0x060010AF RID: 4271 RVA: 0x000071C9 File Offset: 0x000053C9
		public unsafe static Il2CppReferenceArray<DynamicMetaObject> EmptyMetaObjects
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicMetaObject.NativeFieldInfoPtr_EmptyMetaObjects, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicMetaObject>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicMetaObject.NativeFieldInfoPtr_EmptyMetaObjects, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x00057BC0 File Offset: 0x00055DC0
		// (set) Token: 0x060010B1 RID: 4273 RVA: 0x000071DB File Offset: 0x000053DB
		public unsafe static Object s_noValueSentinel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DynamicMetaObject.NativeFieldInfoPtr_s_noValueSentinel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicMetaObject.NativeFieldInfoPtr_s_noValueSentinel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x00057BE8 File Offset: 0x00055DE8
		// (set) Token: 0x060010B3 RID: 4275 RVA: 0x000071ED File Offset: 0x000053ED
		public unsafe Object _value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicMetaObject.NativeFieldInfoPtr__value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicMetaObject.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00057C18 File Offset: 0x00055E18
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x0000720C File Offset: 0x0000540C
		public unsafe Expression _Expression_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicMetaObject.NativeFieldInfoPtr__Expression_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicMetaObject.NativeFieldInfoPtr__Expression_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x00057C48 File Offset: 0x00055E48
		// (set) Token: 0x060010B7 RID: 4279 RVA: 0x0000722B File Offset: 0x0000542B
		public unsafe BindingRestrictions _Restrictions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicMetaObject.NativeFieldInfoPtr__Restrictions_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BindingRestrictions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicMetaObject.NativeFieldInfoPtr__Restrictions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeFieldInfoPtr_EmptyMetaObjects;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeFieldInfoPtr_s_noValueSentinel;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeFieldInfoPtr__value;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeFieldInfoPtr__Expression_k__BackingField;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeFieldInfoPtr__Restrictions_k__BackingField;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_BindingRestrictions_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_BindingRestrictions_Object_0;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr_get_Expression_Public_get_Expression_0;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeMethodInfoPtr_get_Restrictions_Public_get_BindingRestrictions_0;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValue_Public_get_Boolean_0;

		// Token: 0x04000BF2 RID: 3058
		private static readonly IntPtr NativeMethodInfoPtr_get_RuntimeType_Public_get_Type_0;

		// Token: 0x04000BF3 RID: 3059
		private static readonly IntPtr NativeMethodInfoPtr_get_LimitType_Public_get_Type_0;

		// Token: 0x04000BF4 RID: 3060
		private static readonly IntPtr NativeMethodInfoPtr_BindConvert_Public_Virtual_New_DynamicMetaObject_ConvertBinder_0;

		// Token: 0x04000BF5 RID: 3061
		private static readonly IntPtr NativeMethodInfoPtr_BindGetMember_Public_Virtual_New_DynamicMetaObject_GetMemberBinder_0;

		// Token: 0x04000BF6 RID: 3062
		private static readonly IntPtr NativeMethodInfoPtr_BindSetMember_Public_Virtual_New_DynamicMetaObject_SetMemberBinder_DynamicMetaObject_0;

		// Token: 0x04000BF7 RID: 3063
		private static readonly IntPtr NativeMethodInfoPtr_BindDeleteMember_Public_Virtual_New_DynamicMetaObject_DeleteMemberBinder_0;

		// Token: 0x04000BF8 RID: 3064
		private static readonly IntPtr NativeMethodInfoPtr_BindGetIndex_Public_Virtual_New_DynamicMetaObject_GetIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x04000BF9 RID: 3065
		private static readonly IntPtr NativeMethodInfoPtr_BindSetIndex_Public_Virtual_New_DynamicMetaObject_SetIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_DynamicMetaObject_0;

		// Token: 0x04000BFA RID: 3066
		private static readonly IntPtr NativeMethodInfoPtr_BindDeleteIndex_Public_Virtual_New_DynamicMetaObject_DeleteIndexBinder_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x04000BFB RID: 3067
		private static readonly IntPtr NativeMethodInfoPtr_BindInvokeMember_Public_Virtual_New_DynamicMetaObject_InvokeMemberBinder_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x04000BFC RID: 3068
		private static readonly IntPtr NativeMethodInfoPtr_BindInvoke_Public_Virtual_New_DynamicMetaObject_InvokeBinder_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x04000BFD RID: 3069
		private static readonly IntPtr NativeMethodInfoPtr_BindCreateInstance_Public_Virtual_New_DynamicMetaObject_CreateInstanceBinder_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x04000BFE RID: 3070
		private static readonly IntPtr NativeMethodInfoPtr_BindUnaryOperation_Public_Virtual_New_DynamicMetaObject_UnaryOperationBinder_0;

		// Token: 0x04000BFF RID: 3071
		private static readonly IntPtr NativeMethodInfoPtr_BindBinaryOperation_Public_Virtual_New_DynamicMetaObject_BinaryOperationBinder_DynamicMetaObject_0;

		// Token: 0x04000C00 RID: 3072
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicMemberNames_Public_Virtual_New_IEnumerable_1_String_0;

		// Token: 0x04000C01 RID: 3073
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_DynamicMetaObject_Object_Expression_0;
	}
}
