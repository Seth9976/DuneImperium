using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000026 RID: 38
	[StructLayout(2)]
	public struct TextProcessingElement
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x00012E88 File Offset: 0x00011088
		// Note: this type is marked as 'beforefieldinit'.
		static TextProcessingElement()
		{
			Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextProcessingElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr);
			TextProcessingElement.NativeFieldInfoPtr_elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, "elementType");
			TextProcessingElement.NativeFieldInfoPtr_unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, "unicode");
			TextProcessingElement.NativeFieldInfoPtr_stringIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, "stringIndex");
			TextProcessingElement.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, "length");
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00004B9E File Offset: 0x00002D9E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, ref this));
		}

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeFieldInfoPtr_elementType;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeFieldInfoPtr_unicode;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeFieldInfoPtr_stringIndex;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04000345 RID: 837
		[FieldOffset(0)]
		public TextProcessingElementType elementType;

		// Token: 0x04000346 RID: 838
		[FieldOffset(4)]
		public uint unicode;

		// Token: 0x04000347 RID: 839
		[FieldOffset(8)]
		public int stringIndex;

		// Token: 0x04000348 RID: 840
		[FieldOffset(12)]
		public int length;
	}
}
