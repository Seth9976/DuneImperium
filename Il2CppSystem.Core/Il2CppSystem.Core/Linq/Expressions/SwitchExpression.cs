using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000086 RID: 134
	public sealed class SwitchExpression : Expression
	{
		// Token: 0x0600071A RID: 1818 RVA: 0x00031944 File Offset: 0x0002FB44
		// Note: this type is marked as 'beforefieldinit'.
		static SwitchExpression()
		{
			Il2CppClassPointerStore<SwitchExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "SwitchExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchExpression>.NativeClassPtr);
			SwitchExpression.NativeFieldInfoPtr__SwitchValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchExpression>.NativeClassPtr, "<SwitchValue>k__BackingField");
			SwitchExpression.NativeFieldInfoPtr__Cases_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchExpression>.NativeClassPtr, "<Cases>k__BackingField");
			SwitchExpression.NativeFieldInfoPtr__DefaultBody_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchExpression>.NativeClassPtr, "<DefaultBody>k__BackingField");
			SwitchExpression.NativeFieldInfoPtr__Comparison_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchExpression>.NativeClassPtr, "<Comparison>k__BackingField");
			SwitchExpression.NativeMethodInfoPtr_get_SwitchValue_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchExpression>.NativeClassPtr, 100664743);
			SwitchExpression.NativeMethodInfoPtr_get_Cases_Public_get_ReadOnlyCollection_1_SwitchCase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchExpression>.NativeClassPtr, 100664744);
			SwitchExpression.NativeMethodInfoPtr_get_DefaultBody_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchExpression>.NativeClassPtr, 100664745);
			SwitchExpression.NativeMethodInfoPtr_get_Comparison_Public_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchExpression>.NativeClassPtr, 100664746);
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00031A14 File Offset: 0x0002FC14
		public unsafe Expression SwitchValue
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchExpression.NativeMethodInfoPtr_get_SwitchValue_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00031A54 File Offset: 0x0002FC54
		public unsafe ReadOnlyCollection<SwitchCase> Cases
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchExpression.NativeMethodInfoPtr_get_Cases_Public_get_ReadOnlyCollection_1_SwitchCase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<SwitchCase>>(intPtr3) : null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00031A94 File Offset: 0x0002FC94
		public unsafe Expression DefaultBody
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchExpression.NativeMethodInfoPtr_get_DefaultBody_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00031AD4 File Offset: 0x0002FCD4
		public unsafe MethodInfo Comparison
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchExpression.NativeMethodInfoPtr_get_Comparison_Public_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00003B70 File Offset: 0x00001D70
		public SwitchExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00031B14 File Offset: 0x0002FD14
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x00003B79 File Offset: 0x00001D79
		public unsafe Expression _SwitchValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchExpression.NativeFieldInfoPtr__SwitchValue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchExpression.NativeFieldInfoPtr__SwitchValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00031B44 File Offset: 0x0002FD44
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00003B98 File Offset: 0x00001D98
		public unsafe ReadOnlyCollection<SwitchCase> _Cases_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchExpression.NativeFieldInfoPtr__Cases_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<SwitchCase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchExpression.NativeFieldInfoPtr__Cases_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00031B74 File Offset: 0x0002FD74
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x00003BB7 File Offset: 0x00001DB7
		public unsafe Expression _DefaultBody_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchExpression.NativeFieldInfoPtr__DefaultBody_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchExpression.NativeFieldInfoPtr__DefaultBody_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00031BA4 File Offset: 0x0002FDA4
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x00003BD6 File Offset: 0x00001DD6
		public unsafe MethodInfo _Comparison_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchExpression.NativeFieldInfoPtr__Comparison_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchExpression.NativeFieldInfoPtr__Comparison_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeFieldInfoPtr__SwitchValue_k__BackingField;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeFieldInfoPtr__Cases_k__BackingField;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeFieldInfoPtr__DefaultBody_k__BackingField;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeFieldInfoPtr__Comparison_k__BackingField;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeMethodInfoPtr_get_SwitchValue_Public_get_Expression_0;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeMethodInfoPtr_get_Cases_Public_get_ReadOnlyCollection_1_SwitchCase_0;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultBody_Public_get_Expression_0;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeMethodInfoPtr_get_Comparison_Public_get_MethodInfo_0;
	}
}
