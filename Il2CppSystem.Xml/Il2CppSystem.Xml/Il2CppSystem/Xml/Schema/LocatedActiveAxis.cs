using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200010E RID: 270
	public class LocatedActiveAxis : ActiveAxis
	{
		// Token: 0x0600184F RID: 6223 RVA: 0x0007DE48 File Offset: 0x0007C048
		// Note: this type is marked as 'beforefieldinit'.
		static LocatedActiveAxis()
		{
			Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "LocatedActiveAxis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr);
			LocatedActiveAxis.NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr, "column");
			LocatedActiveAxis.NativeFieldInfoPtr_isMatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr, "isMatched");
			LocatedActiveAxis.NativeFieldInfoPtr_Ks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr, "Ks");
			LocatedActiveAxis.NativeMethodInfoPtr_get_Column_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr, 100667074);
			LocatedActiveAxis.NativeMethodInfoPtr__ctor_Internal_Void_Asttree_KeySequence_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr, 100667075);
			LocatedActiveAxis.NativeMethodInfoPtr_Reactivate_Internal_Void_KeySequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr, 100667076);
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x0007DEF0 File Offset: 0x0007C0F0
		public unsafe int Column
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocatedActiveAxis.NativeMethodInfoPtr_get_Column_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0007DF2C File Offset: 0x0007C12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391890, XrefRangeEnd = 391892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocatedActiveAxis(Asttree astfield, KeySequence ks, int column)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocatedActiveAxis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(astfield);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ks);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref column;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocatedActiveAxis.NativeMethodInfoPtr__ctor_Internal_Void_Asttree_KeySequence_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0007DF98 File Offset: 0x0007C198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391892, XrefRangeEnd = 391893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reactivate(KeySequence ks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocatedActiveAxis.NativeMethodInfoPtr_Reactivate_Internal_Void_KeySequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0000A65A File Offset: 0x0000885A
		public LocatedActiveAxis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x0007DFDC File Offset: 0x0007C1DC
		// (set) Token: 0x06001855 RID: 6229 RVA: 0x0000A663 File Offset: 0x00008863
		public unsafe int column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocatedActiveAxis.NativeFieldInfoPtr_column);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocatedActiveAxis.NativeFieldInfoPtr_column)) = value;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x0007E004 File Offset: 0x0007C204
		// (set) Token: 0x06001857 RID: 6231 RVA: 0x0000A67E File Offset: 0x0000887E
		public unsafe bool isMatched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocatedActiveAxis.NativeFieldInfoPtr_isMatched);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocatedActiveAxis.NativeFieldInfoPtr_isMatched)) = value;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x0007E02C File Offset: 0x0007C22C
		// (set) Token: 0x06001859 RID: 6233 RVA: 0x0000A699 File Offset: 0x00008899
		public unsafe KeySequence Ks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocatedActiveAxis.NativeFieldInfoPtr_Ks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeySequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocatedActiveAxis.NativeFieldInfoPtr_Ks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeFieldInfoPtr_column;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeFieldInfoPtr_isMatched;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeFieldInfoPtr_Ks;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeMethodInfoPtr_get_Column_Internal_get_Int32_0;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Asttree_KeySequence_Int32_0;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeMethodInfoPtr_Reactivate_Internal_Void_KeySequence_0;
	}
}
