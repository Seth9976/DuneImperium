using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000208 RID: 520
	public sealed class XPathScanner : Object
	{
		// Token: 0x06002DA3 RID: 11683 RVA: 0x000D1D28 File Offset: 0x000CFF28
		// Note: this type is marked as 'beforefieldinit'.
		static XPathScanner()
		{
			Il2CppClassPointerStore<XPathScanner>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "XPathScanner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr);
			XPathScanner.NativeFieldInfoPtr__xpathExpr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_xpathExpr");
			XPathScanner.NativeFieldInfoPtr__xpathExprIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_xpathExprIndex");
			XPathScanner.NativeFieldInfoPtr__kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_kind");
			XPathScanner.NativeFieldInfoPtr__currentChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_currentChar");
			XPathScanner.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_name");
			XPathScanner.NativeFieldInfoPtr__prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_prefix");
			XPathScanner.NativeFieldInfoPtr__stringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_stringValue");
			XPathScanner.NativeFieldInfoPtr__numberValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_numberValue");
			XPathScanner.NativeFieldInfoPtr__canBeFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_canBeFunction");
			XPathScanner.NativeFieldInfoPtr__xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_xmlCharType");
			XPathScanner.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669887);
			XPathScanner.NativeMethodInfoPtr_get_SourceText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669888);
			XPathScanner.NativeMethodInfoPtr_get_CurrentChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669889);
			XPathScanner.NativeMethodInfoPtr_NextChar_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669890);
			XPathScanner.NativeMethodInfoPtr_get_Kind_Public_get_LexKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669891);
			XPathScanner.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669892);
			XPathScanner.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669893);
			XPathScanner.NativeMethodInfoPtr_get_StringValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669894);
			XPathScanner.NativeMethodInfoPtr_get_NumberValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669895);
			XPathScanner.NativeMethodInfoPtr_get_CanBeFunction_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669896);
			XPathScanner.NativeMethodInfoPtr_SkipSpace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669897);
			XPathScanner.NativeMethodInfoPtr_NextLex_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669898);
			XPathScanner.NativeMethodInfoPtr_ScanNumber_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669899);
			XPathScanner.NativeMethodInfoPtr_ScanFraction_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669900);
			XPathScanner.NativeMethodInfoPtr_ScanString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669901);
			XPathScanner.NativeMethodInfoPtr_ScanName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100669902);
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x000D1F60 File Offset: 0x000D0160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426367, XrefRangeEnd = 426381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathScanner(string xpathExpr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xpathExpr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06002DA5 RID: 11685 RVA: 0x000D1FAC File Offset: 0x000D01AC
		public unsafe string SourceText
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_SourceText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06002DA6 RID: 11686 RVA: 0x000D1FE4 File Offset: 0x000D01E4
		public unsafe char CurrentChar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_CurrentChar_Private_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x000D2020 File Offset: 0x000D0220
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 426381, RefRangeEnd = 426395, XrefRangeStart = 426381, XrefRangeEnd = 426381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_NextChar_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x000D205C File Offset: 0x000D025C
		public unsafe XPathScanner.LexKind Kind
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_Kind_Public_get_LexKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06002DA9 RID: 11689 RVA: 0x000D2098 File Offset: 0x000D0298
		public unsafe string Name
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x000D20D0 File Offset: 0x000D02D0
		public unsafe string Prefix
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06002DAB RID: 11691 RVA: 0x000D2108 File Offset: 0x000D0308
		public unsafe string StringValue
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_StringValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06002DAC RID: 11692 RVA: 0x000D2140 File Offset: 0x000D0340
		public unsafe double NumberValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_NumberValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06002DAD RID: 11693 RVA: 0x000D217C File Offset: 0x000D037C
		public unsafe bool CanBeFunction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_get_CanBeFunction_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x000D21B8 File Offset: 0x000D03B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 426398, RefRangeEnd = 426399, XrefRangeStart = 426395, XrefRangeEnd = 426398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_SkipSpace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x000D21EC File Offset: 0x000D03EC
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 426479, RefRangeEnd = 426516, XrefRangeStart = 426399, XrefRangeEnd = 426479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NextLex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_NextLex_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x000D2228 File Offset: 0x000D0428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 426532, RefRangeEnd = 426533, XrefRangeStart = 426516, XrefRangeEnd = 426532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ScanNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_ScanNumber_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x000D2264 File Offset: 0x000D0464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426533, XrefRangeEnd = 426543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ScanFraction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_ScanFraction_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x000D22A0 File Offset: 0x000D04A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426543, XrefRangeEnd = 426553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ScanString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_ScanString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x000D22D8 File Offset: 0x000D04D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 426559, RefRangeEnd = 426561, XrefRangeStart = 426553, XrefRangeEnd = 426559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ScanName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathScanner.NativeMethodInfoPtr_ScanName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x00012CEB File Offset: 0x00010EEB
		public XPathScanner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06002DB5 RID: 11701 RVA: 0x000D2310 File Offset: 0x000D0510
		// (set) Token: 0x06002DB6 RID: 11702 RVA: 0x00012CF4 File Offset: 0x00010EF4
		public unsafe string _xpathExpr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__xpathExpr);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__xpathExpr), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x000D2338 File Offset: 0x000D0538
		// (set) Token: 0x06002DB8 RID: 11704 RVA: 0x00012D13 File Offset: 0x00010F13
		public unsafe int _xpathExprIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__xpathExprIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__xpathExprIndex)) = value;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06002DB9 RID: 11705 RVA: 0x000D2360 File Offset: 0x000D0560
		// (set) Token: 0x06002DBA RID: 11706 RVA: 0x00012D2E File Offset: 0x00010F2E
		public unsafe XPathScanner.LexKind _kind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__kind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__kind)) = value;
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06002DBB RID: 11707 RVA: 0x000D2388 File Offset: 0x000D0588
		// (set) Token: 0x06002DBC RID: 11708 RVA: 0x00012D49 File Offset: 0x00010F49
		public unsafe char _currentChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__currentChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__currentChar)) = value;
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06002DBD RID: 11709 RVA: 0x000D23B0 File Offset: 0x000D05B0
		// (set) Token: 0x06002DBE RID: 11710 RVA: 0x00012D64 File Offset: 0x00010F64
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06002DBF RID: 11711 RVA: 0x000D23D8 File Offset: 0x000D05D8
		// (set) Token: 0x06002DC0 RID: 11712 RVA: 0x00012D83 File Offset: 0x00010F83
		public unsafe string _prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06002DC1 RID: 11713 RVA: 0x000D2400 File Offset: 0x000D0600
		// (set) Token: 0x06002DC2 RID: 11714 RVA: 0x00012DA2 File Offset: 0x00010FA2
		public unsafe string _stringValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__stringValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__stringValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x000D2428 File Offset: 0x000D0628
		// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x00012DC1 File Offset: 0x00010FC1
		public unsafe double _numberValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__numberValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__numberValue)) = value;
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x000D2450 File Offset: 0x000D0650
		// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x00012DDC File Offset: 0x00010FDC
		public unsafe bool _canBeFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__canBeFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__canBeFunction)) = value;
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06002DC7 RID: 11719 RVA: 0x000D2478 File Offset: 0x000D0678
		// (set) Token: 0x06002DC8 RID: 11720 RVA: 0x00012DF7 File Offset: 0x00010FF7
		public XmlCharType _xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathScanner.NativeFieldInfoPtr__xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040022C9 RID: 8905
		private static readonly IntPtr NativeFieldInfoPtr__xpathExpr;

		// Token: 0x040022CA RID: 8906
		private static readonly IntPtr NativeFieldInfoPtr__xpathExprIndex;

		// Token: 0x040022CB RID: 8907
		private static readonly IntPtr NativeFieldInfoPtr__kind;

		// Token: 0x040022CC RID: 8908
		private static readonly IntPtr NativeFieldInfoPtr__currentChar;

		// Token: 0x040022CD RID: 8909
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x040022CE RID: 8910
		private static readonly IntPtr NativeFieldInfoPtr__prefix;

		// Token: 0x040022CF RID: 8911
		private static readonly IntPtr NativeFieldInfoPtr__stringValue;

		// Token: 0x040022D0 RID: 8912
		private static readonly IntPtr NativeFieldInfoPtr__numberValue;

		// Token: 0x040022D1 RID: 8913
		private static readonly IntPtr NativeFieldInfoPtr__canBeFunction;

		// Token: 0x040022D2 RID: 8914
		private static readonly IntPtr NativeFieldInfoPtr__xmlCharType;

		// Token: 0x040022D3 RID: 8915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040022D4 RID: 8916
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceText_Public_get_String_0;

		// Token: 0x040022D5 RID: 8917
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentChar_Private_get_Char_0;

		// Token: 0x040022D6 RID: 8918
		private static readonly IntPtr NativeMethodInfoPtr_NextChar_Private_Boolean_0;

		// Token: 0x040022D7 RID: 8919
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_get_LexKind_0;

		// Token: 0x040022D8 RID: 8920
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x040022D9 RID: 8921
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x040022DA RID: 8922
		private static readonly IntPtr NativeMethodInfoPtr_get_StringValue_Public_get_String_0;

		// Token: 0x040022DB RID: 8923
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberValue_Public_get_Double_0;

		// Token: 0x040022DC RID: 8924
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeFunction_Public_get_Boolean_0;

		// Token: 0x040022DD RID: 8925
		private static readonly IntPtr NativeMethodInfoPtr_SkipSpace_Private_Void_0;

		// Token: 0x040022DE RID: 8926
		private static readonly IntPtr NativeMethodInfoPtr_NextLex_Public_Boolean_0;

		// Token: 0x040022DF RID: 8927
		private static readonly IntPtr NativeMethodInfoPtr_ScanNumber_Private_Double_0;

		// Token: 0x040022E0 RID: 8928
		private static readonly IntPtr NativeMethodInfoPtr_ScanFraction_Private_Double_0;

		// Token: 0x040022E1 RID: 8929
		private static readonly IntPtr NativeMethodInfoPtr_ScanString_Private_String_0;

		// Token: 0x040022E2 RID: 8930
		private static readonly IntPtr NativeMethodInfoPtr_ScanName_Private_String_0;

		// Token: 0x02000285 RID: 645
		public enum LexKind
		{
			// Token: 0x04002835 RID: 10293
			Comma = 44,
			// Token: 0x04002836 RID: 10294
			Slash = 47,
			// Token: 0x04002837 RID: 10295
			At = 64,
			// Token: 0x04002838 RID: 10296
			Dot = 46,
			// Token: 0x04002839 RID: 10297
			LParens = 40,
			// Token: 0x0400283A RID: 10298
			RParens,
			// Token: 0x0400283B RID: 10299
			LBracket = 91,
			// Token: 0x0400283C RID: 10300
			RBracket = 93,
			// Token: 0x0400283D RID: 10301
			Star = 42,
			// Token: 0x0400283E RID: 10302
			Plus,
			// Token: 0x0400283F RID: 10303
			Minus = 45,
			// Token: 0x04002840 RID: 10304
			Eq = 61,
			// Token: 0x04002841 RID: 10305
			Lt = 60,
			// Token: 0x04002842 RID: 10306
			Gt = 62,
			// Token: 0x04002843 RID: 10307
			Bang = 33,
			// Token: 0x04002844 RID: 10308
			Dollar = 36,
			// Token: 0x04002845 RID: 10309
			Apos = 39,
			// Token: 0x04002846 RID: 10310
			Quote = 34,
			// Token: 0x04002847 RID: 10311
			Union = 124,
			// Token: 0x04002848 RID: 10312
			Ne = 78,
			// Token: 0x04002849 RID: 10313
			Le = 76,
			// Token: 0x0400284A RID: 10314
			Ge = 71,
			// Token: 0x0400284B RID: 10315
			And = 65,
			// Token: 0x0400284C RID: 10316
			Or = 79,
			// Token: 0x0400284D RID: 10317
			DotDot = 68,
			// Token: 0x0400284E RID: 10318
			SlashSlash = 83,
			// Token: 0x0400284F RID: 10319
			Name = 110,
			// Token: 0x04002850 RID: 10320
			String = 115,
			// Token: 0x04002851 RID: 10321
			Number = 100,
			// Token: 0x04002852 RID: 10322
			Axe = 97,
			// Token: 0x04002853 RID: 10323
			Eof = 69
		}
	}
}
