using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Linq.Expressions;

namespace Il2CppSystem.Dynamic
{
	// Token: 0x02000114 RID: 276
	public class BinaryOperationBinder : DynamicMetaObjectBinder
	{
		// Token: 0x06001066 RID: 4198 RVA: 0x000563E4 File Offset: 0x000545E4
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryOperationBinder()
		{
			Il2CppClassPointerStore<BinaryOperationBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic", "BinaryOperationBinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryOperationBinder>.NativeClassPtr);
			BinaryOperationBinder.NativeFieldInfoPtr__Operation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryOperationBinder>.NativeClassPtr, "<Operation>k__BackingField");
			BinaryOperationBinder.NativeMethodInfoPtr_get_Operation_Public_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperationBinder>.NativeClassPtr, 100666353);
			BinaryOperationBinder.NativeMethodInfoPtr_FallbackBinaryOperation_Public_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperationBinder>.NativeClassPtr, 100666354);
			BinaryOperationBinder.NativeMethodInfoPtr_FallbackBinaryOperation_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperationBinder>.NativeClassPtr, 100666355);
			BinaryOperationBinder.NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryOperationBinder>.NativeClassPtr, 100666356);
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001067 RID: 4199 RVA: 0x00056478 File Offset: 0x00054678
		public unsafe ExpressionType Operation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperationBinder.NativeMethodInfoPtr_get_Operation_Public_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x000564B4 File Offset: 0x000546B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1027945, RefRangeEnd = 1027949, XrefRangeStart = 1027945, XrefRangeEnd = 1027945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperationBinder.NativeMethodInfoPtr_FallbackBinaryOperation_Public_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00056518 File Offset: 0x00054718
		[CallerCount(0)]
		public unsafe virtual DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorSuggestion);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryOperationBinder.NativeMethodInfoPtr_FallbackBinaryOperation_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00056598 File Offset: 0x00054798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027949, XrefRangeEnd = 1027961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicMetaObject Bind(DynamicMetaObject target, Il2CppReferenceArray<DynamicMetaObject> args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryOperationBinder.NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicMetaObject>(intPtr3) : null;
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00007104 File Offset: 0x00005304
		public BinaryOperationBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x000565FC File Offset: 0x000547FC
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x0000710D File Offset: 0x0000530D
		public unsafe ExpressionType _Operation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperationBinder.NativeFieldInfoPtr__Operation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryOperationBinder.NativeFieldInfoPtr__Operation_k__BackingField)) = value;
			}
		}

		// Token: 0x04000BC8 RID: 3016
		private static readonly IntPtr NativeFieldInfoPtr__Operation_k__BackingField;

		// Token: 0x04000BC9 RID: 3017
		private static readonly IntPtr NativeMethodInfoPtr_get_Operation_Public_get_ExpressionType_0;

		// Token: 0x04000BCA RID: 3018
		private static readonly IntPtr NativeMethodInfoPtr_FallbackBinaryOperation_Public_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0;

		// Token: 0x04000BCB RID: 3019
		private static readonly IntPtr NativeMethodInfoPtr_FallbackBinaryOperation_Public_Abstract_Virtual_New_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_DynamicMetaObject_0;

		// Token: 0x04000BCC RID: 3020
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Final_DynamicMetaObject_DynamicMetaObject_Il2CppReferenceArray_1_DynamicMetaObject_0;
	}
}
