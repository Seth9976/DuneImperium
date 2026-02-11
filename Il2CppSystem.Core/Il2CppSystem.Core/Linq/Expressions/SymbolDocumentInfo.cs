using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000087 RID: 135
	public class SymbolDocumentInfo : Object
	{
		// Token: 0x06000728 RID: 1832 RVA: 0x00031BD4 File Offset: 0x0002FDD4
		// Note: this type is marked as 'beforefieldinit'.
		static SymbolDocumentInfo()
		{
			Il2CppClassPointerStore<SymbolDocumentInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "SymbolDocumentInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SymbolDocumentInfo>.NativeClassPtr);
			SymbolDocumentInfo.NativeFieldInfoPtr__FileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolDocumentInfo>.NativeClassPtr, "<FileName>k__BackingField");
			SymbolDocumentInfo.NativeFieldInfoPtr_DocumentType_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymbolDocumentInfo>.NativeClassPtr, "DocumentType_Text");
			SymbolDocumentInfo.NativeMethodInfoPtr_get_FileName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymbolDocumentInfo>.NativeClassPtr, 100664747);
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00031C40 File Offset: 0x0002FE40
		public unsafe string FileName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymbolDocumentInfo.NativeMethodInfoPtr_get_FileName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00003BF5 File Offset: 0x00001DF5
		public SymbolDocumentInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00031C78 File Offset: 0x0002FE78
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x00003BFE File Offset: 0x00001DFE
		public unsafe string _FileName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolDocumentInfo.NativeFieldInfoPtr__FileName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymbolDocumentInfo.NativeFieldInfoPtr__FileName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00031CA0 File Offset: 0x0002FEA0
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00003C1D File Offset: 0x00001E1D
		public unsafe static Guid DocumentType_Text
		{
			get
			{
				Guid guid;
				IL2CPP.il2cpp_field_static_get_value(SymbolDocumentInfo.NativeFieldInfoPtr_DocumentType_Text, (void*)(&guid));
				return guid;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SymbolDocumentInfo.NativeFieldInfoPtr_DocumentType_Text, (void*)(&value));
			}
		}

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeFieldInfoPtr__FileName_k__BackingField;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr_DocumentType_Text;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeMethodInfoPtr_get_FileName_Public_get_String_0;
	}
}
