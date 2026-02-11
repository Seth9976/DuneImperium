using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000002 RID: 2
	[Serializable]
	public class Character : TextElement
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000065F0 File Offset: 0x000047F0
		// Note: this type is marked as 'beforefieldinit'.
		static Character()
		{
			Il2CppClassPointerStore<Character>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "Character");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Character>.NativeClassPtr);
			Character.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100663297);
			Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_FontAsset_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100663298);
			Character.NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100663299);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000665C File Offset: 0x0000485C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097833, XrefRangeEnd = 1097834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Character()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Character>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00006698 File Offset: 0x00004898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1097834, XrefRangeEnd = 1097838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Character(uint unicode, FontAsset fontAsset, Glyph glyph)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Character>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fontAsset);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(glyph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr__ctor_Public_Void_UInt32_FontAsset_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00006704 File Offset: 0x00004904
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1097841, RefRangeEnd = 1097843, XrefRangeStart = 1097838, XrefRangeEnd = 1097841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Character(uint unicode, uint glyphIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Character>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unicode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		public Character(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_FontAsset_Glyph_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt32_UInt32_0;
	}
}
