using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000141 RID: 321
	public static class CompatibilitySwitches : Object
	{
		// Token: 0x0600163D RID: 5693 RVA: 0x00006F0C File Offset: 0x0000510C
		// Note: this type is marked as 'beforefieldinit'.
		static CompatibilitySwitches()
		{
			Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CompatibilitySwitches");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr);
			CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompatibilitySwitches>.NativeClassPtr, "IsAppEarlierThanWindowsPhone8");
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00006F45 File Offset: 0x00005145
		public CompatibilitySwitches(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x00091528 File Offset: 0x0008F728
		// (set) Token: 0x06001640 RID: 5696 RVA: 0x00006F4E File Offset: 0x0000514E
		public unsafe static bool IsAppEarlierThanWindowsPhone8
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompatibilitySwitches.NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8, (void*)(&value));
			}
		}

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeFieldInfoPtr_IsAppEarlierThanWindowsPhone8;
	}
}
