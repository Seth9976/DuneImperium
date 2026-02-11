using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200008C RID: 140
	public sealed class RegexWriter : ValueType
	{
		// Token: 0x06000A8D RID: 2701 RVA: 0x000445C4 File Offset: 0x000427C4
		// Note: this type is marked as 'beforefieldinit'.
		static RegexWriter()
		{
			Il2CppClassPointerStore<RegexWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr);
			RegexWriter.NativeFieldInfoPtr__emitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_emitted");
			RegexWriter.NativeFieldInfoPtr__intStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_intStack");
			RegexWriter.NativeFieldInfoPtr__stringHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_stringHash");
			RegexWriter.NativeFieldInfoPtr__stringTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_stringTable");
			RegexWriter.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_caps");
			RegexWriter.NativeFieldInfoPtr__trackCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_trackCount");
			RegexWriter.NativeMethodInfoPtr__ctor_Private_Void_Span_1_Int32_Span_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664891);
			RegexWriter.NativeMethodInfoPtr_Write_Public_Static_RegexCode_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664892);
			RegexWriter.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664893);
			RegexWriter.NativeMethodInfoPtr_RegexCodeFromRegexTree_Public_RegexCode_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664894);
			RegexWriter.NativeMethodInfoPtr_PatchJump_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664895);
			RegexWriter.NativeMethodInfoPtr_Emit_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664896);
			RegexWriter.NativeMethodInfoPtr_Emit_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664897);
			RegexWriter.NativeMethodInfoPtr_Emit_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664898);
			RegexWriter.NativeMethodInfoPtr_StringCode_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664899);
			RegexWriter.NativeMethodInfoPtr_MapCapnum_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664900);
			RegexWriter.NativeMethodInfoPtr_EmitFragment_Private_Void_Int32_RegexNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664901);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00044748 File Offset: 0x00042948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442391, XrefRangeEnd = 442408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexWriter(Span<int> emittedSpan, Span<int> intStackSpan)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(emittedSpan));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(intStackSpan));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr__ctor_Private_Void_Span_1_Int32_Span_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x000447B4 File Offset: 0x000429B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442408, XrefRangeEnd = 442433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexCode Write(RegexTree tree)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_Write_Public_Static_RegexCode_RegexTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr3) : null;
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x000447F8 File Offset: 0x000429F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442433, XrefRangeEnd = 442438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00044830 File Offset: 0x00042A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442503, RefRangeEnd = 442504, XrefRangeStart = 442438, XrefRangeEnd = 442503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCode RegexCodeFromRegexTree(RegexTree tree)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_RegexCodeFromRegexTree_Public_RegexCode_RegexTree_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr3) : null;
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00044888 File Offset: 0x00042A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442507, RefRangeEnd = 442508, XrefRangeStart = 442504, XrefRangeEnd = 442507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PatchJump(int offset, int jumpDest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpDest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_PatchJump_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000448DC File Offset: 0x00042ADC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 442512, RefRangeEnd = 442522, XrefRangeStart = 442508, XrefRangeEnd = 442512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_Emit_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00044920 File Offset: 0x00042B20
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 442528, RefRangeEnd = 442537, XrefRangeStart = 442522, XrefRangeEnd = 442528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int op, int opd1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opd1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_Emit_Private_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00044974 File Offset: 0x00042B74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442545, RefRangeEnd = 442549, XrefRangeStart = 442537, XrefRangeEnd = 442545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int op, int opd1, int opd2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opd1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opd2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_Emit_Private_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x000449D4 File Offset: 0x00042BD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 442561, RefRangeEnd = 442564, XrefRangeStart = 442549, XrefRangeEnd = 442561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int StringCode(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_StringCode_Private_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00044A28 File Offset: 0x00042C28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 442565, RefRangeEnd = 442567, XrefRangeStart = 442564, XrefRangeEnd = 442565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MapCapnum(int capnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_MapCapnum_Private_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00044A78 File Offset: 0x00042C78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 442628, RefRangeEnd = 442631, XrefRangeStart = 442567, XrefRangeEnd = 442628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitFragment(int nodetype, RegexNode node, int curIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodetype;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref curIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_EmitFragment_Private_Void_Int32_RegexNode_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00005A67 File Offset: 0x00003C67
		public RegexWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00005A70 File Offset: 0x00003C70
		public RegexWriter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr))
		{
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00044ADC File Offset: 0x00042CDC
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00005A82 File Offset: 0x00003C82
		public Il2CppSystem.Collections.Generic.ValueListBuilder<int> _emitted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__emitted);
				return new Il2CppSystem.Collections.Generic.ValueListBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Collections.Generic.ValueListBuilder<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__emitted), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Collections.Generic.ValueListBuilder<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00044B0C File Offset: 0x00042D0C
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00005AB0 File Offset: 0x00003CB0
		public Il2CppSystem.Collections.Generic.ValueListBuilder<int> _intStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__intStack);
				return new Il2CppSystem.Collections.Generic.ValueListBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Collections.Generic.ValueListBuilder<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__intStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Collections.Generic.ValueListBuilder<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00044B3C File Offset: 0x00042D3C
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00005ADE File Offset: 0x00003CDE
		public unsafe Dictionary<string, int> _stringHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__stringHash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__stringHash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00044B6C File Offset: 0x00042D6C
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00005AFD File Offset: 0x00003CFD
		public unsafe List<string> _stringTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__stringTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__stringTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00044B9C File Offset: 0x00042D9C
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00005B1C File Offset: 0x00003D1C
		public unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00044BCC File Offset: 0x00042DCC
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00005B3B File Offset: 0x00003D3B
		public unsafe int _trackCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__trackCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__trackCount)) = value;
			}
		}

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeFieldInfoPtr__emitted;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeFieldInfoPtr__intStack;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeFieldInfoPtr__stringHash;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeFieldInfoPtr__stringTable;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeFieldInfoPtr__trackCount;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Span_1_Int32_Span_1_Int32_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Static_RegexCode_RegexTree_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr_RegexCodeFromRegexTree_Public_RegexCode_RegexTree_0;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeMethodInfoPtr_PatchJump_Private_Void_Int32_Int32_0;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Private_Void_Int32_0;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Private_Void_Int32_Int32_0;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeMethodInfoPtr_StringCode_Private_Int32_String_0;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeMethodInfoPtr_MapCapnum_Private_Int32_Int32_0;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeMethodInfoPtr_EmitFragment_Private_Void_Int32_RegexNode_Int32_0;
	}
}
