using System;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus.matchMaking
{
	// Token: 0x020000E3 RID: 227
	public class PlayQueue : MonoBehaviour
	{
		// Token: 0x06000B31 RID: 2865 RVA: 0x00034ADC File Offset: 0x00032CDC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayQueue()
		{
			Il2CppClassPointerStore<PlayQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.matchMaking", "PlayQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr);
			PlayQueue.NativeFieldInfoPtr_endedGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr, "endedGames");
			PlayQueue.NativeFieldInfoPtr_turnPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr, "turnPlayed");
			PlayQueue.NativeMethodInfoPtr_ReceivedPBMMatchFound_Public_Boolean_PBMMatchFound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr, 100665083);
			PlayQueue.NativeMethodInfoPtr_SetTurnPlayed_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr, 100665084);
			PlayQueue.NativeMethodInfoPtr_ReceivedPBMTurnReady_Public_Boolean_PBMTurnReady_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr, 100665085);
			PlayQueue.NativeMethodInfoPtr_GetGameEnded_Public_Boolean_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr, 100665086);
			PlayQueue.NativeMethodInfoPtr_SetGameEnded_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr, 100665087);
			PlayQueue.NativeMethodInfoPtr_setTurn_Private_Void_GameID_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr, 100665088);
			PlayQueue.NativeMethodInfoPtr_hasAcknowledged_Private_Boolean_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr, 100665089);
			PlayQueue.NativeMethodInfoPtr_hasAcknowledged_Private_Boolean_GameID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr, 100665090);
			PlayQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr, 100665091);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00034BE8 File Offset: 0x00032DE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 994486, RefRangeEnd = 994487, XrefRangeStart = 994462, XrefRangeEnd = 994486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReceivedPBMMatchFound(PBMMatchFound msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayQueue.NativeMethodInfoPtr_ReceivedPBMMatchFound_Public_Boolean_PBMMatchFound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00034C38 File Offset: 0x00032E38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 994488, RefRangeEnd = 994491, XrefRangeStart = 994487, XrefRangeEnd = 994488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTurnPlayed(GameID gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayQueue.NativeMethodInfoPtr_SetTurnPlayed_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00034C7C File Offset: 0x00032E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 994503, RefRangeEnd = 994504, XrefRangeStart = 994491, XrefRangeEnd = 994503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReceivedPBMTurnReady(PBMTurnReady msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayQueue.NativeMethodInfoPtr_ReceivedPBMTurnReady_Public_Boolean_PBMTurnReady_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00034CCC File Offset: 0x00032ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 994508, RefRangeEnd = 994509, XrefRangeStart = 994504, XrefRangeEnd = 994508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetGameEnded(GameID gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayQueue.NativeMethodInfoPtr_GetGameEnded_Public_Boolean_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00034D1C File Offset: 0x00032F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 994513, RefRangeEnd = 994514, XrefRangeStart = 994509, XrefRangeEnd = 994513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameEnded(GameID gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayQueue.NativeMethodInfoPtr_SetGameEnded_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00034D60 File Offset: 0x00032F60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 994529, RefRangeEnd = 994531, XrefRangeStart = 994514, XrefRangeEnd = 994529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void setTurn(GameID gameID, int turnNumber, bool newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turnNumber;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayQueue.NativeMethodInfoPtr_setTurn_Private_Void_GameID_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00034DC0 File Offset: 0x00032FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994531, XrefRangeEnd = 994539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool hasAcknowledged(GameID gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayQueue.NativeMethodInfoPtr_hasAcknowledged_Private_Boolean_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00034E10 File Offset: 0x00033010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 994543, RefRangeEnd = 994545, XrefRangeStart = 994539, XrefRangeEnd = 994543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool hasAcknowledged(GameID gameID, int turnNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turnNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayQueue.NativeMethodInfoPtr_hasAcknowledged_Private_Boolean_GameID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00034E6C File Offset: 0x0003306C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994545, XrefRangeEnd = 994560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x000071D7 File Offset: 0x000053D7
		public PlayQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x00034EA8 File Offset: 0x000330A8
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x000071E0 File Offset: 0x000053E0
		public unsafe HashSet<GameID> endedGames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayQueue.NativeFieldInfoPtr_endedGames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GameID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayQueue.NativeFieldInfoPtr_endedGames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x00034ED8 File Offset: 0x000330D8
		// (set) Token: 0x06000B3F RID: 2879 RVA: 0x000071FF File Offset: 0x000053FF
		public unsafe Dictionary<GameID, Dictionary<int, bool>> turnPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayQueue.NativeFieldInfoPtr_turnPlayed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameID, Dictionary<int, bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayQueue.NativeFieldInfoPtr_turnPlayed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr_endedGames;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr_turnPlayed;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedPBMMatchFound_Public_Boolean_PBMMatchFound_0;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeMethodInfoPtr_SetTurnPlayed_Public_Void_GameID_0;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeMethodInfoPtr_ReceivedPBMTurnReady_Public_Boolean_PBMTurnReady_0;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr_GetGameEnded_Public_Boolean_GameID_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_SetGameEnded_Public_Void_GameID_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_setTurn_Private_Void_GameID_Int32_Boolean_0;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeMethodInfoPtr_hasAcknowledged_Private_Boolean_GameID_0;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeMethodInfoPtr_hasAcknowledged_Private_Boolean_GameID_Int32_0;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000241 RID: 577
		[ObfuscatedName("lotus.matchMaking.PlayQueue+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001AB7 RID: 6839 RVA: 0x000639F0 File Offset: 0x00061BF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayQueue.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayQueue>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayQueue.__c>.NativeClassPtr);
				PlayQueue.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayQueue.__c>.NativeClassPtr, "<>9");
				PlayQueue.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayQueue.__c>.NativeClassPtr, "<>9__8_0");
				PlayQueue.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayQueue.__c>.NativeClassPtr, 100665093);
				PlayQueue.__c.NativeMethodInfoPtr__hasAcknowledged_b__8_0_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayQueue.__c>.NativeClassPtr, 100665094);
			}

			// Token: 0x06001AB8 RID: 6840 RVA: 0x00063A6C File Offset: 0x00061C6C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayQueue.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayQueue.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AB9 RID: 6841 RVA: 0x00063AA8 File Offset: 0x00061CA8
			[CallerCount(0)]
			public unsafe bool _hasAcknowledged_b__8_0(bool t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayQueue.__c.NativeMethodInfoPtr__hasAcknowledged_b__8_0_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001ABA RID: 6842 RVA: 0x0000E8AD File Offset: 0x0000CAAD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007D6 RID: 2006
			// (get) Token: 0x06001ABB RID: 6843 RVA: 0x00063AF4 File Offset: 0x00061CF4
			// (set) Token: 0x06001ABC RID: 6844 RVA: 0x0000E8B6 File Offset: 0x0000CAB6
			public unsafe static PlayQueue.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayQueue.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayQueue.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayQueue.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D7 RID: 2007
			// (get) Token: 0x06001ABD RID: 6845 RVA: 0x00063B1C File Offset: 0x00061D1C
			// (set) Token: 0x06001ABE RID: 6846 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
			public unsafe static Func<bool, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayQueue.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayQueue.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001028 RID: 4136
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001029 RID: 4137
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400102A RID: 4138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400102B RID: 4139
			private static readonly IntPtr NativeMethodInfoPtr__hasAcknowledged_b__8_0_Internal_Boolean_Boolean_0;
		}
	}
}
