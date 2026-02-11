using System;
using Canis.utils.ids;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace worm.menus.dataRenderers
{
	// Token: 0x0200008D RID: 141
	public class WormEventsNewTagRenderer : MonoBehaviour
	{
		// Token: 0x0600057F RID: 1407 RVA: 0x000298E0 File Offset: 0x00027AE0
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsNewTagRenderer()
		{
			Il2CppClassPointerStore<WormEventsNewTagRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormEventsNewTagRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsNewTagRenderer>.NativeClassPtr);
			WormEventsNewTagRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsNewTagRenderer>.NativeClassPtr, "animator");
			WormEventsNewTagRenderer.NativeFieldInfoPtr_EnableParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsNewTagRenderer>.NativeClassPtr, "EnableParam");
			WormEventsNewTagRenderer.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsNewTagRenderer>.NativeClassPtr, 100664081);
			WormEventsNewTagRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsNewTagRenderer>.NativeClassPtr, 100664082);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00029960 File Offset: 0x00027B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695261, XrefRangeEnd = 695266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsNewTagRenderer.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000299A0 File Offset: 0x00027BA0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsNewTagRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsNewTagRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsNewTagRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00004B9E File Offset: 0x00002D9E
		public WormEventsNewTagRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x000299DC File Offset: 0x00027BDC
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00004BA7 File Offset: 0x00002DA7
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00029A0C File Offset: 0x00027C0C
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00004BC6 File Offset: 0x00002DC6
		public unsafe static int EnableParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormEventsNewTagRenderer.NativeFieldInfoPtr_EnableParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormEventsNewTagRenderer.NativeFieldInfoPtr_EnableParam, (void*)(&value));
			}
		}

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeFieldInfoPtr_EnableParam;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000302 RID: 770
		[ObfuscatedName("worm.menus.dataRenderers.WormEventsNewTagRenderer+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001F07 RID: 7943 RVA: 0x00077014 File Offset: 0x00075214
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormEventsNewTagRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsNewTagRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsNewTagRenderer.__c>.NativeClassPtr);
				WormEventsNewTagRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsNewTagRenderer.__c>.NativeClassPtr, "<>9");
				WormEventsNewTagRenderer.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsNewTagRenderer.__c>.NativeClassPtr, "<>9__2_0");
				WormEventsNewTagRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsNewTagRenderer.__c>.NativeClassPtr, 100664085);
				WormEventsNewTagRenderer.__c.NativeMethodInfoPtr__Start_b__2_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsNewTagRenderer.__c>.NativeClassPtr, 100664086);
			}

			// Token: 0x06001F08 RID: 7944 RVA: 0x00077090 File Offset: 0x00075290
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsNewTagRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsNewTagRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F09 RID: 7945 RVA: 0x000770CC File Offset: 0x000752CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695165, XrefRangeEnd = 695173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__2_0(UnityWebRequest r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsNewTagRenderer.__c.NativeMethodInfoPtr__Start_b__2_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F0A RID: 7946 RVA: 0x000118CC File Offset: 0x0000FACC
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000879 RID: 2169
			// (get) Token: 0x06001F0B RID: 7947 RVA: 0x00077110 File Offset: 0x00075310
			// (set) Token: 0x06001F0C RID: 7948 RVA: 0x000118D5 File Offset: 0x0000FAD5
			public unsafe static WormEventsNewTagRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEventsNewTagRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsNewTagRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEventsNewTagRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087A RID: 2170
			// (get) Token: 0x06001F0D RID: 7949 RVA: 0x00077138 File Offset: 0x00075338
			// (set) Token: 0x06001F0E RID: 7950 RVA: 0x000118E7 File Offset: 0x0000FAE7
			public unsafe static Action<UnityWebRequest> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormEventsNewTagRenderer.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormEventsNewTagRenderer.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011EF RID: 4591
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040011F0 RID: 4592
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040011F1 RID: 4593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011F2 RID: 4594
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__2_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x02000303 RID: 771
		[ObfuscatedName("worm.menus.dataRenderers.WormEventsNewTagRenderer+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001F0F RID: 7951 RVA: 0x00077160 File Offset: 0x00075360
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormEventsNewTagRenderer.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsNewTagRenderer>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsNewTagRenderer.__c__DisplayClass2_0>.NativeClassPtr);
				WormEventsNewTagRenderer.__c__DisplayClass2_0.NativeFieldInfoPtr_seenIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsNewTagRenderer.__c__DisplayClass2_0>.NativeClassPtr, "seenIDs");
				WormEventsNewTagRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsNewTagRenderer.__c__DisplayClass2_0>.NativeClassPtr, 100664087);
				WormEventsNewTagRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__Start_b__1_Internal_Boolean_EventID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsNewTagRenderer.__c__DisplayClass2_0>.NativeClassPtr, 100664088);
			}

			// Token: 0x06001F10 RID: 7952 RVA: 0x000771C8 File Offset: 0x000753C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsNewTagRenderer.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsNewTagRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F11 RID: 7953 RVA: 0x00077204 File Offset: 0x00075404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695173, XrefRangeEnd = 695176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__1(EventID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsNewTagRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__Start_b__1_Internal_Boolean_EventID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F12 RID: 7954 RVA: 0x000118F9 File Offset: 0x0000FAF9
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700087B RID: 2171
			// (get) Token: 0x06001F13 RID: 7955 RVA: 0x00077254 File Offset: 0x00075454
			// (set) Token: 0x06001F14 RID: 7956 RVA: 0x00011902 File Offset: 0x0000FB02
			public unsafe IReadOnlyList<EventID> seenIDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer.__c__DisplayClass2_0.NativeFieldInfoPtr_seenIDs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<EventID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer.__c__DisplayClass2_0.NativeFieldInfoPtr_seenIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011F3 RID: 4595
			private static readonly IntPtr NativeFieldInfoPtr_seenIDs;

			// Token: 0x040011F4 RID: 4596
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011F5 RID: 4597
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Boolean_EventID_0;
		}

		// Token: 0x02000304 RID: 772
		[ObfuscatedName("worm.menus.dataRenderers.WormEventsNewTagRenderer+<Start>d__2")]
		public sealed class _Start_d__2 : global::Il2CppSystem.Object
		{
			// Token: 0x06001F15 RID: 7957 RVA: 0x00077284 File Offset: 0x00075484
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__2()
			{
				Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsNewTagRenderer>.NativeClassPtr, "<Start>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr);
				WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr, "<>1__state");
				WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr, "<>2__current");
				WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr, "<>8__1");
				WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr, "<>4__this");
				WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr, "<request>5__2");
				WormEventsNewTagRenderer._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr, 100664089);
				WormEventsNewTagRenderer._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr, 100664090);
				WormEventsNewTagRenderer._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr, 100664091);
				WormEventsNewTagRenderer._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr, 100664092);
				WormEventsNewTagRenderer._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr, 100664093);
				WormEventsNewTagRenderer._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr, 100664094);
			}

			// Token: 0x06001F16 RID: 7958 RVA: 0x0007738C File Offset: 0x0007558C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsNewTagRenderer._Start_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsNewTagRenderer._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F17 RID: 7959 RVA: 0x000773D4 File Offset: 0x000755D4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsNewTagRenderer._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F18 RID: 7960 RVA: 0x00077408 File Offset: 0x00075608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695176, XrefRangeEnd = 695256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsNewTagRenderer._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000881 RID: 2177
			// (get) Token: 0x06001F19 RID: 7961 RVA: 0x00077444 File Offset: 0x00075644
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsNewTagRenderer._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F1A RID: 7962 RVA: 0x00077484 File Offset: 0x00075684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695256, XrefRangeEnd = 695261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsNewTagRenderer._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000882 RID: 2178
			// (get) Token: 0x06001F1B RID: 7963 RVA: 0x000774B8 File Offset: 0x000756B8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsNewTagRenderer._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F1C RID: 7964 RVA: 0x00011921 File Offset: 0x0000FB21
			public _Start_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700087C RID: 2172
			// (get) Token: 0x06001F1D RID: 7965 RVA: 0x000774F8 File Offset: 0x000756F8
			// (set) Token: 0x06001F1E RID: 7966 RVA: 0x0001192A File Offset: 0x0000FB2A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700087D RID: 2173
			// (get) Token: 0x06001F1F RID: 7967 RVA: 0x00077520 File Offset: 0x00075720
			// (set) Token: 0x06001F20 RID: 7968 RVA: 0x00011945 File Offset: 0x0000FB45
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087E RID: 2174
			// (get) Token: 0x06001F21 RID: 7969 RVA: 0x00077550 File Offset: 0x00075750
			// (set) Token: 0x06001F22 RID: 7970 RVA: 0x00011964 File Offset: 0x0000FB64
			public unsafe WormEventsNewTagRenderer.__c__DisplayClass2_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsNewTagRenderer.__c__DisplayClass2_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700087F RID: 2175
			// (get) Token: 0x06001F23 RID: 7971 RVA: 0x00077580 File Offset: 0x00075780
			// (set) Token: 0x06001F24 RID: 7972 RVA: 0x00011983 File Offset: 0x0000FB83
			public unsafe WormEventsNewTagRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsNewTagRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000880 RID: 2176
			// (get) Token: 0x06001F25 RID: 7973 RVA: 0x000775B0 File Offset: 0x000757B0
			// (set) Token: 0x06001F26 RID: 7974 RVA: 0x000119A2 File Offset: 0x0000FBA2
			public unsafe DwdWebRequestCommand _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsNewTagRenderer._Start_d__2.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011F6 RID: 4598
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011F7 RID: 4599
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040011F8 RID: 4600
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040011F9 RID: 4601
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011FA RID: 4602
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x040011FB RID: 4603
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040011FC RID: 4604
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011FD RID: 4605
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040011FE RID: 4606
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040011FF RID: 4607
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001200 RID: 4608
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
