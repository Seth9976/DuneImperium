using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace worm.match.components
{
	// Token: 0x020001E1 RID: 481
	public class WormCustomChoices : MonoBehaviour
	{
		// Token: 0x06001541 RID: 5441 RVA: 0x000589FC File Offset: 0x00056BFC
		// Note: this type is marked as 'beforefieldinit'.
		static WormCustomChoices()
		{
			Il2CppClassPointerStore<WormCustomChoices>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormCustomChoices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCustomChoices>.NativeClassPtr);
			WormCustomChoices.NativeFieldInfoPtr_choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoices>.NativeClassPtr, "choices");
			WormCustomChoices.NativeMethodInfoPtr_Init_Public_Void_IList_1_LocalizableText_Action_2_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoices>.NativeClassPtr, 100666234);
			WormCustomChoices.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoices>.NativeClassPtr, 100666235);
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00058A68 File Offset: 0x00056C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 715138, RefRangeEnd = 715139, XrefRangeStart = 715079, XrefRangeEnd = 715138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(IList<LocalizableText> choicesText, Action<bool, int> onToggleChanged)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(choicesText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onToggleChanged);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoices.NativeMethodInfoPtr_Init_Public_Void_IList_1_LocalizableText_Action_2_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x00058ABC File Offset: 0x00056CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715139, XrefRangeEnd = 715147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCustomChoices()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCustomChoices>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoices.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0000CED9 File Offset: 0x0000B0D9
		public WormCustomChoices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x00058AF8 File Offset: 0x00056CF8
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x0000CEE2 File Offset: 0x0000B0E2
		public unsafe Il2CppReferenceArray<WormCustomChoices.Choice> choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoices.NativeFieldInfoPtr_choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormCustomChoices.Choice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoices.NativeFieldInfoPtr_choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeFieldInfoPtr_choices;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_IList_1_LocalizableText_Action_2_Boolean_Int32_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003E2 RID: 994
		[Serializable]
		public sealed class Choice : ValueType
		{
			// Token: 0x06002863 RID: 10339 RVA: 0x00092858 File Offset: 0x00090A58
			// Note: this type is marked as 'beforefieldinit'.
			static Choice()
			{
				Il2CppClassPointerStore<WormCustomChoices.Choice>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormCustomChoices>.NativeClassPtr, "Choice");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCustomChoices.Choice>.NativeClassPtr);
				WormCustomChoices.Choice.NativeFieldInfoPtr_toggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoices.Choice>.NativeClassPtr, "toggle");
				WormCustomChoices.Choice.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoices.Choice>.NativeClassPtr, "text");
			}

			// Token: 0x06002864 RID: 10340 RVA: 0x00016269 File Offset: 0x00014469
			public Choice(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002865 RID: 10341 RVA: 0x00016272 File Offset: 0x00014472
			public Choice()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCustomChoices.Choice>.NativeClassPtr))
			{
			}

			// Token: 0x17000B4F RID: 2895
			// (get) Token: 0x06002866 RID: 10342 RVA: 0x000928AC File Offset: 0x00090AAC
			// (set) Token: 0x06002867 RID: 10343 RVA: 0x00016284 File Offset: 0x00014484
			public unsafe Toggle toggle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoices.Choice.NativeFieldInfoPtr_toggle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoices.Choice.NativeFieldInfoPtr_toggle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B50 RID: 2896
			// (get) Token: 0x06002868 RID: 10344 RVA: 0x000928DC File Offset: 0x00090ADC
			// (set) Token: 0x06002869 RID: 10345 RVA: 0x000162A3 File Offset: 0x000144A3
			public unsafe TMP_Text text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoices.Choice.NativeFieldInfoPtr_text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoices.Choice.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001743 RID: 5955
			private static readonly IntPtr NativeFieldInfoPtr_toggle;

			// Token: 0x04001744 RID: 5956
			private static readonly IntPtr NativeFieldInfoPtr_text;
		}

		// Token: 0x020003E3 RID: 995
		[ObfuscatedName("worm.match.components.WormCustomChoices+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600286A RID: 10346 RVA: 0x0009290C File Offset: 0x00090B0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormCustomChoices.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormCustomChoices>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCustomChoices.__c__DisplayClass2_0>.NativeClassPtr);
				WormCustomChoices.__c__DisplayClass2_0.NativeFieldInfoPtr_onToggleChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoices.__c__DisplayClass2_0>.NativeClassPtr, "onToggleChanged");
				WormCustomChoices.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoices.__c__DisplayClass2_0>.NativeClassPtr, 100666236);
			}

			// Token: 0x0600286B RID: 10347 RVA: 0x00092960 File Offset: 0x00090B60
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCustomChoices.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoices.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600286C RID: 10348 RVA: 0x000162C2 File Offset: 0x000144C2
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B51 RID: 2897
			// (get) Token: 0x0600286D RID: 10349 RVA: 0x0009299C File Offset: 0x00090B9C
			// (set) Token: 0x0600286E RID: 10350 RVA: 0x000162CB File Offset: 0x000144CB
			public unsafe Action<bool, int> onToggleChanged
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoices.__c__DisplayClass2_0.NativeFieldInfoPtr_onToggleChanged);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoices.__c__DisplayClass2_0.NativeFieldInfoPtr_onToggleChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001745 RID: 5957
			private static readonly IntPtr NativeFieldInfoPtr_onToggleChanged;

			// Token: 0x04001746 RID: 5958
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003E4 RID: 996
		[ObfuscatedName("worm.match.components.WormCustomChoices+<>c__DisplayClass2_1")]
		public sealed class __c__DisplayClass2_1 : global::Il2CppSystem.Object
		{
			// Token: 0x0600286F RID: 10351 RVA: 0x000929CC File Offset: 0x00090BCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_1()
			{
				Il2CppClassPointerStore<WormCustomChoices.__c__DisplayClass2_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormCustomChoices>.NativeClassPtr, "<>c__DisplayClass2_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCustomChoices.__c__DisplayClass2_1>.NativeClassPtr);
				WormCustomChoices.__c__DisplayClass2_1.NativeFieldInfoPtr_toggleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoices.__c__DisplayClass2_1>.NativeClassPtr, "toggleIndex");
				WormCustomChoices.__c__DisplayClass2_1.NativeFieldInfoPtr_field_Public___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCustomChoices.__c__DisplayClass2_1>.NativeClassPtr, "CS$<>8__locals1");
				WormCustomChoices.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoices.__c__DisplayClass2_1>.NativeClassPtr, 100666237);
				WormCustomChoices.__c__DisplayClass2_1.NativeMethodInfoPtr__Init_b__0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCustomChoices.__c__DisplayClass2_1>.NativeClassPtr, 100666238);
			}

			// Token: 0x06002870 RID: 10352 RVA: 0x00092A48 File Offset: 0x00090C48
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCustomChoices.__c__DisplayClass2_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoices.__c__DisplayClass2_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002871 RID: 10353 RVA: 0x00092A84 File Offset: 0x00090C84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715078, XrefRangeEnd = 715079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Init_b__0(bool isOn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isOn;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCustomChoices.__c__DisplayClass2_1.NativeMethodInfoPtr__Init_b__0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002872 RID: 10354 RVA: 0x000162EA File Offset: 0x000144EA
			public __c__DisplayClass2_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B52 RID: 2898
			// (get) Token: 0x06002873 RID: 10355 RVA: 0x00092AC4 File Offset: 0x00090CC4
			// (set) Token: 0x06002874 RID: 10356 RVA: 0x000162F3 File Offset: 0x000144F3
			public unsafe int toggleIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoices.__c__DisplayClass2_1.NativeFieldInfoPtr_toggleIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoices.__c__DisplayClass2_1.NativeFieldInfoPtr_toggleIndex)) = value;
				}
			}

			// Token: 0x17000B53 RID: 2899
			// (get) Token: 0x06002875 RID: 10357 RVA: 0x00092AEC File Offset: 0x00090CEC
			// (set) Token: 0x06002876 RID: 10358 RVA: 0x0001630E File Offset: 0x0001450E
			public unsafe WormCustomChoices.__c__DisplayClass2_0 field_Public___c__DisplayClass2_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoices.__c__DisplayClass2_1.NativeFieldInfoPtr_field_Public___c__DisplayClass2_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormCustomChoices.__c__DisplayClass2_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCustomChoices.__c__DisplayClass2_1.NativeFieldInfoPtr_field_Public___c__DisplayClass2_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001747 RID: 5959
			private static readonly IntPtr NativeFieldInfoPtr_toggleIndex;

			// Token: 0x04001748 RID: 5960
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass2_0_0;

			// Token: 0x04001749 RID: 5961
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400174A RID: 5962
			private static readonly IntPtr NativeMethodInfoPtr__Init_b__0_Internal_Void_Boolean_0;
		}
	}
}
