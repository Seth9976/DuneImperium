using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace XInputDotNetPure
{
	// Token: 0x02000007 RID: 7
	[StructLayout(2)]
	public struct GamePadThumbSticks
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00007D1C File Offset: 0x00005F1C
		// Note: this type is marked as 'beforefieldinit'.
		static GamePadThumbSticks()
		{
			Il2CppClassPointerStore<GamePadThumbSticks>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "XInputDotNetPure", "GamePadThumbSticks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePadThumbSticks>.NativeClassPtr);
			GamePadThumbSticks.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadThumbSticks>.NativeClassPtr, "left");
			GamePadThumbSticks.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadThumbSticks>.NativeClassPtr, "right");
			GamePadThumbSticks.NativeMethodInfoPtr__ctor_Internal_Void_StickValue_StickValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadThumbSticks>.NativeClassPtr, 100663322);
			GamePadThumbSticks.NativeMethodInfoPtr_get_Left_Public_get_StickValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadThumbSticks>.NativeClassPtr, 100663323);
			GamePadThumbSticks.NativeMethodInfoPtr_get_Right_Public_get_StickValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadThumbSticks>.NativeClassPtr, 100663324);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00007DB0 File Offset: 0x00005FB0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 636721, RefRangeEnd = 636742, XrefRangeStart = 636721, XrefRangeEnd = 636742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamePadThumbSticks(GamePadThumbSticks.StickValue left, GamePadThumbSticks.StickValue right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadThumbSticks.NativeMethodInfoPtr__ctor_Internal_Void_StickValue_StickValue_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00007DF0 File Offset: 0x00005FF0
		public unsafe GamePadThumbSticks.StickValue Left
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadThumbSticks.NativeMethodInfoPtr_get_Left_Public_get_StickValue_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00007E20 File Offset: 0x00006020
		public unsafe GamePadThumbSticks.StickValue Right
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadThumbSticks.NativeMethodInfoPtr_get_Right_Public_get_StickValue_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002086 File Offset: 0x00000286
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePadThumbSticks>.NativeClassPtr, ref this));
		}

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_left;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_right;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_StickValue_StickValue_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_Left_Public_get_StickValue_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_StickValue_0;

		// Token: 0x0400003E RID: 62
		[FieldOffset(0)]
		public GamePadThumbSticks.StickValue left;

		// Token: 0x0400003F RID: 63
		[FieldOffset(8)]
		public GamePadThumbSticks.StickValue right;

		// Token: 0x0200020D RID: 525
		[StructLayout(2)]
		public struct StickValue
		{
			// Token: 0x06001175 RID: 4469 RVA: 0x00044A24 File Offset: 0x00042C24
			// Note: this type is marked as 'beforefieldinit'.
			static StickValue()
			{
				Il2CppClassPointerStore<GamePadThumbSticks.StickValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GamePadThumbSticks>.NativeClassPtr, "StickValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePadThumbSticks.StickValue>.NativeClassPtr);
				GamePadThumbSticks.StickValue.NativeFieldInfoPtr_vector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamePadThumbSticks.StickValue>.NativeClassPtr, "vector");
				GamePadThumbSticks.StickValue.NativeMethodInfoPtr__ctor_Internal_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadThumbSticks.StickValue>.NativeClassPtr, 100663325);
				GamePadThumbSticks.StickValue.NativeMethodInfoPtr_get_X_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadThumbSticks.StickValue>.NativeClassPtr, 100663326);
				GamePadThumbSticks.StickValue.NativeMethodInfoPtr_get_Y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadThumbSticks.StickValue>.NativeClassPtr, 100663327);
				GamePadThumbSticks.StickValue.NativeMethodInfoPtr_get_Vector_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePadThumbSticks.StickValue>.NativeClassPtr, 100663328);
			}

			// Token: 0x06001176 RID: 4470 RVA: 0x00044AB4 File Offset: 0x00042CB4
			[CallerCount(0)]
			public unsafe StickValue(float x, float y)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadThumbSticks.StickValue.NativeMethodInfoPtr__ctor_Internal_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003CC RID: 972
			// (get) Token: 0x06001177 RID: 4471 RVA: 0x00044AF4 File Offset: 0x00042CF4
			public unsafe float X
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadThumbSticks.StickValue.NativeMethodInfoPtr_get_X_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170003CD RID: 973
			// (get) Token: 0x06001178 RID: 4472 RVA: 0x00044B24 File Offset: 0x00042D24
			public unsafe float Y
			{
				[CallerCount(0)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadThumbSticks.StickValue.NativeMethodInfoPtr_get_Y_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170003CE RID: 974
			// (get) Token: 0x06001179 RID: 4473 RVA: 0x00044B54 File Offset: 0x00042D54
			public unsafe Vector2 Vector
			{
				[CallerCount(99)]
				[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePadThumbSticks.StickValue.NativeMethodInfoPtr_get_Vector_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600117A RID: 4474 RVA: 0x00007058 File Offset: 0x00005258
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamePadThumbSticks.StickValue>.NativeClassPtr, ref this));
			}

			// Token: 0x04000D6B RID: 3435
			private static readonly IntPtr NativeFieldInfoPtr_vector;

			// Token: 0x04000D6C RID: 3436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Single_Single_0;

			// Token: 0x04000D6D RID: 3437
			private static readonly IntPtr NativeMethodInfoPtr_get_X_Public_get_Single_0;

			// Token: 0x04000D6E RID: 3438
			private static readonly IntPtr NativeMethodInfoPtr_get_Y_Public_get_Single_0;

			// Token: 0x04000D6F RID: 3439
			private static readonly IntPtr NativeMethodInfoPtr_get_Vector_Public_get_Vector2_0;

			// Token: 0x04000D70 RID: 3440
			[FieldOffset(0)]
			public Vector2 vector;
		}
	}
}
