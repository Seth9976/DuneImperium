using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;
using worm.dataProviders;
using worm.match.prompts.prompts;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000D0 RID: 208
	public class WormEarnedSkirmishBadgePromptBehavior : PromptBehaviour<WormEarnedSkirmishBadgePrompt>
	{
		// Token: 0x060008CE RID: 2254 RVA: 0x000332DC File Offset: 0x000314DC
		// Note: this type is marked as 'beforefieldinit'.
		static WormEarnedSkirmishBadgePromptBehavior()
		{
			Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormEarnedSkirmishBadgePromptBehavior");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior>.NativeClassPtr);
			WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_headerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior>.NativeClassPtr, "headerText");
			WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_rankText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior>.NativeClassPtr, "rankText");
			WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_goldBadge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior>.NativeClassPtr, "goldBadge");
			WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_silverBadge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior>.NativeClassPtr, "silverBadge");
			WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_bronzeBadge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior>.NativeClassPtr, "bronzeBadge");
			WormEarnedSkirmishBadgePromptBehavior.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior>.NativeClassPtr, 100664500);
			WormEarnedSkirmishBadgePromptBehavior.NativeMethodInfoPtr_init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior>.NativeClassPtr, 100664501);
			WormEarnedSkirmishBadgePromptBehavior.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior>.NativeClassPtr, 100664502);
			WormEarnedSkirmishBadgePromptBehavior.NativeMethodInfoPtr___n__0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior>.NativeClassPtr, 100664503);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000333C0 File Offset: 0x000315C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699015, XrefRangeEnd = 699021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEarnedSkirmishBadgePromptBehavior.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000333FC File Offset: 0x000315FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699021, XrefRangeEnd = 699026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEarnedSkirmishBadgePromptBehavior.NativeMethodInfoPtr_init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0003343C File Offset: 0x0003163C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699026, XrefRangeEnd = 699029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEarnedSkirmishBadgePromptBehavior()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEarnedSkirmishBadgePromptBehavior.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00033478 File Offset: 0x00031678
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __n__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEarnedSkirmishBadgePromptBehavior.NativeMethodInfoPtr___n__0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0000682E File Offset: 0x00004A2E
		public WormEarnedSkirmishBadgePromptBehavior(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x000334AC File Offset: 0x000316AC
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x00006837 File Offset: 0x00004A37
		public unsafe TMP_Text headerText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_headerText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_headerText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x000334DC File Offset: 0x000316DC
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00006856 File Offset: 0x00004A56
		public unsafe TMP_Text rankText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_rankText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_rankText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0003350C File Offset: 0x0003170C
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00006875 File Offset: 0x00004A75
		public unsafe GameObject goldBadge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_goldBadge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_goldBadge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0003353C File Offset: 0x0003173C
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x00006894 File Offset: 0x00004A94
		public unsafe GameObject silverBadge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_silverBadge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_silverBadge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0003356C File Offset: 0x0003176C
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x000068B3 File Offset: 0x00004AB3
		public unsafe GameObject bronzeBadge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_bronzeBadge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior.NativeFieldInfoPtr_bronzeBadge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeFieldInfoPtr_headerText;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeFieldInfoPtr_rankText;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeFieldInfoPtr_goldBadge;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeFieldInfoPtr_silverBadge;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeFieldInfoPtr_bronzeBadge;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_init_Private_IEnumerator_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_Void_0;

		// Token: 0x02000331 RID: 817
		[ObfuscatedName("worm.match.prompts.behaviours.WormEarnedSkirmishBadgePromptBehavior+<init>d__6")]
		public sealed class _init_d__6 : global::Il2CppSystem.Object
		{
			// Token: 0x06002104 RID: 8452 RVA: 0x0007CA5C File Offset: 0x0007AC5C
			// Note: this type is marked as 'beforefieldinit'.
			static _init_d__6()
			{
				Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior._init_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior>.NativeClassPtr, "<init>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior._init_d__6>.NativeClassPtr);
				WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior._init_d__6>.NativeClassPtr, "<>1__state");
				WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior._init_d__6>.NativeClassPtr, "<>2__current");
				WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior._init_d__6>.NativeClassPtr, "<>4__this");
				WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeFieldInfoPtr__provider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior._init_d__6>.NativeClassPtr, "<provider>5__2");
				WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior._init_d__6>.NativeClassPtr, 100664504);
				WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior._init_d__6>.NativeClassPtr, 100664505);
				WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior._init_d__6>.NativeClassPtr, 100664506);
				WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior._init_d__6>.NativeClassPtr, 100664507);
				WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior._init_d__6>.NativeClassPtr, 100664508);
				WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior._init_d__6>.NativeClassPtr, 100664509);
			}

			// Token: 0x06002105 RID: 8453 RVA: 0x0007CB50 File Offset: 0x0007AD50
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _init_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEarnedSkirmishBadgePromptBehavior._init_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002106 RID: 8454 RVA: 0x0007CB98 File Offset: 0x0007AD98
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002107 RID: 8455 RVA: 0x0007CBCC File Offset: 0x0007ADCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698996, XrefRangeEnd = 699010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000919 RID: 2329
			// (get) Token: 0x06002108 RID: 8456 RVA: 0x0007CC08 File Offset: 0x0007AE08
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002109 RID: 8457 RVA: 0x0007CC48 File Offset: 0x0007AE48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 699010, XrefRangeEnd = 699015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700091A RID: 2330
			// (get) Token: 0x0600210A RID: 8458 RVA: 0x0007CC7C File Offset: 0x0007AE7C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600210B RID: 8459 RVA: 0x00012954 File Offset: 0x00010B54
			public _init_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000915 RID: 2325
			// (get) Token: 0x0600210C RID: 8460 RVA: 0x0007CCBC File Offset: 0x0007AEBC
			// (set) Token: 0x0600210D RID: 8461 RVA: 0x0001295D File Offset: 0x00010B5D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000916 RID: 2326
			// (get) Token: 0x0600210E RID: 8462 RVA: 0x0007CCE4 File Offset: 0x0007AEE4
			// (set) Token: 0x0600210F RID: 8463 RVA: 0x00012978 File Offset: 0x00010B78
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000917 RID: 2327
			// (get) Token: 0x06002110 RID: 8464 RVA: 0x0007CD14 File Offset: 0x0007AF14
			// (set) Token: 0x06002111 RID: 8465 RVA: 0x00012997 File Offset: 0x00010B97
			public unsafe WormEarnedSkirmishBadgePromptBehavior __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEarnedSkirmishBadgePromptBehavior>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000918 RID: 2328
			// (get) Token: 0x06002112 RID: 8466 RVA: 0x0007CD44 File Offset: 0x0007AF44
			// (set) Token: 0x06002113 RID: 8467 RVA: 0x000129B6 File Offset: 0x00010BB6
			public unsafe WormDailyChallengeProvider _provider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeFieldInfoPtr__provider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormDailyChallengeProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEarnedSkirmishBadgePromptBehavior._init_d__6.NativeFieldInfoPtr__provider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001306 RID: 4870
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001307 RID: 4871
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001308 RID: 4872
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001309 RID: 4873
			private static readonly IntPtr NativeFieldInfoPtr__provider_5__2;

			// Token: 0x0400130A RID: 4874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400130B RID: 4875
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400130C RID: 4876
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400130D RID: 4877
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400130E RID: 4878
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400130F RID: 4879
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
