using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Data
{
	// Token: 0x02000025 RID: 37
	public class ConstraintEnumerator : Object
	{
		// Token: 0x06000500 RID: 1280 RVA: 0x0001EF20 File Offset: 0x0001D120
		// Note: this type is marked as 'beforefieldinit'.
		static ConstraintEnumerator()
		{
			Il2CppClassPointerStore<ConstraintEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "ConstraintEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstraintEnumerator>.NativeClassPtr);
			ConstraintEnumerator.NativeFieldInfoPtr__tables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintEnumerator>.NativeClassPtr, "_tables");
			ConstraintEnumerator.NativeFieldInfoPtr__constraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintEnumerator>.NativeClassPtr, "_constraints");
			ConstraintEnumerator.NativeFieldInfoPtr__currentObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintEnumerator>.NativeClassPtr, "_currentObject");
			ConstraintEnumerator.NativeMethodInfoPtr__ctor_Public_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintEnumerator>.NativeClassPtr, 100664170);
			ConstraintEnumerator.NativeMethodInfoPtr_GetNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintEnumerator>.NativeClassPtr, 100664171);
			ConstraintEnumerator.NativeMethodInfoPtr_GetConstraint_Public_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintEnumerator>.NativeClassPtr, 100664172);
			ConstraintEnumerator.NativeMethodInfoPtr_IsValidCandidate_Protected_Virtual_New_Boolean_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintEnumerator>.NativeClassPtr, 100664173);
			ConstraintEnumerator.NativeMethodInfoPtr_get_CurrentObject_Protected_get_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintEnumerator>.NativeClassPtr, 100664174);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001EFF0 File Offset: 0x0001D1F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 898538, RefRangeEnd = 898539, XrefRangeStart = 898533, XrefRangeEnd = 898538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstraintEnumerator(DataSet dataSet)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstraintEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintEnumerator.NativeMethodInfoPtr__ctor_Public_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001F03C File Offset: 0x0001D23C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 898558, RefRangeEnd = 898566, XrefRangeStart = 898539, XrefRangeEnd = 898558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintEnumerator.NativeMethodInfoPtr_GetNext_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001F078 File Offset: 0x0001D278
		[CallerCount(0)]
		public unsafe Constraint GetConstraint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintEnumerator.NativeMethodInfoPtr_GetConstraint_Public_Constraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constraint>(intPtr3) : null;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0001F0B8 File Offset: 0x0001D2B8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidCandidate(Constraint constraint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstraintEnumerator.NativeMethodInfoPtr_IsValidCandidate_Protected_Virtual_New_Boolean_Constraint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0001F110 File Offset: 0x0001D310
		public unsafe Constraint CurrentObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintEnumerator.NativeMethodInfoPtr_get_CurrentObject_Protected_get_Constraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Constraint>(intPtr3) : null;
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000035DE File Offset: 0x000017DE
		public ConstraintEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0001F150 File Offset: 0x0001D350
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x000035E7 File Offset: 0x000017E7
		public unsafe IEnumerator _tables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintEnumerator.NativeFieldInfoPtr__tables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintEnumerator.NativeFieldInfoPtr__tables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0001F180 File Offset: 0x0001D380
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00003606 File Offset: 0x00001806
		public unsafe IEnumerator _constraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintEnumerator.NativeFieldInfoPtr__constraints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintEnumerator.NativeFieldInfoPtr__constraints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0001F1B0 File Offset: 0x0001D3B0
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00003625 File Offset: 0x00001825
		public unsafe Constraint _currentObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintEnumerator.NativeFieldInfoPtr__currentObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintEnumerator.NativeFieldInfoPtr__currentObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr__tables;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr__constraints;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr__currentObject;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataSet_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Public_Boolean_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_GetConstraint_Public_Constraint_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_IsValidCandidate_Protected_Virtual_New_Boolean_Constraint_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentObject_Protected_get_Constraint_0;
	}
}
