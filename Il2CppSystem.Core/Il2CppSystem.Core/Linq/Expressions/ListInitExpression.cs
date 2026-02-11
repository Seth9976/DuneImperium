using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000061 RID: 97
	public sealed class ListInitExpression : Expression
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x0002AE6C File Offset: 0x0002906C
		// Note: this type is marked as 'beforefieldinit'.
		static ListInitExpression()
		{
			Il2CppClassPointerStore<ListInitExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "ListInitExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListInitExpression>.NativeClassPtr);
			ListInitExpression.NativeFieldInfoPtr__NewExpression_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListInitExpression>.NativeClassPtr, "<NewExpression>k__BackingField");
			ListInitExpression.NativeFieldInfoPtr__Initializers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListInitExpression>.NativeClassPtr, "<Initializers>k__BackingField");
			ListInitExpression.NativeMethodInfoPtr_get_NewExpression_Public_get_NewExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListInitExpression>.NativeClassPtr, 100664495);
			ListInitExpression.NativeMethodInfoPtr_get_Initializers_Public_get_ReadOnlyCollection_1_ElementInit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListInitExpression>.NativeClassPtr, 100664496);
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0002AEEC File Offset: 0x000290EC
		public unsafe NewExpression NewExpression
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListInitExpression.NativeMethodInfoPtr_get_NewExpression_Public_get_NewExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NewExpression>(intPtr3) : null;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0002AF2C File Offset: 0x0002912C
		public unsafe ReadOnlyCollection<ElementInit> Initializers
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListInitExpression.NativeMethodInfoPtr_get_Initializers_Public_get_ReadOnlyCollection_1_ElementInit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ElementInit>>(intPtr3) : null;
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00003426 File Offset: 0x00001626
		public ListInitExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0002AF6C File Offset: 0x0002916C
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x0000342F File Offset: 0x0000162F
		public unsafe NewExpression _NewExpression_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListInitExpression.NativeFieldInfoPtr__NewExpression_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListInitExpression.NativeFieldInfoPtr__NewExpression_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0002AF9C File Offset: 0x0002919C
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0000344E File Offset: 0x0000164E
		public unsafe ReadOnlyCollection<ElementInit> _Initializers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListInitExpression.NativeFieldInfoPtr__Initializers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ElementInit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListInitExpression.NativeFieldInfoPtr__Initializers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeFieldInfoPtr__NewExpression_k__BackingField;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr__Initializers_k__BackingField;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_get_NewExpression_Public_get_NewExpression_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_get_Initializers_Public_get_ReadOnlyCollection_1_ElementInit_0;
	}
}
