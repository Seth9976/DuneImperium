using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000028 RID: 40
	[StructLayout(2)]
	public struct CharacterSubstitution
	{
		// Token: 0x0600044F RID: 1103 RVA: 0x0001325C File Offset: 0x0001145C
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterSubstitution()
		{
			Il2CppClassPointerStore<CharacterSubstitution>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "CharacterSubstitution");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSubstitution>.NativeClassPtr);
			CharacterSubstitution.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSubstitution>.NativeClassPtr, "index");
			CharacterSubstitution.NativeFieldInfoPtr_unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSubstitution>.NativeClassPtr, "unicode");
			CharacterSubstitution.NativeMethodInfoPtr__ctor_Public_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSubstitution>.NativeClassPtr, 100663583);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000132C8 File Offset: 0x000114C8
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterSubstitution(int index, uint unicode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unicode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterSubstitution.NativeMethodInfoPtr__ctor_Public_Void_Int32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00004C05 File Offset: 0x00002E05
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterSubstitution>.NativeClassPtr, ref this));
		}

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeFieldInfoPtr_unicode;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_UInt32_0;

		// Token: 0x04000355 RID: 853
		[FieldOffset(0)]
		public int index;

		// Token: 0x04000356 RID: 854
		[FieldOffset(4)]
		public uint unicode;
	}
}
