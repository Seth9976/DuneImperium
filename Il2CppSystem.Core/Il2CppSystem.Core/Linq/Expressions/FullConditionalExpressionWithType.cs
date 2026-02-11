using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200003F RID: 63
	public sealed class FullConditionalExpressionWithType : FullConditionalExpression
	{
		// Token: 0x0600038A RID: 906 RVA: 0x00021728 File Offset: 0x0001F928
		// Note: this type is marked as 'beforefieldinit'.
		static FullConditionalExpressionWithType()
		{
			Il2CppClassPointerStore<FullConditionalExpressionWithType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "FullConditionalExpressionWithType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullConditionalExpressionWithType>.NativeClassPtr);
			FullConditionalExpressionWithType.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullConditionalExpressionWithType>.NativeClassPtr, "<Type>k__BackingField");
			FullConditionalExpressionWithType.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_Expression_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullConditionalExpressionWithType>.NativeClassPtr, 100664160);
			FullConditionalExpressionWithType.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullConditionalExpressionWithType>.NativeClassPtr, 100664161);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00021794 File Offset: 0x0001F994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012169, XrefRangeEnd = 1012172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullConditionalExpressionWithType(Expression test, Expression ifTrue, Expression ifFalse, Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullConditionalExpressionWithType>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(test);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ifTrue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ifFalse);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullConditionalExpressionWithType.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_Expression_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00021818 File Offset: 0x0001FA18
		public unsafe override Type Type
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullConditionalExpressionWithType.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002D3E File Offset: 0x00000F3E
		public FullConditionalExpressionWithType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00021858 File Offset: 0x0001FA58
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00002D47 File Offset: 0x00000F47
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullConditionalExpressionWithType.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullConditionalExpressionWithType.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_Expression_Type_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;
	}
}
