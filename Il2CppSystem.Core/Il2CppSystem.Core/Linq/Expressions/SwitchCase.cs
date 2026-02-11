using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000085 RID: 133
	public sealed class SwitchCase : Object
	{
		// Token: 0x06000712 RID: 1810 RVA: 0x000317E4 File Offset: 0x0002F9E4
		// Note: this type is marked as 'beforefieldinit'.
		static SwitchCase()
		{
			Il2CppClassPointerStore<SwitchCase>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "SwitchCase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchCase>.NativeClassPtr);
			SwitchCase.NativeFieldInfoPtr__TestValues_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchCase>.NativeClassPtr, "<TestValues>k__BackingField");
			SwitchCase.NativeFieldInfoPtr__Body_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchCase>.NativeClassPtr, "<Body>k__BackingField");
			SwitchCase.NativeMethodInfoPtr_get_TestValues_Public_get_ReadOnlyCollection_1_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchCase>.NativeClassPtr, 100664741);
			SwitchCase.NativeMethodInfoPtr_get_Body_Public_get_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchCase>.NativeClassPtr, 100664742);
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00031864 File Offset: 0x0002FA64
		public unsafe ReadOnlyCollection<Expression> TestValues
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchCase.NativeMethodInfoPtr_get_TestValues_Public_get_ReadOnlyCollection_1_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr3) : null;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x000318A4 File Offset: 0x0002FAA4
		public unsafe Expression Body
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SwitchCase.NativeMethodInfoPtr_get_Body_Public_get_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00003B29 File Offset: 0x00001D29
		public SwitchCase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x000318E4 File Offset: 0x0002FAE4
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00003B32 File Offset: 0x00001D32
		public unsafe ReadOnlyCollection<Expression> _TestValues_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchCase.NativeFieldInfoPtr__TestValues_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchCase.NativeFieldInfoPtr__TestValues_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00031914 File Offset: 0x0002FB14
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00003B51 File Offset: 0x00001D51
		public unsafe Expression _Body_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchCase.NativeFieldInfoPtr__Body_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SwitchCase.NativeFieldInfoPtr__Body_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeFieldInfoPtr__TestValues_k__BackingField;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeFieldInfoPtr__Body_k__BackingField;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_get_TestValues_Public_get_ReadOnlyCollection_1_Expression_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_get_Body_Public_get_Expression_0;
	}
}
