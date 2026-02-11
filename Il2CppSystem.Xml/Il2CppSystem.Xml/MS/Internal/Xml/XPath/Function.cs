using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x02000201 RID: 513
	public class Function : AstNode
	{
		// Token: 0x06002D2B RID: 11563 RVA: 0x000D01D8 File Offset: 0x000CE3D8
		// Note: this type is marked as 'beforefieldinit'.
		static Function()
		{
			Il2CppClassPointerStore<Function>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "Function");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Function>.NativeClassPtr);
			Function.NativeFieldInfoPtr__functionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_functionType");
			Function.NativeFieldInfoPtr__argumentList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_argumentList");
			Function.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_name");
			Function.NativeFieldInfoPtr__prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "_prefix");
			Function.NativeFieldInfoPtr_ReturnTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Function>.NativeClassPtr, "ReturnTypes");
			Function.NativeMethodInfoPtr__ctor_Public_Void_FunctionType_List_1_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100669827);
			Function.NativeMethodInfoPtr__ctor_Public_Void_String_String_List_1_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100669828);
			Function.NativeMethodInfoPtr__ctor_Public_Void_FunctionType_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100669829);
			Function.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100669830);
			Function.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Function>.NativeClassPtr, 100669831);
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x000D02D0 File Offset: 0x000CE4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425572, XrefRangeEnd = 425580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Function(Function.FunctionType ftype, List<AstNode> argumentList)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Function>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ftype;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Function.NativeMethodInfoPtr__ctor_Public_Void_FunctionType_List_1_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x000D032C File Offset: 0x000CE52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425580, XrefRangeEnd = 425590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Function(string prefix, string name, List<AstNode> argumentList)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Function>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Function.NativeMethodInfoPtr__ctor_Public_Void_String_String_List_1_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x000D039C File Offset: 0x000CE59C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 425604, RefRangeEnd = 425606, XrefRangeStart = 425590, XrefRangeEnd = 425604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Function(Function.FunctionType ftype, AstNode arg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Function>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ftype;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Function.NativeMethodInfoPtr__ctor_Public_Void_FunctionType_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06002D2F RID: 11567 RVA: 0x000D03F8 File Offset: 0x000CE5F8
		public unsafe override AstNode.AstType Type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Function.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06002D30 RID: 11568 RVA: 0x000D0440 File Offset: 0x000CE640
		public unsafe override XPathResultType ReturnType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425606, XrefRangeEnd = 425610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Function.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00012A20 File Offset: 0x00010C20
		public Function(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x000D0488 File Offset: 0x000CE688
		// (set) Token: 0x06002D33 RID: 11571 RVA: 0x00012A29 File Offset: 0x00010C29
		public unsafe Function.FunctionType _functionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__functionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__functionType)) = value;
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06002D34 RID: 11572 RVA: 0x000D04B0 File Offset: 0x000CE6B0
		// (set) Token: 0x06002D35 RID: 11573 RVA: 0x00012A44 File Offset: 0x00010C44
		public unsafe List<AstNode> _argumentList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__argumentList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AstNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__argumentList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06002D36 RID: 11574 RVA: 0x000D04E0 File Offset: 0x000CE6E0
		// (set) Token: 0x06002D37 RID: 11575 RVA: 0x00012A63 File Offset: 0x00010C63
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x000D0508 File Offset: 0x000CE708
		// (set) Token: 0x06002D39 RID: 11577 RVA: 0x00012A82 File Offset: 0x00010C82
		public unsafe string _prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Function.NativeFieldInfoPtr__prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06002D3A RID: 11578 RVA: 0x000D0530 File Offset: 0x000CE730
		// (set) Token: 0x06002D3B RID: 11579 RVA: 0x00012AA1 File Offset: 0x00010CA1
		public unsafe static Il2CppStructArray<XPathResultType> ReturnTypes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Function.NativeFieldInfoPtr_ReturnTypes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<XPathResultType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Function.NativeFieldInfoPtr_ReturnTypes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400227A RID: 8826
		private static readonly IntPtr NativeFieldInfoPtr__functionType;

		// Token: 0x0400227B RID: 8827
		private static readonly IntPtr NativeFieldInfoPtr__argumentList;

		// Token: 0x0400227C RID: 8828
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x0400227D RID: 8829
		private static readonly IntPtr NativeFieldInfoPtr__prefix;

		// Token: 0x0400227E RID: 8830
		private static readonly IntPtr NativeFieldInfoPtr_ReturnTypes;

		// Token: 0x0400227F RID: 8831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FunctionType_List_1_AstNode_0;

		// Token: 0x04002280 RID: 8832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_List_1_AstNode_0;

		// Token: 0x04002281 RID: 8833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FunctionType_AstNode_0;

		// Token: 0x04002282 RID: 8834
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0;

		// Token: 0x04002283 RID: 8835
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0;

		// Token: 0x02000282 RID: 642
		public enum FunctionType
		{
			// Token: 0x040027FF RID: 10239
			FuncLast,
			// Token: 0x04002800 RID: 10240
			FuncPosition,
			// Token: 0x04002801 RID: 10241
			FuncCount,
			// Token: 0x04002802 RID: 10242
			FuncID,
			// Token: 0x04002803 RID: 10243
			FuncLocalName,
			// Token: 0x04002804 RID: 10244
			FuncNameSpaceUri,
			// Token: 0x04002805 RID: 10245
			FuncName,
			// Token: 0x04002806 RID: 10246
			FuncString,
			// Token: 0x04002807 RID: 10247
			FuncBoolean,
			// Token: 0x04002808 RID: 10248
			FuncNumber,
			// Token: 0x04002809 RID: 10249
			FuncTrue,
			// Token: 0x0400280A RID: 10250
			FuncFalse,
			// Token: 0x0400280B RID: 10251
			FuncNot,
			// Token: 0x0400280C RID: 10252
			FuncConcat,
			// Token: 0x0400280D RID: 10253
			FuncStartsWith,
			// Token: 0x0400280E RID: 10254
			FuncContains,
			// Token: 0x0400280F RID: 10255
			FuncSubstringBefore,
			// Token: 0x04002810 RID: 10256
			FuncSubstringAfter,
			// Token: 0x04002811 RID: 10257
			FuncSubstring,
			// Token: 0x04002812 RID: 10258
			FuncStringLength,
			// Token: 0x04002813 RID: 10259
			FuncNormalize,
			// Token: 0x04002814 RID: 10260
			FuncTranslate,
			// Token: 0x04002815 RID: 10261
			FuncLang,
			// Token: 0x04002816 RID: 10262
			FuncSum,
			// Token: 0x04002817 RID: 10263
			FuncFloor,
			// Token: 0x04002818 RID: 10264
			FuncCeiling,
			// Token: 0x04002819 RID: 10265
			FuncRound,
			// Token: 0x0400281A RID: 10266
			FuncUserDefined
		}
	}
}
