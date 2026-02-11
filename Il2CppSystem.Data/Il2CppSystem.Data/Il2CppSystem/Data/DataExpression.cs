using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Data.Common;

namespace Il2CppSystem.Data
{
	// Token: 0x02000053 RID: 83
	public sealed class DataExpression : Object
	{
		// Token: 0x06000880 RID: 2176 RVA: 0x0002D6E0 File Offset: 0x0002B8E0
		// Note: this type is marked as 'beforefieldinit'.
		static DataExpression()
		{
			Il2CppClassPointerStore<DataExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DataExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataExpression>.NativeClassPtr);
			DataExpression.NativeFieldInfoPtr__originalExpression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, "_originalExpression");
			DataExpression.NativeFieldInfoPtr__parsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, "_parsed");
			DataExpression.NativeFieldInfoPtr__bound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, "_bound");
			DataExpression.NativeFieldInfoPtr__expr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, "_expr");
			DataExpression.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, "_table");
			DataExpression.NativeFieldInfoPtr__storageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, "_storageType");
			DataExpression.NativeFieldInfoPtr__dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, "_dataType");
			DataExpression.NativeFieldInfoPtr__dependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, "_dependency");
			DataExpression.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664702);
			DataExpression.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664703);
			DataExpression.NativeMethodInfoPtr_get_Expression_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664704);
			DataExpression.NativeMethodInfoPtr_get_HasValue_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664705);
			DataExpression.NativeMethodInfoPtr_Bind_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664706);
			DataExpression.NativeMethodInfoPtr_DependsOn_Internal_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664707);
			DataExpression.NativeMethodInfoPtr_Evaluate_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664708);
			DataExpression.NativeMethodInfoPtr_Evaluate_Internal_Object_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664709);
			DataExpression.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Boolean_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664710);
			DataExpression.NativeMethodInfoPtr_GetDependency_Internal_Il2CppReferenceArray_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664711);
			DataExpression.NativeMethodInfoPtr_IsTableAggregate_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664712);
			DataExpression.NativeMethodInfoPtr_IsUnknown_Internal_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664713);
			DataExpression.NativeMethodInfoPtr_HasLocalAggregate_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664714);
			DataExpression.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664715);
			DataExpression.NativeMethodInfoPtr_ToBoolean_Internal_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExpression>.NativeClassPtr, 100664716);
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0002D8DC File Offset: 0x0002BADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 903462, XrefRangeEnd = 903463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataExpression(DataTable table, string expression)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expression);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x0002D93C File Offset: 0x0002BB3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 903515, RefRangeEnd = 903518, XrefRangeStart = 903463, XrefRangeEnd = 903515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataExpression(DataTable table, string expression, Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expression);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0002D9AC File Offset: 0x0002BBAC
		public unsafe string Expression
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 903519, RefRangeEnd = 903520, XrefRangeStart = 903518, XrefRangeEnd = 903519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr_get_Expression_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0002D9E4 File Offset: 0x0002BBE4
		public unsafe bool HasValue
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 434802, RefRangeEnd = 434827, XrefRangeStart = 434802, XrefRangeEnd = 434827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr_get_HasValue_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0002DA20 File Offset: 0x0002BC20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 903533, RefRangeEnd = 903535, XrefRangeStart = 903520, XrefRangeEnd = 903533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bind(DataTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr_Bind_Internal_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0002DA64 File Offset: 0x0002BC64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 903535, RefRangeEnd = 903538, XrefRangeStart = 903535, XrefRangeEnd = 903535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DependsOn(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr_DependsOn_Internal_Boolean_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0002DAB4 File Offset: 0x0002BCB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 903539, RefRangeEnd = 903540, XrefRangeStart = 903538, XrefRangeEnd = 903539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr_Evaluate_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0002DAF4 File Offset: 0x0002BCF4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 903548, RefRangeEnd = 903559, XrefRangeStart = 903540, XrefRangeEnd = 903548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Evaluate(DataRow row, DataRowVersion version)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr_Evaluate_Internal_Object_DataRow_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0002DB54 File Offset: 0x0002BD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 903559, XrefRangeEnd = 903560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Invoke(DataRow row, DataRowVersion version)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Boolean_DataRow_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0002DBB0 File Offset: 0x0002BDB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<DataColumn> GetDependency()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr_GetDependency_Internal_Il2CppReferenceArray_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr3) : null;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0002DBF0 File Offset: 0x0002BDF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 903560, RefRangeEnd = 903562, XrefRangeStart = 903560, XrefRangeEnd = 903560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTableAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr_IsTableAggregate_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0002DC2C File Offset: 0x0002BE2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 903566, RefRangeEnd = 903567, XrefRangeStart = 903562, XrefRangeEnd = 903566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUnknown(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr_IsUnknown_Internal_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x0002DC70 File Offset: 0x0002BE70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 903567, RefRangeEnd = 903570, XrefRangeStart = 903567, XrefRangeEnd = 903567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasLocalAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr_HasLocalAggregate_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0002DCAC File Offset: 0x0002BEAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 903570, RefRangeEnd = 903571, XrefRangeStart = 903570, XrefRangeEnd = 903570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasRemoteAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0002DCE8 File Offset: 0x0002BEE8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 903585, RefRangeEnd = 903589, XrefRangeStart = 903571, XrefRangeEnd = 903585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ToBoolean(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExpression.NativeMethodInfoPtr_ToBoolean_Internal_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00004911 File Offset: 0x00002B11
		public DataExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x0002DD2C File Offset: 0x0002BF2C
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x0000491A File Offset: 0x00002B1A
		public unsafe string _originalExpression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__originalExpression);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__originalExpression), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x0002DD54 File Offset: 0x0002BF54
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x00004939 File Offset: 0x00002B39
		public unsafe bool _parsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__parsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__parsed)) = value;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x0002DD7C File Offset: 0x0002BF7C
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x00004954 File Offset: 0x00002B54
		public unsafe bool _bound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__bound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__bound)) = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x0002DDA4 File Offset: 0x0002BFA4
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x0000496F File Offset: 0x00002B6F
		public unsafe ExpressionNode _expr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__expr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__expr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x0002DDD4 File Offset: 0x0002BFD4
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x0000498E File Offset: 0x00002B8E
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x0002DE04 File Offset: 0x0002C004
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x000049AD File Offset: 0x00002BAD
		public unsafe StorageType _storageType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__storageType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__storageType)) = value;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x0002DE2C File Offset: 0x0002C02C
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x000049C8 File Offset: 0x00002BC8
		public unsafe Type _dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x0002DE5C File Offset: 0x0002C05C
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x000049E7 File Offset: 0x00002BE7
		public unsafe Il2CppReferenceArray<DataColumn> _dependency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__dependency);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataColumn>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExpression.NativeFieldInfoPtr__dependency), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeFieldInfoPtr__originalExpression;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeFieldInfoPtr__parsed;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeFieldInfoPtr__bound;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeFieldInfoPtr__expr;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeFieldInfoPtr__storageType;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeFieldInfoPtr__dataType;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeFieldInfoPtr__dependency;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_Type_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_get_Expression_Internal_get_String_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_get_HasValue_Internal_get_Boolean_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Internal_Void_DataTable_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_DependsOn_Internal_Boolean_DataColumn_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Internal_Object_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Internal_Object_DataRow_DataRowVersion_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Boolean_DataRow_DataRowVersion_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_GetDependency_Internal_Il2CppReferenceArray_1_DataColumn_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_IsTableAggregate_Internal_Boolean_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_IsUnknown_Internal_Static_Boolean_Object_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_HasLocalAggregate_Internal_Boolean_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_HasRemoteAggregate_Internal_Boolean_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_ToBoolean_Internal_Static_Boolean_Object_0;
	}
}
