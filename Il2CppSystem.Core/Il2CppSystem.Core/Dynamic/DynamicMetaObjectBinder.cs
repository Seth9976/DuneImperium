using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Linq.Expressions;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Dynamic
{
	// Token: 0x0200011B RID: 283
	public class DynamicMetaObjectBinder : CallSiteBinder
	{
		// Token: 0x060010B8 RID: 4280 RVA: 0x00057C78 File Offset: 0x00055E78
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicMetaObjectBinder()
		{
			Il2CppClassPointerStore<DynamicMetaObjectBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic", "DynamicMetaObjectBinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicMetaObjectBinder>.NativeClassPtr);
			DynamicMetaObjectBinder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObjectBinder>.NativeClassPtr, 100666421);
			DynamicMetaObjectBinder.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObjectBinder>.NativeClassPtr, 100666422);
			DynamicMetaObjectBinder.NativeMethodInfoPtr_Bind_Public_Virtual_Final_Expression_Il2CppReferenceArray_1_Object_ReadOnlyCollection_1_ParameterExpression_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObjectBinder>.NativeClassPtr, 100666423);
			DynamicMetaObjectBinder.NativeMethodInfoPtr_CreateArgumentMetaObjects_Private_Static_Il2CppReferenceArray_1_DynamicMetaObject_Il2CppReferenceArray_1_Object_ReadOnlyCollection_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObjectBinder>.NativeClassPtr, 100666424);
			DynamicMetaObjectBinder.NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObjectBinder>.NativeClassPtr, 100666425);
			DynamicMetaObjectBinder.NativeMethodInfoPtr_GetUpdateExpression_Public_Expression_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObjectBinder>.NativeClassPtr, 100666426);
			DynamicMetaObjectBinder.NativeMethodInfoPtr_get_IsStandardBinder_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicMetaObjectBinder>.NativeClassPtr, 100666427);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00057D34 File Offset: 0x00055F34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1028487, RefRangeEnd = 1028489, XrefRangeStart = 1028483, XrefRangeEnd = 1028487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicMetaObjectBinder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicMetaObjectBinder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMetaObjectBinder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x00057D70 File Offset: 0x00055F70
		public unsafe virtual Type ReturnType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028489, XrefRangeEnd = 1028495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObjectBinder.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00057DBC File Offset: 0x00055FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028495, XrefRangeEnd = 1028574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Bind(Il2CppReferenceArray<Object> args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(returnLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMetaObjectBinder.NativeMethodInfoPtr_Bind_Public_Virtual_Final_Expression_Il2CppReferenceArray_1_Object_ReadOnlyCollection_1_ParameterExpression_LabelTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00057E30 File Offset: 0x00056030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1028574, XrefRangeEnd = 1028580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<DynamicMetaObject> CreateArgumentMetaObjects(Il2CppReferenceArray<Object> args, ReadOnlyCollection<ParameterExpression> parameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMetaObjectBinder.NativeMethodInfoPtr_CreateArgumentMetaObjects_Private_Static_Il2CppReferenceArray_1_DynamicMetaObject_Il2CppReferenceArray_1_Object_ReadOnlyCollection_1_ParameterExpression_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynamicMetaObject>>(intPtr3) : null;
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00057E88 File Offset: 0x00056088
		[CallerCount(0)]
		public unsafe virtual DynamicMetaObject Bind(DynamicMetaObject target, Il2CppReferenceArray<DynamicMetaObject> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObjectBinder.NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00057EF8 File Offset: 0x000560F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1028591, RefRangeEnd = 1028592, XrefRangeStart = 1028580, XrefRangeEnd = 1028591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression GetUpdateExpression(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicMetaObjectBinder.NativeMethodInfoPtr_GetUpdateExpression_Public_Expression_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x060010BF RID: 4287 RVA: 0x00057F48 File Offset: 0x00056148
		public unsafe virtual bool IsStandardBinder
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicMetaObjectBinder.NativeMethodInfoPtr_get_IsStandardBinder_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0000724A File Offset: 0x0000544A
		public DynamicMetaObjectBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C02 RID: 3074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000C03 RID: 3075
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_New_get_Type_0;

		// Token: 0x04000C04 RID: 3076
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Final_Expression_Il2CppReferenceArray_1_Object_ReadOnlyCollection_1_ParameterExpression_LabelTarget_0;

		// Token: 0x04000C05 RID: 3077
		private static readonly IntPtr NativeMethodInfoPtr_CreateArgumentMetaObjects_Private_Static_Il2CppReferenceArray_1_DynamicMetaObject_Il2CppReferenceArray_1_Object_ReadOnlyCollection_1_ParameterExpression_0;

		// Token: 0x04000C06 RID: 3078
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0;

		// Token: 0x04000C07 RID: 3079
		private static readonly IntPtr NativeMethodInfoPtr_GetUpdateExpression_Public_Expression_Type_0;

		// Token: 0x04000C08 RID: 3080
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStandardBinder_Internal_Virtual_New_get_Boolean_0;
	}
}
