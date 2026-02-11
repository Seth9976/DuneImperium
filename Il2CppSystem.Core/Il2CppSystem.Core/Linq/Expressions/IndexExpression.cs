using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200004D RID: 77
	public sealed class IndexExpression : Expression
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x000276C0 File Offset: 0x000258C0
		// Note: this type is marked as 'beforefieldinit'.
		static IndexExpression()
		{
			Il2CppClassPointerStore<IndexExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "IndexExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr);
			IndexExpression.NativeFieldInfoPtr__arguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, "_arguments");
			IndexExpression.NativeFieldInfoPtr__Object_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, "<Object>k__BackingField");
			IndexExpression.NativeFieldInfoPtr__Indexer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, "<Indexer>k__BackingField");
			IndexExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_PropertyInfo_IReadOnlyList_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100664393);
			IndexExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100664394);
			IndexExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100664395);
			IndexExpression.NativeMethodInfoPtr_get_Object_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100664396);
			IndexExpression.NativeMethodInfoPtr_get_Indexer_Public_get_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100664397);
			IndexExpression.NativeMethodInfoPtr_GetArgument_Public_Virtual_Final_New_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100664398);
			IndexExpression.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100664399);
			IndexExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100664400);
			IndexExpression.NativeMethodInfoPtr_Rewrite_Internal_Expression_Expression_Il2CppReferenceArray_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr, 100664401);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000277E0 File Offset: 0x000259E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1013828, RefRangeEnd = 1013833, XrefRangeStart = 1013820, XrefRangeEnd = 1013828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexExpression(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexExpression.NativeMethodInfoPtr__ctor_Internal_Void_Expression_PropertyInfo_IReadOnlyList_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00027850 File Offset: 0x00025A50
		public unsafe override ExpressionType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexExpression.NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0002788C File Offset: 0x00025A8C
		public unsafe override Type Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013833, XrefRangeEnd = 1013835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x000278CC File Offset: 0x00025ACC
		public unsafe Expression Object
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexExpression.NativeMethodInfoPtr_get_Object_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0002790C File Offset: 0x00025B0C
		public unsafe PropertyInfo Indexer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexExpression.NativeMethodInfoPtr_get_Indexer_Public_get_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0002794C File Offset: 0x00025B4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1013839, RefRangeEnd = 1013843, XrefRangeStart = 1013835, XrefRangeEnd = 1013839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexExpression.NativeMethodInfoPtr_GetArgument_Public_Virtual_Final_New_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00027998 File Offset: 0x00025B98
		public unsafe int ArgumentCount
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1013847, RefRangeEnd = 1013854, XrefRangeStart = 1013843, XrefRangeEnd = 1013847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexExpression.NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000279D4 File Offset: 0x00025BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013854, XrefRangeEnd = 1013855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Expression Accept(ExpressionVisitor visitor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visitor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexExpression.NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00027A24 File Offset: 0x00025C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013855, XrefRangeEnd = 1013859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Expression Rewrite(Expression instance, Il2CppReferenceArray<Expression> arguments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexExpression.NativeMethodInfoPtr_Rewrite_Internal_Expression_Expression_Il2CppReferenceArray_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002F39 File Offset: 0x00001139
		public IndexExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00027A88 File Offset: 0x00025C88
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00002F42 File Offset: 0x00001142
		public unsafe IReadOnlyList<Expression> _arguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexExpression.NativeFieldInfoPtr__arguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexExpression.NativeFieldInfoPtr__arguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00027AB8 File Offset: 0x00025CB8
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00002F61 File Offset: 0x00001161
		public unsafe Expression _Object_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexExpression.NativeFieldInfoPtr__Object_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexExpression.NativeFieldInfoPtr__Object_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00027AE8 File Offset: 0x00025CE8
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00002F80 File Offset: 0x00001180
		public unsafe PropertyInfo _Indexer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexExpression.NativeFieldInfoPtr__Indexer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexExpression.NativeFieldInfoPtr__Indexer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr__arguments;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr__Object_k__BackingField;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr__Indexer_k__BackingField;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Expression_PropertyInfo_IReadOnlyList_1_Expression_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_Final_get_ExpressionType_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_get_Object_Public_get_Expression_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_get_Indexer_Public_get_PropertyInfo_0;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Final_New_Expression_Int32_0;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgumentCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr_Accept_FamOrAssem_Virtual_Expression_ExpressionVisitor_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_Rewrite_Internal_Expression_Expression_Il2CppReferenceArray_1_Expression_0;
	}
}
