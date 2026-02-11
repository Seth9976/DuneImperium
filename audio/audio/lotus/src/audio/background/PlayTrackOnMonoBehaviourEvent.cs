using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus.src.audio.background
{
	// Token: 0x02000016 RID: 22
	public class PlayTrackOnMonoBehaviourEvent : MonoBehaviour
	{
		// Token: 0x060000CD RID: 205 RVA: 0x000050F4 File Offset: 0x000032F4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayTrackOnMonoBehaviourEvent()
		{
			Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus.src.audio.background", "PlayTrackOnMonoBehaviourEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr);
			PlayTrackOnMonoBehaviourEvent.NativeFieldInfoPtr_trackDataArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr, "trackDataArray");
			PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr, 100663388);
			PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr, 100663389);
			PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr, 100663390);
			PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr, 100663391);
			PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr, 100663392);
			PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_getTrackDataByEvent_Private_List_1_TrackData_LifecycleEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr, 100663393);
			PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_tryPlay_Private_Void_LifecycleEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr, 100663394);
			PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr, 100663395);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000051D8 File Offset: 0x000033D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261815, XrefRangeEnd = 1261816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000520C File Offset: 0x0000340C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261816, XrefRangeEnd = 1261817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005240 File Offset: 0x00003440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261817, XrefRangeEnd = 1261818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00005274 File Offset: 0x00003474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261818, XrefRangeEnd = 1261819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000052A8 File Offset: 0x000034A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261819, XrefRangeEnd = 1261820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000052DC File Offset: 0x000034DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261820, XrefRangeEnd = 1261837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PlayTrackOnMonoBehaviourEvent.TrackData> getTrackDataByEvent(PlayTrackOnMonoBehaviourEvent.LifecycleEvent ev)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ev;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_getTrackDataByEvent_Private_List_1_TrackData_LifecycleEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PlayTrackOnMonoBehaviourEvent.TrackData>>(intPtr3) : null;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00005328 File Offset: 0x00003528
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1261873, RefRangeEnd = 1261878, XrefRangeStart = 1261837, XrefRangeEnd = 1261873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void tryPlay(PlayTrackOnMonoBehaviourEvent.LifecycleEvent ev)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ev;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr_tryPlay_Private_Void_LifecycleEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00005368 File Offset: 0x00003568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261878, XrefRangeEnd = 1261883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayTrackOnMonoBehaviourEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnMonoBehaviourEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000268E File Offset: 0x0000088E
		public PlayTrackOnMonoBehaviourEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000053A4 File Offset: 0x000035A4
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002697 File Offset: 0x00000897
		public unsafe Il2CppReferenceArray<PlayTrackOnMonoBehaviourEvent.TrackData> trackDataArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnMonoBehaviourEvent.NativeFieldInfoPtr_trackDataArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayTrackOnMonoBehaviourEvent.TrackData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnMonoBehaviourEvent.NativeFieldInfoPtr_trackDataArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_trackDataArray;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_getTrackDataByEvent_Private_List_1_TrackData_LifecycleEvent_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_tryPlay_Private_Void_LifecycleEvent_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000020 RID: 32
		public enum LifecycleEvent
		{
			// Token: 0x040000BA RID: 186
			OnAwake,
			// Token: 0x040000BB RID: 187
			OnStart,
			// Token: 0x040000BC RID: 188
			OnEnable,
			// Token: 0x040000BD RID: 189
			OnDisable,
			// Token: 0x040000BE RID: 190
			OnDestroy
		}

		// Token: 0x02000021 RID: 33
		[Serializable]
		public class TrackData : global::Il2CppSystem.Object
		{
			// Token: 0x0600013F RID: 319 RVA: 0x000065AC File Offset: 0x000047AC
			// Note: this type is marked as 'beforefieldinit'.
			static TrackData()
			{
				Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.TrackData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr, "TrackData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.TrackData>.NativeClassPtr);
				PlayTrackOnMonoBehaviourEvent.TrackData.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.TrackData>.NativeClassPtr, "Event");
				PlayTrackOnMonoBehaviourEvent.TrackData.NativeFieldInfoPtr_Channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.TrackData>.NativeClassPtr, "Channel");
				PlayTrackOnMonoBehaviourEvent.TrackData.NativeFieldInfoPtr_Track = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.TrackData>.NativeClassPtr, "Track");
				PlayTrackOnMonoBehaviourEvent.TrackData.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.TrackData>.NativeClassPtr, 100663396);
				PlayTrackOnMonoBehaviourEvent.TrackData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.TrackData>.NativeClassPtr, 100663397);
			}

			// Token: 0x06000140 RID: 320 RVA: 0x0000663C File Offset: 0x0000483C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261808, XrefRangeEnd = 1261809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsValid()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnMonoBehaviourEvent.TrackData.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00006678 File Offset: 0x00004878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261809, XrefRangeEnd = 1261815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TrackData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.TrackData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnMonoBehaviourEvent.TrackData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000142 RID: 322 RVA: 0x000029F9 File Offset: 0x00000BF9
			public TrackData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000143 RID: 323 RVA: 0x000066B4 File Offset: 0x000048B4
			// (set) Token: 0x06000144 RID: 324 RVA: 0x00002A02 File Offset: 0x00000C02
			public unsafe PlayTrackOnMonoBehaviourEvent.LifecycleEvent Event
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnMonoBehaviourEvent.TrackData.NativeFieldInfoPtr_Event);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnMonoBehaviourEvent.TrackData.NativeFieldInfoPtr_Event)) = value;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000145 RID: 325 RVA: 0x000066DC File Offset: 0x000048DC
			// (set) Token: 0x06000146 RID: 326 RVA: 0x00002A1D File Offset: 0x00000C1D
			public unsafe string Channel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnMonoBehaviourEvent.TrackData.NativeFieldInfoPtr_Channel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnMonoBehaviourEvent.TrackData.NativeFieldInfoPtr_Channel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000147 RID: 327 RVA: 0x00006704 File Offset: 0x00004904
			// (set) Token: 0x06000148 RID: 328 RVA: 0x00002A3C File Offset: 0x00000C3C
			public unsafe string Track
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnMonoBehaviourEvent.TrackData.NativeFieldInfoPtr_Track);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnMonoBehaviourEvent.TrackData.NativeFieldInfoPtr_Track), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040000BF RID: 191
			private static readonly IntPtr NativeFieldInfoPtr_Event;

			// Token: 0x040000C0 RID: 192
			private static readonly IntPtr NativeFieldInfoPtr_Channel;

			// Token: 0x040000C1 RID: 193
			private static readonly IntPtr NativeFieldInfoPtr_Track;

			// Token: 0x040000C2 RID: 194
			private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

			// Token: 0x040000C3 RID: 195
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000022 RID: 34
		[ObfuscatedName("lotus.src.audio.background.PlayTrackOnMonoBehaviourEvent+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06000149 RID: 329 RVA: 0x0000672C File Offset: 0x0000492C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.__c__DisplayClass8_0>.NativeClassPtr);
				PlayTrackOnMonoBehaviourEvent.__c__DisplayClass8_0.NativeFieldInfoPtr_ev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.__c__DisplayClass8_0>.NativeClassPtr, "ev");
				PlayTrackOnMonoBehaviourEvent.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.__c__DisplayClass8_0>.NativeClassPtr, 100663398);
				PlayTrackOnMonoBehaviourEvent.__c__DisplayClass8_0.NativeMethodInfoPtr__getTrackDataByEvent_b__0_Internal_Boolean_TrackData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.__c__DisplayClass8_0>.NativeClassPtr, 100663399);
			}

			// Token: 0x0600014A RID: 330 RVA: 0x00006794 File Offset: 0x00004994
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayTrackOnMonoBehaviourEvent.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnMonoBehaviourEvent.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600014B RID: 331 RVA: 0x000067D0 File Offset: 0x000049D0
			[CallerCount(0)]
			public unsafe bool _getTrackDataByEvent_b__0(PlayTrackOnMonoBehaviourEvent.TrackData datum)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(datum);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrackOnMonoBehaviourEvent.__c__DisplayClass8_0.NativeMethodInfoPtr__getTrackDataByEvent_b__0_Internal_Boolean_TrackData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600014C RID: 332 RVA: 0x00002A5B File Offset: 0x00000C5B
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x0600014D RID: 333 RVA: 0x00006820 File Offset: 0x00004A20
			// (set) Token: 0x0600014E RID: 334 RVA: 0x00002A64 File Offset: 0x00000C64
			public unsafe PlayTrackOnMonoBehaviourEvent.LifecycleEvent ev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnMonoBehaviourEvent.__c__DisplayClass8_0.NativeFieldInfoPtr_ev);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrackOnMonoBehaviourEvent.__c__DisplayClass8_0.NativeFieldInfoPtr_ev)) = value;
				}
			}

			// Token: 0x040000C4 RID: 196
			private static readonly IntPtr NativeFieldInfoPtr_ev;

			// Token: 0x040000C5 RID: 197
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000C6 RID: 198
			private static readonly IntPtr NativeMethodInfoPtr__getTrackDataByEvent_b__0_Internal_Boolean_TrackData_0;
		}
	}
}
