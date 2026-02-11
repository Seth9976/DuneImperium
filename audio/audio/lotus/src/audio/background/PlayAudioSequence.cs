using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace lotus.src.audio.background
{
	// Token: 0x02000013 RID: 19
	public class PlayAudioSequence : Command
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00004C60 File Offset: 0x00002E60
		// Note: this type is marked as 'beforefieldinit'.
		static PlayAudioSequence()
		{
			Il2CppClassPointerStore<PlayAudioSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus.src.audio.background", "PlayAudioSequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayAudioSequence>.NativeClassPtr);
			PlayAudioSequence.NativeFieldInfoPtr_track = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSequence>.NativeClassPtr, "track");
			PlayAudioSequence.NativeFieldInfoPtr_stopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSequence>.NativeClassPtr, "stopped");
			PlayAudioSequence.NativeFieldInfoPtr_activeSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSequence>.NativeClassPtr, "activeSound");
			PlayAudioSequence.NativeMethodInfoPtr__ctor_Public_Void_Track_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSequence>.NativeClassPtr, 100663368);
			PlayAudioSequence.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSequence>.NativeClassPtr, 100663369);
			PlayAudioSequence.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSequence>.NativeClassPtr, 100663370);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004D08 File Offset: 0x00002F08
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayAudioSequence(Track track)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayAudioSequence>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(track);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSequence.NativeMethodInfoPtr__ctor_Public_Void_Track_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004D54 File Offset: 0x00002F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261739, XrefRangeEnd = 1261745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSequence.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00004D88 File Offset: 0x00002F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261745, XrefRangeEnd = 1261750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayAudioSequence.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000025BD File Offset: 0x000007BD
		public PlayAudioSequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00004DD4 File Offset: 0x00002FD4
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000025C6 File Offset: 0x000007C6
		public unsafe Track track
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence.NativeFieldInfoPtr_track);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Track>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence.NativeFieldInfoPtr_track), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00004E04 File Offset: 0x00003004
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000025E5 File Offset: 0x000007E5
		public unsafe bool stopped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence.NativeFieldInfoPtr_stopped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence.NativeFieldInfoPtr_stopped)) = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00004E2C File Offset: 0x0000302C
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002600 File Offset: 0x00000800
		public unsafe AudioObject activeSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence.NativeFieldInfoPtr_activeSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence.NativeFieldInfoPtr_activeSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_track;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_stopped;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_activeSound;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Track_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200001E RID: 30
		[ObfuscatedName("lotus.src.audio.background.PlayAudioSequence+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x0600011F RID: 287 RVA: 0x00005F8C File Offset: 0x0000418C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<PlayAudioSequence._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayAudioSequence>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayAudioSequence._execute_d__5>.NativeClassPtr);
				PlayAudioSequence._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSequence._execute_d__5>.NativeClassPtr, "<>1__state");
				PlayAudioSequence._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSequence._execute_d__5>.NativeClassPtr, "<>2__current");
				PlayAudioSequence._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSequence._execute_d__5>.NativeClassPtr, "<>4__this");
				PlayAudioSequence._execute_d__5.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSequence._execute_d__5>.NativeClassPtr, "<i>5__2");
				PlayAudioSequence._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSequence._execute_d__5>.NativeClassPtr, 100663371);
				PlayAudioSequence._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSequence._execute_d__5>.NativeClassPtr, 100663372);
				PlayAudioSequence._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSequence._execute_d__5>.NativeClassPtr, 100663373);
				PlayAudioSequence._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSequence._execute_d__5>.NativeClassPtr, 100663374);
				PlayAudioSequence._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSequence._execute_d__5>.NativeClassPtr, 100663375);
				PlayAudioSequence._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSequence._execute_d__5>.NativeClassPtr, 100663376);
			}

			// Token: 0x06000120 RID: 288 RVA: 0x00006080 File Offset: 0x00004280
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayAudioSequence._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSequence._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000121 RID: 289 RVA: 0x000060C8 File Offset: 0x000042C8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSequence._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000122 RID: 290 RVA: 0x000060FC File Offset: 0x000042FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261709, XrefRangeEnd = 1261734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSequence._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000123 RID: 291 RVA: 0x00006138 File Offset: 0x00004338
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSequence._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000124 RID: 292 RVA: 0x00006178 File Offset: 0x00004378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261734, XrefRangeEnd = 1261739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSequence._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000125 RID: 293 RVA: 0x000061AC File Offset: 0x000043AC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSequence._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000126 RID: 294 RVA: 0x000028FF File Offset: 0x00000AFF
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x06000127 RID: 295 RVA: 0x000061EC File Offset: 0x000043EC
			// (set) Token: 0x06000128 RID: 296 RVA: 0x00002908 File Offset: 0x00000B08
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x06000129 RID: 297 RVA: 0x00006214 File Offset: 0x00004414
			// (set) Token: 0x0600012A RID: 298 RVA: 0x00002923 File Offset: 0x00000B23
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x0600012B RID: 299 RVA: 0x00006244 File Offset: 0x00004444
			// (set) Token: 0x0600012C RID: 300 RVA: 0x00002942 File Offset: 0x00000B42
			public unsafe PlayAudioSequence __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayAudioSequence>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x0600012D RID: 301 RVA: 0x00006274 File Offset: 0x00004474
			// (set) Token: 0x0600012E RID: 302 RVA: 0x00002961 File Offset: 0x00000B61
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence._execute_d__5.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSequence._execute_d__5.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040000A5 RID: 165
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040000A6 RID: 166
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040000A7 RID: 167
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040000A8 RID: 168
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040000A9 RID: 169
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040000AA RID: 170
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000AB RID: 171
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040000AC RID: 172
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040000AD RID: 173
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040000AE RID: 174
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
