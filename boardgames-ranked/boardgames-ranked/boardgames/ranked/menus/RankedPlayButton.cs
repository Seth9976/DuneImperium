using System;
using boardgames.ranked.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace boardgames.ranked.menus
{
	// Token: 0x02000021 RID: 33
	public class RankedPlayButton : MonoBehaviour
	{
		// Token: 0x0600010D RID: 269 RVA: 0x000061AC File Offset: 0x000043AC
		// Note: this type is marked as 'beforefieldinit'.
		static RankedPlayButton()
		{
			Il2CppClassPointerStore<RankedPlayButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedPlayButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayButton>.NativeClassPtr);
			RankedPlayButton.NativeFieldInfoPtr_ShowRankParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayButton>.NativeClassPtr, "ShowRankParam");
			RankedPlayButton.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayButton>.NativeClassPtr, 100663356);
			RankedPlayButton.NativeMethodInfoPtr_Event_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayButton>.NativeClassPtr, 100663357);
			RankedPlayButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayButton>.NativeClassPtr, 100663358);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000622C File Offset: 0x0000442C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225099, XrefRangeEnd = 1225104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayButton.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000626C File Offset: 0x0000446C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225104, XrefRangeEnd = 1225114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayButton.NativeMethodInfoPtr_Event_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000062A0 File Offset: 0x000044A0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedPlayButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002B85 File Offset: 0x00000D85
		public RankedPlayButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000062DC File Offset: 0x000044DC
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00002B8E File Offset: 0x00000D8E
		public unsafe static int ShowRankParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RankedPlayButton.NativeFieldInfoPtr_ShowRankParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RankedPlayButton.NativeFieldInfoPtr_ShowRankParam, (void*)(&value));
			}
		}

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_ShowRankParam;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_Event_Play_Public_Void_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200003E RID: 62
		[ObfuscatedName("boardgames.ranked.menus.RankedPlayButton+<Start>d__1")]
		public sealed class _Start_d__1 : global::Il2CppSystem.Object
		{
			// Token: 0x0600020D RID: 525 RVA: 0x000093B0 File Offset: 0x000075B0
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__1()
			{
				Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankedPlayButton>.NativeClassPtr, "<Start>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr);
				RankedPlayButton._Start_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr, "<>1__state");
				RankedPlayButton._Start_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr, "<>2__current");
				RankedPlayButton._Start_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr, "<>4__this");
				RankedPlayButton._Start_d__1.NativeFieldInfoPtr__animator_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr, "<animator>5__2");
				RankedPlayButton._Start_d__1.NativeFieldInfoPtr__getInfo_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr, "<getInfo>5__3");
				RankedPlayButton._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr, 100663360);
				RankedPlayButton._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr, 100663361);
				RankedPlayButton._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr, 100663362);
				RankedPlayButton._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr, 100663363);
				RankedPlayButton._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr, 100663364);
				RankedPlayButton._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr, 100663365);
			}

			// Token: 0x0600020E RID: 526 RVA: 0x000094B8 File Offset: 0x000076B8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayButton._Start_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayButton._Start_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600020F RID: 527 RVA: 0x00009500 File Offset: 0x00007700
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayButton._Start_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000210 RID: 528 RVA: 0x00009534 File Offset: 0x00007734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225069, XrefRangeEnd = 1225094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayButton._Start_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x06000211 RID: 529 RVA: 0x00009570 File Offset: 0x00007770
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayButton._Start_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000212 RID: 530 RVA: 0x000095B0 File Offset: 0x000077B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225094, XrefRangeEnd = 1225099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayButton._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x06000213 RID: 531 RVA: 0x000095E4 File Offset: 0x000077E4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayButton._Start_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000214 RID: 532 RVA: 0x00003233 File Offset: 0x00001433
			public _Start_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x06000215 RID: 533 RVA: 0x00009624 File Offset: 0x00007824
			// (set) Token: 0x06000216 RID: 534 RVA: 0x0000323C File Offset: 0x0000143C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButton._Start_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButton._Start_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x06000217 RID: 535 RVA: 0x0000964C File Offset: 0x0000784C
			// (set) Token: 0x06000218 RID: 536 RVA: 0x00003257 File Offset: 0x00001457
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButton._Start_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButton._Start_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x06000219 RID: 537 RVA: 0x0000967C File Offset: 0x0000787C
			// (set) Token: 0x0600021A RID: 538 RVA: 0x00003276 File Offset: 0x00001476
			public unsafe RankedPlayButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButton._Start_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedPlayButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButton._Start_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x0600021B RID: 539 RVA: 0x000096AC File Offset: 0x000078AC
			// (set) Token: 0x0600021C RID: 540 RVA: 0x00003295 File Offset: 0x00001495
			public unsafe Animator _animator_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButton._Start_d__1.NativeFieldInfoPtr__animator_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButton._Start_d__1.NativeFieldInfoPtr__animator_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x0600021D RID: 541 RVA: 0x000096DC File Offset: 0x000078DC
			// (set) Token: 0x0600021E RID: 542 RVA: 0x000032B4 File Offset: 0x000014B4
			public unsafe GetRankedQueueInfoCommand _getInfo_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButton._Start_d__1.NativeFieldInfoPtr__getInfo_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetRankedQueueInfoCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayButton._Start_d__1.NativeFieldInfoPtr__getInfo_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400011F RID: 287
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000120 RID: 288
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000121 RID: 289
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000122 RID: 290
			private static readonly IntPtr NativeFieldInfoPtr__animator_5__2;

			// Token: 0x04000123 RID: 291
			private static readonly IntPtr NativeFieldInfoPtr__getInfo_5__3;

			// Token: 0x04000124 RID: 292
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000125 RID: 293
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000126 RID: 294
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000127 RID: 295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000128 RID: 296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000129 RID: 297
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
