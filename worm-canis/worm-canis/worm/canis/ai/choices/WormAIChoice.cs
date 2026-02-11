using System;
using Canis.entities.ai;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.abilities;
using worm.canis.entities;

namespace worm.canis.ai.choices
{
	// Token: 0x0200021F RID: 543
	public class WormAIChoice : AIChoice
	{
		// Token: 0x060017D9 RID: 6105 RVA: 0x000B5700 File Offset: 0x000B3900
		// Note: this type is marked as 'beforefieldinit'.
		static WormAIChoice()
		{
			Il2CppClassPointerStore<WormAIChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.ai.choices", "WormAIChoice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIChoice>.NativeClassPtr);
			WormAIChoice.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoice>.NativeClassPtr, "Ability");
			WormAIChoice.NativeFieldInfoPtr_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoice>.NativeClassPtr, "Context");
			WormAIChoice.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoice>.NativeClassPtr, "value");
			WormAIChoice.NativeMethodInfoPtr_get_Player_Public_get_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoice>.NativeClassPtr, 100667327);
			WormAIChoice.NativeMethodInfoPtr_get_AIProfile_Public_get_WormAIProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoice>.NativeClassPtr, 100667328);
			WormAIChoice.NativeMethodInfoPtr_get_Value_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoice>.NativeClassPtr, 100667329);
			WormAIChoice.NativeMethodInfoPtr_set_Value_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoice>.NativeClassPtr, 100667330);
			WormAIChoice.NativeMethodInfoPtr__ctor_Protected_Void_Double_WormAbilityDefinition_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoice>.NativeClassPtr, 100667331);
			WormAIChoice.NativeMethodInfoPtr_SetRank_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoice>.NativeClassPtr, 100667332);
			WormAIChoice.NativeMethodInfoPtr_SendResponse_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoice>.NativeClassPtr, 100667333);
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x000B57F8 File Offset: 0x000B39F8
		public unsafe WormPlayer Player
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 129473, RefRangeEnd = 129497, XrefRangeStart = 129473, XrefRangeEnd = 129473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoice.NativeMethodInfoPtr_get_Player_Public_get_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x000B5838 File Offset: 0x000B3A38
		public unsafe WormAIProfile AIProfile
		{
			[CallerCount(55)]
			[CachedScanResults(RefRangeStart = 129497, RefRangeEnd = 129552, XrefRangeStart = 129497, XrefRangeEnd = 129497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoice.NativeMethodInfoPtr_get_AIProfile_Public_get_WormAIProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIProfile>(intPtr3) : null;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x000B5878 File Offset: 0x000B3A78
		// (set) Token: 0x060017DD RID: 6109 RVA: 0x000B58B4 File Offset: 0x000B3AB4
		public unsafe double Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoice.NativeMethodInfoPtr_get_Value_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 129566, RefRangeEnd = 129574, XrefRangeStart = 129552, XrefRangeEnd = 129566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoice.NativeMethodInfoPtr_set_Value_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x000B58F4 File Offset: 0x000B3AF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 129581, RefRangeEnd = 129585, XrefRangeStart = 129574, XrefRangeEnd = 129581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAIChoice(double value, WormAbilityDefinition ability, WormAIChoiceContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIChoice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ability);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoice.NativeMethodInfoPtr__ctor_Protected_Void_Double_WormAbilityDefinition_WormAIChoiceContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x000B5960 File Offset: 0x000B3B60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129586, RefRangeEnd = 129587, XrefRangeStart = 129585, XrefRangeEnd = 129586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void SetRank(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoice.NativeMethodInfoPtr_SetRank_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x000B59A0 File Offset: 0x000B3BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129587, XrefRangeEnd = 129595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAIChoice.NativeMethodInfoPtr_SendResponse_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0000A630 File Offset: 0x00008830
		public WormAIChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x000B59DC File Offset: 0x000B3BDC
		// (set) Token: 0x060017E3 RID: 6115 RVA: 0x0000A639 File Offset: 0x00008839
		public unsafe WormAbilityDefinition Ability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoice.NativeFieldInfoPtr_Ability);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoice.NativeFieldInfoPtr_Ability), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x000B5A0C File Offset: 0x000B3C0C
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x0000A658 File Offset: 0x00008858
		public unsafe WormAIChoiceContext Context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoice.NativeFieldInfoPtr_Context);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoice.NativeFieldInfoPtr_Context), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x000B5A3C File Offset: 0x000B3C3C
		// (set) Token: 0x060017E7 RID: 6119 RVA: 0x0000A677 File Offset: 0x00008877
		public unsafe double value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoice.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoice.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeFieldInfoPtr_Ability;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeFieldInfoPtr_Context;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_get_Player_Public_get_WormPlayer_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_get_AIProfile_Public_get_WormAIProfile_0;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Double_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Double_0;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Double_WormAbilityDefinition_WormAIChoiceContext_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr_SetRank_Public_Void_Int32_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr_SendResponse_Public_Virtual_Void_0;
	}
}
