using System;
using Canis.json;
using Canis.json.tokenizers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using JsonFx.Serialization;
using JsonFx.Serialization.GraphCycles;

namespace Canis.attributes
{
	// Token: 0x02000011 RID: 17
	public sealed class IAttributeTokenizer : DwdTypeTokenizer
	{
		// Token: 0x0600014B RID: 331 RVA: 0x00006A68 File Offset: 0x00004C68
		// Note: this type is marked as 'beforefieldinit'.
		static IAttributeTokenizer()
		{
			Il2CppClassPointerStore<IAttributeTokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "IAttributeTokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAttributeTokenizer>.NativeClassPtr);
			IAttributeTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributeTokenizer>.NativeClassPtr, 100663354);
			IAttributeTokenizer.NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAttributeTokenizer>.NativeClassPtr, 100663355);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006AC0 File Offset: 0x00004CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215669, XrefRangeEnd = 1215713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAttributeTokenizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IAttributeTokenizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAttributeTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00006AFC File Offset: 0x00004CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215713, XrefRangeEnd = 1215767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IAttributeTokenizer.NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002A3E File Offset: 0x00000C3E
		public IAttributeTokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0;
	}
}
