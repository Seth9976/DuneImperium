using System;
using Canis.entities;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001F8 RID: 504
	public class ObfuscatedMessageActionFactory : Object
	{
		// Token: 0x0600155C RID: 5468 RVA: 0x0006FA78 File Offset: 0x0006DC78
		// Note: this type is marked as 'beforefieldinit'.
		static ObfuscatedMessageActionFactory()
		{
			Il2CppClassPointerStore<ObfuscatedMessageActionFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "ObfuscatedMessageActionFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObfuscatedMessageActionFactory>.NativeClassPtr);
			ObfuscatedMessageActionFactory.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_Action_NetworkMessageEvent_Match_PlayerEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscatedMessageActionFactory>.NativeClassPtr, 100668107);
			ObfuscatedMessageActionFactory.NativeMethodInfoPtr_CreateMsgs_Private_IEnumerable_1_ValueTuple_2_NetworkMessageEvent_PlayerEntity_NetworkMessageEvent_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscatedMessageActionFactory>.NativeClassPtr, 100668108);
			ObfuscatedMessageActionFactory.NativeMethodInfoPtr_Obfuscate_Private_IEnumerable_1_NetworkMessageEvent_NetworkMessageEvent_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscatedMessageActionFactory>.NativeClassPtr, 100668109);
			ObfuscatedMessageActionFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscatedMessageActionFactory>.NativeClassPtr, 100668110);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x0006FAF8 File Offset: 0x0006DCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591023, XrefRangeEnd = 591054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Action Create(NetworkMessageEvent message, Match m, PlayerEntity player, bool waitForResponse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitForResponse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscatedMessageActionFactory.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_Action_NetworkMessageEvent_Match_PlayerEntity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x0006FB7C File Offset: 0x0006DD7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 591079, RefRangeEnd = 591081, XrefRangeStart = 591054, XrefRangeEnd = 591079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<NetworkMessageEvent, PlayerEntity>> CreateMsgs(NetworkMessageEvent message, Match m, PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscatedMessageActionFactory.NativeMethodInfoPtr_CreateMsgs_Private_IEnumerable_1_ValueTuple_2_NetworkMessageEvent_PlayerEntity_NetworkMessageEvent_Match_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<NetworkMessageEvent, PlayerEntity>>>(intPtr3) : null;
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x0006FBF0 File Offset: 0x0006DDF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 591160, RefRangeEnd = 591161, XrefRangeStart = 591081, XrefRangeEnd = 591160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<NetworkMessageEvent> Obfuscate(NetworkMessageEvent message, Match m, PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscatedMessageActionFactory.NativeMethodInfoPtr_Obfuscate_Private_IEnumerable_1_NetworkMessageEvent_NetworkMessageEvent_Match_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<NetworkMessageEvent>>(intPtr3) : null;
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x0006FC64 File Offset: 0x0006DE64
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObfuscatedMessageActionFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObfuscatedMessageActionFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscatedMessageActionFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x0000A4ED File Offset: 0x000086ED
		public ObfuscatedMessageActionFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Final_New_Action_NetworkMessageEvent_Match_PlayerEntity_Boolean_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_CreateMsgs_Private_IEnumerable_1_ValueTuple_2_NetworkMessageEvent_PlayerEntity_NetworkMessageEvent_Match_PlayerEntity_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_Obfuscate_Private_IEnumerable_1_NetworkMessageEvent_NetworkMessageEvent_Match_PlayerEntity_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000442 RID: 1090
		[ObfuscatedName("Canis.actions.ObfuscatedMessageActionFactory+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002FFE RID: 12286 RVA: 0x000C7E10 File Offset: 0x000C6010
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObfuscatedMessageActionFactory>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c>.NativeClassPtr);
				ObfuscatedMessageActionFactory.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c>.NativeClassPtr, "<>9");
				ObfuscatedMessageActionFactory.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c>.NativeClassPtr, "<>9__1_0");
				ObfuscatedMessageActionFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c>.NativeClassPtr, 100668112);
				ObfuscatedMessageActionFactory.__c.NativeMethodInfoPtr__CreateMsgs_b__1_0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c>.NativeClassPtr, 100668113);
			}

			// Token: 0x06002FFF RID: 12287 RVA: 0x000C7E8C File Offset: 0x000C608C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscatedMessageActionFactory.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003000 RID: 12288 RVA: 0x000C7EC8 File Offset: 0x000C60C8
			[CallerCount(0)]
			public unsafe bool _CreateMsgs_b__1_0(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscatedMessageActionFactory.__c.NativeMethodInfoPtr__CreateMsgs_b__1_0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003001 RID: 12289 RVA: 0x00016EA0 File Offset: 0x000150A0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C8A RID: 3210
			// (get) Token: 0x06003002 RID: 12290 RVA: 0x000C7F18 File Offset: 0x000C6118
			// (set) Token: 0x06003003 RID: 12291 RVA: 0x00016EA9 File Offset: 0x000150A9
			public unsafe static ObfuscatedMessageActionFactory.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObfuscatedMessageActionFactory.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObfuscatedMessageActionFactory.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObfuscatedMessageActionFactory.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C8B RID: 3211
			// (get) Token: 0x06003004 RID: 12292 RVA: 0x000C7F40 File Offset: 0x000C6140
			// (set) Token: 0x06003005 RID: 12293 RVA: 0x00016EBB File Offset: 0x000150BB
			public unsafe static Func<PlayerEntity, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObfuscatedMessageActionFactory.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObfuscatedMessageActionFactory.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E08 RID: 7688
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001E09 RID: 7689
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001E0A RID: 7690
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001E0B RID: 7691
			private static readonly IntPtr NativeMethodInfoPtr__CreateMsgs_b__1_0_Internal_Boolean_PlayerEntity_0;
		}

		// Token: 0x02000443 RID: 1091
		[ObfuscatedName("Canis.actions.ObfuscatedMessageActionFactory+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x06003006 RID: 12294 RVA: 0x000C7F68 File Offset: 0x000C6168
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObfuscatedMessageActionFactory>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass0_0>.NativeClassPtr);
				ObfuscatedMessageActionFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass0_0>.NativeClassPtr, "m");
				ObfuscatedMessageActionFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_waitForResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass0_0>.NativeClassPtr, "waitForResponse");
				ObfuscatedMessageActionFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass0_0>.NativeClassPtr, 100668114);
				ObfuscatedMessageActionFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__Create_b__0_Internal_MessageAction_ValueTuple_2_NetworkMessageEvent_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass0_0>.NativeClassPtr, 100668115);
			}

			// Token: 0x06003007 RID: 12295 RVA: 0x000C7FE4 File Offset: 0x000C61E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscatedMessageActionFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003008 RID: 12296 RVA: 0x000C8020 File Offset: 0x000C6220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591015, XrefRangeEnd = 591019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MessageAction _Create_b__0(ValueTuple<NetworkMessageEvent, PlayerEntity> tup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tup));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscatedMessageActionFactory.__c__DisplayClass0_0.NativeMethodInfoPtr__Create_b__0_Internal_MessageAction_ValueTuple_2_NetworkMessageEvent_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageAction>(intPtr3) : null;
				}
			}

			// Token: 0x06003009 RID: 12297 RVA: 0x00016ECD File Offset: 0x000150CD
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C8C RID: 3212
			// (get) Token: 0x0600300A RID: 12298 RVA: 0x000C8078 File Offset: 0x000C6278
			// (set) Token: 0x0600300B RID: 12299 RVA: 0x00016ED6 File Offset: 0x000150D6
			public unsafe Match m
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscatedMessageActionFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_m);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscatedMessageActionFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_m), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C8D RID: 3213
			// (get) Token: 0x0600300C RID: 12300 RVA: 0x000C80A8 File Offset: 0x000C62A8
			// (set) Token: 0x0600300D RID: 12301 RVA: 0x00016EF5 File Offset: 0x000150F5
			public unsafe bool waitForResponse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscatedMessageActionFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_waitForResponse);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscatedMessageActionFactory.__c__DisplayClass0_0.NativeFieldInfoPtr_waitForResponse)) = value;
				}
			}

			// Token: 0x04001E0C RID: 7692
			private static readonly IntPtr NativeFieldInfoPtr_m;

			// Token: 0x04001E0D RID: 7693
			private static readonly IntPtr NativeFieldInfoPtr_waitForResponse;

			// Token: 0x04001E0E RID: 7694
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001E0F RID: 7695
			private static readonly IntPtr NativeMethodInfoPtr__Create_b__0_Internal_MessageAction_ValueTuple_2_NetworkMessageEvent_PlayerEntity_0;
		}

		// Token: 0x02000444 RID: 1092
		[ObfuscatedName("Canis.actions.ObfuscatedMessageActionFactory+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600300E RID: 12302 RVA: 0x000C80D0 File Offset: 0x000C62D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObfuscatedMessageActionFactory>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass1_0>.NativeClassPtr);
				ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass1_0>.NativeClassPtr, "message");
				ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass1_0>.NativeClassPtr, "m");
				ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass1_0>.NativeClassPtr, "player");
				ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass1_0>.NativeClassPtr, 100668116);
				ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateMsgs_b__1_Internal_IEnumerable_1_ValueTuple_2_NetworkMessageEvent_PlayerEntity_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass1_0>.NativeClassPtr, 100668117);
				ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateMsgs_b__2_Internal_ValueTuple_2_NetworkMessageEvent_PlayerEntity_NetworkMessageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass1_0>.NativeClassPtr, 100668118);
			}

			// Token: 0x0600300F RID: 12303 RVA: 0x000C8188 File Offset: 0x000C6388
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObfuscatedMessageActionFactory.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003010 RID: 12304 RVA: 0x000C81C4 File Offset: 0x000C63C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591019, XrefRangeEnd = 591020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ValueTuple<NetworkMessageEvent, PlayerEntity>> _CreateMsgs_b__1(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateMsgs_b__1_Internal_IEnumerable_1_ValueTuple_2_NetworkMessageEvent_PlayerEntity_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<NetworkMessageEvent, PlayerEntity>>>(intPtr3) : null;
				}
			}

			// Token: 0x06003011 RID: 12305 RVA: 0x000C8214 File Offset: 0x000C6414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591020, XrefRangeEnd = 591023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<NetworkMessageEvent, PlayerEntity> _CreateMsgs_b__2(NetworkMessageEvent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeMethodInfoPtr__CreateMsgs_b__2_Internal_ValueTuple_2_NetworkMessageEvent_PlayerEntity_NetworkMessageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<NetworkMessageEvent, PlayerEntity>(intPtr);
				}
			}

			// Token: 0x06003012 RID: 12306 RVA: 0x00016F10 File Offset: 0x00015110
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C8E RID: 3214
			// (get) Token: 0x06003013 RID: 12307 RVA: 0x000C825C File Offset: 0x000C645C
			// (set) Token: 0x06003014 RID: 12308 RVA: 0x00016F19 File Offset: 0x00015119
			public unsafe ObfuscatedMessageActionFactory __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObfuscatedMessageActionFactory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C8F RID: 3215
			// (get) Token: 0x06003015 RID: 12309 RVA: 0x000C828C File Offset: 0x000C648C
			// (set) Token: 0x06003016 RID: 12310 RVA: 0x00016F38 File Offset: 0x00015138
			public unsafe NetworkMessageEvent message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C90 RID: 3216
			// (get) Token: 0x06003017 RID: 12311 RVA: 0x000C82BC File Offset: 0x000C64BC
			// (set) Token: 0x06003018 RID: 12312 RVA: 0x00016F57 File Offset: 0x00015157
			public unsafe Match m
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_m);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_m), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C91 RID: 3217
			// (get) Token: 0x06003019 RID: 12313 RVA: 0x000C82EC File Offset: 0x000C64EC
			// (set) Token: 0x0600301A RID: 12314 RVA: 0x00016F76 File Offset: 0x00015176
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObfuscatedMessageActionFactory.__c__DisplayClass1_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E10 RID: 7696
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001E11 RID: 7697
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04001E12 RID: 7698
			private static readonly IntPtr NativeFieldInfoPtr_m;

			// Token: 0x04001E13 RID: 7699
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04001E14 RID: 7700
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001E15 RID: 7701
			private static readonly IntPtr NativeMethodInfoPtr__CreateMsgs_b__1_Internal_IEnumerable_1_ValueTuple_2_NetworkMessageEvent_PlayerEntity_PlayerEntity_0;

			// Token: 0x04001E16 RID: 7702
			private static readonly IntPtr NativeMethodInfoPtr__CreateMsgs_b__2_Internal_ValueTuple_2_NetworkMessageEvent_PlayerEntity_NetworkMessageEvent_0;
		}
	}
}
