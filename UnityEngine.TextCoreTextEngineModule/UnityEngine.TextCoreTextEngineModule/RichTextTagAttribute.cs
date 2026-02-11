using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000025 RID: 37
	[StructLayout(2)]
	public struct RichTextTagAttribute
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x00012DE0 File Offset: 0x00010FE0
		// Note: this type is marked as 'beforefieldinit'.
		static RichTextTagAttribute()
		{
			Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "RichTextTagAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr);
			RichTextTagAttribute.NativeFieldInfoPtr_nameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "nameHashCode");
			RichTextTagAttribute.NativeFieldInfoPtr_valueHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueHashCode");
			RichTextTagAttribute.NativeFieldInfoPtr_valueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueType");
			RichTextTagAttribute.NativeFieldInfoPtr_valueStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueStartIndex");
			RichTextTagAttribute.NativeFieldInfoPtr_valueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueLength");
			RichTextTagAttribute.NativeFieldInfoPtr_unitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "unitType");
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00004B8C File Offset: 0x00002D8C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, ref this));
		}

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeFieldInfoPtr_nameHashCode;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeFieldInfoPtr_valueHashCode;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeFieldInfoPtr_valueType;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeFieldInfoPtr_valueStartIndex;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeFieldInfoPtr_valueLength;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeFieldInfoPtr_unitType;

		// Token: 0x0400033B RID: 827
		[FieldOffset(0)]
		public int nameHashCode;

		// Token: 0x0400033C RID: 828
		[FieldOffset(4)]
		public int valueHashCode;

		// Token: 0x0400033D RID: 829
		[FieldOffset(8)]
		public TagValueType valueType;

		// Token: 0x0400033E RID: 830
		[FieldOffset(12)]
		public int valueStartIndex;

		// Token: 0x0400033F RID: 831
		[FieldOffset(16)]
		public int valueLength;

		// Token: 0x04000340 RID: 832
		[FieldOffset(20)]
		public TagUnitType unitType;
	}
}
