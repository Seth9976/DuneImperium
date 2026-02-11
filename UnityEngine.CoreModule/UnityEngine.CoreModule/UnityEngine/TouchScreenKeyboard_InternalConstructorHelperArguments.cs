using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200016F RID: 367
	[StructLayout(2)]
	public struct TouchScreenKeyboard_InternalConstructorHelperArguments
	{
		// Token: 0x06001B89 RID: 7049 RVA: 0x0007DF6C File Offset: 0x0007C16C
		// Note: this type is marked as 'beforefieldinit'.
		static TouchScreenKeyboard_InternalConstructorHelperArguments()
		{
			Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TouchScreenKeyboard_InternalConstructorHelperArguments");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr);
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_keyboardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "keyboardType");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_autocorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "autocorrection");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "multiline");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "secure");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_alert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "alert");
			TouchScreenKeyboard_InternalConstructorHelperArguments.NativeFieldInfoPtr_characterLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, "characterLimit");
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0000AB2A File Offset: 0x00008D2A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TouchScreenKeyboard_InternalConstructorHelperArguments>.NativeClassPtr, ref this));
		}

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeFieldInfoPtr_keyboardType;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeFieldInfoPtr_autocorrection;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeFieldInfoPtr_multiline;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeFieldInfoPtr_secure;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeFieldInfoPtr_alert;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeFieldInfoPtr_characterLimit;

		// Token: 0x04001837 RID: 6199
		[FieldOffset(0)]
		public uint keyboardType;

		// Token: 0x04001838 RID: 6200
		[FieldOffset(4)]
		public uint autocorrection;

		// Token: 0x04001839 RID: 6201
		[FieldOffset(8)]
		public uint multiline;

		// Token: 0x0400183A RID: 6202
		[FieldOffset(12)]
		public uint secure;

		// Token: 0x0400183B RID: 6203
		[FieldOffset(16)]
		public uint alert;

		// Token: 0x0400183C RID: 6204
		[FieldOffset(20)]
		public int characterLimit;
	}
}
