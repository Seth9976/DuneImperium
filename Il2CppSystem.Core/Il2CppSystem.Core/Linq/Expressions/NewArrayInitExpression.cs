using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200007B RID: 123
	public sealed class NewArrayInitExpression : NewArrayExpression
	{
		// Token: 0x06000661 RID: 1633 RVA: 0x0002E548 File Offset: 0x0002C748
		// Note: this type is marked as 'beforefieldinit'.
		static NewArrayInitExpression()
		{
			Il2CppClassPointerStore<NewArrayInitExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "NewArrayInitExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewArrayInitExpression>.NativeClassPtr);
			NewArrayInitExpression.NativeMethodInfoPtr__ctor_Internal_Void_Type_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayInitExpression>.NativeClassPtr, 100664593);
			NewArrayInitExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayInitExpression>.NativeClassPtr, 100664594);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0002E5A0 File Offset: 0x0002C7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014571, XrefRangeEnd = 1014572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewArrayInitExpression(Type type, ReadOnlyCollection<Expression> expressions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewArrayInitExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expressions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayInitExpression.NativeMethodInfoPtr__ctor_Internal_Void_Type_ReadOnlyCollection_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0002E600 File Offset: 0x0002C800
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayInitExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00003A19 File Offset: 0x00001C19
		public NewArrayInitExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_ReadOnlyCollection_1_Expression_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;
	}
}
