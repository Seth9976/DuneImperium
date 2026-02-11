using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200002B RID: 43
	public class SimpleBinaryExpression : BinaryExpression
	{
		// Token: 0x060001DE RID: 478 RVA: 0x00017F10 File Offset: 0x00016110
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleBinaryExpression()
		{
			Il2CppClassPointerStore<SimpleBinaryExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "SimpleBinaryExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleBinaryExpression>.NativeClassPtr);
			SimpleBinaryExpression.NativeFieldInfoPtr__NodeType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleBinaryExpression>.NativeClassPtr, "<NodeType>k__BackingField");
			SimpleBinaryExpression.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleBinaryExpression>.NativeClassPtr, "<Type>k__BackingField");
			SimpleBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Expression_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleBinaryExpression>.NativeClassPtr, 100663841);
			SimpleBinaryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleBinaryExpression>.NativeClassPtr, 100663842);
			SimpleBinaryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleBinaryExpression>.NativeClassPtr, 100663843);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00017FA4 File Offset: 0x000161A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007250, XrefRangeEnd = 1007252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleBinaryExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(left);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Expression_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00018024 File Offset: 0x00016224
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleBinaryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00018060 File Offset: 0x00016260
		public unsafe override Type Type
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleBinaryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000027D6 File Offset: 0x000009D6
		public SimpleBinaryExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000180A0 File Offset: 0x000162A0
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x000027DF File Offset: 0x000009DF
		public unsafe ExpressionType _NodeType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleBinaryExpression.NativeFieldInfoPtr__NodeType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleBinaryExpression.NativeFieldInfoPtr__NodeType_k__BackingField)) = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000180C8 File Offset: 0x000162C8
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x000027FA File Offset: 0x000009FA
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleBinaryExpression.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleBinaryExpression.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr__NodeType_k__BackingField;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ExpressionType_Expression_Expression_Type_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;
	}
}
