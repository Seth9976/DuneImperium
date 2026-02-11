using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x02000162 RID: 354
	public class WormSnooperTokenRenderer : MonoBehaviour
	{
		// Token: 0x06000FD9 RID: 4057 RVA: 0x00047C18 File Offset: 0x00045E18
		// Note: this type is marked as 'beforefieldinit'.
		static WormSnooperTokenRenderer()
		{
			Il2CppClassPointerStore<WormSnooperTokenRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormSnooperTokenRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSnooperTokenRenderer>.NativeClassPtr);
			WormSnooperTokenRenderer.NativeFieldInfoPtr_snooperToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSnooperTokenRenderer>.NativeClassPtr, "snooperToken");
			WormSnooperTokenRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSnooperTokenRenderer>.NativeClassPtr, "animator");
			WormSnooperTokenRenderer.NativeFieldInfoPtr_heroicOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSnooperTokenRenderer>.NativeClassPtr, "heroicOffset");
			WormSnooperTokenRenderer.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSnooperTokenRenderer>.NativeClassPtr, "faction");
			WormSnooperTokenRenderer.NativeFieldInfoPtr_HideSnooperToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSnooperTokenRenderer>.NativeClassPtr, "HideSnooperToken");
			WormSnooperTokenRenderer.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSnooperTokenRenderer>.NativeClassPtr, 100665456);
			WormSnooperTokenRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSnooperTokenRenderer>.NativeClassPtr, 100665457);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00047CD4 File Offset: 0x00045ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708815, XrefRangeEnd = 708820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSnooperTokenRenderer.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00047D14 File Offset: 0x00045F14
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormSnooperTokenRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSnooperTokenRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSnooperTokenRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0000A567 File Offset: 0x00008767
		public WormSnooperTokenRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00047D50 File Offset: 0x00045F50
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x0000A570 File Offset: 0x00008770
		public unsafe GameObject snooperToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer.NativeFieldInfoPtr_snooperToken);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer.NativeFieldInfoPtr_snooperToken), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00047D80 File Offset: 0x00045F80
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x0000A58F File Offset: 0x0000878F
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00047DB0 File Offset: 0x00045FB0
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x0000A5AE File Offset: 0x000087AE
		public unsafe Vector3 heroicOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer.NativeFieldInfoPtr_heroicOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer.NativeFieldInfoPtr_heroicOffset)) = value;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00047DD8 File Offset: 0x00045FD8
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x0000A5C9 File Offset: 0x000087C9
		public unsafe Factions faction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer.NativeFieldInfoPtr_faction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer.NativeFieldInfoPtr_faction)) = value;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00047E00 File Offset: 0x00046000
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x0000A5E4 File Offset: 0x000087E4
		public unsafe static int HideSnooperToken
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormSnooperTokenRenderer.NativeFieldInfoPtr_HideSnooperToken, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormSnooperTokenRenderer.NativeFieldInfoPtr_HideSnooperToken, (void*)(&value));
			}
		}

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeFieldInfoPtr_snooperToken;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeFieldInfoPtr_heroicOffset;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeFieldInfoPtr_faction;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeFieldInfoPtr_HideSnooperToken;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003AC RID: 940
		[ObfuscatedName("worm.match.dataRenderers.WormSnooperTokenRenderer+<Start>d__5")]
		public sealed class _Start_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x060025CA RID: 9674 RVA: 0x0008A2D8 File Offset: 0x000884D8
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__5()
			{
				Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormSnooperTokenRenderer>.NativeClassPtr, "<Start>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr);
				WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr, "<>1__state");
				WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr, "<>2__current");
				WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr, "<>4__this");
				WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr__matchHub_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr, "<matchHub>5__2");
				WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr__wormEntities_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr, "<wormEntities>5__3");
				WormSnooperTokenRenderer._Start_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr, 100665459);
				WormSnooperTokenRenderer._Start_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr, 100665460);
				WormSnooperTokenRenderer._Start_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr, 100665461);
				WormSnooperTokenRenderer._Start_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr, 100665462);
				WormSnooperTokenRenderer._Start_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr, 100665463);
				WormSnooperTokenRenderer._Start_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr, 100665464);
			}

			// Token: 0x060025CB RID: 9675 RVA: 0x0008A3E0 File Offset: 0x000885E0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormSnooperTokenRenderer._Start_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSnooperTokenRenderer._Start_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025CC RID: 9676 RVA: 0x0008A428 File Offset: 0x00088628
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSnooperTokenRenderer._Start_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025CD RID: 9677 RVA: 0x0008A45C File Offset: 0x0008865C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708734, XrefRangeEnd = 708810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSnooperTokenRenderer._Start_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A8C RID: 2700
			// (get) Token: 0x060025CE RID: 9678 RVA: 0x0008A498 File Offset: 0x00088698
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSnooperTokenRenderer._Start_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025CF RID: 9679 RVA: 0x0008A4D8 File Offset: 0x000886D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 708810, XrefRangeEnd = 708815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSnooperTokenRenderer._Start_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A8D RID: 2701
			// (get) Token: 0x060025D0 RID: 9680 RVA: 0x0008A50C File Offset: 0x0008870C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormSnooperTokenRenderer._Start_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025D1 RID: 9681 RVA: 0x00015034 File Offset: 0x00013234
			public _Start_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A87 RID: 2695
			// (get) Token: 0x060025D2 RID: 9682 RVA: 0x0008A54C File Offset: 0x0008874C
			// (set) Token: 0x060025D3 RID: 9683 RVA: 0x0001503D File Offset: 0x0001323D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A88 RID: 2696
			// (get) Token: 0x060025D4 RID: 9684 RVA: 0x0008A574 File Offset: 0x00088774
			// (set) Token: 0x060025D5 RID: 9685 RVA: 0x00015058 File Offset: 0x00013258
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A89 RID: 2697
			// (get) Token: 0x060025D6 RID: 9686 RVA: 0x0008A5A4 File Offset: 0x000887A4
			// (set) Token: 0x060025D7 RID: 9687 RVA: 0x00015077 File Offset: 0x00013277
			public unsafe WormSnooperTokenRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSnooperTokenRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A8A RID: 2698
			// (get) Token: 0x060025D8 RID: 9688 RVA: 0x0008A5D4 File Offset: 0x000887D4
			// (set) Token: 0x060025D9 RID: 9689 RVA: 0x00015096 File Offset: 0x00013296
			public unsafe DBGMatchHub _matchHub_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr__matchHub_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr__matchHub_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A8B RID: 2699
			// (get) Token: 0x060025DA RID: 9690 RVA: 0x0008A604 File Offset: 0x00088804
			// (set) Token: 0x060025DB RID: 9691 RVA: 0x000150B5 File Offset: 0x000132B5
			public unsafe WormEntities _wormEntities_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr__wormEntities_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormSnooperTokenRenderer._Start_d__5.NativeFieldInfoPtr__wormEntities_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015AC RID: 5548
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015AD RID: 5549
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015AE RID: 5550
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015AF RID: 5551
			private static readonly IntPtr NativeFieldInfoPtr__matchHub_5__2;

			// Token: 0x040015B0 RID: 5552
			private static readonly IntPtr NativeFieldInfoPtr__wormEntities_5__3;

			// Token: 0x040015B1 RID: 5553
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015B2 RID: 5554
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015B3 RID: 5555
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015B4 RID: 5556
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015B5 RID: 5557
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015B6 RID: 5558
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
