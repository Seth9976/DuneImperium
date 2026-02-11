using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.match.commands
{
	// Token: 0x0200028D RID: 653
	public static class MatchFailedCodes : Object
	{
		// Token: 0x06001EAA RID: 7850 RVA: 0x000102E7 File Offset: 0x0000E4E7
		// Note: this type is marked as 'beforefieldinit'.
		static MatchFailedCodes()
		{
			Il2CppClassPointerStore<MatchFailedCodes>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "MatchFailedCodes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchFailedCodes>.NativeClassPtr);
			MatchFailedCodes.NativeFieldInfoPtr_COULD_NOT_ESTABLISH_CONTEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchFailedCodes>.NativeClassPtr, "COULD_NOT_ESTABLISH_CONTEXT");
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00010320 File Offset: 0x0000E520
		public MatchFailedCodes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x00083A68 File Offset: 0x00081C68
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x00010329 File Offset: 0x0000E529
		public unsafe static int COULD_NOT_ESTABLISH_CONTEXT
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(MatchFailedCodes.NativeFieldInfoPtr_COULD_NOT_ESTABLISH_CONTEXT, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MatchFailedCodes.NativeFieldInfoPtr_COULD_NOT_ESTABLISH_CONTEXT, (void*)(&value));
			}
		}

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeFieldInfoPtr_COULD_NOT_ESTABLISH_CONTEXT;
	}
}
