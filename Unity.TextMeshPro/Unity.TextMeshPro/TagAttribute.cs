using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x0200001D RID: 29
	[StructLayout(2)]
	public struct TagAttribute
	{
		// Token: 0x060002F0 RID: 752 RVA: 0x00013588 File Offset: 0x00011788
		// Note: this type is marked as 'beforefieldinit'.
		static TagAttribute()
		{
			Il2CppClassPointerStore<TagAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TagAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr);
			TagAttribute.NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, "startIndex");
			TagAttribute.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, "length");
			TagAttribute.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, "hashCode");
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00003744 File Offset: 0x00001944
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, ref this));
		}

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr_startIndex;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x0400021D RID: 541
		[FieldOffset(0)]
		public int startIndex;

		// Token: 0x0400021E RID: 542
		[FieldOffset(4)]
		public int length;

		// Token: 0x0400021F RID: 543
		[FieldOffset(8)]
		public int hashCode;
	}
}
