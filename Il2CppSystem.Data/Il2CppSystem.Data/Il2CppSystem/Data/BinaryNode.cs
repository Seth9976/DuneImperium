using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Data.Common;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Data
{
	// Token: 0x02000050 RID: 80
	public class BinaryNode : ExpressionNode
	{
		// Token: 0x06000847 RID: 2119 RVA: 0x0002C3CC File Offset: 0x0002A5CC
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryNode()
		{
			Il2CppClassPointerStore<BinaryNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "BinaryNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr);
			BinaryNode.NativeFieldInfoPtr__op = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, "_op");
			BinaryNode.NativeFieldInfoPtr__left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, "_left");
			BinaryNode.NativeFieldInfoPtr__right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, "_right");
			BinaryNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Int32_ExpressionNode_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664663);
			BinaryNode.NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664664);
			BinaryNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664665);
			BinaryNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664666);
			BinaryNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664667);
			BinaryNode.NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664668);
			BinaryNode.NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664669);
			BinaryNode.NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664670);
			BinaryNode.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664671);
			BinaryNode.NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664672);
			BinaryNode.NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664673);
			BinaryNode.NativeMethodInfoPtr_SetTypeMismatchError_Internal_Void_Int32_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664674);
			BinaryNode.NativeMethodInfoPtr_Eval_Private_Static_Object_ExpressionNode_DataRow_DataRowVersion_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664675);
			BinaryNode.NativeMethodInfoPtr_BinaryCompare_Internal_Int32_Object_Object_StorageType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664676);
			BinaryNode.NativeMethodInfoPtr_BinaryCompare_Internal_Int32_Object_Object_StorageType_Int32_CompareInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664677);
			BinaryNode.NativeMethodInfoPtr_EvalBinaryOp_Private_Object_Int32_ExpressionNode_ExpressionNode_DataRow_DataRowVersion_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664678);
			BinaryNode.NativeMethodInfoPtr_GetPrecedence_Private_DataTypePrecedence_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664679);
			BinaryNode.NativeMethodInfoPtr_GetPrecedenceType_Private_Static_StorageType_DataTypePrecedence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664680);
			BinaryNode.NativeMethodInfoPtr_IsMixed_Private_Boolean_StorageType_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664681);
			BinaryNode.NativeMethodInfoPtr_IsMixedSql_Private_Boolean_StorageType_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664682);
			BinaryNode.NativeMethodInfoPtr_ResultType_Internal_StorageType_StorageType_StorageType_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664683);
			BinaryNode.NativeMethodInfoPtr_ResultSqlType_Internal_StorageType_StorageType_StorageType_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664684);
			BinaryNode.NativeMethodInfoPtr_SqlResultType_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr, 100664685);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0002C604 File Offset: 0x0002A804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902948, XrefRangeEnd = 902952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryNode(DataTable table, int op, ExpressionNode left, ExpressionNode right)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(left);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Int32_ExpressionNode_ExpressionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0002C684 File Offset: 0x0002A884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902952, XrefRangeEnd = 902954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(DataTable table, List<DataColumn> list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryNode.NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0002C6E4 File Offset: 0x0002A8E4
		[CallerCount(0)]
		public unsafe override Object Eval()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0002C730 File Offset: 0x0002A930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902954, XrefRangeEnd = 902955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Eval(DataRow row, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0002C79C File Offset: 0x0002A99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902955, XrefRangeEnd = 902956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Eval(Il2CppStructArray<int> recordNos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recordNos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0002C7F8 File Offset: 0x0002A9F8
		[CallerCount(0)]
		public unsafe override bool IsConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryNode.NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0002C840 File Offset: 0x0002AA40
		[CallerCount(0)]
		public unsafe override bool IsTableConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryNode.NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0002C888 File Offset: 0x0002AA88
		[CallerCount(0)]
		public unsafe override bool HasLocalAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryNode.NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0002C8D0 File Offset: 0x0002AAD0
		[CallerCount(0)]
		public unsafe override bool HasRemoteAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryNode.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0002C918 File Offset: 0x0002AB18
		[CallerCount(0)]
		public unsafe override bool DependsOn(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryNode.NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0002C970 File Offset: 0x0002AB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902956, XrefRangeEnd = 902975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ExpressionNode Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryNode.NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr3) : null;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0002C9BC File Offset: 0x0002ABBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902975, XrefRangeEnd = 902978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTypeMismatchError(int op, Type left, Type right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(left);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryNode.NativeMethodInfoPtr_SetTypeMismatchError_Internal_Void_Int32_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0002CA20 File Offset: 0x0002AC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902978, XrefRangeEnd = 902979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, Il2CppStructArray<int> recordNos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(row);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recordNos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryNode.NativeMethodInfoPtr_Eval_Private_Static_Object_ExpressionNode_DataRow_DataRowVersion_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0002CA98 File Offset: 0x0002AC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902979, XrefRangeEnd = 902980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BinaryCompare(Object vLeft, Object vRight, StorageType resultType, int op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vLeft);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vRight);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryNode.NativeMethodInfoPtr_BinaryCompare_Internal_Int32_Object_Object_StorageType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0002CB14 File Offset: 0x0002AD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 903187, RefRangeEnd = 903188, XrefRangeStart = 902980, XrefRangeEnd = 903187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BinaryCompare(Object vLeft, Object vRight, StorageType resultType, int op, CompareInfo comparer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vLeft);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vRight);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resultType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(comparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryNode.NativeMethodInfoPtr_BinaryCompare_Internal_Int32_Object_Object_StorageType_Int32_CompareInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0002CBA4 File Offset: 0x0002ADA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 903235, RefRangeEnd = 903237, XrefRangeStart = 903188, XrefRangeEnd = 903235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, Il2CppStructArray<int> recordNos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(left);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(row);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recordNos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryNode.NativeMethodInfoPtr_EvalBinaryOp_Private_Object_Int32_ExpressionNode_ExpressionNode_DataRow_DataRowVersion_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0002CC48 File Offset: 0x0002AE48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 903237, RefRangeEnd = 903241, XrefRangeStart = 903237, XrefRangeEnd = 903237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref storageType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryNode.NativeMethodInfoPtr_GetPrecedence_Private_DataTypePrecedence_StorageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0002CC94 File Offset: 0x0002AE94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 903241, RefRangeEnd = 903243, XrefRangeStart = 903241, XrefRangeEnd = 903241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryNode.NativeMethodInfoPtr_GetPrecedenceType_Private_Static_StorageType_DataTypePrecedence_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0002CCD4 File Offset: 0x0002AED4
		[CallerCount(0)]
		public unsafe bool IsMixed(StorageType left, StorageType right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryNode.NativeMethodInfoPtr_IsMixed_Private_Boolean_StorageType_StorageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0002CD2C File Offset: 0x0002AF2C
		[CallerCount(0)]
		public unsafe bool IsMixedSql(StorageType left, StorageType right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryNode.NativeMethodInfoPtr_IsMixedSql_Private_Boolean_StorageType_StorageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0002CD84 File Offset: 0x0002AF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 903243, XrefRangeEnd = 903277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lc;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rc;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryNode.NativeMethodInfoPtr_ResultType_Internal_StorageType_StorageType_StorageType_Boolean_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0002CE08 File Offset: 0x0002B008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 903277, XrefRangeEnd = 903286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lc;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rc;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryNode.NativeMethodInfoPtr_ResultSqlType_Internal_StorageType_StorageType_StorageType_Boolean_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0002CE8C File Offset: 0x0002B08C
		[CallerCount(0)]
		public unsafe int SqlResultType(int typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryNode.NativeMethodInfoPtr_SqlResultType_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00004844 File Offset: 0x00002A44
		public BinaryNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x0002CED8 File Offset: 0x0002B0D8
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x0000484D File Offset: 0x00002A4D
		public unsafe int _op
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryNode.NativeFieldInfoPtr__op);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryNode.NativeFieldInfoPtr__op)) = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x0002CF00 File Offset: 0x0002B100
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x00004868 File Offset: 0x00002A68
		public unsafe ExpressionNode _left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryNode.NativeFieldInfoPtr__left);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryNode.NativeFieldInfoPtr__left), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x0002CF30 File Offset: 0x0002B130
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x00004887 File Offset: 0x00002A87
		public unsafe ExpressionNode _right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryNode.NativeFieldInfoPtr__right);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryNode.NativeFieldInfoPtr__right), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006CA RID: 1738
		private static readonly IntPtr NativeFieldInfoPtr__op;

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeFieldInfoPtr__left;

		// Token: 0x040006CC RID: 1740
		private static readonly IntPtr NativeFieldInfoPtr__right;

		// Token: 0x040006CD RID: 1741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Int32_ExpressionNode_ExpressionNode_0;

		// Token: 0x040006CE RID: 1742
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0;

		// Token: 0x040006CF RID: 1743
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0;

		// Token: 0x040006D0 RID: 1744
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0;

		// Token: 0x040006D1 RID: 1745
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0;

		// Token: 0x040006D2 RID: 1746
		private static readonly IntPtr NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0;

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0;

		// Token: 0x040006D4 RID: 1748
		private static readonly IntPtr NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0;

		// Token: 0x040006D5 RID: 1749
		private static readonly IntPtr NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0;

		// Token: 0x040006D6 RID: 1750
		private static readonly IntPtr NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0;

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeMethodInfoPtr_SetTypeMismatchError_Internal_Void_Int32_Type_Type_0;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Private_Static_Object_ExpressionNode_DataRow_DataRowVersion_Il2CppStructArray_1_Int32_0;

		// Token: 0x040006DA RID: 1754
		private static readonly IntPtr NativeMethodInfoPtr_BinaryCompare_Internal_Int32_Object_Object_StorageType_Int32_0;

		// Token: 0x040006DB RID: 1755
		private static readonly IntPtr NativeMethodInfoPtr_BinaryCompare_Internal_Int32_Object_Object_StorageType_Int32_CompareInfo_0;

		// Token: 0x040006DC RID: 1756
		private static readonly IntPtr NativeMethodInfoPtr_EvalBinaryOp_Private_Object_Int32_ExpressionNode_ExpressionNode_DataRow_DataRowVersion_Il2CppStructArray_1_Int32_0;

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeMethodInfoPtr_GetPrecedence_Private_DataTypePrecedence_StorageType_0;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeMethodInfoPtr_GetPrecedenceType_Private_Static_StorageType_DataTypePrecedence_0;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeMethodInfoPtr_IsMixed_Private_Boolean_StorageType_StorageType_0;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeMethodInfoPtr_IsMixedSql_Private_Boolean_StorageType_StorageType_0;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeMethodInfoPtr_ResultType_Internal_StorageType_StorageType_StorageType_Boolean_Boolean_Int32_0;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeMethodInfoPtr_ResultSqlType_Internal_StorageType_StorageType_StorageType_Boolean_Boolean_Int32_0;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_SqlResultType_Private_Int32_Int32_0;

		// Token: 0x020000E1 RID: 225
		public enum DataTypePrecedence
		{
			// Token: 0x04001121 RID: 4385
			SqlDateTime = 25,
			// Token: 0x04001122 RID: 4386
			DateTimeOffset = 24,
			// Token: 0x04001123 RID: 4387
			DateTime = 23,
			// Token: 0x04001124 RID: 4388
			TimeSpan = 20,
			// Token: 0x04001125 RID: 4389
			SqlDouble = 19,
			// Token: 0x04001126 RID: 4390
			Double = 18,
			// Token: 0x04001127 RID: 4391
			SqlSingle = 17,
			// Token: 0x04001128 RID: 4392
			Single = 16,
			// Token: 0x04001129 RID: 4393
			SqlDecimal = 15,
			// Token: 0x0400112A RID: 4394
			Decimal = 14,
			// Token: 0x0400112B RID: 4395
			SqlMoney = 13,
			// Token: 0x0400112C RID: 4396
			UInt64 = 12,
			// Token: 0x0400112D RID: 4397
			SqlInt64 = 11,
			// Token: 0x0400112E RID: 4398
			Int64 = 10,
			// Token: 0x0400112F RID: 4399
			UInt32 = 9,
			// Token: 0x04001130 RID: 4400
			SqlInt32 = 8,
			// Token: 0x04001131 RID: 4401
			Int32 = 7,
			// Token: 0x04001132 RID: 4402
			UInt16 = 6,
			// Token: 0x04001133 RID: 4403
			SqlInt16 = 5,
			// Token: 0x04001134 RID: 4404
			Int16 = 4,
			// Token: 0x04001135 RID: 4405
			Byte = 3,
			// Token: 0x04001136 RID: 4406
			SqlByte = 2,
			// Token: 0x04001137 RID: 4407
			SByte = 1,
			// Token: 0x04001138 RID: 4408
			Error = 0,
			// Token: 0x04001139 RID: 4409
			SqlBoolean = -1,
			// Token: 0x0400113A RID: 4410
			Boolean = -2,
			// Token: 0x0400113B RID: 4411
			SqlGuid = -3,
			// Token: 0x0400113C RID: 4412
			SqlString = -4,
			// Token: 0x0400113D RID: 4413
			String = -5,
			// Token: 0x0400113E RID: 4414
			SqlXml = -6,
			// Token: 0x0400113F RID: 4415
			SqlChars = -7,
			// Token: 0x04001140 RID: 4416
			Char = -8,
			// Token: 0x04001141 RID: 4417
			SqlBytes = -9,
			// Token: 0x04001142 RID: 4418
			SqlBinary = -10
		}
	}
}
