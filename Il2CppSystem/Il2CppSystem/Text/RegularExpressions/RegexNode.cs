using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000084 RID: 132
	public sealed class RegexNode : Object
	{
		// Token: 0x06000978 RID: 2424 RVA: 0x0004057C File Offset: 0x0003E77C
		// Note: this type is marked as 'beforefieldinit'.
		static RegexNode()
		{
			Il2CppClassPointerStore<RegexNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexNode>.NativeClassPtr);
			RegexNode.NativeFieldInfoPtr_NType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "NType");
			RegexNode.NativeFieldInfoPtr_Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "Children");
			RegexNode.NativeFieldInfoPtr_Str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "Str");
			RegexNode.NativeFieldInfoPtr_Ch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "Ch");
			RegexNode.NativeFieldInfoPtr_M = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "M");
			RegexNode.NativeFieldInfoPtr_N = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "N");
			RegexNode.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "Options");
			RegexNode.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, "Next");
			RegexNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664757);
			RegexNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664758);
			RegexNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664759);
			RegexNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664760);
			RegexNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664761);
			RegexNode.NativeMethodInfoPtr_UseOptionR_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664762);
			RegexNode.NativeMethodInfoPtr_ReverseLeft_Public_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664763);
			RegexNode.NativeMethodInfoPtr_MakeRep_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664764);
			RegexNode.NativeMethodInfoPtr_Reduce_Private_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664765);
			RegexNode.NativeMethodInfoPtr_StripEnation_Private_RegexNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664766);
			RegexNode.NativeMethodInfoPtr_ReduceGroup_Private_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664767);
			RegexNode.NativeMethodInfoPtr_ReduceRep_Private_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664768);
			RegexNode.NativeMethodInfoPtr_ReduceSet_Private_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664769);
			RegexNode.NativeMethodInfoPtr_ReduceAlternation_Private_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664770);
			RegexNode.NativeMethodInfoPtr_ReduceConcatenation_Private_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664771);
			RegexNode.NativeMethodInfoPtr_MakeQuantifier_Public_RegexNode_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664772);
			RegexNode.NativeMethodInfoPtr_AddChild_Public_Void_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664773);
			RegexNode.NativeMethodInfoPtr_Child_Public_RegexNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664774);
			RegexNode.NativeMethodInfoPtr_ChildCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664775);
			RegexNode.NativeMethodInfoPtr_Type_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexNode>.NativeClassPtr, 100664776);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000407DC File Offset: 0x0003E9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440982, XrefRangeEnd = 440983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode(int type, RegexOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00040834 File Offset: 0x0003EA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440983, XrefRangeEnd = 440984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode(int type, RegexOptions options, char ch)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00040898 File Offset: 0x0003EA98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 440986, RefRangeEnd = 440988, XrefRangeStart = 440984, XrefRangeEnd = 440986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode(int type, RegexOptions options, string str)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00040900 File Offset: 0x0003EB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440988, XrefRangeEnd = 440989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode(int type, RegexOptions options, int m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00040964 File Offset: 0x0003EB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440989, XrefRangeEnd = 440990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode(int type, RegexOptions options, int m, int n)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x000409D8 File Offset: 0x0003EBD8
		[CallerCount(0)]
		public unsafe bool UseOptionR()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_UseOptionR_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00040A14 File Offset: 0x0003EC14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 440994, RefRangeEnd = 440996, XrefRangeStart = 440990, XrefRangeEnd = 440994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReverseLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReverseLeft_Public_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00040A54 File Offset: 0x0003EC54
		[CallerCount(0)]
		public unsafe void MakeRep(int type, int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_MakeRep_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00040AB0 File Offset: 0x0003ECB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441017, RefRangeEnd = 441018, XrefRangeStart = 440996, XrefRangeEnd = 441017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode Reduce()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_Reduce_Private_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00040AF0 File Offset: 0x0003ECF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441023, RefRangeEnd = 441025, XrefRangeStart = 441018, XrefRangeEnd = 441023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode StripEnation(int emptyType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref emptyType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_StripEnation_Private_RegexNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00040B3C File Offset: 0x0003ED3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441025, XrefRangeEnd = 441029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceGroup_Private_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00040B7C File Offset: 0x0003ED7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441041, RefRangeEnd = 441042, XrefRangeStart = 441029, XrefRangeEnd = 441041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceRep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceRep_Private_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00040BBC File Offset: 0x0003EDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441042, XrefRangeEnd = 441056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceSet_Private_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00040BFC File Offset: 0x0003EDFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441109, RefRangeEnd = 441110, XrefRangeStart = 441056, XrefRangeEnd = 441109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceAlternation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceAlternation_Private_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00040C3C File Offset: 0x0003EE3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 441160, RefRangeEnd = 441161, XrefRangeStart = 441110, XrefRangeEnd = 441160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ReduceConcatenation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ReduceConcatenation_Private_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00040C7C File Offset: 0x0003EE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441161, XrefRangeEnd = 441171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode MakeQuantifier(bool lazy, int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lazy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_MakeQuantifier_Public_RegexNode_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00040CE4 File Offset: 0x0003EEE4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 441187, RefRangeEnd = 441199, XrefRangeStart = 441171, XrefRangeEnd = 441187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChild(RegexNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_AddChild_Public_Void_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00040D28 File Offset: 0x0003EF28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 441203, RefRangeEnd = 441205, XrefRangeStart = 441199, XrefRangeEnd = 441203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode Child(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_Child_Public_RegexNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00040D74 File Offset: 0x0003EF74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 441206, RefRangeEnd = 441210, XrefRangeStart = 441205, XrefRangeEnd = 441206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ChildCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_ChildCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00040DB0 File Offset: 0x0003EFB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Type()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexNode.NativeMethodInfoPtr_Type_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0000531E File Offset: 0x0000351E
		public RegexNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00040DEC File Offset: 0x0003EFEC
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x00005327 File Offset: 0x00003527
		public unsafe int NType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_NType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_NType)) = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00040E14 File Offset: 0x0003F014
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x00005342 File Offset: 0x00003542
		public unsafe List<RegexNode> Children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_Children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RegexNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_Children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00040E44 File Offset: 0x0003F044
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00005361 File Offset: 0x00003561
		public unsafe string Str
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_Str);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_Str), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00040E6C File Offset: 0x0003F06C
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00005380 File Offset: 0x00003580
		public unsafe char Ch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_Ch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_Ch)) = value;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00040E94 File Offset: 0x0003F094
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x0000539B File Offset: 0x0000359B
		public unsafe int M
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_M);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_M)) = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x00040EBC File Offset: 0x0003F0BC
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x000053B6 File Offset: 0x000035B6
		public unsafe int N
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_N);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_N)) = value;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00040EE4 File Offset: 0x0003F0E4
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x000053D1 File Offset: 0x000035D1
		public unsafe RegexOptions Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_Options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_Options)) = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00040F0C File Offset: 0x0003F10C
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x000053EC File Offset: 0x000035EC
		public unsafe RegexNode Next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_Next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexNode.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeFieldInfoPtr_NType;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeFieldInfoPtr_Children;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeFieldInfoPtr_Str;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeFieldInfoPtr_Ch;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeFieldInfoPtr_M;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeFieldInfoPtr_N;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeFieldInfoPtr_Next;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_Char_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_String_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_Int32_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_RegexOptions_Int32_Int32_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionR_Public_Boolean_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_ReverseLeft_Public_RegexNode_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_MakeRep_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_Reduce_Private_RegexNode_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_StripEnation_Private_RegexNode_Int32_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_ReduceGroup_Private_RegexNode_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_ReduceRep_Private_RegexNode_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_ReduceSet_Private_RegexNode_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_ReduceAlternation_Private_RegexNode_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_ReduceConcatenation_Private_RegexNode_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_MakeQuantifier_Public_RegexNode_Boolean_Int32_Int32_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Public_Void_RegexNode_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_Child_Public_RegexNode_Int32_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr_ChildCount_Public_Int32_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_Type_Public_Int32_0;
	}
}
