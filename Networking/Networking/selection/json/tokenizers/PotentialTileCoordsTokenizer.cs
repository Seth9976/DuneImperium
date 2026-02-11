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
	// Token: 0x0200008D RID: 141
	public class PotentialTileCoordsTokenizer : DwdTypeTokenizer
	{
		// Token: 0x060004B8 RID: 1208 RVA: 0x00012AD4 File Offset: 0x00010CD4
		// Note: this type is marked as 'beforefieldinit'.
		static PotentialTileCoordsTokenizer()
		{
			Il2CppClassPointerStore<PotentialTileCoordsTokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.json.tokenizers", "PotentialTileCoordsTokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotentialTileCoordsTokenizer>.NativeClassPtr);
			PotentialTileCoordsTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotentialTileCoordsTokenizer>.NativeClassPtr, 100663610);
			PotentialTileCoordsTokenizer.NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotentialTileCoordsTokenizer>.NativeClassPtr, 100663611);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00012B2C File Offset: 0x00010D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195007, XrefRangeEnd = 1195023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotentialTileCoordsTokenizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotentialTileCoordsTokenizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotentialTileCoordsTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00012B68 File Offset: 0x00010D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195023, XrefRangeEnd = 1195051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotentialTileCoordsTokenizer.NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00004E1A File Offset: 0x0000301A
		public PotentialTileCoordsTokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0;
	}
}
