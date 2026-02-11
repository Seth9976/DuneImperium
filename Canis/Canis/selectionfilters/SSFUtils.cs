using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.selectionfilters
{
	// Token: 0x0200005C RID: 92
	public static class SSFUtils : Object
	{
		// Token: 0x06000552 RID: 1362 RVA: 0x0002DEE4 File Offset: 0x0002C0E4
		// Note: this type is marked as 'beforefieldinit'.
		static SSFUtils()
		{
			Il2CppClassPointerStore<SSFUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.selectionfilters", "SSFUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr);
			SSFUtils.NativeFieldInfoPtr_DefaultPredicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, "DefaultPredicate");
			SSFUtils.NativeMethodInfoPtr_And_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, 100664378);
			SSFUtils.NativeMethodInfoPtr_And_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_Func_2_NetworkMessageEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, 100664379);
			SSFUtils.NativeMethodInfoPtr_And_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, 100664380);
			SSFUtils.NativeMethodInfoPtr_And_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, 100664381);
			SSFUtils.NativeMethodInfoPtr_Or_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, 100664382);
			SSFUtils.NativeMethodInfoPtr_Or_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_Func_2_NetworkMessageEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, 100664383);
			SSFUtils.NativeMethodInfoPtr_Or_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, 100664384);
			SSFUtils.NativeMethodInfoPtr_Or_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, 100664385);
			SSFUtils.NativeMethodInfoPtr_MatchesTurn_Public_Static_Func_2_NetworkMessageEvent_Boolean_Match_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, 100664386);
			SSFUtils.NativeMethodInfoPtr_MatchesPrompt_Public_Static_Func_2_NetworkMessageEvent_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, 100664387);
			SSFUtils.NativeMethodInfoPtr_MatchesSource_Public_Static_Func_2_NetworkMessageEvent_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, 100664388);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0002E004 File Offset: 0x0002C204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554637, XrefRangeEnd = 554649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<NetworkMessageEvent, bool> And(this Func<bool> fst, Func<bool> snd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.NativeMethodInfoPtr_And_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_Func_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr3) : null;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0002E05C File Offset: 0x0002C25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554649, XrefRangeEnd = 554661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<NetworkMessageEvent, bool> And(this Func<bool> fst, Func<NetworkMessageEvent, bool> snd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.NativeMethodInfoPtr_And_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_Func_2_NetworkMessageEvent_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr3) : null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0002E0B4 File Offset: 0x0002C2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554661, XrefRangeEnd = 554673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<NetworkMessageEvent, bool> And(this Func<NetworkMessageEvent, bool> fst, Func<bool> snd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.NativeMethodInfoPtr_And_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr3) : null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0002E10C File Offset: 0x0002C30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554673, XrefRangeEnd = 554685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<NetworkMessageEvent, bool> And(this Func<NetworkMessageEvent, bool> fst, Func<NetworkMessageEvent, bool> snd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.NativeMethodInfoPtr_And_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr3) : null;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0002E164 File Offset: 0x0002C364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554685, XrefRangeEnd = 554697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<NetworkMessageEvent, bool> Or(this Func<bool> fst, Func<bool> snd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.NativeMethodInfoPtr_Or_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_Func_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr3) : null;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0002E1BC File Offset: 0x0002C3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554697, XrefRangeEnd = 554709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<NetworkMessageEvent, bool> Or(this Func<bool> fst, Func<NetworkMessageEvent, bool> snd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.NativeMethodInfoPtr_Or_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_Func_2_NetworkMessageEvent_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr3) : null;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0002E214 File Offset: 0x0002C414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554709, XrefRangeEnd = 554721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<NetworkMessageEvent, bool> Or(this Func<NetworkMessageEvent, bool> fst, Func<bool> snd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.NativeMethodInfoPtr_Or_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr3) : null;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0002E26C File Offset: 0x0002C46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554721, XrefRangeEnd = 554733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<NetworkMessageEvent, bool> Or(this Func<NetworkMessageEvent, bool> fst, Func<NetworkMessageEvent, bool> snd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fst);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(snd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.NativeMethodInfoPtr_Or_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr3) : null;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0002E2C4 File Offset: 0x0002C4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554733, XrefRangeEnd = 554744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<NetworkMessageEvent, bool> MatchesTurn(Match match, Nullable<int> turn)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(turn));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.NativeMethodInfoPtr_MatchesTurn_Public_Static_Func_2_NetworkMessageEvent_Boolean_Match_Nullable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr3) : null;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0002E320 File Offset: 0x0002C520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554744, XrefRangeEnd = 554755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<NetworkMessageEvent, bool> MatchesPrompt(string prompt)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.NativeMethodInfoPtr_MatchesPrompt_Public_Static_Func_2_NetworkMessageEvent_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0002E364 File Offset: 0x0002C564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554755, XrefRangeEnd = 554766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<NetworkMessageEvent, bool> MatchesSource(EntityID source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.NativeMethodInfoPtr_MatchesSource_Public_Static_Func_2_NetworkMessageEvent_Boolean_EntityID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000458B File Offset: 0x0000278B
		public SSFUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0002E3A8 File Offset: 0x0002C5A8
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00004594 File Offset: 0x00002794
		public unsafe static Func<NetworkMessageEvent, bool> DefaultPredicate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SSFUtils.NativeFieldInfoPtr_DefaultPredicate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SSFUtils.NativeFieldInfoPtr_DefaultPredicate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr_DefaultPredicate;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_And_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_Func_1_Boolean_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_And_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_Func_2_NetworkMessageEvent_Boolean_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_And_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_And_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_Or_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_Func_1_Boolean_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_Or_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_Func_2_NetworkMessageEvent_Boolean_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_Or_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_Func_1_Boolean_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_Or_Public_Static_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_Func_2_NetworkMessageEvent_Boolean_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_MatchesTurn_Public_Static_Func_2_NetworkMessageEvent_Boolean_Match_Nullable_1_Int32_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_MatchesPrompt_Public_Static_Func_2_NetworkMessageEvent_Boolean_String_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_MatchesSource_Public_Static_Func_2_NetworkMessageEvent_Boolean_EntityID_0;

		// Token: 0x020002B1 RID: 689
		[ObfuscatedName("Canis.selectionfilters.SSFUtils+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D45 RID: 7493 RVA: 0x00089CC0 File Offset: 0x00087EC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SSFUtils.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSFUtils.__c>.NativeClassPtr);
				SSFUtils.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c>.NativeClassPtr, "<>9");
				SSFUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c>.NativeClassPtr, 100664391);
				SSFUtils.__c.NativeMethodInfoPtr___cctor_b__12_0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c>.NativeClassPtr, 100664392);
			}

			// Token: 0x06001D46 RID: 7494 RVA: 0x00089D28 File Offset: 0x00087F28
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSFUtils.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D47 RID: 7495 RVA: 0x00089D64 File Offset: 0x00087F64
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__12_0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c.NativeMethodInfoPtr___cctor_b__12_0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D48 RID: 7496 RVA: 0x0000E0AE File Offset: 0x0000C2AE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D5 RID: 1749
			// (get) Token: 0x06001D49 RID: 7497 RVA: 0x00089DB4 File Offset: 0x00087FB4
			// (set) Token: 0x06001D4A RID: 7498 RVA: 0x0000E0B7 File Offset: 0x0000C2B7
			public unsafe static SSFUtils.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SSFUtils.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SSFUtils.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SSFUtils.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400129C RID: 4764
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400129D RID: 4765
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400129E RID: 4766
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__12_0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002B2 RID: 690
		[ObfuscatedName("Canis.selectionfilters.SSFUtils+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06001D4B RID: 7499 RVA: 0x00089DDC File Offset: 0x00087FDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<SSFUtils.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass10_0>.NativeClassPtr);
				SSFUtils.__c__DisplayClass10_0.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass10_0>.NativeClassPtr, "prompt");
				SSFUtils.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass10_0>.NativeClassPtr, 100664393);
				SSFUtils.__c__DisplayClass10_0.NativeMethodInfoPtr__MatchesPrompt_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass10_0>.NativeClassPtr, 100664394);
			}

			// Token: 0x06001D4C RID: 7500 RVA: 0x00089E44 File Offset: 0x00088044
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D4D RID: 7501 RVA: 0x00089E80 File Offset: 0x00088080
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554622, XrefRangeEnd = 554629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MatchesPrompt_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass10_0.NativeMethodInfoPtr__MatchesPrompt_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D4E RID: 7502 RVA: 0x0000E0C9 File Offset: 0x0000C2C9
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D6 RID: 1750
			// (get) Token: 0x06001D4F RID: 7503 RVA: 0x00089ED0 File Offset: 0x000880D0
			// (set) Token: 0x06001D50 RID: 7504 RVA: 0x0000E0D2 File Offset: 0x0000C2D2
			public unsafe string prompt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass10_0.NativeFieldInfoPtr_prompt);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass10_0.NativeFieldInfoPtr_prompt), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400129F RID: 4767
			private static readonly IntPtr NativeFieldInfoPtr_prompt;

			// Token: 0x040012A0 RID: 4768
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012A1 RID: 4769
			private static readonly IntPtr NativeMethodInfoPtr__MatchesPrompt_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002B3 RID: 691
		[ObfuscatedName("Canis.selectionfilters.SSFUtils+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06001D51 RID: 7505 RVA: 0x00089EF8 File Offset: 0x000880F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<SSFUtils.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass11_0>.NativeClassPtr);
				SSFUtils.__c__DisplayClass11_0.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass11_0>.NativeClassPtr, "source");
				SSFUtils.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass11_0>.NativeClassPtr, 100664395);
				SSFUtils.__c__DisplayClass11_0.NativeMethodInfoPtr__MatchesSource_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass11_0>.NativeClassPtr, 100664396);
			}

			// Token: 0x06001D52 RID: 7506 RVA: 0x00089F60 File Offset: 0x00088160
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D53 RID: 7507 RVA: 0x00089F9C File Offset: 0x0008819C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554629, XrefRangeEnd = 554633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MatchesSource_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass11_0.NativeMethodInfoPtr__MatchesSource_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D54 RID: 7508 RVA: 0x0000E0F1 File Offset: 0x0000C2F1
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D7 RID: 1751
			// (get) Token: 0x06001D55 RID: 7509 RVA: 0x00089FEC File Offset: 0x000881EC
			// (set) Token: 0x06001D56 RID: 7510 RVA: 0x0000E0FA File Offset: 0x0000C2FA
			public unsafe EntityID source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass11_0.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass11_0.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012A2 RID: 4770
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x040012A3 RID: 4771
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012A4 RID: 4772
			private static readonly IntPtr NativeMethodInfoPtr__MatchesSource_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002B4 RID: 692
		[ObfuscatedName("Canis.selectionfilters.SSFUtils+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06001D57 RID: 7511 RVA: 0x0008A01C File Offset: 0x0008821C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<SSFUtils.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass1_0>.NativeClassPtr);
				SSFUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_fst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass1_0>.NativeClassPtr, "fst");
				SSFUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass1_0>.NativeClassPtr, "snd");
				SSFUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass1_0>.NativeClassPtr, 100664397);
				SSFUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__And_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass1_0>.NativeClassPtr, 100664398);
			}

			// Token: 0x06001D58 RID: 7512 RVA: 0x0008A098 File Offset: 0x00088298
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D59 RID: 7513 RVA: 0x0008A0D4 File Offset: 0x000882D4
			[CallerCount(0)]
			public unsafe bool _And_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass1_0.NativeMethodInfoPtr__And_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D5A RID: 7514 RVA: 0x0000E119 File Offset: 0x0000C319
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D8 RID: 1752
			// (get) Token: 0x06001D5B RID: 7515 RVA: 0x0008A124 File Offset: 0x00088324
			// (set) Token: 0x06001D5C RID: 7516 RVA: 0x0000E122 File Offset: 0x0000C322
			public unsafe Func<bool> fst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_fst);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_fst), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006D9 RID: 1753
			// (get) Token: 0x06001D5D RID: 7517 RVA: 0x0008A154 File Offset: 0x00088354
			// (set) Token: 0x06001D5E RID: 7518 RVA: 0x0000E141 File Offset: 0x0000C341
			public unsafe Func<bool> snd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_snd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass1_0.NativeFieldInfoPtr_snd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012A5 RID: 4773
			private static readonly IntPtr NativeFieldInfoPtr_fst;

			// Token: 0x040012A6 RID: 4774
			private static readonly IntPtr NativeFieldInfoPtr_snd;

			// Token: 0x040012A7 RID: 4775
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012A8 RID: 4776
			private static readonly IntPtr NativeMethodInfoPtr__And_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002B5 RID: 693
		[ObfuscatedName("Canis.selectionfilters.SSFUtils+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06001D5F RID: 7519 RVA: 0x0008A184 File Offset: 0x00088384
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<SSFUtils.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass2_0>.NativeClassPtr);
				SSFUtils.__c__DisplayClass2_0.NativeFieldInfoPtr_fst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass2_0>.NativeClassPtr, "fst");
				SSFUtils.__c__DisplayClass2_0.NativeFieldInfoPtr_snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass2_0>.NativeClassPtr, "snd");
				SSFUtils.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass2_0>.NativeClassPtr, 100664399);
				SSFUtils.__c__DisplayClass2_0.NativeMethodInfoPtr__And_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass2_0>.NativeClassPtr, 100664400);
			}

			// Token: 0x06001D60 RID: 7520 RVA: 0x0008A200 File Offset: 0x00088400
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D61 RID: 7521 RVA: 0x0008A23C File Offset: 0x0008843C
			[CallerCount(0)]
			public unsafe bool _And_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass2_0.NativeMethodInfoPtr__And_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D62 RID: 7522 RVA: 0x0000E160 File Offset: 0x0000C360
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006DA RID: 1754
			// (get) Token: 0x06001D63 RID: 7523 RVA: 0x0008A28C File Offset: 0x0008848C
			// (set) Token: 0x06001D64 RID: 7524 RVA: 0x0000E169 File Offset: 0x0000C369
			public unsafe Func<bool> fst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass2_0.NativeFieldInfoPtr_fst);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass2_0.NativeFieldInfoPtr_fst), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DB RID: 1755
			// (get) Token: 0x06001D65 RID: 7525 RVA: 0x0008A2BC File Offset: 0x000884BC
			// (set) Token: 0x06001D66 RID: 7526 RVA: 0x0000E188 File Offset: 0x0000C388
			public unsafe Func<NetworkMessageEvent, bool> snd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass2_0.NativeFieldInfoPtr_snd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass2_0.NativeFieldInfoPtr_snd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012A9 RID: 4777
			private static readonly IntPtr NativeFieldInfoPtr_fst;

			// Token: 0x040012AA RID: 4778
			private static readonly IntPtr NativeFieldInfoPtr_snd;

			// Token: 0x040012AB RID: 4779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012AC RID: 4780
			private static readonly IntPtr NativeMethodInfoPtr__And_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002B6 RID: 694
		[ObfuscatedName("Canis.selectionfilters.SSFUtils+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06001D67 RID: 7527 RVA: 0x0008A2EC File Offset: 0x000884EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<SSFUtils.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass3_0>.NativeClassPtr);
				SSFUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_fst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass3_0>.NativeClassPtr, "fst");
				SSFUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass3_0>.NativeClassPtr, "snd");
				SSFUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass3_0>.NativeClassPtr, 100664401);
				SSFUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__And_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass3_0>.NativeClassPtr, 100664402);
			}

			// Token: 0x06001D68 RID: 7528 RVA: 0x0008A368 File Offset: 0x00088568
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D69 RID: 7529 RVA: 0x0008A3A4 File Offset: 0x000885A4
			[CallerCount(0)]
			public unsafe bool _And_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass3_0.NativeMethodInfoPtr__And_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D6A RID: 7530 RVA: 0x0000E1A7 File Offset: 0x0000C3A7
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006DC RID: 1756
			// (get) Token: 0x06001D6B RID: 7531 RVA: 0x0008A3F4 File Offset: 0x000885F4
			// (set) Token: 0x06001D6C RID: 7532 RVA: 0x0000E1B0 File Offset: 0x0000C3B0
			public unsafe Func<NetworkMessageEvent, bool> fst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_fst);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_fst), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DD RID: 1757
			// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0008A424 File Offset: 0x00088624
			// (set) Token: 0x06001D6E RID: 7534 RVA: 0x0000E1CF File Offset: 0x0000C3CF
			public unsafe Func<bool> snd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_snd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass3_0.NativeFieldInfoPtr_snd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012AD RID: 4781
			private static readonly IntPtr NativeFieldInfoPtr_fst;

			// Token: 0x040012AE RID: 4782
			private static readonly IntPtr NativeFieldInfoPtr_snd;

			// Token: 0x040012AF RID: 4783
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012B0 RID: 4784
			private static readonly IntPtr NativeMethodInfoPtr__And_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002B7 RID: 695
		[ObfuscatedName("Canis.selectionfilters.SSFUtils+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06001D6F RID: 7535 RVA: 0x0008A454 File Offset: 0x00088654
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<SSFUtils.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass4_0>.NativeClassPtr);
				SSFUtils.__c__DisplayClass4_0.NativeFieldInfoPtr_fst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass4_0>.NativeClassPtr, "fst");
				SSFUtils.__c__DisplayClass4_0.NativeFieldInfoPtr_snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass4_0>.NativeClassPtr, "snd");
				SSFUtils.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass4_0>.NativeClassPtr, 100664403);
				SSFUtils.__c__DisplayClass4_0.NativeMethodInfoPtr__And_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass4_0>.NativeClassPtr, 100664404);
			}

			// Token: 0x06001D70 RID: 7536 RVA: 0x0008A4D0 File Offset: 0x000886D0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D71 RID: 7537 RVA: 0x0008A50C File Offset: 0x0008870C
			[CallerCount(0)]
			public unsafe bool _And_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass4_0.NativeMethodInfoPtr__And_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D72 RID: 7538 RVA: 0x0000E1EE File Offset: 0x0000C3EE
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006DE RID: 1758
			// (get) Token: 0x06001D73 RID: 7539 RVA: 0x0008A55C File Offset: 0x0008875C
			// (set) Token: 0x06001D74 RID: 7540 RVA: 0x0000E1F7 File Offset: 0x0000C3F7
			public unsafe Func<NetworkMessageEvent, bool> fst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass4_0.NativeFieldInfoPtr_fst);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass4_0.NativeFieldInfoPtr_fst), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DF RID: 1759
			// (get) Token: 0x06001D75 RID: 7541 RVA: 0x0008A58C File Offset: 0x0008878C
			// (set) Token: 0x06001D76 RID: 7542 RVA: 0x0000E216 File Offset: 0x0000C416
			public unsafe Func<NetworkMessageEvent, bool> snd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass4_0.NativeFieldInfoPtr_snd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass4_0.NativeFieldInfoPtr_snd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012B1 RID: 4785
			private static readonly IntPtr NativeFieldInfoPtr_fst;

			// Token: 0x040012B2 RID: 4786
			private static readonly IntPtr NativeFieldInfoPtr_snd;

			// Token: 0x040012B3 RID: 4787
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012B4 RID: 4788
			private static readonly IntPtr NativeMethodInfoPtr__And_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002B8 RID: 696
		[ObfuscatedName("Canis.selectionfilters.SSFUtils+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06001D77 RID: 7543 RVA: 0x0008A5BC File Offset: 0x000887BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<SSFUtils.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass5_0>.NativeClassPtr);
				SSFUtils.__c__DisplayClass5_0.NativeFieldInfoPtr_fst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass5_0>.NativeClassPtr, "fst");
				SSFUtils.__c__DisplayClass5_0.NativeFieldInfoPtr_snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass5_0>.NativeClassPtr, "snd");
				SSFUtils.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass5_0>.NativeClassPtr, 100664405);
				SSFUtils.__c__DisplayClass5_0.NativeMethodInfoPtr__Or_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass5_0>.NativeClassPtr, 100664406);
			}

			// Token: 0x06001D78 RID: 7544 RVA: 0x0008A638 File Offset: 0x00088838
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D79 RID: 7545 RVA: 0x0008A674 File Offset: 0x00088874
			[CallerCount(0)]
			public unsafe bool _Or_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass5_0.NativeMethodInfoPtr__Or_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D7A RID: 7546 RVA: 0x0000E235 File Offset: 0x0000C435
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E0 RID: 1760
			// (get) Token: 0x06001D7B RID: 7547 RVA: 0x0008A6C4 File Offset: 0x000888C4
			// (set) Token: 0x06001D7C RID: 7548 RVA: 0x0000E23E File Offset: 0x0000C43E
			public unsafe Func<bool> fst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass5_0.NativeFieldInfoPtr_fst);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass5_0.NativeFieldInfoPtr_fst), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E1 RID: 1761
			// (get) Token: 0x06001D7D RID: 7549 RVA: 0x0008A6F4 File Offset: 0x000888F4
			// (set) Token: 0x06001D7E RID: 7550 RVA: 0x0000E25D File Offset: 0x0000C45D
			public unsafe Func<bool> snd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass5_0.NativeFieldInfoPtr_snd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass5_0.NativeFieldInfoPtr_snd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012B5 RID: 4789
			private static readonly IntPtr NativeFieldInfoPtr_fst;

			// Token: 0x040012B6 RID: 4790
			private static readonly IntPtr NativeFieldInfoPtr_snd;

			// Token: 0x040012B7 RID: 4791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012B8 RID: 4792
			private static readonly IntPtr NativeMethodInfoPtr__Or_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002B9 RID: 697
		[ObfuscatedName("Canis.selectionfilters.SSFUtils+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06001D7F RID: 7551 RVA: 0x0008A724 File Offset: 0x00088924
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<SSFUtils.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass6_0>.NativeClassPtr);
				SSFUtils.__c__DisplayClass6_0.NativeFieldInfoPtr_fst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass6_0>.NativeClassPtr, "fst");
				SSFUtils.__c__DisplayClass6_0.NativeFieldInfoPtr_snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass6_0>.NativeClassPtr, "snd");
				SSFUtils.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass6_0>.NativeClassPtr, 100664407);
				SSFUtils.__c__DisplayClass6_0.NativeMethodInfoPtr__Or_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass6_0>.NativeClassPtr, 100664408);
			}

			// Token: 0x06001D80 RID: 7552 RVA: 0x0008A7A0 File Offset: 0x000889A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D81 RID: 7553 RVA: 0x0008A7DC File Offset: 0x000889DC
			[CallerCount(0)]
			public unsafe bool _Or_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass6_0.NativeMethodInfoPtr__Or_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D82 RID: 7554 RVA: 0x0000E27C File Offset: 0x0000C47C
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E2 RID: 1762
			// (get) Token: 0x06001D83 RID: 7555 RVA: 0x0008A82C File Offset: 0x00088A2C
			// (set) Token: 0x06001D84 RID: 7556 RVA: 0x0000E285 File Offset: 0x0000C485
			public unsafe Func<bool> fst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass6_0.NativeFieldInfoPtr_fst);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass6_0.NativeFieldInfoPtr_fst), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E3 RID: 1763
			// (get) Token: 0x06001D85 RID: 7557 RVA: 0x0008A85C File Offset: 0x00088A5C
			// (set) Token: 0x06001D86 RID: 7558 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
			public unsafe Func<NetworkMessageEvent, bool> snd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass6_0.NativeFieldInfoPtr_snd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass6_0.NativeFieldInfoPtr_snd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012B9 RID: 4793
			private static readonly IntPtr NativeFieldInfoPtr_fst;

			// Token: 0x040012BA RID: 4794
			private static readonly IntPtr NativeFieldInfoPtr_snd;

			// Token: 0x040012BB RID: 4795
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012BC RID: 4796
			private static readonly IntPtr NativeMethodInfoPtr__Or_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002BA RID: 698
		[ObfuscatedName("Canis.selectionfilters.SSFUtils+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06001D87 RID: 7559 RVA: 0x0008A88C File Offset: 0x00088A8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<SSFUtils.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass7_0>.NativeClassPtr);
				SSFUtils.__c__DisplayClass7_0.NativeFieldInfoPtr_fst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass7_0>.NativeClassPtr, "fst");
				SSFUtils.__c__DisplayClass7_0.NativeFieldInfoPtr_snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass7_0>.NativeClassPtr, "snd");
				SSFUtils.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass7_0>.NativeClassPtr, 100664409);
				SSFUtils.__c__DisplayClass7_0.NativeMethodInfoPtr__Or_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass7_0>.NativeClassPtr, 100664410);
			}

			// Token: 0x06001D88 RID: 7560 RVA: 0x0008A908 File Offset: 0x00088B08
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D89 RID: 7561 RVA: 0x0008A944 File Offset: 0x00088B44
			[CallerCount(0)]
			public unsafe bool _Or_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass7_0.NativeMethodInfoPtr__Or_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D8A RID: 7562 RVA: 0x0000E2C3 File Offset: 0x0000C4C3
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E4 RID: 1764
			// (get) Token: 0x06001D8B RID: 7563 RVA: 0x0008A994 File Offset: 0x00088B94
			// (set) Token: 0x06001D8C RID: 7564 RVA: 0x0000E2CC File Offset: 0x0000C4CC
			public unsafe Func<NetworkMessageEvent, bool> fst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass7_0.NativeFieldInfoPtr_fst);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass7_0.NativeFieldInfoPtr_fst), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E5 RID: 1765
			// (get) Token: 0x06001D8D RID: 7565 RVA: 0x0008A9C4 File Offset: 0x00088BC4
			// (set) Token: 0x06001D8E RID: 7566 RVA: 0x0000E2EB File Offset: 0x0000C4EB
			public unsafe Func<bool> snd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass7_0.NativeFieldInfoPtr_snd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass7_0.NativeFieldInfoPtr_snd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012BD RID: 4797
			private static readonly IntPtr NativeFieldInfoPtr_fst;

			// Token: 0x040012BE RID: 4798
			private static readonly IntPtr NativeFieldInfoPtr_snd;

			// Token: 0x040012BF RID: 4799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012C0 RID: 4800
			private static readonly IntPtr NativeMethodInfoPtr__Or_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002BB RID: 699
		[ObfuscatedName("Canis.selectionfilters.SSFUtils+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06001D8F RID: 7567 RVA: 0x0008A9F4 File Offset: 0x00088BF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<SSFUtils.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass8_0>.NativeClassPtr);
				SSFUtils.__c__DisplayClass8_0.NativeFieldInfoPtr_fst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass8_0>.NativeClassPtr, "fst");
				SSFUtils.__c__DisplayClass8_0.NativeFieldInfoPtr_snd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass8_0>.NativeClassPtr, "snd");
				SSFUtils.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass8_0>.NativeClassPtr, 100664411);
				SSFUtils.__c__DisplayClass8_0.NativeMethodInfoPtr__Or_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass8_0>.NativeClassPtr, 100664412);
			}

			// Token: 0x06001D90 RID: 7568 RVA: 0x0008AA70 File Offset: 0x00088C70
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D91 RID: 7569 RVA: 0x0008AAAC File Offset: 0x00088CAC
			[CallerCount(0)]
			public unsafe bool _Or_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass8_0.NativeMethodInfoPtr__Or_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D92 RID: 7570 RVA: 0x0000E30A File Offset: 0x0000C50A
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E6 RID: 1766
			// (get) Token: 0x06001D93 RID: 7571 RVA: 0x0008AAFC File Offset: 0x00088CFC
			// (set) Token: 0x06001D94 RID: 7572 RVA: 0x0000E313 File Offset: 0x0000C513
			public unsafe Func<NetworkMessageEvent, bool> fst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass8_0.NativeFieldInfoPtr_fst);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass8_0.NativeFieldInfoPtr_fst), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E7 RID: 1767
			// (get) Token: 0x06001D95 RID: 7573 RVA: 0x0008AB2C File Offset: 0x00088D2C
			// (set) Token: 0x06001D96 RID: 7574 RVA: 0x0000E332 File Offset: 0x0000C532
			public unsafe Func<NetworkMessageEvent, bool> snd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass8_0.NativeFieldInfoPtr_snd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NetworkMessageEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass8_0.NativeFieldInfoPtr_snd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012C1 RID: 4801
			private static readonly IntPtr NativeFieldInfoPtr_fst;

			// Token: 0x040012C2 RID: 4802
			private static readonly IntPtr NativeFieldInfoPtr_snd;

			// Token: 0x040012C3 RID: 4803
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012C4 RID: 4804
			private static readonly IntPtr NativeMethodInfoPtr__Or_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}

		// Token: 0x020002BC RID: 700
		[ObfuscatedName("Canis.selectionfilters.SSFUtils+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Object
		{
			// Token: 0x06001D97 RID: 7575 RVA: 0x0008AB5C File Offset: 0x00088D5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<SSFUtils.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SSFUtils>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass9_0>.NativeClassPtr);
				SSFUtils.__c__DisplayClass9_0.NativeFieldInfoPtr_turn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass9_0>.NativeClassPtr, "turn");
				SSFUtils.__c__DisplayClass9_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass9_0>.NativeClassPtr, "match");
				SSFUtils.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass9_0>.NativeClassPtr, 100664413);
				SSFUtils.__c__DisplayClass9_0.NativeMethodInfoPtr__MatchesTurn_b__0_Internal_Boolean_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass9_0>.NativeClassPtr, 100664414);
			}

			// Token: 0x06001D98 RID: 7576 RVA: 0x0008ABD8 File Offset: 0x00088DD8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSFUtils.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D99 RID: 7577 RVA: 0x0008AC14 File Offset: 0x00088E14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554633, XrefRangeEnd = 554637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MatchesTurn_b__0(NetworkMessageEvent evt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SSFUtils.__c__DisplayClass9_0.NativeMethodInfoPtr__MatchesTurn_b__0_Internal_Boolean_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001D9A RID: 7578 RVA: 0x0000E351 File Offset: 0x0000C551
			public __c__DisplayClass9_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E8 RID: 1768
			// (get) Token: 0x06001D9B RID: 7579 RVA: 0x0008AC64 File Offset: 0x00088E64
			// (set) Token: 0x06001D9C RID: 7580 RVA: 0x0000E35A File Offset: 0x0000C55A
			public Nullable<int> turn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass9_0.NativeFieldInfoPtr_turn);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass9_0.NativeFieldInfoPtr_turn), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170006E9 RID: 1769
			// (get) Token: 0x06001D9D RID: 7581 RVA: 0x0008AC94 File Offset: 0x00088E94
			// (set) Token: 0x06001D9E RID: 7582 RVA: 0x0000E388 File Offset: 0x0000C588
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass9_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SSFUtils.__c__DisplayClass9_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012C5 RID: 4805
			private static readonly IntPtr NativeFieldInfoPtr_turn;

			// Token: 0x040012C6 RID: 4806
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x040012C7 RID: 4807
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012C8 RID: 4808
			private static readonly IntPtr NativeMethodInfoPtr__MatchesTurn_b__0_Internal_Boolean_NetworkMessageEvent_0;
		}
	}
}
