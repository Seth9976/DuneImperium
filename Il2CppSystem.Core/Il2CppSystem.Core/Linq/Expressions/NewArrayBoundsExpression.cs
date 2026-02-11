using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200007C RID: 124
	public sealed class NewArrayBoundsExpression : NewArrayExpression
	{
		// Token: 0x06000665 RID: 1637 RVA: 0x0002E63C File Offset: 0x0002C83C
		// Note: this type is marked as 'beforefieldinit'.
		static NewArrayBoundsExpression()
		{
			Il2CppClassPointerStore<NewArrayBoundsExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "NewArrayBoundsExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewArrayBoundsExpression>.NativeClassPtr);
			NewArrayBoundsExpression.NativeMethodInfoPtr__ctor_Internal_Void_Type_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayBoundsExpression>.NativeClassPtr, 100664595);
			NewArrayBoundsExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayBoundsExpression>.NativeClassPtr, 100664596);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0002E694 File Offset: 0x0002C894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewArrayBoundsExpression(Type type, ReadOnlyCollection<Expression> expressions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewArrayBoundsExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expressions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayBoundsExpression.NativeMethodInfoPtr__ctor_Internal_Void_Type_ReadOnlyCollection_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0002E6F4 File Offset: 0x0002C8F4
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayBoundsExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00003A22 File Offset: 0x00001C22
		public NewArrayBoundsExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_ReadOnlyCollection_1_Expression_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;
	}
}
