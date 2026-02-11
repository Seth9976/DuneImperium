using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace XInputDotNetPure
{
	// Token: 0x0200000B RID: 11
	public class GamePad : Object
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00008218 File Offset: 0x00006418
		// Note: this type is marked as 'beforefieldinit'.
		static GamePad()
		{
			Il2CppClassPointerStore<GamePad>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "XInputDotNetPure", "GamePad");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamePad>.NativeClassPtr);
			GamePad.NativeMethodInfoPtr_GetState_Public_Static_GamePadState_PlayerIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePad>.NativeClassPtr, 100663339);
			GamePad.NativeMethodInfoPtr_SetVibration_Public_Static_Void_PlayerIndex_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePad>.NativeClassPtr, 100663340);
			GamePad.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamePad>.NativeClassPtr, 100663341);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00008284 File Offset: 0x00006484
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 767574, RefRangeEnd = 767576, XrefRangeStart = 767550, XrefRangeEnd = 767574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GamePadState GetState(PlayerIndex playerIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePad.NativeMethodInfoPtr_GetState_Public_Static_GamePadState_PlayerIndex_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000082C4 File Offset: 0x000064C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767548, RefRangeEnd = 767549, XrefRangeStart = 767548, XrefRangeEnd = 767549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetVibration(PlayerIndex playerIndex, float leftMotor, float rightMotor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leftMotor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightMotor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePad.NativeMethodInfoPtr_SetVibration_Public_Static_Void_PlayerIndex_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00008314 File Offset: 0x00006514
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamePad()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamePad>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamePad.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000020BC File Offset: 0x000002BC
		public GamePad(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_GetState_Public_Static_GamePadState_PlayerIndex_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Static_Void_PlayerIndex_Single_Single_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
