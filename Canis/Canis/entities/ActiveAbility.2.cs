using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000D0 RID: 208
	public class ActiveAbility<TMatch, TAbilityDefinition> : ActiveAbility where TMatch : Match where TAbilityDefinition : AbilityDefinitionForGame<TMatch>
	{
		// Token: 0x0600099B RID: 2459 RVA: 0x00042034 File Offset: 0x00040234
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveAbility()
		{
			Il2CppClassPointerStore<ActiveAbility<TMatch, TAbilityDefinition>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "ActiveAbility`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAbilityDefinition>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveAbility<TMatch, TAbilityDefinition>>.NativeClassPtr);
			ActiveAbility<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_tMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility<TMatch, TAbilityDefinition>>.NativeClassPtr, "tMatch");
			ActiveAbility<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_get_TypedMatch_Public_get_TMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665331);
			ActiveAbility<TMatch, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Protected_Void_TAbilityDefinition_PlayerEntity_TMatch_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665332);
			ActiveAbility<TMatch, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_TMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility<TMatch, TAbilityDefinition>>.NativeClassPtr, 100665333);
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00042104 File Offset: 0x00040304
		public unsafe TMatch TypedMatch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility<TMatch, TAbilityDefinition>.NativeMethodInfoPtr_get_TypedMatch_Public_get_TMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, false, true);
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00042140 File Offset: 0x00040340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 564502, RefRangeEnd = 564503, XrefRangeStart = 564478, XrefRangeEnd = 564502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveAbility(TAbilityDefinition abilityDefinition, PlayerEntity runningPlayer, TMatch m, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveAbility<TMatch, TAbilityDefinition>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TAbilityDefinition).IsValueType)
				{
					TAbilityDefinition tabilityDefinition = abilityDefinition;
					intPtr = ((tabilityDefinition is string) ? IL2CPP.ManagedStringToIl2Cpp(tabilityDefinition as string) : IL2CPP.Il2CppObjectBaseToPtr(tabilityDefinition as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref abilityDefinition;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runningPlayer);
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TMatch).IsValueType)
			{
				TMatch tmatch = m;
				intPtr2 = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref m;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ActiveAbility<TMatch, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Protected_Void_TAbilityDefinition_PlayerEntity_TMatch_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00042230 File Offset: 0x00040430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 564505, RefRangeEnd = 564506, XrefRangeStart = 564503, XrefRangeEnd = 564505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveAbility(SerializedEntity se, TMatch match, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveAbility<TMatch, TAbilityDefinition>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ActiveAbility<TMatch, TAbilityDefinition>.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_TMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0000599B File Offset: 0x00003B9B
		public ActiveAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x000422D8 File Offset: 0x000404D8
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x00042300 File Offset: 0x00040500
		public unsafe TMatch tMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_tMatch);
				return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility<TMatch, TAbilityDefinition>.NativeFieldInfoPtr_tMatch);
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

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeFieldInfoPtr_tMatch;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedMatch_Public_get_TMatch_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_TAbilityDefinition_PlayerEntity_TMatch_String_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_TMatch_Entity_0;
	}
}
