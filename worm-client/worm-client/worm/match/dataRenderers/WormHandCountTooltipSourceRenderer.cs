using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000137 RID: 311
	public class WormHandCountTooltipSourceRenderer : MonoBehaviour
	{
		// Token: 0x06000E03 RID: 3587 RVA: 0x00042684 File Offset: 0x00040884
		// Note: this type is marked as 'beforefieldinit'.
		static WormHandCountTooltipSourceRenderer()
		{
			Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormHandCountTooltipSourceRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer>.NativeClassPtr);
			WormHandCountTooltipSourceRenderer.NativeFieldInfoPtr_revealedTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer>.NativeClassPtr, "revealedTooltip");
			WormHandCountTooltipSourceRenderer.NativeFieldInfoPtr_unrevealedTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer>.NativeClassPtr, "unrevealedTooltip");
			WormHandCountTooltipSourceRenderer.NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer>.NativeClassPtr, "model");
			WormHandCountTooltipSourceRenderer.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer>.NativeClassPtr, 100665193);
			WormHandCountTooltipSourceRenderer.NativeMethodInfoPtr_init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer>.NativeClassPtr, 100665194);
			WormHandCountTooltipSourceRenderer.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer>.NativeClassPtr, 100665195);
			WormHandCountTooltipSourceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer>.NativeClassPtr, 100665196);
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x00042740 File Offset: 0x00040940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706177, XrefRangeEnd = 706183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandCountTooltipSourceRenderer.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00042774 File Offset: 0x00040974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706183, XrefRangeEnd = 706188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandCountTooltipSourceRenderer.NativeMethodInfoPtr_init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x000427B4 File Offset: 0x000409B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706188, XrefRangeEnd = 706189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalizedTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandCountTooltipSourceRenderer.NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x000427EC File Offset: 0x000409EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706189, XrefRangeEnd = 706195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormHandCountTooltipSourceRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandCountTooltipSourceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00009610 File Offset: 0x00007810
		public WormHandCountTooltipSourceRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00042828 File Offset: 0x00040A28
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x00009619 File Offset: 0x00007819
		public unsafe string revealedTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer.NativeFieldInfoPtr_revealedTooltip);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer.NativeFieldInfoPtr_revealedTooltip), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x00042850 File Offset: 0x00040A50
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x00009638 File Offset: 0x00007838
		public unsafe string unrevealedTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer.NativeFieldInfoPtr_unrevealedTooltip);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer.NativeFieldInfoPtr_unrevealedTooltip), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00042878 File Offset: 0x00040A78
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00009657 File Offset: 0x00007857
		public unsafe WormHasRevealedData model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer.NativeFieldInfoPtr_model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormHasRevealedData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer.NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeFieldInfoPtr_revealedTooltip;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeFieldInfoPtr_unrevealedTooltip;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeFieldInfoPtr_model;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_init_Private_IEnumerator_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedTooltip_Public_Virtual_Final_New_String_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200038C RID: 908
		[ObfuscatedName("worm.match.dataRenderers.WormHandCountTooltipSourceRenderer+<init>d__4")]
		public sealed class _init_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x06002471 RID: 9329 RVA: 0x000864F8 File Offset: 0x000846F8
			// Note: this type is marked as 'beforefieldinit'.
			static _init_d__4()
			{
				Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer._init_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer>.NativeClassPtr, "<init>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer._init_d__4>.NativeClassPtr);
				WormHandCountTooltipSourceRenderer._init_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer._init_d__4>.NativeClassPtr, "<>1__state");
				WormHandCountTooltipSourceRenderer._init_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer._init_d__4>.NativeClassPtr, "<>2__current");
				WormHandCountTooltipSourceRenderer._init_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer._init_d__4>.NativeClassPtr, "<>4__this");
				WormHandCountTooltipSourceRenderer._init_d__4.NativeFieldInfoPtr__parent_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer._init_d__4>.NativeClassPtr, "<parent>5__2");
				WormHandCountTooltipSourceRenderer._init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer._init_d__4>.NativeClassPtr, 100665197);
				WormHandCountTooltipSourceRenderer._init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer._init_d__4>.NativeClassPtr, 100665198);
				WormHandCountTooltipSourceRenderer._init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer._init_d__4>.NativeClassPtr, 100665199);
				WormHandCountTooltipSourceRenderer._init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer._init_d__4>.NativeClassPtr, 100665200);
				WormHandCountTooltipSourceRenderer._init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer._init_d__4>.NativeClassPtr, 100665201);
				WormHandCountTooltipSourceRenderer._init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer._init_d__4>.NativeClassPtr, 100665202);
			}

			// Token: 0x06002472 RID: 9330 RVA: 0x000865EC File Offset: 0x000847EC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _init_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormHandCountTooltipSourceRenderer._init_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandCountTooltipSourceRenderer._init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002473 RID: 9331 RVA: 0x00086634 File Offset: 0x00084834
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandCountTooltipSourceRenderer._init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002474 RID: 9332 RVA: 0x00086668 File Offset: 0x00084868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706163, XrefRangeEnd = 706172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandCountTooltipSourceRenderer._init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A1A RID: 2586
			// (get) Token: 0x06002475 RID: 9333 RVA: 0x000866A4 File Offset: 0x000848A4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandCountTooltipSourceRenderer._init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002476 RID: 9334 RVA: 0x000866E4 File Offset: 0x000848E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706172, XrefRangeEnd = 706177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandCountTooltipSourceRenderer._init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A1B RID: 2587
			// (get) Token: 0x06002477 RID: 9335 RVA: 0x00086718 File Offset: 0x00084918
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormHandCountTooltipSourceRenderer._init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002478 RID: 9336 RVA: 0x00014569 File Offset: 0x00012769
			public _init_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A16 RID: 2582
			// (get) Token: 0x06002479 RID: 9337 RVA: 0x00086758 File Offset: 0x00084958
			// (set) Token: 0x0600247A RID: 9338 RVA: 0x00014572 File Offset: 0x00012772
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer._init_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer._init_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A17 RID: 2583
			// (get) Token: 0x0600247B RID: 9339 RVA: 0x00086780 File Offset: 0x00084980
			// (set) Token: 0x0600247C RID: 9340 RVA: 0x0001458D File Offset: 0x0001278D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer._init_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer._init_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A18 RID: 2584
			// (get) Token: 0x0600247D RID: 9341 RVA: 0x000867B0 File Offset: 0x000849B0
			// (set) Token: 0x0600247E RID: 9342 RVA: 0x000145AC File Offset: 0x000127AC
			public unsafe WormHandCountTooltipSourceRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer._init_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormHandCountTooltipSourceRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer._init_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A19 RID: 2585
			// (get) Token: 0x0600247F RID: 9343 RVA: 0x000867E0 File Offset: 0x000849E0
			// (set) Token: 0x06002480 RID: 9344 RVA: 0x000145CB File Offset: 0x000127CB
			public unsafe EntityView _parent_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer._init_d__4.NativeFieldInfoPtr__parent_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormHandCountTooltipSourceRenderer._init_d__4.NativeFieldInfoPtr__parent_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014E7 RID: 5351
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014E8 RID: 5352
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040014E9 RID: 5353
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014EA RID: 5354
			private static readonly IntPtr NativeFieldInfoPtr__parent_5__2;

			// Token: 0x040014EB RID: 5355
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040014EC RID: 5356
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014ED RID: 5357
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040014EE RID: 5358
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040014EF RID: 5359
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014F0 RID: 5360
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
