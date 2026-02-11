using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000006 RID: 6
	public static class LocalAppContextSwitches : Object
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000164F0 File Offset: 0x000146F0
		// Note: this type is marked as 'beforefieldinit'.
		static LocalAppContextSwitches()
		{
			Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System", "LocalAppContextSwitches");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr);
			LocalAppContextSwitches.NativeFieldInfoPtr_IgnoreEmptyKeySequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr, "IgnoreEmptyKeySequences");
			LocalAppContextSwitches.NativeFieldInfoPtr_DontThrowOnInvalidSurrogatePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr, "DontThrowOnInvalidSurrogatePairs");
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000213C File Offset: 0x0000033C
		public LocalAppContextSwitches(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00016548 File Offset: 0x00014748
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002145 File Offset: 0x00000345
		public unsafe static bool IgnoreEmptyKeySequences
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalAppContextSwitches.NativeFieldInfoPtr_IgnoreEmptyKeySequences, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalAppContextSwitches.NativeFieldInfoPtr_IgnoreEmptyKeySequences, (void*)(&value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00016564 File Offset: 0x00014764
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002153 File Offset: 0x00000353
		public unsafe static bool DontThrowOnInvalidSurrogatePairs
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalAppContextSwitches.NativeFieldInfoPtr_DontThrowOnInvalidSurrogatePairs, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalAppContextSwitches.NativeFieldInfoPtr_DontThrowOnInvalidSurrogatePairs, (void*)(&value));
			}
		}

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_IgnoreEmptyKeySequences;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_DontThrowOnInvalidSurrogatePairs;
	}
}
