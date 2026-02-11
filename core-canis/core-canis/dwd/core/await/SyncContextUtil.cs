using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace dwd.core.await
{
	// Token: 0x02000209 RID: 521
	public static class SyncContextUtil : Object
	{
		// Token: 0x06001CC3 RID: 7363 RVA: 0x000859AC File Offset: 0x00083BAC
		// Note: this type is marked as 'beforefieldinit'.
		static SyncContextUtil()
		{
			Il2CppClassPointerStore<SyncContextUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.await", "SyncContextUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncContextUtil>.NativeClassPtr);
			SyncContextUtil.NativeFieldInfoPtr__UnitySynchronizationContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncContextUtil>.NativeClassPtr, "<UnitySynchronizationContext>k__BackingField");
			SyncContextUtil.NativeFieldInfoPtr__UnityThreadId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncContextUtil>.NativeClassPtr, "<UnityThreadId>k__BackingField");
			SyncContextUtil.NativeMethodInfoPtr_get_UnitySynchronizationContext_Public_Static_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncContextUtil>.NativeClassPtr, 100667924);
			SyncContextUtil.NativeMethodInfoPtr_set_UnitySynchronizationContext_Private_Static_set_Void_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncContextUtil>.NativeClassPtr, 100667925);
			SyncContextUtil.NativeMethodInfoPtr_get_UnityThreadId_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncContextUtil>.NativeClassPtr, 100667926);
			SyncContextUtil.NativeMethodInfoPtr_set_UnityThreadId_Private_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncContextUtil>.NativeClassPtr, 100667927);
			SyncContextUtil.NativeMethodInfoPtr_RunOnUnityScheduler_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncContextUtil>.NativeClassPtr, 100667928);
			SyncContextUtil.NativeMethodInfoPtr_Install_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncContextUtil>.NativeClassPtr, 100667929);
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00085A7C File Offset: 0x00083C7C
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x00085AB0 File Offset: 0x00083CB0
		public unsafe static SynchronizationContext UnitySynchronizationContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885929, XrefRangeEnd = 885931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncContextUtil.NativeMethodInfoPtr_get_UnitySynchronizationContext_Public_Static_get_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885931, XrefRangeEnd = 885935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncContextUtil.NativeMethodInfoPtr_set_UnitySynchronizationContext_Private_Static_set_Void_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x00085AE8 File Offset: 0x00083CE8
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x00085B18 File Offset: 0x00083D18
		public unsafe static int UnityThreadId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885935, XrefRangeEnd = 885937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncContextUtil.NativeMethodInfoPtr_get_UnityThreadId_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885937, XrefRangeEnd = 885939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncContextUtil.NativeMethodInfoPtr_set_UnityThreadId_Private_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x00085B4C File Offset: 0x00083D4C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 885956, RefRangeEnd = 885966, XrefRangeStart = 885939, XrefRangeEnd = 885956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunOnUnityScheduler(Action action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncContextUtil.NativeMethodInfoPtr_RunOnUnityScheduler_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x00085B84 File Offset: 0x00083D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885966, XrefRangeEnd = 885975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Install()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncContextUtil.NativeMethodInfoPtr_Install_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x0000C52B File Offset: 0x0000A72B
		public SyncContextUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001CCB RID: 7371 RVA: 0x00085BAC File Offset: 0x00083DAC
		// (set) Token: 0x06001CCC RID: 7372 RVA: 0x0000C534 File Offset: 0x0000A734
		public unsafe static SynchronizationContext _UnitySynchronizationContext_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SyncContextUtil.NativeFieldInfoPtr__UnitySynchronizationContext_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SyncContextUtil.NativeFieldInfoPtr__UnitySynchronizationContext_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001CCD RID: 7373 RVA: 0x00085BD4 File Offset: 0x00083DD4
		// (set) Token: 0x06001CCE RID: 7374 RVA: 0x0000C546 File Offset: 0x0000A746
		public unsafe static int _UnityThreadId_k__BackingField
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(SyncContextUtil.NativeFieldInfoPtr__UnityThreadId_k__BackingField, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SyncContextUtil.NativeFieldInfoPtr__UnityThreadId_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeFieldInfoPtr__UnitySynchronizationContext_k__BackingField;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeFieldInfoPtr__UnityThreadId_k__BackingField;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeMethodInfoPtr_get_UnitySynchronizationContext_Public_Static_get_SynchronizationContext_0;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_set_UnitySynchronizationContext_Private_Static_set_Void_SynchronizationContext_0;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr_get_UnityThreadId_Public_Static_get_Int32_0;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeMethodInfoPtr_set_UnityThreadId_Private_Static_set_Void_Int32_0;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr_RunOnUnityScheduler_Public_Static_Void_Action_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_Install_Private_Static_Void_0;

		// Token: 0x0200039C RID: 924
		[ObfuscatedName("dwd.core.await.SyncContextUtil+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06002935 RID: 10549 RVA: 0x000AD058 File Offset: 0x000AB258
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<SyncContextUtil.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SyncContextUtil>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncContextUtil.__c__DisplayClass8_0>.NativeClassPtr);
				SyncContextUtil.__c__DisplayClass8_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncContextUtil.__c__DisplayClass8_0>.NativeClassPtr, "action");
				SyncContextUtil.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncContextUtil.__c__DisplayClass8_0>.NativeClassPtr, 100667930);
				SyncContextUtil.__c__DisplayClass8_0.NativeMethodInfoPtr__RunOnUnityScheduler_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncContextUtil.__c__DisplayClass8_0>.NativeClassPtr, 100667931);
			}

			// Token: 0x06002936 RID: 10550 RVA: 0x000AD0C0 File Offset: 0x000AB2C0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SyncContextUtil.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncContextUtil.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002937 RID: 10551 RVA: 0x000AD0FC File Offset: 0x000AB2FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885928, XrefRangeEnd = 885929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RunOnUnityScheduler_b__0(Object _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SyncContextUtil.__c__DisplayClass8_0.NativeMethodInfoPtr__RunOnUnityScheduler_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002938 RID: 10552 RVA: 0x00012BBB File Offset: 0x00010DBB
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BB0 RID: 2992
			// (get) Token: 0x06002939 RID: 10553 RVA: 0x000AD140 File Offset: 0x000AB340
			// (set) Token: 0x0600293A RID: 10554 RVA: 0x00012BC4 File Offset: 0x00010DC4
			public unsafe Action action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyncContextUtil.__c__DisplayClass8_0.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SyncContextUtil.__c__DisplayClass8_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BE1 RID: 7137
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04001BE2 RID: 7138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BE3 RID: 7139
			private static readonly IntPtr NativeMethodInfoPtr__RunOnUnityScheduler_b__0_Internal_Void_Object_0;
		}
	}
}
