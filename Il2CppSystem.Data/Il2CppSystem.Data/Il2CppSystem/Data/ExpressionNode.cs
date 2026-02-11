using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Data.Common;

namespace Il2CppSystem.Data
{
	// Token: 0x02000054 RID: 84
	public class ExpressionNode : Object
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x0002DE8C File Offset: 0x0002C08C
		// Note: this type is marked as 'beforefieldinit'.
		static ExpressionNode()
		{
			Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "ExpressionNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr);
			ExpressionNode.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, "_table");
			ExpressionNode.NativeMethodInfoPtr__ctor_Protected_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664717);
			ExpressionNode.NativeMethodInfoPtr_get_FormatProvider_Internal_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664718);
			ExpressionNode.NativeMethodInfoPtr_get_IsSqlColumn_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664719);
			ExpressionNode.NativeMethodInfoPtr_get_table_Protected_get_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664720);
			ExpressionNode.NativeMethodInfoPtr_BindTable_Protected_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664721);
			ExpressionNode.NativeMethodInfoPtr_Bind_Internal_Abstract_Virtual_New_Void_DataTable_List_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664722);
			ExpressionNode.NativeMethodInfoPtr_Eval_Internal_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664723);
			ExpressionNode.NativeMethodInfoPtr_Eval_Internal_Abstract_Virtual_New_Object_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664724);
			ExpressionNode.NativeMethodInfoPtr_Eval_Internal_Abstract_Virtual_New_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664725);
			ExpressionNode.NativeMethodInfoPtr_IsConstant_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664726);
			ExpressionNode.NativeMethodInfoPtr_IsTableConstant_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664727);
			ExpressionNode.NativeMethodInfoPtr_HasLocalAggregate_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664728);
			ExpressionNode.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664729);
			ExpressionNode.NativeMethodInfoPtr_Optimize_Internal_Abstract_Virtual_New_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664730);
			ExpressionNode.NativeMethodInfoPtr_DependsOn_Internal_Virtual_New_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664731);
			ExpressionNode.NativeMethodInfoPtr_IsInteger_Internal_Static_Boolean_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664732);
			ExpressionNode.NativeMethodInfoPtr_IsIntegerSql_Internal_Static_Boolean_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664733);
			ExpressionNode.NativeMethodInfoPtr_IsSigned_Internal_Static_Boolean_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664734);
			ExpressionNode.NativeMethodInfoPtr_IsSignedSql_Internal_Static_Boolean_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664735);
			ExpressionNode.NativeMethodInfoPtr_IsUnsigned_Internal_Static_Boolean_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664736);
			ExpressionNode.NativeMethodInfoPtr_IsUnsignedSql_Internal_Static_Boolean_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664737);
			ExpressionNode.NativeMethodInfoPtr_IsNumeric_Internal_Static_Boolean_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664738);
			ExpressionNode.NativeMethodInfoPtr_IsNumericSql_Internal_Static_Boolean_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664739);
			ExpressionNode.NativeMethodInfoPtr_IsFloat_Internal_Static_Boolean_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664740);
			ExpressionNode.NativeMethodInfoPtr_IsFloatSql_Internal_Static_Boolean_StorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr, 100664741);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0002E0C4 File Offset: 0x0002C2C4
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpressionNode(DataTable table)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionNode>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr__ctor_Protected_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0002E110 File Offset: 0x0002C310
		public unsafe IFormatProvider FormatProvider
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 903594, RefRangeEnd = 903611, XrefRangeStart = 903589, XrefRangeEnd = 903594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr_get_FormatProvider_Internal_get_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0002E150 File Offset: 0x0002C350
		public unsafe virtual bool IsSqlColumn
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionNode.NativeMethodInfoPtr_get_IsSqlColumn_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x0002E198 File Offset: 0x0002C398
		public unsafe DataTable table
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr_get_table_Protected_get_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr3) : null;
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0002E1D8 File Offset: 0x0002C3D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindTable(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr_BindTable_Protected_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0002E21C File Offset: 0x0002C41C
		[CallerCount(0)]
		public unsafe virtual void Bind(DataTable table, List<DataColumn> list)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionNode.NativeMethodInfoPtr_Bind_Internal_Abstract_Virtual_New_Void_DataTable_List_1_DataColumn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0002E27C File Offset: 0x0002C47C
		[CallerCount(0)]
		public unsafe virtual Object Eval()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionNode.NativeMethodInfoPtr_Eval_Internal_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0002E2C8 File Offset: 0x0002C4C8
		[CallerCount(0)]
		public unsafe virtual Object Eval(DataRow row, DataRowVersion version)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionNode.NativeMethodInfoPtr_Eval_Internal_Abstract_Virtual_New_Object_DataRow_DataRowVersion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0002E334 File Offset: 0x0002C534
		[CallerCount(0)]
		public unsafe virtual Object Eval(Il2CppStructArray<int> recordNos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recordNos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionNode.NativeMethodInfoPtr_Eval_Internal_Abstract_Virtual_New_Object_Il2CppStructArray_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0002E390 File Offset: 0x0002C590
		[CallerCount(0)]
		public unsafe virtual bool IsConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionNode.NativeMethodInfoPtr_IsConstant_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0002E3D8 File Offset: 0x0002C5D8
		[CallerCount(0)]
		public unsafe virtual bool IsTableConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionNode.NativeMethodInfoPtr_IsTableConstant_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0002E420 File Offset: 0x0002C620
		[CallerCount(0)]
		public unsafe virtual bool HasLocalAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionNode.NativeMethodInfoPtr_HasLocalAggregate_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0002E468 File Offset: 0x0002C668
		[CallerCount(0)]
		public unsafe virtual bool HasRemoteAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionNode.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0002E4B0 File Offset: 0x0002C6B0
		[CallerCount(0)]
		public unsafe virtual ExpressionNode Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionNode.NativeMethodInfoPtr_Optimize_Internal_Abstract_Virtual_New_ExpressionNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr3) : null;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0002E4FC File Offset: 0x0002C6FC
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DependsOn(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ExpressionNode.NativeMethodInfoPtr_DependsOn_Internal_Virtual_New_Boolean_DataColumn_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0002E554 File Offset: 0x0002C754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 903611, RefRangeEnd = 903612, XrefRangeStart = 903611, XrefRangeEnd = 903611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsInteger(StorageType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr_IsInteger_Internal_Static_Boolean_StorageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0002E594 File Offset: 0x0002C794
		[CallerCount(0)]
		public unsafe static bool IsIntegerSql(StorageType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr_IsIntegerSql_Internal_Static_Boolean_StorageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0002E5D4 File Offset: 0x0002C7D4
		[CallerCount(0)]
		public unsafe static bool IsSigned(StorageType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr_IsSigned_Internal_Static_Boolean_StorageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0002E614 File Offset: 0x0002C814
		[CallerCount(0)]
		public unsafe static bool IsSignedSql(StorageType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr_IsSignedSql_Internal_Static_Boolean_StorageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0002E654 File Offset: 0x0002C854
		[CallerCount(0)]
		public unsafe static bool IsUnsigned(StorageType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr_IsUnsigned_Internal_Static_Boolean_StorageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0002E694 File Offset: 0x0002C894
		[CallerCount(0)]
		public unsafe static bool IsUnsignedSql(StorageType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr_IsUnsignedSql_Internal_Static_Boolean_StorageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0002E6D4 File Offset: 0x0002C8D4
		[CallerCount(0)]
		public unsafe static bool IsNumeric(StorageType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr_IsNumeric_Internal_Static_Boolean_StorageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0002E714 File Offset: 0x0002C914
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 903612, RefRangeEnd = 903614, XrefRangeStart = 903612, XrefRangeEnd = 903612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNumericSql(StorageType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr_IsNumericSql_Internal_Static_Boolean_StorageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0002E754 File Offset: 0x0002C954
		[CallerCount(0)]
		public unsafe static bool IsFloat(StorageType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr_IsFloat_Internal_Static_Boolean_StorageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0002E794 File Offset: 0x0002C994
		[CallerCount(0)]
		public unsafe static bool IsFloatSql(StorageType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionNode.NativeMethodInfoPtr_IsFloatSql_Internal_Static_Boolean_StorageType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00004A06 File Offset: 0x00002C06
		public ExpressionNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0002E7D4 File Offset: 0x0002C9D4
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00004A0F File Offset: 0x00002C0F
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionNode.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionNode.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_DataTable_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatProvider_Internal_get_IFormatProvider_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSqlColumn_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_get_table_Protected_get_DataTable_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_BindTable_Protected_Void_DataTable_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Internal_Abstract_Virtual_New_Void_DataTable_List_1_DataColumn_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Abstract_Virtual_New_Object_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Abstract_Virtual_New_Object_DataRow_DataRowVersion_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Abstract_Virtual_New_Object_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_IsConstant_Internal_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_IsTableConstant_Internal_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_HasLocalAggregate_Internal_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_HasRemoteAggregate_Internal_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_Optimize_Internal_Abstract_Virtual_New_ExpressionNode_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_DependsOn_Internal_Virtual_New_Boolean_DataColumn_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_IsInteger_Internal_Static_Boolean_StorageType_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr_IsIntegerSql_Internal_Static_Boolean_StorageType_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_IsSigned_Internal_Static_Boolean_StorageType_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_IsSignedSql_Internal_Static_Boolean_StorageType_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_IsUnsigned_Internal_Static_Boolean_StorageType_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_IsUnsignedSql_Internal_Static_Boolean_StorageType_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_IsNumeric_Internal_Static_Boolean_StorageType_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_IsNumericSql_Internal_Static_Boolean_StorageType_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_IsFloat_Internal_Static_Boolean_StorageType_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_IsFloatSql_Internal_Static_Boolean_StorageType_0;
	}
}
