using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Data
{
	// Token: 0x0200004F RID: 79
	public sealed class AggregateNode : ExpressionNode
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x0002BC9C File Offset: 0x00029E9C
		// Note: this type is marked as 'beforefieldinit'.
		static AggregateNode()
		{
			Il2CppClassPointerStore<AggregateNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "AggregateNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr);
			AggregateNode.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, "_type");
			AggregateNode.NativeFieldInfoPtr__aggregate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, "_aggregate");
			AggregateNode.NativeFieldInfoPtr__local = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, "_local");
			AggregateNode.NativeFieldInfoPtr__relationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, "_relationName");
			AggregateNode.NativeFieldInfoPtr__columnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, "_columnName");
			AggregateNode.NativeFieldInfoPtr__childTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, "_childTable");
			AggregateNode.NativeFieldInfoPtr__column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, "_column");
			AggregateNode.NativeFieldInfoPtr__relation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, "_relation");
			AggregateNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_FunctionId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, 100664650);
			AggregateNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_FunctionId_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, 100664651);
			AggregateNode.NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, 100664652);
			AggregateNode.NativeMethodInfoPtr_Bind_Internal_Static_Void_DataRelation_List_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, 100664653);
			AggregateNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, 100664654);
			AggregateNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, 100664655);
			AggregateNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, 100664656);
			AggregateNode.NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, 100664657);
			AggregateNode.NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, 100664658);
			AggregateNode.NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, 100664659);
			AggregateNode.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, 100664660);
			AggregateNode.NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, 100664661);
			AggregateNode.NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr, 100664662);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0002BE70 File Offset: 0x0002A070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902834, XrefRangeEnd = 902835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateNode(DataTable table, FunctionId aggregateType, string columnName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aggregateType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(columnName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_FunctionId_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0002BEDC File Offset: 0x0002A0DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 902854, RefRangeEnd = 902856, XrefRangeStart = 902835, XrefRangeEnd = 902854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateNode(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggregateNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aggregateType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(columnName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref local;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relationName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_FunctionId_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0002BF68 File Offset: 0x0002A168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902856, XrefRangeEnd = 902886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateNode.NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0002BFBC File Offset: 0x0002A1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902886, XrefRangeEnd = 902900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Bind(DataRelation relation, List<DataColumn> list)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(relation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateNode.NativeMethodInfoPtr_Bind_Internal_Static_Void_DataRelation_List_1_DataColumn_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0002C004 File Offset: 0x0002A204
		[CallerCount(0)]
		public unsafe override Object Eval()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0002C044 File Offset: 0x0002A244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902900, XrefRangeEnd = 902937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0002C0A4 File Offset: 0x0002A2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902937, XrefRangeEnd = 902947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Eval(Il2CppStructArray<int> records)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(records);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0002C0F4 File Offset: 0x0002A2F4
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateNode.NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0002C130 File Offset: 0x0002A330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsTableConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateNode.NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0002C16C File Offset: 0x0002A36C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasLocalAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateNode.NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0002C1A8 File Offset: 0x0002A3A8
		[CallerCount(0)]
		public unsafe override bool HasRemoteAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateNode.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0002C1E4 File Offset: 0x0002A3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 902947, XrefRangeEnd = 902948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DependsOn(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateNode.NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0002C234 File Offset: 0x0002A434
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ExpressionNode Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AggregateNode.NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr3) : null;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0000474F File Offset: 0x0000294F
		public AggregateNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x0002C274 File Offset: 0x0002A474
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00004758 File Offset: 0x00002958
		public unsafe AggregateType _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0002C29C File Offset: 0x0002A49C
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00004773 File Offset: 0x00002973
		public unsafe Aggregate _aggregate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__aggregate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__aggregate)) = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0002C2C4 File Offset: 0x0002A4C4
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x0000478E File Offset: 0x0000298E
		public unsafe bool _local
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__local);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__local)) = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0002C2EC File Offset: 0x0002A4EC
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x000047A9 File Offset: 0x000029A9
		public unsafe string _relationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__relationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__relationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0002C314 File Offset: 0x0002A514
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x000047C8 File Offset: 0x000029C8
		public unsafe string _columnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__columnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__columnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0002C33C File Offset: 0x0002A53C
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x000047E7 File Offset: 0x000029E7
		public unsafe DataTable _childTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__childTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__childTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x0002C36C File Offset: 0x0002A56C
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00004806 File Offset: 0x00002A06
		public unsafe DataColumn _column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__column);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__column), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x0002C39C File Offset: 0x0002A59C
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x00004825 File Offset: 0x00002A25
		public unsafe DataRelation _relation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__relation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRelation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AggregateNode.NativeFieldInfoPtr__relation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeFieldInfoPtr__aggregate;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeFieldInfoPtr__local;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr__relationName;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr__columnName;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeFieldInfoPtr__childTable;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeFieldInfoPtr__column;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeFieldInfoPtr__relation;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_FunctionId_String_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_FunctionId_String_Boolean_String_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Internal_Static_Void_DataRelation_List_1_DataColumn_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0;
	}
}
