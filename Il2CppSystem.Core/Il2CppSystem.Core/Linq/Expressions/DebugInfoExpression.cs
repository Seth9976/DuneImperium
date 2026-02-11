using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000042 RID: 66
	public class DebugInfoExpression : Expression
	{
		// Token: 0x0600039F RID: 927 RVA: 0x00021C0C File Offset: 0x0001FE0C
		// Note: this type is marked as 'beforefieldinit'.
		static DebugInfoExpression()
		{
			Il2CppClassPointerStore<DebugInfoExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "DebugInfoExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugInfoExpression>.NativeClassPtr);
			DebugInfoExpression.NativeFieldInfoPtr__Document_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugInfoExpression>.NativeClassPtr, "<Document>k__BackingField");
			DebugInfoExpression.NativeMethodInfoPtr_get_StartLine_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInfoExpression>.NativeClassPtr, 100664169);
			DebugInfoExpression.NativeMethodInfoPtr_get_EndLine_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInfoExpression>.NativeClassPtr, 100664170);
			DebugInfoExpression.NativeMethodInfoPtr_get_Document_Public_get_SymbolDocumentInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInfoExpression>.NativeClassPtr, 100664171);
			DebugInfoExpression.NativeMethodInfoPtr_get_IsClear_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugInfoExpression>.NativeClassPtr, 100664172);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00021CA0 File Offset: 0x0001FEA0
		public unsafe virtual int StartLine
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012193, XrefRangeEnd = 1012196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugInfoExpression.NativeMethodInfoPtr_get_StartLine_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00021CE8 File Offset: 0x0001FEE8
		public unsafe virtual int EndLine
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012196, XrefRangeEnd = 1012199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugInfoExpression.NativeMethodInfoPtr_get_EndLine_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00021D30 File Offset: 0x0001FF30
		public unsafe SymbolDocumentInfo Document
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugInfoExpression.NativeMethodInfoPtr_get_Document_Public_get_SymbolDocumentInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolDocumentInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00021D70 File Offset: 0x0001FF70
		public unsafe virtual bool IsClear
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012199, XrefRangeEnd = 1012202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugInfoExpression.NativeMethodInfoPtr_get_IsClear_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002DB6 File Offset: 0x00000FB6
		public DebugInfoExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00021DB8 File Offset: 0x0001FFB8
		// (set) Token: 0x060003A6 RID: 934 RVA: 0x00002DBF File Offset: 0x00000FBF
		public unsafe SymbolDocumentInfo _Document_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInfoExpression.NativeFieldInfoPtr__Document_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolDocumentInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugInfoExpression.NativeFieldInfoPtr__Document_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeFieldInfoPtr__Document_k__BackingField;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_get_StartLine_Public_Virtual_New_get_Int32_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_get_EndLine_Public_Virtual_New_get_Int32_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_get_Document_Public_get_SymbolDocumentInfo_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClear_Public_Virtual_New_get_Boolean_0;
	}
}
