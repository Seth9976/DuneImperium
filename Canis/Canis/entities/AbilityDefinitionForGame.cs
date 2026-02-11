using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000BA RID: 186
	public class AbilityDefinitionForGame<TMatch> : AbilityDefinition where TMatch : Match
	{
		// Token: 0x060008AF RID: 2223 RVA: 0x0003CC14 File Offset: 0x0003AE14
		// Note: this type is marked as 'beforefieldinit'.
		static AbilityDefinitionForGame()
		{
			Il2CppClassPointerStore<AbilityDefinitionForGame<TMatch>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "AbilityDefinitionForGame`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatch>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDefinitionForGame<TMatch>>.NativeClassPtr);
			AbilityDefinitionForGame<TMatch>.NativeFieldInfoPtr_tMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDefinitionForGame<TMatch>>.NativeClassPtr, "tMatch");
			AbilityDefinitionForGame<TMatch>.NativeMethodInfoPtr__ctor_Protected_Void_TMatch_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionForGame<TMatch>>.NativeClassPtr, 100665093);
			AbilityDefinitionForGame<TMatch>.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_TMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionForGame<TMatch>>.NativeClassPtr, 100665094);
			AbilityDefinitionForGame<TMatch>.NativeMethodInfoPtr_get_TypedMatch_Public_get_TMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDefinitionForGame<TMatch>>.NativeClassPtr, 100665095);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0003CCD0 File Offset: 0x0003AED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 561183, RefRangeEnd = 561184, XrefRangeStart = 561181, XrefRangeEnd = 561183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityDefinitionForGame(TMatch m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDefinitionForGame<TMatch>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TMatch).IsValueType)
				{
					TMatch tmatch = m;
					intPtr = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref m;
				}
				ptr2 = intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionForGame<TMatch>.NativeMethodInfoPtr__ctor_Protected_Void_TMatch_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0003CD78 File Offset: 0x0003AF78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 561186, RefRangeEnd = 561187, XrefRangeStart = 561184, XrefRangeEnd = 561186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbilityDefinitionForGame(SerializedEntity se, TMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDefinitionForGame<TMatch>>.NativeClassPtr))
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
				TMatch tmatch = m;
				intPtr = ((tmatch is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatch as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatch as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref m;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionForGame<TMatch>.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_TMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0003CE20 File Offset: 0x0003B020
		public unsafe TMatch TypedMatch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbilityDefinitionForGame<TMatch>.NativeMethodInfoPtr_get_TypedMatch_Public_get_TMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, false, true);
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0000560E File Offset: 0x0000380E
		public AbilityDefinitionForGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0003CE5C File Offset: 0x0003B05C
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x0003CE84 File Offset: 0x0003B084
		public unsafe TMatch tMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinitionForGame<TMatch>.NativeFieldInfoPtr_tMatch);
				return IL2CPP.PointerToValueGeneric<TMatch>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbilityDefinitionForGame<TMatch>.NativeFieldInfoPtr_tMatch);
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

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeFieldInfoPtr_tMatch;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_TMatch_String_PlayerEntity_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_TMatch_Entity_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedMatch_Public_get_TMatch_0;
	}
}
