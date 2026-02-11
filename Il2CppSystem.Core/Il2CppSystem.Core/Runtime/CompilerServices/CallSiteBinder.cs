using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Linq.Expressions;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200010C RID: 268
	public class CallSiteBinder : Object
	{
		// Token: 0x06001005 RID: 4101 RVA: 0x00054514 File Offset: 0x00052714
		// Note: this type is marked as 'beforefieldinit'.
		static CallSiteBinder()
		{
			Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Runtime.CompilerServices", "CallSiteBinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr);
			CallSiteBinder.NativeFieldInfoPtr_Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr, "Cache");
			CallSiteBinder.NativeFieldInfoPtr__UpdateLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr, "<UpdateLabel>k__BackingField");
			CallSiteBinder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr, 100666279);
			CallSiteBinder.NativeMethodInfoPtr_get_UpdateLabel_Public_Static_get_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr, 100666280);
			CallSiteBinder.NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_Expression_Il2CppReferenceArray_1_Object_ReadOnlyCollection_1_ParameterExpression_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr, 100666281);
			CallSiteBinder.NativeMethodInfoPtr_BindDelegate_Public_Virtual_New_T_CallSite_1_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr, 100666282);
			CallSiteBinder.NativeMethodInfoPtr_BindCore_Internal_T_CallSite_1_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr, 100666283);
			CallSiteBinder.NativeMethodInfoPtr_CacheTarget_Protected_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr, 100666284);
			CallSiteBinder.NativeMethodInfoPtr_Stitch_Private_Static_Expression_1_T_Expression_LambdaSignature_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr, 100666285);
			CallSiteBinder.NativeMethodInfoPtr_GetRuleCache_Internal_RuleCache_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr, 100666286);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0005460C File Offset: 0x0005280C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSiteBinder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteBinder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x00054648 File Offset: 0x00052848
		public unsafe static LabelTarget UpdateLabel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027590, XrefRangeEnd = 1027594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteBinder.NativeMethodInfoPtr_get_UpdateLabel_Public_Static_get_LabelTarget_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabelTarget>(intPtr3) : null;
			}
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0005467C File Offset: 0x0005287C
		[CallerCount(0)]
		public unsafe virtual Expression Bind(Il2CppReferenceArray<Object> args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallSiteBinder.NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_Expression_Il2CppReferenceArray_1_Object_ReadOnlyCollection_1_ParameterExpression_LabelTarget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x000546FC File Offset: 0x000528FC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T BindDelegate<T>(CallSite<T> site, Il2CppReferenceArray<Object> args) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(site);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallSiteBinder.MethodInfoStoreGeneric_BindDelegate_Public_Virtual_New_T_CallSite_1_T_Il2CppReferenceArray_1_Object_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00054764 File Offset: 0x00052964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027594, XrefRangeEnd = 1027605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T BindCore<T>(CallSite<T> site, Il2CppReferenceArray<Object> args) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(site);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteBinder.MethodInfoStoreGeneric_BindCore_Internal_T_CallSite_1_T_Il2CppReferenceArray_1_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x000547C0 File Offset: 0x000529C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027605, XrefRangeEnd = 1027609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheTarget<T>(T target) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = target;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref target;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CallSiteBinder.MethodInfoStoreGeneric_CacheTarget_Protected_Void_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00054838 File Offset: 0x00052A38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1027671, RefRangeEnd = 1027672, XrefRangeStart = 1027609, XrefRangeEnd = 1027671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Expression<T> Stitch<T>(Expression binding, CallSiteBinder.LambdaSignature<T> signature) where T : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binding);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteBinder.MethodInfoStoreGeneric_Stitch_Private_Static_Expression_1_T_Expression_LambdaSignature_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression<T>>(intPtr3) : null;
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00054890 File Offset: 0x00052A90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1027702, RefRangeEnd = 1027705, XrefRangeStart = 1027672, XrefRangeEnd = 1027702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuleCache<T> GetRuleCache<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteBinder.MethodInfoStoreGeneric_GetRuleCache_Internal_RuleCache_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuleCache<T>>(intPtr3) : null;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00006FDD File Offset: 0x000051DD
		public CallSiteBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x000548D0 File Offset: 0x00052AD0
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x00006FE6 File Offset: 0x000051E6
		public unsafe Dictionary<Type, Object> Cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteBinder.NativeFieldInfoPtr_Cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteBinder.NativeFieldInfoPtr_Cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x00054900 File Offset: 0x00052B00
		// (set) Token: 0x06001012 RID: 4114 RVA: 0x00007005 File Offset: 0x00005205
		public unsafe static LabelTarget _UpdateLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CallSiteBinder.NativeFieldInfoPtr__UpdateLabel_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabelTarget>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallSiteBinder.NativeFieldInfoPtr__UpdateLabel_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B7F RID: 2943
		private static readonly IntPtr NativeFieldInfoPtr_Cache;

		// Token: 0x04000B80 RID: 2944
		private static readonly IntPtr NativeFieldInfoPtr__UpdateLabel_k__BackingField;

		// Token: 0x04000B81 RID: 2945
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000B82 RID: 2946
		private static readonly IntPtr NativeMethodInfoPtr_get_UpdateLabel_Public_Static_get_LabelTarget_0;

		// Token: 0x04000B83 RID: 2947
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Abstract_Virtual_New_Expression_Il2CppReferenceArray_1_Object_ReadOnlyCollection_1_ParameterExpression_LabelTarget_0;

		// Token: 0x04000B84 RID: 2948
		private static readonly IntPtr NativeMethodInfoPtr_BindDelegate_Public_Virtual_New_T_CallSite_1_T_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000B85 RID: 2949
		private static readonly IntPtr NativeMethodInfoPtr_BindCore_Internal_T_CallSite_1_T_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000B86 RID: 2950
		private static readonly IntPtr NativeMethodInfoPtr_CacheTarget_Protected_Void_T_0;

		// Token: 0x04000B87 RID: 2951
		private static readonly IntPtr NativeMethodInfoPtr_Stitch_Private_Static_Expression_1_T_Expression_LambdaSignature_1_T_0;

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_GetRuleCache_Internal_RuleCache_1_T_0;

		// Token: 0x0200032E RID: 814
		public sealed class LambdaSignature<T> : Object where T : class
		{
			// Token: 0x06001B53 RID: 6995 RVA: 0x00081C0C File Offset: 0x0007FE0C
			// Note: this type is marked as 'beforefieldinit'.
			static LambdaSignature()
			{
				Il2CppClassPointerStore<CallSiteBinder.LambdaSignature<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr, "LambdaSignature`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSiteBinder.LambdaSignature<T>>.NativeClassPtr);
				CallSiteBinder.LambdaSignature<T>.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteBinder.LambdaSignature<T>>.NativeClassPtr, "s_instance");
				CallSiteBinder.LambdaSignature<T>.NativeFieldInfoPtr_Parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteBinder.LambdaSignature<T>>.NativeClassPtr, "Parameters");
				CallSiteBinder.LambdaSignature<T>.NativeFieldInfoPtr_ReturnLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSiteBinder.LambdaSignature<T>>.NativeClassPtr, "ReturnLabel");
				CallSiteBinder.LambdaSignature<T>.NativeMethodInfoPtr_get_Instance_Internal_Static_get_LambdaSignature_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteBinder.LambdaSignature<T>>.NativeClassPtr, 100666288);
				CallSiteBinder.LambdaSignature<T>.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSiteBinder.LambdaSignature<T>>.NativeClassPtr, 100666289);
			}

			// Token: 0x170006E9 RID: 1769
			// (get) Token: 0x06001B54 RID: 6996 RVA: 0x00081CD8 File Offset: 0x0007FED8
			public unsafe static CallSiteBinder.LambdaSignature<T> Instance
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1027538, RefRangeEnd = 1027539, XrefRangeStart = 1027525, XrefRangeEnd = 1027538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteBinder.LambdaSignature<T>.NativeMethodInfoPtr_get_Instance_Internal_Static_get_LambdaSignature_1_T_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallSiteBinder.LambdaSignature<T>>(intPtr3) : null;
				}
			}

			// Token: 0x06001B55 RID: 6997 RVA: 0x00081D0C File Offset: 0x0007FF0C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1027589, RefRangeEnd = 1027590, XrefRangeStart = 1027539, XrefRangeEnd = 1027589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LambdaSignature()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSiteBinder.LambdaSignature<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSiteBinder.LambdaSignature<T>.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B56 RID: 6998 RVA: 0x0000A6AC File Offset: 0x000088AC
			public LambdaSignature(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E6 RID: 1766
			// (get) Token: 0x06001B57 RID: 6999 RVA: 0x00081D48 File Offset: 0x0007FF48
			// (set) Token: 0x06001B58 RID: 7000 RVA: 0x0000A6B5 File Offset: 0x000088B5
			public unsafe static CallSiteBinder.LambdaSignature<T> s_instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CallSiteBinder.LambdaSignature<T>.NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallSiteBinder.LambdaSignature<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CallSiteBinder.LambdaSignature<T>.NativeFieldInfoPtr_s_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E7 RID: 1767
			// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00081D70 File Offset: 0x0007FF70
			// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0000A6C7 File Offset: 0x000088C7
			public unsafe ReadOnlyCollection<ParameterExpression> Parameters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteBinder.LambdaSignature<T>.NativeFieldInfoPtr_Parameters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ParameterExpression>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteBinder.LambdaSignature<T>.NativeFieldInfoPtr_Parameters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E8 RID: 1768
			// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00081DA0 File Offset: 0x0007FFA0
			// (set) Token: 0x06001B5C RID: 7004 RVA: 0x0000A6E6 File Offset: 0x000088E6
			public unsafe LabelTarget ReturnLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteBinder.LambdaSignature<T>.NativeFieldInfoPtr_ReturnLabel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabelTarget>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSiteBinder.LambdaSignature<T>.NativeFieldInfoPtr_ReturnLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001277 RID: 4727
			private static readonly IntPtr NativeFieldInfoPtr_s_instance;

			// Token: 0x04001278 RID: 4728
			private static readonly IntPtr NativeFieldInfoPtr_Parameters;

			// Token: 0x04001279 RID: 4729
			private static readonly IntPtr NativeFieldInfoPtr_ReturnLabel;

			// Token: 0x0400127A RID: 4730
			private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Internal_Static_get_LambdaSignature_1_T_0;

			// Token: 0x0400127B RID: 4731
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
		}

		// Token: 0x0200032F RID: 815
		private sealed class MethodInfoStoreGeneric_BindDelegate_Public_Virtual_New_T_CallSite_1_T_Il2CppReferenceArray_1_Object_0<T>
		{
			// Token: 0x0400127C RID: 4732
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallSiteBinder.NativeMethodInfoPtr_BindDelegate_Public_Virtual_New_T_CallSite_1_T_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000330 RID: 816
		private sealed class MethodInfoStoreGeneric_BindCore_Internal_T_CallSite_1_T_Il2CppReferenceArray_1_Object_0<T>
		{
			// Token: 0x0400127D RID: 4733
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallSiteBinder.NativeMethodInfoPtr_BindCore_Internal_T_CallSite_1_T_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000331 RID: 817
		private sealed class MethodInfoStoreGeneric_CacheTarget_Protected_Void_T_0<T>
		{
			// Token: 0x0400127E RID: 4734
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallSiteBinder.NativeMethodInfoPtr_CacheTarget_Protected_Void_T_0, Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000332 RID: 818
		private sealed class MethodInfoStoreGeneric_Stitch_Private_Static_Expression_1_T_Expression_LambdaSignature_1_T_0<T>
		{
			// Token: 0x0400127F RID: 4735
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallSiteBinder.NativeMethodInfoPtr_Stitch_Private_Static_Expression_1_T_Expression_LambdaSignature_1_T_0, Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000333 RID: 819
		private sealed class MethodInfoStoreGeneric_GetRuleCache_Internal_RuleCache_1_T_0<T>
		{
			// Token: 0x04001280 RID: 4736
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CallSiteBinder.NativeMethodInfoPtr_GetRuleCache_Internal_RuleCache_1_T_0, Il2CppClassPointerStore<CallSiteBinder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
