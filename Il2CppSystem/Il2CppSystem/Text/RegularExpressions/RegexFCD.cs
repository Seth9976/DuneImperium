using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000080 RID: 128
	public sealed class RegexFCD : ValueType
	{
		// Token: 0x06000907 RID: 2311 RVA: 0x0003E834 File Offset: 0x0003CA34
		// Note: this type is marked as 'beforefieldinit'.
		static RegexFCD()
		{
			Il2CppClassPointerStore<RegexFCD>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexFCD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr);
			RegexFCD.NativeFieldInfoPtr__fcStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_fcStack");
			RegexFCD.NativeFieldInfoPtr__intStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_intStack");
			RegexFCD.NativeFieldInfoPtr__skipAllChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_skipAllChildren");
			RegexFCD.NativeFieldInfoPtr__skipchild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_skipchild");
			RegexFCD.NativeFieldInfoPtr__failed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_failed");
			RegexFCD.NativeMethodInfoPtr__ctor_Private_Void_Span_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664687);
			RegexFCD.NativeMethodInfoPtr_FirstChars_Public_Static_Nullable_1_RegexPrefix_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664688);
			RegexFCD.NativeMethodInfoPtr_Prefix_Public_Static_RegexPrefix_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664689);
			RegexFCD.NativeMethodInfoPtr_Anchors_Public_Static_Int32_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664690);
			RegexFCD.NativeMethodInfoPtr_AnchorFromType_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664691);
			RegexFCD.NativeMethodInfoPtr_PushInt_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664692);
			RegexFCD.NativeMethodInfoPtr_IntIsEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664693);
			RegexFCD.NativeMethodInfoPtr_PopInt_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664694);
			RegexFCD.NativeMethodInfoPtr_PushFC_Private_Void_RegexFC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664695);
			RegexFCD.NativeMethodInfoPtr_FCIsEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664696);
			RegexFCD.NativeMethodInfoPtr_PopFC_Private_RegexFC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664697);
			RegexFCD.NativeMethodInfoPtr_TopFC_Private_RegexFC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664698);
			RegexFCD.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664699);
			RegexFCD.NativeMethodInfoPtr_RegexFCFromRegexTree_Private_RegexFC_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664700);
			RegexFCD.NativeMethodInfoPtr_SkipChild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664701);
			RegexFCD.NativeMethodInfoPtr_CalculateFC_Private_Void_Int32_RegexNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664702);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0003EA08 File Offset: 0x0003CC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440473, XrefRangeEnd = 440482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFCD(Span<int> intStack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(intStack));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr__ctor_Private_Void_Span_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0003EA60 File Offset: 0x0003CC60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440518, RefRangeEnd = 440519, XrefRangeStart = 440482, XrefRangeEnd = 440518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<RegexPrefix> FirstChars(RegexTree t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_FirstChars_Public_Static_Nullable_1_RegexPrefix_RegexTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<RegexPrefix>(intPtr);
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0003EA9C File Offset: 0x0003CC9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440531, RefRangeEnd = 440532, XrefRangeStart = 440519, XrefRangeEnd = 440531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexPrefix Prefix(RegexTree tree)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_Prefix_Public_Static_RegexPrefix_RegexTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RegexPrefix(intPtr);
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0003EAD8 File Offset: 0x0003CCD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440544, RefRangeEnd = 440545, XrefRangeStart = 440532, XrefRangeEnd = 440544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Anchors(RegexTree tree)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_Anchors_Public_Static_Int32_RegexTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0003EB1C File Offset: 0x0003CD1C
		[CallerCount(0)]
		public unsafe static int AnchorFromType(int type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_AnchorFromType_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0003EB5C File Offset: 0x0003CD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440545, XrefRangeEnd = 440550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushInt(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_PushInt_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0003EBA0 File Offset: 0x0003CDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440550, XrefRangeEnd = 440551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IntIsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_IntIsEmpty_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0003EBE4 File Offset: 0x0003CDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440551, XrefRangeEnd = 440552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PopInt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_PopInt_Private_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0003EC28 File Offset: 0x0003CE28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440558, RefRangeEnd = 440559, XrefRangeStart = 440552, XrefRangeEnd = 440558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushFC(RegexFC fc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_PushFC_Private_Void_RegexFC_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0003EC70 File Offset: 0x0003CE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440559, XrefRangeEnd = 440560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FCIsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_FCIsEmpty_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0003ECB4 File Offset: 0x0003CEB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440568, RefRangeEnd = 440569, XrefRangeStart = 440560, XrefRangeEnd = 440568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC PopFC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_PopFC_Private_RegexFC_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexFC>(intPtr3) : null;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0003ECF8 File Offset: 0x0003CEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440569, XrefRangeEnd = 440574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC TopFC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_TopFC_Private_RegexFC_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexFC>(intPtr3) : null;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0003ED3C File Offset: 0x0003CF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440574, XrefRangeEnd = 440577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0003ED74 File Offset: 0x0003CF74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440596, RefRangeEnd = 440597, XrefRangeStart = 440577, XrefRangeEnd = 440596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexFC RegexFCFromRegexTree(RegexTree tree)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_RegexFCFromRegexTree_Private_RegexFC_RegexTree_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexFC>(intPtr3) : null;
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0003EDCC File Offset: 0x0003CFCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 440597, RefRangeEnd = 440599, XrefRangeStart = 440597, XrefRangeEnd = 440597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_SkipChild_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0003EE04 File Offset: 0x0003D004
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 440647, RefRangeEnd = 440650, XrefRangeStart = 440599, XrefRangeEnd = 440647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateFC(int NodeType, RegexNode node, int CurIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref NodeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref CurIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexFCD.NativeMethodInfoPtr_CalculateFC_Private_Void_Int32_RegexNode_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x000050F2 File Offset: 0x000032F2
		public RegexFCD(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x000050FB File Offset: 0x000032FB
		public RegexFCD()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr))
		{
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x0003EE68 File Offset: 0x0003D068
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x0000510D File Offset: 0x0000330D
		public unsafe List<RegexFC> _fcStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__fcStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RegexFC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__fcStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0003EE98 File Offset: 0x0003D098
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x0000512C File Offset: 0x0000332C
		public Il2CppSystem.Collections.Generic.ValueListBuilder<int> _intStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__intStack);
				return new Il2CppSystem.Collections.Generic.ValueListBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Collections.Generic.ValueListBuilder<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__intStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Collections.Generic.ValueListBuilder<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x0003EEC8 File Offset: 0x0003D0C8
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x0000515A File Offset: 0x0000335A
		public unsafe bool _skipAllChildren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__skipAllChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__skipAllChildren)) = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x0003EEF0 File Offset: 0x0003D0F0
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x00005175 File Offset: 0x00003375
		public unsafe bool _skipchild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__skipchild);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__skipchild)) = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0003EF18 File Offset: 0x0003D118
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00005190 File Offset: 0x00003390
		public unsafe bool _failed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__failed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexFCD.NativeFieldInfoPtr__failed)) = value;
			}
		}

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeFieldInfoPtr__fcStack;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeFieldInfoPtr__intStack;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeFieldInfoPtr__skipAllChildren;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeFieldInfoPtr__skipchild;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeFieldInfoPtr__failed;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Span_1_Int32_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_FirstChars_Public_Static_Nullable_1_RegexPrefix_RegexTree_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_Prefix_Public_Static_RegexPrefix_RegexTree_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_Anchors_Public_Static_Int32_RegexTree_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_AnchorFromType_Private_Static_Int32_Int32_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_PushInt_Private_Void_Int32_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_IntIsEmpty_Private_Boolean_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_PopInt_Private_Int32_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_PushFC_Private_Void_RegexFC_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_FCIsEmpty_Private_Boolean_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_PopFC_Private_RegexFC_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_TopFC_Private_RegexFC_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_RegexFCFromRegexTree_Private_RegexFC_RegexTree_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_SkipChild_Private_Void_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFC_Private_Void_Int32_RegexNode_Int32_0;
	}
}
