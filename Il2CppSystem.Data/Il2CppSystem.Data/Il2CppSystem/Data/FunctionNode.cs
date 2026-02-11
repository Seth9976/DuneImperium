using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Data
{
	// Token: 0x02000019 RID: 25
	public sealed class FunctionNode : ExpressionNode
	{
		// Token: 0x0600043D RID: 1085 RVA: 0x0001B1B4 File Offset: 0x000193B4
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionNode()
		{
			Il2CppClassPointerStore<FunctionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "FunctionNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr);
			FunctionNode.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, "_name");
			FunctionNode.NativeFieldInfoPtr__info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, "_info");
			FunctionNode.NativeFieldInfoPtr__argumentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, "_argumentCount");
			FunctionNode.NativeFieldInfoPtr__arguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, "_arguments");
			FunctionNode.NativeFieldInfoPtr__capturedLimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, "_capturedLimiter");
			FunctionNode.NativeFieldInfoPtr_s_funcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, "s_funcs");
			FunctionNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664040);
			FunctionNode.NativeMethodInfoPtr_AddArgument_Internal_Void_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664041);
			FunctionNode.NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664042);
			FunctionNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664043);
			FunctionNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664044);
			FunctionNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664045);
			FunctionNode.NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664046);
			FunctionNode.NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664047);
			FunctionNode.NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664048);
			FunctionNode.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664049);
			FunctionNode.NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664050);
			FunctionNode.NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664051);
			FunctionNode.NativeMethodInfoPtr_GetDataType_Private_Type_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664052);
			FunctionNode.NativeMethodInfoPtr_EvalFunction_Private_Object_FunctionId_Il2CppReferenceArray_1_Object_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664053);
			FunctionNode.NativeMethodInfoPtr_get_Aggregate_Internal_get_FunctionId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664054);
			FunctionNode.NativeMethodInfoPtr_get_IsAggregate_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664055);
			FunctionNode.NativeMethodInfoPtr_Check_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr, 100664056);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0001B3B0 File Offset: 0x000195B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 897209, RefRangeEnd = 897211, XrefRangeStart = 897197, XrefRangeEnd = 897209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionNode(DataTable table, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0001B410 File Offset: 0x00019610
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 897234, RefRangeEnd = 897236, XrefRangeStart = 897211, XrefRangeEnd = 897234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddArgument(ExpressionNode argument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(argument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_AddArgument_Internal_Void_ExpressionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0001B454 File Offset: 0x00019654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897236, XrefRangeEnd = 897246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0001B4A8 File Offset: 0x000196A8
		[CallerCount(0)]
		public unsafe override Object Eval()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0001B4E8 File Offset: 0x000196E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897246, XrefRangeEnd = 897332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0001B548 File Offset: 0x00019748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897332, XrefRangeEnd = 897336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Eval(Il2CppStructArray<int> recordNos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recordNos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0001B598 File Offset: 0x00019798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897336, XrefRangeEnd = 897337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0001B5D4 File Offset: 0x000197D4
		[CallerCount(0)]
		public unsafe override bool IsTableConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0001B610 File Offset: 0x00019810
		[CallerCount(0)]
		public unsafe override bool HasLocalAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0001B64C File Offset: 0x0001984C
		[CallerCount(0)]
		public unsafe override bool HasRemoteAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0001B688 File Offset: 0x00019888
		[CallerCount(0)]
		public unsafe override bool DependsOn(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0001B6D8 File Offset: 0x000198D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897337, XrefRangeEnd = 897347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ExpressionNode Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr3) : null;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001B718 File Offset: 0x00019918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897347, XrefRangeEnd = 897374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetDataType(ExpressionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_GetDataType_Private_Type_ExpressionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0001B768 File Offset: 0x00019968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897374, XrefRangeEnd = 897418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object EvalFunction(FunctionId id, Il2CppReferenceArray<Object> argumentValues, DataRow row, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentValues);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(row);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_EvalFunction_Private_Object_FunctionId_Il2CppReferenceArray_1_Object_DataRow_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0001B7E8 File Offset: 0x000199E8
		public unsafe FunctionId Aggregate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 897420, RefRangeEnd = 897421, XrefRangeStart = 897418, XrefRangeEnd = 897420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_get_Aggregate_Internal_get_FunctionId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0001B824 File Offset: 0x00019A24
		public unsafe bool IsAggregate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 897437, RefRangeEnd = 897438, XrefRangeStart = 897421, XrefRangeEnd = 897437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_get_IsAggregate_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0001B860 File Offset: 0x00019A60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 897453, RefRangeEnd = 897455, XrefRangeStart = 897438, XrefRangeEnd = 897453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionNode.NativeMethodInfoPtr_Check_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00003230 File Offset: 0x00001430
		public FunctionNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0001B894 File Offset: 0x00019A94
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00003239 File Offset: 0x00001439
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionNode.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionNode.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x0001B8BC File Offset: 0x00019ABC
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00003258 File Offset: 0x00001458
		public unsafe int _info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionNode.NativeFieldInfoPtr__info);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionNode.NativeFieldInfoPtr__info)) = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0001B8E4 File Offset: 0x00019AE4
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00003273 File Offset: 0x00001473
		public unsafe int _argumentCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionNode.NativeFieldInfoPtr__argumentCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionNode.NativeFieldInfoPtr__argumentCount)) = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0001B90C File Offset: 0x00019B0C
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x0000328E File Offset: 0x0000148E
		public unsafe Il2CppReferenceArray<ExpressionNode> _arguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionNode.NativeFieldInfoPtr__arguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExpressionNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionNode.NativeFieldInfoPtr__arguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0001B93C File Offset: 0x00019B3C
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x000032AD File Offset: 0x000014AD
		public unsafe TypeLimiter _capturedLimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionNode.NativeFieldInfoPtr__capturedLimiter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeLimiter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionNode.NativeFieldInfoPtr__capturedLimiter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0001B96C File Offset: 0x00019B6C
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x000032CC File Offset: 0x000014CC
		public unsafe static Il2CppReferenceArray<Function> s_funcs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FunctionNode.NativeFieldInfoPtr_s_funcs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Function>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FunctionNode.NativeFieldInfoPtr_s_funcs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr__info;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr__argumentCount;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeFieldInfoPtr__arguments;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeFieldInfoPtr__capturedLimiter;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeFieldInfoPtr_s_funcs;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_AddArgument_Internal_Void_ExpressionNode_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_GetDataType_Private_Type_ExpressionNode_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_EvalFunction_Private_Object_FunctionId_Il2CppReferenceArray_1_Object_DataRow_DataRowVersion_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_get_Aggregate_Internal_get_FunctionId_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAggregate_Internal_get_Boolean_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_Check_Internal_Void_0;
	}
}
