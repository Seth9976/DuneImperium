using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000207 RID: 519
	public class XPathParser : Object
	{
		// Token: 0x06002D68 RID: 11624 RVA: 0x000D0E7C File Offset: 0x000CF07C
		// Note: this type is marked as 'beforefieldinit'.
		static XPathParser()
		{
			Il2CppClassPointerStore<XPathParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "XPathParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathParser>.NativeClassPtr);
			XPathParser.NativeFieldInfoPtr__scanner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "_scanner");
			XPathParser.NativeFieldInfoPtr__parseDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "_parseDepth");
			XPathParser.NativeFieldInfoPtr_s_temparray1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray1");
			XPathParser.NativeFieldInfoPtr_s_temparray2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray2");
			XPathParser.NativeFieldInfoPtr_s_temparray3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray3");
			XPathParser.NativeFieldInfoPtr_s_temparray4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray4");
			XPathParser.NativeFieldInfoPtr_s_temparray5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray5");
			XPathParser.NativeFieldInfoPtr_s_temparray6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray6");
			XPathParser.NativeFieldInfoPtr_s_temparray7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray7");
			XPathParser.NativeFieldInfoPtr_s_temparray8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray8");
			XPathParser.NativeFieldInfoPtr_s_temparray9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_temparray9");
			XPathParser.NativeFieldInfoPtr_s_functionTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_functionTable");
			XPathParser.NativeFieldInfoPtr_s_AxesTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "s_AxesTable");
			XPathParser.NativeMethodInfoPtr__ctor_Private_Void_XPathScanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669850);
			XPathParser.NativeMethodInfoPtr_ParseXPathExpression_Public_Static_AstNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669851);
			XPathParser.NativeMethodInfoPtr_ParseExpression_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669852);
			XPathParser.NativeMethodInfoPtr_ParseOrExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669853);
			XPathParser.NativeMethodInfoPtr_ParseAndExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669854);
			XPathParser.NativeMethodInfoPtr_ParseEqualityExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669855);
			XPathParser.NativeMethodInfoPtr_ParseRelationalExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669856);
			XPathParser.NativeMethodInfoPtr_ParseAdditiveExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669857);
			XPathParser.NativeMethodInfoPtr_ParseMultiplicativeExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669858);
			XPathParser.NativeMethodInfoPtr_ParseUnaryExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669859);
			XPathParser.NativeMethodInfoPtr_ParseUnionExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669860);
			XPathParser.NativeMethodInfoPtr_IsNodeType_Private_Static_Boolean_XPathScanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669861);
			XPathParser.NativeMethodInfoPtr_ParsePathExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669862);
			XPathParser.NativeMethodInfoPtr_ParseFilterExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669863);
			XPathParser.NativeMethodInfoPtr_ParsePredicate_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669864);
			XPathParser.NativeMethodInfoPtr_ParseLocationPath_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669865);
			XPathParser.NativeMethodInfoPtr_ParseRelativeLocationPath_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669866);
			XPathParser.NativeMethodInfoPtr_IsStep_Private_Static_Boolean_LexKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669867);
			XPathParser.NativeMethodInfoPtr_ParseStep_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669868);
			XPathParser.NativeMethodInfoPtr_ParseNodeTest_Private_AstNode_AstNode_AxisType_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669869);
			XPathParser.NativeMethodInfoPtr_IsPrimaryExpr_Private_Static_Boolean_XPathScanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669870);
			XPathParser.NativeMethodInfoPtr_ParsePrimaryExpr_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669871);
			XPathParser.NativeMethodInfoPtr_ParseMethod_Private_AstNode_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669872);
			XPathParser.NativeMethodInfoPtr_CheckToken_Private_Void_LexKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669873);
			XPathParser.NativeMethodInfoPtr_PassToken_Private_Void_LexKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669874);
			XPathParser.NativeMethodInfoPtr_NextLex_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669875);
			XPathParser.NativeMethodInfoPtr_TestOp_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669876);
			XPathParser.NativeMethodInfoPtr_CheckNodeSet_Private_Void_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669877);
			XPathParser.NativeMethodInfoPtr_CreateFunctionTable_Private_Static_Dictionary_2_String_ParamInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669878);
			XPathParser.NativeMethodInfoPtr_CreateAxesTable_Private_Static_Dictionary_2_String_AxisType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669879);
			XPathParser.NativeMethodInfoPtr_GetAxis_Private_AxisType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, 100669880);
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x000D121C File Offset: 0x000CF41C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathParser(XPathScanner scanner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scanner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr__ctor_Private_Void_XPathScanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x000D1268 File Offset: 0x000CF468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425652, RefRangeEnd = 425653, XrefRangeStart = 425636, XrefRangeEnd = 425652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AstNode ParseXPathExpression(string xpathExpression)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xpathExpression);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseXPathExpression_Public_Static_AstNode_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x000D12AC File Offset: 0x000CF4AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 425667, RefRangeEnd = 425671, XrefRangeStart = 425653, XrefRangeEnd = 425667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseExpression(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseExpression_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x000D12FC File Offset: 0x000CF4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425671, XrefRangeEnd = 425685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseOrExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseOrExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x000D134C File Offset: 0x000CF54C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 425699, RefRangeEnd = 425703, XrefRangeStart = 425685, XrefRangeEnd = 425699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseAndExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseAndExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x000D139C File Offset: 0x000CF59C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425714, RefRangeEnd = 425716, XrefRangeStart = 425703, XrefRangeEnd = 425714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseEqualityExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseEqualityExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x000D13EC File Offset: 0x000CF5EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425729, RefRangeEnd = 425731, XrefRangeStart = 425716, XrefRangeEnd = 425729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseRelationalExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseRelationalExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x000D143C File Offset: 0x000CF63C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425742, RefRangeEnd = 425744, XrefRangeStart = 425731, XrefRangeEnd = 425742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseAdditiveExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseAdditiveExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x000D148C File Offset: 0x000CF68C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425762, RefRangeEnd = 425764, XrefRangeStart = 425744, XrefRangeEnd = 425762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseMultiplicativeExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseMultiplicativeExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x000D14DC File Offset: 0x000CF6DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425781, RefRangeEnd = 425783, XrefRangeStart = 425764, XrefRangeEnd = 425781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseUnaryExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseUnaryExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x000D152C File Offset: 0x000CF72C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425793, RefRangeEnd = 425794, XrefRangeStart = 425783, XrefRangeEnd = 425793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseUnionExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseUnionExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x000D157C File Offset: 0x000CF77C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 425798, RefRangeEnd = 425801, XrefRangeStart = 425794, XrefRangeEnd = 425798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNodeType(XPathScanner scaner)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_IsNodeType_Private_Static_Boolean_XPathScanner_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x000D15C0 File Offset: 0x000CF7C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425844, RefRangeEnd = 425846, XrefRangeStart = 425801, XrefRangeEnd = 425844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParsePathExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParsePathExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x000D1610 File Offset: 0x000CF810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425846, XrefRangeEnd = 425855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseFilterExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseFilterExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x000D1660 File Offset: 0x000CF860
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 425858, RefRangeEnd = 425861, XrefRangeStart = 425855, XrefRangeEnd = 425858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParsePredicate(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParsePredicate_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x000D16B0 File Offset: 0x000CF8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425861, XrefRangeEnd = 425879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseLocationPath(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseLocationPath_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x000D1700 File Offset: 0x000CF900
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 425889, RefRangeEnd = 425892, XrefRangeStart = 425879, XrefRangeEnd = 425889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseRelativeLocationPath(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseRelativeLocationPath_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x000D1750 File Offset: 0x000CF950
		[CallerCount(0)]
		public unsafe static bool IsStep(XPathScanner.LexKind lexKind)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lexKind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_IsStep_Private_Static_Boolean_LexKind_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x000D1790 File Offset: 0x000CF990
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425919, RefRangeEnd = 425921, XrefRangeStart = 425892, XrefRangeEnd = 425919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseStep(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseStep_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x000D17E0 File Offset: 0x000CF9E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 425960, RefRangeEnd = 425961, XrefRangeStart = 425921, XrefRangeEnd = 425960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseNodeTest_Private_AstNode_AstNode_AxisType_XPathNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x000D184C File Offset: 0x000CFA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425961, XrefRangeEnd = 425965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimaryExpr(XPathScanner scanner)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scanner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_IsPrimaryExpr_Private_Static_Boolean_XPathScanner_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x000D1890 File Offset: 0x000CFA90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425973, RefRangeEnd = 425975, XrefRangeStart = 425965, XrefRangeEnd = 425973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParsePrimaryExpr(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParsePrimaryExpr_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x000D18E0 File Offset: 0x000CFAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425975, XrefRangeEnd = 426039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstNode ParseMethod(AstNode qyInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qyInput);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_ParseMethod_Private_AstNode_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x000D1930 File Offset: 0x000CFB30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 426039, RefRangeEnd = 426041, XrefRangeStart = 426039, XrefRangeEnd = 426039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckToken(XPathScanner.LexKind t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_CheckToken_Private_Void_LexKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x000D1970 File Offset: 0x000CFB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426041, XrefRangeEnd = 426044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PassToken(XPathScanner.LexKind t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_PassToken_Private_Void_LexKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x000D19B0 File Offset: 0x000CFBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426044, XrefRangeEnd = 426046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NextLex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_NextLex_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x000D19E4 File Offset: 0x000CFBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426046, XrefRangeEnd = 426047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TestOp(string op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_TestOp_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x000D1A34 File Offset: 0x000CFC34
		[CallerCount(0)]
		public unsafe void CheckNodeSet(XPathResultType t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_CheckNodeSet_Private_Void_XPathResultType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x000D1A74 File Offset: 0x000CFC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426047, XrefRangeEnd = 426301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, XPathParser.ParamInfo> CreateFunctionTable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_CreateFunctionTable_Private_Static_Dictionary_2_String_ParamInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, XPathParser.ParamInfo>>(intPtr3) : null;
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x000D1AA8 File Offset: 0x000CFCA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426301, XrefRangeEnd = 426360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<string, Axis.AxisType> CreateAxesTable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_CreateAxesTable_Private_Static_Dictionary_2_String_AxisType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Axis.AxisType>>(intPtr3) : null;
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x000D1ADC File Offset: 0x000CFCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 426360, XrefRangeEnd = 426367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Axis.AxisType GetAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.NativeMethodInfoPtr_GetAxis_Private_AxisType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00012BE2 File Offset: 0x00010DE2
		public XPathParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06002D89 RID: 11657 RVA: 0x000D1B18 File Offset: 0x000CFD18
		// (set) Token: 0x06002D8A RID: 11658 RVA: 0x00012BEB File Offset: 0x00010DEB
		public unsafe XPathScanner _scanner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.NativeFieldInfoPtr__scanner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XPathScanner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.NativeFieldInfoPtr__scanner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x000D1B48 File Offset: 0x000CFD48
		// (set) Token: 0x06002D8C RID: 11660 RVA: 0x00012C0A File Offset: 0x00010E0A
		public unsafe int _parseDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.NativeFieldInfoPtr__parseDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.NativeFieldInfoPtr__parseDepth)) = value;
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06002D8D RID: 11661 RVA: 0x000D1B70 File Offset: 0x000CFD70
		// (set) Token: 0x06002D8E RID: 11662 RVA: 0x00012C25 File Offset: 0x00010E25
		public unsafe static Il2CppStructArray<XPathResultType> s_temparray1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_s_temparray1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_s_temparray1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06002D8F RID: 11663 RVA: 0x000D1B98 File Offset: 0x000CFD98
		// (set) Token: 0x06002D90 RID: 11664 RVA: 0x00012C37 File Offset: 0x00010E37
		public unsafe static Il2CppStructArray<XPathResultType> s_temparray2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_s_temparray2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_s_temparray2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06002D91 RID: 11665 RVA: 0x000D1BC0 File Offset: 0x000CFDC0
		// (set) Token: 0x06002D92 RID: 11666 RVA: 0x00012C49 File Offset: 0x00010E49
		public unsafe static Il2CppStructArray<XPathResultType> s_temparray3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_s_temparray3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_s_temparray3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06002D93 RID: 11667 RVA: 0x000D1BE8 File Offset: 0x000CFDE8
		// (set) Token: 0x06002D94 RID: 11668 RVA: 0x00012C5B File Offset: 0x00010E5B
		public unsafe static Il2CppStructArray<XPathResultType> s_temparray4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_s_temparray4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_s_temparray4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06002D95 RID: 11669 RVA: 0x000D1C10 File Offset: 0x000CFE10
		// (set) Token: 0x06002D96 RID: 11670 RVA: 0x00012C6D File Offset: 0x00010E6D
		public unsafe static Il2CppStructArray<XPathResultType> s_temparray5
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_s_temparray5, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_s_temparray5, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06002D97 RID: 11671 RVA: 0x000D1C38 File Offset: 0x000CFE38
		// (set) Token: 0x06002D98 RID: 11672 RVA: 0x00012C7F File Offset: 0x00010E7F
		public unsafe static Il2CppStructArray<XPathResultType> s_temparray6
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_s_temparray6, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_s_temparray6, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x000D1C60 File Offset: 0x000CFE60
		// (set) Token: 0x06002D9A RID: 11674 RVA: 0x00012C91 File Offset: 0x00010E91
		public unsafe static Il2CppStructArray<XPathResultType> s_temparray7
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_s_temparray7, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_s_temparray7, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x000D1C88 File Offset: 0x000CFE88
		// (set) Token: 0x06002D9C RID: 11676 RVA: 0x00012CA3 File Offset: 0x00010EA3
		public unsafe static Il2CppStructArray<XPathResultType> s_temparray8
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_s_temparray8, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_s_temparray8, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06002D9D RID: 11677 RVA: 0x000D1CB0 File Offset: 0x000CFEB0
		// (set) Token: 0x06002D9E RID: 11678 RVA: 0x00012CB5 File Offset: 0x00010EB5
		public unsafe static Il2CppStructArray<XPathResultType> s_temparray9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_s_temparray9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_s_temparray9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06002D9F RID: 11679 RVA: 0x000D1CD8 File Offset: 0x000CFED8
		// (set) Token: 0x06002DA0 RID: 11680 RVA: 0x00012CC7 File Offset: 0x00010EC7
		public unsafe static Dictionary<string, XPathParser.ParamInfo> s_functionTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_s_functionTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, XPathParser.ParamInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_s_functionTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06002DA1 RID: 11681 RVA: 0x000D1D00 File Offset: 0x000CFF00
		// (set) Token: 0x06002DA2 RID: 11682 RVA: 0x00012CD9 File Offset: 0x00010ED9
		public unsafe static Dictionary<string, Axis.AxisType> s_AxesTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathParser.NativeFieldInfoPtr_s_AxesTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Axis.AxisType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathParser.NativeFieldInfoPtr_s_AxesTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400229D RID: 8861
		private static readonly IntPtr NativeFieldInfoPtr__scanner;

		// Token: 0x0400229E RID: 8862
		private static readonly IntPtr NativeFieldInfoPtr__parseDepth;

		// Token: 0x0400229F RID: 8863
		private static readonly IntPtr NativeFieldInfoPtr_s_temparray1;

		// Token: 0x040022A0 RID: 8864
		private static readonly IntPtr NativeFieldInfoPtr_s_temparray2;

		// Token: 0x040022A1 RID: 8865
		private static readonly IntPtr NativeFieldInfoPtr_s_temparray3;

		// Token: 0x040022A2 RID: 8866
		private static readonly IntPtr NativeFieldInfoPtr_s_temparray4;

		// Token: 0x040022A3 RID: 8867
		private static readonly IntPtr NativeFieldInfoPtr_s_temparray5;

		// Token: 0x040022A4 RID: 8868
		private static readonly IntPtr NativeFieldInfoPtr_s_temparray6;

		// Token: 0x040022A5 RID: 8869
		private static readonly IntPtr NativeFieldInfoPtr_s_temparray7;

		// Token: 0x040022A6 RID: 8870
		private static readonly IntPtr NativeFieldInfoPtr_s_temparray8;

		// Token: 0x040022A7 RID: 8871
		private static readonly IntPtr NativeFieldInfoPtr_s_temparray9;

		// Token: 0x040022A8 RID: 8872
		private static readonly IntPtr NativeFieldInfoPtr_s_functionTable;

		// Token: 0x040022A9 RID: 8873
		private static readonly IntPtr NativeFieldInfoPtr_s_AxesTable;

		// Token: 0x040022AA RID: 8874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_XPathScanner_0;

		// Token: 0x040022AB RID: 8875
		private static readonly IntPtr NativeMethodInfoPtr_ParseXPathExpression_Public_Static_AstNode_String_0;

		// Token: 0x040022AC RID: 8876
		private static readonly IntPtr NativeMethodInfoPtr_ParseExpression_Private_AstNode_AstNode_0;

		// Token: 0x040022AD RID: 8877
		private static readonly IntPtr NativeMethodInfoPtr_ParseOrExpr_Private_AstNode_AstNode_0;

		// Token: 0x040022AE RID: 8878
		private static readonly IntPtr NativeMethodInfoPtr_ParseAndExpr_Private_AstNode_AstNode_0;

		// Token: 0x040022AF RID: 8879
		private static readonly IntPtr NativeMethodInfoPtr_ParseEqualityExpr_Private_AstNode_AstNode_0;

		// Token: 0x040022B0 RID: 8880
		private static readonly IntPtr NativeMethodInfoPtr_ParseRelationalExpr_Private_AstNode_AstNode_0;

		// Token: 0x040022B1 RID: 8881
		private static readonly IntPtr NativeMethodInfoPtr_ParseAdditiveExpr_Private_AstNode_AstNode_0;

		// Token: 0x040022B2 RID: 8882
		private static readonly IntPtr NativeMethodInfoPtr_ParseMultiplicativeExpr_Private_AstNode_AstNode_0;

		// Token: 0x040022B3 RID: 8883
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnaryExpr_Private_AstNode_AstNode_0;

		// Token: 0x040022B4 RID: 8884
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnionExpr_Private_AstNode_AstNode_0;

		// Token: 0x040022B5 RID: 8885
		private static readonly IntPtr NativeMethodInfoPtr_IsNodeType_Private_Static_Boolean_XPathScanner_0;

		// Token: 0x040022B6 RID: 8886
		private static readonly IntPtr NativeMethodInfoPtr_ParsePathExpr_Private_AstNode_AstNode_0;

		// Token: 0x040022B7 RID: 8887
		private static readonly IntPtr NativeMethodInfoPtr_ParseFilterExpr_Private_AstNode_AstNode_0;

		// Token: 0x040022B8 RID: 8888
		private static readonly IntPtr NativeMethodInfoPtr_ParsePredicate_Private_AstNode_AstNode_0;

		// Token: 0x040022B9 RID: 8889
		private static readonly IntPtr NativeMethodInfoPtr_ParseLocationPath_Private_AstNode_AstNode_0;

		// Token: 0x040022BA RID: 8890
		private static readonly IntPtr NativeMethodInfoPtr_ParseRelativeLocationPath_Private_AstNode_AstNode_0;

		// Token: 0x040022BB RID: 8891
		private static readonly IntPtr NativeMethodInfoPtr_IsStep_Private_Static_Boolean_LexKind_0;

		// Token: 0x040022BC RID: 8892
		private static readonly IntPtr NativeMethodInfoPtr_ParseStep_Private_AstNode_AstNode_0;

		// Token: 0x040022BD RID: 8893
		private static readonly IntPtr NativeMethodInfoPtr_ParseNodeTest_Private_AstNode_AstNode_AxisType_XPathNodeType_0;

		// Token: 0x040022BE RID: 8894
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimaryExpr_Private_Static_Boolean_XPathScanner_0;

		// Token: 0x040022BF RID: 8895
		private static readonly IntPtr NativeMethodInfoPtr_ParsePrimaryExpr_Private_AstNode_AstNode_0;

		// Token: 0x040022C0 RID: 8896
		private static readonly IntPtr NativeMethodInfoPtr_ParseMethod_Private_AstNode_AstNode_0;

		// Token: 0x040022C1 RID: 8897
		private static readonly IntPtr NativeMethodInfoPtr_CheckToken_Private_Void_LexKind_0;

		// Token: 0x040022C2 RID: 8898
		private static readonly IntPtr NativeMethodInfoPtr_PassToken_Private_Void_LexKind_0;

		// Token: 0x040022C3 RID: 8899
		private static readonly IntPtr NativeMethodInfoPtr_NextLex_Private_Void_0;

		// Token: 0x040022C4 RID: 8900
		private static readonly IntPtr NativeMethodInfoPtr_TestOp_Private_Boolean_String_0;

		// Token: 0x040022C5 RID: 8901
		private static readonly IntPtr NativeMethodInfoPtr_CheckNodeSet_Private_Void_XPathResultType_0;

		// Token: 0x040022C6 RID: 8902
		private static readonly IntPtr NativeMethodInfoPtr_CreateFunctionTable_Private_Static_Dictionary_2_String_ParamInfo_0;

		// Token: 0x040022C7 RID: 8903
		private static readonly IntPtr NativeMethodInfoPtr_CreateAxesTable_Private_Static_Dictionary_2_String_AxisType_0;

		// Token: 0x040022C8 RID: 8904
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis_Private_AxisType_0;

		// Token: 0x02000284 RID: 644
		public class ParamInfo : Object
		{
			// Token: 0x060032DB RID: 13019 RVA: 0x000E0DA4 File Offset: 0x000DEFA4
			// Note: this type is marked as 'beforefieldinit'.
			static ParamInfo()
			{
				Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XPathParser>.NativeClassPtr, "ParamInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr);
				XPathParser.ParamInfo.NativeFieldInfoPtr__ftype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, "_ftype");
				XPathParser.ParamInfo.NativeFieldInfoPtr__minargs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, "_minargs");
				XPathParser.ParamInfo.NativeFieldInfoPtr__maxargs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, "_maxargs");
				XPathParser.ParamInfo.NativeFieldInfoPtr__argTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, "_argTypes");
				XPathParser.ParamInfo.NativeMethodInfoPtr_get_FType_Public_get_FunctionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, 100669882);
				XPathParser.ParamInfo.NativeMethodInfoPtr_get_Minargs_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, 100669883);
				XPathParser.ParamInfo.NativeMethodInfoPtr_get_Maxargs_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, 100669884);
				XPathParser.ParamInfo.NativeMethodInfoPtr_get_ArgTypes_Public_get_Il2CppStructArray_1_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, 100669885);
				XPathParser.ParamInfo.NativeMethodInfoPtr__ctor_Internal_Void_FunctionType_Int32_Int32_Il2CppStructArray_1_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr, 100669886);
			}

			// Token: 0x17001119 RID: 4377
			// (get) Token: 0x060032DC RID: 13020 RVA: 0x000E0E84 File Offset: 0x000DF084
			public unsafe Function.FunctionType FType
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.ParamInfo.NativeMethodInfoPtr_get_FType_Public_get_FunctionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700111A RID: 4378
			// (get) Token: 0x060032DD RID: 13021 RVA: 0x000E0EC0 File Offset: 0x000DF0C0
			public unsafe int Minargs
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.ParamInfo.NativeMethodInfoPtr_get_Minargs_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700111B RID: 4379
			// (get) Token: 0x060032DE RID: 13022 RVA: 0x000E0EFC File Offset: 0x000DF0FC
			public unsafe int Maxargs
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.ParamInfo.NativeMethodInfoPtr_get_Maxargs_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700111C RID: 4380
			// (get) Token: 0x060032DF RID: 13023 RVA: 0x000E0F38 File Offset: 0x000DF138
			public unsafe Il2CppStructArray<XPathResultType> ArgTypes
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.ParamInfo.NativeMethodInfoPtr_get_ArgTypes_Public_get_Il2CppStructArray_1_XPathResultType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr3) : null;
				}
			}

			// Token: 0x060032E0 RID: 13024 RVA: 0x000E0F78 File Offset: 0x000DF178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425634, XrefRangeEnd = 425636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParamInfo(Function.FunctionType ftype, int minargs, int maxargs, Il2CppStructArray<XPathResultType> argTypes)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathParser.ParamInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ftype;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minargs;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxargs;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathParser.ParamInfo.NativeMethodInfoPtr__ctor_Internal_Void_FunctionType_Int32_Int32_Il2CppStructArray_1_XPathResultType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032E1 RID: 13025 RVA: 0x00015E43 File Offset: 0x00014043
			public ParamInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001115 RID: 4373
			// (get) Token: 0x060032E2 RID: 13026 RVA: 0x000E0FF0 File Offset: 0x000DF1F0
			// (set) Token: 0x060032E3 RID: 13027 RVA: 0x00015E4C File Offset: 0x0001404C
			public unsafe Function.FunctionType _ftype
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr__ftype);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr__ftype)) = value;
				}
			}

			// Token: 0x17001116 RID: 4374
			// (get) Token: 0x060032E4 RID: 13028 RVA: 0x000E1018 File Offset: 0x000DF218
			// (set) Token: 0x060032E5 RID: 13029 RVA: 0x00015E67 File Offset: 0x00014067
			public unsafe int _minargs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr__minargs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr__minargs)) = value;
				}
			}

			// Token: 0x17001117 RID: 4375
			// (get) Token: 0x060032E6 RID: 13030 RVA: 0x000E1040 File Offset: 0x000DF240
			// (set) Token: 0x060032E7 RID: 13031 RVA: 0x00015E82 File Offset: 0x00014082
			public unsafe int _maxargs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr__maxargs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr__maxargs)) = value;
				}
			}

			// Token: 0x17001118 RID: 4376
			// (get) Token: 0x060032E8 RID: 13032 RVA: 0x000E1068 File Offset: 0x000DF268
			// (set) Token: 0x060032E9 RID: 13033 RVA: 0x00015E9D File Offset: 0x0001409D
			public unsafe Il2CppStructArray<XPathResultType> _argTypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr__argTypes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathParser.ParamInfo.NativeFieldInfoPtr__argTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400282B RID: 10283
			private static readonly IntPtr NativeFieldInfoPtr__ftype;

			// Token: 0x0400282C RID: 10284
			private static readonly IntPtr NativeFieldInfoPtr__minargs;

			// Token: 0x0400282D RID: 10285
			private static readonly IntPtr NativeFieldInfoPtr__maxargs;

			// Token: 0x0400282E RID: 10286
			private static readonly IntPtr NativeFieldInfoPtr__argTypes;

			// Token: 0x0400282F RID: 10287
			private static readonly IntPtr NativeMethodInfoPtr_get_FType_Public_get_FunctionType_0;

			// Token: 0x04002830 RID: 10288
			private static readonly IntPtr NativeMethodInfoPtr_get_Minargs_Public_get_Int32_0;

			// Token: 0x04002831 RID: 10289
			private static readonly IntPtr NativeMethodInfoPtr_get_Maxargs_Public_get_Int32_0;

			// Token: 0x04002832 RID: 10290
			private static readonly IntPtr NativeMethodInfoPtr_get_ArgTypes_Public_get_Il2CppStructArray_1_XPathResultType_0;

			// Token: 0x04002833 RID: 10291
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_FunctionType_Int32_Int32_Il2CppStructArray_1_XPathResultType_0;
		}
	}
}
