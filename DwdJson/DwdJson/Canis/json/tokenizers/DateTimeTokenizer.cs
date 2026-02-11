using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using JsonFx.Serialization;
using JsonFx.Serialization.GraphCycles;

namespace Canis.json.tokenizers
{
	// Token: 0x02000019 RID: 25
	public sealed class DateTimeTokenizer : DwdTypeTokenizer
	{
		// Token: 0x060000DF RID: 223 RVA: 0x00005B20 File Offset: 0x00003D20
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeTokenizer()
		{
			Il2CppClassPointerStore<DateTimeTokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json.tokenizers", "DateTimeTokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeTokenizer>.NativeClassPtr);
			DateTimeTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeTokenizer>.NativeClassPtr, 100663404);
			DateTimeTokenizer.NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeTokenizer>.NativeClassPtr, 100663405);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00005B78 File Offset: 0x00003D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249504, XrefRangeEnd = 1249521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTimeTokenizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeTokenizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005BB4 File Offset: 0x00003DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249521, XrefRangeEnd = 1249549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeTokenizer.NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000025A3 File Offset: 0x000007A3
		public DateTimeTokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0;
	}
}
