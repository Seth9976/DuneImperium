using System;
using Canis.entities;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions
{
	// Token: 0x020001CC RID: 460
	public class ResumePlayer<TMatch, TPlayer> : Action where TMatch : Match where TPlayer : PlayerEntity
	{
		// Token: 0x0600135B RID: 4955 RVA: 0x00067A18 File Offset: 0x00065C18
		// Note: this type is marked as 'beforefieldinit'.
		static ResumePlayer()
		{
			Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "ResumePlayer`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>>.NativeClassPtr);
			ResumePlayer<TMatch, TPlayer>.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>>.NativeClassPtr, "match");
			ResumePlayer<TMatch, TPlayer>.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>>.NativeClassPtr, "player");
			ResumePlayer<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_TPlayer_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>>.NativeClassPtr, 100667500);
			ResumePlayer<TMatch, TPlayer>.NativeMethodInfoPtr_AreValidDisplayActions_Private_Boolean_PlayerSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>>.NativeClassPtr, 100667501);
			ResumePlayer<TMatch, TPlayer>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>>.NativeClassPtr, 100667502);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00067AFC File Offset: 0x00065CFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 587041, RefRangeEnd = 587043, XrefRangeStart = 587031, XrefRangeEnd = 587041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResumePlayer(TPlayer player, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TPlayer).IsValueType)
				{
					TPlayer tplayer = player;
					intPtr = ((tplayer is string) ? IL2CPP.ManagedStringToIl2Cpp(tplayer as string) : IL2CPP.Il2CppObjectBaseToPtr(tplayer as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref player;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_TPlayer_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00067B90 File Offset: 0x00065D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587043, XrefRangeEnd = 587070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreValidDisplayActions(PlayerSaveData playerSaveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerSaveData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>.NativeMethodInfoPtr_AreValidDisplayActions_Private_Boolean_PlayerSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00067BE0 File Offset: 0x00065DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587070, XrefRangeEnd = 587074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResumePlayer<TMatch, TPlayer>.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x000097AE File Offset: 0x000079AE
		public ResumePlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x00067C2C File Offset: 0x00065E2C
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x00067C54 File Offset: 0x00065E54
		public unsafe TMatch match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>.NativeFieldInfoPtr_match);
				return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>.NativeFieldInfoPtr_match);
				Type typeFromHandle = typeof(TMatch);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x00067CFC File Offset: 0x00065EFC
		// (set) Token: 0x06001363 RID: 4963 RVA: 0x00067D24 File Offset: 0x00065F24
		public unsafe TPlayer player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>.NativeFieldInfoPtr_player);
				return IL2CPP.PointerToValueGeneric<TPlayer>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>.NativeFieldInfoPtr_player);
				Type typeFromHandle = typeof(TPlayer);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04000C90 RID: 3216
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x04000C91 RID: 3217
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04000C92 RID: 3218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TPlayer_Match_0;

		// Token: 0x04000C93 RID: 3219
		private static readonly IntPtr NativeMethodInfoPtr_AreValidDisplayActions_Private_Boolean_PlayerSaveData_0;

		// Token: 0x04000C94 RID: 3220
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x02000402 RID: 1026
		[ObfuscatedName("Canis.actions.ResumePlayer`2+<>O")]
		public static class __O : Object
		{
			// Token: 0x06002C63 RID: 11363 RVA: 0x000BC4E4 File Offset: 0x000BA6E4
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__O>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>>.NativeClassPtr, "<>O"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__O>.NativeClassPtr);
				ResumePlayer<TMatch, TPlayer>.__O.NativeFieldInfoPtr__0___IsSelectionMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__O>.NativeClassPtr, "<0>__IsSelectionMessage");
			}

			// Token: 0x06002C64 RID: 11364 RVA: 0x00015378 File Offset: 0x00013578
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B6A RID: 2922
			// (get) Token: 0x06002C65 RID: 11365 RVA: 0x000BC570 File Offset: 0x000BA770
			// (set) Token: 0x06002C66 RID: 11366 RVA: 0x00015381 File Offset: 0x00013581
			public unsafe static Func<DWDEvent, bool> _0___IsSelectionMessage
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResumePlayer<TMatch, TPlayer>.__O.NativeFieldInfoPtr__0___IsSelectionMessage, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DWDEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResumePlayer<TMatch, TPlayer>.__O.NativeFieldInfoPtr__0___IsSelectionMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BC2 RID: 7106
			private static readonly IntPtr NativeFieldInfoPtr__0___IsSelectionMessage;
		}

		// Token: 0x02000403 RID: 1027
		[ObfuscatedName("Canis.actions.ResumePlayer`2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002C67 RID: 11367 RVA: 0x000BC598 File Offset: 0x000BA798
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c>.NativeClassPtr);
				ResumePlayer<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c>.NativeClassPtr, "<>9");
				ResumePlayer<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c>.NativeClassPtr, "<>9__3_0");
				ResumePlayer<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9__3_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c>.NativeClassPtr, "<>9__3_2");
				ResumePlayer<TMatch, TPlayer>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c>.NativeClassPtr, 100667504);
				ResumePlayer<TMatch, TPlayer>.__c.NativeMethodInfoPtr__AreValidDisplayActions_b__3_0_Internal_Boolean_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c>.NativeClassPtr, 100667505);
				ResumePlayer<TMatch, TPlayer>.__c.NativeMethodInfoPtr__AreValidDisplayActions_b__3_2_Internal_Boolean_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c>.NativeClassPtr, 100667506);
			}

			// Token: 0x06002C68 RID: 11368 RVA: 0x000BC688 File Offset: 0x000BA888
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C69 RID: 11369 RVA: 0x000BC6C4 File Offset: 0x000BA8C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586965, XrefRangeEnd = 586970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AreValidDisplayActions_b__3_0(DWDEvent msg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>.__c.NativeMethodInfoPtr__AreValidDisplayActions_b__3_0_Internal_Boolean_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C6A RID: 11370 RVA: 0x000BC714 File Offset: 0x000BA914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586970, XrefRangeEnd = 586975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AreValidDisplayActions_b__3_2(DWDEvent msg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>.__c.NativeMethodInfoPtr__AreValidDisplayActions_b__3_2_Internal_Boolean_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C6B RID: 11371 RVA: 0x00015393 File Offset: 0x00013593
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B6B RID: 2923
			// (get) Token: 0x06002C6C RID: 11372 RVA: 0x000BC764 File Offset: 0x000BA964
			// (set) Token: 0x06002C6D RID: 11373 RVA: 0x0001539C File Offset: 0x0001359C
			public unsafe static ResumePlayer<TMatch, TPlayer>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResumePlayer<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumePlayer<TMatch, TPlayer>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResumePlayer<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B6C RID: 2924
			// (get) Token: 0x06002C6E RID: 11374 RVA: 0x000BC78C File Offset: 0x000BA98C
			// (set) Token: 0x06002C6F RID: 11375 RVA: 0x000153AE File Offset: 0x000135AE
			public unsafe static Func<DWDEvent, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResumePlayer<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DWDEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResumePlayer<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B6D RID: 2925
			// (get) Token: 0x06002C70 RID: 11376 RVA: 0x000BC7B4 File Offset: 0x000BA9B4
			// (set) Token: 0x06002C71 RID: 11377 RVA: 0x000153C0 File Offset: 0x000135C0
			public unsafe static Func<DWDEvent, bool> __9__3_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ResumePlayer<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9__3_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DWDEvent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ResumePlayer<TMatch, TPlayer>.__c.NativeFieldInfoPtr___9__3_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BC3 RID: 7107
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001BC4 RID: 7108
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04001BC5 RID: 7109
			private static readonly IntPtr NativeFieldInfoPtr___9__3_2;

			// Token: 0x04001BC6 RID: 7110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BC7 RID: 7111
			private static readonly IntPtr NativeMethodInfoPtr__AreValidDisplayActions_b__3_0_Internal_Boolean_DWDEvent_0;

			// Token: 0x04001BC8 RID: 7112
			private static readonly IntPtr NativeMethodInfoPtr__AreValidDisplayActions_b__3_2_Internal_Boolean_DWDEvent_0;
		}

		// Token: 0x02000404 RID: 1028
		[ObfuscatedName("Canis.actions.ResumePlayer`2+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06002C72 RID: 11378 RVA: 0x000BC7DC File Offset: 0x000BA9DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>>.NativeClassPtr, "<>c__DisplayClass3_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c__DisplayClass3_0>.NativeClassPtr);
				ResumePlayer<TMatch, TPlayer>.__c__DisplayClass3_0.NativeFieldInfoPtr_selectionCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c__DisplayClass3_0>.NativeClassPtr, "selectionCounter");
				ResumePlayer<TMatch, TPlayer>.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c__DisplayClass3_0>.NativeClassPtr, 100667507);
				ResumePlayer<TMatch, TPlayer>.__c__DisplayClass3_0.NativeMethodInfoPtr__AreValidDisplayActions_b__1_Internal_Boolean_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c__DisplayClass3_0>.NativeClassPtr, 100667508);
			}

			// Token: 0x06002C73 RID: 11379 RVA: 0x000BC890 File Offset: 0x000BAA90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C74 RID: 11380 RVA: 0x000BC8CC File Offset: 0x000BAACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586975, XrefRangeEnd = 586981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AreValidDisplayActions_b__1(DWDEvent msg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>.__c__DisplayClass3_0.NativeMethodInfoPtr__AreValidDisplayActions_b__1_Internal_Boolean_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C75 RID: 11381 RVA: 0x000153D2 File Offset: 0x000135D2
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B6E RID: 2926
			// (get) Token: 0x06002C76 RID: 11382 RVA: 0x000BC91C File Offset: 0x000BAB1C
			// (set) Token: 0x06002C77 RID: 11383 RVA: 0x000153DB File Offset: 0x000135DB
			public unsafe int selectionCounter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>.__c__DisplayClass3_0.NativeFieldInfoPtr_selectionCounter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>.__c__DisplayClass3_0.NativeFieldInfoPtr_selectionCounter)) = value;
				}
			}

			// Token: 0x04001BC9 RID: 7113
			private static readonly IntPtr NativeFieldInfoPtr_selectionCounter;

			// Token: 0x04001BCA RID: 7114
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001BCB RID: 7115
			private static readonly IntPtr NativeMethodInfoPtr__AreValidDisplayActions_b__1_Internal_Boolean_DWDEvent_0;
		}

		// Token: 0x02000405 RID: 1029
		[ObfuscatedName("Canis.actions.ResumePlayer`2+<execute>d__4")]
		public sealed class _execute_d__4 : Object
		{
			// Token: 0x06002C78 RID: 11384 RVA: 0x000BC944 File Offset: 0x000BAB44
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__4()
			{
				Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>>.NativeClassPtr, "<execute>d__4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr);
				ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr, "<>1__state");
				ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr, "<>2__current");
				ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr, "<>l__initialThreadId");
				ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr, "<>4__this");
				ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr__playerSaveData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr, "<playerSaveData>5__2");
				ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr, 100667509);
				ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr, 100667510);
				ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr, 100667511);
				ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr, 100667512);
				ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr, 100667513);
				ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr, 100667514);
				ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr, 100667515);
				ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr, 100667516);
			}

			// Token: 0x06002C79 RID: 11385 RVA: 0x000BCAC0 File Offset: 0x000BACC0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResumePlayer<TMatch, TPlayer>._execute_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C7A RID: 11386 RVA: 0x000BCB08 File Offset: 0x000BAD08
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C7B RID: 11387 RVA: 0x000BCB3C File Offset: 0x000BAD3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 586981, XrefRangeEnd = 587030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B74 RID: 2932
			// (get) Token: 0x06002C7C RID: 11388 RVA: 0x000BCB78 File Offset: 0x000BAD78
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002C7D RID: 11389 RVA: 0x000BCBB8 File Offset: 0x000BADB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B75 RID: 2933
			// (get) Token: 0x06002C7E RID: 11390 RVA: 0x000BCBEC File Offset: 0x000BADEC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C7F RID: 11391 RVA: 0x000BCC2C File Offset: 0x000BAE2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002C80 RID: 11392 RVA: 0x000BCC6C File Offset: 0x000BAE6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587030, XrefRangeEnd = 587031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002C81 RID: 11393 RVA: 0x000153F6 File Offset: 0x000135F6
			public _execute_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B6F RID: 2927
			// (get) Token: 0x06002C82 RID: 11394 RVA: 0x000BCCAC File Offset: 0x000BAEAC
			// (set) Token: 0x06002C83 RID: 11395 RVA: 0x000153FF File Offset: 0x000135FF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B70 RID: 2928
			// (get) Token: 0x06002C84 RID: 11396 RVA: 0x000BCCD4 File Offset: 0x000BAED4
			// (set) Token: 0x06002C85 RID: 11397 RVA: 0x0001541A File Offset: 0x0001361A
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B71 RID: 2929
			// (get) Token: 0x06002C86 RID: 11398 RVA: 0x000BCD04 File Offset: 0x000BAF04
			// (set) Token: 0x06002C87 RID: 11399 RVA: 0x00015439 File Offset: 0x00013639
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000B72 RID: 2930
			// (get) Token: 0x06002C88 RID: 11400 RVA: 0x000BCD2C File Offset: 0x000BAF2C
			// (set) Token: 0x06002C89 RID: 11401 RVA: 0x00015454 File Offset: 0x00013654
			public unsafe ResumePlayer<TMatch, TPlayer> __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResumePlayer<TMatch, TPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B73 RID: 2931
			// (get) Token: 0x06002C8A RID: 11402 RVA: 0x000BCD5C File Offset: 0x000BAF5C
			// (set) Token: 0x06002C8B RID: 11403 RVA: 0x00015473 File Offset: 0x00013673
			public unsafe PlayerSaveData _playerSaveData_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr__playerSaveData_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSaveData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResumePlayer<TMatch, TPlayer>._execute_d__4.NativeFieldInfoPtr__playerSaveData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001BCC RID: 7116
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001BCD RID: 7117
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001BCE RID: 7118
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001BCF RID: 7119
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001BD0 RID: 7120
			private static readonly IntPtr NativeFieldInfoPtr__playerSaveData_5__2;

			// Token: 0x04001BD1 RID: 7121
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001BD2 RID: 7122
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BD3 RID: 7123
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001BD4 RID: 7124
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001BD5 RID: 7125
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001BD6 RID: 7126
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001BD7 RID: 7127
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001BD8 RID: 7128
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
