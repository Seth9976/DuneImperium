using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Util
{
	// Token: 0x02000225 RID: 549
	public sealed class Parser : Object
	{
		// Token: 0x06002467 RID: 9319 RVA: 0x000CB2EC File Offset: 0x000C94EC
		// Note: this type is marked as 'beforefieldinit'.
		static Parser()
		{
			Il2CppClassPointerStore<Parser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Util", "Parser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parser>.NativeClassPtr);
			Parser.NativeFieldInfoPtr__doc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "_doc");
			Parser.NativeFieldInfoPtr__t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parser>.NativeClassPtr, "_t");
			Parser.NativeMethodInfoPtr_GetTopElement_Internal_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100669436);
			Parser.NativeMethodInfoPtr_GetRequiredSizes_Private_Void_TokenizerStream_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100669437);
			Parser.NativeMethodInfoPtr_DetermineFormat_Private_Int32_TokenizerStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100669438);
			Parser.NativeMethodInfoPtr_ParseContents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100669439);
			Parser.NativeMethodInfoPtr__ctor_Private_Void_Tokenizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100669440);
			Parser.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parser>.NativeClassPtr, 100669441);
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x000CB3BC File Offset: 0x000C95BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1370217, RefRangeEnd = 1370219, XrefRangeStart = 1370216, XrefRangeEnd = 1370217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecurityElement GetTopElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_GetTopElement_Internal_SecurityElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x000CB3FC File Offset: 0x000C95FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1370262, RefRangeEnd = 1370263, XrefRangeStart = 1370219, XrefRangeEnd = 1370262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRequiredSizes(TokenizerStream stream, ref int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_GetRequiredSizes_Private_Void_TokenizerStream_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x000CB44C File Offset: 0x000C964C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1370286, RefRangeEnd = 1370287, XrefRangeStart = 1370263, XrefRangeEnd = 1370286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DetermineFormat(TokenizerStream stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_DetermineFormat_Private_Int32_TokenizerStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x000CB49C File Offset: 0x000C969C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1370355, RefRangeEnd = 1370356, XrefRangeStart = 1370287, XrefRangeEnd = 1370355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr_ParseContents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x000CB4D0 File Offset: 0x000C96D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1370363, RefRangeEnd = 1370364, XrefRangeStart = 1370356, XrefRangeEnd = 1370363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Parser(Tokenizer t)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr__ctor_Private_Void_Tokenizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x000CB51C File Offset: 0x000C971C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1370376, RefRangeEnd = 1370378, XrefRangeStart = 1370364, XrefRangeEnd = 1370376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Parser(string input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parser.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		public Parser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x000CB568 File Offset: 0x000C9768
		// (set) Token: 0x06002470 RID: 9328 RVA: 0x0000B9C1 File Offset: 0x00009BC1
		public unsafe SecurityDocument _doc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr__doc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SecurityDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr__doc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x000CB598 File Offset: 0x000C9798
		// (set) Token: 0x06002472 RID: 9330 RVA: 0x0000B9E0 File Offset: 0x00009BE0
		public unsafe Tokenizer _t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr__t);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tokenizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parser.NativeFieldInfoPtr__t), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeFieldInfoPtr__doc;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeFieldInfoPtr__t;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeMethodInfoPtr_GetTopElement_Internal_SecurityElement_0;

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredSizes_Private_Void_TokenizerStream_byref_Int32_0;

		// Token: 0x04001FD1 RID: 8145
		private static readonly IntPtr NativeMethodInfoPtr_DetermineFormat_Private_Int32_TokenizerStream_0;

		// Token: 0x04001FD2 RID: 8146
		private static readonly IntPtr NativeMethodInfoPtr_ParseContents_Private_Void_0;

		// Token: 0x04001FD3 RID: 8147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Tokenizer_0;

		// Token: 0x04001FD4 RID: 8148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;
	}
}
