using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using InControl;

namespace MultiplayerWithBindingsExample
{
	// Token: 0x0200000C RID: 12
	public class PlayerActions : PlayerActionSet
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x00004B64 File Offset: 0x00002D64
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerActions()
		{
			Il2CppClassPointerStore<PlayerActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "MultiplayerWithBindingsExample", "PlayerActions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr);
			PlayerActions.NativeFieldInfoPtr_Green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Green");
			PlayerActions.NativeFieldInfoPtr_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Red");
			PlayerActions.NativeFieldInfoPtr_Blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Blue");
			PlayerActions.NativeFieldInfoPtr_Yellow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Yellow");
			PlayerActions.NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Left");
			PlayerActions.NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Right");
			PlayerActions.NativeFieldInfoPtr_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Up");
			PlayerActions.NativeFieldInfoPtr_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Down");
			PlayerActions.NativeFieldInfoPtr_Rotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Rotate");
			PlayerActions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, 100663369);
			PlayerActions.NativeMethodInfoPtr_CreateWithKeyboardBindings_Public_Static_PlayerActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, 100663370);
			PlayerActions.NativeMethodInfoPtr_CreateWithJoystickBindings_Public_Static_PlayerActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, 100663371);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004C84 File Offset: 0x00002E84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1251842, RefRangeEnd = 1251844, XrefRangeStart = 1251807, XrefRangeEnd = 1251842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerActions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004CC0 File Offset: 0x00002EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1251873, RefRangeEnd = 1251874, XrefRangeStart = 1251844, XrefRangeEnd = 1251873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerActions CreateWithKeyboardBindings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActions.NativeMethodInfoPtr_CreateWithKeyboardBindings_Public_Static_PlayerActions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerActions>(intPtr3) : null;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004CF4 File Offset: 0x00002EF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1251890, RefRangeEnd = 1251891, XrefRangeStart = 1251874, XrefRangeEnd = 1251890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerActions CreateWithJoystickBindings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActions.NativeMethodInfoPtr_CreateWithJoystickBindings_Public_Static_PlayerActions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerActions>(intPtr3) : null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002544 File Offset: 0x00000744
		public PlayerActions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00004D28 File Offset: 0x00002F28
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000254D File Offset: 0x0000074D
		public unsafe PlayerAction Green
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Green);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Green), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00004D58 File Offset: 0x00002F58
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000256C File Offset: 0x0000076C
		public unsafe PlayerAction Red
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Red);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Red), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00004D88 File Offset: 0x00002F88
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000258B File Offset: 0x0000078B
		public unsafe PlayerAction Blue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Blue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Blue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00004DB8 File Offset: 0x00002FB8
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000025AA File Offset: 0x000007AA
		public unsafe PlayerAction Yellow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Yellow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Yellow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00004DE8 File Offset: 0x00002FE8
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000025C9 File Offset: 0x000007C9
		public unsafe PlayerAction Left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Left);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Left), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00004E18 File Offset: 0x00003018
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x000025E8 File Offset: 0x000007E8
		public unsafe PlayerAction Right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Right);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Right), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00004E48 File Offset: 0x00003048
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002607 File Offset: 0x00000807
		public unsafe PlayerAction Up
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Up);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Up), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004E78 File Offset: 0x00003078
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002626 File Offset: 0x00000826
		public unsafe PlayerAction Down
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Down);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Down), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00004EA8 File Offset: 0x000030A8
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002645 File Offset: 0x00000845
		public unsafe PlayerTwoAxisAction Rotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Rotate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTwoAxisAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Rotate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_Green;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_Red;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_Blue;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_Yellow;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_Left;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_Right;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_Up;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_Down;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_Rotate;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_CreateWithKeyboardBindings_Public_Static_PlayerActions_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_CreateWithJoystickBindings_Public_Static_PlayerActions_0;
	}
}
