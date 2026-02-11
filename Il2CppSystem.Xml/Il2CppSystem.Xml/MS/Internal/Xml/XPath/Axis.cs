using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.XPath
{
	// Token: 0x020001FF RID: 511
	public class Axis : AstNode
	{
		// Token: 0x06002D05 RID: 11525 RVA: 0x000CF978 File Offset: 0x000CDB78
		// Note: this type is marked as 'beforefieldinit'.
		static Axis()
		{
			Il2CppClassPointerStore<Axis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "Axis");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Axis>.NativeClassPtr);
			Axis.NativeFieldInfoPtr__axisType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "_axisType");
			Axis.NativeFieldInfoPtr__input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "_input");
			Axis.NativeFieldInfoPtr__prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "_prefix");
			Axis.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "_name");
			Axis.NativeFieldInfoPtr__nodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "_nodeType");
			Axis.NativeFieldInfoPtr_abbrAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "abbrAxis");
			Axis.NativeFieldInfoPtr__urn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Axis>.NativeClassPtr, "_urn");
			Axis.NativeMethodInfoPtr__ctor_Public_Void_AxisType_AstNode_String_String_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100669811);
			Axis.NativeMethodInfoPtr__ctor_Public_Void_AxisType_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100669812);
			Axis.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100669813);
			Axis.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100669814);
			Axis.NativeMethodInfoPtr_get_Input_Public_get_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100669815);
			Axis.NativeMethodInfoPtr_set_Input_Public_set_Void_AstNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100669816);
			Axis.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100669817);
			Axis.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100669818);
			Axis.NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100669819);
			Axis.NativeMethodInfoPtr_get_TypeOfAxis_Public_get_AxisType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100669820);
			Axis.NativeMethodInfoPtr_get_AbbrAxis_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100669821);
			Axis.NativeMethodInfoPtr_get_Urn_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100669822);
			Axis.NativeMethodInfoPtr_set_Urn_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Axis>.NativeClassPtr, 100669823);
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x000CFB38 File Offset: 0x000CDD38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 425555, RefRangeEnd = 425558, XrefRangeStart = 425548, XrefRangeEnd = 425555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Axis(Axis.AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Axis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodetype;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr__ctor_Public_Void_AxisType_AstNode_String_String_XPathNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x000CFBC4 File Offset: 0x000CDDC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 425567, RefRangeEnd = 425572, XrefRangeStart = 425558, XrefRangeEnd = 425567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Axis(Axis.AxisType axisType, AstNode input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Axis>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr__ctor_Public_Void_AxisType_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x000CFC20 File Offset: 0x000CDE20
		public unsafe override AstNode.AstType Type
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Axis.NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x000CFC68 File Offset: 0x000CDE68
		public unsafe override XPathResultType ReturnType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 25008, RefRangeEnd = 25013, XrefRangeStart = 25008, XrefRangeEnd = 25013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Axis.NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x000CFCB0 File Offset: 0x000CDEB0
		// (set) Token: 0x06002D0B RID: 11531 RVA: 0x000CFCF0 File Offset: 0x000CDEF0
		public unsafe AstNode Input
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_Input_Public_get_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_set_Input_Public_set_Void_AstNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x000CFD34 File Offset: 0x000CDF34
		public unsafe string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x000CFD6C File Offset: 0x000CDF6C
		public unsafe string Name
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x000CFDA4 File Offset: 0x000CDFA4
		public unsafe XPathNodeType NodeType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06002D0F RID: 11535 RVA: 0x000CFDE0 File Offset: 0x000CDFE0
		public unsafe Axis.AxisType TypeOfAxis
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_TypeOfAxis_Public_get_AxisType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x000CFE1C File Offset: 0x000CE01C
		public unsafe bool AbbrAxis
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_AbbrAxis_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x000CFE58 File Offset: 0x000CE058
		// (set) Token: 0x06002D12 RID: 11538 RVA: 0x000CFE90 File Offset: 0x000CE090
		public unsafe string Urn
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_get_Urn_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Axis.NativeMethodInfoPtr_set_Urn_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00012903 File Offset: 0x00010B03
		public Axis(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x000CFED4 File Offset: 0x000CE0D4
		// (set) Token: 0x06002D15 RID: 11541 RVA: 0x0001290C File Offset: 0x00010B0C
		public unsafe Axis.AxisType _axisType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr__axisType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr__axisType)) = value;
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x000CFEFC File Offset: 0x000CE0FC
		// (set) Token: 0x06002D17 RID: 11543 RVA: 0x00012927 File Offset: 0x00010B27
		public unsafe AstNode _input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr__input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AstNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr__input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06002D18 RID: 11544 RVA: 0x000CFF2C File Offset: 0x000CE12C
		// (set) Token: 0x06002D19 RID: 11545 RVA: 0x00012946 File Offset: 0x00010B46
		public unsafe string _prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr__prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr__prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x000CFF54 File Offset: 0x000CE154
		// (set) Token: 0x06002D1B RID: 11547 RVA: 0x00012965 File Offset: 0x00010B65
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06002D1C RID: 11548 RVA: 0x000CFF7C File Offset: 0x000CE17C
		// (set) Token: 0x06002D1D RID: 11549 RVA: 0x00012984 File Offset: 0x00010B84
		public unsafe XPathNodeType _nodeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr__nodeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr__nodeType)) = value;
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06002D1E RID: 11550 RVA: 0x000CFFA4 File Offset: 0x000CE1A4
		// (set) Token: 0x06002D1F RID: 11551 RVA: 0x0001299F File Offset: 0x00010B9F
		public unsafe bool abbrAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_abbrAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr_abbrAxis)) = value;
			}
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06002D20 RID: 11552 RVA: 0x000CFFCC File Offset: 0x000CE1CC
		// (set) Token: 0x06002D21 RID: 11553 RVA: 0x000129BA File Offset: 0x00010BBA
		public unsafe string _urn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr__urn);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Axis.NativeFieldInfoPtr__urn), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002261 RID: 8801
		private static readonly IntPtr NativeFieldInfoPtr__axisType;

		// Token: 0x04002262 RID: 8802
		private static readonly IntPtr NativeFieldInfoPtr__input;

		// Token: 0x04002263 RID: 8803
		private static readonly IntPtr NativeFieldInfoPtr__prefix;

		// Token: 0x04002264 RID: 8804
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x04002265 RID: 8805
		private static readonly IntPtr NativeFieldInfoPtr__nodeType;

		// Token: 0x04002266 RID: 8806
		private static readonly IntPtr NativeFieldInfoPtr_abbrAxis;

		// Token: 0x04002267 RID: 8807
		private static readonly IntPtr NativeFieldInfoPtr__urn;

		// Token: 0x04002268 RID: 8808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AxisType_AstNode_String_String_XPathNodeType_0;

		// Token: 0x04002269 RID: 8809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AxisType_AstNode_0;

		// Token: 0x0400226A RID: 8810
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_get_AstType_0;

		// Token: 0x0400226B RID: 8811
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturnType_Public_Virtual_get_XPathResultType_0;

		// Token: 0x0400226C RID: 8812
		private static readonly IntPtr NativeMethodInfoPtr_get_Input_Public_get_AstNode_0;

		// Token: 0x0400226D RID: 8813
		private static readonly IntPtr NativeMethodInfoPtr_set_Input_Public_set_Void_AstNode_0;

		// Token: 0x0400226E RID: 8814
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x0400226F RID: 8815
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04002270 RID: 8816
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0;

		// Token: 0x04002271 RID: 8817
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeOfAxis_Public_get_AxisType_0;

		// Token: 0x04002272 RID: 8818
		private static readonly IntPtr NativeMethodInfoPtr_get_AbbrAxis_Public_get_Boolean_0;

		// Token: 0x04002273 RID: 8819
		private static readonly IntPtr NativeMethodInfoPtr_get_Urn_Public_get_String_0;

		// Token: 0x04002274 RID: 8820
		private static readonly IntPtr NativeMethodInfoPtr_set_Urn_Public_set_Void_String_0;

		// Token: 0x02000281 RID: 641
		public enum AxisType
		{
			// Token: 0x040027F0 RID: 10224
			Ancestor,
			// Token: 0x040027F1 RID: 10225
			AncestorOrSelf,
			// Token: 0x040027F2 RID: 10226
			Attribute,
			// Token: 0x040027F3 RID: 10227
			Child,
			// Token: 0x040027F4 RID: 10228
			Descendant,
			// Token: 0x040027F5 RID: 10229
			DescendantOrSelf,
			// Token: 0x040027F6 RID: 10230
			Following,
			// Token: 0x040027F7 RID: 10231
			FollowingSibling,
			// Token: 0x040027F8 RID: 10232
			Namespace,
			// Token: 0x040027F9 RID: 10233
			Parent,
			// Token: 0x040027FA RID: 10234
			Preceding,
			// Token: 0x040027FB RID: 10235
			PrecedingSibling,
			// Token: 0x040027FC RID: 10236
			Self,
			// Token: 0x040027FD RID: 10237
			None
		}
	}
}
