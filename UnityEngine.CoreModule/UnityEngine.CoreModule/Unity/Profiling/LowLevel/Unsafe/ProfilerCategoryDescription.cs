using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Unity.Profiling.LowLevel.Unsafe
{
	// Token: 0x02000024 RID: 36
	[StructLayout(2)]
	public struct ProfilerCategoryDescription
	{
		// Token: 0x06000125 RID: 293 RVA: 0x000197D4 File Offset: 0x000179D4
		// Note: this type is marked as 'beforefieldinit'.
		static ProfilerCategoryDescription()
		{
			Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", "ProfilerCategoryDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr);
			ProfilerCategoryDescription.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "Id");
			ProfilerCategoryDescription.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "Flags");
			ProfilerCategoryDescription.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "Color");
			ProfilerCategoryDescription.NativeFieldInfoPtr_reserved0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "reserved0");
			ProfilerCategoryDescription.NativeFieldInfoPtr_NameUtf8Len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "NameUtf8Len");
			ProfilerCategoryDescription.NativeFieldInfoPtr_NameUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, "NameUtf8");
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000028B9 File Offset: 0x00000AB9
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerCategoryDescription>.NativeClassPtr, ref this));
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000127 RID: 295 RVA: 0x000028CB File Offset: 0x00000ACB
		public string Name
		{
			get
			{
				return ProfilerUnsafeUtility.Utf8ToString(this.NameUtf8, this.NameUtf8Len);
			}
		}

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_Flags;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_reserved0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_NameUtf8Len;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_NameUtf8;

		// Token: 0x040000FB RID: 251
		[FieldOffset(0)]
		public readonly ushort Id;

		// Token: 0x040000FC RID: 252
		[FieldOffset(2)]
		public readonly ushort Flags;

		// Token: 0x040000FD RID: 253
		[FieldOffset(4)]
		public readonly global::UnityEngine.Color32 Color;

		// Token: 0x040000FE RID: 254
		[FieldOffset(8)]
		public readonly int reserved0;

		// Token: 0x040000FF RID: 255
		[FieldOffset(12)]
		public readonly int NameUtf8Len;

		// Token: 0x04000100 RID: 256
		[FieldOffset(16)]
		public readonly IntPtr NameUtf8;
	}
}
