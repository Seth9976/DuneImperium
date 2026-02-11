using System;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis
{
	// Token: 0x02000025 RID: 37
	public static class MatchOnlineUtils : Object
	{
		// Token: 0x0600026C RID: 620 RVA: 0x00002F09 File Offset: 0x00001109
		// Note: this type is marked as 'beforefieldinit'.
		static MatchOnlineUtils()
		{
			Il2CppClassPointerStore<MatchOnlineUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis", "MatchOnlineUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchOnlineUtils>.NativeClassPtr);
			MatchOnlineUtils.NativeMethodInfoPtr_PlayerNameData_Public_Static_List_1_AccountIDUsernameMetadata_TMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchOnlineUtils>.NativeClassPtr, 100663896);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00023B48 File Offset: 0x00021D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548723, XrefRangeEnd = 548735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<AccountIDUsernameMetadata> PlayerNameData<TMatch, TPlayer>(this TMatch match) where TMatch : Match where TPlayer : PlayerEntity
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TMatch).IsValueType)
				{
					TMatch tmatch = match;
					intPtr = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref match;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MatchOnlineUtils.MethodInfoStoreGeneric_PlayerNameData_Public_Static_List_1_AccountIDUsernameMetadata_TMatch_0<TMatch, TPlayer>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<List<AccountIDUsernameMetadata>>(intPtr4) : null;
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002F42 File Offset: 0x00001142
		public MatchOnlineUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_PlayerNameData_Public_Static_List_1_AccountIDUsernameMetadata_TMatch_0;

		// Token: 0x02000277 RID: 631
		[ObfuscatedName("Canis.MatchOnlineUtils+<>c__DisplayClass0_0`2")]
		public sealed class __c__DisplayClass0_0<TMatch, TPlayer> : Object where TMatch : Match where TPlayer : PlayerEntity
		{
			// Token: 0x06001ACB RID: 6859 RVA: 0x00082180 File Offset: 0x00080380
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<MatchOnlineUtils.__c__DisplayClass0_0<TMatch, TPlayer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchOnlineUtils>.NativeClassPtr, "<>c__DisplayClass0_0`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchOnlineUtils.__c__DisplayClass0_0<TMatch, TPlayer>>.NativeClassPtr);
				MatchOnlineUtils.__c__DisplayClass0_0<TMatch, TPlayer>.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchOnlineUtils.__c__DisplayClass0_0<TMatch, TPlayer>>.NativeClassPtr, "match");
				MatchOnlineUtils.__c__DisplayClass0_0<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchOnlineUtils.__c__DisplayClass0_0<TMatch, TPlayer>>.NativeClassPtr, 100663897);
				MatchOnlineUtils.__c__DisplayClass0_0<TMatch, TPlayer>.NativeMethodInfoPtr__PlayerNameData_b__0_Internal_AccountIDUsernameMetadata_TPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchOnlineUtils.__c__DisplayClass0_0<TMatch, TPlayer>>.NativeClassPtr, 100663898);
			}

			// Token: 0x06001ACC RID: 6860 RVA: 0x00082234 File Offset: 0x00080434
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchOnlineUtils.__c__DisplayClass0_0<TMatch, TPlayer>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchOnlineUtils.__c__DisplayClass0_0<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ACD RID: 6861 RVA: 0x00082270 File Offset: 0x00080470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548615, XrefRangeEnd = 548718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccountIDUsernameMetadata _PlayerNameData_b__0(TPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TPlayer).IsValueType)
					{
						TPlayer tplayer = p;
						intPtr = ((tplayer is string) ? IL2CPP.ManagedStringToIl2Cpp(tplayer as string) : IL2CPP.Il2CppObjectBaseToPtr(tplayer as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref p;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MatchOnlineUtils.__c__DisplayClass0_0<TMatch, TPlayer>.NativeMethodInfoPtr__PlayerNameData_b__0_Internal_AccountIDUsernameMetadata_TPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr4) : null;
				}
			}

			// Token: 0x06001ACE RID: 6862 RVA: 0x0000CD1D File Offset: 0x0000AF1D
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x06001ACF RID: 6863 RVA: 0x000822F8 File Offset: 0x000804F8
			// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x00082320 File Offset: 0x00080520
			public unsafe TMatch match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchOnlineUtils.__c__DisplayClass0_0<TMatch, TPlayer>.NativeFieldInfoPtr_match);
					return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchOnlineUtils.__c__DisplayClass0_0<TMatch, TPlayer>.NativeFieldInfoPtr_match);
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

			// Token: 0x0400111A RID: 4378
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x0400111B RID: 4379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400111C RID: 4380
			private static readonly IntPtr NativeMethodInfoPtr__PlayerNameData_b__0_Internal_AccountIDUsernameMetadata_TPlayer_0;
		}

		// Token: 0x02000278 RID: 632
		[ObfuscatedName("Canis.MatchOnlineUtils+<>c__DisplayClass0_1`2")]
		public sealed class __c__DisplayClass0_1<TMatch, TPlayer> : Object where TMatch : Match where TPlayer : PlayerEntity
		{
			// Token: 0x06001AD1 RID: 6865 RVA: 0x000823C8 File Offset: 0x000805C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_1()
			{
				Il2CppClassPointerStore<MatchOnlineUtils.__c__DisplayClass0_1<TMatch, TPlayer>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchOnlineUtils>.NativeClassPtr, "<>c__DisplayClass0_1`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchOnlineUtils.__c__DisplayClass0_1<TMatch, TPlayer>>.NativeClassPtr);
				MatchOnlineUtils.__c__DisplayClass0_1<TMatch, TPlayer>.NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchOnlineUtils.__c__DisplayClass0_1<TMatch, TPlayer>>.NativeClassPtr, "p");
				MatchOnlineUtils.__c__DisplayClass0_1<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchOnlineUtils.__c__DisplayClass0_1<TMatch, TPlayer>>.NativeClassPtr, 100663899);
				MatchOnlineUtils.__c__DisplayClass0_1<TMatch, TPlayer>.NativeMethodInfoPtr__PlayerNameData_b__1_Internal_Boolean_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchOnlineUtils.__c__DisplayClass0_1<TMatch, TPlayer>>.NativeClassPtr, 100663900);
			}

			// Token: 0x06001AD2 RID: 6866 RVA: 0x0008247C File Offset: 0x0008067C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchOnlineUtils.__c__DisplayClass0_1<TMatch, TPlayer>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchOnlineUtils.__c__DisplayClass0_1<TMatch, TPlayer>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AD3 RID: 6867 RVA: 0x000824B8 File Offset: 0x000806B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548718, XrefRangeEnd = 548723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayerNameData_b__1(PlayerMatchInitData player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchOnlineUtils.__c__DisplayClass0_1<TMatch, TPlayer>.NativeMethodInfoPtr__PlayerNameData_b__1_Internal_Boolean_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001AD4 RID: 6868 RVA: 0x0000CD26 File Offset: 0x0000AF26
			public __c__DisplayClass0_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x06001AD5 RID: 6869 RVA: 0x00082508 File Offset: 0x00080708
			// (set) Token: 0x06001AD6 RID: 6870 RVA: 0x00082530 File Offset: 0x00080730
			public unsafe TPlayer p
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchOnlineUtils.__c__DisplayClass0_1<TMatch, TPlayer>.NativeFieldInfoPtr_p);
					return IL2CPP.PointerToValueGeneric<TPlayer>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchOnlineUtils.__c__DisplayClass0_1<TMatch, TPlayer>.NativeFieldInfoPtr_p);
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

			// Token: 0x0400111D RID: 4381
			private static readonly IntPtr NativeFieldInfoPtr_p;

			// Token: 0x0400111E RID: 4382
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400111F RID: 4383
			private static readonly IntPtr NativeMethodInfoPtr__PlayerNameData_b__1_Internal_Boolean_PlayerMatchInitData_0;
		}

		// Token: 0x02000279 RID: 633
		private sealed class MethodInfoStoreGeneric_PlayerNameData_Public_Static_List_1_AccountIDUsernameMetadata_TMatch_0<TMatch, TPlayer>
		{
			// Token: 0x04001120 RID: 4384
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MatchOnlineUtils.NativeMethodInfoPtr_PlayerNameData_Public_Static_List_1_AccountIDUsernameMetadata_TMatch_0, Il2CppClassPointerStore<MatchOnlineUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPlayer>.NativeClassPtr))
			}))));
		}
	}
}
