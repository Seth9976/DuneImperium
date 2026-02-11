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
	// Token: 0x0200008E RID: 142
	public class SquareCoordsTokenizer : DwdTypeTokenizer
	{
		// Token: 0x060004BC RID: 1212 RVA: 0x00012BF8 File Offset: 0x00010DF8
		// Note: this type is marked as 'beforefieldinit'.
		static SquareCoordsTokenizer()
		{
			Il2CppClassPointerStore<SquareCoordsTokenizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.json.tokenizers", "SquareCoordsTokenizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SquareCoordsTokenizer>.NativeClassPtr);
			SquareCoordsTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoordsTokenizer>.NativeClassPtr, 100663612);
			SquareCoordsTokenizer.NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoordsTokenizer>.NativeClassPtr, 100663613);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00012C50 File Offset: 0x00010E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195051, XrefRangeEnd = 1195067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SquareCoordsTokenizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SquareCoordsTokenizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoordsTokenizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00012C8C File Offset: 0x00010E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195067, XrefRangeEnd = 1195092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SquareCoordsTokenizer.NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00004E23 File Offset: 0x00003023
		public SquareCoordsTokenizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_Tokenize_Public_Virtual_Boolean_DwdModelWalker_ICycleDetector_List_1_Token_Object_0;
	}
}
