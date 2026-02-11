using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000032 RID: 50
	public sealed class LogMessage : ValueType
	{
		// Token: 0x0600039C RID: 924 RVA: 0x00014D50 File Offset: 0x00012F50
		// Note: this type is marked as 'beforefieldinit'.
		static LogMessage()
		{
			Il2CppClassPointerStore<LogMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "LogMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogMessage>.NativeClassPtr);
			LogMessage.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogMessage>.NativeClassPtr, "Text");
			LogMessage.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogMessage>.NativeClassPtr, "Type");
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00003537 File Offset: 0x00001737
		public LogMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00003540 File Offset: 0x00001740
		public LogMessage()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogMessage>.NativeClassPtr))
		{
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00014DA8 File Offset: 0x00012FA8
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x00003552 File Offset: 0x00001752
		public unsafe string Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogMessage.NativeFieldInfoPtr_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogMessage.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00014DD0 File Offset: 0x00012FD0
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x00003571 File Offset: 0x00001771
		public unsafe LogMessageType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogMessage.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogMessage.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_Type;
	}
}
