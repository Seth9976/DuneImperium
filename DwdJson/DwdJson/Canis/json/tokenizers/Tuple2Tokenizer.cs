using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using JsonFx.Serialization;
using JsonFx.Serialization.GraphCycles;

namespace Canis.json.tokenizers
{
	// Token: 0x0200001B RID: 27
	public class Tuple2Tokenizer : DwdTypeTokenizer
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00005DB0 File Offset: 0x00003FB0
		// Note: this type is marked as 'beforefieldinit'.
		static Tuple2Tokenizer()
		{
			Il2CppClassPointerStore<Tuple2Tokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json.tokenizers", "Tuple2Tokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tuple2Tokenizer>.NativeClassPtr);
			Tuple2Tokenizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple2Tokenizer>.NativeClassPtr, 100663408);
			Tuple2Tokenizer.NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple2Tokenizer>.NativeClassPtr, 100663409);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005E08 File Offset: 0x00004008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249549, XrefRangeEnd = 1249566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tuple2Tokenizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tuple2Tokenizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple2Tokenizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00005E44 File Offset: 0x00004044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249566, XrefRangeEnd = 1249590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Tokenize(DwdModelWalker walker, ICycleDetector detector, List<Token> tokens, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(walker);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(detector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tuple2Tokenizer.NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000025D4 File Offset: 0x000007D4
		public Tuple2Tokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0;
	}
}
