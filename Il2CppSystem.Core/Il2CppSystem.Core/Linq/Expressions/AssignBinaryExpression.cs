using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000028 RID: 40
	public class AssignBinaryExpression : BinaryExpression
	{
		// Token: 0x060001CB RID: 459 RVA: 0x00017A58 File Offset: 0x00015C58
		// Note: this type is marked as 'beforefieldinit'.
		static AssignBinaryExpression()
		{
			Il2CppClassPointerStore<AssignBinaryExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "AssignBinaryExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignBinaryExpression>.NativeClassPtr);
			AssignBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignBinaryExpression>.NativeClassPtr, 100663832);
			AssignBinaryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignBinaryExpression>.NativeClassPtr, 100663833);
			AssignBinaryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignBinaryExpression>.NativeClassPtr, 100663834);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00017AC4 File Offset: 0x00015CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007242, XrefRangeEnd = 1007243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssignBinaryExpression(Expression left, Expression right)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignBinaryExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignBinaryExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00017B24 File Offset: 0x00015D24
		public unsafe override Type Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007243, XrefRangeEnd = 1007244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignBinaryExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00017B64 File Offset: 0x00015D64
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignBinaryExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000277D File Offset: 0x0000097D
		public AssignBinaryExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_Expression_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;
	}
}
