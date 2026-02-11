using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200002F RID: 47
	[StructLayout(2)]
	public struct WordInfo
	{
		// Token: 0x06000561 RID: 1377 RVA: 0x00017368 File Offset: 0x00015568
		// Note: this type is marked as 'beforefieldinit'.
		static WordInfo()
		{
			Il2CppClassPointerStore<WordInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "WordInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WordInfo>.NativeClassPtr);
			WordInfo.NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordInfo>.NativeClassPtr, "firstCharacterIndex");
			WordInfo.NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordInfo>.NativeClassPtr, "lastCharacterIndex");
			WordInfo.NativeFieldInfoPtr_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordInfo>.NativeClassPtr, "characterCount");
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000055DA File Offset: 0x000037DA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeFieldInfoPtr_firstCharacterIndex;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeFieldInfoPtr_lastCharacterIndex;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr_characterCount;

		// Token: 0x04000418 RID: 1048
		[FieldOffset(0)]
		public int firstCharacterIndex;

		// Token: 0x04000419 RID: 1049
		[FieldOffset(4)]
		public int lastCharacterIndex;

		// Token: 0x0400041A RID: 1050
		[FieldOffset(8)]
		public int characterCount;
	}
}
