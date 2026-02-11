using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using lotus;
using TMPro;
using UnityEngine;

namespace worm.match.components
{
	// Token: 0x020001AD RID: 429
	public class BaronPlayerInfoView : ObserveOnce
	{
		// Token: 0x060012F7 RID: 4855 RVA: 0x00051B28 File Offset: 0x0004FD28
		// Note: this type is marked as 'beforefieldinit'.
		static BaronPlayerInfoView()
		{
			Il2CppClassPointerStore<BaronPlayerInfoView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "BaronPlayerInfoView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaronPlayerInfoView>.NativeClassPtr);
			BaronPlayerInfoView.NativeFieldInfoPtr_extraAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaronPlayerInfoView>.NativeClassPtr, "extraAbility");
			BaronPlayerInfoView.NativeFieldInfoPtr_spacersFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaronPlayerInfoView>.NativeClassPtr, "spacersFaction");
			BaronPlayerInfoView.NativeFieldInfoPtr_emperorFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaronPlayerInfoView>.NativeClassPtr, "emperorFaction");
			BaronPlayerInfoView.NativeFieldInfoPtr_beneFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaronPlayerInfoView>.NativeClassPtr, "beneFaction");
			BaronPlayerInfoView.NativeFieldInfoPtr_fremenFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaronPlayerInfoView>.NativeClassPtr, "fremenFaction");
			BaronPlayerInfoView.NativeFieldInfoPtr_abilityFactionsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaronPlayerInfoView>.NativeClassPtr, "abilityFactionsText");
			BaronPlayerInfoView.NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaronPlayerInfoView>.NativeClassPtr, 100665884);
			BaronPlayerInfoView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaronPlayerInfoView>.NativeClassPtr, 100665885);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00051BF8 File Offset: 0x0004FDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712582, XrefRangeEnd = 712643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaronPlayerInfoView.NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00051C40 File Offset: 0x0004FE40
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaronPlayerInfoView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaronPlayerInfoView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaronPlayerInfoView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0000BCC9 File Offset: 0x00009EC9
		public BaronPlayerInfoView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00051C7C File Offset: 0x0004FE7C
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x0000BCD2 File Offset: 0x00009ED2
		public unsafe GameObject extraAbility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaronPlayerInfoView.NativeFieldInfoPtr_extraAbility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaronPlayerInfoView.NativeFieldInfoPtr_extraAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00051CAC File Offset: 0x0004FEAC
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x0000BCF1 File Offset: 0x00009EF1
		public unsafe GameObject spacersFaction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaronPlayerInfoView.NativeFieldInfoPtr_spacersFaction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaronPlayerInfoView.NativeFieldInfoPtr_spacersFaction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00051CDC File Offset: 0x0004FEDC
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x0000BD10 File Offset: 0x00009F10
		public unsafe GameObject emperorFaction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaronPlayerInfoView.NativeFieldInfoPtr_emperorFaction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaronPlayerInfoView.NativeFieldInfoPtr_emperorFaction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x00051D0C File Offset: 0x0004FF0C
		// (set) Token: 0x06001302 RID: 4866 RVA: 0x0000BD2F File Offset: 0x00009F2F
		public unsafe GameObject beneFaction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaronPlayerInfoView.NativeFieldInfoPtr_beneFaction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaronPlayerInfoView.NativeFieldInfoPtr_beneFaction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x00051D3C File Offset: 0x0004FF3C
		// (set) Token: 0x06001304 RID: 4868 RVA: 0x0000BD4E File Offset: 0x00009F4E
		public unsafe GameObject fremenFaction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaronPlayerInfoView.NativeFieldInfoPtr_fremenFaction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaronPlayerInfoView.NativeFieldInfoPtr_fremenFaction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x00051D6C File Offset: 0x0004FF6C
		// (set) Token: 0x06001306 RID: 4870 RVA: 0x0000BD6D File Offset: 0x00009F6D
		public unsafe TMP_Text abilityFactionsText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaronPlayerInfoView.NativeFieldInfoPtr_abilityFactionsText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaronPlayerInfoView.NativeFieldInfoPtr_abilityFactionsText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeFieldInfoPtr_extraAbility;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeFieldInfoPtr_spacersFaction;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeFieldInfoPtr_emperorFaction;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeFieldInfoPtr_beneFaction;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeFieldInfoPtr_fremenFaction;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeFieldInfoPtr_abilityFactionsText;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003C2 RID: 962
		[ObfuscatedName("worm.match.components.BaronPlayerInfoView+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060026D9 RID: 9945 RVA: 0x0008E038 File Offset: 0x0008C238
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BaronPlayerInfoView.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaronPlayerInfoView>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaronPlayerInfoView.__c>.NativeClassPtr);
				BaronPlayerInfoView.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaronPlayerInfoView.__c>.NativeClassPtr, "<>9");
				BaronPlayerInfoView.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaronPlayerInfoView.__c>.NativeClassPtr, "<>9__6_0");
				BaronPlayerInfoView.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaronPlayerInfoView.__c>.NativeClassPtr, 100665887);
				BaronPlayerInfoView.__c.NativeMethodInfoPtr__Initialize_b__6_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaronPlayerInfoView.__c>.NativeClassPtr, 100665888);
			}

			// Token: 0x060026DA RID: 9946 RVA: 0x0008E0B4 File Offset: 0x0008C2B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaronPlayerInfoView.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaronPlayerInfoView.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060026DB RID: 9947 RVA: 0x0008E0F0 File Offset: 0x0008C2F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 712575, XrefRangeEnd = 712582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Initialize_b__6_0(EntityComponent e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaronPlayerInfoView.__c.NativeMethodInfoPtr__Initialize_b__6_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060026DC RID: 9948 RVA: 0x000156A3 File Offset: 0x000138A3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ACC RID: 2764
			// (get) Token: 0x060026DD RID: 9949 RVA: 0x0008E140 File Offset: 0x0008C340
			// (set) Token: 0x060026DE RID: 9950 RVA: 0x000156AC File Offset: 0x000138AC
			public unsafe static BaronPlayerInfoView.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BaronPlayerInfoView.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaronPlayerInfoView.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BaronPlayerInfoView.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ACD RID: 2765
			// (get) Token: 0x060026DF RID: 9951 RVA: 0x0008E168 File Offset: 0x0008C368
			// (set) Token: 0x060026E0 RID: 9952 RVA: 0x000156BE File Offset: 0x000138BE
			public unsafe static Func<EntityComponent, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BaronPlayerInfoView.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BaronPlayerInfoView.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400165E RID: 5726
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400165F RID: 5727
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04001660 RID: 5728
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001661 RID: 5729
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__6_0_Internal_Boolean_EntityComponent_0;
		}
	}
}
