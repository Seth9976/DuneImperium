using System;
using Canis.json;
using Canis.json.tokenizers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using JsonFx.Serialization;
using JsonFx.Serialization.GraphCycles;

namespace Networking.selection.json.tokenizers
{
	// Token: 0x0200008C RID: 140
	public class HexCoordsTokenizer : DwdTypeTokenizer
	{
		// Token: 0x060004B4 RID: 1204 RVA: 0x000129B0 File Offset: 0x00010BB0
		// Note: this type is marked as 'beforefieldinit'.
		static HexCoordsTokenizer()
		{
			Il2CppClassPointerStore<HexCoordsTokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.json.tokenizers", "HexCoordsTokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HexCoordsTokenizer>.NativeClassPtr);
			HexCoordsTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsTokenizer>.NativeClassPtr, 100663608);
			HexCoordsTokenizer.NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HexCoordsTokenizer>.NativeClassPtr, 100663609);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00012A08 File Offset: 0x00010C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194966, XrefRangeEnd = 1194982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HexCoordsTokenizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HexCoordsTokenizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HexCoordsTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00012A44 File Offset: 0x00010C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194982, XrefRangeEnd = 1195007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HexCoordsTokenizer.NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00004E11 File Offset: 0x00003011
		public HexCoordsTokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0;
	}
}
