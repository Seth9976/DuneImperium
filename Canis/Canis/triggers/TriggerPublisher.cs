using System;
using Canis.actions;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.triggers
{
	// Token: 0x02000044 RID: 68
	public class TriggerPublisher : Object
	{
		// Token: 0x06000452 RID: 1106 RVA: 0x0002ACD8 File Offset: 0x00028ED8
		// Note: this type is marked as 'beforefieldinit'.
		static TriggerPublisher()
		{
			Il2CppClassPointerStore<TriggerPublisher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.triggers", "TriggerPublisher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerPublisher>.NativeClassPtr);
			TriggerPublisher.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPublisher>.NativeClassPtr, "match");
			TriggerPublisher.NativeFieldInfoPtr_triggerMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPublisher>.NativeClassPtr, "triggerMap");
			TriggerPublisher.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher>.NativeClassPtr, 100664217);
			TriggerPublisher.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher>.NativeClassPtr, 100664218);
			TriggerPublisher.NativeMethodInfoPtr_AddSubscriber_Public_Void_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher>.NativeClassPtr, 100664219);
			TriggerPublisher.NativeMethodInfoPtr_updateAttribute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher>.NativeClassPtr, 100664220);
			TriggerPublisher.NativeMethodInfoPtr_addSubscriberInternal_Private_Void_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher>.NativeClassPtr, 100664221);
			TriggerPublisher.NativeMethodInfoPtr_RemoveSubscriber_Public_Void_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher>.NativeClassPtr, 100664222);
			TriggerPublisher.NativeMethodInfoPtr_OnTrigger_Public_IEnumerable_1_Action_Int32_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher>.NativeClassPtr, 100664223);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0002ADBC File Offset: 0x00028FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553329, XrefRangeEnd = 553338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TriggerPublisher(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerPublisher>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0002AE08 File Offset: 0x00029008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553338, XrefRangeEnd = 553371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0002AE3C File Offset: 0x0002903C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553371, XrefRangeEnd = 553373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSubscriber(Trigger trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher.NativeMethodInfoPtr_AddSubscriber_Public_Void_Trigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0002AE80 File Offset: 0x00029080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 553418, RefRangeEnd = 553420, XrefRangeStart = 553373, XrefRangeEnd = 553418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher.NativeMethodInfoPtr_updateAttribute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0002AEB4 File Offset: 0x000290B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 553442, RefRangeEnd = 553444, XrefRangeStart = 553420, XrefRangeEnd = 553442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void addSubscriberInternal(Trigger trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher.NativeMethodInfoPtr_addSubscriberInternal_Private_Void_Trigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0002AEF8 File Offset: 0x000290F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553444, XrefRangeEnd = 553451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSubscriber(Trigger trigger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher.NativeMethodInfoPtr_RemoveSubscriber_Public_Void_Trigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0002AF3C File Offset: 0x0002913C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553451, XrefRangeEnd = 553458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Canis.actions.Action> OnTrigger(int phase, Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref phase;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher.NativeMethodInfoPtr_OnTrigger_Public_IEnumerable_1_Action_Int32_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00003D45 File Offset: 0x00001F45
		public TriggerPublisher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0002AF9C File Offset: 0x0002919C
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00003D4E File Offset: 0x00001F4E
		public unsafe Match match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0002AFCC File Offset: 0x000291CC
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00003D6D File Offset: 0x00001F6D
		public unsafe Dictionary<int, List<Trigger>> triggerMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher.NativeFieldInfoPtr_triggerMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<Trigger>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher.NativeFieldInfoPtr_triggerMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr_triggerMap;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_AddSubscriber_Public_Void_Trigger_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_updateAttribute_Private_Void_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_addSubscriberInternal_Private_Void_Trigger_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSubscriber_Public_Void_Trigger_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_OnTrigger_Public_IEnumerable_1_Action_Int32_Context_0;

		// Token: 0x0200029E RID: 670
		[ObfuscatedName("Canis.triggers.TriggerPublisher+<OnTrigger>d__8")]
		public sealed class _OnTrigger_d__8 : Object
		{
			// Token: 0x06001C37 RID: 7223 RVA: 0x00086C04 File Offset: 0x00084E04
			// Note: this type is marked as 'beforefieldinit'.
			static _OnTrigger_d__8()
			{
				Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TriggerPublisher>.NativeClassPtr, "<OnTrigger>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr);
				TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, "<>1__state");
				TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, "<>2__current");
				TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, "<>l__initialThreadId");
				TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, "<>4__this");
				TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr_phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, "phase");
				TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___3__phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, "<>3__phase");
				TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, "context");
				TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___3__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, "<>3__context");
				TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, "<>7__wrap1");
				TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, "<>7__wrap2");
				TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, 100664224);
				TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, 100664225);
				TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, 100664226);
				TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, 100664227);
				TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, 100664228);
				TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, 100664229);
				TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, 100664230);
				TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, 100664231);
				TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, 100664232);
				TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr, 100664233);
			}

			// Token: 0x06001C38 RID: 7224 RVA: 0x00086DC0 File Offset: 0x00084FC0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnTrigger_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TriggerPublisher._OnTrigger_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C39 RID: 7225 RVA: 0x00086E08 File Offset: 0x00085008
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553262, XrefRangeEnd = 553275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C3A RID: 7226 RVA: 0x00086E3C File Offset: 0x0008503C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553275, XrefRangeEnd = 553309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001C3B RID: 7227 RVA: 0x00086E78 File Offset: 0x00085078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553309, XrefRangeEnd = 553312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C3C RID: 7228 RVA: 0x00086EAC File Offset: 0x000850AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553312, XrefRangeEnd = 553315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000688 RID: 1672
			// (get) Token: 0x06001C3D RID: 7229 RVA: 0x00086EE0 File Offset: 0x000850E0
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001C3E RID: 7230 RVA: 0x00086F20 File Offset: 0x00085120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553315, XrefRangeEnd = 553320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000689 RID: 1673
			// (get) Token: 0x06001C3F RID: 7231 RVA: 0x00086F54 File Offset: 0x00085154
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001C40 RID: 7232 RVA: 0x00086F94 File Offset: 0x00085194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553320, XrefRangeEnd = 553329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001C41 RID: 7233 RVA: 0x00086FD4 File Offset: 0x000851D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TriggerPublisher._OnTrigger_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001C42 RID: 7234 RVA: 0x0000D73E File Offset: 0x0000B93E
			public _OnTrigger_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700067E RID: 1662
			// (get) Token: 0x06001C43 RID: 7235 RVA: 0x00087014 File Offset: 0x00085214
			// (set) Token: 0x06001C44 RID: 7236 RVA: 0x0000D747 File Offset: 0x0000B947
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700067F RID: 1663
			// (get) Token: 0x06001C45 RID: 7237 RVA: 0x0008703C File Offset: 0x0008523C
			// (set) Token: 0x06001C46 RID: 7238 RVA: 0x0000D762 File Offset: 0x0000B962
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000680 RID: 1664
			// (get) Token: 0x06001C47 RID: 7239 RVA: 0x0008706C File Offset: 0x0008526C
			// (set) Token: 0x06001C48 RID: 7240 RVA: 0x0000D781 File Offset: 0x0000B981
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000681 RID: 1665
			// (get) Token: 0x06001C49 RID: 7241 RVA: 0x00087094 File Offset: 0x00085294
			// (set) Token: 0x06001C4A RID: 7242 RVA: 0x0000D79C File Offset: 0x0000B99C
			public unsafe TriggerPublisher __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TriggerPublisher>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000682 RID: 1666
			// (get) Token: 0x06001C4B RID: 7243 RVA: 0x000870C4 File Offset: 0x000852C4
			// (set) Token: 0x06001C4C RID: 7244 RVA: 0x0000D7BB File Offset: 0x0000B9BB
			public unsafe int phase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr_phase);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr_phase)) = value;
				}
			}

			// Token: 0x17000683 RID: 1667
			// (get) Token: 0x06001C4D RID: 7245 RVA: 0x000870EC File Offset: 0x000852EC
			// (set) Token: 0x06001C4E RID: 7246 RVA: 0x0000D7D6 File Offset: 0x0000B9D6
			public unsafe int __3__phase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___3__phase);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___3__phase)) = value;
				}
			}

			// Token: 0x17000684 RID: 1668
			// (get) Token: 0x06001C4F RID: 7247 RVA: 0x00087114 File Offset: 0x00085314
			// (set) Token: 0x06001C50 RID: 7248 RVA: 0x0000D7F1 File Offset: 0x0000B9F1
			public unsafe Context context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000685 RID: 1669
			// (get) Token: 0x06001C51 RID: 7249 RVA: 0x00087144 File Offset: 0x00085344
			// (set) Token: 0x06001C52 RID: 7250 RVA: 0x0000D810 File Offset: 0x0000BA10
			public unsafe Context __3__context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___3__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___3__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000686 RID: 1670
			// (get) Token: 0x06001C53 RID: 7251 RVA: 0x00087174 File Offset: 0x00085374
			// (set) Token: 0x06001C54 RID: 7252 RVA: 0x0000D82F File Offset: 0x0000BA2F
			public List<Trigger>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___7__wrap1);
					return new List<Trigger>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Trigger>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Trigger>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000687 RID: 1671
			// (get) Token: 0x06001C55 RID: 7253 RVA: 0x000871A4 File Offset: 0x000853A4
			// (set) Token: 0x06001C56 RID: 7254 RVA: 0x0000D85D File Offset: 0x0000BA5D
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TriggerPublisher._OnTrigger_d__8.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001201 RID: 4609
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001202 RID: 4610
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001203 RID: 4611
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001204 RID: 4612
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001205 RID: 4613
			private static readonly IntPtr NativeFieldInfoPtr_phase;

			// Token: 0x04001206 RID: 4614
			private static readonly IntPtr NativeFieldInfoPtr___3__phase;

			// Token: 0x04001207 RID: 4615
			private static readonly IntPtr NativeFieldInfoPtr_context;

			// Token: 0x04001208 RID: 4616
			private static readonly IntPtr NativeFieldInfoPtr___3__context;

			// Token: 0x04001209 RID: 4617
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400120A RID: 4618
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400120B RID: 4619
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400120C RID: 4620
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400120D RID: 4621
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400120E RID: 4622
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400120F RID: 4623
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001210 RID: 4624
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001211 RID: 4625
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001212 RID: 4626
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001213 RID: 4627
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001214 RID: 4628
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
