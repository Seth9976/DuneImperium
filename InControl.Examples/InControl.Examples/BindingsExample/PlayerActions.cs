using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using InControl;

namespace BindingsExample
{
	// Token: 0x02000014 RID: 20
	public class PlayerActions : PlayerActionSet
	{
		// Token: 0x06000122 RID: 290 RVA: 0x000064A8 File Offset: 0x000046A8
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerActions()
		{
			Il2CppClassPointerStore<PlayerActions>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "BindingsExample", "PlayerActions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr);
			PlayerActions.NativeFieldInfoPtr_Fire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Fire");
			PlayerActions.NativeFieldInfoPtr_Jump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Jump");
			PlayerActions.NativeFieldInfoPtr_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Left");
			PlayerActions.NativeFieldInfoPtr_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Right");
			PlayerActions.NativeFieldInfoPtr_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Up");
			PlayerActions.NativeFieldInfoPtr_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Down");
			PlayerActions.NativeFieldInfoPtr_Move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "Move");
			PlayerActions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, 100663419);
			PlayerActions.NativeMethodInfoPtr_CreateWithDefaultBindings_Public_Static_PlayerActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, 100663420);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000658C File Offset: 0x0000478C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252479, XrefRangeEnd = 1252506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerActions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000065C8 File Offset: 0x000047C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252627, RefRangeEnd = 1252628, XrefRangeStart = 1252506, XrefRangeEnd = 1252627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PlayerActions CreateWithDefaultBindings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActions.NativeMethodInfoPtr_CreateWithDefaultBindings_Public_Static_PlayerActions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerActions>(intPtr3) : null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000292B File Offset: 0x00000B2B
		public PlayerActions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000065FC File Offset: 0x000047FC
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00002934 File Offset: 0x00000B34
		public unsafe PlayerAction Fire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Fire);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Fire), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000662C File Offset: 0x0000482C
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00002953 File Offset: 0x00000B53
		public unsafe PlayerAction Jump
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Jump);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Jump), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000665C File Offset: 0x0000485C
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002972 File Offset: 0x00000B72
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000668C File Offset: 0x0000488C
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00002991 File Offset: 0x00000B91
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000066BC File Offset: 0x000048BC
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000029B0 File Offset: 0x00000BB0
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

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000066EC File Offset: 0x000048EC
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000029CF File Offset: 0x00000BCF
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000671C File Offset: 0x0000491C
		// (set) Token: 0x06000133 RID: 307 RVA: 0x000029EE File Offset: 0x00000BEE
		public unsafe PlayerTwoAxisAction Move
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Move);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTwoAxisAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerActions.NativeFieldInfoPtr_Move), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeFieldInfoPtr_Fire;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeFieldInfoPtr_Jump;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeFieldInfoPtr_Left;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeFieldInfoPtr_Right;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeFieldInfoPtr_Up;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_Down;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_Move;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_CreateWithDefaultBindings_Public_Static_PlayerActions_0;

		// Token: 0x0200001B RID: 27
		[ObfuscatedName("BindingsExample.PlayerActions+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600016F RID: 367 RVA: 0x0000708C File Offset: 0x0000528C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayerActions.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerActions>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerActions.__c>.NativeClassPtr);
				PlayerActions.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions.__c>.NativeClassPtr, "<>9");
				PlayerActions.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions.__c>.NativeClassPtr, "<>9__8_0");
				PlayerActions.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions.__c>.NativeClassPtr, "<>9__8_1");
				PlayerActions.__c.NativeFieldInfoPtr___9__8_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerActions.__c>.NativeClassPtr, "<>9__8_2");
				PlayerActions.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActions.__c>.NativeClassPtr, 100663422);
				PlayerActions.__c.NativeMethodInfoPtr__CreateWithDefaultBindings_b__8_0_Internal_Boolean_PlayerAction_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActions.__c>.NativeClassPtr, 100663423);
				PlayerActions.__c.NativeMethodInfoPtr__CreateWithDefaultBindings_b__8_1_Internal_Void_PlayerAction_BindingSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActions.__c>.NativeClassPtr, 100663424);
				PlayerActions.__c.NativeMethodInfoPtr__CreateWithDefaultBindings_b__8_2_Internal_Void_PlayerAction_BindingSource_BindingSourceRejectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerActions.__c>.NativeClassPtr, 100663425);
			}

			// Token: 0x06000170 RID: 368 RVA: 0x00007158 File Offset: 0x00005358
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerActions.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActions.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000171 RID: 369 RVA: 0x00007194 File Offset: 0x00005394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252451, XrefRangeEnd = 1252459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateWithDefaultBindings_b__8_0(PlayerAction action, BindingSource binding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActions.__c.NativeMethodInfoPtr__CreateWithDefaultBindings_b__8_0_Internal_Boolean_PlayerAction_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000172 RID: 370 RVA: 0x000071F4 File Offset: 0x000053F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252459, XrefRangeEnd = 1252469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateWithDefaultBindings_b__8_1(PlayerAction action, BindingSource binding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActions.__c.NativeMethodInfoPtr__CreateWithDefaultBindings_b__8_1_Internal_Void_PlayerAction_BindingSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000173 RID: 371 RVA: 0x00007248 File Offset: 0x00005448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252469, XrefRangeEnd = 1252479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateWithDefaultBindings_b__8_2(PlayerAction action, BindingSource binding, BindingSourceRejectionType reason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binding);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reason;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerActions.__c.NativeMethodInfoPtr__CreateWithDefaultBindings_b__8_2_Internal_Void_PlayerAction_BindingSource_BindingSourceRejectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000174 RID: 372 RVA: 0x00002BF1 File Offset: 0x00000DF1
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000175 RID: 373 RVA: 0x000072AC File Offset: 0x000054AC
			// (set) Token: 0x06000176 RID: 374 RVA: 0x00002BFA File Offset: 0x00000DFA
			public unsafe static PlayerActions.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerActions.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerActions.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerActions.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000177 RID: 375 RVA: 0x000072D4 File Offset: 0x000054D4
			// (set) Token: 0x06000178 RID: 376 RVA: 0x00002C0C File Offset: 0x00000E0C
			public unsafe static Func<PlayerAction, BindingSource, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerActions.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerAction, BindingSource, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerActions.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x06000179 RID: 377 RVA: 0x000072FC File Offset: 0x000054FC
			// (set) Token: 0x0600017A RID: 378 RVA: 0x00002C1E File Offset: 0x00000E1E
			public unsafe static Action<PlayerAction, BindingSource> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerActions.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlayerAction, BindingSource>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerActions.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x0600017B RID: 379 RVA: 0x00007324 File Offset: 0x00005524
			// (set) Token: 0x0600017C RID: 380 RVA: 0x00002C30 File Offset: 0x00000E30
			public unsafe static Action<PlayerAction, BindingSource, BindingSourceRejectionType> __9__8_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerActions.__c.NativeFieldInfoPtr___9__8_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlayerAction, BindingSource, BindingSourceRejectionType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerActions.__c.NativeFieldInfoPtr___9__8_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000DD RID: 221
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000DE RID: 222
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040000DF RID: 223
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x040000E0 RID: 224
			private static readonly IntPtr NativeFieldInfoPtr___9__8_2;

			// Token: 0x040000E1 RID: 225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000E2 RID: 226
			private static readonly IntPtr NativeMethodInfoPtr__CreateWithDefaultBindings_b__8_0_Internal_Boolean_PlayerAction_BindingSource_0;

			// Token: 0x040000E3 RID: 227
			private static readonly IntPtr NativeMethodInfoPtr__CreateWithDefaultBindings_b__8_1_Internal_Void_PlayerAction_BindingSource_0;

			// Token: 0x040000E4 RID: 228
			private static readonly IntPtr NativeMethodInfoPtr__CreateWithDefaultBindings_b__8_2_Internal_Void_PlayerAction_BindingSource_BindingSourceRejectionType_0;
		}
	}
}
