using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace lib.canis.audio
{
	// Token: 0x02000006 RID: 6
	public class PlaySoundsInOrder : MonoBehaviour
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002DC4 File Offset: 0x00000FC4
		// Note: this type is marked as 'beforefieldinit'.
		static PlaySoundsInOrder()
		{
			Il2CppClassPointerStore<PlaySoundsInOrder>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lib.canis.audio", "PlaySoundsInOrder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySoundsInOrder>.NativeClassPtr);
			PlaySoundsInOrder.NativeFieldInfoPtr_sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundsInOrder>.NativeClassPtr, "sounds");
			PlaySoundsInOrder.NativeFieldInfoPtr_audioDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundsInOrder>.NativeClassPtr, "audioDelay");
			PlaySoundsInOrder.NativeFieldInfoPtr_conditionallySkipMatchStartAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundsInOrder>.NativeClassPtr, "conditionallySkipMatchStartAudio");
			PlaySoundsInOrder.NativeFieldInfoPtr_runningCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundsInOrder>.NativeClassPtr, "runningCoroutine");
			PlaySoundsInOrder.NativeMethodInfoPtr_Event_PlaySounds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundsInOrder>.NativeClassPtr, 100663303);
			PlaySoundsInOrder.NativeMethodInfoPtr_PlaySounds_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundsInOrder>.NativeClassPtr, 100663304);
			PlaySoundsInOrder.NativeMethodInfoPtr_SetSounds_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundsInOrder>.NativeClassPtr, 100663305);
			PlaySoundsInOrder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundsInOrder>.NativeClassPtr, 100663306);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002E94 File Offset: 0x00001094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261254, XrefRangeEnd = 1261264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_PlaySounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundsInOrder.NativeMethodInfoPtr_Event_PlaySounds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002EC8 File Offset: 0x000010C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261264, XrefRangeEnd = 1261269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PlaySounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundsInOrder.NativeMethodInfoPtr_PlaySounds_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002F08 File Offset: 0x00001108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSounds(Il2CppStringArray newSounds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSounds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundsInOrder.NativeMethodInfoPtr_SetSounds_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002F4C File Offset: 0x0000114C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261269, XrefRangeEnd = 1261274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaySoundsInOrder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySoundsInOrder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundsInOrder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020E7 File Offset: 0x000002E7
		public PlaySoundsInOrder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002F88 File Offset: 0x00001188
		// (set) Token: 0x0600001A RID: 26 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe Il2CppStringArray sounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder.NativeFieldInfoPtr_sounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder.NativeFieldInfoPtr_sounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002FB8 File Offset: 0x000011B8
		// (set) Token: 0x0600001C RID: 28 RVA: 0x0000210F File Offset: 0x0000030F
		public unsafe float audioDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder.NativeFieldInfoPtr_audioDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder.NativeFieldInfoPtr_audioDelay)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002FE0 File Offset: 0x000011E0
		// (set) Token: 0x0600001E RID: 30 RVA: 0x0000212A File Offset: 0x0000032A
		public unsafe bool conditionallySkipMatchStartAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder.NativeFieldInfoPtr_conditionallySkipMatchStartAudio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder.NativeFieldInfoPtr_conditionallySkipMatchStartAudio)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00003008 File Offset: 0x00001208
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002145 File Offset: 0x00000345
		public unsafe Coroutine runningCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder.NativeFieldInfoPtr_runningCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder.NativeFieldInfoPtr_runningCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_sounds;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_audioDelay;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_conditionallySkipMatchStartAudio;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_runningCoroutine;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_Event_PlaySounds_Public_Void_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_PlaySounds_Private_IEnumerator_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_SetSounds_Public_Void_Il2CppStringArray_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200001C RID: 28
		[ObfuscatedName("lib.canis.audio.PlaySoundsInOrder+<PlaySounds>d__5")]
		public sealed class _PlaySounds_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x06000106 RID: 262 RVA: 0x00005B18 File Offset: 0x00003D18
			// Note: this type is marked as 'beforefieldinit'.
			static _PlaySounds_d__5()
			{
				Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlaySoundsInOrder>.NativeClassPtr, "<PlaySounds>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr);
				PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr, "<>1__state");
				PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr, "<>2__current");
				PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr, "<>4__this");
				PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr, "<>7__wrap1");
				PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr, "<>7__wrap2");
				PlaySoundsInOrder._PlaySounds_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr, 100663307);
				PlaySoundsInOrder._PlaySounds_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr, 100663308);
				PlaySoundsInOrder._PlaySounds_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr, 100663309);
				PlaySoundsInOrder._PlaySounds_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr, 100663310);
				PlaySoundsInOrder._PlaySounds_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr, 100663311);
				PlaySoundsInOrder._PlaySounds_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr, 100663312);
			}

			// Token: 0x06000107 RID: 263 RVA: 0x00005C20 File Offset: 0x00003E20
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlaySounds_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySoundsInOrder._PlaySounds_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundsInOrder._PlaySounds_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000108 RID: 264 RVA: 0x00005C68 File Offset: 0x00003E68
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundsInOrder._PlaySounds_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000109 RID: 265 RVA: 0x00005C9C File Offset: 0x00003E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261240, XrefRangeEnd = 1261249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundsInOrder._PlaySounds_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x0600010A RID: 266 RVA: 0x00005CD8 File Offset: 0x00003ED8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundsInOrder._PlaySounds_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600010B RID: 267 RVA: 0x00005D18 File Offset: 0x00003F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261249, XrefRangeEnd = 1261254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundsInOrder._PlaySounds_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x0600010C RID: 268 RVA: 0x00005D4C File Offset: 0x00003F4C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundsInOrder._PlaySounds_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600010D RID: 269 RVA: 0x0000281C File Offset: 0x00000A1C
			public _PlaySounds_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x0600010E RID: 270 RVA: 0x00005D8C File Offset: 0x00003F8C
			// (set) Token: 0x0600010F RID: 271 RVA: 0x00002825 File Offset: 0x00000A25
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x06000110 RID: 272 RVA: 0x00005DB4 File Offset: 0x00003FB4
			// (set) Token: 0x06000111 RID: 273 RVA: 0x00002840 File Offset: 0x00000A40
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x06000112 RID: 274 RVA: 0x00005DE4 File Offset: 0x00003FE4
			// (set) Token: 0x06000113 RID: 275 RVA: 0x0000285F File Offset: 0x00000A5F
			public unsafe PlaySoundsInOrder __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlaySoundsInOrder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x06000114 RID: 276 RVA: 0x00005E14 File Offset: 0x00004014
			// (set) Token: 0x06000115 RID: 277 RVA: 0x0000287E File Offset: 0x00000A7E
			public unsafe Il2CppStringArray __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000116 RID: 278 RVA: 0x00005E44 File Offset: 0x00004044
			// (set) Token: 0x06000117 RID: 279 RVA: 0x0000289D File Offset: 0x00000A9D
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundsInOrder._PlaySounds_d__5.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x04000097 RID: 151
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000098 RID: 152
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000099 RID: 153
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400009A RID: 154
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400009B RID: 155
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400009C RID: 156
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400009D RID: 157
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400009E RID: 158
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400009F RID: 159
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000A0 RID: 160
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000A1 RID: 161
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
