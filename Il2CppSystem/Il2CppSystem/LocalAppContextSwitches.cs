using System;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200006B RID: 107
	public static class LocalAppContextSwitches : Object
	{
		// Token: 0x060006A3 RID: 1699 RVA: 0x000041CF File Offset: 0x000023CF
		// Note: this type is marked as 'beforefieldinit'.
		static LocalAppContextSwitches()
		{
			Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "LocalAppContextSwitches");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr);
			LocalAppContextSwitches.NativeFieldInfoPtr_MemberDescriptorEqualsReturnsFalseIfEquivalent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalAppContextSwitches>.NativeClassPtr, "MemberDescriptorEqualsReturnsFalseIfEquivalent");
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00004208 File Offset: 0x00002408
		public LocalAppContextSwitches(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00036020 File Offset: 0x00034220
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00004211 File Offset: 0x00002411
		public unsafe static bool MemberDescriptorEqualsReturnsFalseIfEquivalent
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(LocalAppContextSwitches.NativeFieldInfoPtr_MemberDescriptorEqualsReturnsFalseIfEquivalent, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LocalAppContextSwitches.NativeFieldInfoPtr_MemberDescriptorEqualsReturnsFalseIfEquivalent, (void*)(&value));
			}
		}

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeFieldInfoPtr_MemberDescriptorEqualsReturnsFalseIfEquivalent;
	}
}
