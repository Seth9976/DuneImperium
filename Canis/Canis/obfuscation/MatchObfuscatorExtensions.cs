using System;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.obfuscation
{
	// Token: 0x02000065 RID: 101
	public static class MatchObfuscatorExtensions : Object
	{
		// Token: 0x060005A0 RID: 1440 RVA: 0x0002F6D4 File Offset: 0x0002D8D4
		// Note: this type is marked as 'beforefieldinit'.
		static MatchObfuscatorExtensions()
		{
			Il2CppClassPointerStore<MatchObfuscatorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.obfuscation", "MatchObfuscatorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchObfuscatorExtensions>.NativeClassPtr);
			MatchObfuscatorExtensions.NativeMethodInfoPtr_FailedToFindMessage_Public_Static_String_Match_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchObfuscatorExtensions>.NativeClassPtr, 100664456);
			MatchObfuscatorExtensions.NativeMethodInfoPtr_BruteForceFindEntity_Public_Static_Entity_Match_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchObfuscatorExtensions>.NativeClassPtr, 100664457);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0002F72C File Offset: 0x0002D92C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 554961, RefRangeEnd = 554967, XrefRangeStart = 554938, XrefRangeEnd = 554961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FailedToFindMessage(this Match match, EntityID id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchObfuscatorExtensions.NativeMethodInfoPtr_FailedToFindMessage_Public_Static_String_Match_EntityID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0002F77C File Offset: 0x0002D97C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 554986, RefRangeEnd = 554987, XrefRangeStart = 554967, XrefRangeEnd = 554986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Entity BruteForceFindEntity(this Match match, EntityID id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchObfuscatorExtensions.NativeMethodInfoPtr_BruteForceFindEntity_Public_Static_Entity_Match_EntityID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000046DE File Offset: 0x000028DE
		public MatchObfuscatorExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_FailedToFindMessage_Public_Static_String_Match_EntityID_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_BruteForceFindEntity_Public_Static_Entity_Match_EntityID_0;

		// Token: 0x020002BE RID: 702
		[ObfuscatedName("Canis.obfuscation.MatchObfuscatorExtensions+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06001DAF RID: 7599 RVA: 0x0008B038 File Offset: 0x00089238
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<MatchObfuscatorExtensions.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MatchObfuscatorExtensions>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchObfuscatorExtensions.__c__DisplayClass1_0>.NativeClassPtr);
				MatchObfuscatorExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchObfuscatorExtensions.__c__DisplayClass1_0>.NativeClassPtr, "id");
				MatchObfuscatorExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchObfuscatorExtensions.__c__DisplayClass1_0>.NativeClassPtr, 100664458);
				MatchObfuscatorExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__BruteForceFindEntity_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchObfuscatorExtensions.__c__DisplayClass1_0>.NativeClassPtr, 100664459);
			}

			// Token: 0x06001DB0 RID: 7600 RVA: 0x0008B0A0 File Offset: 0x000892A0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchObfuscatorExtensions.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchObfuscatorExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001DB1 RID: 7601 RVA: 0x0008B0DC File Offset: 0x000892DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554934, XrefRangeEnd = 554938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BruteForceFindEntity_b__0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchObfuscatorExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__BruteForceFindEntity_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001DB2 RID: 7602 RVA: 0x0000E405 File Offset: 0x0000C605
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006EF RID: 1775
			// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x0008B12C File Offset: 0x0008932C
			// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x0000E40E File Offset: 0x0000C60E
			public unsafe EntityID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchObfuscatorExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchObfuscatorExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012D4 RID: 4820
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040012D5 RID: 4821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040012D6 RID: 4822
			private static readonly IntPtr NativeMethodInfoPtr__BruteForceFindEntity_b__0_Internal_Boolean_Entity_0;
		}
	}
}
