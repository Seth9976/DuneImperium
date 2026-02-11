using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace lotus.match.messages
{
	// Token: 0x020000E7 RID: 231
	public static class Outgoing : Object
	{
		// Token: 0x06000B50 RID: 2896 RVA: 0x00007246 File Offset: 0x00005446
		// Note: this type is marked as 'beforefieldinit'.
		static Outgoing()
		{
			Il2CppClassPointerStore<Outgoing>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.match.messages", "Outgoing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Outgoing>.NativeClassPtr);
			Outgoing.NativeMethodInfoPtr_MultipleSimultaneousSelections_Public_Static_Object_GameID_IEnumerable_1_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outgoing>.NativeClassPtr, 100665107);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00035394 File Offset: 0x00033594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994610, XrefRangeEnd = 994667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object MultipleSimultaneousSelections(GameID gameID, IEnumerable<EntityID> selection, int counter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selection);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref counter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Outgoing.NativeMethodInfoPtr_MultipleSimultaneousSelections_Public_Static_Object_GameID_IEnumerable_1_EntityID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0000727F File Offset: 0x0000547F
		public Outgoing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_MultipleSimultaneousSelections_Public_Static_Object_GameID_IEnumerable_1_EntityID_Int32_0;

		// Token: 0x02000242 RID: 578
		[ObfuscatedName("lotus.match.messages.Outgoing+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001ABF RID: 6847 RVA: 0x00063B44 File Offset: 0x00061D44
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Outgoing.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Outgoing>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Outgoing.__c>.NativeClassPtr);
				Outgoing.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Outgoing.__c>.NativeClassPtr, "<>9");
				Outgoing.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Outgoing.__c>.NativeClassPtr, "<>9__0_0");
				Outgoing.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outgoing.__c>.NativeClassPtr, 100665109);
				Outgoing.__c.NativeMethodInfoPtr__MultipleSimultaneousSelections_b__0_0_Internal_String_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Outgoing.__c>.NativeClassPtr, 100665110);
			}

			// Token: 0x06001AC0 RID: 6848 RVA: 0x00063BC0 File Offset: 0x00061DC0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Outgoing.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Outgoing.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AC1 RID: 6849 RVA: 0x00063BFC File Offset: 0x00061DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MultipleSimultaneousSelections_b__0_0(EntityID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Outgoing.__c.NativeMethodInfoPtr__MultipleSimultaneousSelections_b__0_0_Internal_String_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001AC2 RID: 6850 RVA: 0x0000E8DA File Offset: 0x0000CADA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007D8 RID: 2008
			// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x00063C44 File Offset: 0x00061E44
			// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x0000E8E3 File Offset: 0x0000CAE3
			public unsafe static Outgoing.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Outgoing.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outgoing.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Outgoing.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D9 RID: 2009
			// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x00063C6C File Offset: 0x00061E6C
			// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x0000E8F5 File Offset: 0x0000CAF5
			public unsafe static Func<EntityID, string> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Outgoing.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityID, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Outgoing.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400102C RID: 4140
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400102D RID: 4141
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x0400102E RID: 4142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400102F RID: 4143
			private static readonly IntPtr NativeMethodInfoPtr__MultipleSimultaneousSelections_b__0_0_Internal_String_EntityID_0;
		}
	}
}
