using System;
using boardgames.match.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000007 RID: 7
public class SkipReplayButtonBehaviour : MonoBehaviour
{
	// Token: 0x06000024 RID: 36 RVA: 0x0001DB40 File Offset: 0x0001BD40
	// Note: this type is marked as 'beforefieldinit'.
	static SkipReplayButtonBehaviour()
	{
		Il2CppClassPointerStore<SkipReplayButtonBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "SkipReplayButtonBehaviour");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkipReplayButtonBehaviour>.NativeClassPtr);
		SkipReplayButtonBehaviour.NativeFieldInfoPtr_onReplayFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipReplayButtonBehaviour>.NativeClassPtr, "onReplayFinished");
		SkipReplayButtonBehaviour.NativeFieldInfoPtr_startedFastForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipReplayButtonBehaviour>.NativeClassPtr, "startedFastForward");
		SkipReplayButtonBehaviour.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipReplayButtonBehaviour>.NativeClassPtr, 100663312);
		SkipReplayButtonBehaviour.NativeMethodInfoPtr_Event_FastForward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipReplayButtonBehaviour>.NativeClassPtr, 100663313);
		SkipReplayButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipReplayButtonBehaviour>.NativeClassPtr, 100663314);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x0001DBD4 File Offset: 0x0001BDD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494731, XrefRangeEnd = 494736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipReplayButtonBehaviour.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x0001DC14 File Offset: 0x0001BE14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494736, XrefRangeEnd = 494750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Event_FastForward()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipReplayButtonBehaviour.NativeMethodInfoPtr_Event_FastForward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x0001DC48 File Offset: 0x0001BE48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494750, XrefRangeEnd = 494756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkipReplayButtonBehaviour()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkipReplayButtonBehaviour>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipReplayButtonBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x0000210F File Offset: 0x0000030F
	public SkipReplayButtonBehaviour(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000029 RID: 41 RVA: 0x0001DC84 File Offset: 0x0001BE84
	// (set) Token: 0x0600002A RID: 42 RVA: 0x00002118 File Offset: 0x00000318
	public unsafe UnityEvent onReplayFinished
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipReplayButtonBehaviour.NativeFieldInfoPtr_onReplayFinished);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipReplayButtonBehaviour.NativeFieldInfoPtr_onReplayFinished), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600002B RID: 43 RVA: 0x0001DCB4 File Offset: 0x0001BEB4
	// (set) Token: 0x0600002C RID: 44 RVA: 0x00002137 File Offset: 0x00000337
	public unsafe bool startedFastForward
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipReplayButtonBehaviour.NativeFieldInfoPtr_startedFastForward);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipReplayButtonBehaviour.NativeFieldInfoPtr_startedFastForward)) = value;
		}
	}

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeFieldInfoPtr_onReplayFinished;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeFieldInfoPtr_startedFastForward;

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeMethodInfoPtr_Event_FastForward_Public_Void_0;

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002BF RID: 703
	[ObfuscatedName("SkipReplayButtonBehaviour+<Start>d__2")]
	public sealed class _Start_d__2 : global::Il2CppSystem.Object
	{
		// Token: 0x06002114 RID: 8468 RVA: 0x0008B770 File Offset: 0x00089970
		// Note: this type is marked as 'beforefieldinit'.
		static _Start_d__2()
		{
			Il2CppClassPointerStore<SkipReplayButtonBehaviour._Start_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SkipReplayButtonBehaviour>.NativeClassPtr, "<Start>d__2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkipReplayButtonBehaviour._Start_d__2>.NativeClassPtr);
			SkipReplayButtonBehaviour._Start_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipReplayButtonBehaviour._Start_d__2>.NativeClassPtr, "<>1__state");
			SkipReplayButtonBehaviour._Start_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipReplayButtonBehaviour._Start_d__2>.NativeClassPtr, "<>2__current");
			SkipReplayButtonBehaviour._Start_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipReplayButtonBehaviour._Start_d__2>.NativeClassPtr, "<>4__this");
			SkipReplayButtonBehaviour._Start_d__2.NativeFieldInfoPtr__hub_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkipReplayButtonBehaviour._Start_d__2>.NativeClassPtr, "<hub>5__2");
			SkipReplayButtonBehaviour._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipReplayButtonBehaviour._Start_d__2>.NativeClassPtr, 100663315);
			SkipReplayButtonBehaviour._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipReplayButtonBehaviour._Start_d__2>.NativeClassPtr, 100663316);
			SkipReplayButtonBehaviour._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipReplayButtonBehaviour._Start_d__2>.NativeClassPtr, 100663317);
			SkipReplayButtonBehaviour._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipReplayButtonBehaviour._Start_d__2>.NativeClassPtr, 100663318);
			SkipReplayButtonBehaviour._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipReplayButtonBehaviour._Start_d__2>.NativeClassPtr, 100663319);
			SkipReplayButtonBehaviour._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkipReplayButtonBehaviour._Start_d__2>.NativeClassPtr, 100663320);
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x0008B864 File Offset: 0x00089A64
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Start_d__2(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkipReplayButtonBehaviour._Start_d__2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipReplayButtonBehaviour._Start_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x0008B8AC File Offset: 0x00089AAC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipReplayButtonBehaviour._Start_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x0008B8E0 File Offset: 0x00089AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494722, XrefRangeEnd = 494726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipReplayButtonBehaviour._Start_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x0008B91C File Offset: 0x00089B1C
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipReplayButtonBehaviour._Start_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x0008B95C File Offset: 0x00089B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 494726, XrefRangeEnd = 494731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipReplayButtonBehaviour._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x0008B990 File Offset: 0x00089B90
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkipReplayButtonBehaviour._Start_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x000114A6 File Offset: 0x0000F6A6
		public _Start_d__2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x0008B9D0 File Offset: 0x00089BD0
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x000114AF File Offset: 0x0000F6AF
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipReplayButtonBehaviour._Start_d__2.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipReplayButtonBehaviour._Start_d__2.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x0008B9F8 File Offset: 0x00089BF8
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x000114CA File Offset: 0x0000F6CA
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipReplayButtonBehaviour._Start_d__2.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipReplayButtonBehaviour._Start_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x0008BA28 File Offset: 0x00089C28
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x000114E9 File Offset: 0x0000F6E9
		public unsafe SkipReplayButtonBehaviour __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipReplayButtonBehaviour._Start_d__2.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkipReplayButtonBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipReplayButtonBehaviour._Start_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x0008BA58 File Offset: 0x00089C58
		// (set) Token: 0x06002123 RID: 8483 RVA: 0x00011508 File Offset: 0x0000F708
		public unsafe DBGMatchHub _hub_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipReplayButtonBehaviour._Start_d__2.NativeFieldInfoPtr__hub_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchHub>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkipReplayButtonBehaviour._Start_d__2.NativeFieldInfoPtr__hub_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeFieldInfoPtr__hub_5__2;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
