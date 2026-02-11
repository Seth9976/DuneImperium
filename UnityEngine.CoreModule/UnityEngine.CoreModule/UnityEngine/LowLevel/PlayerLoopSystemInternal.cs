using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.LowLevel
{
	// Token: 0x020001C6 RID: 454
	public sealed class PlayerLoopSystemInternal : ValueType
	{
		// Token: 0x060020D5 RID: 8405 RVA: 0x00091654 File Offset: 0x0008F854
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerLoopSystemInternal()
		{
			Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.LowLevel", "PlayerLoopSystemInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr);
			PlayerLoopSystemInternal.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "type");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "updateDelegate");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "updateFunction");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "loopConditionFunction");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "numSubSystems");
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x0000C6B4 File Offset: 0x0000A8B4
		public PlayerLoopSystemInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x0000C6BD File Offset: 0x0000A8BD
		public PlayerLoopSystemInternal()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr))
		{
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x000916E8 File Offset: 0x0008F8E8
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x0000C6CF File Offset: 0x0000A8CF
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x00091718 File Offset: 0x0008F918
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x0000C6EE File Offset: 0x0000A8EE
		public unsafe PlayerLoopSystem.UpdateFunction updateDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerLoopSystem.UpdateFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x00091748 File Offset: 0x0008F948
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x0000C70D File Offset: 0x0000A90D
		public unsafe IntPtr updateFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction)) = value;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x00091770 File Offset: 0x0008F970
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x0000C728 File Offset: 0x0000A928
		public unsafe IntPtr loopConditionFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction)) = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x00091798 File Offset: 0x0008F998
		// (set) Token: 0x060020E1 RID: 8417 RVA: 0x0000C743 File Offset: 0x0000A943
		public unsafe int numSubSystems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems)) = value;
			}
		}

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001C2F RID: 7215
		private static readonly IntPtr NativeFieldInfoPtr_updateDelegate;

		// Token: 0x04001C30 RID: 7216
		private static readonly IntPtr NativeFieldInfoPtr_updateFunction;

		// Token: 0x04001C31 RID: 7217
		private static readonly IntPtr NativeFieldInfoPtr_loopConditionFunction;

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeFieldInfoPtr_numSubSystems;
	}
}
