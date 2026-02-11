using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using worm.canis.match;

namespace worm.canis.data.ScenarioGames
{
	// Token: 0x020000C4 RID: 196
	public static class ScenarioGames : Object
	{
		// Token: 0x06000D69 RID: 3433 RVA: 0x0000711A File Offset: 0x0000531A
		// Note: this type is marked as 'beforefieldinit'.
		static ScenarioGames()
		{
			Il2CppClassPointerStore<ScenarioGames>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.ScenarioGames", "ScenarioGames");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScenarioGames>.NativeClassPtr);
			ScenarioGames.NativeFieldInfoPtr_stub = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScenarioGames>.NativeClassPtr, "stub");
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00007153 File Offset: 0x00005353
		public ScenarioGames(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x000966FC File Offset: 0x000948FC
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x0000715C File Offset: 0x0000535C
		public unsafe static WormMatchInitData stub
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScenarioGames.NativeFieldInfoPtr_stub, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScenarioGames.NativeFieldInfoPtr_stub, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeFieldInfoPtr_stub;
	}
}
