using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI;

namespace boardgames.datarenderers
{
	// Token: 0x02000179 RID: 377
	public class ValidAvatarsRenderer : VersionedSubscriber<ValidAvatarsDataComponent>
	{
		// Token: 0x060010A0 RID: 4256 RVA: 0x000520D0 File Offset: 0x000502D0
		// Note: this type is marked as 'beforefieldinit'.
		static ValidAvatarsRenderer()
		{
			Il2CppClassPointerStore<ValidAvatarsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.datarenderers", "ValidAvatarsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidAvatarsRenderer>.NativeClassPtr);
			ValidAvatarsRenderer.NativeFieldInfoPtr_avatarSelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidAvatarsRenderer>.NativeClassPtr, "avatarSelectables");
			ValidAvatarsRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidAvatarsRenderer>.NativeClassPtr, 100665623);
			ValidAvatarsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidAvatarsRenderer>.NativeClassPtr, 100665624);
			ValidAvatarsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidAvatarsRenderer>.NativeClassPtr, 100665625);
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00052150 File Offset: 0x00050350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514137, XrefRangeEnd = 514166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValidAvatarsRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0005218C File Offset: 0x0005038C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514166, XrefRangeEnd = 514206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValidAvatarsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x000521C8 File Offset: 0x000503C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 514206, XrefRangeEnd = 514209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidAvatarsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidAvatarsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidAvatarsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0000A09E File Offset: 0x0000829E
		public ValidAvatarsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x00052204 File Offset: 0x00050404
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x0000A0A7 File Offset: 0x000082A7
		public unsafe Il2CppReferenceArray<ValidAvatarsRenderer.AvatarSelectablePair> avatarSelectables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidAvatarsRenderer.NativeFieldInfoPtr_avatarSelectables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValidAvatarsRenderer.AvatarSelectablePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidAvatarsRenderer.NativeFieldInfoPtr_avatarSelectables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeFieldInfoPtr_avatarSelectables;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000371 RID: 881
		[Serializable]
		public class AvatarSelectablePair : Object
		{
			// Token: 0x06002979 RID: 10617 RVA: 0x000A4914 File Offset: 0x000A2B14
			// Note: this type is marked as 'beforefieldinit'.
			static AvatarSelectablePair()
			{
				Il2CppClassPointerStore<ValidAvatarsRenderer.AvatarSelectablePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValidAvatarsRenderer>.NativeClassPtr, "AvatarSelectablePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidAvatarsRenderer.AvatarSelectablePair>.NativeClassPtr);
				ValidAvatarsRenderer.AvatarSelectablePair.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidAvatarsRenderer.AvatarSelectablePair>.NativeClassPtr, "Avatar");
				ValidAvatarsRenderer.AvatarSelectablePair.NativeFieldInfoPtr_Toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidAvatarsRenderer.AvatarSelectablePair>.NativeClassPtr, "Toggle");
				ValidAvatarsRenderer.AvatarSelectablePair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidAvatarsRenderer.AvatarSelectablePair>.NativeClassPtr, 100665626);
			}

			// Token: 0x0600297A RID: 10618 RVA: 0x000A497C File Offset: 0x000A2B7C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AvatarSelectablePair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidAvatarsRenderer.AvatarSelectablePair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidAvatarsRenderer.AvatarSelectablePair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600297B RID: 10619 RVA: 0x000156AF File Offset: 0x000138AF
			public AvatarSelectablePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BAA RID: 2986
			// (get) Token: 0x0600297C RID: 10620 RVA: 0x000A49B8 File Offset: 0x000A2BB8
			// (set) Token: 0x0600297D RID: 10621 RVA: 0x000156B8 File Offset: 0x000138B8
			public unsafe string Avatar
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidAvatarsRenderer.AvatarSelectablePair.NativeFieldInfoPtr_Avatar);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidAvatarsRenderer.AvatarSelectablePair.NativeFieldInfoPtr_Avatar), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000BAB RID: 2987
			// (get) Token: 0x0600297E RID: 10622 RVA: 0x000A49E0 File Offset: 0x000A2BE0
			// (set) Token: 0x0600297F RID: 10623 RVA: 0x000156D7 File Offset: 0x000138D7
			public unsafe Toggle Toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidAvatarsRenderer.AvatarSelectablePair.NativeFieldInfoPtr_Toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidAvatarsRenderer.AvatarSelectablePair.NativeFieldInfoPtr_Toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019E7 RID: 6631
			private static readonly IntPtr NativeFieldInfoPtr_Avatar;

			// Token: 0x040019E8 RID: 6632
			private static readonly IntPtr NativeFieldInfoPtr_Toggle;

			// Token: 0x040019E9 RID: 6633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000372 RID: 882
		[ObfuscatedName("boardgames.datarenderers.ValidAvatarsRenderer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002980 RID: 10624 RVA: 0x000A4A10 File Offset: 0x000A2C10
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ValidAvatarsRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValidAvatarsRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidAvatarsRenderer.__c>.NativeClassPtr);
				ValidAvatarsRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidAvatarsRenderer.__c>.NativeClassPtr, "<>9");
				ValidAvatarsRenderer.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidAvatarsRenderer.__c>.NativeClassPtr, "<>9__3_0");
				ValidAvatarsRenderer.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidAvatarsRenderer.__c>.NativeClassPtr, "<>9__3_1");
				ValidAvatarsRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidAvatarsRenderer.__c>.NativeClassPtr, 100665628);
				ValidAvatarsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__3_0_Internal_Boolean_AvatarSelectablePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidAvatarsRenderer.__c>.NativeClassPtr, 100665629);
				ValidAvatarsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__3_1_Internal_Boolean_AvatarSelectablePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidAvatarsRenderer.__c>.NativeClassPtr, 100665630);
			}

			// Token: 0x06002981 RID: 10625 RVA: 0x000A4AB4 File Offset: 0x000A2CB4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidAvatarsRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidAvatarsRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002982 RID: 10626 RVA: 0x000A4AF0 File Offset: 0x000A2CF0
			[CallerCount(0)]
			public unsafe bool _dirtyUpdate_b__3_0(ValidAvatarsRenderer.AvatarSelectablePair avatar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidAvatarsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__3_0_Internal_Boolean_AvatarSelectablePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002983 RID: 10627 RVA: 0x000A4B40 File Offset: 0x000A2D40
			[CallerCount(0)]
			public unsafe bool _dirtyUpdate_b__3_1(ValidAvatarsRenderer.AvatarSelectablePair avatar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidAvatarsRenderer.__c.NativeMethodInfoPtr__dirtyUpdate_b__3_1_Internal_Boolean_AvatarSelectablePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002984 RID: 10628 RVA: 0x000156F6 File Offset: 0x000138F6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BAC RID: 2988
			// (get) Token: 0x06002985 RID: 10629 RVA: 0x000A4B90 File Offset: 0x000A2D90
			// (set) Token: 0x06002986 RID: 10630 RVA: 0x000156FF File Offset: 0x000138FF
			public unsafe static ValidAvatarsRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValidAvatarsRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidAvatarsRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValidAvatarsRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BAD RID: 2989
			// (get) Token: 0x06002987 RID: 10631 RVA: 0x000A4BB8 File Offset: 0x000A2DB8
			// (set) Token: 0x06002988 RID: 10632 RVA: 0x00015711 File Offset: 0x00013911
			public unsafe static Func<ValidAvatarsRenderer.AvatarSelectablePair, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValidAvatarsRenderer.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValidAvatarsRenderer.AvatarSelectablePair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValidAvatarsRenderer.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BAE RID: 2990
			// (get) Token: 0x06002989 RID: 10633 RVA: 0x000A4BE0 File Offset: 0x000A2DE0
			// (set) Token: 0x0600298A RID: 10634 RVA: 0x00015723 File Offset: 0x00013923
			public unsafe static Func<ValidAvatarsRenderer.AvatarSelectablePair, bool> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ValidAvatarsRenderer.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValidAvatarsRenderer.AvatarSelectablePair, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ValidAvatarsRenderer.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019EA RID: 6634
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040019EB RID: 6635
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040019EC RID: 6636
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x040019ED RID: 6637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040019EE RID: 6638
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__3_0_Internal_Boolean_AvatarSelectablePair_0;

			// Token: 0x040019EF RID: 6639
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__3_1_Internal_Boolean_AvatarSelectablePair_0;
		}
	}
}
