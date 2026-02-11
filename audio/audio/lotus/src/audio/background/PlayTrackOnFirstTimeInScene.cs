using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace lotus.src.audio.background
{
	// Token: 0x02000015 RID: 21
	public class PlayTrackOnFirstTimeInScene : PlayTrack
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00004F9C File Offset: 0x0000319C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayTrackOnFirstTimeInScene()
		{
			Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus.src.audio.background", "PlayTrackOnFirstTimeInScene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene>.NativeClassPtr);
			PlayTrackOnFirstTimeInScene.NativeFieldInfoPtr_sceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene>.NativeClassPtr, "sceneName");
			PlayTrackOnFirstTimeInScene.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene>.NativeClassPtr, 100663379);
			PlayTrackOnFirstTimeInScene.NativeMethodInfoPtr_waitForSceneAnPlay_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene>.NativeClassPtr, 100663380);
			PlayTrackOnFirstTimeInScene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene>.NativeClassPtr, 100663381);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000501C File Offset: 0x0000321C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261792, XrefRangeEnd = 1261798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnFirstTimeInScene.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00005050 File Offset: 0x00003250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261798, XrefRangeEnd = 1261803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator waitForSceneAnPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnFirstTimeInScene.NativeMethodInfoPtr_waitForSceneAnPlay_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005090 File Offset: 0x00003290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261803, XrefRangeEnd = 1261808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayTrackOnFirstTimeInScene()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnFirstTimeInScene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002666 File Offset: 0x00000866
		public PlayTrackOnFirstTimeInScene(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000050CC File Offset: 0x000032CC
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000266F File Offset: 0x0000086F
		public unsafe string sceneName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnFirstTimeInScene.NativeFieldInfoPtr_sceneName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnFirstTimeInScene.NativeFieldInfoPtr_sceneName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_sceneName;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_waitForSceneAnPlay_Private_IEnumerator_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200001F RID: 31
		[ObfuscatedName("lotus.src.audio.background.PlayTrackOnFirstTimeInScene+<waitForSceneAnPlay>d__2")]
		public sealed class _waitForSceneAnPlay_d__2 : Object
		{
			// Token: 0x0600012F RID: 303 RVA: 0x0000629C File Offset: 0x0000449C
			// Note: this type is marked as 'beforefieldinit'.
			static _waitForSceneAnPlay_d__2()
			{
				Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene>.NativeClassPtr, "<waitForSceneAnPlay>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2>.NativeClassPtr);
				PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2>.NativeClassPtr, "<>1__state");
				PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2>.NativeClassPtr, "<>2__current");
				PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2>.NativeClassPtr, "<>4__this");
				PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeFieldInfoPtr__readyToPlay_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2>.NativeClassPtr, "<readyToPlay>5__2");
				PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2>.NativeClassPtr, 100663382);
				PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2>.NativeClassPtr, 100663383);
				PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2>.NativeClassPtr, 100663384);
				PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2>.NativeClassPtr, 100663385);
				PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2>.NativeClassPtr, 100663386);
				PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2>.NativeClassPtr, 100663387);
			}

			// Token: 0x06000130 RID: 304 RVA: 0x00006390 File Offset: 0x00004590
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _waitForSceneAnPlay_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000131 RID: 305 RVA: 0x000063D8 File Offset: 0x000045D8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000132 RID: 306 RVA: 0x0000640C File Offset: 0x0000460C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261763, XrefRangeEnd = 1261787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000133 RID: 307 RVA: 0x00006448 File Offset: 0x00004648
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000134 RID: 308 RVA: 0x00006488 File Offset: 0x00004688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261787, XrefRangeEnd = 1261792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000135 RID: 309 RVA: 0x000064BC File Offset: 0x000046BC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000136 RID: 310 RVA: 0x0000297C File Offset: 0x00000B7C
			public _waitForSceneAnPlay_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000137 RID: 311 RVA: 0x000064FC File Offset: 0x000046FC
			// (set) Token: 0x06000138 RID: 312 RVA: 0x00002985 File Offset: 0x00000B85
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000139 RID: 313 RVA: 0x00006524 File Offset: 0x00004724
			// (set) Token: 0x0600013A RID: 314 RVA: 0x000029A0 File Offset: 0x00000BA0
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x0600013B RID: 315 RVA: 0x00006554 File Offset: 0x00004754
			// (set) Token: 0x0600013C RID: 316 RVA: 0x000029BF File Offset: 0x00000BBF
			public unsafe PlayTrackOnFirstTimeInScene __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayTrackOnFirstTimeInScene>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x0600013D RID: 317 RVA: 0x00006584 File Offset: 0x00004784
			// (set) Token: 0x0600013E RID: 318 RVA: 0x000029DE File Offset: 0x00000BDE
			public unsafe bool _readyToPlay_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeFieldInfoPtr__readyToPlay_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnFirstTimeInScene._waitForSceneAnPlay_d__2.NativeFieldInfoPtr__readyToPlay_5__2)) = value;
				}
			}

			// Token: 0x040000AF RID: 175
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000B0 RID: 176
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000B1 RID: 177
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000B2 RID: 178
			private static readonly IntPtr NativeFieldInfoPtr__readyToPlay_5__2;

			// Token: 0x040000B3 RID: 179
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000B4 RID: 180
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000B5 RID: 181
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000B6 RID: 182
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000B7 RID: 183
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000B8 RID: 184
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
